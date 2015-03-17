using Anycmd.Xacml.Interfaces;

// ReSharper disable once CheckNamespace
namespace Anycmd.Xacml.Runtime.Functions
{
	/// <summary>
	/// Function implementation, in order to check the function behavior use the value of the Id
	/// property to search the function in the specification document.
	/// </summary>
	public class DnsNameRegexpMatch : RegexpMatchBase
	{
		#region IFunction Members

		/// <summary>
		/// The id of the function, used only for notification.
		/// </summary>
		public override string Id
		{
			get{ return Consts.Schema2.InternalFunctions.DnsNameRegexpMatch; }
		}

		/// <summary>
		/// The data type for which the function is defined.
		/// </summary>
		public override IDataType DataType
		{
			get{ return DataTypeDescriptor.DnsName; }
		}

		#endregion
	}
}
