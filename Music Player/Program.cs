using Music_Player;

class App
{
    public static void Main(string[] args)
    {
        while (true){
            Console.WriteLine("Press 1 to display current music \nPress 2 to add new music \nPress 3 to remove music\nPress 4 to edit music\nPress 5 to create playlist\nPress 6 to view playlist\nPress 7 to shuffle\nPress 0 or enter key to exit"); var enteropt = Console.ReadLine();
            if (enteropt == "1")
            {

                Music.MusicDisplay();
            }
            else if(enteropt == "2")
            {
                Music.AddMusic();
            }

            else if (enteropt == "3")
            {
                Music.Removemusic();
            }
            else if (enteropt == "4")
            {
                Music.EditMusic();
            }

            else if (enteropt == "5")
            {
                Music.CreatePlayList();
            }
            else if (enteropt == "6")
            {
                Music.DisplayList();
            }
            else if (enteropt == "7")
            {
                Music.ShuffleMusic();
            }
            else
            {
                Console.WriteLine("Goodbye buddy!");
                break;
            }
        }    
        

    }
}