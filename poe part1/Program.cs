using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            user userObj = new user();
            chatbot chatbotObj = new chatbot();
            userInteraction interactionObj = new userInteraction(chatbotObj,userObj);
            interactionObj.Chat(); 
           
        }
    }
}
