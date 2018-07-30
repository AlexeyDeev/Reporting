using System;
using System.Collections.Generic;
using Reporting.Core.Abstractions;

namespace Reporting.Factories
{
    public class PrintingEngineFactory : IPrintingEngineFactory
    {
        private readonly Dictionary<string, Func<IPrintingEngine>> _factoriesDictionary;

        public PrintingEngineFactory(Action<Dictionary<string, Func<IPrintingEngine>>> configAction)
        {
            _factoriesDictionary = new Dictionary<string, Func<IPrintingEngine>>();
            configAction(_factoriesDictionary);
        }

        public IPrintingEngine CreaPrintingEngine(string name)
        {
            if (_factoriesDictionary.TryGetValue(name, out var func))
            {
                return func();
            }

            throw new Exception("Unsupported printing engine type");
        }
    }
}