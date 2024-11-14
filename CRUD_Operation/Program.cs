using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCrud crud = new ProductCrud();

            try
            {
                string ch;
                do
                {
                    Console.WriteLine("1.Product List");
                    Console.WriteLine("2.Add Product");
                    Console.WriteLine("3.Modify Product");
                    Console.WriteLine("4.Delete Product");
                    Console.WriteLine("5.Get Product By Id");
                    Console.WriteLine("Select option from above");

                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Product> products = crud.DisplayAllProduct();
                            foreach (Product product in products)
                            {
                                Console.WriteLine(product);
                            }
                            break;
                        case 2:
                            Product p = new Product();
                            Console.WriteLine("Enter Id : ");
                            p.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name :");
                            p.Name = Console.ReadLine();
                            Console.WriteLine("Enter Price :");
                            p.Price = Convert.ToInt32(Console.ReadLine());

                            crud.AddProduct(p);
                            Console.WriteLine("Product Added Successfully");
                            break;
                        case 3:
                            Product p1 = new Product();
                            Console.WriteLine("Enter existing Id : ");
                            p1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name :");
                            p1.Name = Console.ReadLine();
                            Console.WriteLine("Enter new Price :");
                            p1.Price = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyProduct(p1);
                            break;
                        case 4:
                            Console.WriteLine("Enter existing ID that you want to delete :");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteProduct(id);
                            Console.WriteLine("Product Delete Successfully");
                            break;
                        case 5:
                            Console.WriteLine("Enter product id :");
                            int id1 = Convert.ToInt32(Console.ReadLine());
                            crud.GetProductById(id1);
                            break;
                    }
                    Console.WriteLine("Do you want to continue ! (y/n)");
                    ch = Console.ReadLine();
                } while (ch == "yes" | ch == "y");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
