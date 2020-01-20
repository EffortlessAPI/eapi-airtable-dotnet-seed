using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class PhysicsParadigm
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhysicsParadigmId")]
        public String PhysicsParadigmId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Definition")]
        public String Definition { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CoreLexicons")]                    
        [RemoteIsCollection]
        public String[] CoreLexicons { get; set; }
    

        

        
        
        private static string CreatePhysicsParadigmWhere(IEnumerable<PhysicsParadigm> physicsParadigms, String forignKeyFieldName = "PhysicsParadigmId")
        {
            if (!physicsParadigms.Any()) return "1=1";
            else 
            {
                var idList = physicsParadigms.Select(selectPhysicsParadigm => String.Format("'{0}'", selectPhysicsParadigm.PhysicsParadigmId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
