using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess;

namespace MongoDB_CRUD.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        MongoDbDataAccess mogodb = new MongoDbDataAccess();

        [HttpGet]
        public List<UserInfo> GetAllUsers()
        {
            //MongoDB_CRUD mongoDB_CRUD = new MongoDB_CRUD();
            return mogodb.GetAllUsers();
            //MongoDbDataAccess mongdb = new MongoDbDataAccess();
            //IEnumerable<UserInfo> userInfos = mongdb.GetUserInfo();
            //return userInfos;

        }
        [HttpGet]
        public UserInfo GetUserById(int id)
        {
            return mogodb.GetSingleUser(id);
        }

        [HttpPost]
        public bool AddUser(UserInfo user)
        {
            return mogodb.AddUser(user);
        }

        [HttpPost]
        public UserInfo UpdateUser(UserInfo user)
        {
            UserInfo userUpd =  mogodb.UpdateUser(user);
            return userUpd;
        }

        [HttpGet]
        public bool DeleteUser(int id)
        {
            return mogodb.DeleteUser(2);
        }
    }
}
