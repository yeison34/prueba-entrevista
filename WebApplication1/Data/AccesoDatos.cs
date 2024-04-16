using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Data
{
    public class AccesoDatos
    {
        public static  NpgsqlConnection GetConnection() {
            string cadena = "Server=localhost;Port=5432; User Id=postgres;Password=3424;Database = preuba2024";
            NpgsqlConnection conn = null;
            try {
                conn= new NpgsqlConnection(cadena);
                conn.Open();
                
            }
            catch (Exception ex) {
                throw new Exception("No se pudo obtener connecion");
            }
            return conn;
        }
    }
}