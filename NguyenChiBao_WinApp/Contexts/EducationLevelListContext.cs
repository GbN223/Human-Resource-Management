using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class EducationLevelListContext:DbContext
    {
        public DbSet<EducationLevelList> EducationLevelLists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }


        // Create
        public void CreateEducationLevelList(EducationLevelList educationLevelList)
        {
            EducationLevelLists.Add(educationLevelList);
            SaveChanges();
        }

        // Read
        public EducationLevelList GetEducationLevelListById(int id)
        {
            return EducationLevelLists.FirstOrDefault(el => el.Id == id);
        }

        public List<EducationLevelList> GetAllEducationLevelLists()
        {
            return EducationLevelLists.ToList();
        }

        // Update
        public void UpdateEducationLevelList(EducationLevelList educationLevelList)
        {
            EducationLevelLists.Update(educationLevelList);
            SaveChanges();
        }

        // Delete
        public void DeleteEducationLevelList(EducationLevelList educationLevelList)
        {
            EducationLevelLists.Remove(educationLevelList);
            SaveChanges();
        }
    }
}
