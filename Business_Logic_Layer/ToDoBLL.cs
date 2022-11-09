using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business_Logic_Layer.AutoMapper;
using Business_Logic_Layer.Models;
using Data_Access_Layer.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Business_Logic_Layer
{
    public class ToDoBLL
    {
        private Data_Access_Layer.ToDoDAL _DAL;

        public ToDoBLL()
        {
            _DAL = new Data_Access_Layer.ToDoDAL();
        }

        public async Task<List<ToDoModel>> GetToDoList()
        {
            var toDosEntity = await _DAL.GetToDoList();
            List<ToDoModel> toDoModel = MyAutoMapper<ToDo, ToDoModel>.MapList(toDosEntity);

            return toDoModel;
        }

        public async Task<ToDoModel> GetToDoById(int id)
        {
            var toDoEntity = await _DAL.GetToDoById(id);
            ToDoModel toDoModel = MyAutoMapper<ToDo, ToDoModel>.Map(toDoEntity);

            return toDoModel;
        }

        public async Task<IActionResult> PostToDo(ToDoModel toDoModel)
        {
            ToDo toDoEntity = MyAutoMapper<ToDoModel, ToDo>.Map(toDoModel);
            return await _DAL.PostToDo(toDoEntity);
        }

        public async Task<IActionResult> DeleteToDo(int id)
        {
            return await _DAL.DeleteToDo(id);
        }

        public async Task<IActionResult> PutToDo(ToDoModel toDoModel)
        {
            ToDo toDoEntity = MyAutoMapper<ToDoModel, ToDo>.Map(toDoModel);
            return await _DAL.PutToDo(toDoEntity);
        }

    }
}
