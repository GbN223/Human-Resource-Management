using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class SalaryGradeDetailContext:DbContext
    {
        public DbSet<SalaryGradeDetails> SalaryGradeDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalaryGradeDetails>().ToTable("SalaryGradeDetails");
            modelBuilder.Entity<SalaryGradeDetails>().HasKey(sl=>sl.Id);
          
        }
        public void AddSalaryGradeDetail(SalaryGradeDetails salaryGradeDetail)
        {
            SalaryGradeDetails.Add(salaryGradeDetail);
            SaveChanges();
        }
        public SalaryGradeDetails GetSalaryGradeDetailById(int id)
        {

            return SalaryGradeDetails.Find(id);
        }

        public List<SalaryGradeDetails> GetAllSalaryGradeDetails()
        {
            return SalaryGradeDetails.ToList();
        }
        public void UpdateSalaryGrade(SalaryGradeDetails salaryGradeDetail)
        {
            SalaryGradeDetails.Update(salaryGradeDetail);
            SaveChanges();

        }

        public void DeleteSalaryGradeDetail(int id)
        {
            var salaryGrade = GetSalaryGradeDetailById(id);
            if (salaryGrade != null)
            {
                SalaryGradeDetails.Remove(salaryGrade);
                SaveChanges();
            }
        }
    }
}
