using System;
using System.IO;

namespace CodeHomework_2_1
{
    static class Starter
    {
        public static void Run ()
        {
            Actions action = new Actions();
            Result result = new Result();
            Logger log = new Logger();
            Random rand = new Random();

            for (int i = 0; i <= 100; i++)
            {
                int random = rand.Next(0, 3);

                switch (random)
                {
                    case 0: 
                        {
                            action.Start();
                        }
                        break;
                    case 1: 
                        {
                            action.Skip();
                        }
                        break;
                    case 2: 
                        {
                            action.Broke();
                            string error = result._result;
                            log.Log("Error", $"Action failed by a reason: {error}");
                        }
                        break;
                }
            }
        }
    }
}
