using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeStrategyLifeCycleStates
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStrategyLifeCycleStatesId")]
        public String GNodeStrategyLifeCycleStatesId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Field 2")]
        public String Field2 { get; set; }
    

        

        
        
        private static string CreateGNodeStrategyLifeCycleStatesWhere(IEnumerable<GNodeStrategyLifeCycleStates> gNodeStrategyLifeCycleStatess, String forignKeyFieldName = "GNodeStrategyLifeCycleStatesId")
        {
            if (!gNodeStrategyLifeCycleStatess.Any()) return "1=1";
            else 
            {
                var idList = gNodeStrategyLifeCycleStatess.Select(selectGNodeStrategyLifeCycleStates => String.Format("'{0}'", selectGNodeStrategyLifeCycleStates.GNodeStrategyLifeCycleStatesId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
