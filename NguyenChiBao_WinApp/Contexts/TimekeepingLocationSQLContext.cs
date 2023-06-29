using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class TimekeepingLocationSQLContext:DbContext
    {
        public DbSet<TimekeepingLocation> TimekeepingLocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        // Phương thức tạo mới (Create)
        public void CreateTimekeepingLocation(TimekeepingLocation timekeepingLocation)
        {
            TimekeepingLocations.Add(timekeepingLocation);
            SaveChanges();
        }

        // Phương thức đọc (Read)
        public TimekeepingLocation GetTimekeepingLocationById(int id)
        {
            return TimekeepingLocations.Find(id);
        }

        // Phương thức cập nhật (Update)
        public void UpdateTimekeepingLocation(TimekeepingLocation timekeepingLocation)
        {
            TimekeepingLocations.Update(timekeepingLocation);
            SaveChanges();
        }

        // Phương thức xóa (Delete)
        public void DeleteTimekeepingLocation(int id)
        {
            var timekeepingLocation = TimekeepingLocations.Find(id);
            TimekeepingLocations.Remove(timekeepingLocation);
            SaveChanges();
        }
    }
}
