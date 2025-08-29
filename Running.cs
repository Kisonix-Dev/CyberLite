using System;
namespace CyberLite
{
  public class Running
  {
    public void Run()
    {

      string ver = "1.0";
      string Name;

      try
      {
        while (true)
        {
          Console.Clear();
          Console.CursorVisible = false;
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine($"Версия CyberLite " + ver);
          Console.ResetColor();

          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Добро пожаловать в CyberLite!\n");
          Console.ResetColor();
          Console.CursorVisible = true;
          Console.Write("Введите ваш никнейм: ");
          Name = Console.ReadLine()!;

          if (string.IsNullOrWhiteSpace(Name))
          {
            Console.CursorVisible = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Поле не должно быть пустым!");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
            continue;
          }
          else
          {
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Добро пожаловать " + Name);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
            Console.CursorVisible = true;
            break;
          }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*Введите команду: help - что-бы отобразить доступные команды.");
        Console.ResetColor();

        while (true)
        {
          Console.CursorVisible = true;
          Console.Write($"$" + Name + "PC-0 > ");
          string Input = Console.ReadLine()!;

          switch (Input)
          {
            case "help":
              Console.WriteLine(@"
    Система
help - Отображение справки по всем командам в системе. 
clear - Очистить терминал. 
poweroff - Выйти из игры. 
    Программы
scanip - Программа для сканирования IP адресов в сети.
ssh - Сетевой протокол для передачи данных.
scanp - Сканирование портов в сети.
netshark - Сканирование трафика в сети.
nonsql - SQL-инъекция, внедрение вредоностного кода в базы данных.
email - Программа для отправки электронной почты - (Поддерживается массовая рассылка из файла).
botnet - Сеть заражённых компьютеров, можно использовать в качестве DDoS атак.
");
              Console.CursorVisible = true;
              break;
            case "clear":
              Console.Clear();
              continue;
            case "poweroff":
              Console.CursorVisible = false;
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("Выход из игры...");
              Console.ResetColor();
              Thread.Sleep(2000);
              Console.CursorVisible = true;
              Console.Clear();
              return;
            case "scanip":
              Scanip scan = new Scanip();
              scan.Run();
              break;
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