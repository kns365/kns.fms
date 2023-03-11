using System.Threading.Tasks;
using Abp.Application.Services;
using kns.fms.Authorization.Accounts.Dto;

namespace kns.fms.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
