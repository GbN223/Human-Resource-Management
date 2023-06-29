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
    internal class HRMContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        // DbSet cho các bảng trong cơ sở dữ liệu
        public DbSet<PersonalProfile> personalProfiles { get; set; }

        // Phương thức để chạy stored procedure
        public void RunStoredProcedure(string procedureName, params SqlParameter[] parameters)
        {
            // Code để chạy stored procedure
            // Sử dụng các đối tượng như SqlCommand để thực thi stored procedure
        }

        public List<PersonalProfile> GetEmployeebyDepartment(int Department)
        {
            var employeeIdParam = new SqlParameter("@Department", Department);
            var query = "EXEC GetEmployeebyDepartment @Department";
            return personalProfiles.FromSqlRaw(query, employeeIdParam).ToList();
        }

        // Phương thức để truy vấn view
        //public List<MyViewData> GetViewData()
        //{
        //    // Code để truy vấn view
        //    // Sử dụng các đối tượng như SqlCommand, SqlDataReader để lấy dữ liệu từ view

        //    // Ví dụ đơn giản trả về danh sách dữ liệu từ view
        //    List<MyViewData> viewData = new List<MyViewData>();
        //    // Thực hiện truy vấn và đổ dữ liệu vào danh sách viewData
        //    return viewData;
        //}
    }
}
