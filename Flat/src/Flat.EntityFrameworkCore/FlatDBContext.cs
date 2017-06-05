using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Flat.Domain.Entities;

namespace Flat.EntityFrameworkCore
{
    public class FlatDBContext: DbContext
    {
        public FlatDBContext(DbContextOptions<FlatDBContext> options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //UserRole关联配置
            builder.Entity<UserRole>()
              .HasKey(ur => new { ur.UserId, ur.RoleId });

            //RoleMenu关联配置
            builder.Entity<RoleMenu>()
              .HasKey(rm => new { rm.RoleId, rm.MenuId });

            //启用Guid主键类型扩展
            builder.HasPostgresExtension("uuid-ossp");

            base.OnModelCreating(builder);
        }
    }
}
