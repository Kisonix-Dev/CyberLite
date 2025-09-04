namespace CyberLite
{
  class Email
  {
    private void Run()
    {
      Console.Clear();
      Console.WriteLine("Добро пожаловать в почтовой клиент. \n Здесь вы сможете получать новые задания.\n");

      while (true)
      {
        Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Email > ");
        Console.ResetColor();

        string Input = Console.ReadLine()!;

        switch (Input)
        {
          case "Update":
            break;
        }
      }
    }
    private void Get()
    {
      Quests();
    }
    private void Update()
    {

    }
    private void Quests()
    {

    }
  }
}