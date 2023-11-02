namespace TicTacToe
{
  class Program
  {
    static void Main()
    {
      bool win = true;
      RoundHandler roundHandler = new RoundHandler();
      while (win)
      {
        int[] move = Move();
        win = roundHandler.Play(move[0], move[1]);
      }
    }

    static int[] Move()
    {
      string line = Console.ReadLine()!;
      string[] tmp = line.Split(' ');
      int[] move = {int.Parse(tmp[0]), int.Parse(tmp[1])};
      return move;
    }
  }
}
