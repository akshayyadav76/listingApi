using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listingApi.data
{
    public class ApiUser : IdentityUser
    {
        public string Fname { set; get; }
        public string Lname { set; get; }
    }
}
