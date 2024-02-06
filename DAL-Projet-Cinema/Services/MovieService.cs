using DAL_Projet_Cinema.Entities;
using DAL_Projet_Cinema.Mappers;
using Microsoft.Extensions.Configuration;
using Shared_Projet_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DAL_Projet_Cinema.Services
{
    public class MovieService : BaseService, IMovieRepository<Movie>
    {

        //private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Projet-Cinema;Integrated Security=True";

        public MovieService(IConfiguration configuration) : base(configuration, "DB-Projet-Cinema")
        {
        }


        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_Movie", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Movie> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToMovie();
                        }
                    }
                }
            }
                
        }

        public Movie Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_Movie", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToMovie();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }

        public int Insert(Movie data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Title", data.Title);
                    command.Parameters.AddWithValue("SubTitle", data.SubTitle ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("ReleaseYear", data.ReleaseYear);
                    command.Parameters.AddWithValue("Synopsis", data.Synopsis);
                    command.Parameters.AddWithValue("PosterUrl", data.PosterUrl);
                    command.Parameters.AddWithValue("Duration", data.Duration);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Movie data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Movie", data.Id_Movie);
                    command.Parameters.AddWithValue("Title", data.Title);
                    command.Parameters.AddWithValue("SubTitle", data.SubTitle ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("ReleaseYear", data.ReleaseYear);
                    command.Parameters.AddWithValue("Synopsis", data.Synopsis);
                    command.Parameters.AddWithValue("PosterUrl", data.PosterUrl);
                    command.Parameters.AddWithValue("Duration", data.Duration);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Movie), $"L'identifiant {data.Id_Movie} n'est" +
                            $" pas dans la base de donnée");


                }

            }


        }
    }
}
