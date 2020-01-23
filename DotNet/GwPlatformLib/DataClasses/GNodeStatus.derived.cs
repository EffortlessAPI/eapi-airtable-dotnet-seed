using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;
using GwPlatformDotNet.Lib.Enums;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeStatus
    {
        public static List<GNodeStatus> AllStatuses { get; private set; }

        public static List<String> AllStatusNames { get; private set; }

        public static GNodeStatus SIMTEMPDEACTIVATED { get; private set; }

        public static GNodeStatus ACTIVE { get; private set; }

        public static GNodeStatus PENDING { get; private set; }

        public static GNodeStatus PERMANENTLYDEACTIVATED { get; private set; }
        private static  void PopulateAllGNodeStatuses() {
            GNodeStatus.AllStatuses = new List<GNodeStatus>();
            GNodeStatus.AllStatusNames = new List<String>();

            GNodeStatus.SIMTEMPDEACTIVATED = new GNodeStatus() {
                Name = "SimTempDeactivated",
                Definition = "Can only be applied to TNodes that are in a simulated universe."
            };

            GNodeStatus.AllStatuses.Add(GNodeStatus.SIMTEMPDEACTIVATED);
            GNodeStatus.AllStatusNames.Add(GNodeStatus.SIMTEMPDEACTIVATED.Name);
            
            GNodeStatus.ACTIVE = new GNodeStatus() {
                Name = "Active",
                Definition = "Required for a Node to generate or receive any Events. If a GNode is active its parent is active as well."
            };

            GNodeStatus.AllStatuses.Add(GNodeStatus.ACTIVE);
            GNodeStatus.AllStatusNames.Add(GNodeStatus.ACTIVE.Name);

            GNodeStatus.ACTIVE = new GNodeStatus() {
                Name = "Pending",
                Definition = "Under design, not yet available in production."
            };

            GNodeStatus.AllStatuses.Add(GNodeStatus.PENDING);
            GNodeStatus.AllStatusNames.Add(GNodeStatus.PENDING.Name);


            GNodeStatus.PERMANENTLYDEACTIVATED = new GNodeStatus() {
                Name = "PermanentlyDeactivated",
                Definition = "A designation which retires the GNode (i.e. its unique identifer) from having any GNodeEvents at any point in the future."

            };

            GNodeStatus.AllStatuses.Add(GNodeStatus.PERMANENTLYDEACTIVATED);
            GNodeStatus.AllStatusNames.Add(GNodeStatus.PERMANENTLYDEACTIVATED.Name);


        }
    }
}