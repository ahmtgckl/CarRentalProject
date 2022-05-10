using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encyption
{
    public class SigningCredentialsHelper
    {
        //security key ve algoritmamı belirlediğim nesnem
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature); //Şifrelenmiş kimliği oluşturuyoruz.
        }
    }
}
