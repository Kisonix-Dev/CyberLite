using System;
namespace CyberLite
{
  class Game()
  {
    public static void Main()
    {
      Debugging debug = new Debugging(1);
      debug.Debug();

      Running runner = new Running();
      runner.Run();
    }
  }
}