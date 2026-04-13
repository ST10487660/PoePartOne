using System.Drawing;
using System.Media;

namespace PoePartOne
{
    public class VoiceLogo
    {
        private string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

        // MAIN ENTRY FOR THIS CLASS
        public string RunIntro()// This method orchestrates the introduction sequence by calling methods to display the header, play the greeting audio, show the ASCII logo, and get the user's name. It returns the user's name for use in the chatbot conversation.
        {
            ShowHeader();
            PlayGreeting();
            ShowAscii();
            return GetUserName();
        }

        // ================= HEADER =================
        private void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            string[] lines =
            {
                "=====================================",
                "|| CYBERSECURITY AWARENESS CHATBOT ||",
                "====================================="
            };

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                Thread.Sleep(200);
            }

            Console.ResetColor();
        }

        // ================= VOICE =================
        private void PlayGreeting()

        {

            try
            {
                string soundPath = Path.Combine(basePath, "greet.wav");

                if (File.Exists(soundPath))
                {
                    SoundPlayer player = new SoundPlayer(soundPath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("Audio file not found. Continuing without sound.");
                }
            }
            catch
            {
                Console.WriteLine("Unable to play greeting audio.");
            }
        }

        // ================= ASCII LOGO =================
        //ascii code help  from studyplug

        private void ShowAscii()
        {
            try
            {
                string imagePath = Path.Combine(basePath, "logo.png");

                if (!File.Exists(imagePath))
                {
                    Console.WriteLine("Logo file not found.");
                    return;
                }

                Bitmap image = new Bitmap(imagePath);

                int width = 80;
                int height = (image.Height * width) / image.Width;

                Bitmap resized = new Bitmap(image, new Size(width, height));

                string asciiChars = "@#S%?*+;:,.. ";

                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color pixel = resized.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;

                        int index = (gray * (asciiChars.Length - 1)) / 255;

                        if (gray > 180)
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        else if (gray > 120)
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        else
                            Console.ForegroundColor = ConsoleColor.Blue;

                        Console.Write(asciiChars[index]);
                    }

                    Console.WriteLine();
                    Thread.Sleep(10);
                }

                Console.ResetColor();
                Console.WriteLine("\nSystem has started successfully.\n");
            }
            catch
            {
                Console.WriteLine("Error displaying logo.");
            }
        }

        // ================= USER INPUT =================
        private string GetUserName()
        {
            string name;

            while (true)
            {
                Console.Write("\nEnter your name: ");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                    break;

                Console.WriteLine("Invalid input. Please enter a valid name.");
            }

            Console.WriteLine("\nLoading profile...");
            System.Threading.Thread.Sleep(1000);


            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n =====================================");
            Console.WriteLine($" ||         Welcome, {name}!!!        ||");
            Console.WriteLine(" ||         ()          ()            ||");
            Console.WriteLine(" ||                0                  ||");
            Console.WriteLine(" ||          ''          ''           ||");
            Console.WriteLine(" ||             _______               ||");
            Console.WriteLine("  =====================================");

            Console.ResetColor();

            Console.WriteLine($"\nWhats up {name}?, I am your Cybersecurity Awareness Bot.");
            Console.WriteLine("You can ask me questions about staying safe online.\n");
            Console.WriteLine("I am here to help you understand cybersecurity threats and how to protect yourself on a digital platform.");

            return name;
        }
    }
}