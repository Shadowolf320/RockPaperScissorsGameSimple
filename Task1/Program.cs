using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			

			while (true)
            {
				Console.WriteLine("Rock-Paper-Scissors Choose 1-4 ");
				Console.WriteLine("1)Rock 2)Paper 3)Scissors 4)Quit \n");
				int choice = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				Random random = new Random();

				int computer = random.Next(1, 4);

				if (choice == computer)
				{
					Console.WriteLine("Pc and you chose the same" + ". " + "It's a Draw \n");
				}
                else if (choice == 1 && computer == 2)
                {
					Console.WriteLine("You chose Rock. " + "Pc chose Paper" + ". " + "Pc Won! \n");
                }
				else if (choice == 1 && computer == 3)
				{
					Console.WriteLine("You chose Rock. " + "Pc chose Scissors" + ". " + "You Won! \n");
				}
				else if (choice == 2 && computer == 1)
				{
					Console.WriteLine("You chose Paper. " + "Pc chose Rock " + ". " + "You Won! \n");
				}
				else if (choice == 2 && computer == 3)
				{
					Console.WriteLine("You chose Paper. " + "Pc chose Scissors" + ". " + "Pc Won! \n");
				}
				else if (choice == 3 && computer == 1)
				{
					Console.WriteLine("You chose Scissors. " + "Pc chose Rock" + ". " + "Pc Won! \n");
				}
				else if (choice == 3 && computer == 2)
				{
					Console.WriteLine("You chose Scissors " + "Pc chose Paper" + ". " + "Pc Won! \n");
				}
				else if (choice == 4)
				{
					Console.WriteLine("You have left the game!");
					break;
				}
			}
			










		}
	}
}
