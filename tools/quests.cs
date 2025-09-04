namespace CyberLite
{
  class Quest
  {
    private bool questOn;
    private bool questCompleted;
    public void Quest1()
    {
      while (true)
      {
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("1 - Принять квест.");
        Console.WriteLine("2 - Отменить квест.\n");
        Console.ResetColor();
        Console.Write("Действие > ");

        string Input = Console.ReadLine()!;

        switch (Input)
        {
          case "1":
            break;
          default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error");
            Console.ResetColor();
            continue;
        }

        questOn = false;
        questCompleted = false;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Это твоё первое задание, взломай сервер компании: Blizzard, который отвечает за обработку игровой подписки для игры: World of Warcraft/\n А после этого, добавь на игровой аккаунт: 'Mystery@gmail.com 100.000 дней игрового времени.'");
        Console.ResetColor();

        if (Input == "1")
        {
          questOn = true;
        }
        else
        {
          return;
        }
      }
    }
  }
}