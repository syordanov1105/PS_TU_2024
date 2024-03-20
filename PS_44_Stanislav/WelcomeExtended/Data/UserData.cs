﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        List<User> _users;
        int _nextId;
        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void DeleteUser(User user) { 
            
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach(var user in _users)
            {
                if(user.Names == name && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool ValidateUserLamda(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Password == password)
                .FirstOrDefault() == null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                      where user.Names == name && user.Password == password
                      select user.Id;

            return ret != null ? true : false;
        }

        public User? GetUser(string name, string password)
        {
            User u = _users.Where(x => x.Names == name && x.Password == password)
                .FirstOrDefault();
            if (u == null)
            {
                throw new Exception("User not found!");
            }
            return u;
        }

        public void SetActive(string name, DateTime dateTime)
        {
            User? user = _users.Where(x => x.Names == name).FirstOrDefault();
            if (user != null)
            {
                user.Expires = dateTime;
            }
        }

        public void AssignUserRole(string name, UserRolesEnum role)
        {
            User? user = _users.Where(x => x.Names == name).FirstOrDefault();
            if (user != null)
            {
                user.Role = role;
            }
        }
    }

}
