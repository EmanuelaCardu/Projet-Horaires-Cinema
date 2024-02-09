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
    public class DiffusionService : BaseService, IDiffusionRepository<Diffusion>
    {
        public DiffusionService(IConfiguration configuration) : base(configuration, "DB-Projet-Cinema")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Diffusion", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Diffusion> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDiffusion();
                        }
                    }
                }
            }
        }

        public Diffusion Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Diffusion", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToDiffusion();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }


        public int Insert(Diffusion data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("DiffusionDate", data.DiffusionDate);
                    command.Parameters.AddWithValue("DiffusionTime", data.DiffusionTime);
                    command.Parameters.AddWithValue("AudioLang", data.AudioLang);
                    command.Parameters.AddWithValue("SubTitleLang", data.SubTitleLang ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("Id_CinemaRoom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("Id_Movie", data.Id_Movie);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public void Update(Diffusion data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Diffusion", data.Id_Diffusion);
                    command.Parameters.AddWithValue("DiffusionDate", data.DiffusionDate);
                    command.Parameters.AddWithValue("DiffusionTime", data.DiffusionTime);
                    command.Parameters.AddWithValue("AudioLang", data.AudioLang);
                    command.Parameters.AddWithValue("SubTitleLang", data.SubTitleLang ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("Id_CinemaRoom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("Id_Movie", data.Id_Movie);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Movie), $"L'identifiant {data.Id_Diffusion} n'est" +
                            $" pas dans la base de donnée");

                }

            }
        }
        public IEnumerable<Diffusion> GetByCinemaPlace( int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_GetByCinemaPlace";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_cinemaPlace", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDiffusion();
                        }
                    }
                }
            }
        }


    }
}
