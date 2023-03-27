﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Laboration4Affärssystem
{
    internal class Controller
    {
        public BindingList<Book> bookList = new BindingList<Book>();
        public BindingSource bookSource = new BindingSource();

        public BindingList<Videogame> gameList = new BindingList<Videogame>();
        public BindingSource gameSource = new BindingSource();

        public BindingList<Film> filmList = new BindingList<Film>();
        public BindingSource filmSource = new BindingSource();


        public void createBookList()
        {
            
            bookList.Add(new Book(11, "One Piece", 70, 1, "Eichhiro Oda", "Shonen", "Manga", "German"));
            bookList.Add(new Book(12, "Bello Callico et Civili", 449, 2, "Julius Ceasar", "Historia", "Inbunden", "Latin"));
            
            bookSource.DataSource = bookList;
        }


        public void createGameList()
        {
            gameList.Add(new Videogame(21, "Elden Ring", 599, 3, "Playstation 5"));
            gameList.Add(new Videogame(22, "Demon's Souls", 499, 3, "Playstation 5"));

            gameSource.DataSource = gameList;
        }

        public void createFilmList()
        {
            filmList.Add(new Film(31, "Nyckeln till frihet", 99, 5, "DVD", "142 min"));
            filmList.Add(new Film(32, "Gudfadern", 99, 6, "DVD", "152 min"));

            filmSource.DataSource = filmList;
        }

        public void removeBook(int id)
        {
            Book book = bookList.SingleOrDefault(p => p.ID == id);

            bookList.Remove(book);  
        }

        public void removeGame(int id)
        {
            Videogame game = gameList.SingleOrDefault(p => p.ID == id);

            gameList.Remove(game);
        }

        public void removeFilm (int id)
        {
            Film film = filmList.SingleOrDefault(p => p.ID == id);

            filmList.Remove(film);
        }

        public Book findBook (int id)
        {
            Book book = bookList.SingleOrDefault(p => p.ID == id);

            return book;
        }

        public Videogame findGame(int id)
        {
            Videogame game = gameList.SingleOrDefault(p => p.ID == id);

            return game;
        }

        public Film findFilm (int id)
        {
            Film film = filmList.SingleOrDefault (p => p.ID == id);

            return film;
        }

    }
}
