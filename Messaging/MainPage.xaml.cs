using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Messaging
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DoSubscribe();
        }
        public void OnClick(object o, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        public void DoSubscribe()
        {
            MessagingCenter.Subscribe<MainPage>(this,"Change",(sender)=> { Label1.Text = "Goodbye"; });
        }
    }
}
