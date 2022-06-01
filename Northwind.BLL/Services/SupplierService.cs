using Northwind.BLL.Helpers;
using Northwind.DAL.EFModels;
using Northwind.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Services
{
    public class SupplierService : IServiceBase<Supplier, short>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SupplierService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(Supplier supplier)
        {
            supplier.SupplierName = StringManipulator.RemoveExtraSpaces(supplier.SupplierName);

            var isFound = await _unitOfWork.Suppliers.AnyAsync(
                s => s.SupplierName.ToLower() == supplier.SupplierName.ToLower());

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse(
                    "The Supplier Name already exists.");
            }

            await _unitOfWork.Suppliers.AddAsync(supplier);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();
        }

        public async Task<ProcessedResponse> GetAsync(short supplierId)
        {
            var supplier = await _unitOfWork.Suppliers.GetAsync(s => s.SupplierId == supplierId);

            if (supplier == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "The requested supplier does not exist.");
            }

            return ResponseProcessor.GetSuccessResponse(supplier);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var suppliers = await _unitOfWork.Suppliers.GetListAsync(pageNumber, numberOfRows);

            if (suppliers == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "There are no supplier records.");
            }


            return ResponseProcessor.GetSuccessResponse(suppliers);
        }

        public async Task<ProcessedResponse> GetListAsync(
            Expression<Func<Supplier, bool>> expression, int pageNumber, int numberOfRows)
        {
            var suppliers = await _unitOfWork.Suppliers.GetListAsync(pageNumber, numberOfRows, expression);

            if (suppliers == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "There are not suppliers matching your search");
            }

            return ResponseProcessor.GetSuccessResponse(suppliers);
        }

        public async Task<ProcessedResponse> UpdateAsync(Supplier supplier)
        {
            supplier.SupplierName = StringManipulator.RemoveExtraSpaces(supplier.SupplierName);

            var unChangedSupplier = await _unitOfWork.Suppliers.GetAsync(
                s => s.SupplierId == supplier.SupplierId);

            if (unChangedSupplier is not null)
            {
                if (unChangedSupplier.SupplierName != supplier.SupplierName)
                {
                    var isFound = await _unitOfWork.Suppliers.AnyAsync(
                        s => s.SupplierName.ToLower() == supplier.SupplierName.ToLower());

                    if (isFound)
                    {
                        return ResponseProcessor.GetValidationErrorResponse(
                            "The Supplier Name already exists, please use a different name.");
                    }
                }

                await _unitOfWork.Suppliers.UpdateAsync(supplier);  

                var isUpdated = await _unitOfWork.SaveChanges() > 0;

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The supplier you are trying to update does not exist.");

        }

        public async Task<ProcessedResponse> DeleteAsync(short supplierId)
        {
            var supplier = await _unitOfWork.Suppliers.GetAsync(s => s.SupplierId == supplierId);

            if (supplier is not null)
            {
                // Customers, Employees Orders Suppliers
                var isFound = await _unitOfWork.Products.AnyAsync(p => p.SupplierId == supplierId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The supplier you are trying to delete is tied to an order and cannot be deleted.");
                }

               
                await _unitOfWork.Suppliers.DeleteAsync(supplier);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The supplier you are trying do delete does not exist.");
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<Supplier, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.Suppliers.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}
