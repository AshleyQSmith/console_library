using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public string Name { get; set; }
    public string Location { get; set; }
    private List<Book> Books { get; set; }

    // constructor:
    public Library(string name, string location, List<Book> books)
    {
      Name = name;
      Location = location;
      Books = books;
    }
  }
}