using System;

namespace TicTacToe
{
  enum Players
  {
    X,
    O
  }
  class Tile
  {
    private bool isOcupied;
    private Players player;

    public Tile()
    {
      isOcupied = false;
    }

    public bool IsOcupied
    {
      get => return;
      set {
        if (!isOcupied)
        {
          isOcupied = true;
        }
      }
    }

    public Players Player
    {
      get => return;
      set {
        if (!isOcupied) player = value;
      }
    }
  }
}
