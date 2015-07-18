﻿namespace DSmall.DynamicsCrm.Plugins.Core.UnitTest
{
    using DSmall.UnitTest.Core;
    using NUnit.Framework;

    /// <summary>The when executing add item campaign activity plugin successfully.</summary>
    [TestFixture]
    public class WhenExecutingAddItemCampaignActivityPluginSuccessfully : SpecificationBase
    {
        private AddItemCampaignActivityPluginSpecificationFixture testFixture;

        /// <summary>The organization service should not be null.</summary>
        [Test]
        public void OrganizationServiceShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.OrganizationService);
        }

        /// <summary>The plugin execution context should not be null.</summary>
        [Test]
        public void PluginExecutionContextShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.PluginExecutionContext);
        }

        /// <summary>The tracing service should not be null.</summary>
        [Test]
        public void TracingServiceShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.TracingService);
        }

        /// <summary>The campaign activity id should not be null.</summary>
        [Test]
        public void CampaignActivityIdShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.CampaignActivityId);
        }

        /// <summary>The item id should not be null.</summary>
        [Test]
        public void ItemIdShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.ItemId);
        }

        /// <summary>The entity name should not be null.</summary>
        [Test]
        public void EntityNameShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.EntityName);
        }

        /// <summary>The because of.</summary>
        protected override void BecauseOf()
        {
            base.BecauseOf();

            testFixture.UnderTest.Execute(testFixture.ServiceProvider.Object);
        }

        /// <summary>The context.</summary>
        protected override void Context()
        {
            base.Context();

            testFixture = new AddItemCampaignActivityPluginSpecificationFixture();
            testFixture.PerformTestSetup();
        }
    }
}