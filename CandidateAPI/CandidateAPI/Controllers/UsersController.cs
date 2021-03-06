using CandidateAPI.CustomExceptionFilter;
using CandidateAPI.DataLayer;
using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using UsersAPI.InterviewSchedulerModel;

namespace UsersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [CustomExceptionFilter]

    public class UsersController : ControllerBase
    {
        private readonly UsersDataLayer db = new UsersDataLayer();

        [HttpGet("GetAllUsers")]

        public List<User> GetAllUsers()
        {
            return db.GetAllUsers();
        }

        [HttpPost("AddUser")]

        public int AddUser(User a)
        {

            return db.AddUser(a);
        }
        [HttpPost("LoginUser")]

        public User LoginUser(User a)
        {

            return db.LoginUser(a);
        }


        [HttpGet("Username/{Username}")]
        public IActionResult GetUsername(string Username)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var user = db.GetUserByUserName(Username);
            

            if (user == null)
            {
                return NotFound();
            }


            return Ok(user);
        }

        [HttpGet("Password/{Password}")]
        public IActionResult GetPassword(string Password)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = db.GetPasswordByID(Password);


            if (user == null)
            {
                return NotFound();
            }


            return Ok(user);
        }

        [HttpPut("UpdateUser")]

        public int UpdateUser(int id, User c)
        {
            return db.UpdateUser(id, c);
        }


        [HttpDelete("DeleteUser")]

        public int DeleteUser(int id)
        {
            return db.DeleteUser(id);
        }

        [HttpGet("GetUserById")]

        public User GetUserById(int id)
        {
            return db.GetUserById(id);
        }


        [HttpGet("GetAllRoles")]
        public List<Role> GetAllRoles()
        {
            return db.GetAllRoles();
        }

        [HttpPost("AddRole")]
        public int AddRole(Role a)
        {

            return db.AddRole(a);
        }

        [HttpPut("UpdateRole")]
        public int UpdateRole(int id, Role c)
        {
            return db.UpdateRole(id, c);
        }


        [HttpDelete("DeleteRole")]
        public int DeleteRole(int id)
        {
            return db.DeleteRole(id);
        }


        [HttpGet("{id}/GetRoleById")]



        public Role GetRoleById(int id)
        {
            return db.GetRoleById(id);
        }
    }
}
