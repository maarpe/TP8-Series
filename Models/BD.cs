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

        private static string _connectionString = @"Server=A-PHZ2-CIDI-013; DataBase=BDSeries;Trusted_Connection=True;";
        
        public static List<Actores> TraerActores(int idActor)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Actores where IdActor = @pidActor";
                return db.Query<Actores>(sql, new {@pidActor = idActor }).ToList();
            }
            
        }
        public static List<Series> TraerSeries()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Series";
                return db.Query<Series>(sql).ToList();
            }
        }

        public static Series verInfoSerie(int idS)
        {
            Series serieActual = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series WHERE IdSerie = @idSerieActual";
                serieActual = db.QueryFirstOrDefault<Series>(sql,new {@idSerieActual = idS});
            }
            return serieActual;
        }
        public static List<Temporadas> TraerTemporadas(int idS)
        {
           using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Temporadas where IdTemporada = @pidTemporada";
                return db.Query<Temporadas>(sql, new {@pidTemporada = idS }).ToList();
            }
        }








    }
}

