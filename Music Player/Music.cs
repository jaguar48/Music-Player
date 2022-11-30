namespace Music_Player
{
    internal class Music
    {
        public static  List<MusicList> musics = new List<MusicList>{
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
            

            GetMusic().ForEach(music => Console.WriteLine($"Music id {music.Id} Track name: {music.Track} Artist: {music.Artist}"));

        }
        public static void AddMusic()
        {
            

            int myid = 0;

            foreach (var msc in GetMusic())
            {
                if (msc.Id != myid)
                {
                    myid += 1;

                }
            }
            bool checksession = true;
            while (checksession)
            {
                Console.WriteLine("Add new musics");
                Console.WriteLine("Enter name of song");
                var track = Console.ReadLine();

                Console.WriteLine("Enter Artist name");
                var artist = Console.ReadLine();

                GetMusic().Add(new MusicList { Id = myid += 1, Track = track, Artist = artist });
                MusicDisplay();
                Console.WriteLine("do you want to add more press 1 \n ");
                var moremusic = Console.ReadLine();
                if (moremusic == "1")
                {
                    checksession = true;
                }
                else
                {
                    Console.WriteLine("goodbye");
                    break;
                }
            }
        }
        public static void Removemusic()
        {
            

            Console.WriteLine("enter music ID to remove");
            int removemsc = Convert.ToInt32(Console.ReadLine());

            var firstMatch = GetMusic().First(s => s.Id == removemsc);
            GetMusic().Remove(firstMatch);
            MusicDisplay();

        }

    }
}