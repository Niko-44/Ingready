using Ingready.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ingready.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Recetas : ContentPage
    {
        #region BasedeDatos
        string host = "ec2-54-147-33-38.compute-1.amazonaws.com";
        string port = "5432";
        string user = "vdppsccsqxqemn";
        string database = "d25f8kt0526tsd";
        string password = "8363ac24e726dd56e7e362f63a6b44c3789822b89fc7d174fe0d8e53bf17cca3";
        #endregion


        public List<ClaseRecetas> listarecetas = new List<ClaseRecetas>();

        public Recetas()
        {
            InitializeComponent();
        }

        private void btnCargar_Clicked(object sender, EventArgs e)
        {
            ClaseRecetas recetas = new ClaseRecetas();

            ///Conectar a la base de datos-----------------------------------
            NpgsqlConnection conn = new NpgsqlConnection($"Server={host}; Port={port}; User Id={user};Password = {password}; Database={database};Pooling=true;Use SSL Stream=True;SSL Mode=Require;TrustServerCertificate=True;");

            string tablaReceta = $"Select * from tabla";
            NpgsqlCommand command = new NpgsqlCommand(tablaReceta, conn);
            
            conn.Close();
            conn.Open();

            ///Conectar a la base de datos-----------------------------------

            for (int i = 0; i < 10; i++)
            {
                recetas.Nombre = txtNombre.Text;
                recetas.Imagen = txtImagen.Text;
                recetas.Ingredientes = txtIngrediente.Text;

                listarecetas.Add(recetas);
            }

            cvRecetas.ItemsSource = listarecetas;
        }
    }
}