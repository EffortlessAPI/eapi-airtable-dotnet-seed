using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using dc = GwPlatform.Lib.DataClasses;
using System.Collections.Generic;


namespace EffortlessApi.SassyMQ.Lib
{
    public partial class StandardPayload
    {

        private StandardPayload(SMQActorBase actor, string content, bool final)
        {
            this.PayloadId = Guid.NewGuid().ToString();

            this.__Actor = actor;
            if (!ReferenceEquals(this.__Actor, null))
            {
                this.SenderId = actor.SenderId.ToString();
                this.SenderName = actor.SenderName;
                this.AccessToken = actor.AccessToken;
            }
            else
            {
                this.SenderId = Guid.NewGuid().ToString();
                this.SenderName = "Unnamed Actor";
                this.AccessToken = null;
            }

            this.Content = content;
        }

        // 33 odxml properties
                
        public String IrradianceMeasurementId { get; set; }
        public dc.IrradianceMeasurement IrradianceMeasurement { get; set; }
        public List<dc.IrradianceMeasurement> IrradianceMeasurements { get; set; }
                
        public String ComponentTypeId { get; set; }
        public dc.ComponentType ComponentType { get; set; }
        public List<dc.ComponentType> ComponentTypes { get; set; }
                
        public String SupervisorContainerId { get; set; }
        public dc.SupervisorContainer SupervisorContainer { get; set; }
        public List<dc.SupervisorContainer> SupervisorContainers { get; set; }
                
        public String TimeStepId { get; set; }
        public dc.TimeStep TimeStep { get; set; }
        public List<dc.TimeStep> TimeSteps { get; set; }
                
        public String GrcGNodesId { get; set; }
        public dc.GrcGNodes GrcGNodes { get; set; }
        public List<dc.GrcGNodes> GrcGNodess { get; set; }
                
        public String MessageCategoriesId { get; set; }
        public dc.MessageCategories MessageCategories { get; set; }
        public List<dc.MessageCategories> MessageCategoriess { get; set; }
                
        public String ParameterTypeId { get; set; }
        public dc.ParameterType ParameterType { get; set; }
        public List<dc.ParameterType> ParameterTypes { get; set; }
                
        public String GNodeStrategyId { get; set; }
        public dc.GNodeStrategy GNodeStrategy { get; set; }
        public List<dc.GNodeStrategy> GNodeStrategies { get; set; }
                
        public String GlobalAxiomsId { get; set; }
        public dc.GlobalAxioms GlobalAxioms { get; set; }
        public List<dc.GlobalAxioms> GlobalAxiomss { get; set; }
                
        public String ComponentId { get; set; }
        public dc.Component Component { get; set; }
        public List<dc.Component> Components { get; set; }
                
        public String CoreLexiconTermId { get; set; }
        public dc.CoreLexiconTerm CoreLexiconTerm { get; set; }
        public List<dc.CoreLexiconTerm> CoreLexiconTerms { get; set; }
                
        public String TaOperatingModeSimpleDcId { get; set; }
        public dc.TaOperatingModeSimpleDc TaOperatingModeSimpleDc { get; set; }
        public List<dc.TaOperatingModeSimpleDc> TaOperatingModeSimpleDcs { get; set; }
                
        public String MessageFormatRequirementsId { get; set; }
        public dc.MessageFormatRequirements MessageFormatRequirements { get; set; }
        public List<dc.MessageFormatRequirements> MessageFormatRequirementss { get; set; }
                
        public String WorldInstanceEraId { get; set; }
        public dc.WorldInstanceEra WorldInstanceEra { get; set; }
        public List<dc.WorldInstanceEra> WorldInstanceEras { get; set; }
                
        public String PhysicsParadigmId { get; set; }
        public dc.PhysicsParadigm PhysicsParadigm { get; set; }
        public List<dc.PhysicsParadigm> PhysicsParadigms { get; set; }
                
        public String GNodeId { get; set; }
        public dc.GNode GNode { get; set; }
        public List<dc.GNode> GNodes { get; set; }
                
        public String StrategyParamId { get; set; }
        public dc.StrategyParam StrategyParam { get; set; }
        public List<dc.StrategyParam> StrategyParams { get; set; }
                
        public String ElectricalQuantityId { get; set; }
        public dc.ElectricalQuantity ElectricalQuantity { get; set; }
        public List<dc.ElectricalQuantity> ElectricalQuantities { get; set; }
                
        public String ComponentManufacturersId { get; set; }
        public dc.ComponentManufacturers ComponentManufacturers { get; set; }
        public List<dc.ComponentManufacturers> ComponentManufacturerss { get; set; }
                
        public String MessageProtocolId { get; set; }
        public dc.MessageProtocol MessageProtocol { get; set; }
        public List<dc.MessageProtocol> MessageProtocols { get; set; }
                
        public String AbstractEntityClassificationId { get; set; }
        public dc.AbstractEntityClassification AbstractEntityClassification { get; set; }
        public List<dc.AbstractEntityClassification> AbstractEntityClassifications { get; set; }
                
        public String GNodeInstanceId { get; set; }
        public dc.GNodeInstance GNodeInstance { get; set; }
        public List<dc.GNodeInstance> GNodeInstances { get; set; }
                
        public String FuzzyLogicId { get; set; }
        public dc.FuzzyLogic FuzzyLogic { get; set; }
        public List<dc.FuzzyLogic> FuzzyLogics { get; set; }
                
        public String ComponentCategoryId { get; set; }
        public dc.ComponentCategory ComponentCategory { get; set; }
        public List<dc.ComponentCategory> ComponentCategories { get; set; }
                
        public String MessageProtocolFieldsId { get; set; }
        public dc.MessageProtocolFields MessageProtocolFields { get; set; }
        public List<dc.MessageProtocolFields> MessageProtocolFieldss { get; set; }
                
        public String GNodeStatusId { get; set; }
        public dc.GNodeStatus GNodeStatus { get; set; }
        public List<dc.GNodeStatus> GNodeStatuses { get; set; }
                
        public String GridRunClassId { get; set; }
        public dc.GridRunClass GridRunClass { get; set; }
        public List<dc.GridRunClass> GridRunClasses { get; set; }
                
        public String GNodeRoleId { get; set; }
        public dc.GNodeRole GNodeRole { get; set; }
        public List<dc.GNodeRole> GNodeRoles { get; set; }
                
        public String LocalAxiomsId { get; set; }
        public dc.LocalAxioms LocalAxioms { get; set; }
        public List<dc.LocalAxioms> LocalAxiomss { get; set; }
                
        public String GNodeStrategyLifeCycleStatesId { get; set; }
        public dc.GNodeStrategyLifeCycleStates GNodeStrategyLifeCycleStates { get; set; }
        public List<dc.GNodeStrategyLifeCycleStates> GNodeStrategyLifeCycleStatess { get; set; }
                
        public String ComponentAttributeClassId { get; set; }
        public dc.ComponentAttributeClass ComponentAttributeClass { get; set; }
        public List<dc.ComponentAttributeClass> ComponentAttributeClasses { get; set; }
                
        public String TimeStepBaggageId { get; set; }
        public dc.TimeStepBaggage TimeStepBaggage { get; set; }
        public List<dc.TimeStepBaggage> TimeStepBaggages { get; set; }
                
        public String WorldInstanceId { get; set; }
        public dc.WorldInstance WorldInstance { get; set; }
        public List<dc.WorldInstance> WorldInstances { get; set; }
        
        
        public String ToJSON() 
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        private void HandleReplyTo(object sender, PayloadEventArgs e)
        {
            if (e.Payload.IsHandled && e.BasicDeliverEventArgs.BasicProperties.CorrelationId == this.PayloadId)
            {
                this.ReplyPayload = e.Payload;
                this.ReplyBDEA = e.BasicDeliverEventArgs;
                this.ReplyRecieved = true;
            }
        }

        public Task WaitForReply(PayloadHandler payloadHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var waitTask = System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                if (waitTimeout > 0 && !ReferenceEquals(payloadHandler, null))
                {
                    if (ReferenceEquals(this.__Actor, null)) throw new Exception("Can't handle response if payload.__Actor is null");

                    this.__Actor.ReplyTo += this.HandleReplyTo;
                    try
                    {
                        this.TimedOutWaiting = false;
                        var startedAt = DateTime.Now;

                        while (!this.ReplyRecieved && !this.TimedOutWaiting && DateTime.Now < startedAt.AddSeconds(waitTimeout))
                        {
                            Thread.Sleep(100);
                        }
                    }
                    finally
                    {
                        this.__Actor.ReplyTo -= this.HandleReplyTo;
                    }

                    if (!this.ReplyRecieved) this.TimedOutWaiting = true;

                    var errorMessageReceived = !ReferenceEquals(this.ReplyPayload, null) && !String.IsNullOrEmpty(this.ReplyPayload.ErrorMessage);

                    if (this.ReplyRecieved && !errorMessageReceived)
                    {
                        this.ReplyPayload.__Actor = this.__Actor;
                        payloadHandler(this.ReplyPayload, this.ReplyBDEA);
                    }
                    else if (!ReferenceEquals(timeoutHandler, null)) timeoutHandler(this.ReplyPayload, default(BasicDeliverEventArgs));
                }
            });

            return waitTask;
        }

    }
}