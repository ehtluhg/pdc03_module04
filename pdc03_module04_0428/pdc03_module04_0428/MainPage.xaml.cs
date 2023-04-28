using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pdc03_module04_0428
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void activity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity01());
        }

        private async void activity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity02());
        }

    }
}
