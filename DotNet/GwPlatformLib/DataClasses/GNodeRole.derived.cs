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
        private static  void PopulateAllGNRs() {
            GNodeRole.AllGNRs = new List<GNodeRole>();
            GNodeRole.GNRsByName = new Dictionary<GNodeRoleEnum, GNodeRole>();
            var terminalAsset = new GNodeRole() {
                Name = "TerminalAsset",
                Definition = "A GNode representing physical device capable of injecting or withdrawing electrical power, at the location of its parent.",
                ColorHex = "#43b1cc",
                HasAgent = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnects = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltage = FuzzyLogicEnum.TRUE
            };

            GNodeRole.AllGNRs.Add(terminalAsset);
            GNodeRole.GNRsByName[GNodeRoleEnum.TERMINAL_ASSET] = terminalAsset;
            
            var networkModeler = new GNodeRole() {
                Name = "NetworkModeler",
                Definition = "A NetworkModeler is a GNode responsible for global coordination of either simulated or estimated reality in its associated grid. It must be the child of a GridRoot. Its associated grid is all the descendants of its parent which are part of the grid (e.g. InterconnectionComponents, Ctns ), or interact physically with the grid (e.g. AtomicTNodes, MeteringDevices). ",
                ColorHex = "#bae6ff",
                HasAgent = FuzzyLogicEnum.TRUE,
                ElectricallyConnectsAndDisconnects = FuzzyLogicEnum.FALSE,
                HasPowerLevel = false,
                HasVoltage = FuzzyLogicEnum.FALSE
            };

            GNodeRole.AllGNRs.Add(networkModeler);
            GNodeRole.GNRsByName[GNodeRoleEnum.NETWORK_MODELER] = networkModeler;

            var ctn = new GNodeRole() {
                Name = "Ctn",
                Definition = "A ConductorTopologyNode (Ctn)  is a GNode that corresponds to an electrically equivalent copper junction on the electric grid. This means that electrical measurement quantities of current or power withdrawn, voltage, and phase angle are meaningful and well-defined for a  ConductTopologyNode. ",
                ColorHex = "#2f576e",
                HasAgent = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnects = FuzzyLogicEnum.MAYBE,
                HasPowerLevel = true,
                HasVoltage = FuzzyLogicEnum.TRUE
            };

            GNodeRole.AllGNRs.Add(ctn);
            GNodeRole.GNRsByName[GNodeRoleEnum.CTN] = ctn;

        }
    }
}