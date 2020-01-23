using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeStatus
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStatusId")]
        public String GNodeStatusId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Definition")]
        public String Definition { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNode")]
        public String GNode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GRCGNodes")]
        public String GRCGNodes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CoreLexiconTerms")]                    
        [RemoteIsCollection]
        public String[] CoreLexiconTerms { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodes")]                    
        [RemoteIsCollection]
        public String[] GNodes { get; set; }
    

        

        
        
        private static string CreateGNodeStatusWhere(IEnumerable<GNodeStatus> gNodeStatuses, String forignKeyFieldName = "GNodeStatusId")
        {
            if (!gNodeStatuses.Any()) return "1=1";
            else 
            {
                var idList = gNodeStatuses.Select(selectGNodeStatus => String.Format("'{0}'", selectGNodeStatus.GNodeStatusId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
