using JwtDemo.Models;

namespace JwtDemo.IServices
{
    public interface IAthorizationService
    {
        bool TryAthorize(string username, string password, out User user);
    }
}
