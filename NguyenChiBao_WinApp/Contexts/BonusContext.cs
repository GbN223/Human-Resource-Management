using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class BonusContext:DbContext
    {
        public DbSet<Bonus> Bonuses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");

        }
        public void CreateBonus(Bonus bonus)
        {
            Bonuses.Add(bonus);
            SaveChanges();
        }

        // Phương thức đọc (Read)
        public Bonus GetBonusById(int id)
        {
            return Bonuses.Find(id);
        }
        public List< Bonus> GetAllBonus()
        {
            return Bonuses.ToList();
        }
        // Phương thức cập nhật (Update)
        public void UpdateBonus(Bonus bonus)
        {
            Bonuses.Update(bonus);
            SaveChanges();
        }

        // Phương thức xóa (Delete)
        public void DeleteBonus(int id)
        {
            var bonus = Bonuses.Find(id);
            Bonuses.Remove(bonus);
            SaveChanges();
        }
    }
}
