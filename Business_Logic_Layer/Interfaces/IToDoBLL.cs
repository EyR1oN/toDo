using Business_Logic_Layer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface IToDoBLL
    {
        public Task<List<ToDoModel>> GetToDoList();

        public Task<ToDoModel> GetToDoById(int id);

        public Task<bool> PostToDo(ToDoModel toDoModel);

        public Task<bool> DeleteToDo(int id);

        public Task<bool> PutToDo(ToDoModel toDoModel);

    }
}
