/// <summary>
/// This class represents the database ("NoteDatabase")
/// This is also responsible for creating all the tables needed by the database
/// </summary>
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using OwlNote.Core.Models;

namespace OwlNote.Core
{
	public class NoteDatabase
	{
		static object locker = new object ();
		SQLiteConnection database;

		public NoteDatabase(SQLiteConnection conn, string dbPath)
		{
			database = conn;
			database.CreateTable<Note>();
		}

		public IEnumerable<T> GetItems<T> () where T : IBusinessEntity, new ()
		{
			lock (locker) {
				return (from i in database.Table<T>() select i).ToList();
			}
		}

		public T GetItem<T> (int id) where T : IBusinessEntity, new ()
		{
			lock (locker) {
				return database.Table<T>().FirstOrDefault(x => x.ID == id);
			}
		}

		public int SaveItem<T> (T item) where T : IBusinessEntity
		{
			lock (locker) {
				if (item.ID != 0) {
					database.Update(item);
					return item.ID;
				} else {
					return database.Insert(item);
				}
			}
		}

		public int DeleteItem<T>(int id) where T : IBusinessEntity, new ()
		{
			lock (locker) {
				return database.Delete<T>(id);
			}
		}
	}
}

