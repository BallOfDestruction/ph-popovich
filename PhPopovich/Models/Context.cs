﻿using System.Linq;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models.Pages;

namespace PhPopovich.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FileModel> Files { get; set; }

        public DbSet<AdminModel> AdminModels { get; set; }

        public DbSet<ImageModel> Images { get; set; }

        public DbSet<CmsModel> CmsModels { get; set; }

        public DbSet<MainPageModel> MainPageModels { get; set; }
      
        public DbSet<UserModel> Users { get; set; }

        public DbSet<MenuModel> Menus { get; set; }

        public DbSet<AboutPageModel> AboutPageModels { get; set; }

        public DbSet<ServicesPageModel> ServicesPageModels { get; set; }

        public DbSet<ProjectsPageModel> ProjectsPageModels { get; set; }

        public DbSet<OrderPageModel> OrderPageModels { get; set; }

        public DbSet<ContactsPageModel> ContactsPageModels { get; set; }

        public DbSet<BlogPageModel> BlogPageModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ImageModel>()
                .HasOne(w => w.MainPageModel)
                .WithOne(w => w.ImageModel)
                .HasForeignKey<MainPageModel>(w => w.ImageModelId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        public IQueryable<T> GetDbSet<T>(T type)
            where T : class
        {

            return Set<T>()?.AsQueryable();
        }
    }
}
