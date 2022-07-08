using Ingready.Paginas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ingready
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnRecetas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recetas());
        }
    }
}
