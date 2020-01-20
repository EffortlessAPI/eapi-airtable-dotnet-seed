using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class IrradianceMeasurement
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IrradianceMeasurementId")]
        public String IrradianceMeasurementId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeStampUnixMS")]
        public Int32 TimeStampUnixMS { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IrradianceHorizontalWPerM2")]
        public Int32 IrradianceHorizontalWPerM2 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Location")]
        public String Location { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LocationShorthand")]
        public String LocationShorthand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HumanReadableTimeUTC")]
        public DateTime HumanReadableTimeUTC { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IrradianceTiltedWPerM2")]
        public Int32 IrradianceTiltedWPerM2 { get; set; }
    

        

        
        
        private static string CreateIrradianceMeasurementWhere(IEnumerable<IrradianceMeasurement> irradianceMeasurements, String forignKeyFieldName = "IrradianceMeasurementId")
        {
            if (!irradianceMeasurements.Any()) return "1=1";
            else 
            {
                var idList = irradianceMeasurements.Select(selectIrradianceMeasurement => String.Format("'{0}'", selectIrradianceMeasurement.IrradianceMeasurementId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
