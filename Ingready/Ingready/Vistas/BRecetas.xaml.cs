﻿using Ingready.Modelos;
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
            BindingContext = new VMDetallesRecetas(Navigation);
            CargarDatos();
        }

        void CargarDatos()
        {
            ClaseRecetas recetas = new ClaseRecetas();

            ///Conectar a la base de datos-----------------------------------
            NpgsqlConnection conn = new NpgsqlConnection($"Server={host}; Port={port}; User Id={user};Password = {password}; Database={database};Pooling=true;Use SSL Stream=True;SSL Mode=Require;TrustServerCertificate=True;");

            string tablaReceta = "Select * from recetas";
            NpgsqlCommand command = new NpgsqlCommand(tablaReceta, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listarecetas.Add(new ClaseRecetas(reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
            }

            cvRecetas.ItemsSource = listarecetas;
            conn.Close();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetalleReceta());
        }
    }
}