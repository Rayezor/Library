using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
	[Table("Titles")]
	public class Book
	{
		[Key]
		public string Title { get; set; }
		public string ISBN { get; set; }
		public string Author { get; set; }
		public DateTime DatePublished { get; set; }
	}
}
