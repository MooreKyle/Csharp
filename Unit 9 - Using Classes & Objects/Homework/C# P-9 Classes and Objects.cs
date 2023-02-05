//Preprocessor Directives/Using statements
using System;
using static System.Console;
using System.Globalization;

//class: MainContractor
class MainContractor
{
  //Function: Main
  public static void Main (string[] args)
  {
    //Assignment/Execution Statements
    //Declaration: Instantiate class object: myContractor
    Contractor myContractor = new Contractor();
    myContractor.name = "Placeholder name";
    myContractor.number = 1;
    myContractor.startDate = 01012020;

    //Display Data to User
    WriteLine("The Contractor name is {0}, and the Contractor number is {1}. The Contractor start date is {2} in MM/DD/YYYY format.", myContractor.name, myContractor.number, myContractor.startDate);
  }
}

//class: Contractor
class Contractor
{
  //Declarations: class attributes
  public string name {get; set;}
  public int number {get; set;}
  public int startDate {get; set;}
}