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
    public class OrderService : IServiceBase<Order, short>
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(Order order)
        {               
            await _unitOfWork.Orders.AddAsync(order);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();

        }

        public async Task<ProcessedResponse> GetAsync(short orderId)
        {
            var order = await _unitOfWork.Orders.GetOrderAsync(c => c.OrderId == orderId);

            if (order == null) return ResponseProcessor.GetRecordNotFoundResponse("The requested Order does not exist.");

            return ResponseProcessor.GetSuccessResponse(order);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var orders = await _unitOfWork.Orders.GetOrdersAsync(pageNumber, numberOfRows);

            if (orders == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no Orders on record.");
            }
               
            return ResponseProcessor.GetSuccessResponse(orders);
        }

        public async Task<ProcessedResponse> GetListAsync(Expression<Func<Order, bool>> expression, int pageNumber, int numberOfRows)
        {
            var orders = await _unitOfWork.Orders.GetOrdersAsync(pageNumber, numberOfRows, expression);

            if (orders == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no Orders matching your search.");
            }               

            return ResponseProcessor.GetSuccessResponse(orders);
        }

        public async Task<ProcessedResponse> UpdateAsync(Order order)
        {
            var isFound = await _unitOfWork.Orders.AnyAsync(o => o.OrderId == order.OrderId);

            if (isFound)
            {
                await _unitOfWork.Orders.UpdateAsync(order);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse("Could not update the order, it does not exist.");
        }

        public async Task<ProcessedResponse> DeleteAsync(short orderId)
        {
            var order = await _unitOfWork.Orders.GetAsync(o => o.OrderId == orderId);

            if (order is not null)
            {
                var isFound = await _unitOfWork.OrderDetails.AnyAsync(o => o.OrderId == orderId);
                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The order you are trying to delete is tied to an Order Detail, it cannot be deleted.");
                }
                
                await _unitOfWork.Orders.DeleteAsync(order);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse(
                "The order you are trying to delete does not exist or was already deleted.");
        }


        public async Task<ProcessedResponse> AnyAsync(Expression<Func<Order, bool>> expression)
        {
            var isFound = await _unitOfWork.Orders.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(isFound);
        }
    }
}
