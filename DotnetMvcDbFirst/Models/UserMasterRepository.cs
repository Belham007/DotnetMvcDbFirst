﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetMvcDbFirst.Models
{
    public class UserMasterRepository : IUserMasterRepository
    {
        private List<UserMaster> users = new List<UserMaster>();
        private int Id = 1;

        public UserMasterRepository()
        {
            // Add products for the Demonstration  
            users.Add(new UserMaster { Name = "User1", EmailID = "user1@test.com", MobileNo = "1234567890" });
            users.Add(new UserMaster { Name = "User2", EmailID = "user2@test.com", MobileNo = "1234567890" });
            users.Add(new UserMaster { Name = "User3", EmailID = "user3@test.com", MobileNo = "1234567890" });
        }

        //public UserMaster Add(UserMaster item)
        //{
        //    if (item == null)
        //    {
        //        throw new ArgumentNullException("item");
        //    }

        //    item.ID = Id++;
        //    users.Add(item);
        //    return item;
        //}

        //public bool Delete(int id)
        //{
        //    users.RemoveAll(p => p.ID == id);
        //    return true;
        //}

        //public UserMaster Get(int id)
        //{
        //    return users.FirstOrDefault(x => x.ID == id);
        //}

        public IEnumerable<UserMaster> GetAll()
        {
            return users;
        }

        //public bool Update(UserMaster item)
        //{
        //    if (item == null)
        //    {
        //        throw new ArgumentNullException("item");
        //    }
        //    int index = users.FindIndex(p => p.ID == item.ID);
        //    if (index == -1)
        //    {
        //        return false;
        //    }
        //    users.RemoveAt(index);
        //    users.Add(item);
        //    return true;
        //}
    }
}