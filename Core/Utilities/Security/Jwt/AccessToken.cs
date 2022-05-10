using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        //AccesToken nesnelerim
        public string Token { get; set; } //girş yapan kullanıcıya vereceğim token 
        public DateTime Expiration { get; set; } // kullanıcının token süresinin gerçiliği.

    }
}
