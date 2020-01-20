using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class MessageProtocol
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocolId")]
        public String MessageProtocolId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Alias")]
        public String Alias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EffortlessAPILexiconId")]
        public String EffortlessAPILexiconId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EffortlessApiLexiconTerm")]
        public String EffortlessApiLexiconTerm { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TemplateExample")]
        public String TemplateExample { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ConsiderReplacingWIth")]
        public String ConsiderReplacingWIth { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SchemaLocationURL")]
        public String SchemaLocationURL { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "in MpSchema")]
        public Boolean inMpSchema { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageCategory")]
        public String MessageCategory { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsImmutableDataClass")]
        public Nullable<Boolean> IsImmutableDataClass { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ImmutableDataClass")]
        public String[] ImmutableDataClass { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocolFieldsIgnore")]
        public String[] MessageProtocolFieldsIgnore { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocolFields2Ignore")]
        public String[] MessageProtocolFields2Ignore { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExampleUrl")]
        public String ExampleUrl { get; set; }
    

        

        
        
        private static string CreateMessageProtocolWhere(IEnumerable<MessageProtocol> messageProtocols, String forignKeyFieldName = "MessageProtocolId")
        {
            if (!messageProtocols.Any()) return "1=1";
            else 
            {
                var idList = messageProtocols.Select(selectMessageProtocol => String.Format("'{0}'", selectMessageProtocol.MessageProtocolId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
