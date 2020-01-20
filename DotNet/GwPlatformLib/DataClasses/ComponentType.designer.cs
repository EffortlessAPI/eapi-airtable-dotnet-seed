using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class ComponentType
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentTypeId")]
        public String ComponentTypeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpectedStartupSeconds")]
        public decimal ExpectedStartupSeconds { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExpectedShutdownSeconds")]
        public decimal ExpectedShutdownSeconds { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentCategoryName")]
        public String ComponentCategoryName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsResistiveLoad")]
        public Boolean IsResistiveLoad { get; set; }
    

        

        
        
        private static string CreateComponentTypeWhere(IEnumerable<ComponentType> componentTypes, String forignKeyFieldName = "ComponentTypeId")
        {
            if (!componentTypes.Any()) return "1=1";
            else 
            {
                var idList = componentTypes.Select(selectComponentType => String.Format("'{0}'", selectComponentType.ComponentTypeId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
