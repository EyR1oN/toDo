using Data_Access_Layer.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface IToDoDAL
    {
        public Task<List<ToDo>> GetToDoList();

        public Task<ToDo> GetToDoById(int id);

        public Task<bool> PostToDo(ToDo todo);

        public Task<bool> DeleteToDo(int id);

        public Task<bool> PutToDo(ToDo toDo);
    }
}
