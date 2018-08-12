using System.Net.Mime;

namespace discord.html
{
    using System;
    using System.Text;
    using System.Windows.Forms;

    class Program
    {
        private static string version = "1.0.0";

        private static void ShowHelp()
        {
            Console.WriteLine($"Discord.html Bot Runner (Command Line Interface) v{version}");
            Console.WriteLine();
            Console.WriteLine("[--bot]          HTML file containing bot logic.");
            Console.WriteLine();
            Console.WriteLine("# Example Usage:");
            Console.WriteLine("   discord.html.exe --bot=\"C:\\discord.html\\Bot\\bot.html\"");
        }

        static void Main(string[] args)
        {
            // Set encoding because I'm not shit at what I do.
            Console.OutputEncoding = Encoding.UTF8;

            // Set console title.
            Console.Title = $"Discord.html Bot Runner (Command Line Interface) v{version}";

            if (args.Length >= 0)
            {
                ShowHelp();
            }

            // Recursively cycle through arguments.
            foreach (var cArg in args)
            {
                if (cArg[0] == '-')
                {
                    if (cArg == "--bot")
                    {
                        // TODO:
                        // Implement
                    }
                }
            }
        }
    }
}
