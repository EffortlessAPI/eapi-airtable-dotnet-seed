using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeInstance
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeInstanceId")]
        public String GNodeInstanceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DisplayName")]
        public String DisplayName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EmailAddress")]
        public String EmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeFromGrcGNode")]
        public String GNodeFromGrcGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StartTimeUnixS")]
        public Int32 StartTimeUnixS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GrcGNodeId")]                    
        [RemoteIsCollection]
        public String GrcGNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SupervisorContainerAlias")]
        public String SupervisorContainerAlias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasPowerLevelFromGRCGNode")]
        public Boolean HasPowerLevelFromGRCGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LatestPowerDisplayNumber")]
        public String LatestPowerDisplayNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActivePowerW")]
        public decimal ActivePowerW { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LatestPowerDisplayUnits")]
        public String LatestPowerDisplayUnits { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsElectricallyConnected")]
        public Boolean IsElectricallyConnected { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NetworkModelerFromGrcGNode")]
        public String NetworkModelerFromGrcGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStrategyFromGrcGNode")]
        public String GNodeStrategyFromGrcGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StrategyLifeCycleStateIdFromGNodeStrategy")]
        public String StrategyLifeCycleStateIdFromGNodeStrategy { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EndTimeUnixS")]
        public Int32 EndTimeUnixS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricallyConnectsAndDisconnectsFromGNode")]
        public Boolean ElectricallyConnectsAndDisconnectsFromGNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActiveVoltageV")]
        public Int32 ActiveVoltageV { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SupervisorContainerFromAlias")]
        public String SupervisorContainerFromAlias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SupervisorGNodeFromSupervisorContainerAlias")]
        public String SupervisorGNodeFromSupervisorContainerAlias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceNameFromSupervisorContainer")]
        public String WorldInstanceNameFromSupervisorContainer { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeInstanceState")]
        public String GNodeInstanceState { get; set; }
    

        

        
        
        private static string CreateGNodeInstanceWhere(IEnumerable<GNodeInstance> gNodeInstances, String forignKeyFieldName = "GNodeInstanceId")
        {
            if (!gNodeInstances.Any()) return "1=1";
            else 
            {
                var idList = gNodeInstances.Select(selectGNodeInstance => String.Format("'{0}'", selectGNodeInstance.GNodeInstanceId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
