using System;
using System.Collections.Generic;
using Reporting.Core.Abstractions;

namespace Reporting.Factories
{
    public class BuildEngineFactory : IBuildEngineFactory
    {
        private readonly Dictionary<string, Func<IBuildEngine>> _factoriesDictionary;

        public BuildEngineFactory(Action<Dictionary<string, Func<IBuildEngine>>> configAction)
        {
            _factoriesDictionary = new Dictionary<string, Func<IBuildEngine>>();
            configAction(_factoriesDictionary);
        }

        public IBuildEngine CreateEngine(string name)
        {
            if (_factoriesDictionary.TryGetValue(name, out var func))
            {
                return func();
            }

            throw new Exception("Unsupported build engine type");
        }
    }
}