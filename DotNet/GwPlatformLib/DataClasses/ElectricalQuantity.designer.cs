using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class ElectricalQuantity
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricalQuantityId")]
        public String ElectricalQuantityId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Definition")]
        public String Definition { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CoreLexicon")]                    
        [RemoteIsCollection]
        public String[] CoreLexicon { get; set; }
    

        

        
        
        private static string CreateElectricalQuantityWhere(IEnumerable<ElectricalQuantity> electricalQuantities, String forignKeyFieldName = "ElectricalQuantityId")
        {
            if (!electricalQuantities.Any()) return "1=1";
            else 
            {
                var idList = electricalQuantities.Select(selectElectricalQuantity => String.Format("'{0}'", selectElectricalQuantity.ElectricalQuantityId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
