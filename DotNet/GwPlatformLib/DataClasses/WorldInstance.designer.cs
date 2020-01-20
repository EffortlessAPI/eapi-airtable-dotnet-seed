using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class WorldInstance
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceId")]
        public String WorldInstanceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameDerivedFromAliasAndIdx")]
        public String NameDerivedFromAliasAndIdx { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StartTimeUTCCalculated")]
        public DateTime StartTimeUTCCalculated { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IRLCreatedAtUTC")]
        public DateTime IRLCreatedAtUTC { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldRootGNodeAlias")]
        public String WorldRootGNodeAlias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Idx")]
        public String Idx { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StartingGridRunClassId")]
        public String StartingGridRunClassId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StartTimeUnixS")]
        public Int32 StartTimeUnixS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IRLExpectedTimeStepDeltaMicroSeconds")]
        public Int32 IRLExpectedTimeStepDeltaMicroSeconds { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeIsThrottled")]
        public Boolean TimeIsThrottled { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsSimulated")]
        public Boolean IsSimulated { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AtomicFrequencyHz")]
        public Int32 AtomicFrequencyHz { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AtomicStepsPerDefaultStep")]
        public Int32 AtomicStepsPerDefaultStep { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RunningNow")]
        public Boolean RunningNow { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RequestTimeUnixS")]
        public Int32 RequestTimeUnixS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EndTimeUnixS")]
        public Int32 EndTimeUnixS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldCoordinatorSupervisorContainerName")]
        public String WorldCoordinatorSupervisorContainerName { get; set; }
    

        

        
        
        private static string CreateWorldInstanceWhere(IEnumerable<WorldInstance> worldInstances, String forignKeyFieldName = "WorldInstanceId")
        {
            if (!worldInstances.Any()) return "1=1";
            else 
            {
                var idList = worldInstances.Select(selectWorldInstance => String.Format("'{0}'", selectWorldInstance.WorldInstanceId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
