using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class CandidateProfileContext:DbContext
    {
        public DbSet<CandidateProfile> CandidateProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
          
        }

        
        // Create
        public void CreateCandidateProfile(CandidateProfile candidateProfile)
        {
            CandidateProfiles.Add(candidateProfile);
            SaveChanges();
        }

        // Read
        public CandidateProfile GetCandidateProfileById(int id)
        {
            return CandidateProfiles.FirstOrDefault(cp => cp.Id == id);
        }

        public List<CandidateProfile> GetAllCandidateProfiles()
        {
            return CandidateProfiles.ToList();
        }

        // Update
        public void UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            CandidateProfiles.Update(candidateProfile);
            SaveChanges();
        }

        // Delete
        public void DeleteCandidateProfile(CandidateProfile candidateProfile)
        {
            CandidateProfiles.Remove(candidateProfile);
            SaveChanges();
        }
    }
}
