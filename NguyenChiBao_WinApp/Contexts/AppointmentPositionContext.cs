using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class AppointmentPositionContext:DbContext
    {
        public DbSet<AppointmentPosition> AppointmentPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }

       

        // Create
        public void CreateAppointmentPosition(AppointmentPosition appointmentPosition)
        {
            AppointmentPositions.Add(appointmentPosition);
            SaveChanges();
        }

        // Read
        public AppointmentPosition GetAppointmentPosition(int personal)
        {
            return AppointmentPositions
                .Where(ap => ap.Personal == personal )
                .OrderByDescending(ap => ap.EffectiveDate)
                .FirstOrDefault();
        }
        public List<AppointmentPosition> GetAllAppointmentPositions()
        {
            return AppointmentPositions.ToList();
        }

        // Update
        public void UpdateAppointmentPosition(AppointmentPosition appointmentPosition)
        {
            AppointmentPositions.Update(appointmentPosition);
            SaveChanges();
        }

        // Delete
        public void DeleteAppointmentPosition(AppointmentPosition appointmentPosition)
        {
            AppointmentPositions.Remove(appointmentPosition);
            SaveChanges();
        }
    }
}
