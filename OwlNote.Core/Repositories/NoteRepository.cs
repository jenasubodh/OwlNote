using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using OwlNote.Core.Models;

namespace OwlNote.Core.Repositories
{
	public class NoteRepository
	{
		NoteDatabase database;
		protected static string dbPath;		

		public NoteRepository (SQLiteConnection connection, string dbPath)
		{
			if (database == null) 
			{
				database = new NoteDatabase(connection, dbPath);
			}
		}

		public Note GetNote(int id)
		{
			return database.GetItem<Note>(id);
		}

		public IEnumerable<Note> GetNotes ()
		{
			return database.GetItems<Note>();
		}

		public int SaveNote (Note item)
		{
			return database.SaveItem<Note>(item);
		}

		public int DeleteNote(int id)
		{
			return database.DeleteItem<Note>(id);
		}
	}
}

