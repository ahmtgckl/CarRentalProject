using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService  //Bu servis sisteme giriş yapmayı ve kayıt olmayı sağlar.
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);  //Kayıt operasyonu
        IDataResult<User> Login(UserForLoginDto userForLoginDto); //Giriş operasyonu
        IResult UserExists(string email); //Kullanıcı kontrolü (Kullanıcı var mı ?)
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
