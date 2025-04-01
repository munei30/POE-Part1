using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_part1
{
    internal class chatbot
    {
        public Dictionary<string,string>chatbotQA = new Dictionary<string, string> 
        {
            { "what is your purpose","i am here to help you stay safe online"},
            { "",""}

        };

        public string getResponse(string input, user user)
        {
          

            input = input.ToLower();

            if (input.Contains("hello") || input.Contains("hi"))
            {
                return "Hello! " + user.name + " How can i assist you today?";
            }
            else if (input.Contains("how are you"))
            {
                return "I'm just a bot, but i'm doing great! what about you?";
            }
            else if (input.Contains("fine") || input.Contains("good") || input.Contains("okay"))
            {
                return "That's good, How can i assist you today? ";
            }
            else if (chatbotQA.TryGetValue(input, out string response))
            {
                return response;
            }
            else
            {
                return "i don't think i understand, could you please paraphrase?";
            }
        }
    }
}
