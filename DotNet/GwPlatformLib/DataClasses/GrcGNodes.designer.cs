using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GrcGNodes
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GrcGNodesId")]
        public String GrcGNodesId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GrcGNodeAliasFromGNodeandStrategy")]
        public String GrcGNodeAliasFromGNodeandStrategy { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GridRunClassId")]                    
        [RemoteIsCollection]
        public String GridRunClassId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeId")]                    
        [RemoteIsCollection]
        public String GNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStrategyAlias")]
        public String GNodeStrategyAlias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStatusFromGNode")]
        public String GNodeStatusFromGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricallyConnectsAndDisconnectsConsistentWGNode")]
        public Nullable<Boolean> ElectricallyConnectsAndDisconnectsConsistentWGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NetworkModelerIdFromGridRunClass")]
        public String NetworkModelerIdFromGridRunClass { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasAgent")]
        public Nullable<Boolean> HasAgent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeAliasFromGNode")]
        public String GNodeAliasFromGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SupervisorContainersDrop")]                    
        [RemoteIsCollection]
        public String[] SupervisorContainersDrop { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeInstancesDrop")]                    
        [RemoteIsCollection]
        public String[] GNodeInstancesDrop { get; set; }
    

        

        
        
        private static string CreateGrcGNodesWhere(IEnumerable<GrcGNodes> grcGNodess, String forignKeyFieldName = "GrcGNodesId")
        {
            if (!grcGNodess.Any()) return "1=1";
            else 
            {
                var idList = grcGNodess.Select(selectGrcGNodes => String.Format("'{0}'", selectGrcGNodes.GrcGNodesId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
