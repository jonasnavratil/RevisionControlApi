using System.Threading.Tasks;
using Abp.Application.Services;
using RevisionControl.Sessions.Dto;

namespace RevisionControl.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
