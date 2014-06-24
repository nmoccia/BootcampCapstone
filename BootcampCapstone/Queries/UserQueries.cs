using BootcampCapstone.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BootcampCapstone.Queries
{
    public class UserQueries 
    {
        public User Get(string name)
        {
            User user;
            using (var db = new EventManagerEntities())
            {
                using (var tx = db.Database.Connection.BeginTransaction(IsolationLevel.Unspecified))
                {
                    user = db.Users.First(m => m.username == name);
                    if (user == null)
                    {
                        return HttpNotFound();
                    }
                }
            }
        }

    }
}
