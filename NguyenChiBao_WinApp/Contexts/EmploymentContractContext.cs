using Microsoft.EntityFrameworkCore;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class EmploymentContractContext : DbContext
    {
        public DbSet<EmploymentContract> EmploymentContracts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình thông tin kết nối đến cơ sở dữ liệu
            optionsBuilder.UseSqlServer("Data Source=BAO;Initial Catalog=QLNSnoSQL;Integrated Security=True;TrustServerCertificate=True;");
        }
        public void AddEmploymentContract(EmploymentContract prEmploymentContractofile)
        {
            EmploymentContracts.Add(prEmploymentContractofile);
            SaveChanges();
        }
        public int CreateEmployeeContract(EmploymentContract employeeContract)
        {
            EmploymentContracts.Add(employeeContract);
            SaveChanges(); // Lưu thay đổi và tạo ID mới

            return employeeContract.Id; // Trả về ID của EmployeeContract vừa được tạo
        }
        // Phương thức Read (Đọc)
        public EmploymentContract GetEmploymentContractById(int id)
        {
            return EmploymentContracts.FirstOrDefault(p => p.Id == id);
        }
        public bool IsEmployeeContractCreated(int employee, string startDate)
        {
            // Lấy danh sách các EmploymentContract của Employee
            var employeeContracts = EmploymentContracts
                .Where(ec => ec.Employee == employee)
                .ToList();

            // Kiểm tra xem có EmploymentContract nào đã được tạo trước đó
            // có ngày kết thúc lớn hơn hoặc bằng ngày tạo mới của EmploymentContract
            var isContractCreated = employeeContracts.Any(ec => ec.EndDate > DateTime.Parse( startDate));

            return isContractCreated;
        }
        public List<EmploymentContract> GetAllEmploymentContracts()
        {
            return EmploymentContracts.ToList();
        }

        // Phương thức Update (Cập nhật)
        public void UpdatePersonalProfile(EmploymentContract employmentContracts)
        {
            EmploymentContract existingContract = GetEmploymentContractById(employmentContracts.Id);
            if (existingContract != null)
            {
                // Cập nhật các thuộc tính của profile
               existingContract.Code = employmentContracts.Code;
                existingContract.Employee = employmentContracts.Employee;
                existingContract.StartDate = employmentContracts.StartDate;
                existingContract.EndDate = employmentContracts.EndDate;
                existingContract.CreatedDate= employmentContracts.CreatedDate;


                SaveChanges();
            }
        }

        // Phương thức Delete (Xóa)
        public void DeleteEmployeeContract(int id)
        {
            EmploymentContract employmentContract = GetEmploymentContractById(id);
            if (employmentContract != null)
            {
                EmploymentContracts.Remove(employmentContract);
                SaveChanges();
            }
        }
        public bool IsEmploymentContractCodeExists(string code)
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn để kiểm tra mã RecruitmentRequirements

            // Kiểm tra xem mã RecruitmentRequirements đã tồn tại trong danh sách hay chưa
            bool exists = EmploymentContracts.Any(p => p.Code == code);

            return exists;

        }
    }
}
