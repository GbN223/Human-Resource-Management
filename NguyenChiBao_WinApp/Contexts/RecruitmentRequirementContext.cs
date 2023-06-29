using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NguyenChiBao_WinApp.Contexts
{
    internal class RecruitmentRequirementContext:DbContext
    {
        public DbSet<RecruitmentRequirement> RecruitmentRequirements { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        public void CreateRecruitmentRequirement(RecruitmentRequirement recruitmentRequirement)
        {
            RecruitmentRequirements.Add(recruitmentRequirement);
            SaveChanges();
        }

        // Read
        public RecruitmentRequirement GetRecruitmentRequirementById(int id)
        {
            return RecruitmentRequirements.Find(id);
        }

        public List<RecruitmentRequirement> GetAllRecruitmentRequirements()
        {
            return RecruitmentRequirements.ToList();
        }

        // Update
        public void UpdateRecruitmentRequirement(RecruitmentRequirement updatedRecruitmentRequirement)
        {
            var existingRecruitmentRequirement = RecruitmentRequirements.Find(updatedRecruitmentRequirement.ID);
            if (existingRecruitmentRequirement != null)
            {
                Entry(existingRecruitmentRequirement).CurrentValues.SetValues(updatedRecruitmentRequirement);
                SaveChanges();
            }
        }

        // Delete
        public void DeleteRecruitmentRequirement(int id)
        {
            var recruitmentRequirementToDelete = RecruitmentRequirements.Find(id);
            if (recruitmentRequirementToDelete != null)
            {
                RecruitmentRequirements.Remove(recruitmentRequirementToDelete);
                SaveChanges();
            }
        }
        public bool IsRecruitmentRequirementCodeExists(string code)
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn để kiểm tra mã RecruitmentRequirements

            // Kiểm tra xem mã RecruitmentRequirements đã tồn tại trong danh sách hay chưa
            bool exists = RecruitmentRequirements.Any(p => p.Code == code);

            return exists;

        }
    }
}
