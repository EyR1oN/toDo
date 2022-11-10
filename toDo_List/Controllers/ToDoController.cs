using Business_Logic_Layer.Interfaces;
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

        private IToDoBLL _BLL;

        public ToDoController(IToDoBLL BLL)
        {
            _BLL = BLL;
        }

        [HttpGet]
        public async Task<List<ToDoModel>> GetToDoList()
        {
            return await _BLL.GetToDoList();
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetToDoById(int id)
        {
            var toDo = await _BLL.GetToDoById(id);

            if (toDo == null)
            {
                throw new Exception("Not found");
            }

            return Ok(toDo);
        }

        [HttpPost]
        public async Task<IActionResult> PostToDo(ToDoModel toDo)
        {
            return await _BLL.PostToDo(toDo);
        }

        [HttpPut]
        public async Task<IActionResult> PutToDo(ToDoModel toDo)
        {
            return await _BLL.PutToDo(toDo);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteToDo(int id)
        {
            return await _BLL.DeleteToDo(id);
        }

    }
}
