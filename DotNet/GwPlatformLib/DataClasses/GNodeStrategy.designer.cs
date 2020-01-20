using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeStrategy
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStrategyId")]
        public String GNodeStrategyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Alias")]
        public String Alias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRole")]                    
        [RemoteIsCollection]
        public String GNodeRole { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DisplayName")]
        public String DisplayName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRoleName")]
        public String GNodeRoleName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Short Description")]
        public String ShortDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ColorHEX")]
        public String ColorHEX { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LifeCycleStateDerived")]
        public String LifeCycleStateDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ReplacedByStrategyId")]
        public String ReplacedByStrategyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ScalaSupervisorLifeCycleStateName")]
        public String ScalaSupervisorLifeCycleStateName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Oct2pySupervisorLifeCycleStateName")]
        public String Oct2pySupervisorLifeCycleStateName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DotnetSupervisorLifeCycleStateName")]
        public String DotnetSupervisorLifeCycleStateName { get; set; }
    

        

        
        
        private static string CreateGNodeStrategyWhere(IEnumerable<GNodeStrategy> gNodeStrategies, String forignKeyFieldName = "GNodeStrategyId")
        {
            if (!gNodeStrategies.Any()) return "1=1";
            else 
            {
                var idList = gNodeStrategies.Select(selectGNodeStrategy => String.Format("'{0}'", selectGNodeStrategy.GNodeStrategyId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
