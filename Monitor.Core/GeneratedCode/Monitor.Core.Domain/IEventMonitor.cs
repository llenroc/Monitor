﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Monitor.Core.Domain
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public interface IEventMonitor 
	{
		Guid Id { get;set; }

		IList<IMonitoredEvent> MonitoredEvents { get;set; }

	}
}
