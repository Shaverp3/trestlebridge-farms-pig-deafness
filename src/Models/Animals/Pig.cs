﻿using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Pig : IResource, IGrazing, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        public string Type { get; } = "Pig";
        public double GrassPerDay { get; set; } = 3.2;
        private Double _meatProduced = 8.4;
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public void Graze()
        {
            Console.WriteLine($"Pig {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }
        
        public override string ToString () {
            return $"Pig {this._shortId}. Oink!";
        }

        public string SendAnimalType()
        {
            return Type;
        }
    }
}