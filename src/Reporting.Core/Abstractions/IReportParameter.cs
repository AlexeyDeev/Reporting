using Reporting.Core.Enums;

namespace Reporting.Core.Abstractions
{
    public interface IReportParameter
    {
        string Id { get; }
        ReportParameterTypes ParameterType { get; }
        string DisplayName { get; }
    }
}