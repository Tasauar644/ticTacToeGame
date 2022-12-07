// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Tic t = new Tic();

            string Final = t.input();
            Console.WriteLine(Final);
            Console.ReadKey();
        }
    }

    class Tic
    {

        private static string[,] arr = new string[3, 3];
        private static int[] player1 = new int[5];
        private static int[] player2 = new int[5];
        private static int a = 1;


        public void display()
        {
            Console.WriteLine("\t\t 1|2|3");
            Console.WriteLine("\t\t -|-|-  ");
            Console.WriteLine("\t\t 4|5|6");
            Console.WriteLine("\t\t -|-|-  ");
            Console.WriteLine("\t\t 7|8|9");
        }
        public void display2(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("\t\t {0} |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0} |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0} |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }
            else if (n == 2)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }

            else if (n == 3)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }
            else if (n == 4)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }
            else if (n == 5)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }
            else if (n == 6)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }
            else if (n == 7)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }

            else if (n == 8)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }
            else if (n == 9)
            {
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t {0}  |{1}|  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            }
            else
            {

            }

        }


        public string input()
        {
            string final;
            display();
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Player 1: X");
                int num1 = Convert.ToInt32(Console.ReadLine());
                bool y = check(num1);

                while (y == false)
                {
                    Console.WriteLine("invalid input!!(player 1)");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    y = check(num1);
                }
                Set1(num1);
                display2(num1);

                if (i == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Player 2: O");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    bool y2 = check(num2);

                    while (y2 == false)
                    {
                        Console.WriteLine("invalid input!!(player 2)");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        y2 = check(num2);
                    }
                    Set2(num2);
                    display2(num2);

                }
            }
            final = result();

            return final;
        }

        public void Set1(int n)
        {
            switch (n)
            {
                case 1:
                    arr[0, 0] = "X";
                    break;
                case 2:
                    arr[0, 1] = "X";
                    break;
                case 3:
                    arr[0, 2] = "X";
                    break;
                case 4:
                    arr[1, 0] = "X";
                    break;
                case 5:
                    arr[1, 1] = "X";
                    break;
                case 6:
                    arr[1, 2] = "X";
                    break;

                case 7:
                    arr[2, 0] = "X";
                    break;
                case 8:
                    arr[2, 1] = "X";
                    break;
                case 9:
                    arr[2, 2] = "X";
                    break;


            }

        }

        public void Set2(int n)
        {
            switch (n)
            {
                case 1:
                    arr[0, 0] = "O";
                    break;
                case 2:
                    arr[0, 1] = "O";
                    break;
                case 3:
                    arr[0, 2] = "O";
                    break;
                case 4:
                    arr[1, 0] = "O";
                    break;
                case 5:
                    arr[1, 1] = "O";
                    break;
                case 6:
                    arr[1, 2] = "O";
                    break;

                case 7:
                    arr[2, 0] = "O";
                    break;
                case 8:
                    arr[2, 1] = "O";
                    break;
                case 9:
                    arr[2, 2] = "O";
                    break;


            }

        }



        public Boolean check(int n)
        {


            switch (n)
            {
                case 1:
                    if (arr[0, 0] == "X" || arr[0, 0] == "O")
                        return false;

                    else
                        return true;

                case 2:
                    if (arr[0, 1] == "X" || arr[0, 1] == "O")
                        return false;

                    else
                        return true;
                case 3:
                    if (arr[0, 2] == "X" || arr[0, 2] == "O")
                        return false;

                    else
                        return true;
                case 4:
                    if (arr[1, 0] == "X" || arr[1, 0] == "O")
                        return false;

                    else
                        return true;
                case 5:
                    if (arr[1, 1] == "X" || arr[1, 1] == "O")
                        return false;

                    else
                        return true;
                case 6:
                    if (arr[1, 2] == "X" || arr[1, 2] == "O")
                        return false;

                    else
                        return true;
                case 7:
                    if (arr[2, 0] == "X" || arr[2, 0] == "O")
                        return false;

                    else
                        return true;
                case 8:
                    if (arr[2, 1] == "X" || arr[2, 1] == "O")
                        return false;

                    else
                        return true;
                case 9:
                    if (arr[2, 2] == "X" || arr[2, 2] == "O")
                        return false;

                    else
                        return true;

                default: return false;
            }
        }



        public string result()
        {
            if ((arr[0, 0] == "X" && arr[1, 1] == "X" && arr[2, 2] == "X") || (arr[0, 2] == "X" && arr[1, 1] == "X" && arr[2, 0] == "X"))
            {
                return ("Player 1 Won");

            }
            else if ((arr[0, 1] == "X" && arr[1, 1] == "X") && arr[2, 1] == "X" && arr[1, 0] == "X" && arr[1, 1] == "X" && arr[1, 2] == "X")
            {
                return ("Player 1 Won");
            }
            else if ((arr[0, 0] == "O" && arr[1, 1] == "O" && arr[2, 2] == "O") || (arr[0, 2] == "O" && arr[1, 1] == "O" && arr[2, 0] == "O"))
            {
                return ("Player 2 Won");
            }
            else if ((arr[0, 1] == "O" && arr[1, 1] == "O") && arr[2, 1] == "O" && arr[1, 0] == "O" && arr[1, 1] == "O" && arr[1, 2] == "O")
            {
                return ("Player 2 Won");
            }
            else
            {
                return ("The Match Is Draw");
            }
        }
    }

}



