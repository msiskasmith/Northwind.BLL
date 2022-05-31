using Northwind.BLL.Helpers;
using Northwind.DAL.EFModels;
using Northwind.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Linq.Expressions;

namespace Northwind.BLL.Services
{
    public class CustomerService : IServiceBase<Customer, string>  
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(Customer customer)
        {
            var isFound = await _unitOfWork.Customers
                .AnyAsync(c => c.CustomerName.ToLower() == customer.CustomerName.ToLower());

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse("The Customer Name already exists.");
            }

            await _unitOfWork.Customers.AddAsync(customer);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();
        }

        public async Task<ProcessedResponse> GetAsync(string customerId)
        {
            var customer = await _unitOfWork.Customers.GetAsync(c => c.CustomerId == customerId);

            if (customer == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("The requested customer does not exist");
            }
                
            return ResponseProcessor.GetSuccessResponse(customer);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var customers = await _unitOfWork.Customers.GetListAsync(pageNumber, numberOfRows);

            if(customers == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no customer records.");
            }
                
            return ResponseProcessor.GetSuccessResponse(customers);
        }

        public async Task<ProcessedResponse> GetListAsync(Expression<Func<Customer, bool>> expression, int pageNumber, int numberOfRows)
        {
            var customers = await _unitOfWork.Customers.GetListAsync(pageNumber, numberOfRows, expression);

            if (customers == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no customers on record matching your search.");
            }

            return ResponseProcessor.GetSuccessResponse(customers);
        }

        public async Task<ProcessedResponse> UpdateAsync(Customer customer)
        {
            var unChangedCustomer = await _unitOfWork.Customers.GetAsync(c => c.CustomerId == customer.CustomerId);

            if (unChangedCustomer is not null)
            {
                if(unChangedCustomer.CustomerName != customer.CustomerName)
                {
                    var isFound = await _unitOfWork.Customers.AnyAsync(c => c.CustomerName.ToLower() == customer.CustomerName.ToLower());

                    if (isFound)
                    {
                        return ResponseProcessor.GetValidationErrorResponse(
                            "The Customer Name already exists, please use a different name.");
                    }
                }

                await _unitOfWork.Customers.UpdateAsync(customer);

                var isUpdated = await _unitOfWork.SaveChanges() > 0;

                return ResponseProcessor.GetSuccessResponse();
            }
            
            return ResponseProcessor.GetRecordNotFoundResponse(
                "The customer you are trying to update does not exist.");
        }

        public async Task<ProcessedResponse> DeleteAsync(string customerId)
        {
            var customer = await _unitOfWork.Customers.GetAsync(c => c.CustomerId == customerId);

            if (customer is not null)
            {
                var isFound = await _unitOfWork.Orders.AnyAsync(o => o.CustomerId == customerId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "The customer you are trying to delete is tied to an order and cannot be deleted.");
                }

                await _unitOfWork.Customers.DeleteAsync(customer);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse("The customer you are trying do delete does not exist.");   
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<Customer, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.Customers.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}
