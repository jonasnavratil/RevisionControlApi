using System.Threading.Tasks;
using Abp.Application.Services;
using RevisionControl.Authorization.Accounts.Dto;

namespace RevisionControl.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
