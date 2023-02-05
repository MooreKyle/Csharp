using static System.Console;
class TestSoccerPlayer
{
  static void Main()
  {
    // Write your main here.
    SoccerPlayer mySoccerPlayer = new SoccerPlayer();
    mySoccerPlayer.Name = "Lionel";
    mySoccerPlayer.JerseyNum = 9;
    mySoccerPlayer.Goals = 8;
    mySoccerPlayer.Assists = 35;
    WriteLine("The SoccerPlayer is {0}. Jersey is #{1}.", mySoccerPlayer.Name, mySoccerPlayer.JerseyNum);
    WriteLine("Goals: {0}. Assists: {1}.", mySoccerPlayer.Goals, mySoccerPlayer.Assists);
  }
}
class SoccerPlayer
  {
    // Write your SoccerPlayer class here.
    public string Name {get; set;}
    public int JerseyNum {get; set;}
    public int Goals {get; set;}
    public int Assists {get; set;}
  }
