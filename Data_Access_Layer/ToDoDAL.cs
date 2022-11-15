using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Access_Layer.Interfaces;

namespace Data_Access_Layer
{
    public class ToDoDAL : IToDoDAL
    {

        private readonly ToDoListDbContext dataBaseContext;
        public ToDoDAL(ToDoListDbContext _dataBaseContext)
        {
            dataBaseContext = _dataBaseContext;
        }


        public async Task<List<ToDo>> GetToDoList()
        {
            return await dataBaseContext.ToDos.ToListAsync();
        }

        public async Task<ToDo> GetToDoById(int id)
        {
            ToDo todo = new ToDo();
            todo = await dataBaseContext.ToDos.FirstOrDefaultAsync(x => x.Id == id);

            return todo;
        }

        public async Task<bool> PostToDo(ToDo todo)
        {
            await dataBaseContext.AddAsync(todo);
            var posted = await dataBaseContext.SaveChangesAsync();
            return posted > 0;
        }

        public async Task<bool> DeleteToDo(int id)
        {
            ToDo todo = dataBaseContext.ToDos.FirstOrDefault(x => x.Id == id);
            dataBaseContext.ToDos.Remove(todo);
            var deleted = await dataBaseContext.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<bool> PutToDo(ToDo toDo)
        {
            dataBaseContext.Update(toDo);
            var updated = await dataBaseContext.SaveChangesAsync();
            return updated > 0;

        }
    }
}
