using Music_Player;

class App
{
    public static void Main(string[] args)
    {
        while (true){
            Console.WriteLine("Press 1 to display current music \n press 2 to add new music,3 to remove music");
            var enteropt = Console.ReadLine();
            if (enteropt == "1")
            {

                Music.MusicDisplay();
            }
            else if(enteropt == "2")
            {
                Music.AddMusic();
            }
            else if(enteropt=="3")
            {
                Music.Removemusic();
            }
        }    
        

    }
}
