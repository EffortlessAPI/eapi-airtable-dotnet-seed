using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class MessageFormatRequirements
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageFormatRequirementsId")]
        public String MessageFormatRequirementsId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Example")]
        public String Example { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocolFields")]
        public String[] MessageProtocolFields { get; set; }
    

        

        
        
        private static string CreateMessageFormatRequirementsWhere(IEnumerable<MessageFormatRequirements> messageFormatRequirementss, String forignKeyFieldName = "MessageFormatRequirementsId")
        {
            if (!messageFormatRequirementss.Any()) return "1=1";
            else 
            {
                var idList = messageFormatRequirementss.Select(selectMessageFormatRequirements => String.Format("'{0}'", selectMessageFormatRequirements.MessageFormatRequirementsId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
