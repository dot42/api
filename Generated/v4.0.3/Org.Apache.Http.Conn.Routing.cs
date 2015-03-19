#pragma warning disable 1717
namespace Org.Apache.Http.Conn.Routing
{
		/// <java-name>
		/// org/apache/http/conn/routing/HttpRoutePlanner
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/HttpRoutePlanner", AccessFlags = 1537)]
		public partial interface IHttpRoutePlanner
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/routing/HttpRouteDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/HttpRouteDirector", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IHttpRouteDirectorConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNREACHABLE
				/// </java-name>
				[Dot42.DexImport("UNREACHABLE", "I", AccessFlags = 25)]
				public const int UNREACHABLE = -1;
				/// <java-name>
				/// COMPLETE
				/// </java-name>
				[Dot42.DexImport("COMPLETE", "I", AccessFlags = 25)]
				public const int COMPLETE = 0;
				/// <java-name>
				/// CONNECT_TARGET
				/// </java-name>
				[Dot42.DexImport("CONNECT_TARGET", "I", AccessFlags = 25)]
				public const int CONNECT_TARGET = 1;
				/// <java-name>
				/// CONNECT_PROXY
				/// </java-name>
				[Dot42.DexImport("CONNECT_PROXY", "I", AccessFlags = 25)]
				public const int CONNECT_PROXY = 2;
				/// <java-name>
				/// TUNNEL_TARGET
				/// </java-name>
				[Dot42.DexImport("TUNNEL_TARGET", "I", AccessFlags = 25)]
				public const int TUNNEL_TARGET = 3;
				/// <java-name>
				/// TUNNEL_PROXY
				/// </java-name>
				[Dot42.DexImport("TUNNEL_PROXY", "I", AccessFlags = 25)]
				public const int TUNNEL_PROXY = 4;
				/// <java-name>
				/// LAYER_PROTOCOL
				/// </java-name>
				[Dot42.DexImport("LAYER_PROTOCOL", "I", AccessFlags = 25)]
				public const int LAYER_PROTOCOL = 5;
		}

		/// <java-name>
		/// org/apache/http/conn/routing/HttpRouteDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/HttpRouteDirector", AccessFlags = 1537)]
		public partial interface IHttpRouteDirector
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// nextStep
				/// </java-name>
				[Dot42.DexImport("nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 1025)]
				int NextStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo, global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/routing/RouteTracker
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/RouteTracker", AccessFlags = 49)]
		public sealed partial class RouteTracker : global::Org.Apache.Http.Conn.Routing.IRouteInfo, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public RouteTracker(global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 1)]
				public RouteTracker(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connectTarget
				/// </java-name>
				[Dot42.DexImport("connectTarget", "(Z)V", AccessFlags = 17)]
				public void ConnectTarget(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connectProxy
				/// </java-name>
				[Dot42.DexImport("connectProxy", "(Lorg/apache/http/HttpHost;Z)V", AccessFlags = 17)]
				public void ConnectProxy(global::Org.Apache.Http.HttpHost httpHost, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(Z)V", AccessFlags = 17)]
				public void TunnelTarget(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;Z)V", AccessFlags = 17)]
				public void TunnelProxy(global::Org.Apache.Http.HttpHost httpHost, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Z)V", AccessFlags = 17)]
				public void LayerProtocol(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
				public global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getHopCount
				/// </java-name>
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
				public int GetHopCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHopTarget
				/// </java-name>
				[Dot42.DexImport("getHopTarget", "(I)Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetHopTarget(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// getProxyHost
				/// </java-name>
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetProxyHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 17)]
				public bool IsConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTunnelType
				/// </java-name>
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType GetTunnelType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType);
				}

				/// <java-name>
				/// isTunnelled
				/// </java-name>
				[Dot42.DexImport("isTunnelled", "()Z", AccessFlags = 17)]
				public bool IsTunnelled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLayerType
				/// </java-name>
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType GetLayerType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType);
				}

				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 17)]
				public bool IsLayered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 17)]
				public bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toRoute
				/// </java-name>
				[Dot42.DexImport("toRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.HttpRoute ToRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RouteTracker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTargetHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost TargetHost
				{
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetTargetHost(); }
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
						get{ return GetLocalAddress(); }
				}

				/// <java-name>
				/// getHopCount
				/// </java-name>
				public int HopCount
				{
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
						get{ return GetHopCount(); }
				}

				/// <java-name>
				/// getProxyHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost ProxyHost
				{
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetProxyHost(); }
				}

				/// <java-name>
				/// getTunnelType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType TunnelType
				{
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
						get{ return GetTunnelType(); }
				}

				/// <java-name>
				/// getLayerType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType LayerType
				{
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
						get{ return GetLayerType(); }
				}

		}

		/// <java-name>
		/// org/apache/http/conn/routing/HttpRoute
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/HttpRoute", AccessFlags = 49)]
		public sealed partial class HttpRoute : global::Org.Apache.Http.Conn.Routing.IRouteInfo, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;[Lorg/apache/http/HttpHost;ZLorg" +
    "/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/Rou" +
    "teInfo$LayerType;)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.InetAddress inetAddress, global::Org.Apache.Http.HttpHost[] httpHost1, bool boolean, global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType iRouteInfo_TunnelType, global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType iRouteInfo_LayerType) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;ZLorg/" +
    "apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/Rout" +
    "eInfo$LayerType;)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.InetAddress inetAddress, global::Org.Apache.Http.HttpHost httpHost1, bool boolean, global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType iRouteInfo_TunnelType, global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType iRouteInfo_LayerType) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Z)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.InetAddress inetAddress, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;Z)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.InetAddress inetAddress, global::Org.Apache.Http.HttpHost httpHost1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
				public global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getHopCount
				/// </java-name>
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
				public int GetHopCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHopTarget
				/// </java-name>
				[Dot42.DexImport("getHopTarget", "(I)Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetHopTarget(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// getProxyHost
				/// </java-name>
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetProxyHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// getTunnelType
				/// </java-name>
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType GetTunnelType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType);
				}

				/// <java-name>
				/// isTunnelled
				/// </java-name>
				[Dot42.DexImport("isTunnelled", "()Z", AccessFlags = 17)]
				public bool IsTunnelled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLayerType
				/// </java-name>
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType GetLayerType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType);
				}

				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 17)]
				public bool IsLayered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 17)]
				public bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpRoute() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTargetHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost TargetHost
				{
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetTargetHost(); }
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
						get{ return GetLocalAddress(); }
				}

				/// <java-name>
				/// getHopCount
				/// </java-name>
				public int HopCount
				{
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
						get{ return GetHopCount(); }
				}

				/// <java-name>
				/// getProxyHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost ProxyHost
				{
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetProxyHost(); }
				}

				/// <java-name>
				/// getTunnelType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType TunnelType
				{
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
						get{ return GetTunnelType(); }
				}

				/// <java-name>
				/// getLayerType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType LayerType
				{
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
						get{ return GetLayerType(); }
				}

		}

		/// <java-name>
		/// org/apache/http/conn/routing/RouteInfo
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/RouteInfo", AccessFlags = 1537)]
		public partial interface IRouteInfo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
				global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
				global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getHopCount
				/// </java-name>
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 1025)]
				int GetHopCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getHopTarget
				/// </java-name>
				[Dot42.DexImport("getHopTarget", "(I)Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
				global::Org.Apache.Http.HttpHost GetHopTarget(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProxyHost
				/// </java-name>
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
				global::Org.Apache.Http.HttpHost GetProxyHost() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTunnelType
				/// </java-name>
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType GetTunnelType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isTunnelled
				/// </java-name>
				[Dot42.DexImport("isTunnelled", "()Z", AccessFlags = 1025)]
				bool IsTunnelled() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLayerType
				/// </java-name>
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType GetLayerType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 1025)]
				bool IsLayered() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1025)]
				bool IsSecure() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/routing/RouteInfo$LayerType
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/RouteInfo$LayerType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Lorg/apache/http/conn/routing/RouteInfo$LayerType;>;")]
		public sealed class IRouteInfo_LayerType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LAYERED
				/// </java-name>
				[Dot42.DexImport("LAYERED", "Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 16409)]
				public static readonly global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType LAYERED;
				/// <java-name>
				/// PLAIN
				/// </java-name>
				[Dot42.DexImport("PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 16409)]
				public static readonly global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType PLAIN;
				private IRouteInfo_LayerType() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType);
				}

		}

		/// <java-name>
		/// org/apache/http/conn/routing/RouteInfo$TunnelType
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/RouteInfo$TunnelType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Lorg/apache/http/conn/routing/RouteInfo$TunnelType;>;")]
		public sealed class IRouteInfo_TunnelType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PLAIN
				/// </java-name>
				[Dot42.DexImport("PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 16409)]
				public static readonly global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType PLAIN;
				/// <java-name>
				/// TUNNELLED
				/// </java-name>
				[Dot42.DexImport("TUNNELLED", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 16409)]
				public static readonly global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType TUNNELLED;
				private IRouteInfo_TunnelType() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType);
				}

		}

		/// <java-name>
		/// org/apache/http/conn/routing/BasicRouteDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/BasicRouteDirector", AccessFlags = 33)]
		public partial class BasicRouteDirector : global::Org.Apache.Http.Conn.Routing.IHttpRouteDirector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicRouteDirector() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextStep
				/// </java-name>
				[Dot42.DexImport("nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 1)]
				public virtual int NextStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo, global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// firstStep
				/// </java-name>
				[Dot42.DexImport("firstStep", "(Lorg/apache/http/conn/routing/RouteInfo;)I", AccessFlags = 4)]
				protected internal virtual int FirstStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// directStep
				/// </java-name>
				[Dot42.DexImport("directStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 4)]
				protected internal virtual int DirectStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo, global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// proxiedStep
				/// </java-name>
				[Dot42.DexImport("proxiedStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 4)]
				protected internal virtual int ProxiedStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo, global::Org.Apache.Http.Conn.Routing.IRouteInfo routeInfo1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

}

