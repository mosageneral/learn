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
using Android.Speech.Tts;
using Android;
using Android.Gms.Ads;

namespace learn
{
    [Activity(Label = "sea")]
    public class sea : Activity
    {
        TextToSpeech textToSpeech;

        Button b1, b2, b3, b4, b5, b6, b7, b8, b9, b10,
            b11, b12, b13, b14, b15, b16, b17, b18, b19, b20,
            b21, b22, b23, b24, b25, b26, b27, b28, b29, b30,
            b31, b32, b33,b34, b35, b36, b37, b38, b39, b40,
            b41, b42, b43, b44, b45, b46, b47, b48, b49, b50;
        Java.Util.Locale lang;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.sea );
            AdView mAdView = FindViewById<AdView>(Resource.Id.adView1);
            var adRequest = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView.LoadAd(adRequest);
            b1 = FindViewById<Button>(Resource.Id.b1); 
            b2 = FindViewById<Button>(Resource.Id.b2);
            b3 = FindViewById<Button>(Resource.Id.b3);
            b4 = FindViewById<Button>(Resource.Id.b4);
            b5 = FindViewById<Button>(Resource.Id.b5);
            b6 = FindViewById<Button>(Resource.Id.b6);
            b7 = FindViewById<Button>(Resource.Id.b7);
            b8 = FindViewById<Button>(Resource.Id.b8);
            b9 = FindViewById<Button>(Resource.Id.b9);
            b10 = FindViewById<Button>(Resource.Id.b10);
            b11 = FindViewById<Button>(Resource.Id.b11);
            b12 = FindViewById<Button>(Resource.Id.b12);
            b13 = FindViewById<Button>(Resource.Id.b13);
            b14 = FindViewById<Button>(Resource.Id.b14);
            b15 = FindViewById<Button>(Resource.Id.b15);
            b16 = FindViewById<Button>(Resource.Id.b16);
            b17= FindViewById<Button>(Resource.Id.b17);
            b18 = FindViewById<Button>(Resource.Id.b18);
            b19 = FindViewById<Button>(Resource.Id.b19);
            b20 = FindViewById<Button>(Resource.Id.b20);
            b21 = FindViewById<Button>(Resource.Id.b21);
         /*   b22 = FindViewById<Button>(Resource.Id.b22);
            b23 = FindViewById<Button>(Resource.Id.b23);
            b24 = FindViewById<Button>(Resource.Id.b24);
            b25 = FindViewById<Button>(Resource.Id.b25);
            b26 = FindViewById<Button>(Resource.Id.b26);
            b27 = FindViewById<Button>(Resource.Id.b27);
            b28 = FindViewById<Button>(Resource.Id.b28);
            b29 = FindViewById<Button>(Resource.Id.b29);
            b30 = FindViewById<Button>(Resource.Id.b30);
            b31 = FindViewById<Button>(Resource.Id.b31);
            b32 = FindViewById<Button>(Resource.Id.b32);
            b33 = FindViewById<Button>(Resource.Id.b33);
            b34 = FindViewById<Button>(Resource.Id.b34);
            b35 = FindViewById<Button>(Resource.Id.b35);
            b36 = FindViewById<Button>(Resource.Id.b36);
            b37 = FindViewById<Button>(Resource.Id.b37);
            b38 = FindViewById<Button>(Resource.Id.b38);
            b39 = FindViewById<Button>(Resource.Id.b39);
            b40= FindViewById<Button>(Resource.Id.b40);
            b41 = FindViewById<Button>(Resource.Id.b41);
            b42 = FindViewById<Button>(Resource.Id.b42);
            b43 = FindViewById<Button>(Resource.Id.b43);
            b44= FindViewById<Button>(Resource.Id.b44);
            b45= FindViewById<Button>(Resource.Id.b45);
            b46 = FindViewById<Button>(Resource.Id.b46);
            b47 = FindViewById<Button>(Resource.Id.b47);
            b48 = FindViewById<Button>(Resource.Id.b48);
            b49 = FindViewById<Button>(Resource.Id.b49);
            b50 = FindViewById<Button>(Resource.Id.b50);*/
            b1.Click += B1_Click;
            b2.Click += B2_Click;
            b3.Click += B3_Click;
            b4.Click += B4_Click;
            b5.Click += B5_Click;
            b6.Click += B6_Click;
            b7.Click += B7_Click;
            b8.Click += B8_Click;
            b9.Click += B9_Click;
            b10.Click += B10_Click;
            b11.Click += B11_Click;
            b12.Click += B12_Click;
            b13.Click += B13_Click;
            b14.Click += B14_Click;
            b15.Click += B15_Click;
            b16.Click += B16_Click;
            b17.Click += B17_Click;
            b18.Click += B18_Click;
            b19.Click += B19_Click;
            b20.Click += B20_Click;
            b21.Click += B21_Click;
           /* b22.Click += B22_Click;
            b23.Click += B23_Click;
            b24.Click += B24_Click;
            b25.Click += B25_Click;
            b26.Click += B26_Click;
            b27.Click += B27_Click;
            b28.Click += B28_Click;
            b29.Click += B29_Click;
            b30.Click += B30_Click;
            b31.Click += B31_Click;
            b32.Click += B32_Click;
            b33.Click += B33_Click;
            b34.Click += B34_Click;
            b35.Click += B35_Click;
            b36.Click += B36_Click;
            b37.Click += B37_Click;
            b38.Click += B38_Click;
            b39.Click += B39_Click;
            b40.Click += B40_Click;
            b41.Click += B41_Click;
            b42.Click += B42_Click;
            b43.Click += B43_Click;
            b44.Click += B44_Click;
            b45.Click += B45_Click;
            b46.Click += B46_Click;
            b47.Click += B47_Click;
            b48.Click += B48_Click;
            b49.Click += B49_Click;
            b50.Click += B50_Click;*/
           

            textToSpeech = new TextToSpeech(this, null, "com.google.android.tts");


            lang = Java.Util.Locale.Default;
            textToSpeech.SetLanguage(lang);

            // set the speed and pitch
            textToSpeech.SetPitch(1.00f);
            textToSpeech.SetSpeechRate(.8f);
            
        }

     /*   private void B50_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b50.Text))
                textToSpeech.Speak(b50.Text, QueueMode.Flush, null);
        }

        private void B49_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b49.Text))
                textToSpeech.Speak(b49.Text, QueueMode.Flush, null);
        }

        private void B48_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b48.Text))
                textToSpeech.Speak(b48.Text, QueueMode.Flush, null);
        }

        private void B46_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b46.Text))
                textToSpeech.Speak(b46.Text, QueueMode.Flush, null);
        }

        private void B47_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b47.Text))
                textToSpeech.Speak(b47.Text, QueueMode.Flush, null);
        }

        private void B45_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b45.Text))
                textToSpeech.Speak(b45.Text, QueueMode.Flush, null);
        }

        private void B44_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b44.Text))
                textToSpeech.Speak(b44.Text, QueueMode.Flush, null);
        }

        private void B43_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b43.Text))
                textToSpeech.Speak(b43.Text, QueueMode.Flush, null);
        }

        private void B42_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b42.Text))
                textToSpeech.Speak(b42.Text, QueueMode.Flush, null);
        }

        private void B41_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b41.Text))
                textToSpeech.Speak(b41.Text, QueueMode.Flush, null);
        }

        private void B40_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b40.Text))
                textToSpeech.Speak(b40.Text, QueueMode.Flush, null);
        }

        private void B39_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b39.Text))
                textToSpeech.Speak(b39.Text, QueueMode.Flush, null);
        }

        private void B38_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b38.Text))
                textToSpeech.Speak(b38.Text, QueueMode.Flush, null);
        }

        private void B37_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b37.Text))
                textToSpeech.Speak(b37.Text, QueueMode.Flush, null);
        }

        private void B36_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b36.Text))
                textToSpeech.Speak(b36.Text, QueueMode.Flush, null);
        }

        private void B35_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b35.Text))
                textToSpeech.Speak(b35.Text, QueueMode.Flush, null);
        }

        private void B34_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b34.Text))
                textToSpeech.Speak(b34.Text, QueueMode.Flush, null);
        }

        private void B33_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b33.Text))
                textToSpeech.Speak(b33.Text, QueueMode.Flush, null);
        }

        private void B32_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b32.Text))
                textToSpeech.Speak(b32.Text, QueueMode.Flush, null);
        }

        private void B31_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b31.Text))
                textToSpeech.Speak(b31.Text, QueueMode.Flush, null);
        }

        private void B30_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b30.Text))
                textToSpeech.Speak(b30.Text, QueueMode.Flush, null);
        }

        private void B29_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b29.Text))
                textToSpeech.Speak(b29.Text, QueueMode.Flush, null);
        }

        private void B28_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b28.Text))
                textToSpeech.Speak(b28.Text, QueueMode.Flush, null);
        }

        private void B27_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b27.Text))
                textToSpeech.Speak(b27.Text, QueueMode.Flush, null);
        }

        private void B26_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b26.Text))
                textToSpeech.Speak(b26.Text, QueueMode.Flush, null);
        }

        private void B25_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b25.Text))
                textToSpeech.Speak(b25.Text, QueueMode.Flush, null);
        }

        private void B24_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b24.Text))
                textToSpeech.Speak(b24.Text, QueueMode.Flush, null);
        }

        private void B23_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b23.Text))
                textToSpeech.Speak(b23.Text, QueueMode.Flush, null);
        }

        private void B22_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b22.Text))
                textToSpeech.Speak(b22.Text, QueueMode.Flush, null);
        }*/

        private void B21_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b21.Text))
                textToSpeech.Speak(b21.Text, QueueMode.Flush, null);
        }

        private void B20_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b20.Text))
                textToSpeech.Speak(b20.Text, QueueMode.Flush, null);
        }

        private void B19_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b19.Text))
                textToSpeech.Speak(b19.Text, QueueMode.Flush, null);
        }

        private void B18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b18.Text))
                textToSpeech.Speak(b18.Text, QueueMode.Flush, null);
        }

        private void B17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b17.Text))
                textToSpeech.Speak(b17.Text, QueueMode.Flush, null);
        }

        private void B16_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b16.Text))
                textToSpeech.Speak(b16.Text, QueueMode.Flush, null);
        }

        private void B15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b15.Text))
                textToSpeech.Speak(b15.Text, QueueMode.Flush, null);
        }

        private void B14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b14.Text))
                textToSpeech.Speak(b14.Text, QueueMode.Flush, null);
        }

        private void B13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b13.Text))
                textToSpeech.Speak(b13.Text, QueueMode.Flush, null);
        }

        private void B12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b12.Text))
                textToSpeech.Speak(b12.Text, QueueMode.Flush, null);
        }

        private void B11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b11.Text))
                textToSpeech.Speak(b11.Text, QueueMode.Flush, null);
        }

        private void B10_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b10.Text))
                textToSpeech.Speak(b10.Text, QueueMode.Flush, null);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b9.Text))
                textToSpeech.Speak(b9.Text, QueueMode.Flush, null);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b8.Text))
                textToSpeech.Speak(b8.Text, QueueMode.Flush, null);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b7.Text))
                textToSpeech.Speak(b7.Text, QueueMode.Flush, null);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b6.Text))
                textToSpeech.Speak(b6.Text, QueueMode.Flush, null);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b5.Text))
                textToSpeech.Speak(b5.Text, QueueMode.Flush, null);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b4.Text))
                textToSpeech.Speak(b4.Text, QueueMode.Flush, null);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b3.Text))
                textToSpeech.Speak(b3.Text, QueueMode.Flush, null);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b2.Text))
                textToSpeech.Speak(b2.Text, QueueMode.Flush, null);
        }

        private void B1_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(b1.Text))
                textToSpeech.Speak(b1.Text, QueueMode.Flush, null);
        }

      
    }
}