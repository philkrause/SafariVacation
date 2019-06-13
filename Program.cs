using System;
using System.Threading;

namespace SafariVacation
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      string Welcome = "Welcome to the Deadly Safari! My name is Mugato, and we have had over 22000 accidents since we have opened. Type list if you would like to view the animals you have seen";
      foreach (char c in Welcome)
      {
        Console.Write(c);
        Thread.Sleep(50);
      }




    }
  }
}
