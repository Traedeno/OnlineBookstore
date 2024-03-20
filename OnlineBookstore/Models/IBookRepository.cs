﻿namespace OnlineBookstore.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
