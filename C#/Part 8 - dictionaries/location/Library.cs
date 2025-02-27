public class Library
{
  private Dictionary<string, Book> directory;

  public Library()
  {
    this.directory = new Dictionary<string, Book>();
  }

  public void AddBook(Book book)
  {
    string name = book.name;
    if (name == null)
    {
      name = "";
    }

    name = name.ToLower();
    name = name.Trim();

    if (this.directory.ContainsKey(name))
    {
      Console.WriteLine("Book is already in the library!");
    }
    else
    {
      directory.Add(name, book);
    }
  }
}