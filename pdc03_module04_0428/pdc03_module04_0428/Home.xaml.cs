using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pdc03_module04_0428
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
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

        private async void activity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity03());
        }

        private async void activity04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity04());
        }

        private async void activity05(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity05());
        }
    }
}