﻿using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Inceptum.AppServer.Configuration;

namespace Inceptum.Applications.EventStoreNode.Single
{
    public class ApplicationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<ConfigurationFacility>(f => f.Configuration("event-store"));
            container.Register(Component.For<SingleNodeConfiguration>().FromConfiguration("single-node", "", "{environment}", "{instance}"));
        }
    }
}