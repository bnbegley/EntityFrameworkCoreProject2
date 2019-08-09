

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreProject2.Models {


    public class AppDbContext : DbContext {

        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr =
                "server=localhost\\sqlexpress;database=AppEfDb;trusted_connection=true;";
            builder.UseLazyLoadingProxies();
            builder.UseSqlServer(connStr);

        }
        
}
