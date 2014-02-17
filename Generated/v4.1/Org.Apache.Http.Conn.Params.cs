// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Conn.Params.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#pragma warning disable 1717
namespace Org.Apache.Http.Conn.Params
{
		/// <summary>
		/// <para>This interface is intended for looking up maximum number of connections allowed for for a given route. This class can be used by pooling connection managers for a fine-grained control of connections on a per route basis.</para><para><para></para><para></para><title>Revision:</title><para>651813 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnPerRoute
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnPerRoute", AccessFlags = 1537)]
		public partial interface IConnPerRoute
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getMaxForRoute
				/// </java-name>
				[Dot42.DexImport("getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I", AccessFlags = 1025)]
				int GetMaxForRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Allows for setting parameters relating to connections on HttpParams. This class ensures that the values set on the params are type-safe. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnConnectionParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnConnectionParamBean", AccessFlags = 33)]
		public partial class ConnConnectionParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ConnConnectionParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>ConnConnectionPNames::MAX_STATUS_LINE_GARBAGE </para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxStatusLineGarbage
				/// </java-name>
				[Dot42.DexImport("setMaxStatusLineGarbage", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxStatusLineGarbage(int maxStatusLineGarbage) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnConnectionParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Parameter names for routing in HttpConn.</para><para><para></para><title>Revision:</title><para>613656 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnRoutePNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRoutePNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnRoutePNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Parameter for the default proxy. The default value will be used by some HttpRoutePlanner implementations, in particular the default implementation. </para><para>This parameter expects a value of type org.apache.http.HttpHost. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_PROXY
				/// </java-name>
				[Dot42.DexImport("DEFAULT_PROXY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_PROXY = "http.route.default-proxy";
				/// <summary>
				/// <para>Parameter for the local address. On machines with multiple network interfaces, this parameter can be used to select the network interface from which the connection originates. It will be interpreted by the standard HttpRoutePlanner implementations, in particular the default implementation. </para><para>This parameter expects a value of type java.net.InetAddress. </para>        
				/// </summary>
				/// <java-name>
				/// LOCAL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("LOCAL_ADDRESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOCAL_ADDRESS = "http.route.local-address";
				/// <summary>
				/// <para>Parameter for an forced route. The forced route will be interpreted by the standard HttpRoutePlanner implementations. Instead of computing a route, the given forced route will be returned, even if it points to the wrong target host. </para><para>This parameter expects a value of type HttpRoute. </para>        
				/// </summary>
				/// <java-name>
				/// FORCED_ROUTE
				/// </java-name>
				[Dot42.DexImport("FORCED_ROUTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FORCED_ROUTE = "http.route.forced-route";
		}

		/// <summary>
		/// <para>Parameter names for routing in HttpConn.</para><para><para></para><title>Revision:</title><para>613656 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnRoutePNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRoutePNames", AccessFlags = 1537)]
		public partial interface IConnRoutePNames
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Allows for setting parameters relating to connection managers on HttpParams. This class ensures that the values set on the params are type-safe. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerParamBean", AccessFlags = 33)]
		public partial class ConnManagerParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ConnManagerParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTimeout
				/// </java-name>
				[Dot42.DexImport("setTimeout", "(J)V", AccessFlags = 1)]
				public virtual void SetTimeout(long timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>ConnManagerPNames::MAX_TOTAL_CONNECTIONS </para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxTotalConnections
				/// </java-name>
				[Dot42.DexImport("setMaxTotalConnections", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxTotalConnections(int maxConnections) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>ConnManagerPNames::MAX_CONNECTIONS_PER_ROUTE </para></para>        
				/// </summary>
				/// <java-name>
				/// setConnectionsPerRoute
				/// </java-name>
				[Dot42.DexImport("setConnectionsPerRoute", "(Lorg/apache/http/conn/params/ConnPerRouteBean;)V", AccessFlags = 1)]
				public virtual void SetConnectionsPerRoute(global::Org.Apache.Http.Conn.Params.ConnPerRouteBean connPerRoute) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnManagerParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Parameter names for connection managers in HttpConn.</para><para><para></para><title>Revision:</title><para>658781 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnManagerPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Defines the timeout in milliseconds used when retrieving an instance of org.apache.http.conn.ManagedClientConnection from the org.apache.http.conn.ClientConnectionManager. </para><para>This parameter expects a value of type Long. </para>        
				/// </summary>
				/// <java-name>
				/// TIMEOUT
				/// </java-name>
				[Dot42.DexImport("TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TIMEOUT = "http.conn-manager.timeout";
				/// <summary>
				/// <para>Defines the maximum number of connections per route. This limit is interpreted by client connection managers and applies to individual manager instances. </para><para>This parameter expects a value of type ConnPerRoute. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_CONNECTIONS_PER_ROUTE
				/// </java-name>
				[Dot42.DexImport("MAX_CONNECTIONS_PER_ROUTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_CONNECTIONS_PER_ROUTE = "http.conn-manager.max-per-route";
				/// <summary>
				/// <para>Defines the maximum number of connections in total. This limit is interpreted by client connection managers and applies to individual manager instances. </para><para>This parameter expects a value of type Integer. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_TOTAL_CONNECTIONS
				/// </java-name>
				[Dot42.DexImport("MAX_TOTAL_CONNECTIONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_TOTAL_CONNECTIONS = "http.conn-manager.max-total";
		}

		/// <summary>
		/// <para>Parameter names for connection managers in HttpConn.</para><para><para></para><title>Revision:</title><para>658781 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerPNames", AccessFlags = 1537)]
		public partial interface IConnManagerPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Allows for setting parameters relating to connection routes on HttpParams. This class ensures that the values set on the params are type-safe. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnRouteParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRouteParamBean", AccessFlags = 33)]
		public partial class ConnRouteParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ConnRouteParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>ConnRoutePNames::DEFAULT_PROXY </para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultProxy
				/// </java-name>
				[Dot42.DexImport("setDefaultProxy", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void SetDefaultProxy(global::Org.Apache.Http.HttpHost defaultProxy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>ConnRoutePNames::LOCAL_ADDRESS </para></para>        
				/// </summary>
				/// <java-name>
				/// setLocalAddress
				/// </java-name>
				[Dot42.DexImport("setLocalAddress", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void SetLocalAddress(global::Java.Net.InetAddress address) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>ConnRoutePNames::FORCED_ROUTE </para></para>        
				/// </summary>
				/// <java-name>
				/// setForcedRoute
				/// </java-name>
				[Dot42.DexImport("setForcedRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 1)]
				public virtual void SetForcedRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnRouteParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This class maintains a map of HTTP routes to maximum number of connections allowed for those routes. This class can be used by pooling connection managers for a fine-grained control of connections on a per route basis.</para><para><para></para><para></para><title>Revision:</title><para>652947 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnPerRouteBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnPerRouteBean", AccessFlags = 49)]
		public sealed partial class ConnPerRouteBean : global::Org.Apache.Http.Conn.Params.IConnPerRoute
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default maximum number of connections allowed per host </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_MAX_CONNECTIONS_PER_ROUTE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_MAX_CONNECTIONS_PER_ROUTE", "I", AccessFlags = 25)]
				public const int DEFAULT_MAX_CONNECTIONS_PER_ROUTE = 2;
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ConnPerRouteBean(int defaultMax) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnPerRouteBean() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultMax
				/// </java-name>
				[Dot42.DexImport("getDefaultMax", "()I", AccessFlags = 1)]
				public int GetDefaultMax() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDefaultMaxPerRoute
				/// </java-name>
				[Dot42.DexImport("setDefaultMaxPerRoute", "(I)V", AccessFlags = 1)]
				public void SetDefaultMaxPerRoute(int max) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxForRoute
				/// </java-name>
				[Dot42.DexImport("setMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;I)V", AccessFlags = 1)]
				public void SetMaxForRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute route, int max) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxForRoute
				/// </java-name>
				[Dot42.DexImport("getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I", AccessFlags = 1)]
				public int GetMaxForRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setMaxForRoutes
				/// </java-name>
				[Dot42.DexImport("setMaxForRoutes", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Integer;>;)V")]
				public void SetMaxForRoutes(global::Java.Util.IMap<global::Org.Apache.Http.Conn.Routing.HttpRoute, int?> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultMax
				/// </java-name>
				public int DefaultMax
				{
				[Dot42.DexImport("getDefaultMax", "()I", AccessFlags = 1)]
						get{ return GetDefaultMax(); }
				}

		}

		/// <summary>
		/// <para>An adaptor for accessing route related parameters in HttpParams. See ConnRoutePNames for parameter name definitions.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>658785 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnRouteParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRouteParams", AccessFlags = 33)]
		public partial class ConnRouteParams : global::Org.Apache.Http.Conn.Params.IConnRoutePNames
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A special value indicating "no host". This relies on a nonsense scheme name to avoid conflicts with actual hosts. Note that this is a <b>valid</b> host. </para>        
				/// </summary>
				/// <java-name>
				/// NO_HOST
				/// </java-name>
				[Dot42.DexImport("NO_HOST", "Lorg/apache/http/HttpHost;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpHost NO_HOST;
				/// <summary>
				/// <para>A special value indicating "no route". This is a route with NO_HOST as the target. </para>        
				/// </summary>
				/// <java-name>
				/// NO_ROUTE
				/// </java-name>
				[Dot42.DexImport("NO_ROUTE", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Conn.Routing.HttpRoute NO_ROUTE;
				/// <summary>
				/// <para>Disabled default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ConnRouteParams() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the DEFAULT_PROXY parameter value. NO_HOST will be mapped to <code>null</code>, to allow unsetting in a hierarchy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default proxy set in the argument parameters, or <code>null</code> if not set </para>
				/// </returns>
				/// <java-name>
				/// getDefaultProxy
				/// </java-name>
				[Dot42.DexImport("getDefaultProxy", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/HttpHost;", AccessFlags = 9)]
				public static global::Org.Apache.Http.HttpHost GetDefaultProxy(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Sets the DEFAULT_PROXY parameter value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultProxy
				/// </java-name>
				[Dot42.DexImport("setDefaultProxy", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/HttpHost;)V", AccessFlags = 9)]
				public static void SetDefaultProxy(global::Org.Apache.Http.Params.IHttpParams @params, global::Org.Apache.Http.HttpHost proxy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the FORCED_ROUTE parameter value. NO_ROUTE will be mapped to <code>null</code>, to allow unsetting in a hierarchy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the forced route set in the argument parameters, or <code>null</code> if not set </para>
				/// </returns>
				/// <java-name>
				/// getForcedRoute
				/// </java-name>
				[Dot42.DexImport("getForcedRoute", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Routing.HttpRoute GetForcedRoute(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <summary>
				/// <para>Sets the FORCED_ROUTE parameter value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setForcedRoute
				/// </java-name>
				[Dot42.DexImport("setForcedRoute", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 9)]
				public static void SetForcedRoute(global::Org.Apache.Http.Params.IHttpParams @params, global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the LOCAL_ADDRESS parameter value. There is no special value that would automatically be mapped to <code>null</code>. You can use the wildcard address (0.0.0.0 for IPv4, :: for IPv6) to override a specific local address in a hierarchy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address set in the argument parameters, or <code>null</code> if not set </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "(Lorg/apache/http/params/HttpParams;)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetLocalAddress(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Sets the LOCAL_ADDRESS parameter value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLocalAddress
				/// </java-name>
				[Dot42.DexImport("setLocalAddress", "(Lorg/apache/http/params/HttpParams;Ljava/net/InetAddress;)V", AccessFlags = 9)]
				public static void SetLocalAddress(global::Org.Apache.Http.Params.IHttpParams @params, global::Java.Net.InetAddress local) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class represents a collection of HTTP protocol parameters applicable to client-side connection managers.</para><para><para> </para><simplesectsep></simplesectsep><para>Michael Becke</para><para></para><title>Revision:</title><para>658785 </para></para><para><para>4.0</para><para>ConnManagerPNames </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerParams", AccessFlags = 49)]
		public sealed partial class ConnManagerParams : global::Org.Apache.Http.Conn.Params.IConnManagerPNames
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default maximum number of connections allowed overall </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_MAX_TOTAL_CONNECTIONS
				/// </java-name>
				[Dot42.DexImport("DEFAULT_MAX_TOTAL_CONNECTIONS", "I", AccessFlags = 25)]
				public const int DEFAULT_MAX_TOTAL_CONNECTIONS = 20;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnManagerParams() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the timeout in milliseconds used when retrieving a org.apache.http.conn.ManagedClientConnection from the org.apache.http.conn.ClientConnectionManager.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>timeout in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getTimeout
				/// </java-name>
				[Dot42.DexImport("getTimeout", "(Lorg/apache/http/params/HttpParams;)J", AccessFlags = 9)]
				public static long GetTimeout(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the timeout in milliseconds used when retrieving a org.apache.http.conn.ManagedClientConnection from the org.apache.http.conn.ClientConnectionManager.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTimeout
				/// </java-name>
				[Dot42.DexImport("setTimeout", "(Lorg/apache/http/params/HttpParams;J)V", AccessFlags = 9)]
				public static void SetTimeout(global::Org.Apache.Http.Params.IHttpParams @params, long timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets lookup interface for maximum number of connections allowed per route.</para><para><para>ConnManagerPNames::MAX_CONNECTIONS_PER_ROUTE </para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxConnectionsPerRoute
				/// </java-name>
				[Dot42.DexImport("setMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/params/ConnPerRoute;)V", AccessFlags = 9)]
				public static void SetMaxConnectionsPerRoute(global::Org.Apache.Http.Params.IHttpParams @params, global::Org.Apache.Http.Conn.Params.IConnPerRoute connPerRoute) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns lookup interface for maximum number of connections allowed per route.</para><para><para>ConnManagerPNames::MAX_CONNECTIONS_PER_ROUTE </para></para>        
				/// </summary>
				/// <returns>
				/// <para>lookup interface for maximum number of connections allowed per route.</para>
				/// </returns>
				/// <java-name>
				/// getMaxConnectionsPerRoute
				/// </java-name>
				[Dot42.DexImport("getMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/conn/params/ConnPerRoute;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Params.IConnPerRoute GetMaxConnectionsPerRoute(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Params.IConnPerRoute);
				}

				/// <summary>
				/// <para>Sets the maximum number of connections allowed.</para><para><para>ConnManagerPNames::MAX_TOTAL_CONNECTIONS </para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxTotalConnections
				/// </java-name>
				[Dot42.DexImport("setMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetMaxTotalConnections(global::Org.Apache.Http.Params.IHttpParams @params, int maxTotalConnections) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the maximum number of connections allowed.</para><para><para>ConnManagerPNames::MAX_TOTAL_CONNECTIONS </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The maximum number of connections allowed.</para>
				/// </returns>
				/// <java-name>
				/// getMaxTotalConnections
				/// </java-name>
				[Dot42.DexImport("getMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetMaxTotalConnections(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>Parameter names for connections in HttpConn.</para><para><para></para><title>Revision:</title><para>576068 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnConnectionPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnConnectionPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Defines the maximum number of ignorable lines before we expect a HTTP response's status line. </para><para>With HTTP/1.1 persistent connections, the problem arises that broken scripts could return a wrong Content-Length (there are more bytes sent than specified). Unfortunately, in some cases, this cannot be detected after the bad response, but only before the next one. So HttpClient must be able to skip those surplus lines this way. </para><para>This parameter expects a value of type Integer. 0 disallows all garbage/empty lines before the status line. Use java.lang.Integer#MAX_VALUE for unlimited (default in lenient mode). </para>        
				/// </summary>
				/// <java-name>
				/// MAX_STATUS_LINE_GARBAGE
				/// </java-name>
				[Dot42.DexImport("MAX_STATUS_LINE_GARBAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_STATUS_LINE_GARBAGE = "http.connection.max-status-line-garbage";
		}

		/// <summary>
		/// <para>Parameter names for connections in HttpConn.</para><para><para></para><title>Revision:</title><para>576068 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/params/ConnConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnConnectionPNames", AccessFlags = 1537)]
		public partial interface IConnConnectionPNames
 /* scope: __dot42__ */ 
		{
		}

}


