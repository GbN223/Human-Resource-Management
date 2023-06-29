using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
namespace NguyenChiBao_WinApp.Contexts
{
    internal class TimekeepingLocationFirebaseContext
    {
        private FirebaseClient firebaseClient;

        public TimekeepingLocationFirebaseContext()
        {
            // Khởi tạo kết nối tới Firebase Realtime Database
            firebaseClient = new FirebaseClient("https://demotest-95b06-default-rtdb.asia-southeast1.firebasedatabase.app");
        }

        // Phương thức tạo mới (Create)
        public async Task CreateTimekeepingLocation(TimekeepingLocation timekeepingLocation)
        {
            var firebaseResponse = await firebaseClient
                .Child("TimekeepingLocations")
                .PostAsync(timekeepingLocation);

            // Lấy id của đối tượng được tạo trong Firebase
             firebaseResponse.Object.Id= timekeepingLocation.Id;
        }

        // Phương thức đọc (Read)
        public async Task<TimekeepingLocation> GetTimekeepingLocationById(int id)
        {
            var firebaseResponse = await firebaseClient
                .Child("TimekeepingLocation")
                .Child(id.ToString())
                .OnceSingleAsync<TimekeepingLocation>();

            return firebaseResponse;
        }

        // Phương thức cập nhật (Update)
        public async Task UpdateTimekeepingLocation(TimekeepingLocation timekeepingLocation)
        {
            await firebaseClient
                .Child("TimekeepingLocation")
                .Child(timekeepingLocation.Id.ToString())
                .PutAsync(timekeepingLocation);
        }

        // Phương thức xóa (Delete)
        public async Task DeleteTimekeepingLocation(string id)
        {
            await firebaseClient
                .Child("TimekeepingLocation")
                .Child(id)
                .DeleteAsync();
        }
    }
}
