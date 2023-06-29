using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenChiBao
{
    [Activity(Label = "FragmentInfo")]
    public class FragmentInfo : Activity
    {
        Button btn;
        TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Info);
            // Create your application here
             btn = FindViewById<Button>(Resource.Id.button1);
            textView=FindViewById<TextView>(Resource.Id.txInfo);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(HomePage));
            StartActivity(intent);
        }
    }
}