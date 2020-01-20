using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class ComponentManufacturers
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentManufacturersId")]
        public String ComponentManufacturersId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ColorHex")]
        public String ColorHex { get; set; }
    

        

        
        
        private static string CreateComponentManufacturersWhere(IEnumerable<ComponentManufacturers> componentManufacturerss, String forignKeyFieldName = "ComponentManufacturersId")
        {
            if (!componentManufacturerss.Any()) return "1=1";
            else 
            {
                var idList = componentManufacturerss.Select(selectComponentManufacturers => String.Format("'{0}'", selectComponentManufacturers.ComponentManufacturersId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
