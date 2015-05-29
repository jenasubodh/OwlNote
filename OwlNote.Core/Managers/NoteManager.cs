using System;
using System.Collections.Generic;
using SQLite;
using OwlNote.Core.Models;
using OwlNote.Core.Repositories;

namespace OwlNote.Core.Managers
{
	public class NoteManager
	{
		NoteRepository repository;

		public NoteManager (SQLiteConnection conn)
		{
			if (repository == null) 
			{
				repository = new NoteRepository (conn, "");
			}
		}

		public Note GetNote(int id)
		{
			return repository.GetNote(id);
		}

		public IList<Note> GetNotes ()
		{
			return new List<Note>(repository.GetNotes());
		}

		public int SaveNote (Note item)
		{
			return repository.SaveNote(item);
		}

		public int DeleteNote(int id)
		{
			return repository.DeleteNote(id);
		}

	}
}

