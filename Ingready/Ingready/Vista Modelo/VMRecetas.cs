using Ingready.Modelos;
using Ingready.Vistas;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ingready.Vista_Modelo
{
    public class VMRecetas : BaseVistaModelo
    {

        #region Datos para la conexion
        string host = "ec2-54-147-33-38.compute-1.amazonaws.com";
        string port = "5432";
        string user = "vdppsccsqxqemn";
        string database = "d25f8kt0526tsd";
        string password = "8363ac24e726dd56e7e362f63a6b44c3789822b89fc7d174fe0d8e53bf17cca3";
        #endregion

        public List<ClaseRecetas> _listarecetas = new List<ClaseRecetas>();

        public List<ClaseRecetas> listarecetas 
        {
            get {return _listarecetas;} 
        }

        

        #region Constructor
        public VMRecetas(INavigation navigation)
        {
            Navigation = navigation;
            CargarDatos();
        }
        #endregion

        #region Procesos
        public async Task iraPaginaDetalles(ClaseRecetas detallesRecetas)
        {
            await Navigation.PushAsync(new DetalleReceta(detallesRecetas));
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
                _listarecetas.Add(new ClaseRecetas(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
            }

            conn.Close();
        }

        #endregion

        #region Comandos
        public ICommand paginaDetalle => new Command<ClaseRecetas>(async(parametro) => await iraPaginaDetalles(parametro));
        #endregion

    }
}
