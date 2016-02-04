#pragma warning disable 1717
namespace System.Reflection
{
		/// <summary>
		///  <para>This class provides a wrapper for an exception thrown by a <c>Method </c> or  <c>Constructor </c> invocation.</para> <para> <para>Method::invoke </para> <para>Constructor::newInstance </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/InvocationTargetException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/InvocationTargetException", AccessFlags = 33)]
		public partial class TargetInvocationException : global::Java.Lang.ReflectiveOperationException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>InvocationTargetException </c> instance with a  <c>null </c> cause / target exception. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TargetInvocationException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>InvocationTargetException </c> instance with its cause / target exception filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TargetInvocationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>InvocationTargetException </c> instance with its cause / target exception and message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V", AccessFlags = 1)]
				public TargetInvocationException(global::System.Exception exception, string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the target exception, which may be <c>null </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the target exception </para>
				/// </returns>
				/// <java-name>
				/// getTargetException
				/// </java-name>
				public virtual global::System.Exception TargetException
				{
						[Dot42.DexImport("getTargetException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <summary>
				///  <para>Returns the cause of this exception, which may be <c>null </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cause of this exception </para>
				/// </returns>
				/// <java-name>
				/// getCause
				/// </java-name>
				public override global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

}

