using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class AbstractEntityClassification
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AbstractEntityClassificationId")]
        public String AbstractEntityClassificationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EntityAlias")]
        public String EntityAlias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EntityType")]
        public String EntityType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasMessageProtocol")]
        public Nullable<Boolean> HasMessageProtocol { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MessageProtocol")]
        public String MessageProtocol { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InstancesNameConceptsInCode")]
        public Nullable<Boolean> InstancesNameConceptsInCode { get; set; }
    

        

        
        
        private static string CreateAbstractEntityClassificationWhere(IEnumerable<AbstractEntityClassification> abstractEntityClassifications, String forignKeyFieldName = "AbstractEntityClassificationId")
        {
            if (!abstractEntityClassifications.Any()) return "1=1";
            else 
            {
                var idList = abstractEntityClassifications.Select(selectAbstractEntityClassification => String.Format("'{0}'", selectAbstractEntityClassification.AbstractEntityClassificationId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
