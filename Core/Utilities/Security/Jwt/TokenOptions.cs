using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        //Web API de appsettings kısımlarında token options sekmem var. orada ki değerlerle buradaki değerleri eşlemem gerekecek. daha nesnel çalışmak için
        //Bir JWT üretmenin çeşitli standartları var bizim bunları veriyor olmamız gerekiyor. Sade bir şekilde şundan bahsediyorum. appsetting içerisinde ki verilere
        // JWT oluştururken ihtiyacım var. bende orada ki değerleri bu nesnemile mapp edip 'CreateToken' yaparken kullanacağım
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
