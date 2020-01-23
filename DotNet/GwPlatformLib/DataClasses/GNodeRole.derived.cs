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
        public static GNodeRole GROUND { get; private set; }
    
        public static GNodeRole SUPERVISOR { get; private set; }
    
        public static GNodeRole WIR { get; private set; }
    
        public static GNodeRole CTN { get; private set; }
    
        public static GNodeRole ADMIN { get; private set; }
    
        public static GNodeRole ATOMICTNODE { get; private set; }
    
        public static GNodeRole CONTRACTCOORDINATOR { get; private set; }
    
        public static GNodeRole NEUTRAL { get; private set; }
    
        public static GNodeRole TERMINALASSET { get; private set; }
    
        public static GNodeRole MPR { get; private set; }
    
        public static GNodeRole GNODE { get; private set; }
    
        public static GNodeRole GRIDROOT { get; private set; }
    
        public static GNodeRole AGGREGATEDTNODE { get; private set; }
    
        public static GNodeRole TIMECOORDINATOR { get; private set; }
    
        public static GNodeRole WORLDCOORDINATOR { get; private set; }
    
        public static GNodeRole TERMINALSSNODE { get; private set; }
    
        public static GNodeRole SERVICECOORDINATOR { get; private set; }
    
        public static GNodeRole NETWORKMODELER { get; private set; }
    
        public static GNodeRole INTERCONNECTIONCOMPONENT { get; private set; }
    
        public static GNodeRole COMPONENTREGISTRY { get; private set; }
    
        public static GNodeRole GNR { get; private set; }
    
        public static GNodeRole ACTUATINGDEVICE { get; private set; }
    


        private static  void PopulateGNodeRoles() {
            GNodeRole.AllGNodeRoles  = new List<GNodeRole>();
            GNodeRole.AllGNodeRoleValues = new List<String>();
        
            GNodeRole.GROUND  = new GNodeRole() {
                Value = "Ground",
                Definition = @"This node represents electrical ground in the world. It is the `ToNode` for all TerminalAssets. That is, a TerminalAsset viewed as an ElectricalComponent has power flowing from its FromNode to its ToNode, and the ToNode is ground. ",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.FALSE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.GROUND);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.GROUND.Value);
        
            GNodeRole.SUPERVISOR  = new GNodeRole() {
                Value = "Supervisor",
                Definition = @"This is a GNode role for an actor/agent that is identified with a docker container and that starts up a set of agents, after getting sent initialization data either by the World Instance Registry (if it is a World Coordinator) or from a World Coordinator.  The agents managed by a supervisor will all use code from the same repository - although the same repository can be used for multiple Supervisors.",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.SUPERVISOR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.SUPERVISOR.Value);
        
            GNodeRole.WIR  = new GNodeRole() {
                Value = "Wir",
                Definition = @"WIR stands for the World Instance Registry -a service that maintains information about World Instances, including links to their WorldCoordinators. At the request of Admin, it will gather the initialization data  (GNodes, Components, GNode Strategies,  Grid Run Classes and GRCGNodes) for the world, validate consistency, and then instantiate a new World Instance by creating a container for its WorldCoordinator with this initializing data. It also creates a world-specific broker for the World Instance.    ",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.WIR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.WIR.Value);
        
            GNodeRole.CTN  = new GNodeRole() {
                Value = "Ctn",
                Definition = @"A ConductorTopologyNode (Ctn)  is a GNode that corresponds to an electrically equivalent copper junction on the electric grid. This means that electrical measurement quantities of current or power withdrawn, voltage, and phase angle are meaningful and well-defined for a  ConductTopologyNode. 

'Topology Node' is a term used in the Common Information Model that is consistent with the above. This is why we use the word. However we add the 'Conductor' for copper to help avoid any confusion with TNodes, where the T standards for Transactive.

All TerminalSSNode children of a ConductorTopologyNode have a special relationship w the CopperToplogy Node: specifically, the assumption is that the TerminalSSNodes are within the 'zone of equivalent phasor/voltage.'

The sum of the power (and current) withdrawn for the TerminalSSNode children of a TopologyNode equals the power (and current)  withdrawn for the TopologyNode.  This is true for any model of power - DC, phasor, instantaneous. The tree structure on TopologyNodes 'follows the copper' - that is, in addition to the above requirement, the parent of a TopologyNode is also a TopologyNode, and electrical power can flow between the two. A TopologyNode therefore also has well defined 'flow' electrical measurements associated to it - both current and power - which describe the flow on this edge. The reference direction is taken to be from the parent to the TopologyNode. That is, if there is power flowing from the parent to the TopologyNode it will be a positive measurement.",
                ColorHex = "#2f576e",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.MAYBE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.CTN);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.CTN.Value);
        
            GNodeRole.ADMIN  = new GNodeRole() {
                Value = "Admin",
                Definition = @"GNodeRole of not being a GNode but having admin authority",
                ColorHex = "#ede0f3",
                HasAgentValue = FuzzyLogic.FALSE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.ADMIN);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.ADMIN.Value);
        
            GNodeRole.ATOMICTNODE  = new GNodeRole() {
                Value = "AtomicTNode",
                Definition = @"An AtomicTNode - short for Atomic Transactive Node - is a TerminalSSNode that has the potential to transact in contracts on behalf of its associated ControllableAsset. At present there is only one Role for this - TerminalAsset. However, transformers for example may also be controllable and could be associated with AtomicTNodes.

Note that 'potential' is left as a matter of judgement for the operators of the system. For example, an air compressor with a lot of flexibility in terms of when it operates, but at present no communication capabilities, could have an AtomicTNode associated to it.  

The Atomicity of an AtomicTNode means that there are no AtomicTNode children in the GNode tree below AtomicTNodes.",
                ColorHex = "#7b47d6",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.MAYBE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.ATOMICTNODE);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.ATOMICTNODE.Value);
        
            GNodeRole.CONTRACTCOORDINATOR  = new GNodeRole() {
                Value = "ContractCoordinator",
                Definition = @"Coordinates contracts for energy services. Typically this will be with an AtomicTNode or an AggregatedTNode.",
                ColorHex = "#d0f2d2",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.CONTRACTCOORDINATOR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.CONTRACTCOORDINATOR.Value);
        
            GNodeRole.NEUTRAL  = new GNodeRole() {
                Value = "Neutral",
                Definition = @"We aren't using Neutral yet since we have not moved to a three-phase representation but it'll be here as a node when we do.",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.FALSE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.NEUTRAL);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.NEUTRAL.Value);
        
            GNodeRole.TERMINALASSET  = new GNodeRole() {
                Value = "TerminalAsset",
                Definition = @"A GNode representing physical device capable of injecting or withdrawing electrical power, at the location of its parent. The parent must  be a TerminalSSNode.  Equivalently, the primary role of the parent must be either  AtomicTNode or TerminalSSNode 

It may feel extraneous to have both a TerminalSSNode and a TerminalAsset. In most of the system, the TerminalSSNode will be representing the TerminalAsset - for example, we expect to say 'oh this TerminalSSNode is a 3 kW storage heater.'  The asset allows for us to have different contexts of 'same' and 'different.' In particular if the 3 kW storage heater has to be replaced, and it is replaced by a storage heater of the same make and model, then in this instance the TerminalAsset is replaced (including its immutable serial number, for example) but the TerminalSsNode keeps its name and id.

The TerminalAsset is also an InterconnectionComponent, where the FromNode is either its TerminalSsNode or AtomicTNode (note that when we introduce control devices this may expand) and the ToNode is Ground.",
                ColorHex = "#43b1cc",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.TRUE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.TERMINALASSET);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.TERMINALASSET.Value);
        
            GNodeRole.MPR  = new GNodeRole() {
                Value = "Mpr",
                Definition = @"Short for MessageProtocolRegistry.",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.MPR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.MPR.Value);
        
            GNodeRole.GNODE  = new GNodeRole() {
                Value = "GNode",
                Definition = @"A GNode is a fundamental unit of abstraction in the Gridworks Lexicon and code. GNodes have a tree structure created by left to right reading of the alias, with '.' as the separator. For example, a GNode with alias sw1.ne has a parent with alias of sw1. This tree structure is used both as a method of capturing known topological information about electric grids, and as an organizational principle for coding actions and functions.  

",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.MAYBE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.GNODE);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.GNODE.Value);
        
            GNodeRole.GRIDROOT  = new GNodeRole() {
                Value = "GridRoot",
                Definition = @"A ConductorTopology GNode (GridCoordinator) where its ConductorTopology descendants represent a locally coherent part of the grid. Specifically, if one wants to impose some consistency requirements on a set of GNode strategies (via creating a Grid Run Class), it is assumed that this will impact all instantiated GNodes at or below a particular GridRoot. It must be a ConductorTopologyNode.  It is the only kind of ConductorTopologyNode that does not necessarily have a parent ConductorTopologyNode (although it can).",
                ColorHex = "#70ccb0",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.MAYBE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.GRIDROOT);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.GRIDROOT.Value);
        
            GNodeRole.AGGREGATEDTNODE  = new GNodeRole() {
                Value = "AggregatedTNode",
                Definition = @"An AggregatedTNode is an aggregation of AtomicTNodes that has the potential  of entering into contracts with a contract coordinator on behalf of its AtomicTNodes. We use the term synonymously with Microgrid.",
                ColorHex = "#438a79",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.MAYBE.Value,
                HasVoltageValue = FuzzyLogic.MAYBE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.AGGREGATEDTNODE);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.AGGREGATEDTNODE.Value);
        
            GNodeRole.TIMECOORDINATOR  = new GNodeRole() {
                Value = "TimeCoordinator",
                Definition = @"An entity responsible for issuing TimeSteps. A WorldCoordinator is always a TimeCoordinator. However, there may be additional time coordinators (for example sending higher resolution TimeSteps to a sub-grid of the larger WorldInstance).",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.TIMECOORDINATOR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.TIMECOORDINATOR.Value);
        
            GNodeRole.WORLDCOORDINATOR  = new GNodeRole() {
                Value = "WorldCoordinator",
                Definition = @"<![CDATA[A World Coordinator is associated to a unique world instance, and has ultimate responsibility for the appropriate functioning of its World Instance.  It maintains a user interface allowing Admin to make various changes - for example changing a terminal asset strategy so it runs in scala instead of python, or adding a GridRunClass that adds a whole new set of instantiated GNodes.  This starts with spinning up a container for each of its Supervisors, providing these Supervisors with appropriate creation & change information regarding the World instantiated GNodes, their Components, and their Strategies. Critically the World Coordinator also allocates responsibility for GNodeInstances - its Supervisors create a disjoint cover of all GNodeInstances that HaveAgents. The WorldCoordinator can also be a Supervisor. The World Coordinator is created and initialized by the WorldInstanceRegistry (WIR). Note that the WIR also creates a world-specific message broker (i.e. the only messages running on this broker are between agents within this specific World Instance) for the WorldCoordinator.]]>",
                ColorHex = "#e35d14",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.WORLDCOORDINATOR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.WORLDCOORDINATOR.Value);
        
            GNodeRole.TERMINALSSNODE  = new GNodeRole() {
                Value = "TerminalSsNode",
                Definition = @"A TerminalSSNodes is an infinitesimally long InterconnectionComponent that connects its parent (a ConductorTopologyNode) to its unique child (a Terminal Asset). The FromNode of a TerminalSSNode is its parent ConductorTopologyNode and its ToNode is its TerminalAsset.

NB: We may change 'child' to 'descendant' when we add metering and control devices as GNode parents of Terminal Assets.  

A TerminalSSNodes has Electrical Quantities (current, voltage, etc.). 

",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.TERMINALSSNODE);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.TERMINALSSNODE.Value);
        
            GNodeRole.SERVICECOORDINATOR  = new GNodeRole() {
                Value = "ServiceCoordinator",
                Definition = @"Only one non-development node can be a ServiceCoordinator, and it must be a root node.  The children of the Service Coordinator are services that can be used by multiple world instances simultaneously. The first feature is that it has only one non-development world instance, and that instance is not simulated. The second is that its descendants are limited to a small set of 'Code Service' GNodes - which in particular rules out any GNodes reflecting physical assets on the grid.  The third is that it and its descendants can communicate with other world instances. ",
                ColorHex = "#053982",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.SERVICECOORDINATOR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.SERVICECOORDINATOR.Value);
        
            GNodeRole.NETWORKMODELER  = new GNodeRole() {
                Value = "NetworkModeler",
                Definition = @"A NetworkModeler is a GNode responsible for global coordination of either simulated or estimated reality in its associated grid. It must be the child of a GridRoot. Its associated grid is all the descendants of its parent which are part of the grid (e.g. InterconnectionComponents, Ctns ), or interact physically with the grid (e.g. AtomicTNodes, MeteringDevices). 

In an entirely simulated world, we may choose to define the `real ElectricalQuantities` as  the NetworkModeler estimates of the ElectricalQuantities associated to Ctns (Conductor Topology Nodes), InterconnectionComponents, TerminalAssets at each TimeStep. 
",
                ColorHex = "#bae6ff",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.NETWORKMODELER);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.NETWORKMODELER.Value);
        
            GNodeRole.INTERCONNECTIONCOMPONENT  = new GNodeRole() {
                Value = "InterconnectionComponent",
                Definition = @"An InterconnectionComponent is a component with electrical characteristics that mean it has a non-trivial relationship between voltage and current. In addition, it has a FromNode and ToNode indicating where it connects on each side (and determining the direction of positive current flow).  



The TNode and FromNode for an Atomic
TerminalAssets, although they can be very complex, are among other things InterconnectionComponents where the ToNode is Ground. This is represented by the GNodeRole TerminalAsset having the attribute IsInterconnectionComponent. The TerminalAsset role takes priority over the InterconnectionComponent role. That is, if a GNode has a role of InterconnectionComponent then it's ToNode cannot be Ground. 

As a GNode Role, an InterconnectionComponent must be either a conducting wire (in the air), a cable (in the ground) or a transformer. At present we assume the connection topology is simply between two ConductorTopologyNodes (this may change when we introduce the abstraction of three phases). 

Note that every ConductorTopologyNode also represents an InterconnectionComponent - the cable, wire or transformer between it and its parent node (which must also be a ConductorTopologyNode except in the special case of being a GridRoot  ... which may or may not have parents). 

Combined with the ConductorTopology nodes, the InterconnectionComponent nodes let us complete the conducting graphs. The reference direction is captured by FromNode and ToNode.",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.MAYBE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.INTERCONNECTIONCOMPONENT);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.INTERCONNECTIONCOMPONENT.Value);
        
            GNodeRole.COMPONENTREGISTRY  = new GNodeRole() {
                Value = "ComponentRegistry",
                Definition = @"Components - and particular electrical components - as well as Component Attribute Classes and ComponentTypes",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.COMPONENTREGISTRY);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.COMPONENTREGISTRY.Value);
        
            GNodeRole.GNR  = new GNodeRole() {
                Value = "Gnr",
                Definition = @"Short for GNodeRegistry, Gnr is a  Gridworks Platform Service (i.e., in the tree whose root is a Service Root) which is the authority for the durable data specific to GNodes. In particular it is the authority for mutable data, including the GNode Alias and their inherited tree structure.",
                ColorHex = "",
                HasAgentValue = FuzzyLogic.TRUE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.FALSE.Value,
                HasVoltageValue = FuzzyLogic.FALSE.Value,
                HasPowerLevel = false
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.GNR);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.GNR.Value);
        
            GNodeRole.ACTUATINGDEVICE  = new GNodeRole() {
                Value = "ActuatingDevice",
                Definition = @"We have not yet thought through exactly how we will model and implement SCADA, metering and control. It may be that we want to add GNodes which have the role ActuatingDevice. This is under development.",
                ColorHex = "#0e6f05 ",
                HasAgentValue = FuzzyLogic.MAYBE.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.MAYBE.Value,
                HasVoltageValue = FuzzyLogic.TRUE.Value,
                HasPowerLevel = true
                                    
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.ACTUATINGDEVICE);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.ACTUATINGDEVICE.Value);
        
        }
    }
}
