using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class FactoryAF
    {
        public List<Car> Cars { get; set; } = new();

        public List<Customer> Customers { get; set; } = new();

        public void SaleCar() 
        {
            List<Customer> customersToRemove = new List<Customer>(); 
            foreach (Customer customer in Customers)
            {
                bool isRemoved = Cars.Remove(customer.Car);

                if (isRemoved) 
                {
                    customersToRemove.Add(customer);
                }
            }

            foreach (Customer customerToRemove in customersToRemove)
            {
                Customers.Remove(customerToRemove);
            }

            Cars.Clear();
        } 

        public void AddCar(Car carToAdd)
        {
            Cars.Add(carToAdd);
        }

        public void AddCustomer(Customer customerToAdd)
        {
            Customers.Add(customerToAdd);
        }
    }
}
