﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIverse.Models.ViewModels
{
    public class UserProfileViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string ProfilePicturePath { get; set; }
        public int Age { get; set; }
        public List<Post> Posts { get; set; }
        public List<ApplicationUser> Friends { get; set; }
        public List<Group> Groups { get; set; }
        public University School { get; set; }
    }
}