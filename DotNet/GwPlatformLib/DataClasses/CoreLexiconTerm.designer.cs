using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class CoreLexiconTerm
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CoreLexiconTermId")]
        public String CoreLexiconTermId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Shorthand")]
        public String Shorthand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SourceTable")]
        public String SourceTable { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Defn")]
        public String Defn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRoleDefn")]
        public String GNodeRoleDefn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromGNodeRoles")]                    
        [RemoteIsCollection]
        public String FromGNodeRoles { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricalQuantityDefn")]
        public String ElectricalQuantityDefn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromElectricalQuantities")]                    
        [RemoteIsCollection]
        public String FromElectricalQuantities { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AdHocDefinition")]
        public String AdHocDefinition { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromPhysicsParadigms")]                    
        [RemoteIsCollection]
        public String FromPhysicsParadigms { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhysicsParadigmDefn")]
        public String PhysicsParadigmDefn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromGNodeStatuses")]                    
        [RemoteIsCollection]
        public String FromGNodeStatuses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStatusDefn")]
        public String GNodeStatusDefn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeRoleName")]
        public String GNodeRoleName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ElectricalQuantityName")]
        public String ElectricalQuantityName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PhysicsParadigmName")]
        public String PhysicsParadigmName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodeStatusName")]
        public String GNodeStatusName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AdhocName")]
        public String AdhocName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromDieselOperatingModeSimpleDc")]                    
        [RemoteIsCollection]
        public String FromDieselOperatingModeSimpleDc { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DieselOperatingModeSimpleDcDefn")]
        public String DieselOperatingModeSimpleDcDefn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DieselOperatingModeSimpleDcName")]
        public String DieselOperatingModeSimpleDcName { get; set; }
    

        

        
        
        private static string CreateCoreLexiconTermWhere(IEnumerable<CoreLexiconTerm> coreLexiconTerms, String forignKeyFieldName = "CoreLexiconTermId")
        {
            if (!coreLexiconTerms.Any()) return "1=1";
            else 
            {
                var idList = coreLexiconTerms.Select(selectCoreLexiconTerm => String.Format("'{0}'", selectCoreLexiconTerm.CoreLexiconTermId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
