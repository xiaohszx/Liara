﻿// Author: Prasanna V. Loganathar
// Project: Liara
// Copyright (c) Launchark Technologies. All rights reserved.
// See License.txt in the project root for license information.
// 
// Created: 1:07 PM 15-02-2014

using System;
using System.Collections.Generic;
using System.Linq;
using Liara.Common;
using Liara.Formatting;
using Liara.Logging;
using Liara.ResponseProcessing;
using LightInject;

namespace Liara.Services
{
    public class DefaultServiceDiscovery : ILiaraServiceDiscovery
    {
        private readonly ILiaraServicesContainer container;

        public DefaultServiceDiscovery(ILiaraServicesContainer container)
        {
            CoreServiceOnlyAssemblyWhiteList = new List<string>
            {
                "Liara",
                "Liara.*"
            };

            AssemblyBlackList = new List<string>
            {
                "mscorlib",
                "System",
                "System.*",
                "Microsoft.*",
                "LightInject",
            };

            AssemblyWhiteList = new List<string>();

            TypeBlackList = new List<Type>();
            TypeWhiteList = new List<Type>();

            CoreServiceTypes = new List<Type>
            {
                typeof (LiaraModule),
                typeof (ILiaraFormatSelector),
                typeof (ILiaraFormatter),
                typeof (ILiaraStatusHandler),
                typeof (ILiaraResponseSynchronizer),
                typeof (ILiaraLogWriter)
            };

            this.container = container;
        }

        public List<string> AssemblyBlackList { get; set; }
        public List<string> AssemblyWhiteList { get; set; }
        public List<string> CoreServiceOnlyAssemblyWhiteList { get; set; }

        public List<Type> TypeBlackList { get; set; }
        public List<Type> TypeWhiteList { get; set; }

        public List<Type> CoreServiceTypes { get; set; }
        public int Priority { get; set; }

        public virtual void Discover()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var serviceContainer = (IServiceContainer) container.GetContainer();

            foreach (var assembly in assemblies)
            {
                var name = assembly.GetName().Name;

                var coreServicesOnly = CoreServiceOnlyAssemblyWhiteList.Any(x => IsWildcardedMatch(x, name));

                if (coreServicesOnly ||
                    AssemblyWhiteList.Any(w => IsWildcardedMatch(w, name)) ||
                    !AssemblyBlackList.Any(b => IsWildcardedMatch(b, name)))
                {
                    //TODO: Add auto-discovery logic, and de-couple discovery from container using ILiaraServiceContainer.Register() methods.

                    if (coreServicesOnly)
                    {
                        serviceContainer.RegisterAssembly(assembly, (type, implType) => CoreServiceTypes.Contains(type));
                    }
                    else
                    {
                        serviceContainer.RegisterAssembly(assembly,
                            (type, implType) => TypeWhiteList.Contains(type) || !TypeBlackList.Contains(type));
                    }
                }
            }

            if (Global.FrameworkLogger.IsEnabled)
            {
                foreach (var serviceRegistration in serviceContainer.AvailableServices)
                {
                    Global.FrameworkLogger.WriteTo("Registered Services", "{0}Type: {1}",
                        string.IsNullOrWhiteSpace(serviceRegistration.ServiceName)
                            ? string.Empty
                            : "Name: " + serviceRegistration.ServiceName + ", ",
                        serviceRegistration.ServiceType);
                }
            }
        }

        public bool IsWildcardedMatch(string wildCardedString, string valueString)
        {
            if (wildCardedString.Contains('*'))
            {
                return valueString.StartsWith(wildCardedString.Substring(0, wildCardedString.IndexOf('*'))) &&
                       valueString.EndsWith(wildCardedString.Substring(wildCardedString.LastIndexOf('*') + 1));
            }

            return wildCardedString == valueString;
        }
    }
}