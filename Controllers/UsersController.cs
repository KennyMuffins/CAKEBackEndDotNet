using System.Collections.Generic;
using AutoMapper;
using Cake.Data;
using Cake.Dtos;
using Cake.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cake.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICakeRepo _repo;

        private readonly IMapper _mapper;

        public UsersController(ICakeRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //Get api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var userItems = _repo.GetAllUsers();

            return Ok(userItems);
        }

        //Get api/users/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var userItem = _repo.GetUserById(id);

            return Ok(_mapper.Map<User>(userItem));
        }

        //POST api/users
        [HttpPost]
        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);
            _repo.CreateUser(userModel);
            _repo.SaveChanges();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            //return Ok(userModel);
            return Ok(userReadDto);
        }

        //PUT api/commands
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UserUpdateDto userUpdateDto)
        {
            var userModelFromRepo = _repo.GetUserById(id);
            if (userModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(userUpdateDto, userModelFromRepo);

            _repo.UpdateUser(userModelFromRepo);
            _repo.SaveChanges();

            return NoContent();
        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var userModelFromRepo = _repo.GetUserById(id);
            if (userModelFromRepo == null)
            {
                return NotFound();
            }

            _repo.DeleteUser(userModelFromRepo);

            _repo.SaveChanges();

            return NoContent();
        }
    }
}