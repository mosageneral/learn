using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms.Ads;
using Android;

namespace learn
{
    [Activity(Label = "words")]
    public class words : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.words);
            AdView mAdView = FindViewById<AdView>(Resource.Id.adView1);
            var adRequest = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView.LoadAd(adRequest);
            var home = FindViewById<Button>(Resource.Id.home );
            home.Click += Home_Click;
            var school = FindViewById<Button>(Resource.Id.school);
            school.Click += School_Click;
            var work = FindViewById<Button>(Resource.Id.work);
            work.Click += Work_Click;
            var street = FindViewById<Button>(Resource.Id.street);
            street.Click += Street_Click;
          
            var hospital = FindViewById<Button>(Resource.Id.hospital);
            hospital.Click += Hospital_Click;
            var sea = FindViewById<Button>(Resource.Id.sea);
            sea.Click += Sea_Click;
            var sport = FindViewById<Button>(Resource.Id.sport);
            sport.Click += Sport_Click;
          

        }

      

        private void Sport_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(sport ));
            StartActivity(intent);
        }

        private void Sea_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(sea));
            StartActivity(intent);
        }

        private void Hospital_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(hospital));
            StartActivity(intent);
        }

      

        private void Street_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(street));
            StartActivity(intent);
        }

        private void Work_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(work ));
            StartActivity(intent);
        }

        private void School_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(school ));
            StartActivity(intent);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(home));
            StartActivity(intent);
        }
    }
}