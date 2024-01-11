using System;

namespace Enemies
{
    public class Zombie
    {
        private int health; // private field for health
        private string name = "No name"; // private field for name with default value

        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int GetHealth()
        {
            return health;
        }

        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
