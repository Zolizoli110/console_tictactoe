namespace TicTacToe
{
  class RoundHandler
  {
    private int round;
    private Renderer renderer;
    private Table table;

    public RoundHandler()
    {
      round = 0;
      table = new Table();
      renderer = new Renderer(table);
      renderer.Render();
    }

    public bool Play(int x, int y)
    {
      if(round % 2 == 0 )
      {
        table.SetPlayer(x, y, 'X');
        round++;
      } 
      else 
      {
        table.SetPlayer(x, y, 'O');
        round++;
      }
      renderer.ChangeCellValue();
      renderer.Render();
      return table.CheckWin();
    }
  }
}
