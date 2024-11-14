using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using MaestroLaHuesera.Modelo;
using System.Web.UI.WebControls;


namespace MaestroLaHuesera.Controlador
{
    public class Metodos
    {
        public static string ConsultaPelicula(Pelicula objPelicula)
        {
            try
            {
                SqlConnection conector = DB.conectar("LaHuesera");
                string consulta = "Select  *from Pelicula where Id= " + objPelicula.Id + " or " + objPelicula.Nombre;
                SqlDataReader table = DB.consulta(consulta, conector);

                if (table.Read())
                {
                    objPelicula.Id = Int32.Parse(table[1].ToString());
                    objPelicula.Nombre = table[2].ToString();
                    objPelicula.Genero = table[3].ToString();
                    objPelicula.Descripcion = table[4].ToString();
                    return "Encontrado";
                }
                else
                {

                    return "No encontrado";
                }

                DB.cerrar(conector);
            }
            catch (SqlException ex)
            {
                return "Error sql: " + ex.Message;
            }           
        }
    }
}