using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;
using Android;
using Android.Content;

namespace learn
{
    [Activity(Label = "تعلم الإنجليزية بسهوله", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
           AdView mAdView = FindViewById<AdView>(Resource.Id.adView1);
            var adRequest = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView.LoadAd(adRequest);
            var btnstart = FindViewById<Button>(Resource.Id.btnstart);
            btnstart.Click += Btnstart_Click;
            var rate = FindViewById<Button>(Resource.Id.btnrate);
            rate.Click += Rate_Click;
        }

        private void Rate_Click(object sender, System.EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=com.mosa.LearnEnglish");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void Btnstart_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(select));
            StartActivity(intent);
        }
    }
}

