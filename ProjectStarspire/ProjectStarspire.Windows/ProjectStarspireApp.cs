using SiliconStudio.Xenko.Engine;

namespace ProjectStarspire
{
    class ProjectStarspireApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
