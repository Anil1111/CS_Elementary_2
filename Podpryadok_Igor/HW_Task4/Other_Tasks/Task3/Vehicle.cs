﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3 - Создать класс Vehicle.
//В теле класса создайте поля: координаты и параметры средств передвижения(цена, скорость, год выпуска). 
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
namespace Task3
{
    class Vehicle
    {
        private double coordinateX;
        public double coordinateY;
        public double price;
        public double speed;
        public int sinceYear;

        public double CoordinateX { get => coordinateX; set => coordinateX = value; }

        public Vehicle()
        {

        }
    }

    class Plane : Vehicle
    {

    }

    class Ship : Vehicle
    {

    }

    class Car : Vehicle
    {

    }
}
