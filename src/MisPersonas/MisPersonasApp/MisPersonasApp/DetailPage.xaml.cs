using System;
using Xamarin.Forms;
using MisPersonasApp.Models;

namespace MisPersonasApp
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        public DetailPage(Persona data)
        {
            InitializeComponent();

            Nombre.Text = data.Nombre;
            Direccion.Text = data.Direccion;
            Localidad.Text = data.Localidad;
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void Map_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com.ar/maps/search/" + Uri.EscapeUriString(Direccion.Text) + "," + Uri.EscapeUriString(Localidad.Text)));
        }
    }
}
