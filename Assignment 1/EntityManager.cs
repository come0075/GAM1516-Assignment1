using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAM1516_Assignment_1
{
    class EntityManager
    {
        #region Fields
        GameEntity[] __entityArray;
        int __maxEntities; 
        #endregion

        #region Properties
        public GameEntity[] EntityArray
        {
            get
            {
                return __entityArray;
            }
            set
            {
                __entityArray = value;
            }
        }
        public int MaxEntities
        {
            get
            {
                return __maxEntities;
            }
            set
            {
                __maxEntities = value;
            }
        }     
        #endregion

        #region Constructors
        public EntityManager()
        {
            __maxEntities = 10;
            __entityArray = new GameEntity[__maxEntities];

            for (int i = 0; i < __maxEntities; i++)
            {
                __entityArray[i] = new GameEntity("", i);
            }
        }
        public EntityManager(int _maxEntities)
        {
            __maxEntities = _maxEntities;
            __entityArray = new GameEntity[_maxEntities];
            for (int i = 0; i < _maxEntities; i++)
            {
                EntityArray[i] = new GameEntity("", i);
            }
        }
        #endregion

        #region Methods
        public void AddEntry(GameEntity _addEntry)
        {
            for(int i = 0; i < MaxEntities; i++)
            {
                if (EntityArray[i].Name == null)
                {
                    EntityArray[i] = _addEntry;
                    return;
                }
            }
            Console.WriteLine("Unable to add another entry; Max Entries reached.\n");
        }

        public void RemoveEntry(GameEntity _removeEntry)
        {
            for (int i = 0; i < __maxEntities; i++)
            {
                if (EntityArray[i].Equals(_removeEntry))
                {
                    EntityArray[i] = new GameEntity("", i);
                    return;
                }
            }
            Console.WriteLine("That entry does not exist.\n");
        }

        public GameEntity GetEntity(string _name)
        {
            GameEntity returnNullEntity = new GameEntity();

            // Check each element of the array for the Name
            for (int i = 0; i < __maxEntities; i++)
            {
                if (EntityArray[i].Name == _name)
                {
                    // If found, return it
                    Console.WriteLine("Found the name!\n");
                    return EntityArray[i];
                }
            }
            Console.WriteLine("That entry does not exist.  Returning null entry.\n");
            return returnNullEntity;
        }
        public GameEntity GetEntity(int _id)
        {
            for (int i = 0; i < MaxEntities; i++)
            {
                if (EntityArray[i].ID == _id)
                {
                    Console.WriteLine("ID found!\n");
                    return EntityArray[i];
                }
            }
            Console.WriteLine("That entry does not exist.  Returning null entry.\n");
            return new GameEntity();
        }

        public void PrintAllEntities()
        {
            for (int i = 0; i < MaxEntities; i++)
            {
                if (EntityArray[i].Name == null)
                {
                    Console.WriteLine("NULL Entry");
                }
                else
                {
                    Console.Write(EntityArray[i].ToString());
                    Console.Write(" Layer: ");
                    Console.Write(EntityArray[i].Layer);
                    Console.Write(" X Coord: ");
                    Console.Write(EntityArray[i].Location.X);
                    Console.Write(" Y Coord: ");
                    Console.Write(EntityArray[i].Location.Y);
                    Console.Write(" Height: ");
                    Console.Write(EntityArray[i].Dimension.Height);
                    Console.Write(" Width: ");
                    Console.WriteLine(EntityArray[i].Dimension.Width);
                }
            }

            Console.ReadKey();
            Console.WriteLine("");
        }
        #endregion
    }
}
