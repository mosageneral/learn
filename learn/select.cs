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
    [Activity(Label = "select")]
    public class select : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.select);
            AdView mAdView = FindViewById<AdView>(Resource.Id.adView1);
            var adRequest = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView.LoadAd(adRequest);

            var btnletters = FindViewById<Button>(Resource.Id.btnletters);
            var btnwords = FindViewById<Button>(Resource.Id.btnwords);
            btnwords.Click += Btnwords_Click;
            btnletters.Click += Btnletters_Click;
            var btnus = FindViewById<Button>(Resource.Id.btnus);
            btnus.Click += Btnus_Click;


        }

        private void Btnus_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(speak ));
            StartActivity(intent);
        }

        private void Btnwords_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(words));
            StartActivity(intent);
        }

        private void Btnletters_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(letters));
            StartActivity(intent);
        }
    }
}