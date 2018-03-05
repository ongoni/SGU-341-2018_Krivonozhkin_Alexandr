using System;
using System.IO;

namespace NETPractice.Inheritance
{
    public class Book
    {
        private string _name;
        private int _pageCount;
        private string _publisher;
        private DateTime _publishingDate;
        private DateTime _writingDate;
        private Author _author;

        public Book()
        {
            _author = new Author();
        }

        public Book(string name, int pageCount, string publisher, DateTime publishingDate, 
            DateTime writingDate, Author author)
        {
            Name = name;
            PageCount = pageCount;
            Publisher = publisher;
            PublishingDate = publishingDate;
            WritingDate = writingDate;
            Author = author;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _name = value;
            }
        }

        public int PageCount
        {
            get => _pageCount;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("page count can't be negative or 0");
                }

                _pageCount = value;
            }
        }

        public string Publisher
        {
            get => _publisher;
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _publisher = value;
            }
        }

        public DateTime PublishingDate
        {
            get => _publishingDate;
            set
            {
                if (value.Date > Author.BirthDate.Date || value.Date > WritingDate.Date)
                {
                    throw new InvalidDataException("publishing date can't be before the author birth date " +
                                                   "or writing date");
                }

                _publishingDate = value;
            }
        }

        public DateTime WritingDate
        {
            get => _writingDate;
            set
            {
                if (value.Date > Author.BirthDate.Date)
                {
                    throw new InvalidDataException("writing date can't be before the author birth date");
                }

                _writingDate = value;
            }
        }

        public Author Author
        {
            get => _author;
            set
            {
                if (value == null)
                {
                    throw new InvalidDataException("author can't be null");
                }

                _author = value;
            }
        }

    }
}
