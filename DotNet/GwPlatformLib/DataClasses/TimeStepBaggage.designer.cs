using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class TimeStepBaggage
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeStepBaggageId")]
        public String TimeStepBaggageId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeStepId")]
        public String TimeStepId { get; set; }
    

        

        
        
        private static string CreateTimeStepBaggageWhere(IEnumerable<TimeStepBaggage> timeStepBaggages, String forignKeyFieldName = "TimeStepBaggageId")
        {
            if (!timeStepBaggages.Any()) return "1=1";
            else 
            {
                var idList = timeStepBaggages.Select(selectTimeStepBaggage => String.Format("'{0}'", selectTimeStepBaggage.TimeStepBaggageId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
