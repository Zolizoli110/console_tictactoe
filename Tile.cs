namespace TicTacToe
{
  class Tile
  {
    private bool isOcupied;
    private char player;

    public Tile()
    {
      isOcupied = false;
      player = ' ';
    }

    public bool IsOcupied
    {
      get => isOcupied;
    }

    public char Player
    {
      get => player;
      set {
        if (!isOcupied)
        {
          player = value;
          isOcupied = true;
        }
      }
    }
  }
}
