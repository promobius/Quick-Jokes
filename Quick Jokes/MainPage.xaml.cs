using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;

namespace Quick_Jokes
{
    public partial class MainPage : ContentPage
    {

        private int count = 0;
        private int count2 = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void IncrementCounterClicked(object sender, EventArgs e)
        {
            count++;
            response1.Text = count.ToString();
        }
        private void IncrementCounterClicked2(object sender, EventArgs e)
        {
            count2++;
            response2.Text = count2.ToString();
        }
    }
}

