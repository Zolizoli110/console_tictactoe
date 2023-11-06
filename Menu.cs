namespace TicTacToe
{
  class Menu
  {
    private int input;
    public Menu()
    {
      Console.WriteLine("1) Play");
      Console.WriteLine("2) Exit");
      this.input = int.Parse(Console.ReadLine()!);
      InputHandler();
    }

    private void InputHandler()
    {
      switch (input)
      {
        case 1:
          Start();
          return;
        case 2:
          Console.Clear();
          return;
        default:
          Console.Clear();
          Console.WriteLine("Wrong input!");
          Program.Main();
          return;
      }
    }

    private void Start()
    {
      bool win = true;
      RoundHandler roundHandler = new RoundHandler();
      while (win)
      {
        win = roundHandler.Play();
      }
    }
  }
}
