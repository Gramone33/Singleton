using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {

        // private IdUnique idUnique = IdUnique.getSingleton();
        private CommentsArray commentsArray = CommentsArray.getSingleton();


        [HttpGet]
        public IEnumerable<string> Get([FromQuery] string saisieUser)
        {
            commentsArray.AddComment(saisieUser);
            return commentsArray.Comments;
        }
    }
}
