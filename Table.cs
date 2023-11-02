
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

    public bool CheckWin()
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
        Console.WriteLine("Draw");
        return false;
      }
      return true;
    }
  } 
}
