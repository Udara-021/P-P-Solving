using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_P_Solving
{
    class Q_1
    {
		//Write a program that converts 1 lower case letter("a" - "z") to its corresponding upper case letter("A" - "Z"). 
		//	For example if the user enters "c" then the program will show "C" on the screen.

		public void ToUpper()
		{
			char x;
			int y;
			Console.WriteLine("Enter Latter- ");
			x = Convert.ToChar(Console.ReadLine());
			y= (int)x;
			if (y >= 97 && y <= 122)
			{
				y = y - 32;
				x = (char)y;
				
				Console.WriteLine("Uppercase Letter is = " + x);
			}
			
		}
    }
}
