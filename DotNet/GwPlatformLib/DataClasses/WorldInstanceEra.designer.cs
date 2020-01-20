using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class WorldInstanceEra
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceEraId")]
        public String WorldInstanceEraId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AtomicStepsPerTimeStep")]
        public Int32 AtomicStepsPerTimeStep { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatorGNodeId")]
        public String CreatorGNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceId")]
        public String WorldInstanceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeSteps")]
        public String TimeSteps { get; set; }
    

        

        
        
        private static string CreateWorldInstanceEraWhere(IEnumerable<WorldInstanceEra> worldInstanceEras, String forignKeyFieldName = "WorldInstanceEraId")
        {
            if (!worldInstanceEras.Any()) return "1=1";
            else 
            {
                var idList = worldInstanceEras.Select(selectWorldInstanceEra => String.Format("'{0}'", selectWorldInstanceEra.WorldInstanceEraId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
