﻿using System.Reflection;

namespace Microsoft.Azure.Jobs.Host.Bindings.Runtime
{
    internal class RuntimeBindingProvider : IBindingProvider
    {
        public IBinding TryCreate(BindingProviderContext context)
        {
            ParameterInfo parameter = context.Parameter;

            if (parameter.ParameterType != typeof(IBinder))
            {
                return null;
            }

            return new RuntimeBinding(parameter.Name);
        }
    }
}