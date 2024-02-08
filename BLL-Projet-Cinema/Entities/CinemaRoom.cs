﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Projet_Cinema.Entities
{
    public class CinemaRoom
    {

        public int Id_CinemaRoom { get; set; }
        public int SeatsCount { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public bool Can3D { get; set; }
        public bool Can4DX { get; set; }
        public int Id_CinemaPlace { get; set; }

        public CinemaRoom(int id_CinemaRoom, int seatsCount, int screenWidth, int screenHeight, bool can3D, bool can4DX, int id_CinemaPlace)
        {
            Id_CinemaRoom = id_CinemaRoom;
            SeatsCount = seatsCount;
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            Can3D = can3D;
            Can4DX = can4DX;
            Id_CinemaPlace = id_CinemaPlace;
        }
    }
}