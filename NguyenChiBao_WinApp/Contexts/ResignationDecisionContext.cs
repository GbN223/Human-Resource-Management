using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class ResignationDecisionContext:DbContext
    {
        private DbSet<ResignationDecision> resignationDecisions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        // Phương thức để lấy danh sách ResignationDecision
        public List<ResignationDecision> GetResignationDecisions()
        {
            return resignationDecisions.ToList();
        }

        // Phương thức để thêm một ResignationDecision mới
        public void AddResignationDecision(ResignationDecision decision)
        {
            resignationDecisions.Add(decision);
            SaveChanges();
        }

        // Phương thức để cập nhật một ResignationDecision
        public void UpdateResignationDecision(ResignationDecision decision)
        {
            resignationDecisions.Update(decision);
            SaveChanges();
        }

        // Phương thức để xóa một ResignationDecision
        public void DeleteResignationDecision(ResignationDecision decision)
        {
            resignationDecisions.Remove(decision);
            SaveChanges();
        }
    }
}
