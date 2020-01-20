using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GridRunClass
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GridRunClassId")]
        public String GridRunClassId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GRCGNodesDrop")]
        public String GRCGNodesDrop { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RootNodeGNodeId")]
        public String RootNodeGNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LifeCycleStateName")]
        public String LifeCycleStateName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstancesDrop")]
        public String WorldInstancesDrop { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NetworkModelerGNodeId")]
        public String NetworkModelerGNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GRCGNodes2Drop")]                    
        [RemoteIsCollection]
        public String[] GRCGNodes2Drop { get; set; }
    

        

        
        
        private static string CreateGridRunClassWhere(IEnumerable<GridRunClass> gridRunClasses, String forignKeyFieldName = "GridRunClassId")
        {
            if (!gridRunClasses.Any()) return "1=1";
            else 
            {
                var idList = gridRunClasses.Select(selectGridRunClass => String.Format("'{0}'", selectGridRunClass.GridRunClassId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
