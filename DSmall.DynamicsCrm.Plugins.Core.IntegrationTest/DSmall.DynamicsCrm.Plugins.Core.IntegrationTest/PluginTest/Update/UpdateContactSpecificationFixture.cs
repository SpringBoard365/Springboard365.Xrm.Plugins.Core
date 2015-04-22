﻿namespace DSmall.DynamicsCrm.Plugins.Core.IntegrationTest
{
    using Microsoft.Xrm.Sdk;

    /// <summary>The update contact specification fixture.</summary>
    public class UpdateContactSpecificationFixture : SpecificationFixtureBase
    {
        /// <summary>Gets the entity to update.</summary>
        public Entity EntityToUpdate { get; private set; }

        /// <summary>Gets the message name.</summary>
        public string MessageName { get; private set; }

        /// <summary>The perform test setup.</summary>
        public void PerformTestSetup()
        {
            MessageName = "Update";

            EntityToUpdate = new Entity("contact");
            EntityToUpdate.Attributes.Add("firstname", "DummyFirstName");

            EntityToUpdate.Id = OrganizationService.Create(EntityToUpdate);
        }
    }
}