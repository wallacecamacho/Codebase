using System.Threading.Tasks;

namespace Codebase.Infrastructure.Security
{
    public interface IJwtTokenGenerator
    {
        Task<string> CreateToken(string username);
    }
}