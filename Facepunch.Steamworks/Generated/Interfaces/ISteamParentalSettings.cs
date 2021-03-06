using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamParentalSettings : SteamInterface
	{
		public override string InterfaceName => "STEAMPARENTALSETTINGS_INTERFACE_VERSION001";
		
		public override void InitInternals()
		{
			_BIsParentalLockEnabled = Marshal.GetDelegateForFunctionPointer<FBIsParentalLockEnabled>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 0 ) ) );
			_BIsParentalLockLocked = Marshal.GetDelegateForFunctionPointer<FBIsParentalLockLocked>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 8 ) ) );
			_BIsAppBlocked = Marshal.GetDelegateForFunctionPointer<FBIsAppBlocked>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 16 ) ) );
			_BIsAppInBlockList = Marshal.GetDelegateForFunctionPointer<FBIsAppInBlockList>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 24 ) ) );
			_BIsFeatureBlocked = Marshal.GetDelegateForFunctionPointer<FBIsFeatureBlocked>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 32 ) ) );
			_BIsFeatureInBlockList = Marshal.GetDelegateForFunctionPointer<FBIsFeatureInBlockList>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 40 ) ) );
		}
		internal override void Shutdown()
		{
			base.Shutdown();
			
			_BIsParentalLockEnabled = null;
			_BIsParentalLockLocked = null;
			_BIsAppBlocked = null;
			_BIsAppInBlockList = null;
			_BIsFeatureBlocked = null;
			_BIsFeatureInBlockList = null;
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FBIsParentalLockEnabled( IntPtr self );
		private FBIsParentalLockEnabled _BIsParentalLockEnabled;
		
		#endregion
		internal bool BIsParentalLockEnabled()
		{
			return _BIsParentalLockEnabled( Self );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FBIsParentalLockLocked( IntPtr self );
		private FBIsParentalLockLocked _BIsParentalLockLocked;
		
		#endregion
		internal bool BIsParentalLockLocked()
		{
			return _BIsParentalLockLocked( Self );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FBIsAppBlocked( IntPtr self, AppId nAppID );
		private FBIsAppBlocked _BIsAppBlocked;
		
		#endregion
		internal bool BIsAppBlocked( AppId nAppID )
		{
			return _BIsAppBlocked( Self, nAppID );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FBIsAppInBlockList( IntPtr self, AppId nAppID );
		private FBIsAppInBlockList _BIsAppInBlockList;
		
		#endregion
		internal bool BIsAppInBlockList( AppId nAppID )
		{
			return _BIsAppInBlockList( Self, nAppID );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FBIsFeatureBlocked( IntPtr self, ParentalFeature eFeature );
		private FBIsFeatureBlocked _BIsFeatureBlocked;
		
		#endregion
		internal bool BIsFeatureBlocked( ParentalFeature eFeature )
		{
			return _BIsFeatureBlocked( Self, eFeature );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FBIsFeatureInBlockList( IntPtr self, ParentalFeature eFeature );
		private FBIsFeatureInBlockList _BIsFeatureInBlockList;
		
		#endregion
		internal bool BIsFeatureInBlockList( ParentalFeature eFeature )
		{
			return _BIsFeatureInBlockList( Self, eFeature );
		}
		
	}
}
