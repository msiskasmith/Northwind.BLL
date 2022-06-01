using Northwind.BLL.Helpers;
using Northwind.DAL.EFModels;
using Northwind.DAL.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Northwind.BLL.Services
{
    public class ProductCategoryService : IServiceBase<ProductCategory, short>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(ProductCategory productCategory)
        {
            productCategory.ProductCategoryName = StringManipulator.RemoveExtraSpaces(productCategory.ProductCategoryName);

            var isFound = await _unitOfWork.ProductCategories.AnyAsync(p => p.ProductCategoryName.ToLower() == productCategory.ProductCategoryName.ToLower());

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse(
                    "The product category name already exists, please try a different name.");
            }

            await _unitOfWork.ProductCategories.AddAsync(productCategory);

            var isCreated = await _unitOfWork.SaveChanges() > 0;

            if (isCreated)
            {
                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetValidationErrorResponse("Please make sure all required field are filled.");
        }

        public async Task<ProcessedResponse> GetAsync(short productCategoryId)
        {
                 
            var productCategory = await _unitOfWork.ProductCategories.GetAsync(p => p.ProductCategoryId == productCategoryId);

            if (productCategory == null) return ResponseProcessor.GetRecordNotFoundResponse();

            return ResponseProcessor.GetSuccessResponse(productCategory);       
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var productCategories = await _unitOfWork.ProductCategories.GetListAsync(pageNumber, numberOfRows);

            if (productCategories == null) return ResponseProcessor.GetRecordNotFoundResponse(
                "There are no Product categories on record.");
            
            return ResponseProcessor.GetSuccessResponse(productCategories);            
        }

        public async Task<ProcessedResponse> GetListAsync(Expression<Func<ProductCategory, bool>> expression 
            ,int pageNumber, int numberOfRows
            )
        {
            var productCategories = await _unitOfWork.ProductCategories.GetListAsync(pageNumber, numberOfRows, expression);

            if (productCategories == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "There are no product categories matching your search on record.");
            }

            return ResponseProcessor.GetSuccessResponse(productCategories);
        }

        public async Task<ProcessedResponse> UpdateAsync(ProductCategory productCategory)
        {
            productCategory.ProductCategoryName = StringManipulator.RemoveExtraSpaces(productCategory.ProductCategoryName);

            var unChangedProductCategory = await _unitOfWork.ProductCategories
                    .GetAsync(p => p.ProductCategoryId == productCategory.ProductCategoryId);

            if (unChangedProductCategory is not null)
            {               
                // Check if the ProductCategory Name is being changed
                // Prevent user from changing name to pre-existing name
                if(unChangedProductCategory.ProductCategoryName != productCategory.ProductCategoryName)
                {
                    var isFound = await _unitOfWork.ProductCategories.AnyAsync(
                        p => p.ProductCategoryName.ToLower() == productCategory.ProductCategoryName.ToLower());

                    if (isFound)
                    {
                        return ResponseProcessor.GetValidationErrorResponse(
                            "The Product Category Name already exists, please choose a different name");
                    }
                }

                await _unitOfWork.ProductCategories.UpdateAsync(productCategory);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The product category you are trying to update does not exist.");
   
        }

        public async Task<ProcessedResponse> DeleteAsync(short productCategoryId)
        {
            var productCategory = await _unitOfWork.ProductCategories.GetAsync(p => p.ProductCategoryId == productCategoryId);

            if (productCategory is not null)
            {
                var isFound = await _unitOfWork.Products.AnyAsync(p => p.ProductCategoryId == productCategoryId); 
                
                if(isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The product category you are trying to delete is tied to a product and cannot be delete.");
                }

                await _unitOfWork.ProductCategories.DeleteAsync(productCategory);
                
                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The product category you are trying to delete does not exist.");
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<ProductCategory, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.ProductCategories.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}