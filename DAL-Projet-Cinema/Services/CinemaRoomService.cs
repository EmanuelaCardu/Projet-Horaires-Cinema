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
    public class CinemaRoomService : BaseService, ICinemaRoomRepository<CinemaRoom>
    {

        public CinemaRoomService(IConfiguration configuration) : base(configuration, "DB-Projet-Cinema")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_CinemaRoom", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<CinemaRoom> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCinemaRoom();
                        }
                    }
                }
            }
        }

        public CinemaRoom Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_CinemaRoom", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCinemaRoom();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }

        public int Insert(CinemaRoom data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("SeatsCount", data.SeatsCount);
                    command.Parameters.AddWithValue("Number", data.Number);
                    command.Parameters.AddWithValue("ScreenWidth", data.ScreenWidth);
                    command.Parameters.AddWithValue("ScreenHeight", data.ScreenHeight);
                    command.Parameters.AddWithValue("Can3D", data.Can3D);
                    command.Parameters.AddWithValue("Can4DX ", data.Can4DX);
                    command.Parameters.AddWithValue("Id_CinemaPlace", data.Id_CinemaPlace);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
       
        
        public void Update(CinemaRoom data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_cinemaroom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("SeatsCount", data.SeatsCount);
                    command.Parameters.AddWithValue("ScreenWidth", data.ScreenWidth);
                    command.Parameters.AddWithValue("ScreenHeight", data.ScreenHeight);
                    command.Parameters.AddWithValue("Can3D", data.Can3D);
                    command.Parameters.AddWithValue("Can4DX ", data.Can4DX);
                    command.Parameters.AddWithValue("Id_CinemaPlace", data.Id_CinemaPlace);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_CinemaRoom), $"L'identifiant {data.Id_CinemaRoom} n'est" +
                            $" pas dans la base de donnée");


                }

            }
        }
        public IEnumerable<CinemaRoom> GetByCinemaPlace(int id)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT  * FROM [CinemaRoom] WHERE [Id_CinemaPlace] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCinemaRoom();
                        }
                    }
                }
            }

        }

    }
}
