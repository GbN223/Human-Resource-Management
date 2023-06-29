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
    internal class PersonnalProfileContext : DbContext
    {
        
        public DbSet<PersonalProfile> PersonalProfiles { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentPosition>().ToTable("AppointmentPosition");
            modelBuilder.Entity<AppointmentPosition>().HasKey(ap => ap.Personal);

            modelBuilder.Entity<PositionList>().ToTable("PositionList");
            modelBuilder.Entity<PositionList>().HasKey(pl => pl.Id);

            modelBuilder.Entity<PersonalProfile>().ToTable("PersonalProfile");
            modelBuilder.Entity<PersonalProfile>().HasKey(pp => pp.Id);
        }
        public List<PersonalProfile> GetEmployeebyDepartment(int Department)
        {
            var employeeIdParam = new SqlParameter("@Department", Department);
            var query = "EXEC GetEmployeebyDepartment @Department";
            return PersonalProfiles.FromSqlRaw(query, employeeIdParam).ToList();
        }
        public void AddPersonalProfile(PersonalProfile profile)
        {
            PersonalProfiles.Add(profile);
            SaveChanges();
        }

        // Phương thức Read (Đọc)
        public PersonalProfile GetPersonalProfileById(int id)
        {
            return PersonalProfiles.FirstOrDefault(p => p.Id == id);
        }

        public List<PersonalProfile> GetAllPersonalProfiles()
        {
            return PersonalProfiles.ToList();
        }

        // Phương thức Update (Cập nhật)
        public void UpdatePersonalProfile(PersonalProfile updateprofile)
        {
            PersonalProfile existingProfile = PersonalProfiles.Find(updateprofile.Id);
            if (existingProfile != null)
            {
                // Cập nhật các thuộc tính của profile
                Entry(existingProfile).CurrentValues.SetValues(updateprofile);
                SaveChanges();

            }
        }

        // Phương thức Delete (Xóa)
        public void DeletePersonalProfile(int id)
        {
            PersonalProfile profileToDelete = GetPersonalProfileById(id);
            if (profileToDelete != null)
            {
                PersonalProfiles.Remove(profileToDelete);
                SaveChanges();
            }
        }
        public bool IsPersonalProfileCodeExists(string code)
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn để kiểm tra mã PersonalProfile
            
                // Kiểm tra xem mã PersonalProfile đã tồn tại trong danh sách hay chưa
                bool exists = PersonalProfiles.Any(p => p.Code == code);

                return exists;
            
        }

    }
}
