using System;
using Reporting.Core.Abstractions;
using Reporting.Core.Enums;

namespace Reporting.Data.ReportParameters
{
    public class ParameterBase : IParameter
    {
        public string Id { get; }
        public string DisplayName { get; private set; }

        public ParameterBase(string id)
        {
            Id = id;
        }
        public void SetDisplayName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ApplicationException("Displayname can't be null or empty");
            }

            DisplayName = name;
        }
    }
}