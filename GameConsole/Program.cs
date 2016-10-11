using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            bool running = true;
            char choice;

            do
            {
                GameBoardLayout();
                choice = GetUsersChoice();
                Console.WriteLine();
                switch (choice)
                {
                    case '1':
                        if (f1 == ' ')
                        {
                            f1 = 'x';
                            break;
                        }
                        else
                            ShowSelectionErrorOne();
                        break;
                    case '2': f2 = 'X'; break;
                    case '3': f3 = 'X'; break;
                    case '4': f4 = 'X'; break;
                    case '5': f5 = 'X'; break;
                    case '6': f6 = 'X'; break;
                    case '7': f7 = 'X'; break;
                    case '8': f8 = 'X'; break;
                    case '9': f9 = 'X'; break;
                    default: ShowSelectionError(); break;
                }
                Console.WriteLine("Your choice");
                Console.ReadKey();
            } while (running);
        }

        private void ShowSelectionError()
        {
            Console.WriteLine("You stupid");
        }
        private void ShowSelectionErrorOne()
        {
            Console.WriteLine("That cell is already full! Choose another option.");
        }
        private void GameBoardLayout()
        {
            string b = (" _ _ _"  + Environment.NewLine +
                        "|" + f1 + "|" + f2 + "|" + f3 + "|" + Environment.NewLine +
                        "|" + f4 + "|" + f5 + "|" + f6 + "|" + Environment.NewLine +
                        "|" + f7 + "|" + f8 + "|" + f9 + "|");

            Console.WriteLine(b);
        }

        private char GetUsersChoice()
        {
            Console.WriteLine("Pick a square from 1 - 9");
            return Console.ReadKey().KeyChar;
        }

        public char f1 = ' ';
        public char f2 = ' ';
        public char f3 = ' ';
        public char f4 = ' ';
        public char f5 = ' ';
        public char f6 = ' ';
        public char f7 = ' ';
        public char f8 = ' ';
        public char f9 = ' ';
        
    }
}

