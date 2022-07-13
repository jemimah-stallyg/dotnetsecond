using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet3.rpg.Models;


namespace dotnet3.rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {

        private static List<Character> characters = new List<Character> 
        {
            new Character(),
            new Character { Name = "sam" }
        };
           

        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult <Character> GetSingle()
        {
            return Ok(characters[0]);
        }
        
    }
}