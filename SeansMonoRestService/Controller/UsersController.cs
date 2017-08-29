using System;
using System.Collections;
using System.Web.Http;
using System.Web.Http.Cors;
using SeansMonoRestService.Model;

namespace SeansMonoRestService.Controller
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {

        // GET api/Users 
        public IEnumerable Get()
        {
            return Program.Users;
        }

        // GET api/Users/5 
        public User Get(int id)
        {
            try
            {
                return Program.Users[id];
            }
            catch (Exception e)
            {
                return new User(-1, "", "");
            }
        }

        // POST api/Users 
        public void Post([FromBody] User value)
        {
            Program.Users.Add(++Program.UserCounter, new User(Program.UserCounter, value.Name, value.City));
        }

        // PUT api/Users/5 
        public void Put(int id, [FromBody] User value)
        {
            Program.Users[id].Name = value.Name;
            Program.Users[id].City = value.City;
        }

        // DELETE api/Users/5 
        public void Delete(int id)
        {
            Program.Users.Remove(id);
        }
    }
}