﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinGeigerDosimeter.Tables
{
    public class RegUserTable
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNamber { get; set; }
    }
}
