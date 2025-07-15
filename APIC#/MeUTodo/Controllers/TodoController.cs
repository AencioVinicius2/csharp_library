using MeUTodo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeUTodo.Controllers {
    [ApiController]
    [Route(template:"V1")]
    public class TodoController : ControllerBase {
        public List<Todo> Get() {
            return new List<Todo>();
        }
    }
}
