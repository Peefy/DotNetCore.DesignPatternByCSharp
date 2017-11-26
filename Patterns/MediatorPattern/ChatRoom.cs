
using System;

namespace VsCodeProOne.Patterns.MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine(DateTime.Now + $"[{user.Name}] : {message}");
        }
    }

}
