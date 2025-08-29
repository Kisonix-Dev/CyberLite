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
        Console.WriteLine("Добро пожаловать в утилиту: Scanip.\n Здесь вы сможете просканировать IP адреса в сети.\n Введите: scanip man - для отображения всех команд утилиты.\n");
        while (true)
        {
          Console.CursorVisible = true;
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write("SCANIP > ");
          string Input = Console.ReadLine()!;

          switch (Input)
          {
            case "scan":
              scan();
              break;
            case "scanip man":
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
    private static void scan()
    {
      Console.Clear();
      Console.CursorVisible = false;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("133.123.421.34");
      Thread.Sleep(1000);
      Console.WriteLine("143.546.32.234");
      Thread.Sleep(1020);
      Console.WriteLine("12.435.322.34");
      Thread.Sleep(1200);
      Console.WriteLine("123.42.232.23");
      Thread.Sleep(2000);
      Console.WriteLine("123.42.234.24");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("End");
      Console.ResetColor();
      return;
    }
  }
}
