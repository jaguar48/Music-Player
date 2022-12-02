using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public partial class Music
    {
        public static void PlaySong()
        {
            Console.Clear();
            List<string> MyMusic = new List<string>();
            Console.WriteLine("Enter music ID you want to play");

            int SongtoPlay = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (true)
            {

                foreach (var musia in musics)
                {
                    MyMusic.Add($"Now Playing {musia.Track} by {musia.Artist}");

                }

                Console.WriteLine(MyMusic.ElementAt(SongtoPlay));
            start: Console.WriteLine("1: << Previous \n" +
               "2: Next >>\n" +
               "0: To Return to Main Menu");
                string input = Console.ReadLine();


                try
                {
                    if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine(MyMusic.ElementAt(SongtoPlay -= 1));
                        Console.WriteLine(SongtoPlay);

                        continue;
                    }


                    if (input == "2")
                    {
                        Console.Clear();
                        Console.WriteLine(MyMusic.ElementAt(SongtoPlay += 1));

                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
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
                    MyMusic.ElementAt(SongtoPlay = 1);
                    goto start;
                }

            }



        }
        public static void PlayListSong()
        {
            Console.Clear();
            List<string> PlayListMusic = new List<string>();
            Console.WriteLine("Enter music ID you want to play");

            int SongtoPlay = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (true)
            {

                foreach (var musia in list)
                {
                    PlayListMusic.Add($"Now Playing {musia.Track} by {musia.Artist}");

                }

                Console.WriteLine(PlayListMusic.ElementAt(SongtoPlay));
            start: Console.WriteLine("1: << Previous \n" +
               "2: Next >>\n" +
               "0: To Return to Main Menu");
                string input = Console.ReadLine();


                try
                {
                    if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine(PlayListMusic.ElementAt(SongtoPlay -= 1));
                        Console.WriteLine(SongtoPlay);

                        continue;
                    }


                    if (input == "2")
                    {
                        Console.Clear();
                        Console.WriteLine(PlayListMusic.ElementAt(SongtoPlay += 1));

                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
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
                    PlayListMusic.ElementAt(SongtoPlay = 1);
                    goto start;
                }

            }



        }
    }
}
