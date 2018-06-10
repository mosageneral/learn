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
    [Activity(Label = "letters")]
    public class letters : Activity
    {
        TextToSpeech textToSpeech;
       

        Java.Util.Locale lang;
        Button a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,w,s,r,p,q,t,y,u,z,x,v,one,two,three,four,five,six,seven,eight,nine,ten;
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.letters);

            AdView mAdView = FindViewById<AdView>(Resource.Id.adView1);
            var adRequest = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView.LoadAd(adRequest);


            textToSpeech = new TextToSpeech(this, null, "com.google.android.tts");


            lang = Java.Util.Locale.Default;
            textToSpeech.SetLanguage(lang);

            // set the speed and pitch
            textToSpeech.SetPitch(1.00f);
            textToSpeech.SetSpeechRate(.8f);



             a = FindViewById<Button>(Resource.Id.a);
            b = FindViewById<Button>(Resource.Id.b);
            c = FindViewById<Button>(Resource.Id.c);
            d = FindViewById<Button>(Resource.Id.d);
            e = FindViewById<Button>(Resource.Id.e);
            f = FindViewById<Button>(Resource.Id.f);
            g = FindViewById<Button>(Resource.Id.g);
            h = FindViewById<Button>(Resource.Id.h);
            i = FindViewById<Button>(Resource.Id.i);
            j = FindViewById<Button>(Resource.Id.j);
            k = FindViewById<Button>(Resource.Id.k);
            l = FindViewById<Button>(Resource.Id.l);
            m = FindViewById<Button>(Resource.Id.m);
            n = FindViewById<Button>(Resource.Id.n);
            o = FindViewById<Button>(Resource.Id.o);
            p = FindViewById<Button>(Resource.Id.p);
            u = FindViewById<Button>(Resource.Id.u);
            q = FindViewById<Button>(Resource.Id.q);
            r = FindViewById<Button>(Resource.Id.r);
            s = FindViewById<Button>(Resource.Id.s);
            w = FindViewById<Button>(Resource.Id.w);
            v = FindViewById<Button>(Resource.Id.v);
            x = FindViewById<Button>(Resource.Id.x);
            y = FindViewById<Button>(Resource.Id.y);
            z = FindViewById<Button>(Resource.Id.z);
            one = FindViewById<Button>(Resource.Id.one);
            two = FindViewById<Button>(Resource.Id.two);
            three = FindViewById<Button>(Resource.Id.three);
            four = FindViewById<Button>(Resource.Id.four);
            five = FindViewById<Button>(Resource.Id.five);
            six = FindViewById<Button>(Resource.Id.six);
            seven = FindViewById<Button>(Resource.Id.seven);
            eight = FindViewById<Button>(Resource.Id.eight);
            nine = FindViewById<Button>(Resource.Id.nine);
            ten = FindViewById<Button>(Resource.Id.ten);
            t = FindViewById<Button>(Resource.Id.t);
            
            a.Click +=  A_Click;
            b.Click += B_Click;
            c.Click += C_Click;
            d.Click += D_Click;
            e.Click += E_Click;
            f.Click += F_Click;
            g.Click += G_Click;
            h.Click += H_Click;
            i.Click += I_Click;
            k.Click += K_Click;

            w.Click += w_Click;
            k.Click += K_Click;
            l.Click += L_Click;
            m.Click += M_Click;
            n.Click += N_Click;
            o.Click += O_Click;
            j.Click += J_Click;
            t.Click += T_Click;
            q.Click += Q_Click;
            p.Click += P_Click;
            r.Click += R_Click;
            s.Click += S_Click;
            u.Click += U_Click;
            v.Click += V_Click;
            x.Click += X_Click;

            z.Click += Z_Click;
            one.Click += One_Click;
            two.Click += Two_Click;
            three.Click += Three_Click;
            four.Click += Four_Click;
            five.Click += Five_Click;
            six.Click += Six_Click;
            seven.Click += Seven_Click;
            eight.Click += Eight_Click;
            nine.Click += Nine_Click;
            ten.Click += Ten_Click;
            y.Click += y_Click;






        }
        private void k_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(k.Text))
                textToSpeech.Speak(k.Text, QueueMode.Flush, null);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(z.Text))
                textToSpeech.Speak(z.Text, QueueMode.Flush, null);
        }
        
        private void w_Click1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(w.Text))
                textToSpeech.Speak(w.Text, QueueMode.Flush, null);
        }

        private void Ten_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ten.Text))
                textToSpeech.Speak(ten.Text, QueueMode.Flush, null);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nine .Text))
                textToSpeech.Speak(nine.Text, QueueMode.Flush, null);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(eight .Text))
                textToSpeech.Speak(eight .Text, QueueMode.Flush, null);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(seven .Text))
                textToSpeech.Speak(seven .Text, QueueMode.Flush, null);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(six.Text))
                textToSpeech.Speak(six.Text, QueueMode.Flush, null);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(five.Text))
                textToSpeech.Speak(five.Text, QueueMode.Flush, null);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(four.Text))
                textToSpeech.Speak(four.Text, QueueMode.Flush, null);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(three.Text))
                textToSpeech.Speak(three.Text, QueueMode.Flush, null);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(two.Text))
                textToSpeech.Speak(two.Text, QueueMode.Flush, null);
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(one.Text))
                textToSpeech.Speak(one.Text, QueueMode.Flush, null);
        }

        private void y_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(y.Text))
                textToSpeech.Speak(y.Text, QueueMode.Flush, null);
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(x.Text))
                textToSpeech.Speak(x.Text, QueueMode.Flush, null);
        }

        private void V_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(v.Text))
                textToSpeech.Speak(v.Text, QueueMode.Flush, null);
        }

        private void U_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(u.Text))
                textToSpeech.Speak(u.Text, QueueMode.Flush, null);
        }

        private void S_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(s.Text))
                textToSpeech.Speak(s.Text, QueueMode.Flush, null);
        }

        private void R_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(r.Text))
                textToSpeech.Speak(r.Text, QueueMode.Flush, null);
        }

        private void P_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(p.Text))
                textToSpeech.Speak(p.Text, QueueMode.Flush, null);
        }

        private void Q_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(q.Text))
                textToSpeech.Speak(q.Text, QueueMode.Flush, null);
        }

        private void T_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t.Text))
                textToSpeech.Speak(t.Text, QueueMode.Flush, null);
        }

        private void J_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(j.Text))
                textToSpeech.Speak(j.Text, QueueMode.Flush, null);
        }

        private void O_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(o.Text))
                textToSpeech.Speak(o.Text, QueueMode.Flush, null);
        }

        private void N_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(n.Text))
                textToSpeech.Speak(n.Text, QueueMode.Flush, null);
        }

        private void M_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(m.Text))
                textToSpeech.Speak(m.Text, QueueMode.Flush, null);
        }

        private void L_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(l.Text))
                textToSpeech.Speak(l.Text, QueueMode.Flush, null);
        }

        private void K_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(k.Text))
                textToSpeech.Speak(k.Text, QueueMode.Flush, null);
        }

        private void w_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(w.Text))
                textToSpeech.Speak(w.Text, QueueMode.Flush, null);
        }

        private void I_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(i.Text))
                textToSpeech.Speak(i.Text, QueueMode.Flush, null);
        }

        private void H_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(h.Text))
                textToSpeech.Speak(h.Text, QueueMode.Flush, null);
        }

        private void G_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(g.Text))
                textToSpeech.Speak(g.Text, QueueMode.Flush, null);
        }

        private void F_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(f.Text))
                textToSpeech.Speak(f.Text, QueueMode.Flush, null);
        }

        private void E_Click(object sender, EventArgs p)
        {
            if (!string.IsNullOrEmpty(e.Text))
                textToSpeech.Speak(e.Text, QueueMode.Flush, null);
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(d.Text))
                textToSpeech.Speak(d.Text, QueueMode.Flush, null);
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(c.Text))
                textToSpeech.Speak(c.Text, QueueMode.Flush, null);
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(b.Text))
                textToSpeech.Speak(b.Text, QueueMode.Flush, null);
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(a.Text))
                textToSpeech.Speak(a.Text, QueueMode.Flush, null);
        }

        

      
    }
}