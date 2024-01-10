/// <summary>
/// The Enemies namespace.
/// </summary>
namespace Enemies
{
  /// <summary>
  /// Represents a zombie entity.
  /// </summary>
  public class Zombie
  {
      /// <summary>
      /// Gets or sets the health of the zombie.
      /// </summary>
      public int health;

      /// <summary>
      /// Initializes a new instance of the Zombie class with default health value 0.
      /// </summary>
      public Zombie()
      {
          health = 0;
      }

      /// <summary>
      /// Initializes a new instance of the Zombie class with the specified health value.
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
  }
}
