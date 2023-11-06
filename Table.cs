
namespace TicTacToe
{
  class Table
  {
    private List<List<Tile>> tableList = new List<List<Tile>>();

    public Table()
    {
      for (int i = 0; i < 3; i++)
      {
        List<Tile> row = new List<Tile>();
        for (int j = 0; j < 3; j++)
        {
          Tile t = new Tile();
          row.Add(t);
        }
        tableList.Add(row);
      }
    }

    public void SetPlayer(int x, int y, char player)
    {
      tableList[y][x].Player = player;
    }

    public char GetPlayer(int x, int y)
    {
      return tableList[x][y].Player;
    }

    public List<List<Tile>> TableList { get; }

    public char CheckWin()
    {
      for (int i = 0; i < tableList.Count; i++)
      {
        if (tableList[i][0].Player != ' ' && tableList[i][0].Player == tableList[i][1].Player && tableList[i][1].Player == tableList[i][2].Player)
        {
          Console.WriteLine();
          Console.WriteLine($"Player '{tableList[i][0].Player}' won!");
          Console.WriteLine();
          return tableList[i][0].Player;
        }
        if (tableList[0][i].Player != ' ' && tableList[0][i].Player == tableList[1][i].Player && tableList[1][i].Player == tableList[2][i].Player)
        {
          Console.WriteLine();
          Console.WriteLine($"Player '{tableList[0][i].Player}' won!");
          Console.WriteLine();
          return tableList[0][i].Player;
        }
      }
        if (tableList[0][0].Player != ' ' && tableList[0][0].Player == tableList[1][1].Player && tableList[2][2].Player == tableList[1][1].Player)
        {
          Console.WriteLine();
          Console.WriteLine($"Player '{tableList[0][0].Player}' won!");
          Console.WriteLine();
          return tableList[0][0].Player;
        }
        if (tableList[2][0].Player != ' ' && tableList[2][0].Player == tableList[1][1].Player && tableList[0][2].Player == tableList[1][1].Player)
        {
          Console.WriteLine();
          Console.WriteLine($"Player '{tableList[2][0].Player}' won!");
          Console.WriteLine();
          return tableList[2][0].Player;
        }
      return ' ';
    }

    public bool CheckDraw()
    {
      int num = 0;
      tableList.ForEach(list => {
        list.ForEach(item =>{
          if (item.Player != ' ')
          {
            num++;
          }
        });
      });
      if (num == 9)
      {
        Console.WriteLine();
        Console.WriteLine("Draw");
        Console.WriteLine();
        return false;
      }
      return true;
    }
  } 
}
