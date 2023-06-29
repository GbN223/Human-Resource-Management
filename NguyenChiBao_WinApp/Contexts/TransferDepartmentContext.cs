using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class TransferDepartmentContext:DbContext
    {
        public DbSet<TransferDepartment> TransferDepartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferDepartment>().ToTable("TransferDepartments");
            modelBuilder.Entity<TransferDepartment>().HasKey(td => td.Id);
        }

        // CREATE
        public void AddTransferDepartment(TransferDepartment transferDepartment)
        {
            TransferDepartments.Add(transferDepartment);
            SaveChanges();
        }

        // READ
        public TransferDepartment GetTransferDepartmentById(int id)
        {
            return TransferDepartments.Find(id);
        }

        public List<TransferDepartment> GetAllTransferDepartments()
        {
            return TransferDepartments.ToList();
        }

        // UPDATE
        public void UpdateTransferDepartment(TransferDepartment transferDepartment)
        {
            TransferDepartments.Update(transferDepartment);
            SaveChanges();
        }

        // DELETE
        public void DeleteTransferDepartment(TransferDepartment transferDepartment)
        {
            TransferDepartments.Remove(transferDepartment);
            SaveChanges();
        }
    }
}
