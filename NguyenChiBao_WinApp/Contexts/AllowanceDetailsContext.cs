using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class AllowanceDetailsContext:DbContext
    {
        public DbSet<AllowanceDetails> AllowanceDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");

        }
     
        // Phương thức tạo mới (Create)
        public void CreateAllowanceDetails(AllowanceDetails allowanceDetails)
        {
            AllowanceDetails.Add(allowanceDetails);
            SaveChanges();
        }
        public void CreateAllowanceDetailList(List<AllowanceDetails> allowanceDetails) {
        
            foreach(AllowanceDetails allowances in allowanceDetails)
            {
                AllowanceDetails.Add(allowances);
                SaveChanges();
            }
            
        }
        public void AddAllowance(int allowanceId, int employeeContract, DateTime effectiveDate)
        {
            Database.ExecuteSqlRaw("EXEC AddAllowance @AllowanceId, @EmployeeContract, @EffectiveDate",
                new SqlParameter("@AllowanceId", allowanceId),
                new SqlParameter("@EmployeeContract", employeeContract),
                new SqlParameter("@EffectiveDate", effectiveDate));
        }
        // Phương thức đọc (Read)
        public AllowanceDetails GetAllowanceDetailsById(int id)
        {
            return AllowanceDetails.Find(id);
        }

        // Phương thức cập nhật (Update)
        public void UpdateAllowanceDetails(AllowanceDetails allowanceDetails)
        {
            AllowanceDetails.Update(allowanceDetails);
            SaveChanges();
        }

        // Phương thức xóa (Delete)
        public void DeleteAllowanceDetails(int id)
        {
            var allowanceDetails = AllowanceDetails.Find(id);
            AllowanceDetails.Remove(allowanceDetails);
            SaveChanges();
        }
    }
}
