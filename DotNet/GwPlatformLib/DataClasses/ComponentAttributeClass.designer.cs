using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class ComponentAttributeClass
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentAttributeClassId")]
        public String ComponentAttributeClassId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameDerived")]
        public String NameDerived { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentManufacturerName")]
        public String ComponentManufacturerName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentTypeName")]
        public String ComponentTypeName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ModelNumber")]
        public String ModelNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StartupSeconds")]
        public Int32 StartupSeconds { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ShutdownSeconds")]
        public Int32 ShutdownSeconds { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MaxWChangeIn100MilliS")]
        public Int32 MaxWChangeIn100MilliS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedPowerWithdrawnVA")]
        public Int32 RatedPowerWithdrawnVA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "GNodes")]
        public String GNodes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "VolatilityPercent")]
        public Int32 VolatilityPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeatCapacityWhperDegC")]
        public decimal HeatCapacityWhperDegC { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ClassExampleImage")]
        public AirtableAttachment[] ClassExampleImage { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedAmpacityRMSAmps")]
        public decimal RatedAmpacityRMSAmps { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedPowerInjectedVA")]
        public Int32 RatedPowerInjectedVA { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ColdStartSeconds")]
        public decimal ColdStartSeconds { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MaxRampUpFractionPerSecond")]
        public decimal MaxRampUpFractionPerSecond { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NormalizedEquivInertia")]
        public decimal NormalizedEquivInertia { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExcitationSystemPowerFactorLimit")]
        public decimal ExcitationSystemPowerFactorLimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedVoltageVRMS")]
        public Int32 RatedVoltageVRMS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ResistanceOhms")]
        public decimal ResistanceOhms { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SeriesReactanceOhms")]
        public decimal SeriesReactanceOhms { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ShuntReactanceOhms")]
        public decimal ShuntReactanceOhms { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ShuntReactanceDefaultOhms")]
        public decimal ShuntReactanceDefaultOhms { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MaxRampDownFractionPerSecond")]
        public decimal MaxRampDownFractionPerSecond { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PVTotalAreaM2")]
        public decimal PVTotalAreaM2 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RatedMaxInverterEfficiency")]
        public decimal RatedMaxInverterEfficiency { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentsDrop")]                    
        [RemoteIsCollection]
        public String[] ComponentsDrop { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ComponentTypeFromComponentTypeName")]
        public String ComponentTypeFromComponentTypeName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Field 29")]
        public String Field29 { get; set; }
    

        

        
        
        private static string CreateComponentAttributeClassWhere(IEnumerable<ComponentAttributeClass> componentAttributeClasses, String forignKeyFieldName = "ComponentAttributeClassId")
        {
            if (!componentAttributeClasses.Any()) return "1=1";
            else 
            {
                var idList = componentAttributeClasses.Select(selectComponentAttributeClass => String.Format("'{0}'", selectComponentAttributeClass.ComponentAttributeClassId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
