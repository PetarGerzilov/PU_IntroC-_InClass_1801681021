using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want me to play some music for you?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\PESHO\Desktop\STD2018-1b-PetarGerzilov-1801681021\Week3\PU_IntroC-_InClass_1801681021\W3InClass\MusicFactory\Music\PICPUKK x NICOLE - GOL V 90-ta (Official Video).mp3"))
                {
                    player.PlaySync();
                }

            }
            else if (answer == "fuck")
            {
                Console.WriteLine("Okey, fuck you too");
            }
           

            else if (answer=="no")
            {
                Console.WriteLine("Okey, bye");
            }

            else
            {
                Console.WriteLine("Wrong input");
            }
            //Console.WriteLine($"My answer is: {answer}");

        }
    }
}
