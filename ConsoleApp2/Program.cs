using ConsoleApp2.enums;
using System;
using System.Threading;

namespace TicTacToe
{
    /// <summary>
    /// TicTacToe Program
    /// </summary>
    public class TicTacToeProgram
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choice;
        static int activePlayer = (int)ActivePlayer.Player1;
        static GameStatus gameStatus;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("{0}: X and {1}: O", ActivePlayer.Player1, ActivePlayer.Player2);
                Console.WriteLine("\n");
                if (activePlayer % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                DisplayBoard();
                choice = int.Parse(Console.ReadLine());
                CheckGameStatus();
            } while (gameStatus == GameStatus.running);
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        private static GameStatus CheckGameStatus()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3] ||
                arr[4] == arr[5] && arr[5] == arr[6] ||
                arr[6] == arr[7] && arr[7] == arr[8] ||
                arr[1] == arr[4] && arr[4] == arr[7] ||
                arr[2] == arr[5] && arr[5] == arr[8] ||
                arr[1] == arr[5] && arr[5] == arr[9] ||
                arr[3] == arr[5] && arr[5] == arr[7] ||
                arr[3] == arr[6] && arr[6] == arr[9])
            {
                return GameStatus.won;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' &&
                     arr[4] != '4' && arr[5] != '5' && arr[6] != '6' &&
                     arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return GameStatus.draw;
            }
            else
            {
                return GameStatus.running;
            }
        }
    }
}

