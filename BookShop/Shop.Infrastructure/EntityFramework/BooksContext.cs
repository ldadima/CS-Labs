﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BookShop;
using Microsoft.EntityFrameworkCore;

namespace Shop.Infrastructure.EntityFramework
{
    public class BooksContext: DbContext
    {
        public const string DefaultSchemaName = "Books";

        public BooksContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.HasDefaultSchema(DefaultSchemaName); //problem
        }

        public async Task<List<Book>> GetBooks()
        {
            return await Set<Book>()
                .ToListAsync();
        }

        public void AddBook(Book book)
        {
            Set<Book>().Add(book);
        }
    }
}