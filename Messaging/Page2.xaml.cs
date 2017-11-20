using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Messaging
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        public void OnClicked(object o, EventArgs e)
        {
            var mainPage = new MainPage();
            MessagingCenter.Send<MainPage>(mainPage, "Changed");
            Navigation.PopAsync();
        }
    }
}
