using System.Collections.Generic;

namespace Reporting.Core.Abstractions
{
    public interface IReportPrintingLayout
    {
        string ComponentLayout { get; }
        IEnumerable<IReportParameter> ReportParameters { get; }

    }
}