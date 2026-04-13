namespace PoePartOne
{
    class Program
    {// This is the main entry point of the application. It  sets up the console title, runs the introduction to get the user's name, and starts the chatbot conversation.
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness ChatBot";

            VoiceLogo intro = new VoiceLogo(); //outside of main method, creates instance of VoiceLogo class to run the introduction sequence and get the user's name.
            string userName = intro.RunIntro(); // gets name from intro sequence

            Chatbot bot = new Chatbot();
            bot.StartChat(userName);

            Console.ReadLine();
        }
    }
}
