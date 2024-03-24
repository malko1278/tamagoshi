// See https://aka.ms/new-console-template for more information
using System;

namespace App {
    class Animal {
        public int Heath { get; set; }
        private int _hunger;
        public int Hunger  { get; set; }
        public int Fatigue { get; set; }
        private String? _name;
        public String? Name {
            get => _name;
            set => _name = value;
        }
        
        public Animal() {
            Heath = 10;
            Hunger = 0;
            Fatigue = 0;
            Name = "";
        }

        public Animal(int levHeal, int levHung, int levFat, String name) {
            Heath = levHeal;
            Hunger = levHung;
            Fatigue = levFat;
            Name = name;
        }
    }
}
