using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class PositionListContext:DbContext
    {
        public DbSet<PositionList> PositionLists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PositionList>().ToTable("PositionList");
            modelBuilder.Entity<PositionList>().HasKey(pl => pl.Id);
            modelBuilder.Entity<PositionList>().Property(pl => pl.Code).HasMaxLength(10);
            modelBuilder.Entity<PositionList>().Property(pl => pl.PositionName).HasMaxLength(255);
        }
        // Create
        public void CreatePositionList(PositionList positionList)
        {
            PositionLists.Add(positionList);
            SaveChanges();
        }

        // Read
        public PositionList GetPositionListById(int id)
        {
            return PositionLists.FirstOrDefault(pl => pl.Id == id);
        }

        public List<PositionList> GetAllPositionLists()
        {
            return PositionLists.ToList();
        }

        // Update
        public void UpdatePositionList(PositionList positionList)
        {
            PositionLists.Update(positionList);
            SaveChanges();
        }

        // Delete
        public void DeletePositionList(PositionList positionList)
        {
            PositionLists.Remove(positionList);
            SaveChanges();
        }
    }
}
