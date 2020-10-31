using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _86_FacoryClassProject
{
	class FactoryClass
	{

		public static Rect FactoryRect(int i, int j)
		{
			Rect aRect=new Rect(i,j);
			return aRect;
		}

		
	}
}
