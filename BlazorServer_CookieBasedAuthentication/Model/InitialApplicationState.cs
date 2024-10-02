using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer_CookieBasedAuthentication.Model
{
    public class InitialApplicationState
    {
        public string XsrfToken { get; set; }
        public string Cookie { get; set; }
    }
}
