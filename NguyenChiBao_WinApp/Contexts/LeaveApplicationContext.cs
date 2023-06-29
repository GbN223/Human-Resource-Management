using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class LeaveApplicationContext:DbContext
    {
        public DbSet<LeaveApplication> LeaveApplications { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        public void CreateLeaveApplication(LeaveApplication leaveApplication)
        {
            LeaveApplications.Add(leaveApplication);
            SaveChanges();
        }

        // Phương thức đọc thông tin một đối tượng LeaveApplication dựa trên ID
        public LeaveApplication GetLeaveApplicationById(int id)
        {
            return LeaveApplications.Find(id);
        }

        // Phương thức cập nhật thông tin một đối tượng LeaveApplication
        public void UpdateLeaveApplication(LeaveApplication leaveApplication)
        {
            LeaveApplications.Update(leaveApplication);
            SaveChanges();
        }

        // Phương thức xóa một đối tượng LeaveApplication dựa trên ID
        public void DeleteLeaveApplication(int id)
        {
            var leaveApplication = LeaveApplications.Find(id);
            if (leaveApplication != null)
            {
                LeaveApplications.Remove(leaveApplication);
                SaveChanges();
            }
        }
    }
}
