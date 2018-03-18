using System;

namespace MyPhotoshop
{
	public class Photo
	{
		readonly int width;
		readonly int height;
		readonly Pixel [,] data;

        public Photo(int wight, int height)
        {
            this.width = wight;
            this.height = height;
            data = new Pixel[wight, height];
        }
	}
}

