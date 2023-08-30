using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories;
using Pizza_Delivery.Repositories.Services;

using (var context = new ItallianPizzaContext())
{
    var productRepository = new ProductRepository(context);
    var customerRepository = new CustomerRepository(context);
    //var orderRepository = new OrderRepository(context);


    PerformProductOperations(productRepository);
    PerformCustomerOperations(customerRepository);

}

void PerformCustomerOperations(CustomerRepository customerRepository)
{
    //ADDING NEW CUSTOMER
    var newCustomer = new Customer
    {
        FirstName = "Hina",
        LastName = "Arif",
        Address = "Steet#9 House 2 Pk",
        Email = "hinaarif@gmail.com"
    };

    //UPDATE CUSTOMER
    var UpdateCustomer = customerRepository.GetById(1
        );
    if(UpdateCustomer != null)
    {
        UpdateCustomer.FirstName = "Naveen";
        customerRepository.Update(UpdateCustomer);
    }

    //REMOVE PRODUCT
    //customerRepository.Delete(1);

    //READING ALL DATA
    var customers = customerRepository.GetAll();

    //PRINTING DATA
    PrintingCustomers(customers);

   

}

void PerformProductOperations(ProductRepository productRepository)
{
    //ADDING NEW PRODUCT
    var newProduct = new Product
    {
        Name = "BBQ Tikka Masala Pizza",
        Price = 3300,
    };
    productRepository.Add(newProduct);

 
    //UPDATE PRODUCT
    var UpdateProduct = productRepository.GetById(4);
    if(UpdateProduct != null)
    {
        UpdateProduct.Name = "Tikka Chicken Pizza";
        productRepository.Update(UpdateProduct);
    }

    //REMOVE PRODUCT
    productRepository.Delete(6);

    //READING ALL DATA
    var products = productRepository.GetAll();

    //PRINTING DATA
    PrintingProducts(products);

}



//PRINTING METHODS

void PrintingProducts(IEnumerable<Product> products) //ienumerable
{
    Console.WriteLine("Printing Products");
    Console.WriteLine(new string('-', 20));
    foreach(Product prod in products)
    {
        Console.WriteLine($"ID:         {prod.Id}");
        Console.WriteLine($"Name:       {prod.Name}");
        Console.WriteLine($"Price       {prod.Price}");
        Console.WriteLine(new string('-',20)); //string 
    }
}

void PrintingCustomers(IEnumerable<Customer> customers)
{
    Console.WriteLine("Printing Customers");
    Console.WriteLine(new string('-', 20));
    foreach(Customer cust in customers)
    {
        Console.WriteLine($"ID          {cust.Id}");
        Console.WriteLine($"FirstName   {cust.FirstName}");
        Console.WriteLine($"LastName    {cust.LastName}");
        Console.WriteLine(new string('-',20));
    }
}
