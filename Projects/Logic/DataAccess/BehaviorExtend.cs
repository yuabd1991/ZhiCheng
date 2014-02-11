using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.DataAccess
{
	/// <summary>
	/// Behavior 扩展
	/// </summary>
	//public class BehaviorExtend : IServiceBehavior
	public class BehaviorExtend
	{

		public dynamic _db = null;

		//public BehaviorExtend()
		//{
		//    if (OperationContext.Current != null)
		//    {
		//        string[] array = OperationContext.Current.IncomingMessageHeaders.Action.Split('/');
		//    }
		//}

		//#region IServiceBehavior 成员

		//public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
		//{

		//}

		//public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
		//{

		//    //错误日志扩展
		//    foreach (ChannelDispatcher dispatcher in serviceHostBase.ChannelDispatchers)
		//    {
		//        var hanler = new FaultHandler();

		//        dispatcher.ErrorHandlers.Add(hanler);

		//        foreach (EndpointDispatcher endpoint in dispatcher.Endpoints)
		//        {
		//            foreach (DispatchOperation operation in endpoint.DispatchRuntime.Operations)
		//            {
		//                operation.ParameterInspectors.Add(new InterfaceMonitor.Inspector());

		//            }
		//        }
		//    }
		//}


		//public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
		//{

		//}

		//#endregion
	}
}