using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeRole
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRoleId")]
        public String GNodeRoleId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Definition")]
        public String Definition { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EffortlessAPILexiconSpeakerNIC")]                    
        [RemoteIsCollection]
        public String[] EffortlessAPILexiconSpeakerNIC { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EffortlessAPIListenerNIC")]                    
        [RemoteIsCollection]
        public String[] EffortlessAPIListenerNIC { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StrategiesNIC")]                    
        [RemoteIsCollection]
        public String[] StrategiesNIC { get; set; }
    
        // [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricallyConnectsAndDisconnects")]
        // public String ElectricallyConnectsAndDisconnects { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasInterconnectionComponentDerived")]
        public Boolean HasInterconnectionComponentDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasPowerLevel")]
        public Boolean HasPowerLevel { get; set; }
    
        // [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasVoltage")]
        // public String HasVoltage { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrimaryRoleForTheseGNodesNIC")]                    
        [RemoteIsCollection]
        public String[] PrimaryRoleForTheseGNodesNIC { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CoreLexiconNIC")]                    
        [RemoteIsCollection]
        public String[] CoreLexiconNIC { get; set; }
    
        // [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasAgent")]
        // public String HasAgent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ColorHex")]
        public String ColorHex { get; set; }
    

        

        
        
        private static string CreateGNodeRoleWhere(IEnumerable<GNodeRole> gNodeRoles, String forignKeyFieldName = "GNodeRoleId")
        {
            if (!gNodeRoles.Any()) return "1=1";
            else 
            {
                var idList = gNodeRoles.Select(selectGNodeRole => String.Format("'{0}'", selectGNodeRole.GNodeRoleId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
