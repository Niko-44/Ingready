﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ingready.Modelos
{
    public class ClaseRecetas
    {
        private string nombre;
        private string ingrediente;
        private string imagen;

        public string Nombre { get{return nombre;} set {nombre = value;} }
        public string Ingredientes { get { return ingrediente; } set { ingrediente = value; } }
        public string Imagen { get { return imagen; } set { imagen = value; } }
    }
}
