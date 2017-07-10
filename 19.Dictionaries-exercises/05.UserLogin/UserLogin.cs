using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogin
{
    class UserLogin
    {
        static void Main(string[] args)
        {            
            Dictionary<string, string> userPass = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "login")
            {
                var userPassword = input.Split(' ').ToArray();
                var user = userPassword[0];
                var password = userPassword[userPassword.Length - 1];
                userPass[user] = password;

                input = Console.ReadLine();
            }
            int count = 0;

            input = Console.ReadLine();
            while (input != "end")
            {
                var userPassword = input.Split(' ').ToArray();
                var user = userPassword[0];
                var password = userPassword[userPassword.Length - 1];

                if (userPass.ContainsKey(user) && userPass[user] == password)
                {
                    Console.WriteLine($"{user}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{user}: login failed");
                    count++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
