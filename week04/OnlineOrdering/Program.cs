using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Niyi", address1);
        Product product1a = new Product("iPhone 15 Pro", "#345", 899, 1);
        Product product1b = new Product("AirPods Pro", "#456", 199, 2);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1a);
        order1.AddProduct(product1b);

        Console.WriteLine("\n--- Order 1 (USA Customer) ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.GetTotalCost()}");

        // Order 2: Nigeria Customer
        Address address2 = new Address("12 Allen Ave", "Ikeja", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Chioma", address2);
        Product product2a = new Product("Infinix Note 30", "#789", 400, 1);
        Product product2b = new Product("Oraimo Power Bank", "#567", 50, 3);
        Order order2 = new Order(customer2);
        order2.AddProduct(product2a);
        order2.AddProduct(product2b);

        Console.WriteLine("\n--- Order 2 (Nigeria Customer) ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.GetTotalCost()}");

        // Order 3: Nigeria Customer
        Address address3 = new Address("45 Awolowo Road", "Ikoyi", "Lagos", "Nigeria");
        Customer customer3 = new Customer("Bola", address3);
        Product product3a = new Product("Samsung S23", "#890", 950, 1);
        Product product3b = new Product("Tecno Pop 7", "#112", 120, 2);
        Order order3 = new Order(customer3);
        order3.AddProduct(product3a);
        order3.AddProduct(product3b);

        Console.WriteLine("\n--- Order 3 (Nigeria Customer) ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order3.GetTotalCost()}");
    }
}
