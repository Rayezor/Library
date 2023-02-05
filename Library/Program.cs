namespace Libray
{
	using Library.Models;

	public class Program
	{
		static void Main()
		{
			Book b1 = new Book() { Author = "Shakesspeare", Title = "Hamlet", DatePublished = new DateTime(1601, 6, 1) };
			LibraryContext context = new LibraryContext();

			context.Database.EnsureCreated();
			context.books.Add(b1);
			context.SaveChanges();
		}
	}
}