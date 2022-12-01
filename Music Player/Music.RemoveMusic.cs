using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public static partial class Music
    {

        public static void Removemusic()
        {


            Console.WriteLine("enter music ID to remove");
            try
            {
                int removemsc = Convert.ToInt32(Console.ReadLine());

                var firstMatch = GetMusic().First(s => s.Id == removemsc);
                GetMusic().Remove(firstMatch);
                MusicDisplay();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
