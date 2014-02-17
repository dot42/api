// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Conn.Routing.cs
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
namespace Org.Apache.Http.Conn.Routing
{
		/// <summary>
		/// <para>Helps tracking the steps in establishing a route.</para><para><para></para><para></para><title>Revision:</title><para>620254 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/routing/RouteTracker
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/RouteTracker", AccessFlags = 49)]
		public sealed partial class RouteTracker : global::Org.Apache.Http.Conn.Routing.IRouteInfo, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new route tracker. The target and origin need to be specified at creation time.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public RouteTracker(global::Org.Apache.Http.HttpHost target, global::Java.Net.InetAddress local) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new tracker for the given route. Only target and origin are taken from the route, everything else remains to be tracked.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 1)]
				public RouteTracker(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tracks connecting to the target.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connectTarget
				/// </java-name>
				[Dot42.DexImport("connectTarget", "(Z)V", AccessFlags = 17)]
				public void ConnectTarget(bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tracks connecting to the first proxy.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connectProxy
				/// </java-name>
				[Dot42.DexImport("connectProxy", "(Lorg/apache/http/HttpHost;Z)V", AccessFlags = 17)]
				public void ConnectProxy(global::Org.Apache.Http.HttpHost proxy, bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tracks tunnelling to the target.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(Z)V", AccessFlags = 17)]
				public void TunnelTarget(bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tracks tunnelling to a proxy in a proxy chain. This will extend the tracked proxy chain, but it does not mark the route as tunnelled. Only end-to-end tunnels are considered there.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;Z)V", AccessFlags = 17)]
				public void TunnelProxy(global::Org.Apache.Http.HttpHost proxy, bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tracks layering a protocol.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Z)V", AccessFlags = 17)]
				public void LayerProtocol(bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target host </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Obtains the local address to connect from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
				public global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Obtains the number of hops in this route. A direct route has one hop. A route through a proxy has two hops. A route through a chain of <b>n</b> proxies has <b>n+1</b> hops.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of hops in this route </para>
				/// </returns>
				/// <java-name>
				/// getHopCount
				/// </java-name>
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
				public int GetHopCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the target of a hop in this route. The target of the last hop is the target host, the target of previous hops is the respective proxy in the chain. For a route through exactly one proxy, target of hop 0 is the proxy and target of hop 1 is the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target of the given hop</para>
				/// </returns>
				/// <java-name>
				/// getHopTarget
				/// </java-name>
				[Dot42.DexImport("getHopTarget", "(I)Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetHopTarget(int hop) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Obtains the first proxy host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first proxy in the proxy chain, or <code>null</code> if this route is direct </para>
				/// </returns>
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

				/// <summary>
				/// <para>Obtains the tunnel type of this route. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tunnelling type </para>
				/// </returns>
				/// <java-name>
				/// getTunnelType
				/// </java-name>
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType GetTunnelType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType);
				}

				/// <summary>
				/// <para>Checks whether this route is tunnelled through a proxy. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if tunnelled end-to-end through at least one proxy, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isTunnelled
				/// </java-name>
				[Dot42.DexImport("isTunnelled", "()Z", AccessFlags = 17)]
				public bool IsTunnelled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the layering type of this route. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the layering type </para>
				/// </returns>
				/// <java-name>
				/// getLayerType
				/// </java-name>
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType GetLayerType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType);
				}

				/// <summary>
				/// <para>Checks whether this route includes a layered protocol. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if layered, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 17)]
				public bool IsLayered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether this route is secure.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if secure, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 17)]
				public bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the tracked route. If a route has been tracked, it is connected. If not connected, nothing has been tracked so far.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tracked route, or <code>null</code> if nothing has been tracked so far </para>
				/// </returns>
				/// <java-name>
				/// toRoute
				/// </java-name>
				[Dot42.DexImport("toRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.HttpRoute ToRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <summary>
				/// <para>Compares this tracked route to another.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the argument is the same tracked route, <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Generates a hash code for this tracked route. Route trackers are modifiable and should therefore not be used as lookup keys. Use toRoute to obtain an unmodifiable representation of the tracked route.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains a description of the tracked route.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a human-readable representation of the tracked route </para>
				/// </returns>
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

				/// <summary>
				/// <para>Obtains the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target host </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost TargetHost
				{
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetTargetHost(); }
				}

				/// <summary>
				/// <para>Obtains the local address to connect from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
						get{ return GetLocalAddress(); }
				}

				/// <summary>
				/// <para>Obtains the number of hops in this route. A direct route has one hop. A route through a proxy has two hops. A route through a chain of <b>n</b> proxies has <b>n+1</b> hops.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of hops in this route </para>
				/// </returns>
				/// <java-name>
				/// getHopCount
				/// </java-name>
				public int HopCount
				{
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
						get{ return GetHopCount(); }
				}

				/// <summary>
				/// <para>Obtains the first proxy host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first proxy in the proxy chain, or <code>null</code> if this route is direct </para>
				/// </returns>
				/// <java-name>
				/// getProxyHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost ProxyHost
				{
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetProxyHost(); }
				}

				/// <summary>
				/// <para>Obtains the tunnel type of this route. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tunnelling type </para>
				/// </returns>
				/// <java-name>
				/// getTunnelType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType TunnelType
				{
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
						get{ return GetTunnelType(); }
				}

				/// <summary>
				/// <para>Obtains the layering type of this route. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the layering type </para>
				/// </returns>
				/// <java-name>
				/// getLayerType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType LayerType
				{
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
						get{ return GetLayerType(); }
				}

		}

		/// <summary>
		/// <para>Read-only interface for route information.</para><para><para></para><para></para><title>Revision:</title><para>652200 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/routing/RouteInfo
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/RouteInfo", AccessFlags = 1537)]
		public partial interface IRouteInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target host </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
				global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the local address to connect from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
				global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the number of hops in this route. A direct route has one hop. A route through a proxy has two hops. A route through a chain of <b>n</b> proxies has <b>n+1</b> hops.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of hops in this route </para>
				/// </returns>
				/// <java-name>
				/// getHopCount
				/// </java-name>
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 1025)]
				int GetHopCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the target of a hop in this route. The target of the last hop is the target host, the target of previous hops is the respective proxy in the chain. For a route through exactly one proxy, target of hop 0 is the proxy and target of hop 1 is the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target of the given hop</para>
				/// </returns>
				/// <java-name>
				/// getHopTarget
				/// </java-name>
				[Dot42.DexImport("getHopTarget", "(I)Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
				global::Org.Apache.Http.HttpHost GetHopTarget(int hop) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the first proxy host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first proxy in the proxy chain, or <code>null</code> if this route is direct </para>
				/// </returns>
				/// <java-name>
				/// getProxyHost
				/// </java-name>
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
				global::Org.Apache.Http.HttpHost GetProxyHost() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the tunnel type of this route. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tunnelling type </para>
				/// </returns>
				/// <java-name>
				/// getTunnelType
				/// </java-name>
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType GetTunnelType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this route is tunnelled through a proxy. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if tunnelled end-to-end through at least one proxy, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isTunnelled
				/// </java-name>
				[Dot42.DexImport("isTunnelled", "()Z", AccessFlags = 1025)]
				bool IsTunnelled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the layering type of this route. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the layering type </para>
				/// </returns>
				/// <java-name>
				/// getLayerType
				/// </java-name>
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType GetLayerType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this route includes a layered protocol. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if layered, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 1025)]
				bool IsLayered() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this route is secure.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if secure, <code>false</code> otherwise </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para>Encapsulates logic to compute a HttpRoute to a target host. Implementations may for example be based on parameters, or on the standard Java system properties. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/routing/HttpRoutePlanner
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/HttpRoutePlanner", AccessFlags = 1537)]
		public partial interface IHttpRoutePlanner
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Determines the route for a request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route that the request should take</para>
				/// </returns>
				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Provides directions on establishing a route. Implementations of this interface compare a planned route with a tracked route and indicate the next step required.</para><para><para></para><para></para><title>Revision:</title><para>620255 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/routing/HttpRouteDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/HttpRouteDirector", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IHttpRouteDirectorConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Indicates that the route can not be established at all. </para>        
				/// </summary>
				/// <java-name>
				/// UNREACHABLE
				/// </java-name>
				[Dot42.DexImport("UNREACHABLE", "I", AccessFlags = 25)]
				public const int UNREACHABLE = -1;
				/// <summary>
				/// <para>Indicates that the route is complete. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLETE
				/// </java-name>
				[Dot42.DexImport("COMPLETE", "I", AccessFlags = 25)]
				public const int COMPLETE = 0;
				/// <summary>
				/// <para>Step: open connection to target. </para>        
				/// </summary>
				/// <java-name>
				/// CONNECT_TARGET
				/// </java-name>
				[Dot42.DexImport("CONNECT_TARGET", "I", AccessFlags = 25)]
				public const int CONNECT_TARGET = 1;
				/// <summary>
				/// <para>Step: open connection to proxy. </para>        
				/// </summary>
				/// <java-name>
				/// CONNECT_PROXY
				/// </java-name>
				[Dot42.DexImport("CONNECT_PROXY", "I", AccessFlags = 25)]
				public const int CONNECT_PROXY = 2;
				/// <summary>
				/// <para>Step: tunnel through proxy to target. </para>        
				/// </summary>
				/// <java-name>
				/// TUNNEL_TARGET
				/// </java-name>
				[Dot42.DexImport("TUNNEL_TARGET", "I", AccessFlags = 25)]
				public const int TUNNEL_TARGET = 3;
				/// <summary>
				/// <para>Step: tunnel through proxy to other proxy. </para>        
				/// </summary>
				/// <java-name>
				/// TUNNEL_PROXY
				/// </java-name>
				[Dot42.DexImport("TUNNEL_PROXY", "I", AccessFlags = 25)]
				public const int TUNNEL_PROXY = 4;
				/// <summary>
				/// <para>Step: layer protocol (over tunnel). </para>        
				/// </summary>
				/// <java-name>
				/// LAYER_PROTOCOL
				/// </java-name>
				[Dot42.DexImport("LAYER_PROTOCOL", "I", AccessFlags = 25)]
				public const int LAYER_PROTOCOL = 5;
		}

		/// <summary>
		/// <para>Provides directions on establishing a route. Implementations of this interface compare a planned route with a tracked route and indicate the next step required.</para><para><para></para><para></para><title>Revision:</title><para>620255 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/routing/HttpRouteDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/routing/HttpRouteDirector", AccessFlags = 1537)]
		public partial interface IHttpRouteDirector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Provides the next step.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of the constants defined in this interface, indicating either the next step to perform, or success, or failure. 0 is for success, a negative value for failure. </para>
				/// </returns>
				/// <java-name>
				/// nextStep
				/// </java-name>
				[Dot42.DexImport("nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 1025)]
				int NextStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo plan, global::Org.Apache.Http.Conn.Routing.IRouteInfo fact) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The route for a request. Instances of this class are unmodifiable and therefore suitable for use as lookup keys.</para><para><para></para><para></para><title>Revision:</title><para>653041 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a new direct route. That is a route without a proxy.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Z)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost target, global::Java.Net.InetAddress local, bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new direct insecure route.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new route through a proxy. When using this constructor, the <code>proxy</code> MUST be given. For convenience, it is assumed that a secure connection will be layered over a tunnel through the proxy.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;Z)V", AccessFlags = 1)]
				public HttpRoute(global::Org.Apache.Http.HttpHost target, global::Java.Net.InetAddress local, global::Org.Apache.Http.HttpHost proxy, bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target host </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Obtains the local address to connect from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
				public global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Obtains the number of hops in this route. A direct route has one hop. A route through a proxy has two hops. A route through a chain of <b>n</b> proxies has <b>n+1</b> hops.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of hops in this route </para>
				/// </returns>
				/// <java-name>
				/// getHopCount
				/// </java-name>
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
				public int GetHopCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the target of a hop in this route. The target of the last hop is the target host, the target of previous hops is the respective proxy in the chain. For a route through exactly one proxy, target of hop 0 is the proxy and target of hop 1 is the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target of the given hop</para>
				/// </returns>
				/// <java-name>
				/// getHopTarget
				/// </java-name>
				[Dot42.DexImport("getHopTarget", "(I)Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetHopTarget(int hop) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Obtains the first proxy host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first proxy in the proxy chain, or <code>null</code> if this route is direct </para>
				/// </returns>
				/// <java-name>
				/// getProxyHost
				/// </java-name>
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetProxyHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Obtains the tunnel type of this route. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tunnelling type </para>
				/// </returns>
				/// <java-name>
				/// getTunnelType
				/// </java-name>
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType GetTunnelType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType);
				}

				/// <summary>
				/// <para>Checks whether this route is tunnelled through a proxy. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if tunnelled end-to-end through at least one proxy, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isTunnelled
				/// </java-name>
				[Dot42.DexImport("isTunnelled", "()Z", AccessFlags = 17)]
				public bool IsTunnelled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the layering type of this route. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the layering type </para>
				/// </returns>
				/// <java-name>
				/// getLayerType
				/// </java-name>
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType GetLayerType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType);
				}

				/// <summary>
				/// <para>Checks whether this route includes a layered protocol. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if layered, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 17)]
				public bool IsLayered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether this route is secure.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if secure, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 17)]
				public bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares this route to another.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the argument is the same route, <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Generates a hash code for this route.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains a description of this route.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a human-readable representation of this route </para>
				/// </returns>
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

				/// <summary>
				/// <para>Obtains the target host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target host </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost TargetHost
				{
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetTargetHost(); }
				}

				/// <summary>
				/// <para>Obtains the local address to connect from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
						get{ return GetLocalAddress(); }
				}

				/// <summary>
				/// <para>Obtains the number of hops in this route. A direct route has one hop. A route through a proxy has two hops. A route through a chain of <b>n</b> proxies has <b>n+1</b> hops.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of hops in this route </para>
				/// </returns>
				/// <java-name>
				/// getHopCount
				/// </java-name>
				public int HopCount
				{
				[Dot42.DexImport("getHopCount", "()I", AccessFlags = 17)]
						get{ return GetHopCount(); }
				}

				/// <summary>
				/// <para>Obtains the first proxy host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first proxy in the proxy chain, or <code>null</code> if this route is direct </para>
				/// </returns>
				/// <java-name>
				/// getProxyHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost ProxyHost
				{
				[Dot42.DexImport("getProxyHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetProxyHost(); }
				}

				/// <summary>
				/// <para>Obtains the tunnel type of this route. If there is a proxy chain, only end-to-end tunnels are considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tunnelling type </para>
				/// </returns>
				/// <java-name>
				/// getTunnelType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_TunnelType TunnelType
				{
				[Dot42.DexImport("getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", AccessFlags = 17)]
						get{ return GetTunnelType(); }
				}

				/// <summary>
				/// <para>Obtains the layering type of this route. In the presence of proxies, only layering over an end-to-end tunnel is considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the layering type </para>
				/// </returns>
				/// <java-name>
				/// getLayerType
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IRouteInfo_LayerType LayerType
				{
				[Dot42.DexImport("getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", AccessFlags = 17)]
						get{ return GetLayerType(); }
				}

		}

		/// <summary>
		/// <para>Basic implementation of an HttpRouteDirector. This implementation is stateless and therefore thread-safe.</para><para><para></para><para></para><title>Revision:</title><para>620255 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Provides the next step.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of the constants defined in this class, indicating either the next step to perform, or success, or failure. 0 is for success, a negative value for failure. </para>
				/// </returns>
				/// <java-name>
				/// nextStep
				/// </java-name>
				[Dot42.DexImport("nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 1)]
				public virtual int NextStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo plan, global::Org.Apache.Http.Conn.Routing.IRouteInfo fact) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the first step to establish a route.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first step </para>
				/// </returns>
				/// <java-name>
				/// firstStep
				/// </java-name>
				[Dot42.DexImport("firstStep", "(Lorg/apache/http/conn/routing/RouteInfo;)I", AccessFlags = 4)]
				protected internal virtual int FirstStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo plan) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the next step to establish a direct connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of the constants defined in this class, indicating either the next step to perform, or success, or failure </para>
				/// </returns>
				/// <java-name>
				/// directStep
				/// </java-name>
				[Dot42.DexImport("directStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 4)]
				protected internal virtual int DirectStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo plan, global::Org.Apache.Http.Conn.Routing.IRouteInfo fact) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the next step to establish a connection via proxy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of the constants defined in this class, indicating either the next step to perform, or success, or failure </para>
				/// </returns>
				/// <java-name>
				/// proxiedStep
				/// </java-name>
				[Dot42.DexImport("proxiedStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;" +
    ")I", AccessFlags = 4)]
				protected internal virtual int ProxiedStep(global::Org.Apache.Http.Conn.Routing.IRouteInfo plan, global::Org.Apache.Http.Conn.Routing.IRouteInfo fact) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

}


