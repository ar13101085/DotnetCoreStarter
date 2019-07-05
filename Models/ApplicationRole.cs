using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CoreStarter.Models
{
    public class ApplicationRole:IdentityRole
    {
        public bool IsActive { get; set; }
    }
}
