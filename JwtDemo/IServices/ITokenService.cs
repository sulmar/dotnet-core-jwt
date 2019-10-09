using JwtDemo.Models;

namespace JwtDemo.IServices
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
