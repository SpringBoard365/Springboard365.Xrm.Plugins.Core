﻿namespace DSmall.DynamicsCrm.Plugins.Core.IntegrationTest
{
    using System;
    using DSmall.UnitTest.Core;
    using Microsoft.Xrm.Sdk;
    using NUnit.Framework;

    /// <summary>The create contact specification.</summary>
    [TestFixture]
    public class CreateContactSpecification : SpecificationBase
    {
        private CreateContactSpecificationFixture testFixture;
        private Guid entityId;

        /// <summary>The should return a non empty id.</summary>
        [Test]
        public void ShouldReturnANonEmptyId()
        {
            Assert.AreNotEqual(Guid.Empty, entityId);
        }

        /// <summary>The should return input parameter containing target entity.</summary>
        [Test]
        public void ShouldReturnInputParameterContainingTargetEntity()
        {
            Assert.IsTrue(testFixture.Result.InputParameters.OneOf<Entity>("Target"));
        }

        /// <summary>The should return no pre entity images.</summary>
        [Test]
        public void ShouldReturnNoPreEntityImages()
        {
            Assert.IsTrue(testFixture.Result.PreEntityImages.NoParameters());
        }

        /// <summary>The should return post entity image containing asynchronous step primary name.</summary>
        [Test]
        public void ShouldReturnPostEntityImageContainingAsynchronousStepPrimaryName()
        {
            Assert.IsTrue(testFixture.Result.PostEntityImages.OneOf<Entity>("AsynchronousStepPrimaryName"));
        }

        /// <summary>The because of.</summary>
        protected override void BecauseOf()
        {
            entityId = testFixture.CrmWriter.Create(testFixture.RequestId, testFixture.EntityToCreate);

            testFixture.Result = Retry.Do(() => testFixture.EntitySerializer.Deserialize(testFixture.RequestId, testFixture.MessageName));
        }

        /// <summary>The context.</summary>
        protected override void Context()
        {
            testFixture = new CreateContactSpecificationFixture();
            testFixture.PerformTestSetup();
        }
    }
}