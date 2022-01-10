using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    class Book
    {

        string name; 
        int year; 
        Author author; 
        double price;

        public Book(string name, int year, Author author, double price)
        {
            this.name = name;
            this.year = year;
            this.author = author;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public Author GetAuthor()
        {
            return author;
        }

        public int GetYear()
        {
            return year;
        }

        public double GetPrice()
        {
            return price;
        }

        public void PrintBook()
        {
            Console.WriteLine("Book {0} ({1} RON), by {2}, published in {3}", name, price, author.GetName(), year);
        }

    }
}

