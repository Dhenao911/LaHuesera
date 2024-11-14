using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaestroLaHuesera.Controlador
{
    public class Pelicula
    {

        private int id;
        private string nombre;
        private string genero;
        private string descripcion;

        public Pelicula(int id, string nombre, string genero, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.genero = genero;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}