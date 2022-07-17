using Ingready.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ingready.Vista_Modelo
{
    public class VMDetallesRecetas 
    {
        public INavigation Navigation;

        #region Constructor
        public VMDetallesRecetas(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region Procesos
        public async Task iraPaginaDetalles()
        {
            await Navigation.PushAsync(new DetalleReceta());
        }

        #endregion

        #region Comandos

        public ICommand paginaDetalle => new Command(async() => await iraPaginaDetalles());
        #endregion

    }
}
