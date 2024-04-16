using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PersonaData
    {
        public static void guardar(PersonaModel modelo) {
            try
            {
                string sql = "INSERT INTO persona (id,identificacion,nombre) values(@id,@identificacion,@nombre)";
                NpgsqlConnection conn = AccesoDatos.GetConnection();
                conn.Execute(sql,modelo);
            }
            catch { 
                
            }
        }

        public static List<PersonaModel> listarpersonas()
        {
            List<PersonaModel> lista= new List<PersonaModel>();
            try {
                string sql = "select *from persona";
                NpgsqlConnection conn = AccesoDatos.GetConnection();
                lista=conn.Query<PersonaModel>(sql).ToList();
            }
            catch (Exception ex) { 
            }
            return lista;
        }
    }
}