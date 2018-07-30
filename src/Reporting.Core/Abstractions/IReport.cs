namespace Reporting.Core.Abstractions
{
    public interface IReport
    {
        string Id { get; }
        string DisplayName { get; }
        IReportPrintingLayout ReportPrintingLayout { get; }
        string PrintingSystemType { get; }
        string BuildEngineType { get; }
        string PrintingEngineType { get; }
    }
}