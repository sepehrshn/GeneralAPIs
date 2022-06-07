using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Public.Contaract;
using Public.DTOs;
using Microsoft.AspNetCore.Http;
using System;

namespace Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth auth;
        public AuthController(IAuth _auth)
        {
            auth = _auth;
        }

        // GET: api/<AuthController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/<AuthController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody] LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                string jwt = auth.Login(loginDTO);
                if (string.IsNullOrEmpty(jwt)) 
                {
                    return BadRequest(new { message = "Invalid Credentials" });
                }
                Response.Cookies.Append("AUTHJWT", jwt, new CookieOptions() { HttpOnly = true, Path = "/", Expires = DateTime.Now.AddDays(30) });
                return Ok(new {message = "success"});
            }
        }
    }
}
