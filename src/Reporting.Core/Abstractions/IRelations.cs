using System.Collections.Generic;

namespace Reporting.Core.Abstractions
{
    public interface IRelations
    {
        string ReportParameterId { get; }
        IEnumerable<IRelation> Relations { get; }
        void AddRelation(IRelation relation);
    }
}