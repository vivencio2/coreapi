﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

    }

    public enum Role
    {
        Employee,
        Manager
    }
}
