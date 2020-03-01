using System.Threading.Tasks;

namespace Codebase.Features.Profiles
{
    public interface IProfileReader
    {
        Task<ProfileEnvelope> ReadProfile(string username);
    }
}