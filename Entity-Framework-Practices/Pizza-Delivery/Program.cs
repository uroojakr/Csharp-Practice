

using Pizza_Delivery.Data;
using Pizza_Delivery.Models;
using Pizza_Delivery.Operations;

//using ItallianPizzaContext context = new ItallianPizzaContext();  //instace disposed properly when done using it


////----------------adding to DB--------------------------
//Product TikkaPizza = new Product()
//{
//    Name = "Tikka Pizza",
//    Price = 3800,
//};
//context.Add(TikkaPizza);



////LINQ syntax
//var products2 = from product in context.Products
//                where product.Price > 2300
//                orderby product.Name
//                select product;
////--------------updating fajita------------------------ -
//var FajitaPizza = context.Products
//    .Where(p => p.Name.Equals("Fajita Pizza"))
//    .FirstOrDefault();

//if (FajitaPizza is Product)
//{
//    FajitaPizza.Price = 2400;
//}


////---------------Deleting from DB-----------------------
//var TikkaPizza = context.Products
//    .Where(p => p.Name.Equals("Tikka Pizza"))
//     .FirstOrDefault();

//if (TikkaPizza is Product)
//{
//    context.Remove(TikkaPizza);
//}

////---------------fluent API syntax----------------------
//var products = context.Products
//    .Where(p => p.Price > 2300)
//    .OrderBy(p => p.Name);

//context.SaveChanges();


////-----------------Printing Result----------------------
//foreach (Product i in products)
//{
//    Console.WriteLine($"ID:         {i.Id}");
//    Console.WriteLine($"Name:       {i.Name}");
//    Console.WriteLine($"Price:      {i.Price}");
//    Console.WriteLine(new string('-', 20));
//}

class Program
{
    static void Main()
    {
        using (var context = new ItallianPizzaContext())
        {
            var productOperations = new ProductRepository(context);

            var newProduct = new Product
            { 
                    Name = "BBQ Pizza",
                    Price = 3500
            };

            productOperations.AddProduct(newProduct);

            var products = productOperations.GetProductsbyPrice(2000);
            PrintProducts(products);
        }
    }
    static void PrintProducts(IEnumerable<Product> products)
    {
        foreach (Product product in products) 
        {
            Console.WriteLine($"ID: {product.Id}");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine(new string('-', 20));
        }
    }
}
