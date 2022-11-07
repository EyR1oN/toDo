using System;
using System.Collections.Generic;
using Business_Logic_Layer.AutoMapper;
using Business_Logic_Layer.Models;
using Data_Access_Layer.Repository.Entities;

namespace Business_Logic_Layer
{
    public class ToDoBLL
    {
        private Data_Access_Layer.ToDoDAL _DAL;

        public ToDoBLL()
        {
            _DAL = new Data_Access_Layer.ToDoDAL();
        }

        public List<ToDoModel> GetToDoList()
        {
            var toDosEntity = _DAL.GetToDoList();
            List<ToDoModel> toDoModel = MyAutoMapper<ToDo, ToDoModel>.MapList(toDosEntity);

            return toDoModel;
        }

        public ToDoModel GetToDoById(int id)
        {
            var toDoEntity = _DAL.GetToDoById(id);
            ToDoModel toDoModel = MyAutoMapper<ToDo, ToDoModel>.Map(toDoEntity);

            return toDoModel;
        }

        public void PostToDo(ToDoModel toDoModel)
        {
            ToDo toDoEntity = MyAutoMapper<ToDoModel, ToDo>.Map(toDoModel);
            _DAL.PostToDo(toDoEntity);
        }

        public void DeleteToDo(int id)
        {
            _DAL.DeleteToDo(id);
        }

        public void PutToDo(ToDoModel toDoModel)
        {
            ToDo toDoEntity = MyAutoMapper<ToDoModel, ToDo>.Map(toDoModel);
            _DAL.PutToDo(toDoEntity);
        }

    }
}
