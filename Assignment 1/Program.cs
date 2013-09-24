using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAM1516_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some initialization
            EntityManager testEntities = new EntityManager(5);
            testEntities.EntityArray[0] = new GameEntity("Bob", 33);
            testEntities.EntityArray[1] = new GameEntity("Bill", 52, 200);
            testEntities.EntityArray[2] = new GameEntity("Wolfgang", 3, 300);
            testEntities.EntityArray[3] = new GameEntity("Blobby", 666, 444);
            testEntities.EntityArray[4] = new GameEntity("The Fifth Element", 111, 222);

            var varEntity1 = new GameEntity();
            var varEntity2 = new GameEntity();

            // 1 - Array of size of passed parameter (4)
            EntityManager Entities = new EntityManager(4);  // Creates an Entity containing 4 GameEntities
            Console.WriteLine("Test Case: We've created an array of size of passed parameter (4)");
            Console.WriteLine("Here's the contents of the new array at Stage 1:\n");
            
            Entities.PrintAllEntities();                   // Print all entities to screen.

            // 2 - Add some Entries
            Console.WriteLine("Let's add 5 entries to the array!\n");
            
            for (int j = 0; j < 5; j++)
                // Attempts to add the five entities created in part 1.0 above to the newly created EntityManager array
                // A 'Failed Entry' message appears because the fifth element cannot be added, as there are no more NULL slots available
                {
                    Entities.AddEntry(testEntities.EntityArray[j]);
                }

            Console.WriteLine("Here's the current content of the array at Stage 2:\n");
            Entities.PrintAllEntities();

            // 3 - Get an entity by name and assign it to a variable
            Console.WriteLine("Stage 3: Find the name 'Wolfgang' and if it exists, put it in varEntity1");
            varEntity1 = Entities.GetEntity("Wolfgang");
                //Did it work?
            Console.Write("varEntity1.ToString() : ");
            Console.WriteLine(varEntity1.ToString());
            Console.ReadKey();

            // 4 - Get an entity by ID and assign it to a variable
            Console.WriteLine("Stage 4: Find the entity with ID 52 and if it exists, put it in varEntity1");
            varEntity2 = Entities.GetEntity(52);
            //Did it work?
            Console.Write("varEntity2.ToString() : ");
            Console.WriteLine(varEntity2.ToString());
            Console.ReadKey();

            // 5 - Remove an Entry
            Console.WriteLine("Stage 5: Let's remove the Wolfgang entry from the array!\n");
            Entities.RemoveEntry(testEntities.EntityArray[2]);
            // It's now been set to null by overwriting it with a new GameEntity()
            
            // 6 - Print the final results
            Console.WriteLine("Stage 6: Here's the final content of the array:\n");
            Entities.PrintAllEntities();
        }
    }
}
