using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class FuzzyLogic
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FuzzyLogicId")]
        public String FuzzyLogicId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Key")]
        public String Key { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Value")]
        public String Value { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRoles")]
        public String[] GNodeRoles { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRoles 2")]
        public String[] GNodeRoles2 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRoles 3")]
        public String[] GNodeRoles3 { get; set; }
    

        

        
        
        private static string CreateFuzzyLogicWhere(IEnumerable<FuzzyLogic> fuzzyLogics, String forignKeyFieldName = "FuzzyLogicId")
        {
            if (!fuzzyLogics.Any()) return "1=1";
            else 
            {
                var idList = fuzzyLogics.Select(selectFuzzyLogic => String.Format("'{0}'", selectFuzzyLogic.FuzzyLogicId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
