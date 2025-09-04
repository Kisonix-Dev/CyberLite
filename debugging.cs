namespace CyberLite
{
  public class Debugging
  {
    private int _debugMode;

    public Debugging(int debugMode)
    {
      _debugMode = debugMode;
    }
    public void Debug()
    {
      // Отладочная система, режимы.
      try
      {
        if (_debugMode == 0)
        {
          Scanip scan = new Scanip();
          //scan.Run();
          Quest quest = new Quest();
          quest.Quest1();
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