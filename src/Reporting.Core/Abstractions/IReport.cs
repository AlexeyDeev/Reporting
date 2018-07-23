namespace Reporting.Core.Abstractions
{
    public interface IReport
    {
        string Id { get; }
        string DisplayName { get; }
        IReportPrintingLayout ReportPrintingLayout { get; }
        IPrintingSystem PrintingSystem { get; }
        IBuildEngine BuildEngine { get; }
        IPrintingEngine PrintingEngine { get; }
    }
}