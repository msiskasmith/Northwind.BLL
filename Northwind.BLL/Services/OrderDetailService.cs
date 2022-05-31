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
    public class OrderDetailService : IServiceBase<OrderDetail, short>
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(OrderDetail orderDetail)
        {
            await _unitOfWork.OrderDetails.AddAsync(orderDetail);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();

        }

        public async Task<ProcessedResponse> GetAsync(short orderDetailId)
        {
            var orderDetail = await _unitOfWork.OrderDetails.GetOrderDetailAsync(c => c.OrderDetailId == orderDetailId);

            if (orderDetail == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("The requested Order Detail does not exist.");
            }               

            return ResponseProcessor.GetSuccessResponse(orderDetail);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var orderDetails = await _unitOfWork.OrderDetails.GetOrderDetailsAsync(pageNumber, numberOfRows);

            if (orderDetails == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no orders on record.");
            }
                
            return ResponseProcessor.GetSuccessResponse(orderDetails);
        }

        public async Task<ProcessedResponse> GetListAsync(
            Expression<Func<OrderDetail, bool>> expression, int pageNumber, int numberOfRows)
        {
            var orderDetails = await _unitOfWork.OrderDetails.GetOrderDetailsAsync(pageNumber, numberOfRows, expression);

            if (orderDetails == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse(
                    "There are no Order Details matching your search.");
            }
                
            return ResponseProcessor.GetSuccessResponse(orderDetails);
        }

        public async Task<ProcessedResponse> UpdateAsync(OrderDetail orderDetail)
        {
            var isFound = await _unitOfWork.OrderDetails.AnyAsync(o => o.OrderDetailId == orderDetail.OrderDetailId);

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse(
                    "Could not update the order, it does not exist.");
            }

            await _unitOfWork.OrderDetails.UpdateAsync(orderDetail);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();

        }

        public async Task<ProcessedResponse> DeleteAsync(short orderDetailId)
        {
            var orderDetail = await _unitOfWork.OrderDetails.GetAsync(o => o.OrderDetailId == orderDetailId);

            if (orderDetail is not null)
            {
                await _unitOfWork.OrderDetails.DeleteAsync(orderDetail);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The Order Detail does not exist.");
            
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<OrderDetail, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.OrderDetails.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}
