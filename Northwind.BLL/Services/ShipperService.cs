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
    public class ShipperService : IServiceBase<Shipper, short>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShipperService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(Shipper shipper)
        {
            var isFound = await _unitOfWork.Shippers.AnyAsync(
                s => s.ShipperName.ToLower() == shipper.ShipperName.ToLower());

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse("The Shipper Name already exists.");
            }

            await _unitOfWork.Shippers.AddAsync(shipper);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();
        }

        public async Task<ProcessedResponse> GetAsync(short id)
        {
            var shipper = await _unitOfWork.Shippers.GetAsync(s => s.ShipperId == id);

            if (shipper == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("The requested shipper does not exist.");
            }

            return ResponseProcessor.GetSuccessResponse(shipper);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var shippers = await _unitOfWork.Shippers.GetListAsync(pageNumber, numberOfRows);

            if (shippers == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no shipper records.");
            }


            return ResponseProcessor.GetSuccessResponse(shippers);
        }

        public async Task<ProcessedResponse> GetListAsync(
            Expression<Func<Shipper, bool>> expression, int pageNumber, int numberOfRows)
        {
            var shippers = await _unitOfWork.Shippers.GetListAsync(pageNumber, numberOfRows, expression);

            if (shippers == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "There are not shippers matching your search");
            }

            return ResponseProcessor.GetSuccessResponse(shippers);
        }

        public async Task<ProcessedResponse> UpdateAsync(Shipper shipper)
        {
            var unChangedShipper = await _unitOfWork.Shippers.GetAsync(
                s => s.ShipperId == shipper.ShipperId);

            if (unChangedShipper is not null)
            {
                if (unChangedShipper.ShipperName != shipper.ShipperName)
                {
                    var isFound = await _unitOfWork.Shippers.AnyAsync(
                        s => s.ShipperName.ToLower() == shipper.ShipperName.ToLower());

                    if (isFound)
                    {
                        return ResponseProcessor.GetValidationErrorResponse(
                            "The Shipper Name already exists, please use a different name.");
                    }
                }

                await _unitOfWork.Shippers.UpdateAsync(shipper);

                var isUpdated = await _unitOfWork.SaveChanges() > 0;

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The shipper you are trying to update does not exist.");

        }

        public async Task<ProcessedResponse> DeleteAsync(short shipperId)
        {
            var shipper = await _unitOfWork.Shippers.GetAsync(s => s.ShipperId == shipperId);

            if (shipper is not null)
            {
                var isFound = await _unitOfWork.Orders.AnyAsync(o => o.ShipperId == shipperId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The shipper you are trying to delete is tied to an order and cannot be deleted.");
                }

                await _unitOfWork.Shippers.DeleteAsync(shipper);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse("The shipper you are trying do delete does not exist.");
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<Shipper, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.Shippers.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}
