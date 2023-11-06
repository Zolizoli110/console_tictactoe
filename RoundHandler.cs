namespace TicTacToe
{
  class RoundHandler
  {
    private static int round;
    private Renderer renderer;
    private Table table;

    public RoundHandler()
    {
      round = 0;
      table = new Table();
      renderer = new Renderer(table);
      renderer.Render();
    }

    public bool Play()
    {

      if(round % 2 == 0 )
      {
        Console.WriteLine("X's turn!");
        string line = Console.ReadLine()!;
        string[] tmp = line.Split(' ');
        int[] move = {int.Parse(tmp[0]), int.Parse(tmp[1])};
        table.SetPlayer(move[0], move[1], 'X');
      } 
      else 
      {
        Console.WriteLine("O's turn!");
        string line = Console.ReadLine()!;
        string[] tmp = line.Split(' ');
        int[] move = {int.Parse(tmp[0]), int.Parse(tmp[1])};
        table.SetPlayer(move[0], move[1], 'O');
      }
      renderer.ChangeCellValue();
      renderer.Render();
      if (table.CheckWin() != ' ')
      {
        return false;
      }
      return table.CheckDraw();
    }

    public static void RaiseRound()
    {
      round++;
    }
  }
}
