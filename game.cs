namespace CyberLite
{
  class Game()
  {
    public static void Main()
    {
      Debugging debug = new Debugging(0);
      debug.Debug();

      Running runner = new Running();
      runner.Run();
    }
  }
}