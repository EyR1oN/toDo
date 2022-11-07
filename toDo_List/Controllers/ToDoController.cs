using Business_Logic_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace toDo_List.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {

        private Business_Logic_Layer.ToDoBLL _BLL;

        public ToDoController()
        {
            _BLL = new Business_Logic_Layer.ToDoBLL();
        }

        [HttpGet]
        public List<ToDoModel> GetToDoList()
        {
            return _BLL.GetToDoList();
        }

        [HttpGet]
        [Route("getById")]
        public ActionResult<ToDoModel> GetToDoById(int id)
        {
            var toDo = _BLL.GetToDoById(id);

            if (toDo == null)
            {
                throw new Exception("Not found");
            }

            return Ok(toDo);
        }

        [HttpPost]
        public void PostToDo(ToDoModel toDo)
        {
            _BLL.PostToDo(toDo);
        }

        [HttpPut]
        public void PutToDo(ToDoModel toDo)
        {
            _BLL.PutToDo(toDo);
        }


        [HttpDelete]
        public void DeleteToDo(int id)
        {
            _BLL.DeleteToDo(id);
        }

    }
}
