﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4Affärssystem
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

        //Constructor Item
        public Item(int id, string name, int price, int amount)
        {
            ID = id;
            Name = name;
            Price = price;
            Amount = amount;
        }

        public void Sell(int amountSold)
        {
            Amount -= amountSold;
        }

        public void Shipment(int shippmentAmount)
        {
            Amount += shippmentAmount;
        }
        
    }


    public class Book : Item 
    { 
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }


        //Constructor Book
        public Book(int id, string name, int price, int amount, string author, string genre, string format, string language) : base(id, name, price, amount)
        { 
            Author = author;
            Genre = genre;
            Format = format;
            Language = language;
        }
    }

    public class Videogame : Item
    {
        public string Plattform { get; set; }

        //Contructor Videogame
        public Videogame(int id, string name, int price, int amount, string plattform) : base(id, name, price, amount)
        {
            Plattform = plattform;
        }
    }

    public class Film : Item
    {
        public string Format { set; get; }
        public string Time { set; get; }

        //Constructor Film
        public Film (int id, string name, int price, int amount, string format, string time) : base(id, name, price, amount)
        {
            Format = format;
            Time = time;
        }
    }

    

}
