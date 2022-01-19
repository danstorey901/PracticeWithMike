using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeWithMike
{

    class Books
    {
        private static int NextId = 1;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Inventory { get; set; }
        public bool InStock { get; set; }

        public Books()
        {

        }
        public Books(string title, string author, int pages, int inventory, bool instock)
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.Inventory = inventory;
            this.InStock = instock;

            this.Id = NextId++;

          
        }
        public void PrintUserInputData()
        {
            Console.WriteLine("Please Input your Title!");
            this.Title = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Input your Author!");
            this.Author = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Input your Number of Pages!");
            this.Pages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Input your Inventory Quantity!");
            this.Inventory = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Input Yes or No for Availability!");
            this.InStock = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Here are some book recommendations!{this.Id}.|Title = {this.Title}|Author = {this.Author}|Pages = {this.Pages}|Quantity {this.Inventory}|InStock? {this.InStock}");
        }
    }
}
