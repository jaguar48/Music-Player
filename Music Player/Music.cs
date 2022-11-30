using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class Music
    {
            public List<MusicList> musics = new List<MusicList>{
            new MusicList { Id = 1, Track ="May it be", Artist ="Enya" },
            new MusicList {Id = 2, Track ="Flora Secret", Artist ="Enya"},
            new MusicList {Id = 3,Track ="Orinoco flow", Artist ="Enya" },
            new MusicList {Id = 4, Track="Watermarks", Artist ="Enya"},
            new MusicList {Id = 5,Track ="China Roses",Artist ="Enya" },
            new MusicList {Id = 6,Track ="Storm in Africa",Artist ="Enya" } };

            List<MusicList> GetMusic()
            {
                return musics;
            }

            public static void MusicDisplay()
            {
                Music mymusic = new Music();
          
                mymusic.GetMusic().ForEach(music => Console.WriteLine($"Music id {music.Id} Track name: {music.Track} Artist: {music.Artist}"));

            }
        public static void AddMusic()
        {
            Music mymusic = new Music();

            int myid = 0;

            foreach (var msc in mymusic.GetMusic())
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

                mymusic.GetMusic().Add(new MusicList { Id = myid += 1, Track = track, Artist = artist });
                mymusic.GetMusic().ForEach(music => Console.WriteLine($"Music id {music.Id} Track name: {music.Track} Artist: {music.Artist}"));

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
        public static void Removemusic() {
            Music mymusic = new Music();

            Console.WriteLine("enter music ID to remove");
            int removemsc = Convert.ToInt32(Console.ReadLine());

            var firstMatch = mymusic.GetMusic().First(s => s.Id == removemsc);
            mymusic.GetMusic().Remove(firstMatch);
            mymusic.GetMusic().ForEach(music => Console.WriteLine($"Music id {music.Id} Track name: {music.Track} Artist: {music.Artist}"));

        }

    }
}