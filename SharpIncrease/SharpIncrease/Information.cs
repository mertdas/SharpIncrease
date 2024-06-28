using System;

namespace SharpIncrease
{
    internal class Information
    {
        public static void Banner()
        {
            var bannerText = @"
                   
  _____ __ __   ____  ____   ____ ____  ____     __  ____     ___   ____  _____   ___ 
 / ___/|  |  | /    ||    \ |    \    ||    \   /  ]|    \   /  _] /    |/ ___/  /  _]
(   \_ |  |  ||  o  ||  D  )|  o  )  | |  _  | /  / |  D  ) /  [_ |  o  (   \_  /  [_ 
 \__  ||  _  ||     ||    / |   _/|  | |  |  |/  /  |    / |    _]|     |\__  ||    _]
 /  \ ||  |  ||  _  ||    \ |  |  |  | |  |  /   \_ |    \ |   [_ |  _  |/  \ ||   [_ 
 \    ||  |  ||  |  ||  .  \|  |  |  | |  |  \     ||  .  \|     ||  |  |\    ||     |
  \___||__|__||__|__||__|\_||__| |____||__|__|\____||__|\_||_____||__|__| \___||_____|
                                                                                      
                                             

                                Mert Daş @merterpreter
                                   version: v1.0
           

        ";
            Console.WriteLine(bannerText);
        }
    }
}
