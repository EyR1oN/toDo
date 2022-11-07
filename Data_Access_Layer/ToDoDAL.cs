using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Data_Access_Layer
{
    public class ToDoDAL
    {
        public List<ToDo> GetToDoList()
        {
            var db = new ToDoListDbContext();
            return db.ToDos.ToList();
        }

        public ToDo GetToDoById(int id)
        {
            var db = new ToDoListDbContext();
            ToDo todo = new ToDo();
            todo = db.ToDos.FirstOrDefault(x => x.Id == id);

            return todo;
        }

        public void PostToDo(ToDo todo)
        {
            var db = new ToDoListDbContext();
            db.Add(todo);
            db.SaveChanges();
        }

        public void DeleteToDo(int id)
        {
            var db = new ToDoListDbContext();
            ToDo todo = db.ToDos.FirstOrDefault(x => x.Id == id);
            db.ToDos.Remove(todo);
            db.SaveChanges();
        }

        public void PutToDo(ToDo toDo)
        {
            var db = new ToDoListDbContext();
            db.Update(toDo);
            db.SaveChanges();
        }
    }
}
