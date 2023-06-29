using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class AllowanceContext:DbContext
    {
        public DbSet<Allowance> Allowances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }

        // Phương thức tạo mới (Create)
        public void CreateAllowance(Allowance allowance)
        {
            Allowances.Add(allowance);
            SaveChanges();
        }
        public List<Allowance> GetAllAllowance()
        {
            return Allowances.ToList();
        }
        // Phương thức đọc (Read)
        public Allowance GetAllowanceById(int id)
        {
            return Allowances.Find(id);
        }

        // Phương thức cập nhật (Update)
        public void UpdateAllowance(Allowance allowance)
        {
            Allowances.Update(allowance);
            SaveChanges();
        }

        // Phương thức xóa (Delete)
        public void DeleteAllowance(int id)
        {
            var allowance = Allowances.Find(id);
            Allowances.Remove(allowance);
            SaveChanges();
        }
    }
}
