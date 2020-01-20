using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class TimeStep
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeStepId")]
        public String TimeStepId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IrlCreatedAtUtc")]
        public DateTime IrlCreatedAtUtc { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AtomicStepsSinceLastTimeStep")]
        public Int32 AtomicStepsSinceLastTimeStep { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceEraId")]
        public String WorldInstanceEraId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PreviousTimeStepId")]
        public String PreviousTimeStepId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceId")]
        public String WorldInstanceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeStepUnixMsDerived")]
        public String TimeStepUnixMsDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TsIndex")]
        public Int32 TsIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EraIndexDerived")]
        public Int32 EraIndexDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BeginsEraDerived")]
        public Boolean BeginsEraDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AtomicIndexDerived")]
        public Int32 AtomicIndexDerived { get; set; }
    

        

        
        
        private static string CreateTimeStepWhere(IEnumerable<TimeStep> timeSteps, String forignKeyFieldName = "TimeStepId")
        {
            if (!timeSteps.Any()) return "1=1";
            else 
            {
                var idList = timeSteps.Select(selectTimeStep => String.Format("'{0}'", selectTimeStep.TimeStepId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
