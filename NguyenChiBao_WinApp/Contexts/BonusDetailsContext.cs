using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class BonusDetailsContext:DbContext
    {
        public DbSet<BonusDetails> BonusDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");

        }
        // Phương thức tạo mới (Create)
        public void CreateBonusDetails(BonusDetails bonusDetails)
        {
            BonusDetails.Add(bonusDetails);
            SaveChanges();
        }

        // Phương thức đọc (Read)
        public BonusDetails GetBonusDetailsById(int id)
        {
            return BonusDetails.Find(id);
        }

        // Phương thức cập nhật (Update)
        public void UpdateBonusDetails(BonusDetails bonusDetails)
        {
            BonusDetails.Update(bonusDetails);
            SaveChanges();
        }

        // Phương thức xóa (Delete)
        public void DeleteBonusDetails(int id)
        {
            var bonusDetails = BonusDetails.Find(id);
            BonusDetails.Remove(bonusDetails);
            SaveChanges();
        }

    }
}
