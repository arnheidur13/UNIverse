﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UNIverse.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public University ParentUniversity { get; set; }
        public List<ApplicationUser> Administrators { get; set; }
        public List<ApplicationUser> Members { get; set; }
        public string Description { get; set; }
    }
}