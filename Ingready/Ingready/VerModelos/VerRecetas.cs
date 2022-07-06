using Ingready.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ingready.VerModelos
{
    public class VerRecetas
    {
        public ObservableCollection<Recetas> Recetas { get; set; }

        public VerRecetas()
        {
            Recetas = new ObservableCollection<Recetas>
            {
                new Recetas
                {
                    Nombre = "Pizza",
                    Imagen = "ImgPizza",
                    Ingredientes = "Salsa"
                },
                new Recetas
                {
                    Nombre = "Jamon",
                    Imagen = "ImgJamon",
                    Ingredientes = "Salsa"
                },
                new Recetas
                {
                    Nombre = "Pan con queso",
                    Imagen = "ImgPan",
                    Ingredientes = "Salsa"
                }

            };
        }
    }
}
