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
       /// Initializes a new instance of the Zombie class.
       /// </summary>
       public Zombie()
       {
           // Set the value of 'health' to 0 in the constructor
           health = 0;
       }
   }
}
