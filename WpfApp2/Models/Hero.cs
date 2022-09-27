using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public enum Side
    {
        Good,
        Bad,
        Neutral
    }
    public class Hero : ObservableObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        private int strength;

        public int Strength
        {
            get { return strength; }
            set { SetProperty(ref strength, value); }
        }
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { SetProperty(ref speed, value); }
        }

        private Side heroSide;

        public Side HeroSide
        {
            get { return heroSide; }
            set { heroSide = value; }
        }

        public Hero GetCopy()
        {
            return new Hero
            {
                Name = this.Name,
                Strength = this.Strength,
                Speed = this.Speed,
                HeroSide = this.HeroSide
            };
        }
    }
}
