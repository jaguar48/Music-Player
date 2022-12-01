using System.Text.RegularExpressions;

namespace Music_Player
{
    public static partial class Music
    {
        public static void AddMusic()
        {
            Console.Clear();
            
                foreach (var msc in GetMusic())
                {
                    if (msc.Id != myid)
                    {
                        myid += 1;

                    }
                }
            try
            {
                bool checksession = true;
                while (checksession)
                {
                    Console.WriteLine("Add new musics");
                    start: Console.WriteLine("Enter song name");
                    var track = Console.ReadLine();
                    string userpattern = @"^[a-zA-Z]{10}$";
                    Regex trackreg = new(userpattern);

                    if (trackreg.IsMatch(track))
                    {
                        Console.WriteLine("valid");
                        continue;
                        
                    }

                   if (string.IsNullOrEmpty(track))
                    {
                        Console.WriteLine("Enter Valid input");
                        goto start;
                    }

                setes: Console.WriteLine("Enter Artist name");
                    var artist = Console.ReadLine();
                    if (string.IsNullOrEmpty(artist))
                    {
                        Console.WriteLine("invalid valid");
                        goto setes;
                    }

                    GetMusic().Add(new MusicList { Id = myid += 1, Track = track, Artist = artist });
                    MusicDisplay();
                    Console.WriteLine("press 1 to add more, Hit any key to go main menu \n ");
                    var moremusic = Console.ReadLine();
                    if (moremusic == "1")
                    {
                        checksession = true;
                    }
                    else
                    {
                        Console.WriteLine("Thank you");
                        break;
                    }
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
            }

        }
    }
}
