using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        // member variable
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }

        public int Volume
        {
            get
            {
                volume = this.length * this.height * Width;
                return volume;
            }
        }

        public int Height
        {
            get
            { 
                return height; 
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box (int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;


        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("Length should be higher 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            volume = length*height*Width;
            Console.WriteLine(
                "Length is {0} " +
                "and height is {1} " +
                "and width is {2} " + 
                "so the volume is {3}",
                length, height, Width, volume);
        }

    }
}
