using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAM1516_Assignment_1
{
    class GameEntity
    {
        #region Fields
            int __layer;
            int __id;
            string __name;
            Position __location;
            Rectangle __dimension;
        #endregion

        #region Properties
            public int Layer
            {
                get
                {
                    return __layer;
                }
                set
                {
                    __layer = value;
                }
            }
            public int ID
            {
                get
                {
                    return __id;
                }
                set
                {
                    __id = value;
                }
            }

            public string Name
            {
                get
                {
                    return __name;
                }
                set
                {
                    __name = value;
                }
            }

            public Position Location
            {
                get
                {
                    return __location;
                }
                set
                {
                    __location = value;
                }
            }

            public Rectangle Dimension
            {
                get
                {
                    return __dimension;
                }
                set
                {
                    __dimension = value;
                }
            }
        #endregion

        #region Constructors
            public GameEntity()
            {

            }
            public GameEntity(string _name, int _id)
                : this()
            {
                this.Name = _name;
                this.ID = _id;
            }
            public GameEntity(string _name, int _id, int _layer)
                : this(_name, _id)
            {
                this.Layer = _layer;
            }
            public GameEntity(string _name, int _id, int _layer, Position _position, Rectangle _dimension)
                : this(_name, _id, _layer)
            {
                this.Location = _position;
                this.Dimension = _dimension;
            }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return "Name: " + this.__name + ", ID: " + this.__id;
        }

        public override bool Equals(object obj)
        {
            //Cast obj to GameEntity
            GameEntity compare = (GameEntity)obj;

            // Check and return a bool after testing whether two entities are the same
            if (this.__name.Equals(compare.__name) && this.__id == compare.__id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Methods
        public virtual void Update(float deltaTime)
        {
            // Write to console the deltaTime value for now
            Console.WriteLine(deltaTime);
        }
        public virtual void Draw(float deltaTime)
        {
            // Write to console the deltaTime value for now
            Console.WriteLine(deltaTime);
        }
        #endregion
    }
}
