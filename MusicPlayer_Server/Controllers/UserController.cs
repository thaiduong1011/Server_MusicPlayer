using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MusicPlayer_Server.DAL;
using MusicPlayer_Server.Models;

namespace MusicPlayer_Server.Controllers
{
    public class UserController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IEnumerable<user> Get(string username, string password)
        {
            return new UserDAO().GetUserByUsername(username, password);
        }

        public IEnumerable<user> Get(int user_id)
        {
            return new UserDAO().GetUserById(user_id);
        }

        // POST api/values
        public long Post(string username, string password, string email)
        {
            return new UserDAO().InsertUser(username, password, email);
        }


        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
