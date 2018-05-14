using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicPlayer_Server.Models;
using MusicPlayer_Server.Models.ViewModels;

namespace MusicPlayer_Server.DAL
{
    public class UserDAO
    {
        DbMusicPlayer dbMusicPlayer;

        public UserDAO()
        {
            dbMusicPlayer = new DbMusicPlayer();
        }

        public IEnumerable<user> GetUserById(int user_id)
        {
            var us = dbMusicPlayer.user.Where(s => s.user_id == user_id);

            if (us == null)
            {
                return null;
            }

            return us;
        }

        //getUser
        public IEnumerable<user> GetUserByUsername(string username, string password)
        {
            var us = dbMusicPlayer.user.Where(s => s.user_name == username && s.password == password);

           if (us == null)
            {
               return null;
            }
           
            return us;
        }
       

        //insertUser
        public long InsertUser(string username, string password, string email)
        {
            user us = new user();

            us.user_name = username;
            us.password = password;
            us.email = email;

            dbMusicPlayer.user.Add(us);
            dbMusicPlayer.SaveChanges();
            return us.user_id;
        }
    }
}