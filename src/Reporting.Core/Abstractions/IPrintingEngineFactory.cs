namespace Reporting.Core.Abstractions
{
    public interface IPrintingEngineFactory
    {
        IPrintingEngine CreaPrintingEngine(string name);
    }
}