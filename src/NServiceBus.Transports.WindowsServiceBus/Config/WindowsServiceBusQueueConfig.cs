namespace NServiceBus.Config
{
	using System.Configuration;
	using NServiceBus.Unicast.Queuing.WindowsServiceBus;

	public class WindowsServiceBusQueueConfig : ConfigurationSection
	{
		[ConfigurationProperty("QueueName", IsRequired = false, DefaultValue = null)]
		public string QueueName
		{
			get
			{
				return (string)this["QueueName"];
			}
			set
			{
				this["QueueName"] = value;
			}
		}

		[ConfigurationProperty("LockDuration", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultLockDuration)]
		public int LockDuration
		{
			get
			{
				return (int)this["LockDuration"];
			}
			set
			{
				this["LockDuration"] = value;
			}
		}

		[ConfigurationProperty( "MaxSizeInMegabytes", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultMaxSizeInMegabytes )]
		public long MaxSizeInMegabytes
		{
			 get
			 {
				 return (long)this["MaxSizeInMegabytes"];
			 }
			 set
			 {
				 this["MaxSizeInMegabytes"] = value;
			 }
		}

		[ConfigurationProperty( "RequiresDuplicateDetection", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultRequiresDuplicateDetection )]
		public bool RequiresDuplicateDetection
		{
			 get
			 {
				 return (bool)this["RequiresDuplicateDetection"];
			 }
			 set
			 {
				 this["RequiresDuplicateDetection"] = value;
			 }
		 }

		[ConfigurationProperty( "RequiresSession", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultRequiresSession )]
		public bool RequiresSession
		{
			 get
			 {
				 return (bool)this["RequiresSession"];
			 }
			 set
			 {
				 this["RequiresSession"] = value;
			 }
		}

		[ConfigurationProperty( "DefaultMessageTimeToLive", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultDefaultMessageTimeToLive )]
		public long DefaultMessageTimeToLive
		 {
			 get
			 {
				 return (long)this["DefaultMessageTimeToLive"];
			 }
			 set
			 {
				 this["DefaultMessageTimeToLive"] = value;
			 }
		 }

		[ConfigurationProperty( "EnableDeadLetteringOnMessageExpiration", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultEnableDeadLetteringOnMessageExpiration )]
		public bool EnableDeadLetteringOnMessageExpiration
		{
			 get
			 {
				 return (bool)this["EnableDeadLetteringOnMessageExpiration"];
			 }
			 set
			 {
				 this["EnableDeadLetteringOnMessageExpiration"] = value;
			 }
		}

		[ConfigurationProperty( "EnableDeadLetteringOnFilterEvaluationExceptions", IsRequired = false, DefaultValue = WindowsServicebusDefaults.EnableDeadLetteringOnFilterEvaluationExceptions )]
		public bool EnableDeadLetteringOnFilterEvaluationExceptions
		{
			 get
			 {
				 return (bool)this["EnableDeadLetteringOnFilterEvaluationExceptions"];
			 }
			 set
			 {
				 this["EnableDeadLetteringOnFilterEvaluationExceptions"] = value;
			 }
		}




		[ConfigurationProperty( "DuplicateDetectionHistoryTimeWindow", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultDuplicateDetectionHistoryTimeWindow )]
		public int DuplicateDetectionHistoryTimeWindow
		{
			 get
			 {
				 return (int)this["DuplicateDetectionHistoryTimeWindow"];
			 }
			 set
			 {
				 this["DuplicateDetectionHistoryTimeWindow"] = value;
			 }
		}

		[ConfigurationProperty( "MaxDeliveryCount", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultMaxDeliveryCount )]
		public int MaxDeliveryCount
		{
			 get
			 {
				 return (int)this["MaxDeliveryCount"];
			 }
			 set
			 {
				 this["MaxDeliveryCount"] = value;
			 }
		}

		[ConfigurationProperty( "EnableBatchedOperations", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultEnableBatchedOperations )]
		public bool EnableBatchedOperations
		{
			 get
			 {
				 return (bool)this["EnableBatchedOperations"];
			 }
			 set
			 {
				 this["EnableBatchedOperations"] = value;
			 }
		}

		//[ConfigurationProperty( "QueuePerInstance", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultQueuePerInstance )]
		//public bool QueuePerInstance
		//{
		//	get
		//	{
		//		return (bool)this["QueuePerInstance"];
		//	}
		//	set
		//	{
		//		this["QueuePerInstance"] = value;
		//	}
		//}

		[ConfigurationProperty( "ServerWaitTime", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultServerWaitTime )]
		public int ServerWaitTime
		{
			get
			{
				return (int)this["ServerWaitTime"];
			}
			set
			{
				this["ServerWaitTime"] = value;
			}
		}

		[ConfigurationProperty( "ConnectivityMode", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultConnectivityMode )]
		public string ConnectivityMode
		{
			get
			{
				return (string)this["ConnectivityMode"];
			}
			set
			{
				this["ConnectivityMode"] = value;
			}
		}

		[ConfigurationProperty( "BatchSize", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultBatchSize )]
		public int BatchSize
		{
			get
			{
				return (int)this["BatchSize"];
			}
			set
			{
				this["BatchSize"] = value;
			}
		}

		[ConfigurationProperty( "BackoffTimeInSeconds", IsRequired = false, DefaultValue = WindowsServicebusDefaults.DefaultBackoffTimeInSeconds )]
		public int BackoffTimeInSeconds
		{
			get
			{
				return (int)this["BackoffTimeInSeconds"];
			}
			set
			{
				this["BackoffTimeInSeconds"] = value;
			}
		}
   }
}