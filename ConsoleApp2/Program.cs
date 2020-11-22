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
    static int activePlayer = 0;
    static void Main(string[] args)
    {
      do
      {
        Console.Clear();
        Console.WriteLine("{0}: X and {1}: O", "Player 1", "Player2");
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
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
        Console.WriteLine("     |     |      ");
        choice = int.Parse(Console.ReadLine());

      } while (true);
    }
  }
}

