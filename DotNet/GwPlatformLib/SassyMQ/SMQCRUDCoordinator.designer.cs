using System;
using System.Linq;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System.Threading.Tasks;

namespace EffortlessApi.SassyMQ.Lib
{
    public partial class SMQCRUDCoordinator : SMQActorBase
    {

        public SMQCRUDCoordinator(String amqpConnectionString)
            : base(amqpConnectionString, "crudcoordinator")
        {
        }

        protected override void CheckRouting(StandardPayload payload, BasicDeliverEventArgs  bdea)
        {
            var originalAccessToken = payload.AccessToken;
            try
            {
                switch (bdea.RoutingKey)
                {
                    
                    case "crudcoordinator.general.guest.requesttoken":
                        this.OnGuestRequestTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.guest.validatetemporaryaccesstoken":
                        this.OnGuestValidateTemporaryAccessTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.guest.whoami":
                        this.OnGuestWhoAmIReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.guest.whoareyou":
                        this.OnGuestWhoAreYouReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.guest.storetempfile":
                        this.OnGuestStoreTempFileReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.crudcoordinator.resetrabbitsassymqconfiguration":
                        this.OnCRUDCoordinatorResetRabbitSassyMQConfigurationReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.crudcoordinator.resetjwtsecretkey":
                        this.OnCRUDCoordinatorResetJWTSecretKeyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addirradiancemeasurement":
                        this.OnAdminAddIrradianceMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getirradiancemeasurements":
                        this.OnAdminGetIrradianceMeasurementsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updateirradiancemeasurement":
                        this.OnAdminUpdateIrradianceMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deleteirradiancemeasurement":
                        this.OnAdminDeleteIrradianceMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addcomponenttype":
                        this.OnAdminAddComponentTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getcomponenttypes":
                        this.OnAdminGetComponentTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatecomponenttype":
                        this.OnAdminUpdateComponentTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletecomponenttype":
                        this.OnAdminDeleteComponentTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addsupervisorcontainer":
                        this.OnAdminAddSupervisorContainerReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getsupervisorcontainers":
                        this.OnAdminGetSupervisorContainersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatesupervisorcontainer":
                        this.OnAdminUpdateSupervisorContainerReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletesupervisorcontainer":
                        this.OnAdminDeleteSupervisorContainerReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addtimestep":
                        this.OnAdminAddTimeStepReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.gettimesteps":
                        this.OnAdminGetTimeStepsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatetimestep":
                        this.OnAdminUpdateTimeStepReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletetimestep":
                        this.OnAdminDeleteTimeStepReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgrcgnodes":
                        this.OnAdminAddGrcGNodesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgrcgnodess":
                        this.OnAdminGetGrcGNodessReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategrcgnodes":
                        this.OnAdminUpdateGrcGNodesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegrcgnodes":
                        this.OnAdminDeleteGrcGNodesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addmessagecategories":
                        this.OnAdminAddMessageCategoriesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getmessagecategoriess":
                        this.OnAdminGetMessageCategoriessReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatemessagecategories":
                        this.OnAdminUpdateMessageCategoriesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletemessagecategories":
                        this.OnAdminDeleteMessageCategoriesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addparametertype":
                        this.OnAdminAddParameterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getparametertypes":
                        this.OnAdminGetParameterTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updateparametertype":
                        this.OnAdminUpdateParameterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deleteparametertype":
                        this.OnAdminDeleteParameterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgnodestrategy":
                        this.OnAdminAddGNodeStrategyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgnodestrategies":
                        this.OnAdminGetGNodeStrategiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategnodestrategy":
                        this.OnAdminUpdateGNodeStrategyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegnodestrategy":
                        this.OnAdminDeleteGNodeStrategyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addglobalaxioms":
                        this.OnAdminAddGlobalAxiomsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getglobalaxiomss":
                        this.OnAdminGetGlobalAxiomssReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updateglobalaxioms":
                        this.OnAdminUpdateGlobalAxiomsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deleteglobalaxioms":
                        this.OnAdminDeleteGlobalAxiomsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addcomponent":
                        this.OnAdminAddComponentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getcomponents":
                        this.OnAdminGetComponentsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatecomponent":
                        this.OnAdminUpdateComponentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletecomponent":
                        this.OnAdminDeleteComponentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addcorelexiconterm":
                        this.OnAdminAddCoreLexiconTermReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getcorelexiconterms":
                        this.OnAdminGetCoreLexiconTermsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatecorelexiconterm":
                        this.OnAdminUpdateCoreLexiconTermReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletecorelexiconterm":
                        this.OnAdminDeleteCoreLexiconTermReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addtaoperatingmodesimpledc":
                        this.OnAdminAddTaOperatingModeSimpleDcReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.gettaoperatingmodesimpledcs":
                        this.OnAdminGetTaOperatingModeSimpleDcsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatetaoperatingmodesimpledc":
                        this.OnAdminUpdateTaOperatingModeSimpleDcReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletetaoperatingmodesimpledc":
                        this.OnAdminDeleteTaOperatingModeSimpleDcReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addmessageformatrequirements":
                        this.OnAdminAddMessageFormatRequirementsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getmessageformatrequirementss":
                        this.OnAdminGetMessageFormatRequirementssReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatemessageformatrequirements":
                        this.OnAdminUpdateMessageFormatRequirementsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletemessageformatrequirements":
                        this.OnAdminDeleteMessageFormatRequirementsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addworldinstanceera":
                        this.OnAdminAddWorldInstanceEraReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getworldinstanceeras":
                        this.OnAdminGetWorldInstanceErasReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updateworldinstanceera":
                        this.OnAdminUpdateWorldInstanceEraReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deleteworldinstanceera":
                        this.OnAdminDeleteWorldInstanceEraReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addphysicsparadigm":
                        this.OnAdminAddPhysicsParadigmReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getphysicsparadigms":
                        this.OnAdminGetPhysicsParadigmsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatephysicsparadigm":
                        this.OnAdminUpdatePhysicsParadigmReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletephysicsparadigm":
                        this.OnAdminDeletePhysicsParadigmReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgnode":
                        this.OnAdminAddGNodeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgnodes":
                        this.OnAdminGetGNodesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategnode":
                        this.OnAdminUpdateGNodeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegnode":
                        this.OnAdminDeleteGNodeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addstrategyparam":
                        this.OnAdminAddStrategyParamReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getstrategyparams":
                        this.OnAdminGetStrategyParamsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatestrategyparam":
                        this.OnAdminUpdateStrategyParamReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletestrategyparam":
                        this.OnAdminDeleteStrategyParamReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addelectricalquantity":
                        this.OnAdminAddElectricalQuantityReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getelectricalquantities":
                        this.OnAdminGetElectricalQuantitiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updateelectricalquantity":
                        this.OnAdminUpdateElectricalQuantityReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deleteelectricalquantity":
                        this.OnAdminDeleteElectricalQuantityReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addcomponentmanufacturers":
                        this.OnAdminAddComponentManufacturersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getcomponentmanufacturerss":
                        this.OnAdminGetComponentManufacturerssReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatecomponentmanufacturers":
                        this.OnAdminUpdateComponentManufacturersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletecomponentmanufacturers":
                        this.OnAdminDeleteComponentManufacturersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addmessageprotocol":
                        this.OnAdminAddMessageProtocolReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getmessageprotocols":
                        this.OnAdminGetMessageProtocolsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatemessageprotocol":
                        this.OnAdminUpdateMessageProtocolReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletemessageprotocol":
                        this.OnAdminDeleteMessageProtocolReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addabstractentityclassification":
                        this.OnAdminAddAbstractEntityClassificationReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getabstractentityclassifications":
                        this.OnAdminGetAbstractEntityClassificationsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updateabstractentityclassification":
                        this.OnAdminUpdateAbstractEntityClassificationReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deleteabstractentityclassification":
                        this.OnAdminDeleteAbstractEntityClassificationReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgnodeinstance":
                        this.OnAdminAddGNodeInstanceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgnodeinstances":
                        this.OnAdminGetGNodeInstancesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategnodeinstance":
                        this.OnAdminUpdateGNodeInstanceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegnodeinstance":
                        this.OnAdminDeleteGNodeInstanceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addfuzzylogic":
                        this.OnAdminAddFuzzyLogicReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getfuzzylogics":
                        this.OnAdminGetFuzzyLogicsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatefuzzylogic":
                        this.OnAdminUpdateFuzzyLogicReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletefuzzylogic":
                        this.OnAdminDeleteFuzzyLogicReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addcomponentcategory":
                        this.OnAdminAddComponentCategoryReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getcomponentcategories":
                        this.OnAdminGetComponentCategoriesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatecomponentcategory":
                        this.OnAdminUpdateComponentCategoryReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletecomponentcategory":
                        this.OnAdminDeleteComponentCategoryReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addmessageprotocolfields":
                        this.OnAdminAddMessageProtocolFieldsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getmessageprotocolfieldss":
                        this.OnAdminGetMessageProtocolFieldssReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatemessageprotocolfields":
                        this.OnAdminUpdateMessageProtocolFieldsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletemessageprotocolfields":
                        this.OnAdminDeleteMessageProtocolFieldsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgnodestatus":
                        this.OnAdminAddGNodeStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgnodestatuses":
                        this.OnAdminGetGNodeStatusesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategnodestatus":
                        this.OnAdminUpdateGNodeStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegnodestatus":
                        this.OnAdminDeleteGNodeStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgridrunclass":
                        this.OnAdminAddGridRunClassReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgridrunclasses":
                        this.OnAdminGetGridRunClassesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategridrunclass":
                        this.OnAdminUpdateGridRunClassReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegridrunclass":
                        this.OnAdminDeleteGridRunClassReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgnoderole":
                        this.OnAdminAddGNodeRoleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgnoderoles":
                        this.OnAdminGetGNodeRolesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategnoderole":
                        this.OnAdminUpdateGNodeRoleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegnoderole":
                        this.OnAdminDeleteGNodeRoleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addlocalaxioms":
                        this.OnAdminAddLocalAxiomsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getlocalaxiomss":
                        this.OnAdminGetLocalAxiomssReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatelocalaxioms":
                        this.OnAdminUpdateLocalAxiomsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletelocalaxioms":
                        this.OnAdminDeleteLocalAxiomsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addgnodestrategylifecyclestates":
                        this.OnAdminAddGNodeStrategyLifeCycleStatesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getgnodestrategylifecyclestatess":
                        this.OnAdminGetGNodeStrategyLifeCycleStatessReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updategnodestrategylifecyclestates":
                        this.OnAdminUpdateGNodeStrategyLifeCycleStatesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletegnodestrategylifecyclestates":
                        this.OnAdminDeleteGNodeStrategyLifeCycleStatesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addcomponentattributeclass":
                        this.OnAdminAddComponentAttributeClassReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getcomponentattributeclasses":
                        this.OnAdminGetComponentAttributeClassesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatecomponentattributeclass":
                        this.OnAdminUpdateComponentAttributeClassReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletecomponentattributeclass":
                        this.OnAdminDeleteComponentAttributeClassReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addtimestepbaggage":
                        this.OnAdminAddTimeStepBaggageReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.gettimestepbaggages":
                        this.OnAdminGetTimeStepBaggagesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updatetimestepbaggage":
                        this.OnAdminUpdateTimeStepBaggageReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deletetimestepbaggage":
                        this.OnAdminDeleteTimeStepBaggageReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.addworldinstance":
                        this.OnAdminAddWorldInstanceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.getworldinstances":
                        this.OnAdminGetWorldInstancesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.updateworldinstance":
                        this.OnAdminUpdateWorldInstanceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.admin.deleteworldinstance":
                        this.OnAdminDeleteWorldInstanceReceived(payload, bdea);
                        break;
                    
                }

            }
            catch (Exception ex)
            {
                payload.ErrorMessage = ex.Message;
            }
            if (payload.AccessToken == originalAccessToken) payload.AccessToken = null;            
            this.Reply(payload, bdea.BasicProperties);
        }

        
        /// <summary>
        /// Responds to: RequestToken from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestRequestTokenReceived;
        protected virtual void OnGuestRequestTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestRequestTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestRequestTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: ValidateTemporaryAccessToken from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestValidateTemporaryAccessTokenReceived;
        protected virtual void OnGuestValidateTemporaryAccessTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestValidateTemporaryAccessTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestValidateTemporaryAccessTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: WhoAmI from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestWhoAmIReceived;
        protected virtual void OnGuestWhoAmIReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestWhoAmIReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestWhoAmIReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: WhoAreYou from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestWhoAreYouReceived;
        protected virtual void OnGuestWhoAreYouReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestWhoAreYouReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestWhoAreYouReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: StoreTempFile from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestStoreTempFileReceived;
        protected virtual void OnGuestStoreTempFileReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestStoreTempFileReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestStoreTempFileReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: ResetRabbitSassyMQConfiguration from CRUDCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> CRUDCoordinatorResetRabbitSassyMQConfigurationReceived;
        protected virtual void OnCRUDCoordinatorResetRabbitSassyMQConfigurationReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.CRUDCoordinatorResetRabbitSassyMQConfigurationReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.CRUDCoordinatorResetRabbitSassyMQConfigurationReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: ResetJWTSecretKey from CRUDCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> CRUDCoordinatorResetJWTSecretKeyReceived;
        protected virtual void OnCRUDCoordinatorResetJWTSecretKeyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.CRUDCoordinatorResetJWTSecretKeyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.CRUDCoordinatorResetJWTSecretKeyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddIrradianceMeasurement from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddIrradianceMeasurementReceived;
        protected virtual void OnAdminAddIrradianceMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddIrradianceMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddIrradianceMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetIrradianceMeasurements from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetIrradianceMeasurementsReceived;
        protected virtual void OnAdminGetIrradianceMeasurementsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetIrradianceMeasurementsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetIrradianceMeasurementsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateIrradianceMeasurement from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateIrradianceMeasurementReceived;
        protected virtual void OnAdminUpdateIrradianceMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateIrradianceMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateIrradianceMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteIrradianceMeasurement from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteIrradianceMeasurementReceived;
        protected virtual void OnAdminDeleteIrradianceMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteIrradianceMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteIrradianceMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddComponentType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddComponentTypeReceived;
        protected virtual void OnAdminAddComponentTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddComponentTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddComponentTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetComponentTypes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetComponentTypesReceived;
        protected virtual void OnAdminGetComponentTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetComponentTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetComponentTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateComponentType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateComponentTypeReceived;
        protected virtual void OnAdminUpdateComponentTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateComponentTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateComponentTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteComponentType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteComponentTypeReceived;
        protected virtual void OnAdminDeleteComponentTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteComponentTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteComponentTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSupervisorContainer from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddSupervisorContainerReceived;
        protected virtual void OnAdminAddSupervisorContainerReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddSupervisorContainerReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddSupervisorContainerReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSupervisorContainers from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetSupervisorContainersReceived;
        protected virtual void OnAdminGetSupervisorContainersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetSupervisorContainersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetSupervisorContainersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSupervisorContainer from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateSupervisorContainerReceived;
        protected virtual void OnAdminUpdateSupervisorContainerReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateSupervisorContainerReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateSupervisorContainerReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSupervisorContainer from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteSupervisorContainerReceived;
        protected virtual void OnAdminDeleteSupervisorContainerReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteSupervisorContainerReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteSupervisorContainerReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddTimeStep from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddTimeStepReceived;
        protected virtual void OnAdminAddTimeStepReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddTimeStepReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddTimeStepReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetTimeSteps from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetTimeStepsReceived;
        protected virtual void OnAdminGetTimeStepsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetTimeStepsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetTimeStepsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateTimeStep from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateTimeStepReceived;
        protected virtual void OnAdminUpdateTimeStepReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateTimeStepReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateTimeStepReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteTimeStep from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteTimeStepReceived;
        protected virtual void OnAdminDeleteTimeStepReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteTimeStepReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteTimeStepReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGrcGNodes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGrcGNodesReceived;
        protected virtual void OnAdminAddGrcGNodesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGrcGNodesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGrcGNodesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGrcGNodess from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGrcGNodessReceived;
        protected virtual void OnAdminGetGrcGNodessReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGrcGNodessReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGrcGNodessReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGrcGNodes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGrcGNodesReceived;
        protected virtual void OnAdminUpdateGrcGNodesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGrcGNodesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGrcGNodesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGrcGNodes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGrcGNodesReceived;
        protected virtual void OnAdminDeleteGrcGNodesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGrcGNodesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGrcGNodesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMessageCategories from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMessageCategoriesReceived;
        protected virtual void OnAdminAddMessageCategoriesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMessageCategoriesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMessageCategoriesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMessageCategoriess from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMessageCategoriessReceived;
        protected virtual void OnAdminGetMessageCategoriessReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMessageCategoriessReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMessageCategoriessReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMessageCategories from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMessageCategoriesReceived;
        protected virtual void OnAdminUpdateMessageCategoriesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMessageCategoriesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMessageCategoriesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMessageCategories from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMessageCategoriesReceived;
        protected virtual void OnAdminDeleteMessageCategoriesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMessageCategoriesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMessageCategoriesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddParameterType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddParameterTypeReceived;
        protected virtual void OnAdminAddParameterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddParameterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddParameterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetParameterTypes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetParameterTypesReceived;
        protected virtual void OnAdminGetParameterTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetParameterTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetParameterTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateParameterType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateParameterTypeReceived;
        protected virtual void OnAdminUpdateParameterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateParameterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateParameterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteParameterType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteParameterTypeReceived;
        protected virtual void OnAdminDeleteParameterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteParameterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteParameterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGNodeStrategy from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGNodeStrategyReceived;
        protected virtual void OnAdminAddGNodeStrategyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGNodeStrategyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGNodeStrategyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGNodeStrategies from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGNodeStrategiesReceived;
        protected virtual void OnAdminGetGNodeStrategiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGNodeStrategiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGNodeStrategiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGNodeStrategy from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGNodeStrategyReceived;
        protected virtual void OnAdminUpdateGNodeStrategyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGNodeStrategyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGNodeStrategyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGNodeStrategy from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGNodeStrategyReceived;
        protected virtual void OnAdminDeleteGNodeStrategyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGNodeStrategyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGNodeStrategyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGlobalAxioms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGlobalAxiomsReceived;
        protected virtual void OnAdminAddGlobalAxiomsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGlobalAxiomsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGlobalAxiomsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGlobalAxiomss from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGlobalAxiomssReceived;
        protected virtual void OnAdminGetGlobalAxiomssReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGlobalAxiomssReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGlobalAxiomssReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGlobalAxioms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGlobalAxiomsReceived;
        protected virtual void OnAdminUpdateGlobalAxiomsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGlobalAxiomsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGlobalAxiomsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGlobalAxioms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGlobalAxiomsReceived;
        protected virtual void OnAdminDeleteGlobalAxiomsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGlobalAxiomsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGlobalAxiomsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddComponent from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddComponentReceived;
        protected virtual void OnAdminAddComponentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddComponentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddComponentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetComponents from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetComponentsReceived;
        protected virtual void OnAdminGetComponentsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetComponentsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetComponentsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateComponent from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateComponentReceived;
        protected virtual void OnAdminUpdateComponentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateComponentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateComponentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteComponent from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteComponentReceived;
        protected virtual void OnAdminDeleteComponentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteComponentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteComponentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddCoreLexiconTerm from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddCoreLexiconTermReceived;
        protected virtual void OnAdminAddCoreLexiconTermReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddCoreLexiconTermReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddCoreLexiconTermReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetCoreLexiconTerms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetCoreLexiconTermsReceived;
        protected virtual void OnAdminGetCoreLexiconTermsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetCoreLexiconTermsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetCoreLexiconTermsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateCoreLexiconTerm from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateCoreLexiconTermReceived;
        protected virtual void OnAdminUpdateCoreLexiconTermReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateCoreLexiconTermReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateCoreLexiconTermReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteCoreLexiconTerm from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteCoreLexiconTermReceived;
        protected virtual void OnAdminDeleteCoreLexiconTermReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteCoreLexiconTermReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteCoreLexiconTermReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddTaOperatingModeSimpleDc from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddTaOperatingModeSimpleDcReceived;
        protected virtual void OnAdminAddTaOperatingModeSimpleDcReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddTaOperatingModeSimpleDcReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddTaOperatingModeSimpleDcReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetTaOperatingModeSimpleDcs from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetTaOperatingModeSimpleDcsReceived;
        protected virtual void OnAdminGetTaOperatingModeSimpleDcsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetTaOperatingModeSimpleDcsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetTaOperatingModeSimpleDcsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateTaOperatingModeSimpleDc from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateTaOperatingModeSimpleDcReceived;
        protected virtual void OnAdminUpdateTaOperatingModeSimpleDcReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateTaOperatingModeSimpleDcReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateTaOperatingModeSimpleDcReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteTaOperatingModeSimpleDc from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteTaOperatingModeSimpleDcReceived;
        protected virtual void OnAdminDeleteTaOperatingModeSimpleDcReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteTaOperatingModeSimpleDcReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteTaOperatingModeSimpleDcReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMessageFormatRequirements from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMessageFormatRequirementsReceived;
        protected virtual void OnAdminAddMessageFormatRequirementsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMessageFormatRequirementsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMessageFormatRequirementsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMessageFormatRequirementss from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMessageFormatRequirementssReceived;
        protected virtual void OnAdminGetMessageFormatRequirementssReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMessageFormatRequirementssReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMessageFormatRequirementssReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMessageFormatRequirements from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMessageFormatRequirementsReceived;
        protected virtual void OnAdminUpdateMessageFormatRequirementsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMessageFormatRequirementsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMessageFormatRequirementsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMessageFormatRequirements from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMessageFormatRequirementsReceived;
        protected virtual void OnAdminDeleteMessageFormatRequirementsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMessageFormatRequirementsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMessageFormatRequirementsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddWorldInstanceEra from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddWorldInstanceEraReceived;
        protected virtual void OnAdminAddWorldInstanceEraReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddWorldInstanceEraReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddWorldInstanceEraReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetWorldInstanceEras from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetWorldInstanceErasReceived;
        protected virtual void OnAdminGetWorldInstanceErasReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetWorldInstanceErasReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetWorldInstanceErasReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateWorldInstanceEra from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateWorldInstanceEraReceived;
        protected virtual void OnAdminUpdateWorldInstanceEraReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateWorldInstanceEraReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateWorldInstanceEraReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteWorldInstanceEra from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteWorldInstanceEraReceived;
        protected virtual void OnAdminDeleteWorldInstanceEraReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteWorldInstanceEraReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteWorldInstanceEraReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddPhysicsParadigm from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddPhysicsParadigmReceived;
        protected virtual void OnAdminAddPhysicsParadigmReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddPhysicsParadigmReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddPhysicsParadigmReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetPhysicsParadigms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetPhysicsParadigmsReceived;
        protected virtual void OnAdminGetPhysicsParadigmsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetPhysicsParadigmsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetPhysicsParadigmsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdatePhysicsParadigm from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdatePhysicsParadigmReceived;
        protected virtual void OnAdminUpdatePhysicsParadigmReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdatePhysicsParadigmReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdatePhysicsParadigmReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeletePhysicsParadigm from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeletePhysicsParadigmReceived;
        protected virtual void OnAdminDeletePhysicsParadigmReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeletePhysicsParadigmReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeletePhysicsParadigmReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGNode from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGNodeReceived;
        protected virtual void OnAdminAddGNodeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGNodeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGNodeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGNodes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGNodesReceived;
        protected virtual void OnAdminGetGNodesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGNodesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGNodesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGNode from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGNodeReceived;
        protected virtual void OnAdminUpdateGNodeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGNodeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGNodeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGNode from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGNodeReceived;
        protected virtual void OnAdminDeleteGNodeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGNodeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGNodeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddStrategyParam from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddStrategyParamReceived;
        protected virtual void OnAdminAddStrategyParamReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddStrategyParamReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddStrategyParamReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetStrategyParams from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetStrategyParamsReceived;
        protected virtual void OnAdminGetStrategyParamsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetStrategyParamsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetStrategyParamsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateStrategyParam from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateStrategyParamReceived;
        protected virtual void OnAdminUpdateStrategyParamReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateStrategyParamReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateStrategyParamReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteStrategyParam from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteStrategyParamReceived;
        protected virtual void OnAdminDeleteStrategyParamReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteStrategyParamReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteStrategyParamReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddElectricalQuantity from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddElectricalQuantityReceived;
        protected virtual void OnAdminAddElectricalQuantityReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddElectricalQuantityReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddElectricalQuantityReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetElectricalQuantities from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetElectricalQuantitiesReceived;
        protected virtual void OnAdminGetElectricalQuantitiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetElectricalQuantitiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetElectricalQuantitiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateElectricalQuantity from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateElectricalQuantityReceived;
        protected virtual void OnAdminUpdateElectricalQuantityReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateElectricalQuantityReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateElectricalQuantityReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteElectricalQuantity from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteElectricalQuantityReceived;
        protected virtual void OnAdminDeleteElectricalQuantityReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteElectricalQuantityReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteElectricalQuantityReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddComponentManufacturers from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddComponentManufacturersReceived;
        protected virtual void OnAdminAddComponentManufacturersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddComponentManufacturersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddComponentManufacturersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetComponentManufacturerss from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetComponentManufacturerssReceived;
        protected virtual void OnAdminGetComponentManufacturerssReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetComponentManufacturerssReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetComponentManufacturerssReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateComponentManufacturers from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateComponentManufacturersReceived;
        protected virtual void OnAdminUpdateComponentManufacturersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateComponentManufacturersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateComponentManufacturersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteComponentManufacturers from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteComponentManufacturersReceived;
        protected virtual void OnAdminDeleteComponentManufacturersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteComponentManufacturersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteComponentManufacturersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMessageProtocol from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMessageProtocolReceived;
        protected virtual void OnAdminAddMessageProtocolReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMessageProtocolReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMessageProtocolReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMessageProtocols from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMessageProtocolsReceived;
        protected virtual void OnAdminGetMessageProtocolsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMessageProtocolsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMessageProtocolsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMessageProtocol from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMessageProtocolReceived;
        protected virtual void OnAdminUpdateMessageProtocolReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMessageProtocolReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMessageProtocolReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMessageProtocol from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMessageProtocolReceived;
        protected virtual void OnAdminDeleteMessageProtocolReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMessageProtocolReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMessageProtocolReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddAbstractEntityClassification from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddAbstractEntityClassificationReceived;
        protected virtual void OnAdminAddAbstractEntityClassificationReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddAbstractEntityClassificationReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddAbstractEntityClassificationReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetAbstractEntityClassifications from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetAbstractEntityClassificationsReceived;
        protected virtual void OnAdminGetAbstractEntityClassificationsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetAbstractEntityClassificationsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetAbstractEntityClassificationsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateAbstractEntityClassification from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateAbstractEntityClassificationReceived;
        protected virtual void OnAdminUpdateAbstractEntityClassificationReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateAbstractEntityClassificationReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateAbstractEntityClassificationReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteAbstractEntityClassification from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteAbstractEntityClassificationReceived;
        protected virtual void OnAdminDeleteAbstractEntityClassificationReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteAbstractEntityClassificationReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteAbstractEntityClassificationReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGNodeInstance from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGNodeInstanceReceived;
        protected virtual void OnAdminAddGNodeInstanceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGNodeInstanceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGNodeInstanceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGNodeInstances from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGNodeInstancesReceived;
        protected virtual void OnAdminGetGNodeInstancesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGNodeInstancesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGNodeInstancesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGNodeInstance from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGNodeInstanceReceived;
        protected virtual void OnAdminUpdateGNodeInstanceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGNodeInstanceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGNodeInstanceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGNodeInstance from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGNodeInstanceReceived;
        protected virtual void OnAdminDeleteGNodeInstanceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGNodeInstanceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGNodeInstanceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddFuzzyLogic from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddFuzzyLogicReceived;
        protected virtual void OnAdminAddFuzzyLogicReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddFuzzyLogicReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddFuzzyLogicReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetFuzzyLogics from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetFuzzyLogicsReceived;
        protected virtual void OnAdminGetFuzzyLogicsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetFuzzyLogicsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetFuzzyLogicsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateFuzzyLogic from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateFuzzyLogicReceived;
        protected virtual void OnAdminUpdateFuzzyLogicReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateFuzzyLogicReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateFuzzyLogicReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteFuzzyLogic from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteFuzzyLogicReceived;
        protected virtual void OnAdminDeleteFuzzyLogicReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteFuzzyLogicReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteFuzzyLogicReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddComponentCategory from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddComponentCategoryReceived;
        protected virtual void OnAdminAddComponentCategoryReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddComponentCategoryReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddComponentCategoryReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetComponentCategories from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetComponentCategoriesReceived;
        protected virtual void OnAdminGetComponentCategoriesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetComponentCategoriesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetComponentCategoriesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateComponentCategory from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateComponentCategoryReceived;
        protected virtual void OnAdminUpdateComponentCategoryReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateComponentCategoryReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateComponentCategoryReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteComponentCategory from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteComponentCategoryReceived;
        protected virtual void OnAdminDeleteComponentCategoryReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteComponentCategoryReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteComponentCategoryReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMessageProtocolFields from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMessageProtocolFieldsReceived;
        protected virtual void OnAdminAddMessageProtocolFieldsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMessageProtocolFieldsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMessageProtocolFieldsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMessageProtocolFieldss from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMessageProtocolFieldssReceived;
        protected virtual void OnAdminGetMessageProtocolFieldssReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMessageProtocolFieldssReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMessageProtocolFieldssReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMessageProtocolFields from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMessageProtocolFieldsReceived;
        protected virtual void OnAdminUpdateMessageProtocolFieldsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMessageProtocolFieldsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMessageProtocolFieldsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMessageProtocolFields from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMessageProtocolFieldsReceived;
        protected virtual void OnAdminDeleteMessageProtocolFieldsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMessageProtocolFieldsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMessageProtocolFieldsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGNodeStatus from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGNodeStatusReceived;
        protected virtual void OnAdminAddGNodeStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGNodeStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGNodeStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGNodeStatuses from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGNodeStatusesReceived;
        protected virtual void OnAdminGetGNodeStatusesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGNodeStatusesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGNodeStatusesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGNodeStatus from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGNodeStatusReceived;
        protected virtual void OnAdminUpdateGNodeStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGNodeStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGNodeStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGNodeStatus from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGNodeStatusReceived;
        protected virtual void OnAdminDeleteGNodeStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGNodeStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGNodeStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGridRunClass from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGridRunClassReceived;
        protected virtual void OnAdminAddGridRunClassReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGridRunClassReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGridRunClassReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGridRunClasses from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGridRunClassesReceived;
        protected virtual void OnAdminGetGridRunClassesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGridRunClassesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGridRunClassesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGridRunClass from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGridRunClassReceived;
        protected virtual void OnAdminUpdateGridRunClassReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGridRunClassReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGridRunClassReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGridRunClass from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGridRunClassReceived;
        protected virtual void OnAdminDeleteGridRunClassReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGridRunClassReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGridRunClassReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGNodeRole from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGNodeRoleReceived;
        protected virtual void OnAdminAddGNodeRoleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGNodeRoleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGNodeRoleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGNodeRoles from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGNodeRolesReceived;
        protected virtual void OnAdminGetGNodeRolesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGNodeRolesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGNodeRolesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGNodeRole from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGNodeRoleReceived;
        protected virtual void OnAdminUpdateGNodeRoleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGNodeRoleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGNodeRoleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGNodeRole from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGNodeRoleReceived;
        protected virtual void OnAdminDeleteGNodeRoleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGNodeRoleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGNodeRoleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLocalAxioms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddLocalAxiomsReceived;
        protected virtual void OnAdminAddLocalAxiomsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddLocalAxiomsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddLocalAxiomsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLocalAxiomss from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetLocalAxiomssReceived;
        protected virtual void OnAdminGetLocalAxiomssReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetLocalAxiomssReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetLocalAxiomssReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLocalAxioms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateLocalAxiomsReceived;
        protected virtual void OnAdminUpdateLocalAxiomsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateLocalAxiomsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateLocalAxiomsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLocalAxioms from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteLocalAxiomsReceived;
        protected virtual void OnAdminDeleteLocalAxiomsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteLocalAxiomsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteLocalAxiomsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddGNodeStrategyLifeCycleStates from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddGNodeStrategyLifeCycleStatesReceived;
        protected virtual void OnAdminAddGNodeStrategyLifeCycleStatesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddGNodeStrategyLifeCycleStatesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddGNodeStrategyLifeCycleStatesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetGNodeStrategyLifeCycleStatess from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetGNodeStrategyLifeCycleStatessReceived;
        protected virtual void OnAdminGetGNodeStrategyLifeCycleStatessReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetGNodeStrategyLifeCycleStatessReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetGNodeStrategyLifeCycleStatessReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateGNodeStrategyLifeCycleStates from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateGNodeStrategyLifeCycleStatesReceived;
        protected virtual void OnAdminUpdateGNodeStrategyLifeCycleStatesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateGNodeStrategyLifeCycleStatesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateGNodeStrategyLifeCycleStatesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteGNodeStrategyLifeCycleStates from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteGNodeStrategyLifeCycleStatesReceived;
        protected virtual void OnAdminDeleteGNodeStrategyLifeCycleStatesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteGNodeStrategyLifeCycleStatesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteGNodeStrategyLifeCycleStatesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddComponentAttributeClass from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddComponentAttributeClassReceived;
        protected virtual void OnAdminAddComponentAttributeClassReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddComponentAttributeClassReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddComponentAttributeClassReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetComponentAttributeClasses from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetComponentAttributeClassesReceived;
        protected virtual void OnAdminGetComponentAttributeClassesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetComponentAttributeClassesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetComponentAttributeClassesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateComponentAttributeClass from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateComponentAttributeClassReceived;
        protected virtual void OnAdminUpdateComponentAttributeClassReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateComponentAttributeClassReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateComponentAttributeClassReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteComponentAttributeClass from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteComponentAttributeClassReceived;
        protected virtual void OnAdminDeleteComponentAttributeClassReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteComponentAttributeClassReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteComponentAttributeClassReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddTimeStepBaggage from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddTimeStepBaggageReceived;
        protected virtual void OnAdminAddTimeStepBaggageReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddTimeStepBaggageReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddTimeStepBaggageReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetTimeStepBaggages from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetTimeStepBaggagesReceived;
        protected virtual void OnAdminGetTimeStepBaggagesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetTimeStepBaggagesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetTimeStepBaggagesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateTimeStepBaggage from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateTimeStepBaggageReceived;
        protected virtual void OnAdminUpdateTimeStepBaggageReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateTimeStepBaggageReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateTimeStepBaggageReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteTimeStepBaggage from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteTimeStepBaggageReceived;
        protected virtual void OnAdminDeleteTimeStepBaggageReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteTimeStepBaggageReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteTimeStepBaggageReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddWorldInstance from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddWorldInstanceReceived;
        protected virtual void OnAdminAddWorldInstanceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddWorldInstanceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddWorldInstanceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetWorldInstances from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetWorldInstancesReceived;
        protected virtual void OnAdminGetWorldInstancesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetWorldInstancesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetWorldInstancesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateWorldInstance from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateWorldInstanceReceived;
        protected virtual void OnAdminUpdateWorldInstanceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateWorldInstanceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateWorldInstanceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteWorldInstance from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteWorldInstanceReceived;
        protected virtual void OnAdminDeleteWorldInstanceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteWorldInstanceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteWorldInstanceReceived(this, plea);
            }
        }

        /// <summary>
        /// ResetRabbitSassyMQConfiguration - 
        /// </summary>
        public Task ResetRabbitSassyMQConfiguration(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.ResetRabbitSassyMQConfiguration(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// ResetRabbitSassyMQConfiguration - 
        /// </summary>
        public Task ResetRabbitSassyMQConfiguration(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.ResetRabbitSassyMQConfiguration(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// ResetRabbitSassyMQConfiguration - 
        /// </summary>
        public Task ResetRabbitSassyMQConfiguration(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.crudcoordinator.resetrabbitsassymqconfiguration", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// ResetJWTSecretKey - 
        /// </summary>
        public Task ResetJWTSecretKey(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.ResetJWTSecretKey(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// ResetJWTSecretKey - 
        /// </summary>
        public Task ResetJWTSecretKey(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.ResetJWTSecretKey(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// ResetJWTSecretKey - 
        /// </summary>
        public Task ResetJWTSecretKey(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.crudcoordinator.resetjwtsecretkey", payload, replyHandler, timeoutHandler, waitTimeout);
        }
    }
}

                    
