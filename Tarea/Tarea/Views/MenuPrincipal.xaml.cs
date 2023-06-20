using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTarea1_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Views.Tarea1());
        }

        private void btnTarea2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Tarea2());
        }
    }
}