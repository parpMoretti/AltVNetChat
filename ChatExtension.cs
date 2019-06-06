using AltV.Net;
using AltV.Net.Elements.Entities;

namespace Server.Extensions
{
    public class ChatExtension
    {
        public static void OnChatMessage(IPlayer player, object[] message)
        {
            if ((string)message[0] == "/")
            {
                //Handle Chat Commands
                Alt.Log($"{player.Name} has typed {message}");
            }
        }
    }
}