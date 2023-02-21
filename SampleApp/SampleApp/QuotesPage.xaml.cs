using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleApp
{
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
            string[] quotes =
            {
                "The greatest glory in living lies not in never falling, but in rising every time we fall."
            };
            label1.Text = quotes[0];
        }
    }
}

