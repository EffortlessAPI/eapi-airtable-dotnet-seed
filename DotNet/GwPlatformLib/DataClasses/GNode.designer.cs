using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNode
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeId")]
        public String GNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Alias")]
        public String Alias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EmailAddressDerived")]
        public String EmailAddressDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStatusNameEnum")]
        public String GNodeStatusNameEnum { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentGNodeIdDerived")]
        public String ParentGNodeIdDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DisplayName")]
        public String DisplayName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedPowerWithdrawnVAFromComponent")]
        public Int32 RatedPowerWithdrawnVAFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentId")]                    
        [RemoteIsCollection]
        public String ComponentId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToBusGNodeId")]
        public String ToBusGNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedPowerInjectedVAFromComponent")]
        public Int32 RatedPowerInjectedVAFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ResistanceOhmsFromComponent")]
        public decimal ResistanceOhmsFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SeriesReactanceOhmsFromComponent")]
        public decimal SeriesReactanceOhmsFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NormalizationPowerBaseDefaultVAFromComponent")]
        public Int32 NormalizationPowerBaseDefaultVAFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromBusGNodeId")]
        public String FromBusGNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BusRatedVoltageVRMS")]
        public Int32 BusRatedVoltageVRMS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentRatedVoltageVRMSFromComponent")]
        public Int32 ComponentRatedVoltageVRMSFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CableOrWireRatedPowerFlowVADerived")]
        public Int32 CableOrWireRatedPowerFlowVADerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedAmpacityRMSAmpsFromComponent")]
        public decimal RatedAmpacityRMSAmpsFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasPowerLevelFromGNodeRole")]
        public Boolean HasPowerLevelFromGNodeRole { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricallyConnectsAndDisconnects")]
        public Boolean ElectricallyConnectsAndDisconnects { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasAgentFuzzyLogicValueIdFromComponent")]
        public String HasAgentFuzzyLogicValueIdFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrimaryGNodeRoleId")]                    
        [RemoteIsCollection]
        public String PrimaryGNodeRoleId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrimaryGNodeRole")]
        public String PrimaryGNodeRole { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentAttributeClassFromComponent")]
        public String ComponentAttributeClassFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentTypeFromComponent")]
        public String ComponentTypeFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentCategoryNameFromComponent")]
        public String ComponentCategoryNameFromComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromBusGNodeAliasDerived")]
        public String FromBusGNodeAliasDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToBusGNodeAliasDerived")]
        public String ToBusGNodeAliasDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GraphicIconUrl")]
        public String GraphicIconUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GRCGNodesDrop")]                    
        [RemoteIsCollection]
        public String[] GRCGNodesDrop { get; set; }
    

        

        
        
        private static string CreateGNodeWhere(IEnumerable<GNode> gNodes, String forignKeyFieldName = "GNodeId")
        {
            if (!gNodes.Any()) return "1=1";
            else 
            {
                var idList = gNodes.Select(selectGNode => String.Format("'{0}'", selectGNode.GNodeId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
