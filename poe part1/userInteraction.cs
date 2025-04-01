using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace poe_part1
{
    internal class userInteraction
    {
        public user user;
        public chatbot chatbot;

        public userInteraction(chatbot chatbot, user user)
        {
            this.chatbot = chatbot;
            this.user = user;
        }
        public void Chat()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("chatbot: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello " + user.name + " Welcome to the chatbot");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CHAT STARTED");
            Console.WriteLine("Type exit to end the chat!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.White;
                string Input = Console.ReadLine();
                string userMessage = Input;
                Regex.Replace(userMessage, @"[?]", "");
                if (userMessage.ToLower().Equals("exit") || userMessage.ToLower().Contains("bye") ||
                    userMessage.ToLower().Contains("goodbye"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("chatbot: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Goodbye!");
                    break;
                }
                string response = chatbot.getResponse(userMessage, user);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("chatbot: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(response);
            }
        }
    }
}
