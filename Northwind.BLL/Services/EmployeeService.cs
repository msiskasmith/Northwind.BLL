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
    public class EmployeeService : IServiceBase<Employee, short>
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProcessedResponse> AddAsync(Employee employee)
        {
            employee.EmployeeFirstName = StringManipulator.RemoveExtraSpaces(employee.EmployeeFirstName);
            employee.EmployeeLastName = StringManipulator.RemoveExtraSpaces(employee.EmployeeLastName);

            var isFound = await _unitOfWork.Employees
                .AnyAsync(e => e.EmployeeFirstName.ToLower() == employee.EmployeeFirstName.ToLower() && e.EmployeeLastName.ToLower() == employee.EmployeeLastName.ToLower());

            if (isFound)
            {
                return ResponseProcessor.GetValidationErrorResponse(
                    "The employee you are trying to add already exists.");
            }

            await _unitOfWork.Employees.AddAsync(employee);

            await _unitOfWork.SaveChanges();

            return ResponseProcessor.GetSuccessResponse();

        }

        public async Task<ProcessedResponse> GetAsync(short employeeId)
        {
            var employee = await _unitOfWork.Employees.GetAsync(c => c.EmployeeId == employeeId);

            if (employee == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("The requested employee does not exist.");
            }
        
            return ResponseProcessor.GetSuccessResponse(employee);
        }

        public async Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows)
        {
            var productCategories = await _unitOfWork.Employees.GetListAsync(pageNumber, numberOfRows);

            if (productCategories == null)
            {
                return ResponseProcessor.GetRecordNotFoundResponse("There are no employee records.");
            }
               
            return ResponseProcessor.GetSuccessResponse(productCategories);
        }

        public async Task<ProcessedResponse> GetListAsync(
            Expression<Func<Employee, bool>> expression, int pageNumber, int numberOfRows)
        {
            var productCategories = await _unitOfWork.Employees.GetListAsync(pageNumber, numberOfRows, expression);

            if (productCategories == null) return ResponseProcessor.GetRecordNotFoundResponse(
                "There are no employee records matching your search.");

            return ResponseProcessor.GetSuccessResponse(productCategories);
        }

        public async Task<ProcessedResponse> UpdateAsync(Employee employee)
        {
            employee.EmployeeFirstName = StringManipulator.RemoveExtraSpaces(employee.EmployeeFirstName);
            employee.EmployeeLastName = StringManipulator.RemoveExtraSpaces(employee.EmployeeLastName);

            var unChangedEmployee = await _unitOfWork.Employees.GetAsync(e => e.EmployeeId == employee.EmployeeId);

            
            if (unChangedEmployee is not null)
            {
                // Check if First Name or Last Name are being updated and validate
                if (unChangedEmployee.EmployeeFirstName != employee.EmployeeFirstName
                    || unChangedEmployee.EmployeeLastName != employee.EmployeeLastName)
                {
                    var isFound = await _unitOfWork.Employees
                        .AnyAsync(e => e.EmployeeFirstName.ToLower() == employee.EmployeeFirstName.ToLower() && e.EmployeeLastName.ToLower() == employee.EmployeeLastName.ToLower());

                    if (isFound)
                    {
                        return ResponseProcessor.GetValidationErrorResponse("The employee already exists.");
                    }
                }

                await _unitOfWork.Employees.UpdateAsync(employee);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }
            
            return ResponseProcessor.GetValidationErrorResponse(
                "The employee you are trying to update does not exist.");
        }

        public async Task<ProcessedResponse> DeleteAsync(short employeeId)
        {
            var employee = await _unitOfWork.Employees.GetAsync(e => e.EmployeeId == employeeId);

            if(employee is not null)
            {
                var isFound = await _unitOfWork.Orders.AnyAsync(o => o.EmployeeId == employeeId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "Employee is tied to an order and cannot be deleted");
                }

                isFound = await _unitOfWork.Employees.AnyAsync(e => e.EmployeeSupervisorId == employeeId);

                if (isFound)
                {
                    return ResponseProcessor.GetValidationErrorResponse(
                        "Employee is assigned as a supervisor of another employee and cannot be deleted");
                }

                await _unitOfWork.Employees.DeleteAsync(employee);

                await _unitOfWork.SaveChanges();

                return ResponseProcessor.GetSuccessResponse();
            }

            return ResponseProcessor.GetRecordNotFoundResponse("The employee you are trying to delete does not exist");
        }

        public async Task<ProcessedResponse> AnyAsync(Expression<Func<Employee, bool>> expression)
        {
            var numberOfRows = await _unitOfWork.Employees.AnyAsync(expression);

            return ResponseProcessor.GetSuccessResponse(numberOfRows);
        }
    }
}
