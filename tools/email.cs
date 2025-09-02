namespace CyberLite
{
  class Email
  {
    private bool quest1 = false;
    private bool quest1On = false;
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
      Console.WriteLine("Это твоё первое задание, взломай сервер компании: Blizzard, который отвечает за обработку игровой подписки для игры: World of Warcraft/\n А после этого, добавь на игровой аккаунт: 'Mystery@gmail.com 100.000 дней игрового времени.'");
    }
  }
}