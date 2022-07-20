using Ingready.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ingready.Vista_Modelo;
using Ingready.Vistas;

namespace Ingready.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Recetas : ContentPage
    {

        public Recetas()
        {
            InitializeComponent();
            BindingContext = new VMRecetas(Navigation);
        }

    }
}
