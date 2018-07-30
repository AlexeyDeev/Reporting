namespace Reporting.Core.Abstractions
{
    public interface IBuildEngineFactory
    {
        IBuildEngine CreateEngine(string name);
    }
}