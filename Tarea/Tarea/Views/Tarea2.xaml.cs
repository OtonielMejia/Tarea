using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tarea2 : ContentPage
    {
        public Tarea2()
        {
            InitializeComponent();
        }

        private void Btnenviar_Clicked(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txbnombre.Text) || string.IsNullOrEmpty(txbapellido.Text) || string.IsNullOrEmpty(txbedad.Text) || string.IsNullOrEmpty(txbcorreo.Text))
            {
                DisplayAlert("Error", "Por Favor Completar Todo.", "Aceptar");
            }
            else
            {
                
                InformacionPersona informacion = new InformacionPersona()
                {
                    nombre = txbnombre.Text,
                    apellido = txbapellido.Text,
                    edad = int.Parse(txbedad.Text),
                    correo = txbcorreo.Text
                };
                Navigation.PushAsync(new ResultadosTarea2() { BindingContext = informacion });
            }

        }
    }
}