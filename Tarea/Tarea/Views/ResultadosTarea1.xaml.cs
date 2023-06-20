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
    public partial class ResultadosTarea1 : ContentPage
    {
        public ResultadosTarea1(double resultado)
        {
            InitializeComponent();
            Resultado.Text = $"Resultado: {resultado}";
        }
    }
}