using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Tarea.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tarea1 : ContentPage
    {
        static Controllers.FuncionesMatematicas funcionesMatematicas = new Controllers.FuncionesMatematicas();

        public Tarea1()
        {
            InitializeComponent();
        }

        private void BtnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero1.Text) || string.IsNullOrEmpty(numero2.Text))
            {
                DisplayAlert("Error", "Completar Todo.", "Aceptar");
            }
            else
            {

                double n1 = double.Parse(numero1.Text);
                double n2 = double.Parse(numero2.Text);


                Navigation.PushAsync(new ResultadosTarea1(funcionesMatematicas.Multi(n1, n2)));
            }


        }

        private void BtnSuma_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero1.Text) || string.IsNullOrEmpty(numero2.Text))
            {
                DisplayAlert("Error", "Completar Todo.", "Aceptar");
            }
            else
            {
  
                double n1 = double.Parse(numero1.Text);
                double n2 = double.Parse(numero2.Text);

                
                Navigation.PushAsync(new ResultadosTarea1(funcionesMatematicas.Sum(n1, n2)));
            }

        }

        private void BtnResta_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero1.Text) || string.IsNullOrEmpty(numero2.Text))
            {
                DisplayAlert("Error", "Completar Todo.", "Aceptar");
            }
            else
            {

                double n1 = double.Parse(numero1.Text);
                double n2 = double.Parse(numero2.Text);


                Navigation.PushAsync(new ResultadosTarea1(funcionesMatematicas.Res(n1, n2)));
            }


        }

        private void BtnDivision_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero1.Text) || string.IsNullOrEmpty(numero2.Text))
            {
                DisplayAlert("Error", "Completar Todo.", "Aceptar");
            }
            else
            {

                double n1 = double.Parse(numero1.Text);
                double n2 = double.Parse(numero2.Text);


                Navigation.PushAsync(new ResultadosTarea1(funcionesMatematicas.Div(n1, n2)));
            }


        }
    }
}