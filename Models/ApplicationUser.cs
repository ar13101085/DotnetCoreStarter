using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace CoreStarter.Models
{
    public class ApplicationUser : IdentityUser
    {

        public bool IsActive { get; set; }
    }

}