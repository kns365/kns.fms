using System.Threading.Tasks;
using Abp.Application.Services;
using kns.fms.Sessions.Dto;

namespace kns.fms.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
