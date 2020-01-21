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
            GNodeRole.GNRsByEnum = new Dictionary<GNodeRoleEnum, GNodeRole>();
            GNodeRole.GNRsByName = new Dictionary<String, GNodeRole>();

        
            var gnrGround = new GNodeRole() {
                Name = "Ground",
                Definition = @"This node represents electrical ground in the world. It is the `ToNode` for all TerminalAssets. That is, a TerminalAsset viewed as an ElectricalComponent has power flowing from its FromNode to its ToNode, and the ToNode is ground. ",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrGround);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.GROUND] = gnrGround;
            GNodeRole.GNRsByName["GROUND"] = gnrGround;
        
            var gnrSupervisor = new GNodeRole() {
                Name = "Supervisor",
                Definition = @"This is a GNode role for an actor/agent that is identified with a docker container and that starts up a set of agents, after getting sent initialization data either by the World Instance Registry (if it is a World Coordinator) or from a World Coordinator.  The agents managed by a supervisor will all use code from the same repository - although the same repository can be used for multiple Supervisors.",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrSupervisor);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.SUPERVISOR] = gnrSupervisor;
            GNodeRole.GNRsByName["SUPERVISOR"] = gnrSupervisor;
        
            var gnrWir = new GNodeRole() {
                Name = "Wir",
                Definition = @"WIR stands for the World Instance Registry -a service that maintains information about World Instances, including links to their WorldCoordinators. At the request of Admin, it will gather the initialization data  (GNodes, Components, GNode Strategies,  Grid Run Classes and GRCGNodes) for the world, validate consistency, and then instantiate a new World Instance by creating a container for its WorldCoordinator with this initializing data. It also creates a world-specific broker for the World Instance.    ",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrWir);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.WIR] = gnrWir;
            GNodeRole.GNRsByName["WIR"] = gnrWir;
        
            var gnrCtn = new GNodeRole() {
                Name = "Ctn",
                Definition = @"A ConductorTopologyNode (Ctn)  is a GNode that corresponds to an electrically equivalent copper junction on the electric grid. This means that electrical measurement quantities of current or power withdrawn, voltage, and phase angle are meaningful and well-defined for a  ConductTopologyNode. 

'Topology Node' is a term used in the Common Information Model that is consistent with the above. This is why we use the word. However we add the 'Conductor' for copper to help avoid any confusion with TNodes, where the T standards for Transactive.

All TerminalSSNode children of a ConductorTopologyNode have a special relationship w the CopperToplogy Node: specifically, the assumption is that the TerminalSSNodes are within the 'zone of equivalent phasor/voltage.'

The sum of the power (and current) withdrawn for the TerminalSSNode children of a TopologyNode equals the power (and current)  withdrawn for the TopologyNode.  This is true for any model of power - DC, phasor, instantaneous. The tree structure on TopologyNodes 'follows the copper' - that is, in addition to the above requirement, the parent of a TopologyNode is also a TopologyNode, and electrical power can flow between the two. A TopologyNode therefore also has well defined 'flow' electrical measurements associated to it - both current and power - which describe the flow on this edge. The reference direction is taken to be from the parent to the TopologyNode. That is, if there is power flowing from the parent to the TopologyNode it will be a positive measurement.",
                ColorHex = "#2f576e",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrCtn);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.CTN] = gnrCtn;
            GNodeRole.GNRsByName["CTN"] = gnrCtn;
        
            var gnrAtomicTNode = new GNodeRole() {
                Name = "AtomicTNode",
                Definition = @"An AtomicTNode - short for Atomic Transactive Node - is a TerminalSSNode that has the potential to transact in contracts on behalf of its associated ControllableAsset. At present there is only one Role for this - TerminalAsset. However, transformers for example may also be controllable and could be associated with AtomicTNodes.

Note that 'potential' is left as a matter of judgement for the operators of the system. For example, an air compressor with a lot of flexibility in terms of when it operates, but at present no communication capabilities, could have an AtomicTNode associated to it.  

The Atomicity of an AtomicTNode means that there are no AtomicTNode children in the GNode tree below AtomicTNodes.",
                ColorHex = "#7b47d6",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrAtomicTNode);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.ATOMICTNODE] = gnrAtomicTNode;
            GNodeRole.GNRsByName["ATOMICTNODE"] = gnrAtomicTNode;
        
            var gnrContractCoordinator = new GNodeRole() {
                Name = "ContractCoordinator",
                Definition = @"Coordinates contracts for energy services. Typically this will be with an AtomicTNode or an AggregatedTNode.",
                ColorHex = "#d0f2d2",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrContractCoordinator);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.CONTRACTCOORDINATOR] = gnrContractCoordinator;
            GNodeRole.GNRsByName["CONTRACTCOORDINATOR"] = gnrContractCoordinator;
        
            var gnrNeutral = new GNodeRole() {
                Name = "Neutral",
                Definition = @"We aren't using Neutral yet since we have not moved to a three-phase representation but it'll be here as a node when we do.",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrNeutral);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.NEUTRAL] = gnrNeutral;
            GNodeRole.GNRsByName["NEUTRAL"] = gnrNeutral;
        
            var gnrTerminalAsset = new GNodeRole() {
                Name = "TerminalAsset",
                Definition = @"A GNode representing physical device capable of injecting or withdrawing electrical power, at the location of its parent. The parent must  be a TerminalSSNode.  Equivalently, the primary role of the parent must be either  AtomicTNode or TerminalSSNode 

It may feel extraneous to have both a TerminalSSNode and a TerminalAsset. In most of the system, the TerminalSSNode will be representing the TerminalAsset - for example, we expect to say 'oh this TerminalSSNode is a 3 kW storage heater.'  The asset allows for us to have different contexts of 'same' and 'different.' In particular if the 3 kW storage heater has to be replaced, and it is replaced by a storage heater of the same make and model, then in this instance the TerminalAsset is replaced (including its immutable serial number, for example) but the TerminalSsNode keeps its name and id.

The TerminalAsset is also an InterconnectionComponent, where the FromNode is either its TerminalSsNode or AtomicTNode (note that when we introduce control devices this may expand) and the ToNode is Ground.",
                ColorHex = "#43b1cc",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrTerminalAsset);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.TERMINALASSET] = gnrTerminalAsset;
            GNodeRole.GNRsByName["TERMINALASSET"] = gnrTerminalAsset;
        
            var gnrMpr = new GNodeRole() {
                Name = "Mpr",
                Definition = @"Short for MessageProtocolRegistry.",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrMpr);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.MPR] = gnrMpr;
            GNodeRole.GNRsByName["MPR"] = gnrMpr;
        
            var gnrGNode = new GNodeRole() {
                Name = "GNode",
                Definition = @"A GNode is a fundamental unit of abstraction in the Gridworks Lexicon and code. GNodes have a tree structure created by left to right reading of the alias, with '.' as the separator. For example, a GNode with alias sw1.ne has a parent with alias of sw1. This tree structure is used both as a method of capturing known topological information about electric grids, and as an organizational principle for coding actions and functions.  

",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrGNode);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.GNODE] = gnrGNode;
            GNodeRole.GNRsByName["GNODE"] = gnrGNode;
        
            var gnrGridRoot = new GNodeRole() {
                Name = "GridRoot",
                Definition = @"A ConductorTopology GNode (GridCoordinator) where its ConductorTopology descendants represent a locally coherent part of the grid. Specifically, if one wants to impose some consistency requirements on a set of GNode strategies (via creating a Grid Run Class), it is assumed that this will impact all instantiated GNodes at or below a particular GridRoot. It must be a ConductorTopologyNode.  It is the only kind of ConductorTopologyNode that does not necessarily have a parent ConductorTopologyNode (although it can).",
                ColorHex = "#70ccb0",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrGridRoot);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.GRIDROOT] = gnrGridRoot;
            GNodeRole.GNRsByName["GRIDROOT"] = gnrGridRoot;
        
            var gnrAggregatedTNode = new GNodeRole() {
                Name = "AggregatedTNode",
                Definition = @"An AggregatedTNode is an aggregation of AtomicTNodes that has the potential  of entering into contracts with a contract coordinator on behalf of its AtomicTNodes. We use the term synonymously with Microgrid.",
                ColorHex = "#438a79",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrAggregatedTNode);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.AGGREGATEDTNODE] = gnrAggregatedTNode;
            GNodeRole.GNRsByName["AGGREGATEDTNODE"] = gnrAggregatedTNode;
        
            var gnrTimeCoordinator = new GNodeRole() {
                Name = "TimeCoordinator",
                Definition = @"An entity responsible for issuing TimeSteps. A WorldCoordinator is always a TimeCoordinator. However, there may be additional time coordinators (for example sending higher resolution TimeSteps to a sub-grid of the larger WorldInstance).",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrTimeCoordinator);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.TIMECOORDINATOR] = gnrTimeCoordinator;
            GNodeRole.GNRsByName["TIMECOORDINATOR"] = gnrTimeCoordinator;
        
            var gnrWorldCoordinator = new GNodeRole() {
                Name = "WorldCoordinator",
                Definition = @"<![CDATA[A World Coordinator is associated to a unique world instance, and has ultimate responsibility for the appropriate functioning of its World Instance.  It maintains a user interface allowing Admin to make various changes - for example changing a terminal asset strategy so it runs in scala instead of python, or adding a GridRunClass that adds a whole new set of instantiated GNodes.  This starts with spinning up a container for each of its Supervisors, providing these Supervisors with appropriate creation & change information regarding the World instantiated GNodes, their Components, and their Strategies. Critically the World Coordinator also allocates responsibility for GNodeInstances - its Supervisors create a disjoint cover of all GNodeInstances that HaveAgents. The WorldCoordinator can also be a Supervisor. The World Coordinator is created and initialized by the WorldInstanceRegistry (WIR). Note that the WIR also creates a world-specific message broker (i.e. the only messages running on this broker are between agents within this specific World Instance) for the WorldCoordinator.]]>",
                ColorHex = "#e35d14",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrWorldCoordinator);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.WORLDCOORDINATOR] = gnrWorldCoordinator;
            GNodeRole.GNRsByName["WORLDCOORDINATOR"] = gnrWorldCoordinator;
        
            var gnrTerminalSsNode = new GNodeRole() {
                Name = "TerminalSsNode",
                Definition = @"A TerminalSSNodes is an infinitesimally long InterconnectionComponent that connects its parent (a ConductorTopologyNode) to its unique child (a Terminal Asset). The FromNode of a TerminalSSNode is its parent ConductorTopologyNode and its ToNode is its TerminalAsset.

NB: We may change 'child' to 'descendant' when we add metering and control devices as GNode parents of Terminal Assets.  

A TerminalSSNodes has Electrical Quantities (current, voltage, etc.). 

",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrTerminalSsNode);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.TERMINALSSNODE] = gnrTerminalSsNode;
            GNodeRole.GNRsByName["TERMINALSSNODE"] = gnrTerminalSsNode;
        
            var gnrServiceCoordinator = new GNodeRole() {
                Name = "ServiceCoordinator",
                Definition = @"Only one non-development node can be a ServiceCoordinator, and it must be a root node.  The children of the Service Coordinator are services that can be used by multiple world instances simultaneously. The first feature is that it has only one non-development world instance, and that instance is not simulated. The second is that its descendants are limited to a small set of 'Code Service' GNodes - which in particular rules out any GNodes reflecting physical assets on the grid.  The third is that it and its descendants can communicate with other world instances. ",
                ColorHex = "#053982",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrServiceCoordinator);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.SERVICECOORDINATOR] = gnrServiceCoordinator;
            GNodeRole.GNRsByName["SERVICECOORDINATOR"] = gnrServiceCoordinator;
        
            var gnrNetworkModeler = new GNodeRole() {
                Name = "NetworkModeler",
                Definition = @"A NetworkModeler is a GNode responsible for global coordination of either simulated or estimated reality in its associated grid. It must be the child of a GridRoot. Its associated grid is all the descendants of its parent which are part of the grid (e.g. InterconnectionComponents, Ctns ), or interact physically with the grid (e.g. AtomicTNodes, MeteringDevices). 

In an entirely simulated world, we may choose to define the `real ElectricalQuantities` as  the NetworkModeler estimates of the ElectricalQuantities associated to Ctns (Conductor Topology Nodes), InterconnectionComponents, TerminalAssets at each TimeStep. 
",
                ColorHex = "#bae6ff",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrNetworkModeler);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.NETWORKMODELER] = gnrNetworkModeler;
            GNodeRole.GNRsByName["NETWORKMODELER"] = gnrNetworkModeler;
        
            var gnrInterconnectionComponent = new GNodeRole() {
                Name = "InterconnectionComponent",
                Definition = @"An InterconnectionComponent is a component with electrical characteristics that mean it has a non-trivial relationship between voltage and current. In addition, it has a FromNode and ToNode indicating where it connects on each side (and determining the direction of positive current flow).  



The TNode and FromNode for an Atomic
TerminalAssets, although they can be very complex, are among other things InterconnectionComponents where the ToNode is Ground. This is represented by the GNodeRole TerminalAsset having the attribute IsInterconnectionComponent. The TerminalAsset role takes priority over the InterconnectionComponent role. That is, if a GNode has a role of InterconnectionComponent then it's ToNode cannot be Ground. 

As a GNode Role, an InterconnectionComponent must be either a conducting wire (in the air), a cable (in the ground) or a transformer. At present we assume the connection topology is simply between two ConductorTopologyNodes (this may change when we introduce the abstraction of three phases). 

Note that every ConductorTopologyNode also represents an InterconnectionComponent - the cable, wire or transformer between it and its parent node (which must also be a ConductorTopologyNode except in the special case of being a GridRoot  ... which may or may not have parents). 

Combined with the ConductorTopology nodes, the InterconnectionComponent nodes let us complete the conducting graphs. The reference direction is captured by FromNode and ToNode.",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrInterconnectionComponent);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.INTERCONNECTIONCOMPONENT] = gnrInterconnectionComponent;
            GNodeRole.GNRsByName["INTERCONNECTIONCOMPONENT"] = gnrInterconnectionComponent;
        
            var gnrComponentRegistry = new GNodeRole() {
                Name = "ComponentRegistry",
                Definition = @"Components - and particular electrical components - as well as Component Attribute Classes and ComponentTypes",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrComponentRegistry);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.COMPONENTREGISTRY] = gnrComponentRegistry;
            GNodeRole.GNRsByName["COMPONENTREGISTRY"] = gnrComponentRegistry;
        
            var gnrGnr = new GNodeRole() {
                Name = "Gnr",
                Definition = @"Short for GNodeRegistry, Gnr is a  Gridworks Platform Service (i.e., in the tree whose root is a Service Root) which is the authority for the durable data specific to GNodes. In particular it is the authority for mutable data, including the GNode Alias and their inherited tree structure.",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrGnr);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.GNR] = gnrGnr;
            GNodeRole.GNRsByName["GNR"] = gnrGnr;
        
            var gnrActuatingDevice = new GNodeRole() {
                Name = "ActuatingDevice",
                Definition = @"We have not yet thought through exactly how we will model and implement SCADA, metering and control. It may be that we want to add GNodes which have the role ActuatingDevice. This is under development.",
                ColorHex = "",
                HasAgentEnum = FuzzyLogicEnum.MAYBE,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnrActuatingDevice);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.ACTUATINGDEVICE] = gnrActuatingDevice;
            GNodeRole.GNRsByName["ACTUATINGDEVICE"] = gnrActuatingDevice;
        
        }
    }
}
