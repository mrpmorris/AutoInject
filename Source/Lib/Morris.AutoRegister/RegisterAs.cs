﻿namespace Morris.AutoRegister;

/// <summary>
/// Specifies what should be used as the service key.
/// </summary>
#if PublicContracts
public
#else
internal
#endif
enum RegisterAs
{
	/// <summary>
	/// The service key will be the type specified in the filter criteria.
	/// </summary>
	SearchedType,
	/// <summary>
	/// The service key will be the type specified in the filter criteria as a closed-generic type. E.g. List&lt;int&gt; rather than List&lt;&gt;.
	/// </summary>
	SearchedTypeAsClosedGeneric,
	/// <summary>
	/// The type of the implementing class will be used as the key.
	/// </summary>
	ImplementingClass,
	/// <summary>
	/// A service key will registered for the first interface
	/// found declared on the class discovered.
	/// </summary>
	FirstDiscoveredInterfaceOnClass,
	/// <summary>
	/// The exact interface type or class type that matched the search criteria will be used as the service key.
	/// </summary>
	DiscoveredType
}
