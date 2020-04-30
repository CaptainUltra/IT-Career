using MusicApp.Data;
using MusicApp.Data.Models;
using MusicApp.Services.Contracts;
using System;

namespace MusicApp.Services
{
    public class CategoryService : ICategoryService
    {
        private MusicAppDbContext context;
        public CategoryService(MusicAppDbContext context)
        {
            this.context = context;
        }
        public int CreateCategory(string name)
        {
            var category = new Category() { Name = name };
            context.Categories.Add(category);
            context.SaveChanges();

            return category.Id;
        }
    }
}
