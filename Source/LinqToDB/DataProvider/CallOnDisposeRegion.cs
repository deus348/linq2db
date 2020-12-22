using System;

namespace LinqToDB
{
	/// <summary>
	/// Implements disposable region, which will call provided action, if region execution terminated due to
	/// exception.
	/// </summary>
	internal class CallOnDisposeRegion : IDisposable
	{
		private readonly Action _action;

		public CallOnDisposeRegion(Action action)
		{
			_action = action;
		}

		void IDisposable.Dispose() => _action();
	}
}
