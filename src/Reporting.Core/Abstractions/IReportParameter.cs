using System.Collections;
using Reporting.Core.Enums;

namespace Reporting.Core.Abstractions
{
    public interface IReportParameter
    {
        ReportParameterType ParameterType { get; }
        IEnumerable ParameterValues { get; }
    }
}