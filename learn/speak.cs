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

namespace learn
{
    [Activity(Label = "speak")]
    public class speak : Activity
    {
        TextToSpeech textToSpeech;
        Context context;

        Java.Util.Locale lang;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.speak);
            var btnSayIt = FindViewById<Button>(Resource.Id.btnSpeak);
            var editWhatToSay = FindViewById<EditText>(Resource.Id.editSpeech);

            context = btnSayIt.Context;


            textToSpeech = new TextToSpeech(this, null, "com.google.android.tts");


            lang = Java.Util.Locale.Default;
            textToSpeech.SetLanguage(lang);

            // set the speed and pitch
            textToSpeech.SetPitch(1.00f);
            textToSpeech.SetSpeechRate(.8f);

            // connect up the events
            btnSayIt.Click += delegate
            {
                // if there is nothing to say, don't say it
                if (!string.IsNullOrEmpty(editWhatToSay.Text))
                    textToSpeech.Speak(editWhatToSay.Text, QueueMode.Flush, null);
            };
        }
    }
}