using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_P_Solving
{
    class Q_1
    {
		//Qs-1
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

		//Qs-2
		//Have  function FirstFactorial(number) take  parameter is passed and return the factorial of 
		//it (ex: if num = 4, return (4 * 3 * 2 * 1)). For  test cases,  range will  between 1 and 18 and the 
		//input will always  integer one.

		public  void FirstFactor()
        {
			
			Console.WriteLine("Enter Number- ");
			int number = Convert.ToInt32(Console.ReadLine());
			int result = 1;
			for (int i = number; i > 0; i--)
            {
				result *= 1;

            }
			Console.WriteLine("Result is = " + result);
		}

	}
}
