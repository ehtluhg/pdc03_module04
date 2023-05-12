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
    public partial class activity03_2 : ContentPage
    {
        public activity03_2()
        {
            InitializeComponent();
        }

        private async void onPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}