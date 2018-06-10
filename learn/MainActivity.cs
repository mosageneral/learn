using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;
using Android;
using Android.Content;

namespace learn
{
    [Activity(Label = "learn", MainLauncher = true)]
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
        }

        private void Btnstart_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(select));
            StartActivity(intent);
        }
    }
}

