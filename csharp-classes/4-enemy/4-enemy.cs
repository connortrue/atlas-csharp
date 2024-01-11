using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie entity.
    /// </summary>
    public class Zombie
    {
        private int health; // private field for health
        private string name = "No name"; // private field for name with default value

        /// <summary>
        /// Initializes a new instance of the Zombie class with default health value 0 and default name "No name".
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with the specified health value and default name "No name".
        /// </summary>
        /// <param name="value">The health value.</param>
        /// <exception cref="ArgumentException">Thrown when the health value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Gets or sets the name of the Zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the health value of the Zombie object.
        /// </summary>
        /// <returns>The health value of the Zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
