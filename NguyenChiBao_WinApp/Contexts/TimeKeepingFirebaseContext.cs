using Firebase.Database;
using Firebase.Database.Query;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Contexts
{
    internal class TimeKeepingFirebaseContext
    {
        private FirebaseClient firebaseClient;

        public TimeKeepingFirebaseContext()
        {
            firebaseClient = new FirebaseClient("https://demotest-95b06-default-rtdb.asia-southeast1.firebasedatabase.app");

        }

        public async Task AddTimekeeping(TimeKeeping timekeeping)
        {
            var firebaseResponse = await firebaseClient
                 .Child("TimeKeeping")
                 .PostAsync(timekeeping);

            // Lấy id của đối tượng được tạo trong Firebase
            firebaseResponse.Object.Id = timekeeping.Id;
        }

        public async Task<TimeKeeping> GetTimekeepingById(string id)
        {
            return await firebaseClient
            .Child("Timekeeping")
                .Child(id.ToString())
            .OnceSingleAsync<TimeKeeping>();
        }

        public async Task<List<TimeKeeping>> GetAllTimekeepings()
        {
            return (await firebaseClient
            .Child("TimeKeeping")
            .OnceAsync<TimeKeeping>())
            .Select(item => item.Object)
            .ToList();
        }

        public async Task UpdateTimekeeping(TimeKeeping timekeeping)
        {
            await firebaseClient
                .Child("TimeKeeping")
                .Child(timekeeping.Id.ToString())
                .PutAsync(timekeeping);
        }

        public async Task DeleteTimekeeping(string id)
        {
            await firebaseClient
                .Child("TimeKeeping")
                .Child(id)
                .DeleteAsync();
        }
    }
}
