using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public partial class Music
    {
        public static void EditMusic()
        {
            Console.Clear();
            Console.WriteLine("Enter Id of music you want to edit");
            try
            {
                int EnterById = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter new song name");
                var MusicName = Console.ReadLine();

                Console.WriteLine("Enter Artist name");
                var ArtistName = Console.ReadLine();

                var editsongs = GetMusic().FirstOrDefault(edit => edit.Id == EnterById);
                if (editsongs != null)
                {
                    editsongs.Track = MusicName;
                    editsongs.Artist = ArtistName;

                }
                Console.WriteLine("Sucessfully updated");
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
