#pragma warning disable 1717
namespace Org.Apache.Http.Conn.Params
{
		/// <java-name>
		/// org/apache/http/conn/params/ConnRouteParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRouteParams", AccessFlags = 33)]
		public partial class ConnRouteParams : global::Org.Apache.Http.Conn.Params.IConnRoutePNames
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_HOST
				/// </java-name>
				[Dot42.DexImport("NO_HOST", "Lorg/apache/http/HttpHost;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpHost NO_HOST;
				/// <java-name>
				/// NO_ROUTE
				/// </java-name>
				[Dot42.DexImport("NO_ROUTE", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Conn.Routing.HttpRoute NO_ROUTE;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ConnRouteParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultProxy
				/// </java-name>
				[Dot42.DexImport("getDefaultProxy", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/HttpHost;", AccessFlags = 9)]
				public static global::Org.Apache.Http.HttpHost GetDefaultProxy(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// setDefaultProxy
				/// </java-name>
				[Dot42.DexImport("setDefaultProxy", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/HttpHost;)V", AccessFlags = 9)]
				public static void SetDefaultProxy(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getForcedRoute
				/// </java-name>
				[Dot42.DexImport("getForcedRoute", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Routing.HttpRoute GetForcedRoute(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <java-name>
				/// setForcedRoute
				/// </java-name>
				[Dot42.DexImport("setForcedRoute", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 9)]
				public static void SetForcedRoute(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "(Lorg/apache/http/params/HttpParams;)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetLocalAddress(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// setLocalAddress
				/// </java-name>
				[Dot42.DexImport("setLocalAddress", "(Lorg/apache/http/params/HttpParams;Ljava/net/InetAddress;)V", AccessFlags = 9)]
				public static void SetLocalAddress(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerParamBean", AccessFlags = 33)]
		public partial class ConnManagerParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ConnManagerParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTimeout
				/// </java-name>
				[Dot42.DexImport("setTimeout", "(J)V", AccessFlags = 1)]
				public virtual void SetTimeout(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxTotalConnections
				/// </java-name>
				[Dot42.DexImport("setMaxTotalConnections", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxTotalConnections(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionsPerRoute
				/// </java-name>
				[Dot42.DexImport("setConnectionsPerRoute", "(Lorg/apache/http/conn/params/ConnPerRouteBean;)V", AccessFlags = 1)]
				public virtual void SetConnectionsPerRoute(global::Org.Apache.Http.Conn.Params.ConnPerRouteBean connPerRouteBean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnManagerParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnRouteParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRouteParamBean", AccessFlags = 33)]
		public partial class ConnRouteParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ConnRouteParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultProxy
				/// </java-name>
				[Dot42.DexImport("setDefaultProxy", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void SetDefaultProxy(global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLocalAddress
				/// </java-name>
				[Dot42.DexImport("setLocalAddress", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void SetLocalAddress(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setForcedRoute
				/// </java-name>
				[Dot42.DexImport("setForcedRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 1)]
				public virtual void SetForcedRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnRouteParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnManagerPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TIMEOUT
				/// </java-name>
				[Dot42.DexImport("TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TIMEOUT = "http.conn-manager.timeout";
				/// <java-name>
				/// MAX_CONNECTIONS_PER_ROUTE
				/// </java-name>
				[Dot42.DexImport("MAX_CONNECTIONS_PER_ROUTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_CONNECTIONS_PER_ROUTE = "http.conn-manager.max-per-route";
				/// <java-name>
				/// MAX_TOTAL_CONNECTIONS
				/// </java-name>
				[Dot42.DexImport("MAX_TOTAL_CONNECTIONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_TOTAL_CONNECTIONS = "http.conn-manager.max-total";
		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerPNames", AccessFlags = 1537)]
		public partial interface IConnManagerPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnRoutePNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRoutePNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnRoutePNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_PROXY
				/// </java-name>
				[Dot42.DexImport("DEFAULT_PROXY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_PROXY = "http.route.default-proxy";
				/// <java-name>
				/// LOCAL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("LOCAL_ADDRESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOCAL_ADDRESS = "http.route.local-address";
				/// <java-name>
				/// FORCED_ROUTE
				/// </java-name>
				[Dot42.DexImport("FORCED_ROUTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FORCED_ROUTE = "http.route.forced-route";
		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnRoutePNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnRoutePNames", AccessFlags = 1537)]
		public partial interface IConnRoutePNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnConnectionParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnConnectionParamBean", AccessFlags = 33)]
		public partial class ConnConnectionParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ConnConnectionParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxStatusLineGarbage
				/// </java-name>
				[Dot42.DexImport("setMaxStatusLineGarbage", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxStatusLineGarbage(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnConnectionParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnConnectionPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnConnectionPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_STATUS_LINE_GARBAGE
				/// </java-name>
				[Dot42.DexImport("MAX_STATUS_LINE_GARBAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_STATUS_LINE_GARBAGE = "http.connection.max-status-line-garbage";
		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnConnectionPNames", AccessFlags = 1537)]
		public partial interface IConnConnectionPNames
 /* scope: __dot42__ */ 
		{
		}

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
				int GetMaxForRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/params/ConnPerRouteBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnPerRouteBean", AccessFlags = 49)]
		public sealed partial class ConnPerRouteBean : global::Org.Apache.Http.Conn.Params.IConnPerRoute
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_MAX_CONNECTIONS_PER_ROUTE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_MAX_CONNECTIONS_PER_ROUTE", "I", AccessFlags = 25)]
				public const int DEFAULT_MAX_CONNECTIONS_PER_ROUTE = 2;
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ConnPerRouteBean(int int32) /* MethodBuilder.Create */ 
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
				public void SetDefaultMaxPerRoute(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxForRoute
				/// </java-name>
				[Dot42.DexImport("setMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;I)V", AccessFlags = 1)]
				public void SetMaxForRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxForRoute
				/// </java-name>
				[Dot42.DexImport("getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I", AccessFlags = 1)]
				public int GetMaxForRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// org/apache/http/conn/params/ConnManagerParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/params/ConnManagerParams", AccessFlags = 49)]
		public sealed partial class ConnManagerParams : global::Org.Apache.Http.Conn.Params.IConnManagerPNames
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_MAX_TOTAL_CONNECTIONS
				/// </java-name>
				[Dot42.DexImport("DEFAULT_MAX_TOTAL_CONNECTIONS", "I", AccessFlags = 25)]
				public const int DEFAULT_MAX_TOTAL_CONNECTIONS = 20;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnManagerParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTimeout
				/// </java-name>
				[Dot42.DexImport("getTimeout", "(Lorg/apache/http/params/HttpParams;)J", AccessFlags = 9)]
				public static long GetTimeout(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setTimeout
				/// </java-name>
				[Dot42.DexImport("setTimeout", "(Lorg/apache/http/params/HttpParams;J)V", AccessFlags = 9)]
				public static void SetTimeout(global::Org.Apache.Http.Params.IHttpParams httpParams, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxConnectionsPerRoute
				/// </java-name>
				[Dot42.DexImport("setMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/params/ConnPerRoute;)V", AccessFlags = 9)]
				public static void SetMaxConnectionsPerRoute(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Conn.Params.IConnPerRoute connPerRoute) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxConnectionsPerRoute
				/// </java-name>
				[Dot42.DexImport("getMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/conn/params/ConnPerRoute;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Params.IConnPerRoute GetMaxConnectionsPerRoute(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Params.IConnPerRoute);
				}

				/// <java-name>
				/// setMaxTotalConnections
				/// </java-name>
				[Dot42.DexImport("setMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetMaxTotalConnections(global::Org.Apache.Http.Params.IHttpParams httpParams, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxTotalConnections
				/// </java-name>
				[Dot42.DexImport("getMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetMaxTotalConnections(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

}

