using Ingready.VerModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ingready.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recetas : ContentPage
    {
        public Recetas()
        {
            InitializeComponent();
            BindingContext = new VerRecetas();
        }
    }
}