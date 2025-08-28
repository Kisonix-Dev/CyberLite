using System;
namespace CyberLite
{
  public class Scanip
  {
    public void Run()
    {
      try
      {
        Console.Clear();
        Console.WriteLine("Добро пожаловать в утилиту: Scanip.\n Здесь вы сможете просканировать IP адреса в сети.\n Введите: man scanip - для отображения всех команд утилиты.\n");
        while (true)
        {
          Console.CursorVisible = true;
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write("SCANIP > ");
          string Input = Console.ReadLine()!;

          switch (Input)
          {
            case "man scanip":
              Console.CursorVisible = false;
              Console.WriteLine(@"
scan - Сканирование доступных IP адресов в сети.");
              Console.CursorVisible = true;
              break;
            case "clear":
              Console.Clear();
              continue;
            case "exit":
              Console.Clear();
              return;
            default:
              if (string.IsNullOrWhiteSpace(Input)) { }
              else
              {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Неизвестная команда! - " + Input);
                Console.ResetColor();
              }
              continue;
          }
        }
      }
      catch (Exception)
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error");
        Console.ResetColor();
      }
    }
  }
}
