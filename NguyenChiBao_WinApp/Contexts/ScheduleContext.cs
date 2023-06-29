using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class ScheduleContext:DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
      
        public void CreateSchedule(Schedule schedule)
        {
            Schedules.Add(schedule);
            SaveChanges();
        }

        // Phương thức Read
        public Schedule GetScheduleById(int id)
        {
            return Schedules.Find(id);
        }

        // Phương thức Update
        public void UpdateSchedule(Schedule schedule)
        {
            Schedules.Update(schedule);
            SaveChanges();
        }

        // Phương thức Delete
        public void DeleteSchedule(Schedule schedule)
        {
            Schedules.Remove(schedule);
            SaveChanges();
        }
        public bool IsScheduleCodeExists(string code)
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn để kiểm tra mã Schedule

            // Kiểm tra xem mã Schedule đã tồn tại trong danh sách hay chưa
            bool exists = Schedules.Any(p => p.Code == code);

            return exists;

        }
        public bool IsScheduleExistsWithCandidateAndResult(int candidate, string result)
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn để kiểm tra Schedule
            
                // Kiểm tra xem có lịch trình (Schedule) nào tồn tại với ứng viên (Candidate) và kết quả (Result) tương ứng hay không
                bool exists = Schedules.Any(s => s.Candidate == candidate && s.Result == result);

                return exists;
            
        }
    }
}
