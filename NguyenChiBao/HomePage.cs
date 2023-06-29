using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AndroidX.ViewPager.Widget;
using AndroidX.ViewPager2.Widget;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.Tabs;
using NguyenChiBao.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using static AndroidX.RecyclerView.Widget.RecyclerView;
using Android.Content.Res;

namespace NguyenChiBao
{
    [Activity(Label = "HomePage")]
    public class HomePage : AppCompatActivity
    {
        FrameLayout frame;
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HomePage);
            AddControls();
            // Create your application here
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void AddControls()
        {
           

        }
       
    }
}