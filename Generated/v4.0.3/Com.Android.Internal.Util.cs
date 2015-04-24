#pragma warning disable 1717
namespace Com.Android.Internal.Util
{
		/// <summary>
		///  <para>A Predicate can determine a true or false value for any input of its parameterized type. For example, a <c>RegexPredicate </c> might implement  <c>Predicate&lt;String&gt; </c> , and return true for any String that matches its given regular expression. </para> <para>Implementors of Predicate which may cause side effects upon evaluation are strongly encouraged to state this fact clearly in their API documentation. </para>    
		/// </summary>
		/// <java-name>
		/// com/android/internal/util/Predicate
		/// </java-name>
		[Dot42.DexImport("com/android/internal/util/Predicate", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IPredicate<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TT;)Z")]
				bool Apply(T t) /* MethodBuilder.Create */ ;

		}

}

