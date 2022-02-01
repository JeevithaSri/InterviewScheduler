using CandidateAPI.InterviewSchedulerModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateAPI.DataLayer
{

    [CustomExceptionFilter.CustomExceptionFilter]

    public class UsersDataLayer
    {
        private readonly InterviewScheduleContext db = new InterviewScheduleContext();

        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public int AddUser(User a)
        {
            db.Users.Add(a);

            return db.SaveChanges();
        }

        public User LoginUser(User a)
        {
            User user = db.Users.Where(user => user.Username == a.Username && user.Password == a.Password).SingleOrDefault();

            return user;
        }

        public int UpdateUser(int id, User c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteUser(int id)
        {
            User b = GetUserById(id);
            db.Users.Remove(b);
            return db.SaveChanges();
        }


        public User GetUserById(int id)
        {
            User c = db.Users.Find(id);
            return c;
        }


        public User GetUserByUserName(string Username)
        {
            User item = db.Users.FirstOrDefault(usr => usr.Username == Username);

            return item;
        }

        public List<Role> GetAllRoles()
        {
            return db.Roles.ToList();
        }

        public int AddRole(Role a)
        {
            db.Roles.Add(a);

            return db.SaveChanges();
        }

        public int UpdateRole(int id, Role c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteRole(int id)
        {
            Role b = GetRoleById(id);
            db.Roles.Remove(b);
            return db.SaveChanges();
        }


        public Role GetRoleById(int id)
        {
            Role c = db.Roles.Find(id);
            return c;
        }
    }
}
