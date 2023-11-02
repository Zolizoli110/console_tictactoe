using Alba.CsConsoleFormat;

namespace TicTacToe
{
  class Renderer
  {
    private Table table;
    private Document doc; 

    public Renderer(Table table)
    {
      this.table = table;
       doc = new Document(
        new Grid {
          Columns = { GridLength.Star(1), GridLength.Star(1), GridLength.Star(1), GridLength.Star(1)},
          Children = {
            new Cell() { Height = 1 },
            new Cell(0){ Height = 1 },
            new Cell(1){ Height = 1 },
            new Cell(2){ Height = 1 },
            new Cell(0){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(1){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(2){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(){ Height = 1 },
            new Cell(){ Height = 1 }
          }
        }
      );
    }

    public void ChangeCellValue()
    {
      doc.Children.Clear();
      doc = new Document(
        new Grid {
          Columns = { GridLength.Star(1), GridLength.Star(1), GridLength.Star(1), GridLength.Star(1)},
          Children = {
            new Cell() { Height = 1 },
            new Cell(0){ Height = 1 },
            new Cell(1){ Height = 1 },
            new Cell(2){ Height = 1 },
            new Cell(0){ Height = 1 },
            new Cell(table.GetPlayer(0, 0)){ Height = 1 },
            new Cell(table.GetPlayer(0, 1)){ Height = 1 },
            new Cell(table.GetPlayer(0, 2)){ Height = 1 },
            new Cell(1){ Height = 1 },
            new Cell(table.GetPlayer(1, 0)){ Height = 1 },
            new Cell(table.GetPlayer(1, 1)){ Height = 1 },
            new Cell(table.GetPlayer(1, 2)){ Height = 1 },
            new Cell(2){ Height = 1 },
            new Cell(table.GetPlayer(2, 0)){ Height = 1 },
            new Cell(table.GetPlayer(2, 1)){ Height = 1 },
            new Cell(table.GetPlayer(2, 2)){ Height = 1 }
          }
        }
      );
    }

    public void Render()
    {
      Console.Clear();
      ConsoleRenderer.RenderDocument(doc);
      Console.WriteLine();
    }

  }
}
