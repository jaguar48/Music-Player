using Music_Player;

class App
{
    public static void Main(string[] args)
    {
        while (true){
            Console.WriteLine("Press 1 to display current music, press 2 to add new music,3 to remove music,\n 4 to edit music 5 to create playlist,\n 6 to view playlist, 7 to shuffle");
            var enteropt = Console.ReadLine();
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
        }    
        

    }
}
