// See https://aka.ms/new-console-template for more information
using System;

namespace App {
    class Animal {
        // public int Heath { get; set; }
        public int _heath;
        public int Heath {
            get => _heath;
            set {
                if(value > 10)   _heath = 10;
                else   _heath = value;
            }
        }
        // public int Hunger { get; set; }
        private int _hunger;
        public int Hunger {
            get => _hunger;
            set {
                if(value < 0)   _hunger = 0;
                else   _hunger = value;
            }
        }
        public int Fatigue { get; set; }
        // public String? Name { get; set; }
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
