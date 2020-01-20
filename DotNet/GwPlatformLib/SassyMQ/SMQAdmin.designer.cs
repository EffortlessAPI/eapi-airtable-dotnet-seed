using System;
using System.Linq;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System.Threading.Tasks;

namespace EffortlessApi.SassyMQ.Lib
{
    public partial class SMQAdmin : SMQActorBase
    {

        public SMQAdmin(String amqpConnectionString)
            : base(amqpConnectionString, "admin")
        {
        }

        protected override void CheckRouting(StandardPayload payload, BasicDeliverEventArgs  bdea)
        {
            var originalAccessToken = payload.AccessToken;
            try
            {
                switch (bdea.RoutingKey)
                {
                    
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
        /// AddIrradianceMeasurement - 
        /// </summary>
        public Task AddIrradianceMeasurement(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddIrradianceMeasurement(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddIrradianceMeasurement - 
        /// </summary>
        public Task AddIrradianceMeasurement(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddIrradianceMeasurement(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddIrradianceMeasurement - 
        /// </summary>
        public Task AddIrradianceMeasurement(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addirradiancemeasurement", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetIrradianceMeasurements - 
        /// </summary>
        public Task GetIrradianceMeasurements(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetIrradianceMeasurements(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetIrradianceMeasurements - 
        /// </summary>
        public Task GetIrradianceMeasurements(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetIrradianceMeasurements(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetIrradianceMeasurements - 
        /// </summary>
        public Task GetIrradianceMeasurements(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getirradiancemeasurements", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateIrradianceMeasurement - 
        /// </summary>
        public Task UpdateIrradianceMeasurement(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateIrradianceMeasurement(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateIrradianceMeasurement - 
        /// </summary>
        public Task UpdateIrradianceMeasurement(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateIrradianceMeasurement(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateIrradianceMeasurement - 
        /// </summary>
        public Task UpdateIrradianceMeasurement(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updateirradiancemeasurement", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteIrradianceMeasurement - 
        /// </summary>
        public Task DeleteIrradianceMeasurement(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteIrradianceMeasurement(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteIrradianceMeasurement - 
        /// </summary>
        public Task DeleteIrradianceMeasurement(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteIrradianceMeasurement(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteIrradianceMeasurement - 
        /// </summary>
        public Task DeleteIrradianceMeasurement(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deleteirradiancemeasurement", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddComponentType - 
        /// </summary>
        public Task AddComponentType(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddComponentType(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddComponentType - 
        /// </summary>
        public Task AddComponentType(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddComponentType(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddComponentType - 
        /// </summary>
        public Task AddComponentType(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addcomponenttype", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetComponentTypes - 
        /// </summary>
        public Task GetComponentTypes(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetComponentTypes(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetComponentTypes - 
        /// </summary>
        public Task GetComponentTypes(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetComponentTypes(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetComponentTypes - 
        /// </summary>
        public Task GetComponentTypes(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getcomponenttypes", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateComponentType - 
        /// </summary>
        public Task UpdateComponentType(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateComponentType(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateComponentType - 
        /// </summary>
        public Task UpdateComponentType(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateComponentType(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateComponentType - 
        /// </summary>
        public Task UpdateComponentType(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatecomponenttype", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteComponentType - 
        /// </summary>
        public Task DeleteComponentType(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteComponentType(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteComponentType - 
        /// </summary>
        public Task DeleteComponentType(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteComponentType(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteComponentType - 
        /// </summary>
        public Task DeleteComponentType(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletecomponenttype", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddSupervisorContainer - 
        /// </summary>
        public Task AddSupervisorContainer(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddSupervisorContainer(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddSupervisorContainer - 
        /// </summary>
        public Task AddSupervisorContainer(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddSupervisorContainer(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddSupervisorContainer - 
        /// </summary>
        public Task AddSupervisorContainer(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addsupervisorcontainer", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetSupervisorContainers - 
        /// </summary>
        public Task GetSupervisorContainers(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetSupervisorContainers(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetSupervisorContainers - 
        /// </summary>
        public Task GetSupervisorContainers(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetSupervisorContainers(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetSupervisorContainers - 
        /// </summary>
        public Task GetSupervisorContainers(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getsupervisorcontainers", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateSupervisorContainer - 
        /// </summary>
        public Task UpdateSupervisorContainer(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateSupervisorContainer(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateSupervisorContainer - 
        /// </summary>
        public Task UpdateSupervisorContainer(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateSupervisorContainer(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateSupervisorContainer - 
        /// </summary>
        public Task UpdateSupervisorContainer(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatesupervisorcontainer", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteSupervisorContainer - 
        /// </summary>
        public Task DeleteSupervisorContainer(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteSupervisorContainer(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteSupervisorContainer - 
        /// </summary>
        public Task DeleteSupervisorContainer(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteSupervisorContainer(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteSupervisorContainer - 
        /// </summary>
        public Task DeleteSupervisorContainer(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletesupervisorcontainer", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddTimeStep - 
        /// </summary>
        public Task AddTimeStep(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddTimeStep(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddTimeStep - 
        /// </summary>
        public Task AddTimeStep(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddTimeStep(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddTimeStep - 
        /// </summary>
        public Task AddTimeStep(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addtimestep", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetTimeSteps - 
        /// </summary>
        public Task GetTimeSteps(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetTimeSteps(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetTimeSteps - 
        /// </summary>
        public Task GetTimeSteps(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetTimeSteps(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetTimeSteps - 
        /// </summary>
        public Task GetTimeSteps(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.gettimesteps", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateTimeStep - 
        /// </summary>
        public Task UpdateTimeStep(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateTimeStep(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateTimeStep - 
        /// </summary>
        public Task UpdateTimeStep(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateTimeStep(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateTimeStep - 
        /// </summary>
        public Task UpdateTimeStep(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatetimestep", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteTimeStep - 
        /// </summary>
        public Task DeleteTimeStep(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteTimeStep(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteTimeStep - 
        /// </summary>
        public Task DeleteTimeStep(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteTimeStep(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteTimeStep - 
        /// </summary>
        public Task DeleteTimeStep(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletetimestep", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGrcGNodes - 
        /// </summary>
        public Task AddGrcGNodes(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGrcGNodes(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGrcGNodes - 
        /// </summary>
        public Task AddGrcGNodes(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGrcGNodes(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGrcGNodes - 
        /// </summary>
        public Task AddGrcGNodes(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgrcgnodes", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGrcGNodess - 
        /// </summary>
        public Task GetGrcGNodess(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGrcGNodess(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGrcGNodess - 
        /// </summary>
        public Task GetGrcGNodess(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGrcGNodess(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGrcGNodess - 
        /// </summary>
        public Task GetGrcGNodess(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgrcgnodess", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGrcGNodes - 
        /// </summary>
        public Task UpdateGrcGNodes(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGrcGNodes(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGrcGNodes - 
        /// </summary>
        public Task UpdateGrcGNodes(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGrcGNodes(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGrcGNodes - 
        /// </summary>
        public Task UpdateGrcGNodes(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategrcgnodes", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGrcGNodes - 
        /// </summary>
        public Task DeleteGrcGNodes(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGrcGNodes(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGrcGNodes - 
        /// </summary>
        public Task DeleteGrcGNodes(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGrcGNodes(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGrcGNodes - 
        /// </summary>
        public Task DeleteGrcGNodes(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegrcgnodes", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddMessageCategories - 
        /// </summary>
        public Task AddMessageCategories(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddMessageCategories(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddMessageCategories - 
        /// </summary>
        public Task AddMessageCategories(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddMessageCategories(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddMessageCategories - 
        /// </summary>
        public Task AddMessageCategories(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addmessagecategories", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetMessageCategoriess - 
        /// </summary>
        public Task GetMessageCategoriess(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetMessageCategoriess(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetMessageCategoriess - 
        /// </summary>
        public Task GetMessageCategoriess(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetMessageCategoriess(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetMessageCategoriess - 
        /// </summary>
        public Task GetMessageCategoriess(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getmessagecategoriess", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateMessageCategories - 
        /// </summary>
        public Task UpdateMessageCategories(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateMessageCategories(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateMessageCategories - 
        /// </summary>
        public Task UpdateMessageCategories(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateMessageCategories(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateMessageCategories - 
        /// </summary>
        public Task UpdateMessageCategories(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatemessagecategories", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteMessageCategories - 
        /// </summary>
        public Task DeleteMessageCategories(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteMessageCategories(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteMessageCategories - 
        /// </summary>
        public Task DeleteMessageCategories(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteMessageCategories(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteMessageCategories - 
        /// </summary>
        public Task DeleteMessageCategories(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletemessagecategories", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddParameterType - 
        /// </summary>
        public Task AddParameterType(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddParameterType(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddParameterType - 
        /// </summary>
        public Task AddParameterType(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddParameterType(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddParameterType - 
        /// </summary>
        public Task AddParameterType(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addparametertype", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetParameterTypes - 
        /// </summary>
        public Task GetParameterTypes(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetParameterTypes(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetParameterTypes - 
        /// </summary>
        public Task GetParameterTypes(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetParameterTypes(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetParameterTypes - 
        /// </summary>
        public Task GetParameterTypes(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getparametertypes", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateParameterType - 
        /// </summary>
        public Task UpdateParameterType(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateParameterType(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateParameterType - 
        /// </summary>
        public Task UpdateParameterType(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateParameterType(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateParameterType - 
        /// </summary>
        public Task UpdateParameterType(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updateparametertype", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteParameterType - 
        /// </summary>
        public Task DeleteParameterType(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteParameterType(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteParameterType - 
        /// </summary>
        public Task DeleteParameterType(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteParameterType(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteParameterType - 
        /// </summary>
        public Task DeleteParameterType(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deleteparametertype", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGNodeStrategy - 
        /// </summary>
        public Task AddGNodeStrategy(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGNodeStrategy(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGNodeStrategy - 
        /// </summary>
        public Task AddGNodeStrategy(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGNodeStrategy(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGNodeStrategy - 
        /// </summary>
        public Task AddGNodeStrategy(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgnodestrategy", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGNodeStrategies - 
        /// </summary>
        public Task GetGNodeStrategies(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGNodeStrategies(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGNodeStrategies - 
        /// </summary>
        public Task GetGNodeStrategies(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGNodeStrategies(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGNodeStrategies - 
        /// </summary>
        public Task GetGNodeStrategies(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgnodestrategies", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGNodeStrategy - 
        /// </summary>
        public Task UpdateGNodeStrategy(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGNodeStrategy(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGNodeStrategy - 
        /// </summary>
        public Task UpdateGNodeStrategy(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGNodeStrategy(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGNodeStrategy - 
        /// </summary>
        public Task UpdateGNodeStrategy(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategnodestrategy", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGNodeStrategy - 
        /// </summary>
        public Task DeleteGNodeStrategy(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGNodeStrategy(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGNodeStrategy - 
        /// </summary>
        public Task DeleteGNodeStrategy(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGNodeStrategy(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGNodeStrategy - 
        /// </summary>
        public Task DeleteGNodeStrategy(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegnodestrategy", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGlobalAxioms - 
        /// </summary>
        public Task AddGlobalAxioms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGlobalAxioms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGlobalAxioms - 
        /// </summary>
        public Task AddGlobalAxioms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGlobalAxioms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGlobalAxioms - 
        /// </summary>
        public Task AddGlobalAxioms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addglobalaxioms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGlobalAxiomss - 
        /// </summary>
        public Task GetGlobalAxiomss(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGlobalAxiomss(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGlobalAxiomss - 
        /// </summary>
        public Task GetGlobalAxiomss(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGlobalAxiomss(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGlobalAxiomss - 
        /// </summary>
        public Task GetGlobalAxiomss(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getglobalaxiomss", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGlobalAxioms - 
        /// </summary>
        public Task UpdateGlobalAxioms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGlobalAxioms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGlobalAxioms - 
        /// </summary>
        public Task UpdateGlobalAxioms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGlobalAxioms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGlobalAxioms - 
        /// </summary>
        public Task UpdateGlobalAxioms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updateglobalaxioms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGlobalAxioms - 
        /// </summary>
        public Task DeleteGlobalAxioms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGlobalAxioms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGlobalAxioms - 
        /// </summary>
        public Task DeleteGlobalAxioms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGlobalAxioms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGlobalAxioms - 
        /// </summary>
        public Task DeleteGlobalAxioms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deleteglobalaxioms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddComponent - 
        /// </summary>
        public Task AddComponent(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddComponent(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddComponent - 
        /// </summary>
        public Task AddComponent(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddComponent(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddComponent - 
        /// </summary>
        public Task AddComponent(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addcomponent", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetComponents - 
        /// </summary>
        public Task GetComponents(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetComponents(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetComponents - 
        /// </summary>
        public Task GetComponents(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetComponents(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetComponents - 
        /// </summary>
        public Task GetComponents(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getcomponents", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateComponent - 
        /// </summary>
        public Task UpdateComponent(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateComponent(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateComponent - 
        /// </summary>
        public Task UpdateComponent(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateComponent(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateComponent - 
        /// </summary>
        public Task UpdateComponent(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatecomponent", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteComponent - 
        /// </summary>
        public Task DeleteComponent(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteComponent(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteComponent - 
        /// </summary>
        public Task DeleteComponent(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteComponent(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteComponent - 
        /// </summary>
        public Task DeleteComponent(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletecomponent", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddCoreLexiconTerm - 
        /// </summary>
        public Task AddCoreLexiconTerm(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddCoreLexiconTerm(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddCoreLexiconTerm - 
        /// </summary>
        public Task AddCoreLexiconTerm(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddCoreLexiconTerm(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddCoreLexiconTerm - 
        /// </summary>
        public Task AddCoreLexiconTerm(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addcorelexiconterm", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetCoreLexiconTerms - 
        /// </summary>
        public Task GetCoreLexiconTerms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetCoreLexiconTerms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetCoreLexiconTerms - 
        /// </summary>
        public Task GetCoreLexiconTerms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetCoreLexiconTerms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetCoreLexiconTerms - 
        /// </summary>
        public Task GetCoreLexiconTerms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getcorelexiconterms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateCoreLexiconTerm - 
        /// </summary>
        public Task UpdateCoreLexiconTerm(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateCoreLexiconTerm(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateCoreLexiconTerm - 
        /// </summary>
        public Task UpdateCoreLexiconTerm(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateCoreLexiconTerm(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateCoreLexiconTerm - 
        /// </summary>
        public Task UpdateCoreLexiconTerm(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatecorelexiconterm", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteCoreLexiconTerm - 
        /// </summary>
        public Task DeleteCoreLexiconTerm(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteCoreLexiconTerm(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteCoreLexiconTerm - 
        /// </summary>
        public Task DeleteCoreLexiconTerm(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteCoreLexiconTerm(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteCoreLexiconTerm - 
        /// </summary>
        public Task DeleteCoreLexiconTerm(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletecorelexiconterm", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddTaOperatingModeSimpleDc - 
        /// </summary>
        public Task AddTaOperatingModeSimpleDc(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddTaOperatingModeSimpleDc(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddTaOperatingModeSimpleDc - 
        /// </summary>
        public Task AddTaOperatingModeSimpleDc(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddTaOperatingModeSimpleDc(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddTaOperatingModeSimpleDc - 
        /// </summary>
        public Task AddTaOperatingModeSimpleDc(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addtaoperatingmodesimpledc", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetTaOperatingModeSimpleDcs - 
        /// </summary>
        public Task GetTaOperatingModeSimpleDcs(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetTaOperatingModeSimpleDcs(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetTaOperatingModeSimpleDcs - 
        /// </summary>
        public Task GetTaOperatingModeSimpleDcs(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetTaOperatingModeSimpleDcs(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetTaOperatingModeSimpleDcs - 
        /// </summary>
        public Task GetTaOperatingModeSimpleDcs(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.gettaoperatingmodesimpledcs", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateTaOperatingModeSimpleDc - 
        /// </summary>
        public Task UpdateTaOperatingModeSimpleDc(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateTaOperatingModeSimpleDc(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateTaOperatingModeSimpleDc - 
        /// </summary>
        public Task UpdateTaOperatingModeSimpleDc(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateTaOperatingModeSimpleDc(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateTaOperatingModeSimpleDc - 
        /// </summary>
        public Task UpdateTaOperatingModeSimpleDc(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatetaoperatingmodesimpledc", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteTaOperatingModeSimpleDc - 
        /// </summary>
        public Task DeleteTaOperatingModeSimpleDc(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteTaOperatingModeSimpleDc(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteTaOperatingModeSimpleDc - 
        /// </summary>
        public Task DeleteTaOperatingModeSimpleDc(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteTaOperatingModeSimpleDc(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteTaOperatingModeSimpleDc - 
        /// </summary>
        public Task DeleteTaOperatingModeSimpleDc(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletetaoperatingmodesimpledc", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddMessageFormatRequirements - 
        /// </summary>
        public Task AddMessageFormatRequirements(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddMessageFormatRequirements(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddMessageFormatRequirements - 
        /// </summary>
        public Task AddMessageFormatRequirements(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddMessageFormatRequirements(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddMessageFormatRequirements - 
        /// </summary>
        public Task AddMessageFormatRequirements(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addmessageformatrequirements", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetMessageFormatRequirementss - 
        /// </summary>
        public Task GetMessageFormatRequirementss(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetMessageFormatRequirementss(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetMessageFormatRequirementss - 
        /// </summary>
        public Task GetMessageFormatRequirementss(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetMessageFormatRequirementss(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetMessageFormatRequirementss - 
        /// </summary>
        public Task GetMessageFormatRequirementss(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getmessageformatrequirementss", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateMessageFormatRequirements - 
        /// </summary>
        public Task UpdateMessageFormatRequirements(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateMessageFormatRequirements(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateMessageFormatRequirements - 
        /// </summary>
        public Task UpdateMessageFormatRequirements(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateMessageFormatRequirements(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateMessageFormatRequirements - 
        /// </summary>
        public Task UpdateMessageFormatRequirements(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatemessageformatrequirements", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteMessageFormatRequirements - 
        /// </summary>
        public Task DeleteMessageFormatRequirements(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteMessageFormatRequirements(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteMessageFormatRequirements - 
        /// </summary>
        public Task DeleteMessageFormatRequirements(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteMessageFormatRequirements(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteMessageFormatRequirements - 
        /// </summary>
        public Task DeleteMessageFormatRequirements(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletemessageformatrequirements", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddWorldInstanceEra - 
        /// </summary>
        public Task AddWorldInstanceEra(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddWorldInstanceEra(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddWorldInstanceEra - 
        /// </summary>
        public Task AddWorldInstanceEra(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddWorldInstanceEra(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddWorldInstanceEra - 
        /// </summary>
        public Task AddWorldInstanceEra(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addworldinstanceera", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetWorldInstanceEras - 
        /// </summary>
        public Task GetWorldInstanceEras(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetWorldInstanceEras(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetWorldInstanceEras - 
        /// </summary>
        public Task GetWorldInstanceEras(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetWorldInstanceEras(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetWorldInstanceEras - 
        /// </summary>
        public Task GetWorldInstanceEras(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getworldinstanceeras", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateWorldInstanceEra - 
        /// </summary>
        public Task UpdateWorldInstanceEra(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateWorldInstanceEra(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateWorldInstanceEra - 
        /// </summary>
        public Task UpdateWorldInstanceEra(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateWorldInstanceEra(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateWorldInstanceEra - 
        /// </summary>
        public Task UpdateWorldInstanceEra(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updateworldinstanceera", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteWorldInstanceEra - 
        /// </summary>
        public Task DeleteWorldInstanceEra(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteWorldInstanceEra(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteWorldInstanceEra - 
        /// </summary>
        public Task DeleteWorldInstanceEra(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteWorldInstanceEra(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteWorldInstanceEra - 
        /// </summary>
        public Task DeleteWorldInstanceEra(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deleteworldinstanceera", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddPhysicsParadigm - 
        /// </summary>
        public Task AddPhysicsParadigm(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddPhysicsParadigm(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddPhysicsParadigm - 
        /// </summary>
        public Task AddPhysicsParadigm(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddPhysicsParadigm(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddPhysicsParadigm - 
        /// </summary>
        public Task AddPhysicsParadigm(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addphysicsparadigm", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetPhysicsParadigms - 
        /// </summary>
        public Task GetPhysicsParadigms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetPhysicsParadigms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetPhysicsParadigms - 
        /// </summary>
        public Task GetPhysicsParadigms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetPhysicsParadigms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetPhysicsParadigms - 
        /// </summary>
        public Task GetPhysicsParadigms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getphysicsparadigms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdatePhysicsParadigm - 
        /// </summary>
        public Task UpdatePhysicsParadigm(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdatePhysicsParadigm(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdatePhysicsParadigm - 
        /// </summary>
        public Task UpdatePhysicsParadigm(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdatePhysicsParadigm(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdatePhysicsParadigm - 
        /// </summary>
        public Task UpdatePhysicsParadigm(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatephysicsparadigm", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeletePhysicsParadigm - 
        /// </summary>
        public Task DeletePhysicsParadigm(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeletePhysicsParadigm(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeletePhysicsParadigm - 
        /// </summary>
        public Task DeletePhysicsParadigm(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeletePhysicsParadigm(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeletePhysicsParadigm - 
        /// </summary>
        public Task DeletePhysicsParadigm(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletephysicsparadigm", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGNode - 
        /// </summary>
        public Task AddGNode(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGNode(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGNode - 
        /// </summary>
        public Task AddGNode(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGNode(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGNode - 
        /// </summary>
        public Task AddGNode(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgnode", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGNodes - 
        /// </summary>
        public Task GetGNodes(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGNodes(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGNodes - 
        /// </summary>
        public Task GetGNodes(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGNodes(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGNodes - 
        /// </summary>
        public Task GetGNodes(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgnodes", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGNode - 
        /// </summary>
        public Task UpdateGNode(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGNode(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGNode - 
        /// </summary>
        public Task UpdateGNode(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGNode(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGNode - 
        /// </summary>
        public Task UpdateGNode(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategnode", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGNode - 
        /// </summary>
        public Task DeleteGNode(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGNode(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGNode - 
        /// </summary>
        public Task DeleteGNode(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGNode(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGNode - 
        /// </summary>
        public Task DeleteGNode(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegnode", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddStrategyParam - 
        /// </summary>
        public Task AddStrategyParam(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddStrategyParam(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddStrategyParam - 
        /// </summary>
        public Task AddStrategyParam(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddStrategyParam(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddStrategyParam - 
        /// </summary>
        public Task AddStrategyParam(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addstrategyparam", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetStrategyParams - 
        /// </summary>
        public Task GetStrategyParams(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetStrategyParams(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetStrategyParams - 
        /// </summary>
        public Task GetStrategyParams(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetStrategyParams(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetStrategyParams - 
        /// </summary>
        public Task GetStrategyParams(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getstrategyparams", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateStrategyParam - 
        /// </summary>
        public Task UpdateStrategyParam(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateStrategyParam(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateStrategyParam - 
        /// </summary>
        public Task UpdateStrategyParam(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateStrategyParam(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateStrategyParam - 
        /// </summary>
        public Task UpdateStrategyParam(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatestrategyparam", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteStrategyParam - 
        /// </summary>
        public Task DeleteStrategyParam(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteStrategyParam(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteStrategyParam - 
        /// </summary>
        public Task DeleteStrategyParam(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteStrategyParam(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteStrategyParam - 
        /// </summary>
        public Task DeleteStrategyParam(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletestrategyparam", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddElectricalQuantity - 
        /// </summary>
        public Task AddElectricalQuantity(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddElectricalQuantity(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddElectricalQuantity - 
        /// </summary>
        public Task AddElectricalQuantity(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddElectricalQuantity(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddElectricalQuantity - 
        /// </summary>
        public Task AddElectricalQuantity(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addelectricalquantity", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetElectricalQuantities - 
        /// </summary>
        public Task GetElectricalQuantities(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetElectricalQuantities(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetElectricalQuantities - 
        /// </summary>
        public Task GetElectricalQuantities(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetElectricalQuantities(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetElectricalQuantities - 
        /// </summary>
        public Task GetElectricalQuantities(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getelectricalquantities", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateElectricalQuantity - 
        /// </summary>
        public Task UpdateElectricalQuantity(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateElectricalQuantity(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateElectricalQuantity - 
        /// </summary>
        public Task UpdateElectricalQuantity(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateElectricalQuantity(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateElectricalQuantity - 
        /// </summary>
        public Task UpdateElectricalQuantity(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updateelectricalquantity", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteElectricalQuantity - 
        /// </summary>
        public Task DeleteElectricalQuantity(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteElectricalQuantity(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteElectricalQuantity - 
        /// </summary>
        public Task DeleteElectricalQuantity(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteElectricalQuantity(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteElectricalQuantity - 
        /// </summary>
        public Task DeleteElectricalQuantity(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deleteelectricalquantity", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddComponentManufacturers - 
        /// </summary>
        public Task AddComponentManufacturers(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddComponentManufacturers(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddComponentManufacturers - 
        /// </summary>
        public Task AddComponentManufacturers(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddComponentManufacturers(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddComponentManufacturers - 
        /// </summary>
        public Task AddComponentManufacturers(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addcomponentmanufacturers", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetComponentManufacturerss - 
        /// </summary>
        public Task GetComponentManufacturerss(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetComponentManufacturerss(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetComponentManufacturerss - 
        /// </summary>
        public Task GetComponentManufacturerss(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetComponentManufacturerss(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetComponentManufacturerss - 
        /// </summary>
        public Task GetComponentManufacturerss(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getcomponentmanufacturerss", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateComponentManufacturers - 
        /// </summary>
        public Task UpdateComponentManufacturers(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateComponentManufacturers(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateComponentManufacturers - 
        /// </summary>
        public Task UpdateComponentManufacturers(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateComponentManufacturers(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateComponentManufacturers - 
        /// </summary>
        public Task UpdateComponentManufacturers(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatecomponentmanufacturers", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteComponentManufacturers - 
        /// </summary>
        public Task DeleteComponentManufacturers(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteComponentManufacturers(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteComponentManufacturers - 
        /// </summary>
        public Task DeleteComponentManufacturers(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteComponentManufacturers(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteComponentManufacturers - 
        /// </summary>
        public Task DeleteComponentManufacturers(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletecomponentmanufacturers", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddMessageProtocol - 
        /// </summary>
        public Task AddMessageProtocol(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddMessageProtocol(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddMessageProtocol - 
        /// </summary>
        public Task AddMessageProtocol(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddMessageProtocol(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddMessageProtocol - 
        /// </summary>
        public Task AddMessageProtocol(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addmessageprotocol", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetMessageProtocols - 
        /// </summary>
        public Task GetMessageProtocols(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetMessageProtocols(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetMessageProtocols - 
        /// </summary>
        public Task GetMessageProtocols(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetMessageProtocols(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetMessageProtocols - 
        /// </summary>
        public Task GetMessageProtocols(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getmessageprotocols", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateMessageProtocol - 
        /// </summary>
        public Task UpdateMessageProtocol(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateMessageProtocol(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateMessageProtocol - 
        /// </summary>
        public Task UpdateMessageProtocol(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateMessageProtocol(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateMessageProtocol - 
        /// </summary>
        public Task UpdateMessageProtocol(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatemessageprotocol", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteMessageProtocol - 
        /// </summary>
        public Task DeleteMessageProtocol(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteMessageProtocol(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteMessageProtocol - 
        /// </summary>
        public Task DeleteMessageProtocol(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteMessageProtocol(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteMessageProtocol - 
        /// </summary>
        public Task DeleteMessageProtocol(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletemessageprotocol", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddAbstractEntityClassification - 
        /// </summary>
        public Task AddAbstractEntityClassification(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddAbstractEntityClassification(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddAbstractEntityClassification - 
        /// </summary>
        public Task AddAbstractEntityClassification(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddAbstractEntityClassification(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddAbstractEntityClassification - 
        /// </summary>
        public Task AddAbstractEntityClassification(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addabstractentityclassification", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetAbstractEntityClassifications - 
        /// </summary>
        public Task GetAbstractEntityClassifications(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetAbstractEntityClassifications(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetAbstractEntityClassifications - 
        /// </summary>
        public Task GetAbstractEntityClassifications(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetAbstractEntityClassifications(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetAbstractEntityClassifications - 
        /// </summary>
        public Task GetAbstractEntityClassifications(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getabstractentityclassifications", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateAbstractEntityClassification - 
        /// </summary>
        public Task UpdateAbstractEntityClassification(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateAbstractEntityClassification(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateAbstractEntityClassification - 
        /// </summary>
        public Task UpdateAbstractEntityClassification(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateAbstractEntityClassification(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateAbstractEntityClassification - 
        /// </summary>
        public Task UpdateAbstractEntityClassification(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updateabstractentityclassification", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteAbstractEntityClassification - 
        /// </summary>
        public Task DeleteAbstractEntityClassification(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteAbstractEntityClassification(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteAbstractEntityClassification - 
        /// </summary>
        public Task DeleteAbstractEntityClassification(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteAbstractEntityClassification(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteAbstractEntityClassification - 
        /// </summary>
        public Task DeleteAbstractEntityClassification(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deleteabstractentityclassification", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGNodeInstance - 
        /// </summary>
        public Task AddGNodeInstance(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGNodeInstance(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGNodeInstance - 
        /// </summary>
        public Task AddGNodeInstance(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGNodeInstance(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGNodeInstance - 
        /// </summary>
        public Task AddGNodeInstance(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgnodeinstance", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGNodeInstances - 
        /// </summary>
        public Task GetGNodeInstances(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGNodeInstances(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGNodeInstances - 
        /// </summary>
        public Task GetGNodeInstances(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGNodeInstances(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGNodeInstances - 
        /// </summary>
        public Task GetGNodeInstances(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgnodeinstances", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGNodeInstance - 
        /// </summary>
        public Task UpdateGNodeInstance(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGNodeInstance(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGNodeInstance - 
        /// </summary>
        public Task UpdateGNodeInstance(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGNodeInstance(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGNodeInstance - 
        /// </summary>
        public Task UpdateGNodeInstance(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategnodeinstance", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGNodeInstance - 
        /// </summary>
        public Task DeleteGNodeInstance(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGNodeInstance(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGNodeInstance - 
        /// </summary>
        public Task DeleteGNodeInstance(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGNodeInstance(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGNodeInstance - 
        /// </summary>
        public Task DeleteGNodeInstance(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegnodeinstance", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddFuzzyLogic - 
        /// </summary>
        public Task AddFuzzyLogic(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddFuzzyLogic(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddFuzzyLogic - 
        /// </summary>
        public Task AddFuzzyLogic(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddFuzzyLogic(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddFuzzyLogic - 
        /// </summary>
        public Task AddFuzzyLogic(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addfuzzylogic", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetFuzzyLogics - 
        /// </summary>
        public Task GetFuzzyLogics(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetFuzzyLogics(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetFuzzyLogics - 
        /// </summary>
        public Task GetFuzzyLogics(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetFuzzyLogics(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetFuzzyLogics - 
        /// </summary>
        public Task GetFuzzyLogics(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getfuzzylogics", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateFuzzyLogic - 
        /// </summary>
        public Task UpdateFuzzyLogic(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateFuzzyLogic(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateFuzzyLogic - 
        /// </summary>
        public Task UpdateFuzzyLogic(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateFuzzyLogic(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateFuzzyLogic - 
        /// </summary>
        public Task UpdateFuzzyLogic(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatefuzzylogic", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteFuzzyLogic - 
        /// </summary>
        public Task DeleteFuzzyLogic(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteFuzzyLogic(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteFuzzyLogic - 
        /// </summary>
        public Task DeleteFuzzyLogic(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteFuzzyLogic(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteFuzzyLogic - 
        /// </summary>
        public Task DeleteFuzzyLogic(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletefuzzylogic", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddComponentCategory - 
        /// </summary>
        public Task AddComponentCategory(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddComponentCategory(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddComponentCategory - 
        /// </summary>
        public Task AddComponentCategory(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddComponentCategory(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddComponentCategory - 
        /// </summary>
        public Task AddComponentCategory(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addcomponentcategory", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetComponentCategories - 
        /// </summary>
        public Task GetComponentCategories(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetComponentCategories(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetComponentCategories - 
        /// </summary>
        public Task GetComponentCategories(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetComponentCategories(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetComponentCategories - 
        /// </summary>
        public Task GetComponentCategories(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getcomponentcategories", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateComponentCategory - 
        /// </summary>
        public Task UpdateComponentCategory(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateComponentCategory(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateComponentCategory - 
        /// </summary>
        public Task UpdateComponentCategory(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateComponentCategory(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateComponentCategory - 
        /// </summary>
        public Task UpdateComponentCategory(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatecomponentcategory", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteComponentCategory - 
        /// </summary>
        public Task DeleteComponentCategory(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteComponentCategory(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteComponentCategory - 
        /// </summary>
        public Task DeleteComponentCategory(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteComponentCategory(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteComponentCategory - 
        /// </summary>
        public Task DeleteComponentCategory(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletecomponentcategory", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddMessageProtocolFields - 
        /// </summary>
        public Task AddMessageProtocolFields(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddMessageProtocolFields(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddMessageProtocolFields - 
        /// </summary>
        public Task AddMessageProtocolFields(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddMessageProtocolFields(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddMessageProtocolFields - 
        /// </summary>
        public Task AddMessageProtocolFields(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addmessageprotocolfields", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetMessageProtocolFieldss - 
        /// </summary>
        public Task GetMessageProtocolFieldss(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetMessageProtocolFieldss(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetMessageProtocolFieldss - 
        /// </summary>
        public Task GetMessageProtocolFieldss(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetMessageProtocolFieldss(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetMessageProtocolFieldss - 
        /// </summary>
        public Task GetMessageProtocolFieldss(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getmessageprotocolfieldss", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateMessageProtocolFields - 
        /// </summary>
        public Task UpdateMessageProtocolFields(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateMessageProtocolFields(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateMessageProtocolFields - 
        /// </summary>
        public Task UpdateMessageProtocolFields(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateMessageProtocolFields(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateMessageProtocolFields - 
        /// </summary>
        public Task UpdateMessageProtocolFields(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatemessageprotocolfields", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteMessageProtocolFields - 
        /// </summary>
        public Task DeleteMessageProtocolFields(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteMessageProtocolFields(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteMessageProtocolFields - 
        /// </summary>
        public Task DeleteMessageProtocolFields(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteMessageProtocolFields(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteMessageProtocolFields - 
        /// </summary>
        public Task DeleteMessageProtocolFields(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletemessageprotocolfields", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGNodeStatus - 
        /// </summary>
        public Task AddGNodeStatus(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGNodeStatus(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGNodeStatus - 
        /// </summary>
        public Task AddGNodeStatus(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGNodeStatus(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGNodeStatus - 
        /// </summary>
        public Task AddGNodeStatus(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgnodestatus", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGNodeStatuses - 
        /// </summary>
        public Task GetGNodeStatuses(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGNodeStatuses(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGNodeStatuses - 
        /// </summary>
        public Task GetGNodeStatuses(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGNodeStatuses(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGNodeStatuses - 
        /// </summary>
        public Task GetGNodeStatuses(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgnodestatuses", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGNodeStatus - 
        /// </summary>
        public Task UpdateGNodeStatus(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGNodeStatus(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGNodeStatus - 
        /// </summary>
        public Task UpdateGNodeStatus(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGNodeStatus(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGNodeStatus - 
        /// </summary>
        public Task UpdateGNodeStatus(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategnodestatus", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGNodeStatus - 
        /// </summary>
        public Task DeleteGNodeStatus(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGNodeStatus(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGNodeStatus - 
        /// </summary>
        public Task DeleteGNodeStatus(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGNodeStatus(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGNodeStatus - 
        /// </summary>
        public Task DeleteGNodeStatus(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegnodestatus", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGridRunClass - 
        /// </summary>
        public Task AddGridRunClass(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGridRunClass(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGridRunClass - 
        /// </summary>
        public Task AddGridRunClass(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGridRunClass(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGridRunClass - 
        /// </summary>
        public Task AddGridRunClass(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgridrunclass", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGridRunClasses - 
        /// </summary>
        public Task GetGridRunClasses(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGridRunClasses(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGridRunClasses - 
        /// </summary>
        public Task GetGridRunClasses(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGridRunClasses(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGridRunClasses - 
        /// </summary>
        public Task GetGridRunClasses(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgridrunclasses", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGridRunClass - 
        /// </summary>
        public Task UpdateGridRunClass(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGridRunClass(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGridRunClass - 
        /// </summary>
        public Task UpdateGridRunClass(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGridRunClass(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGridRunClass - 
        /// </summary>
        public Task UpdateGridRunClass(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategridrunclass", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGridRunClass - 
        /// </summary>
        public Task DeleteGridRunClass(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGridRunClass(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGridRunClass - 
        /// </summary>
        public Task DeleteGridRunClass(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGridRunClass(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGridRunClass - 
        /// </summary>
        public Task DeleteGridRunClass(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegridrunclass", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGNodeRole - 
        /// </summary>
        public Task AddGNodeRole(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGNodeRole(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGNodeRole - 
        /// </summary>
        public Task AddGNodeRole(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGNodeRole(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGNodeRole - 
        /// </summary>
        public Task AddGNodeRole(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgnoderole", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGNodeRoles - 
        /// </summary>
        public Task GetGNodeRoles(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGNodeRoles(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGNodeRoles - 
        /// </summary>
        public Task GetGNodeRoles(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGNodeRoles(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGNodeRoles - 
        /// </summary>
        public Task GetGNodeRoles(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgnoderoles", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGNodeRole - 
        /// </summary>
        public Task UpdateGNodeRole(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGNodeRole(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGNodeRole - 
        /// </summary>
        public Task UpdateGNodeRole(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGNodeRole(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGNodeRole - 
        /// </summary>
        public Task UpdateGNodeRole(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategnoderole", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGNodeRole - 
        /// </summary>
        public Task DeleteGNodeRole(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGNodeRole(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGNodeRole - 
        /// </summary>
        public Task DeleteGNodeRole(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGNodeRole(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGNodeRole - 
        /// </summary>
        public Task DeleteGNodeRole(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegnoderole", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddLocalAxioms - 
        /// </summary>
        public Task AddLocalAxioms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddLocalAxioms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddLocalAxioms - 
        /// </summary>
        public Task AddLocalAxioms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddLocalAxioms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddLocalAxioms - 
        /// </summary>
        public Task AddLocalAxioms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addlocalaxioms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetLocalAxiomss - 
        /// </summary>
        public Task GetLocalAxiomss(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetLocalAxiomss(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetLocalAxiomss - 
        /// </summary>
        public Task GetLocalAxiomss(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetLocalAxiomss(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetLocalAxiomss - 
        /// </summary>
        public Task GetLocalAxiomss(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getlocalaxiomss", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateLocalAxioms - 
        /// </summary>
        public Task UpdateLocalAxioms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateLocalAxioms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateLocalAxioms - 
        /// </summary>
        public Task UpdateLocalAxioms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateLocalAxioms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateLocalAxioms - 
        /// </summary>
        public Task UpdateLocalAxioms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatelocalaxioms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteLocalAxioms - 
        /// </summary>
        public Task DeleteLocalAxioms(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteLocalAxioms(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteLocalAxioms - 
        /// </summary>
        public Task DeleteLocalAxioms(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteLocalAxioms(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteLocalAxioms - 
        /// </summary>
        public Task DeleteLocalAxioms(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletelocalaxioms", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task AddGNodeStrategyLifeCycleStates(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddGNodeStrategyLifeCycleStates(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task AddGNodeStrategyLifeCycleStates(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddGNodeStrategyLifeCycleStates(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task AddGNodeStrategyLifeCycleStates(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addgnodestrategylifecyclestates", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetGNodeStrategyLifeCycleStatess - 
        /// </summary>
        public Task GetGNodeStrategyLifeCycleStatess(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetGNodeStrategyLifeCycleStatess(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetGNodeStrategyLifeCycleStatess - 
        /// </summary>
        public Task GetGNodeStrategyLifeCycleStatess(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetGNodeStrategyLifeCycleStatess(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetGNodeStrategyLifeCycleStatess - 
        /// </summary>
        public Task GetGNodeStrategyLifeCycleStatess(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getgnodestrategylifecyclestatess", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task UpdateGNodeStrategyLifeCycleStates(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateGNodeStrategyLifeCycleStates(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task UpdateGNodeStrategyLifeCycleStates(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateGNodeStrategyLifeCycleStates(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task UpdateGNodeStrategyLifeCycleStates(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updategnodestrategylifecyclestates", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task DeleteGNodeStrategyLifeCycleStates(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteGNodeStrategyLifeCycleStates(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task DeleteGNodeStrategyLifeCycleStates(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteGNodeStrategyLifeCycleStates(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteGNodeStrategyLifeCycleStates - 
        /// </summary>
        public Task DeleteGNodeStrategyLifeCycleStates(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletegnodestrategylifecyclestates", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddComponentAttributeClass - 
        /// </summary>
        public Task AddComponentAttributeClass(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddComponentAttributeClass(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddComponentAttributeClass - 
        /// </summary>
        public Task AddComponentAttributeClass(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddComponentAttributeClass(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddComponentAttributeClass - 
        /// </summary>
        public Task AddComponentAttributeClass(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addcomponentattributeclass", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetComponentAttributeClasses - 
        /// </summary>
        public Task GetComponentAttributeClasses(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetComponentAttributeClasses(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetComponentAttributeClasses - 
        /// </summary>
        public Task GetComponentAttributeClasses(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetComponentAttributeClasses(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetComponentAttributeClasses - 
        /// </summary>
        public Task GetComponentAttributeClasses(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getcomponentattributeclasses", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateComponentAttributeClass - 
        /// </summary>
        public Task UpdateComponentAttributeClass(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateComponentAttributeClass(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateComponentAttributeClass - 
        /// </summary>
        public Task UpdateComponentAttributeClass(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateComponentAttributeClass(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateComponentAttributeClass - 
        /// </summary>
        public Task UpdateComponentAttributeClass(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatecomponentattributeclass", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteComponentAttributeClass - 
        /// </summary>
        public Task DeleteComponentAttributeClass(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteComponentAttributeClass(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteComponentAttributeClass - 
        /// </summary>
        public Task DeleteComponentAttributeClass(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteComponentAttributeClass(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteComponentAttributeClass - 
        /// </summary>
        public Task DeleteComponentAttributeClass(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletecomponentattributeclass", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddTimeStepBaggage - 
        /// </summary>
        public Task AddTimeStepBaggage(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddTimeStepBaggage(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddTimeStepBaggage - 
        /// </summary>
        public Task AddTimeStepBaggage(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddTimeStepBaggage(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddTimeStepBaggage - 
        /// </summary>
        public Task AddTimeStepBaggage(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addtimestepbaggage", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetTimeStepBaggages - 
        /// </summary>
        public Task GetTimeStepBaggages(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetTimeStepBaggages(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetTimeStepBaggages - 
        /// </summary>
        public Task GetTimeStepBaggages(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetTimeStepBaggages(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetTimeStepBaggages - 
        /// </summary>
        public Task GetTimeStepBaggages(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.gettimestepbaggages", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateTimeStepBaggage - 
        /// </summary>
        public Task UpdateTimeStepBaggage(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateTimeStepBaggage(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateTimeStepBaggage - 
        /// </summary>
        public Task UpdateTimeStepBaggage(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateTimeStepBaggage(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateTimeStepBaggage - 
        /// </summary>
        public Task UpdateTimeStepBaggage(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updatetimestepbaggage", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteTimeStepBaggage - 
        /// </summary>
        public Task DeleteTimeStepBaggage(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteTimeStepBaggage(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteTimeStepBaggage - 
        /// </summary>
        public Task DeleteTimeStepBaggage(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteTimeStepBaggage(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteTimeStepBaggage - 
        /// </summary>
        public Task DeleteTimeStepBaggage(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deletetimestepbaggage", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// AddWorldInstance - 
        /// </summary>
        public Task AddWorldInstance(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.AddWorldInstance(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// AddWorldInstance - 
        /// </summary>
        public Task AddWorldInstance(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.AddWorldInstance(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// AddWorldInstance - 
        /// </summary>
        public Task AddWorldInstance(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.addworldinstance", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// GetWorldInstances - 
        /// </summary>
        public Task GetWorldInstances(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.GetWorldInstances(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// GetWorldInstances - 
        /// </summary>
        public Task GetWorldInstances(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.GetWorldInstances(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// GetWorldInstances - 
        /// </summary>
        public Task GetWorldInstances(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.getworldinstances", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// UpdateWorldInstance - 
        /// </summary>
        public Task UpdateWorldInstance(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.UpdateWorldInstance(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// UpdateWorldInstance - 
        /// </summary>
        public Task UpdateWorldInstance(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.UpdateWorldInstance(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// UpdateWorldInstance - 
        /// </summary>
        public Task UpdateWorldInstance(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.updateworldinstance", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        /// <summary>
        /// DeleteWorldInstance - 
        /// </summary>
        public Task DeleteWorldInstance(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.DeleteWorldInstance(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }    

        /// <summary>
        /// DeleteWorldInstance - 
        /// </summary>
        public Task DeleteWorldInstance(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.DeleteWorldInstance(payload, replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// DeleteWorldInstance - 
        /// </summary>
        public Task DeleteWorldInstance(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.admin.deleteworldinstance", payload, replyHandler, timeoutHandler, waitTimeout);
        }
    }
}

                    
