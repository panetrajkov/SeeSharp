using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Recap.Classes
{
    public class ProductDetails
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public ProductDetails(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public override string? ToString()
        {
            return $"Id: {Id}, Title: {Title}, Price: {Price}";
        }
    }
}
