using System.IO;
using NETPractice.Polymorphism.ITCompany.Entities;
using NETPractice.Polymorphism.ITCompany.Entities.Employees;

namespace NETPractice.Polymorphism.ITCompany.Logic
{
    public static class ITCompanyPaymentHandler
    {
        private static void PayTo(Employee employee, double wage)
        {
            if (employee == null)
            {
                throw new InvalidDataException("employee can't be null");
            }

            employee.GetPaid(new Salary(wage));
        }
        
    }
    
}
