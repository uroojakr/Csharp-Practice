
using Microsoft.EntityFrameworkCore;
using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Repositories;
using Pizza_Delivery.Repositories.Interfaces;
using Pizza_Delivery.Repositories.Services;

ItallianPizzaContext _context = new ItallianPizzaContext();

//adding data first
//var product = new Product
//              {
//                  Name = "BBQ Pizza",
//                  Price = 2300
//              };

IProductRepository productRepository = new ProductRepository(_context);
ICustomerRepository customerRepository = new CustomerRepository(_context);
IOrderRepository orderRepository = new OrderRepository(_context);
IOrderDetailRepository orderDetailRepository = new OrderDetailRepository(_context);
IDeliveriesRepository deliveriesRepository = new DeliveriesRepository(_context);
IPaymentRepository paymentRepository = new PaymentRepository(_context);
//productRepository.Add(product);


//reading data
var allProducts = productRepository.GetAll();

Console.WriteLine("Printing all Products");

foreach (Product p in allProducts)
{
    Console.WriteLine($"{p.Id}  {p.Name}    {p.Price}");
}

//updating data
//var updateproduct = productRepository.GetById(2);
//if (updateproduct != null)
//{
//    updateproduct.Price = 5000;
//    productRepository.Update(updateproduct);
//}
//Console.WriteLine("updated Data is ");
//Console.WriteLine($"{updateproduct!.Id}  {updateproduct.Name}    {updateproduct.Price}");

////deleting data
//var deleteProduct = productRepository.GetById(1);
//if (deleteProduct != null)
//{
//    productRepository.Delete(1);
//}

//using interface methods for product
//var minPrice = 2500;
//var maxPrice = 4000;
//var productInRange = productRepository.GetProductsByPriceRange(minPrice, maxPrice);
//Console.WriteLine("Price Range is");
//foreach (Product p in productInRange)
//{
//    Console.WriteLine($"{p.Id}  {p.Name} {p.Price}");
//}

//Customers CRUD
int existingProductID = 1;
if (existingProductID.Equals(null))
{
    Console.WriteLine("ID not found");
}
//adding customer first 
//var customer = new Customer
//{
//    FirstName = "Urooj",
//    LastName = "Akram",
//    Email = "uroojakrm@email.com,",
//    Address = "Street 10, ISB",
//    Phone = "5432-322333",
//};
//var order = new Order
//{
//    OrderPlaced = DateTime.Now,
//    //Customer = customer,
//    CustomerId = 2,
//    ProductID = 1,

//};
//var orderDetails = new OrderDetail
//{

//    Order = order,
//    Quantity = 2,
    
//};
//customerRepository.Add(customer);
//orderRepository.Add(order);
//orderDetailRepository.Add(orderDetails);

//creating for deliveries and payment 

int orderId = 10;
var productPrices = _context.Orders.Where(od => od.Id == orderId).Sum(p => p.Product.Price);
var orderDetail = _context.OrderDetails.Where(od => od.OrderId == orderId).FirstOrDefault();
var totalAmount = productPrices * orderDetail!.Quantity;

var payment = new Payment
{
    PaymentDate = DateTime.Now,
    PaymentMethod = "Credit  Card",
    Status = "Paid",
    TotalAmount = totalAmount,
};
var delivery = new Deliveries
{
    FirstName = "Ali",
    LastName = "Ahmed",
    Phone = "434-333333",
    IsAvailable = true,
    OrderID = orderId,
};
//var orderadd = new Order
//{
//    OrderPlaced = DateTime.Now,
//    CustomerId = 2,
//    ProductID = 2,
//};


//orderRepository.Add(orderadd);
paymentRepository.Add(payment);
deliveriesRepository.Add(delivery);



// ------------------------------ Reading Data ----------------------------------------------
// ...

// ------------------------------ Reading Data ----------------------------------------------
var allCustomers = customerRepository.GetAll();
Console.WriteLine("\n Printing all Customers");

foreach (var customers in allCustomers)
{
    Console.WriteLine($"{customers.Id}   {customers.FirstName}    {customers.Address}");
}

//------------------------------- Reading Orders and their Details -------------------------
var allOrders = orderRepository.GetAll();
Console.WriteLine("\n Pritning all Orders");

foreach (var orders in allOrders)
{
    Console.WriteLine($"{orders.Id}     {orders.OrderPlaced}");
    if (orders.Customer != null)
    {
        Console.WriteLine($"{orders.Customer.FirstName}      {orders.Customer.Address}");
    }
    else
    {
        Console.WriteLine("No customer information available for this order.");
    }

    //------------ reading order details ---------------------------------------------------
    //foreach (var item in orders.OrderDetails)
    //{
    //    Console.WriteLine($"{item.Quantity}");
    //}
}
Console.WriteLine("Reading all deliveries");
var allDeliveries = deliveriesRepository.GetAll();
foreach(Deliveries deliveries in allDeliveries)
{
    Console.WriteLine($"{deliveries.FirstName}      {deliveries.OrderID}    {deliveries.IsAvailable}");
}

//joining

var customerOrders = _context.Customers
    .Join(_context.Orders, c => c.Id, o => o.CustomerId, (customer, order) => new
    {
        CustomerName = customer.FirstName,
        OrderDate = order.OrderPlaced
    })
    .ToList();

foreach (var item in customerOrders)
{
    Console.WriteLine(item);
}

//raw sql
var products = _context.Products.FromSqlRaw("SELECT * FROM PRODUCTS WHERE Price > {0}", 2000).ToList();