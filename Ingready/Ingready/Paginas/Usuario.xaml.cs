using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ingready
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Usuario : ContentPage
    {
        public Usuario()
        {
            InitializeComponent();
        }

        string host = "ec2-54-147-33-38.compute-1.amazonaws.com";
        string port = "5432";
        string user = "vdppsccsqxqemn";
        string database = "d25f8kt0526tsd";
        string password = "8363ac24e726dd56e7e362f63a6b44c3789822b89fc7d174fe0d8e53bf17cca3";

        private void btnCrear_Clicked(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection($"Server={host}; Port={port}; User Id={user};Password = {password}; Database={database};Pooling=true;Use SSL Stream=True;SSL Mode=Require;TrustServerCertificate=True;");

            try
            {
                conn.Open();
                DisplayAlert("Servidor", "Conectado correctamente", "Ok");
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}