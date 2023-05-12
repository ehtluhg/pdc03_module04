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
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();
            SetupData();
            listView.ItemsSource = contacts;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushAsync(detailPage);
            }
        }
        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Audriel Bustarde",
                Age = 22,
                Occupation = "Physical Therapist",
                Country = "Georgia"
            });

            contacts.Add(new Contacts
            {
                Name = "Kirsten Fernandez",
                Age = 20,
                Occupation = "Professional Bystander",
                Country = "London"
            });

            contacts.Add(new Contacts
            {
                Name = "Aleeya Candelaria",
                Age = 21,
                Occupation = "Full Stack Developer",
                Country = "Hong Kong"
            });
        }
    }
}