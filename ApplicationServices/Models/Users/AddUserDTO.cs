﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Models.Users
{
    public class AddUserDTO
    {
        public string Name { get; set; }
        public string lastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? Mobile { get; set; }
        public long UserRol { get; set; }
    }
}
