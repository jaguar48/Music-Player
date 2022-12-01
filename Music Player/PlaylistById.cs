using System.Security.Cryptography.X509Certificates;

namespace Music_Player
{
    internal class PlaylistById
    {
        public static void PlaylistId()
        {
            Console.Clear();    
            try
            {
                Console.WriteLine("Enter playlist name");
                Music.PlayListName = Console.ReadLine();

                Console.WriteLine("{0} successfully Created", Music.PlayListName.ToUpper());

                bool checkplay = true;
                while (checkplay)
                {
                    Console.WriteLine("Enter Id");
                    int enterID = Convert.ToInt32(Console.ReadLine());

                    foreach (var msc in Music.musics)
                    {
                        if (enterID == msc.Id)
                        {

                            Music.list.Add(msc);
                            Music.list.ForEach(newplaylist => Console.WriteLine($"{newplaylist.Id} {newplaylist.Track}"));

                        }
                       
                       
                    }
                    Console.WriteLine("Press 1 to add more \n Press any key to go main menu");
                    var moremusic = Console.ReadLine();
                    if (moremusic == "1")
                    {
                        checkplay = true;
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
