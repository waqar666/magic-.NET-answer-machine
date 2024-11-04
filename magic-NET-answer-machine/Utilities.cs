// See https://aka.ms/new-console-template for more information
namespace HelperMethods
{
public static class Utilities
{
    private static readonly string[] Animations = ["| -", "/ \\", "\\ /", "- |"];

  public  static async Task Showanimations()
    {
        for (int i = 0; i < 20; i++)
        {
            foreach (var animation in Animations)
            {
                Console.Write(animation);
                await Task.Delay(50);
                Console.Write("\b\b\b");
            }
        }
    }
}
}

