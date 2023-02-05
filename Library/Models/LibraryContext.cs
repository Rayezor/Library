using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
	public class LibraryContext : DbContext
	{
		private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=False;";
		public DbSet<Book> books { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString); // test
		}
	}
}
