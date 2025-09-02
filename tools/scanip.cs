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
          Console.ResetColor();

          string Input = Console.ReadLine()!;

          switch (Input)
          {
            case "scan":
              Scan();
              break;
            case "scanip man":
              Console.CursorVisible = false;
              Console.WriteLine(@"
scan - Сканирование доступных IP адресов в сети.
status - Проверить статус доступности IP адреса.");
              Console.CursorVisible = true;
              break;
            case "status":
              Status();
              break;
            case "connect":
              Connect();
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
    private bool ipStatus = false;
    private void Scan()
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
      ipStatus = true;
      return;
    }
    private void Status()
    {
      if (ipStatus == true)
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("133.123.421.34");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("143.546.32.234");
        Console.ResetColor();
        Thread.Sleep(1020);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("12.435.322.34 - Доступен!");
        Console.ResetColor();
        Thread.Sleep(1200);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("123.42.232.23");
        Console.ResetColor();
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("123.42.234.24");
        Console.ResetColor();
        ipStatus = false;
        return;
      }
      else
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы не от сканировали IP адреса!\n Пожалуйста, с начало от сканируйте IP адреса в сети командой - 'scan'");
        Console.ResetColor();
        return;
      }
    }
    private void Connect()
    {

    }
  }
}
