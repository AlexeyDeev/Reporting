using System;
using Reporting.Core.Enums;

namespace Reporting.Core.Abstractions
{
    public interface IRelation
    {
        string DataSourceValuePath { get; }
        string PrintingValuePath { get; }
        RelationType RelationType { get; }
        Func<object,object> RelationFunction { get; }
    }
}