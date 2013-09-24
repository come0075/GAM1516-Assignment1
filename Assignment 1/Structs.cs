using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAM1516_Assignment_1
{
        public struct Position
        {
            #region Fields
            private int __x;
            private int __y;
            #endregion

            #region Properties
            public int X
            {
                get
                {
                    return __x;
                }
                set
                {
                    __x = value;
                }
            }
            public int Y
            {
                get
                {
                    return __y;
                }
                set
                {
                    __y = value;
                }
            }
            #endregion

            #region Constructor
            public Position(int _x, int _y)
            {
                this.__x = _x;
                this.__y = _y;
            }
            #endregion
        }

        public struct Rectangle
        {
            #region Fields
            private int __width;
            private int __height;
            #endregion

            #region Properties
            public int Width
            {
                get
                {
                    return __width;
                }
                set
                {
                    __width = value;
                }
            }
            public int Height
            {
                get
                {
                    return __height;
                }
                set
                {
                    __height = value;
                }
            }
            #endregion

            #region Constructor
            public Rectangle(int _width, int _height)
            {
                this.__width = _width;
                this.__height = _height;
            }
            #endregion
        }
}
