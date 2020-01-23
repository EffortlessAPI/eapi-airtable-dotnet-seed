using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GlobalAxioms
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GlobalAxiomsId")]
        public String GlobalAxiomsId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FormalStatement")]
        public String FormalStatement { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocolFields")]                    
        [RemoteIsCollection]
        public String[] MessageProtocolFields { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocolFields 2")]                    
        [RemoteIsCollection]
        public String[] MessageProtocolFields2 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocolFields 3")]                    
        [RemoteIsCollection]
        public String[] MessageProtocolFields3 { get; set; }
    

        

        
        
        private static string CreateGlobalAxiomsWhere(IEnumerable<GlobalAxioms> globalAxiomss, String forignKeyFieldName = "GlobalAxiomsId")
        {
            if (!globalAxiomss.Any()) return "1=1";
            else 
            {
                var idList = globalAxiomss.Select(selectGlobalAxioms => String.Format("'{0}'", selectGlobalAxioms.GlobalAxiomsId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
