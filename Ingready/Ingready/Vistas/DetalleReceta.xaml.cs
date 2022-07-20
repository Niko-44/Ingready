using Ingready.Modelos;
using Ingready.Vista_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ingready.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleReceta : ContentPage
    {

        public DetalleReceta(ClaseRecetas detalleReceta)
        {
            InitializeComponent();
            BindingContext = new VMDetalleReceta(Navigation);

            lblNombre.Text = detalleReceta.Nombre;
            lblImagen.Text = detalleReceta.Imagen;
            lblIngredientes.Text = detalleReceta.Ingredientes;
        }
    }
}