using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleApp
{
    public partial class QuotesPage : ContentPage
    {
        string[] quotes =
        {
            "The greatest glory in living lies not in never falling, but in rising every time we fall.",
            "The way to get started is to quit talking and begin doing.",
            "Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma – which is living with the results of other people's thinking.",
            "If life were predictable it would cease to be life, and be without flavor.",
            "If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success."
        };
        static int i = 0;
        public QuotesPage()
        {
            InitializeComponent();
            label1.Text = quotes[0];
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (i == quotes.Length-1)
                i = -1;
            label1.Text = quotes[++i];
        }
    }
}

