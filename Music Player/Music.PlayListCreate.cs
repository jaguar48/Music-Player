namespace Music_Player
{
    public static partial class Music
    {
        public static void CreatePlayList()
        {
            Console.Clear();

            start: Console.WriteLine("Press 1 to Add by ID \nPress 2 to Add by Range");
           
                var PlayList = Console.ReadLine();
            try
            {
                if (PlayList == "1")
                {

                    PlaylistById.PlaylistId();
                }
                else if (PlayList == "2")
                {

                    Console.WriteLine("Enter playlist name");
                    Music.PlayListName = Console.ReadLine();

                    Console.WriteLine("{0} successfully Created", PlayListName.ToUpper());
                    Console.Clear();
                    Console.WriteLine("Enter from 0-6");
                    Console.WriteLine("enter first range");
                    int range1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter second range");
                    int range2 = Convert.ToInt32(Console.ReadLine());

                    list = musics.GetRange(range1, range2);
                    list.ForEach(rangelist => Console.WriteLine($"{rangelist.Id} {rangelist.Track}"));


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid input {PlayList}");
                    goto start;
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
