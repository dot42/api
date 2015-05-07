#pragma warning disable 1717
namespace Org.Apache.Http.Impl.Entity
{
		/// <java-name>
		/// org/apache/http/impl/entity/EntityDeserializer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/EntityDeserializer", AccessFlags = 33)]
		public partial class EntityDeserializer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V", AccessFlags = 1)]
				public EntityDeserializer(global::Org.Apache.Http.Entity.IContentLengthStrategy contentLengthStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doDeserialize
				/// </java-name>
				[Dot42.DexImport("doDeserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache" +
    "/http/entity/BasicHttpEntity;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Entity.BasicHttpEntity DoDeserialize(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Entity.BasicHttpEntity);
				}

				/// <java-name>
				/// deserialize
				/// </java-name>
				[Dot42.DexImport("deserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache" +
    "/http/HttpEntity;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpEntity Deserialize(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpEntity);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EntityDeserializer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/entity/EntitySerializer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/EntitySerializer", AccessFlags = 33)]
		public partial class EntitySerializer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V", AccessFlags = 1)]
				public EntitySerializer(global::Org.Apache.Http.Entity.IContentLengthStrategy contentLengthStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doSerialize
				/// </java-name>
				[Dot42.DexImport("doSerialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;)Ljava/io/O" +
    "utputStream;", AccessFlags = 4)]
				protected internal virtual global::Java.IO.OutputStream DoSerialize(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.OutputStream);
				}

				/// <java-name>
				/// serialize
				/// </java-name>
				[Dot42.DexImport("serialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;Lorg/apache" +
    "/http/HttpEntity;)V", AccessFlags = 1)]
				public virtual void Serialize(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.IHttpMessage httpMessage, global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EntitySerializer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/entity/LaxContentLengthStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/LaxContentLengthStrategy", AccessFlags = 33)]
		public partial class LaxContentLengthStrategy : global::Org.Apache.Http.Entity.IContentLengthStrategy
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LaxContentLengthStrategy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// determineLength
				/// </java-name>
				[Dot42.DexImport("determineLength", "(Lorg/apache/http/HttpMessage;)J", AccessFlags = 1)]
				public virtual long DetermineLength(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/entity/StrictContentLengthStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/StrictContentLengthStrategy", AccessFlags = 33)]
		public partial class StrictContentLengthStrategy : global::Org.Apache.Http.Entity.IContentLengthStrategy
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StrictContentLengthStrategy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// determineLength
				/// </java-name>
				[Dot42.DexImport("determineLength", "(Lorg/apache/http/HttpMessage;)J", AccessFlags = 1)]
				public virtual long DetermineLength(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

}

