using System;
using System.Collections.Generic;

namespace Library
{
    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private IReadOnlyCollection<string> authors;
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public IReadOnlyCollection<string> Authors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }

        public int CompareTo(Book other)
        {
            var result = this.Year.CompareTo(other.year);
            if(result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}