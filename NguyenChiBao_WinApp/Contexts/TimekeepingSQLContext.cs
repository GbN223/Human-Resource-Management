using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class TimekeepingSQLContext:DbContext
    {
        public DbSet<TimeKeeping> Timekeepings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }

        public void AddTimekeeping(TimeKeeping timekeeping)
        {
            Timekeepings.Add(timekeeping);
            SaveChanges();
        }

        public TimeKeeping GetTimekeepingById(int id)
        {
            return Timekeepings.Find(id);
        }

        public List<TimeKeeping> GetAllTimekeepings()
        {
            return Timekeepings.ToList();
        }

        public void UpdateTimekeeping(TimeKeeping timekeeping)
        {
            Timekeepings.Update(timekeeping);
            SaveChanges();
        }

        public void DeleteTimekeeping(int id)
        {
            var timekeeping = Timekeepings.Find(id);
            if (timekeeping != null)
            {
                Timekeepings.Remove(timekeeping);
                SaveChanges();
            }
        }
    }
}
