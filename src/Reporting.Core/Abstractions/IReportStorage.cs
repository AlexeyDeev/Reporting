using System.Collections.Generic;

namespace Reporting.Core.Abstractions
{
    public interface IReportStorage
    {
        IReport GetById(string reportId);
        void SaveAs(IReport report);
        void Update(IReport reprot);
        void Delete(string reportId);
        List<IReport> GetAllReports();
        List<string> GetAllDisplayNames();
    }
}