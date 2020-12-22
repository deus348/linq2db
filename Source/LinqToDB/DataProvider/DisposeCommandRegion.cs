using System;
using LinqToDB.Data;

namespace LinqToDB
{
	/// <summary>
	/// Implements disposable region, which will call provided action, if region execution terminated due to
	/// exception.
	/// </summary>
	internal class DisposeCommandRegion : IDisposable
	{
		private readonly DataConnection _dataConnection;

		public DisposeCommandRegion(DataConnection dataConnection)
		{
			_dataConnection = dataConnection;
		}

		void IDisposable.Dispose() => _dataConnection.DisposeCommand();
	}
}
