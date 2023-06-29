using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class SalaryGradeContext:DbContext
    {
        public DbSet<SalaryGrade> SalaryGrades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        public void AddSalaryGrade(SalaryGrade salaryGrade)
        {
            SalaryGrades.Add(salaryGrade);
            SaveChanges();
        }
        public SalaryGrade GetSalaryGradeById(int id)
        {
            return SalaryGrades.Find(id);
        }

        public List<SalaryGrade> GetAllSalaryGrades()
        {
            return SalaryGrades.ToList();
        }
        public void UpdateSalaryGrade(SalaryGrade salaryGrade)
        {
            SalaryGrades.Update(salaryGrade);
                SaveChanges();
            
        }

        public void DeleteSalaryGrade(int id)
        {
            var salaryGrade = GetSalaryGradeById(id);
            if (salaryGrade != null)
            {
                SalaryGrades.Remove(salaryGrade);
                SaveChanges();
            }
        }
    }
}
