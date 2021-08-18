using Abp.Application.Services;

namespace RevisionControl.Report
{
    public interface IReportAppService : IApplicationService
    {
        byte[] GenerateTestReport();
    }
}