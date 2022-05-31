using Northwind.BLL.Helpers;
using Northwind.DAL.EFModels;
using Northwind.DAL.Repositories;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Northwind.BLL.Services
{
    public class ProductService : IServiceBase<Product, short>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(Product product)
        {
            var isFound = await _unitOfWork.Products.AnyAsync(
                p => p.ProductName.ToLower() == product.ProductName.ToLower());

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse("The Product Name already exists.");
            }

            await _unitOfWork.Products.AddAsync(product);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();

        }

        public async Task<ProcessedResponse> GetAsync(short productId)
        {
            var product = await _unitOfWork.Products.GetAsync(c => c.ProductId == productId);

            if (product == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("The requested product does not exist.");
            }
                
            return ResponseProcessor.GetSuccessResponse(product);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var products = await _unitOfWork.Products.GetListAsync(pageNumber, numberOfRows);

            if (products == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no product records.");
            }
                

            return ResponseProcessor.GetSuccessResponse(products);
        }

        public async Task<ProcessedResponse> GetListAsync(
            Expression<Func<Product, bool>> expression, int pageNumber, int numberOfRows)
        {
            var products = await _unitOfWork.Products.GetListAsync(pageNumber, numberOfRows, expression);

            if (products == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "There are not products matching your search");
            }
                
            return ResponseProcessor.GetSuccessResponse(products);
        }

        public async Task<ProcessedResponse> UpdateAsync(Product product)
        {
            var unChangedProduct = await _unitOfWork.Products.GetAsync(c => c.ProductId == product.ProductId);

            if (unChangedProduct is not null)
            {
                if (unChangedProduct.ProductName != product.ProductName)
                {
                    var isFound = await _unitOfWork.Products.AnyAsync(c => c.ProductName.ToLower() == product.ProductName.ToLower());

                    if (isFound)
                    {
                        return ResponseProcessor.GetValidationErrorResponse(
                            "The Product Name already exists, please use a different name.");
                    }
                }

                await _unitOfWork.Products.UpdateAsync(product);   

                var isUpdated = await _unitOfWork.SaveChanges() > 0;

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The product you are trying to update does not exist.");

        }

        public async Task<ProcessedResponse> DeleteAsync(short productId)
        {
            var product = await _unitOfWork.Products.GetAsync(c => c.ProductId == productId);

            if (product is not null)
            {
                var isFound = await _unitOfWork.OrderDetails.AnyAsync(o => o.ProductId == productId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The product you are trying to delete is tied to an order detail and cannot be deleted.");
                }

                await _unitOfWork.Products.DeleteAsync(product);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse("The product you are trying do delete does not exist.");
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<Product, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.Products.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}
