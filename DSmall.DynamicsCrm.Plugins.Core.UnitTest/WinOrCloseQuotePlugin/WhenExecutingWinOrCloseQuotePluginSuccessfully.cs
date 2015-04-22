﻿namespace DSmall.DynamicsCrm.Plugins.Core.UnitTest
{
    using DSmall.UnitTest.Core;
    using NUnit.Framework;

    /// <summary>The when executing win or close quote plugin successfully.</summary>
    public class WhenExecutingWinOrCloseQuotePluginSuccessfully : SpecificationBase
    {
        private WinOrCloseQuotePluginSpecificationFixture testFixture;

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

        /// <summary>The quote entity should not be null.</summary>
        [Test]
        public void QuoteEntityShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.QuoteClose);
        }

        /// <summary>The state should not be null.</summary>
        [Test]
        public void StateShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.State);
        }

        /// <summary>The status should not be null.</summary>
        [Test]
        public void StatusShouldNotBeNull()
        {
            Assert.IsNotNull(testFixture.UnderTest.Status);
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

            testFixture = new WinOrCloseQuotePluginSpecificationFixture();
            testFixture.PerformTestSetup();
        }
    }
}