namespace PoePartOne
{
    public class Chatbot
    {// This method starts the chatbot conversation by continuously prompting the user for input, generating responses based on the input, and displaying them until the user types "exit" to end the session.
        public void StartChat(string name)
        {// Welcome message
            Console.WriteLine("Type 'exit' to quit.\n");

            while (true)
            {// Prompt user
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(name + ": ");
                Console.ResetColor();

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter something valid.");
                    continue;
                }

                input = input.ToLower();
                string response = GetResponse(input);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Bot: " + response);
                Console.ResetColor();

                if (input == "exit")
                    break;
            }
        }

        private string GetResponse(string input)
        {
            input = input.ToLower();

            // Greeting
            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
                return "Hello. I am your cybersecurity assistant. You can ask me about online safety, passwords, phishing, hacking, and more.";

            // How are you
            if (input.Contains("how are you"))
                return "I am functioning correctly and ready to assist you with cybersecurity information.";

            // Purpose
            if (input.Contains("purpose") || input.Contains("what do you do"))
                return "My purpose is to educate you about cybersecurity threats and help you stay safe online.";

            // Passwords
            if (input.Contains("password"))
                return "A strong password should include at least 12 characters, a mix of uppercase and lowercase letters, numbers, and symbols. Avoid using personal information such as names or birthdates. Never reuse passwords across multiple accounts.";

            // Phishing
            if (input.Contains("phishing") || input.Contains("scam") || input.Contains("email"))
                return "Phishing is a type of cyber attack where attackers try to trick you into revealing personal information. Be cautious of urgent messages, unknown senders, and suspicious links. Do not click on links unless you trust the source.";

            // Safe browsing
            if (input.Contains("safe browsing") || input.Contains("internet") || input.Contains("browser"))
                return "Safe browsing practices include checking website URLs for HTTPS, avoiding unknown downloads, and not clicking on suspicious advertisements or pop-ups.";

            // Hacking
            if (input.Contains("hack") || input.Contains("hacker"))
                return "Hacking refers to unauthorized access to systems or data. Many attacks succeed due to weak passwords or user mistakes. Protect yourself by using strong passwords, updating software, and avoiding suspicious links.";

            // Malware / viruses
            if (input.Contains("virus") || input.Contains("malware"))
                return "Malware is malicious software designed to damage or gain unauthorized access to systems. Protect your device by using antivirus software, keeping your system updated, and avoiding untrusted downloads.";

            // WiFi / network
            if (input.Contains("wifi") || input.Contains("network"))
                return "Public WiFi networks are often insecure. Avoid entering sensitive information on public networks. If necessary, use a VPN and ensure websites are secure before logging in.";

            // Privacy / data
            if (input.Contains("privacy") || input.Contains("data") || input.Contains("information"))
                return "Your personal data must be protected. Do not share sensitive information such as passwords, identity numbers, or banking details unless you are certain the request is legitimate.";

            //cybersecurity 
            if (input.Contains("cyber") || input.Contains("security") || input.Contains("cybersecurity"))
                return "Cybersecurity is the practice of protecting digital systems, networks, and data from cyberattacks, ensuring confidentiality, integrity, and availability of information." + "Cybersecurity is often guided by the CIA triad:Confidentiality: Ensuring that sensitive information is accessible only to authorized users. Integrity: Maintaining the accuracy and trustworthiness of data, preventing unauthorized modification. Availability: Ensuring that systems and data are accessible when needed, even during attacks or failures.";
            // Exit
            if (input == "exit")
                return "Session ended. Stay safe online.";

            // Default
            return "I did not understand your question/response. You can ask about passwords, phishing, hacking, malware, safe browsing, or privacy.";
        }// The GetResponse method analyzes the user's input and generates an appropriate response based on keywords. It covers various cybersecurity topics such as greetings, password security, phishing, safe browsing, hacking, malware, WiFi safety, privacy, and a general overview of cybersecurity. If the input does not match any known topics, it provides a default response guiding the user on what they can ask about.
    }// The Chatbot class contains the logic for interacting with the user. It has a StartChat method that manages the conversation flow and a GetResponse method that generates responses based on user input.
}// The namespace PoePartOne encapsulates