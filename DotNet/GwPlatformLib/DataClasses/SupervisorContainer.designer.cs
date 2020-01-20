using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class SupervisorContainer
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SupervisorContainerId")]
        public String SupervisorContainerId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SupervisorContainerAlias")]
        public String SupervisorContainerAlias { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GitRepoUrl")]
        public String GitRepoUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GitShortCommit")]
        public String GitShortCommit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FirstDockerNameComponent")]
        public String FirstDockerNameComponent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SecondDockerNameComponentDerived")]
        public String SecondDockerNameComponentDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DockerImageNameDerived")]
        public String DockerImageNameDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GridworksDockerimgIdDerived")]
        public String GridworksDockerimgIdDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DockerImageDate")]
        public DateTime DockerImageDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Location")]
        public String Location { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SupervisorGrcGNodeId")]                    
        [RemoteIsCollection]
        public String SupervisorGrcGNodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceDerivedFromName")]
        public String WorldInstanceDerivedFromName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WorldInstanceName")]
        public String WorldInstanceName { get; set; }
    

        

        
        
        private static string CreateSupervisorContainerWhere(IEnumerable<SupervisorContainer> supervisorContainers, String forignKeyFieldName = "SupervisorContainerId")
        {
            if (!supervisorContainers.Any()) return "1=1";
            else 
            {
                var idList = supervisorContainers.Select(selectSupervisorContainer => String.Format("'{0}'", selectSupervisorContainer.SupervisorContainerId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
