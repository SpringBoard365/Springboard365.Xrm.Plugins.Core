namespace Springboard365.Xrm.Plugins.Core.IntegrationTest
{
    using System;
    using Microsoft.Crm.Sdk.Messages;
    using Microsoft.Xrm.Sdk;

    public class CloseIncidentSpecificationFixture : SpecificationFixtureBase
    {
        public CloseIncidentRequest CloseIncidentRequest { get; private set; }

        public string MessageName { get; private set; }

        public void PerformTestSetup()
        {
            MessageName = "Close";

            var caseEntity = EntityFactory.CreateCase();

            var caseResolutionEntity = new Entity("incidentresolution")
            {
                Id = Guid.NewGuid()
            };
            caseResolutionEntity["incidentid"] = caseEntity.ToEntityReference();

            CloseIncidentRequest = new CloseIncidentRequest
            {
                IncidentResolution = caseResolutionEntity,
                Status = new OptionSetValue(5),
            };
        }
    }
}