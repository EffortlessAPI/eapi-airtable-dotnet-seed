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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Definition")]
        public String Definition { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasInterconnectionComponentDerived")]
        public Boolean HasInterconnectionComponentDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ColorHex")]
        public String ColorHex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasAgentValue")]
        public String HasAgentValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasAgentDerived")]                    
        [RemoteIsCollection]
        public String HasAgentDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageCategoryNic")]                    
        [RemoteIsCollection]
        public String[] MessageCategoryNic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EffortlessAPIListenerNic")]                    
        [RemoteIsCollection]
        public String[] EffortlessAPIListenerNic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StrategiesNic")]                    
        [RemoteIsCollection]
        public String[] StrategiesNic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricallyConnectsAndDisconnectsDerived")]                    
        [RemoteIsCollection]
        public String ElectricallyConnectsAndDisconnectsDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasVoltageDerived")]                    
        [RemoteIsCollection]
        public String HasVoltageDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrimaryRoleForTheseGNodesNic")]                    
        [RemoteIsCollection]
        public String[] PrimaryRoleForTheseGNodesNic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CoreLexiconNic")]                    
        [RemoteIsCollection]
        public String[] CoreLexiconNic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricallyConnectsAndDisconnectsValue")]
        public String ElectricallyConnectsAndDisconnectsValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasVoltageValue")]
        public String HasVoltageValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Value")]
        public String Value { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasPowerLevel")]
        public Nullable<Boolean> HasPowerLevel { get; set; }
    

        

        
        
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
