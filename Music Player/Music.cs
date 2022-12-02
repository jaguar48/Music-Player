namespace Music_Player
{
    public static partial class Music
    {
        public static string? PlayListName;

        private static readonly Random rng = new();

        public static List<MusicList> list = new();

        public static int myid = 0;

        public static List<MusicList> musics = new List<MusicList>{
            new MusicList {Id = 1, Track ="May it be", Artist ="Enya" },
            new MusicList {Id = 2, Track ="Flora Secret", Artist ="Enya"},
            new MusicList {Id = 3,Track ="Orinoco flow", Artist ="Enya" },
            new MusicList {Id = 4, Track="Watermarks", Artist ="Enya"},
            new MusicList {Id = 5,Track ="China Roses",Artist ="Enya" },
            new MusicList {Id = 6,Track ="Storm in Africa",Artist ="Enya" } };

        static List<MusicList> GetMusic()
        {
            return musics;
        }

        public static void MusicDisplay()
        {
            Console.Clear();



            GetMusic().ForEach(music => Console.WriteLine($"Music id {music.Id} Track name: {music.Track} Artist: {music.Artist}"));

            Console.WriteLine("====> Enter 1 to play songs,====> 2 to Sort, ====>3 to shuffle, Press any key to go back");
            var continuesort = Console.ReadLine();
            if (continuesort == "1")
            {
                PlaySong();

            }
            if (continuesort == "2")
            {
                SortMusic();

            }
            if (continuesort == "3")
            {
                ShuffleMusic();


            }


        }


        public static void DisplayList()
        {
            Console.Clear();

            Console.WriteLine("Playlist Name: {0}", PlayListName);
            try
            {
                list.ForEach(disp => Console.WriteLine($"Music id {disp.Id} Track name: {disp.Track} Artist: {disp.Artist}"));
                Console.WriteLine("Enter 1 to Shuffle playlist,Press any key to go main menu");
                var continueshf = Console.ReadLine();
                if (continueshf == "1")
                {
                    ShufflePlayList();
                }
                Console.Clear();
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

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (list[n], list[k]) = (list[k], list[n]);
            }
        }

        public static void ShuffleMusic()
        {

            GetMusic().Shuffle();
            MusicDisplay();

        }
        public static void ShufflePlayList()
        {
            list.Shuffle();
            DisplayList();

        }

        public static void SortMusic()
        {
            /*Console.WriteLine("Enter first letter");
            var firstsort = Console.ReadLine();
*/
            Console.WriteLine("Enter second letter");
            var secondsort = Console.ReadLine();
            /* foreach (var mols in musics)
             {
                 if (mols.Id == secondsort)
                 {
                     musics.Sort();
                 }
             }*/


            /*   musics.Sort((firstsort, secondsort) => string.Compare(firstsort.Track, secondsort.Track));*/

            MusicDisplay();

        }

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
    }
}