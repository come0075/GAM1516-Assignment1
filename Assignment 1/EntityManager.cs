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
                __entityArray[i] = new GameEntity();
            }
        }
        public EntityManager(int _maxEntities)
        {
            __maxEntities = _maxEntities;
            __entityArray = new GameEntity[_maxEntities];
            for (int i = 0; i < _maxEntities; i++)
            {
                EntityArray[i] = new GameEntity();
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
            Console.WriteLine("\a\a\aError: Max Entries reached, cannot add more.\n");
        }

        public void RemoveEntry(GameEntity _removeEntry)
        {
            for (int i = 0; i < __maxEntities; i++)
            {
                if (EntityArray[i].Equals(_removeEntry))
                {
                    EntityArray[i] = null;
                    return;
                }
            }
            Console.WriteLine("\a\a\aThat entry does not exist.\n");
        }

        public GameEntity GetEntity(string _name)
        {
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
            Console.WriteLine("\a\a\aThat entry does not exist.\n");
            return null;
        }
        public GameEntity GetEntity(int _id)
        {
            // Check each element of the array for the ID
            for (int i = 0; i < MaxEntities; i++)
            {
                if (EntityArray[i].ID == _id)
                {
                    Console.WriteLine("ID found!\n");
                    return EntityArray[i];
                }
            }
            Console.WriteLine("\a\a\aThat entry does not exist.\n");
            return null;
        }

        public void PrintAllEntities()
        {
            for (int i = 0; i < MaxEntities; i++)
            {
                if (__entityArray[i] == null)
                {
                    Console.WriteLine("NULL Entry");
                }
                else
                {
                    Console.Write(__entityArray[i].ToString());
                    Console.Write(" Layer: ");
                    Console.Write(__entityArray[i].Layer);
                    Console.Write(" X Coord: ");
                    Console.Write(__entityArray[i].Location.X);
                    Console.Write(" Y Coord: ");
                    Console.Write(__entityArray[i].Location.Y);
                    Console.Write(" Height: ");
                    Console.Write(__entityArray[i].Dimension.Height);
                    Console.Write(" Width: ");
                    Console.WriteLine(__entityArray[i].Dimension.Width);
                }
            }
        }
        #endregion
    }
}
