﻿namespace Springboard365.Xrm.Plugins.Core.Test.Entities
{
    using System.Runtime.Serialization;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;

    [DataContract]
    [EntityLogicalName("incidentresolution")]
    internal class IncidentResolution : Entity
    {
        internal IncidentResolution() :
            base(EntityLogicalName)
        {
        }

        internal const string EntityLogicalName = "incidentresolution";
    }
}