using MisPersonasApp.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using Xamarin.Forms;

namespace MisPersonasApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://mispersonas-api-demo.azurewebsites.net/api/search?id=" + IdNumber.Text);

                if (!response.IsSuccessStatusCode)
                {
                    await DisplayAlert("MisPersonas", "No se encuentra el DNI", "OK");
                    return;
                }

                var json = await response.Content.ReadAsStringAsync();

                var persona = JsonConvert.DeserializeObject<Persona>(json);

                Application.Current.MainPage = new DetailPage(persona);
            }

        }
    }
}
