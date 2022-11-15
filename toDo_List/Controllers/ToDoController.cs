using Business_Logic_Layer.Interfaces;
using Business_Logic_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
            if (await _BLL.PostToDo(toDo))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> PutToDo(ToDoModel toDo)
        {
            if (await _BLL.PutToDo(toDo))
            {
                return Ok();
            }
            return BadRequest();
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteToDo(int id)
        {
            if (await _BLL.DeleteToDo(id))
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
