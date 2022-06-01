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
    public class RegionService : IServiceBase<Region, short>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(Region region)
        {
            region.RegionDescription = StringManipulator.RemoveExtraSpaces(region.RegionDescription);

            var isFound = await _unitOfWork.Regions.AnyAsync(
                r => r.RegionDescription.ToLower() == region.RegionDescription.ToLower());

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse(
                    "The Region Description already exists.");
            }

            await _unitOfWork.Regions.AddAsync(region);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();
        }

        public async Task<ProcessedResponse> GetAsync(short id)
        {
            var region = await _unitOfWork.Regions.GetAsync(r => r.RegionId == id);

            if (region == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "The requested region does not exist.");
            }

            return ResponseProcessor.GetSuccessResponse(region);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var regions = await _unitOfWork.Regions.GetListAsync(pageNumber, numberOfRows);

            if (regions == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no region records.");
            }


            return ResponseProcessor.GetSuccessResponse(regions);
        }

        public async Task<ProcessedResponse> GetListAsync(
            Expression<Func<Region, bool>> expression, int pageNumber, int numberOfRows)
        {
            var regions = await _unitOfWork.Regions.GetListAsync(pageNumber, numberOfRows, expression);

            if (regions == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "There are not regions matching your search");
            }

            return ResponseProcessor.GetSuccessResponse(regions);
        }

        public async Task<ProcessedResponse> UpdateAsync(Region region)
        {
            region.RegionDescription = StringManipulator.RemoveExtraSpaces(region.RegionDescription);

            var unChangedRegion = await _unitOfWork.Regions.GetAsync(r => r.RegionId == region.RegionId);

            if (unChangedRegion is not null)
            {
                if (unChangedRegion.RegionDescription != region.RegionDescription)
                {
                    var isFound = await _unitOfWork.Regions.AnyAsync(r => r.RegionDescription.ToLower() == region.RegionDescription.ToLower());

                    if (isFound)
                    {
                        return ResponseProcessor.GetValidationErrorResponse(
                            "The Region Description already exists, please use a different description.");
                    }
                }

                await _unitOfWork.Regions.UpdateAsync(region);

                var isUpdated = await _unitOfWork.SaveChanges() > 0;

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The region you are trying to update does not exist.");

        }

        public async Task<ProcessedResponse> DeleteAsync(short regionId)
        {
            var region = await _unitOfWork.Regions.GetAsync(r => r.RegionId == regionId);

            if (region is not null)
            {
                // Customers, Employees Orders Suppliers
                var isFound = await _unitOfWork.Orders.AnyAsync(o => o.OrderShipRegionId == regionId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The region you are trying to delete is tied to an order and cannot be deleted.");
                }

                isFound = await _unitOfWork.Customers.AnyAsync(c => c.RegionId == regionId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The region you are trying to delete is tied to a customer and cannot be deleted.");
                }

                isFound = await _unitOfWork.Employees.AnyAsync(e => e.RegionId == regionId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The region you are trying to delete is tied to an employee and cannot be deleted.");
                }

                isFound = await _unitOfWork.Suppliers.AnyAsync(s => s.RegionId == regionId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The region you are trying to delete is tied to a supplier and cannot be deleted.");
                }

                await _unitOfWork.Regions.DeleteAsync(region);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse("The region you are trying do delete does not exist.");
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<Region, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.Regions.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}
