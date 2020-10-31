using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _86_FacoryClassProject
{
	class Rect
	{
		private int _width;
		private int _height;

		public Rect(int width, int height)
		{
			this._width = width;
			this._height = height;
		}

		public int Area()
		{

			return _width * _height;
		}

		public Rect Enlarge(int factor)
		{
			return  new Rect(_width*factor,_height*factor);
		}

		//public override string ToString()
		//{
		//	return string.Format($"width: {_width}, height:{_height} and area is: {Area()}");
		//}
	}
}
