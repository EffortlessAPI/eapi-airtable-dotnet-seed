using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;
using GwPlatformDotNet.Lib.Enums;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeRole
    {



        public static List<GNodeRole> AllGNodeRoles { get; private set; }

        public static List<String> AllGNodeRoleValues { get; private set; }

        public static GNodeRole TERMINALASSET { get; private set; }


        public FuzzyLogic HasAgent { 
            get{
                return FuzzyLogic.AllFuzzyLogics.FirstOrDefault(firstFL => this.HasAgentValue == firstFL.Value);
            }
        
        }
        // TODO: create a test that fails if this.HasAgentValue is not a subset of FuzzyLogic.AllFuzzyLogicValues 
        // That allows HasAgentValue to be null ... but if it is populated it must
        // be in the FuzzyLogic.AllFuzzyLogicValues list.

        public FuzzyLogic ElectricallyConnectsAndDisconnects {
            get{
                return FuzzyLogic.AllFuzzyLogics.FirstOrDefault(firstFL => this.ElectricallyConnectsAndDisconnectsValue == firstFL.Value);
            }      
        }


        public FuzzyLogic HasVoltage { 
            get{
                return FuzzyLogic.AllFuzzyLogics.FirstOrDefault(firstFL => this.HasVoltageValue == firstFL.Value);
            }      
        }

        private static void PopulateGNodeRoles() {
            GNodeRole.AllGNodeRoles  = new List<GNodeRole>();
            GNodeRole.AllGNodeRoleValues = new List<String>();
            GNodeRole.TERMINALASSET = new GNodeRole() {
                Value = "TerminalAsset",
                Definition = "A GNode representing physical device capable of injecting or withdrawing electrical power, at the location of its parent.",
                ColorHex = "#43b1cc",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true,
                HasVoltageValue = FuzzyLogic.TRUE.Value
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.TERMINALASSET);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.TERMINALASSET.Value);

        }
    }
}