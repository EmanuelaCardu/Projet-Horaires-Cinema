using DAL_Projet_Cinema.Entities;
using Microsoft.Extensions.Configuration;
using Shared_Projet_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using DAL_Projet_Cinema.Mappers;

namespace DAL_Projet_Cinema.Services
{
    public class CinemaPlaceService : BaseService, ICinemaPlaceRepository<CinemaPlace>
    {
        public CinemaPlaceService(IConfiguration configuration, string dbname) : base(configuration, "DB-Projet-Cinema")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<CinemaPlace> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_GetAll.sql";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCinemaPlace();
                        }
                    }
                }
            }
        }

        public CinemaPlace Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCinemaPlace();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }

        public int Insert(CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Name", data.Name);
                    command.Parameters.AddWithValue("City", data.City);
                    command.Parameters.AddWithValue("Street", data.Street);
                    command.Parameters.AddWithValue("Number", data.Number);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Update.sql";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Name", data.Name);
                    command.Parameters.AddWithValue("City", data.City);
                    command.Parameters.AddWithValue("Street", data.Street);
                    command.Parameters.AddWithValue("Number", data.Number);

                }

            }
        }
    }
}
