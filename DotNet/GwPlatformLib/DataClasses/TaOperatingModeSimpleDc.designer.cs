using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class TaOperatingModeSimpleDc
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TaOperatingModeSimpleDcId")]
        public String TaOperatingModeSimpleDcId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Definition")]
        public String Definition { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CoreLexiconTerms")]                    
        [RemoteIsCollection]
        public String[] CoreLexiconTerms { get; set; }
    

        

        
        
        private static string CreateTaOperatingModeSimpleDcWhere(IEnumerable<TaOperatingModeSimpleDc> taOperatingModeSimpleDcs, String forignKeyFieldName = "TaOperatingModeSimpleDcId")
        {
            if (!taOperatingModeSimpleDcs.Any()) return "1=1";
            else 
            {
                var idList = taOperatingModeSimpleDcs.Select(selectTaOperatingModeSimpleDc => String.Format("'{0}'", selectTaOperatingModeSimpleDc.TaOperatingModeSimpleDcId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
