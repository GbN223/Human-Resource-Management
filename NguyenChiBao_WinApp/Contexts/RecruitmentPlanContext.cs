
using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class RecruitmentPlanContext:DbContext
    {
        public DbSet<RecruitmentPlan> RecruitmentPlans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
       
        public void AddRecruitmentPlan(RecruitmentPlan recruitmentPlan)
        {
            RecruitmentPlans.Add(recruitmentPlan);
            SaveChanges();
        }
      
        // Read
        public RecruitmentPlan GetRecruitmentPlanId(int id)
        {
            return RecruitmentPlans.Find(id);
        }

        public List<RecruitmentPlan> GetAllRecruitmentPlan()
        {
            return RecruitmentPlans.ToList();
        }
        public bool IsRecruitmentPlanCodeExists(string code)
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn để kiểm tra mã RecruitmentPlan

            // Kiểm tra xem mã RecruitmentPlan đã tồn tại trong danh sách hay chưa
            bool exists = RecruitmentPlans.Any(p => p.Code == code);

            return exists;

        }

    }
}