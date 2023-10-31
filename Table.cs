using System;
using System.Collections.Generic;

namespace TicTacToe
{
  class Table
  {
    private List<List<Tile>> table;

    public Table(int width, int height)
    {
      table = new List<List<Tile>>();
      for (int i = 0; i < heigth; i++)
      {
        List<Tile> row = new List<Tile>();
        for (int j = 0; j < width; j++)
        {
          Tile t = new Tile();
          row.Add(t);
        }
        table.Add(row)
      }
    }

    public void Table
    {
      get
      {
        foreach (List<Tile> item in table)
        {
          foreach (Tile item in item)
          {
            if (item.IsOcupied)
            {
              
            }
            else
            {
              Console.WriteLine("[ ]")
            }
          }
        }
      }
    }
  }
}
