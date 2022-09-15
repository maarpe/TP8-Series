using System.Runtime.InteropServices.ComTypes;
using System.IO.Compression;
using System.Security.Cryptography;
using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;



namespace TP8_Series.Models
{
    public class BD
    {

        private static string _connectionString = @"Server=A-PHZ2-CIDI-030; DataBase=BDSeries;Trusted_Connection=True;";

        private static List<Actores> listaActores = new List<Actores>();
        private static List<Series> listaSeries = new List<Series>();
        


        public static List<Actores> TraerActores(int idActor)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Actores where IdActor = @pidActor";
                listaActores = db.Query<Actores>(sql, new {pidActor = idActor }).ToList();
            }
            return listaActores;
        }
        public static List<Series> TraerSeries(int idS)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Series where IdSerie = @pidSerie";
                listaSeries = db.Query<Series>(sql, new {pidSerie = idS }).ToList();
            }
            return listaSeries;
        }

        public static Series verInfoSerie(int idS)
        {
            Series serieActual = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series WHERE IdSerie = @idSerieActual";
                serieActual = db.QueryFirstOrDefault<Series>(sql,new {idSerieActual = idS});
            }
            return serieActual;
        }








    }
}

