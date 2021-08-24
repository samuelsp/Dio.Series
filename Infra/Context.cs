using System;
using Dio.Series.Models;
using Microsoft.EntityFrameworkCore;

namespace Dio.Series.Infra {
    public class Context : DbContext {
        public DbSet<Serie> Serie { get; set; }

        public string DbPath { get; private set; }

        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}movies.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");
    }
}