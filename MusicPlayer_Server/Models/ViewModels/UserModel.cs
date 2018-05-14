using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicPlayer_Server.Models.ViewModels
{
    public class UserModel
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string email { get; set; }
    }
}