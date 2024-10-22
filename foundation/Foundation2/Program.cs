using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("576 S Geneva Rd", "Orem", "UT 84058", "USA");
        Customer customer1 = new Customer("Cameron Burton", address1);
        List<Product> productList1 = new List<Product>();

        Product o1p1 = new Product("Calculator", "C200", 19.98, 1);
        Product o1p2 = new Product("Notebook", "NB50", 4.98, 5);
        Product o1p3 = new Product("Pencil", "P05", 1.99, 10);

        productList1.Add(o1p1);
        productList1.Add(o1p2);
        productList1.Add(o1p3);

        Order order1 = new Order(productList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("9739 South Lafayette Ln", "Miami Beach", "FL 33141", "USA");
        Customer customer2 = new Customer("Leslie Barrett", address2);
        List<Product> productList2 = new List<Product>();

        Product o2p1 = new Product("Weight Set", "WTSET", 99.99, 1);
        Product o2p2 = new Product("Apple Pencil", "AP200", 199.00, 1);
        Product o2p3 = new Product("Screen Protector", "SCP215", 7.98, 2);

        productList2.Add(o2p1);
        productList2.Add(o2p2);
        productList2.Add(o2p3);

        Order order2 = new Order(productList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();
    }
}