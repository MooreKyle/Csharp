using static System.Console;
class RecoveringDemo
{
   public static void Main()
   {
     Patient aPatient = new Patient();
     Upholsterer anUpholsterer = new Upholsterer();
     FootballPlayer aFootballPlayer = new FootballPlayer();
     Write("The patient says: ");
     aPatient.Recover();
     Write("The upholsterer says: ");
     anUpholsterer.Recover();
     Write("The football player says: ");
     aFootballPlayer.Recover();
   }
}

public interface IRecoverable
{
   void Recover();
}

class Patient : IRecoverable
{
    public void Recover()
    {
       WriteLine("I am getting better");
    }
}

class Upholsterer : IRecoverable
{
   public void Recover()
   {
      WriteLine("I have new material for the couch");
   }
}

class FootballPlayer : IRecoverable
{
   public void Recover()
   {
      WriteLine("I picked up the ball after a fumble");
   }
}
