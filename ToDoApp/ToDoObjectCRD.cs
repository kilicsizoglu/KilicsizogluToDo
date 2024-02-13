using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class ToDoObjectCRD
    {
        public SQLiteConnection connection;
        public ToDoObjectCRD()
        {
            connection = new SQLiteConnection("Data Source=" + ".\\app.db");
            connection.Open();

            // Tablo oluşturma sorgusu
            string createTableQuery = "CREATE TABLE IF NOT EXISTS ToDoList (Id INTEGER PRIMARY KEY AUTOINCREMENT, Task TEXT)";
            var command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }
        public void InsertToDoObject(ToDoObject obj)
        {
            string insertQuery = "INSERT INTO ToDoList (Task) VALUES (@Task)";
            var command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Task", obj.task);
            command.ExecuteNonQuery();
            obj.id = (int)connection.LastInsertRowId;
        }

        public void DeleteToDoObject(string task)
        {
            string deleteQuery = "DELETE FROM ToDoList WHERE Task = @Task";
            var command = new SQLiteCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@Task", task);
            command.ExecuteNonQuery();
        }

        public List<ToDoObject> SelectAllToDoObjects()
        {
            List<ToDoObject> ToDos = new List<ToDoObject>();
            string selectQuery = "SELECT * FROM ToDoList";
            var command = new SQLiteCommand(selectQuery, connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string? task = reader["Task"].ToString();
                    ToDoObject toDoObject = new ToDoObject();
                    toDoObject.id = id;
                    toDoObject.task = task;
                    ToDos.Add(toDoObject);
                }
            }
            return ToDos;
        }
    }
}
