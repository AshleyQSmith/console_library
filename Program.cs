using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //   section below = used prior to contructor
      //   Book myBook = new Book();
      //   myBook.Author = "Shel Silverstein";
      //   myBook.Title = "Where the Sidewalk Ends";

      //   section below = usable b/c of constructor
      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");

    }
  }
}
