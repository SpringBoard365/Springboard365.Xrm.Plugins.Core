﻿namespace DSmall.DynamicsCrm.Plugins.Core.IntegrationTest
{
    using Microsoft.Xrm.Client.Services;
    using Microsoft.Xrm.Sdk;

    /// <summary>The specification fixture base.</summary>
    public class SpecificationFixtureBase
    {
        private const string ConnectionStringSettingName = "CrmConnection";

        /// <summary>Initialises a new instance of the <see cref="SpecificationFixtureBase"/> class.</summary>
        public SpecificationFixtureBase()
        {
            OrganizationService = new OrganizationService(ConnectionStringSettingName);
            CrmHelper = new CrmHelper(OrganizationService);
            CleanUp = new CrmCleaner(OrganizationService);
        }

        /// <summary>Gets the organization service.</summary>
        public IOrganizationService OrganizationService { get; private set; }

        /// <summary>Gets the crm helper.</summary>
        public CrmHelper CrmHelper { get; private set; }

        /// <summary>Gets the clean up.</summary>
        public CrmCleaner CleanUp { get; private set; }
    }
}