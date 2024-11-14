using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation
{
    public class Product
    {
        //private int id;
        //private string name;
        //private int price;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


           

        public override string ToString()
        {
            return $"{Id} , {Name} ,{Price}";
        }
    }

    public class ProductCrud
    {
        List<Product> Products;

        //Constructor
        public ProductCrud()
        {
            Products = new List<Product>();
        }

        //Method to add product
        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        //Method to display all products
        public List<Product> DisplayAllProduct()
        {
           return Products; 
        }

        //Method to modify product

        public void ModifyProduct(Product p) 
        {
            for(int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Id == p.Id)
                {
                    Products[i].Name = p.Name;
                    Products[i].Price = p.Price;
                    break;
                }
            }
        }

        //Method to delete product

        public void DeleteProduct(int id)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Id == id)
                {
                    Products.Remove(Products[i]);
                }
            }
        }

        //Method to get product by ID

        public Product GetProductById(int id)
        {
            Product p = new Product();

            foreach (var item in Products) 
            {
                if (item.Id == id)
                {
                    item.Id = id;
                    item.Name=p.Name;
                    item.Price=p.Price;
                    break;
                }
            }
            return p;
        }
    }
}
