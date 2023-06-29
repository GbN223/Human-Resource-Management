using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class DepartmentContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Department>().HasKey(d => d.Id);
            modelBuilder.Entity<Department>().Property(d => d.Code).HasMaxLength(10);
            modelBuilder.Entity<Department>().Property(d => d.DepartmentName).HasMaxLength(255);
        }

        // Create
        public void CreateDepartment(Department department)
        {
            Departments.Add(department);
            SaveChanges();
        }

        // Read
        public Department GetDepartmentById(int id)
        {
            return Departments.FirstOrDefault(d => d.Id == id);
        }

        public List<Department> GetAllDepartments()
        {
            return Departments.ToList();
        }

        // Update
        public void UpdateDepartment(Department department)
        {
            Departments.Update(department);
            SaveChanges();
        }

        // Delete
        public void DeleteDepartment(Department department)
        {
            Departments.Remove(department);
            SaveChanges();
        }
    }
}
