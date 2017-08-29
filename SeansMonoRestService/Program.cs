using Microsoft.Owin.Hosting;
using System;
using SeansMonoRestService.Model;
using System.Collections.Generic;

namespace SeansMonoRestService
{
    class Program
    {
        public static int UserCounter = 0;
        public static Dictionary<Int32, User> Users = new Dictionary<int, User>();

        static void Main()
        {
            Users.Add(++UserCounter, new User(UserCounter, "Sean", "London"));
            Users.Add(++UserCounter, new User(UserCounter, "Emmy", "Helsinki"));
            Users.Add(++UserCounter, new User(UserCounter, "Cosmo", "New York"));

            string baseAddress = "http://*:8080";

            // Start OWIN host
            using (WebApp.Start(url: baseAddress))
            {
                Console.WriteLine("Service Listening at " + baseAddress);

                System.Threading.Thread.Sleep(-1);
            }

        }
    }
}
