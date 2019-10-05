using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        public List<Book> Books { get => this.books; set => this.books = value; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        public void Sort()
        {
            this.Books.Sort(new BookComparator());
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;
            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.Books = new List<Book>(books);
            }
            public Book Current => this.Books[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                return ++currentIndex < this.Books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
            public List<Book> Books { get; set; }
        }
    }
}