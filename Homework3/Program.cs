namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new Engine();
            engine1.Size = 15;

            Engine engine2 = new Engine();
            engine2.Size = 17;

            Engine engine3 = new Engine();
            engine3.Size = 20;

            Engine engine4 = new Engine();
            engine4.Size = 25;

            Car car1 = new Car(1, engine1);
            Car car2 = new Car(2, engine2);
            Car car3 = new Car(3, engine3);
            Car car4 = new Car(4, engine4);


            Customer customer1 = new Customer()
            {
                FIO = "Петров Петр Петрович",
                Car = car1
            };

            Customer customer2 = new Customer()
            {
                FIO = "Иванов Иван Иванович",
                Car = car2
            };

            Customer customer3 = new Customer()
            {
                FIO = "Алексеев Алексей Алексеевич",
                Car = car3
            };

            Customer customer4 = new Customer()
            {
                FIO = "Александров Александр Александрович",
                Car = car3
            };

            FactoryAF factory = new FactoryAF();
            factory.AddCustomer(customer1);
            factory.AddCustomer(customer2);
            factory.AddCustomer(customer3);
            factory.AddCustomer(customer4);

            factory.AddCar(car1);
            factory.AddCar(car2);
            factory.AddCar(car3);
            factory.AddCar(car4);

            Console.WriteLine("Заказчики до продаж:");
            foreach (Customer customer in factory.Customers)
            {
                Console.WriteLine($"ФИО заказчика: {customer.FIO}. Номер машины заказчика: {customer.Car.Number}");
            }

            Console.WriteLine("Машины до продажи:");
            foreach (Car car in factory.Cars)
            {
                Console.WriteLine($"Номер машины: {car.Number}");
            }

            factory.SaleCar();

            Console.WriteLine("Заказчики после продаж:");
            foreach (Customer customer in factory.Customers)
            {
                Console.WriteLine($"ФИО заказчика: {customer.FIO}. Номер машины заказчика: {customer.Car.Number}");
            }

            Console.WriteLine("Машины после продажи:");
            foreach (Car car in factory.Cars)
            {
                Console.WriteLine($"Номер машины: {car.Number}");
            }
        }
    }
}