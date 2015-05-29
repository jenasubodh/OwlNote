using System;
using SQLite;

namespace OwlNote.Core.Models
{
	public class Note : IBusinessEntity
	{
		public Note ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime Date {get; set;}
	}
}

