﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExaminationMVC.Models
{
    public class UserRegistrationResponse
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}