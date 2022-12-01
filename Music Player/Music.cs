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

            Console.WriteLine("Enter 1 to Sort by Name, 2 to exit");
            var continuesort = Console.ReadLine();
            if (continuesort == "1")
            {
                SortMusic();
            }
            Console.WriteLine("Enter any key to main menu");
        }


        public static void DisplayList()
        {
            Console.Clear();

            Console.WriteLine("Playlist Name: {0}", PlayListName);
            try
            {
                list.ForEach(disp => Console.WriteLine($"Music id {disp.Id} Track name: {disp.Track} Artist: {disp.Artist}"));
                Console.WriteLine("Enter 1 to Shuffle playlist, 2 to exit");
                var continueshf = Console.ReadLine();
                if (continueshf == "1")
                {
                    ShufflePlayList();
                }
                Console.WriteLine("Enter any key to main menu");
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
            Console.WriteLine("Enter first letter");
            var firstsort = Console.ReadLine();

            Console.WriteLine("Enter second letter");
            var secondsort = Console.ReadLine();

            musics.Sort((firstsort, secondsort) => string.Compare(firstsort.Track, secondsort.Track));


       

            MusicDisplay();

        }
    }
}