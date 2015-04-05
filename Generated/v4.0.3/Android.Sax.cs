#pragma warning disable 1717
namespace Android.Sax
{
		/// <java-name>
		/// android/sax/Element
		/// </java-name>
		[Dot42.DexImport("android/sax/Element", AccessFlags = 33)]
		public partial class Element
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Element() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element GetChild(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element GetChild(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <java-name>
				/// requireChild
				/// </java-name>
				[Dot42.DexImport("requireChild", "(Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element RequireChild(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <java-name>
				/// requireChild
				/// </java-name>
				[Dot42.DexImport("requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element RequireChild(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <java-name>
				/// setElementListener
				/// </java-name>
				[Dot42.DexImport("setElementListener", "(Landroid/sax/ElementListener;)V", AccessFlags = 1)]
				public virtual void SetElementListener(global::Android.Sax.IElementListener elementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextElementListener
				/// </java-name>
				[Dot42.DexImport("setTextElementListener", "(Landroid/sax/TextElementListener;)V", AccessFlags = 1)]
				public virtual void SetTextElementListener(global::Android.Sax.ITextElementListener textElementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStartElementListener
				/// </java-name>
				[Dot42.DexImport("setStartElementListener", "(Landroid/sax/StartElementListener;)V", AccessFlags = 1)]
				public virtual void SetStartElementListener(global::Android.Sax.IStartElementListener startElementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEndElementListener
				/// </java-name>
				[Dot42.DexImport("setEndElementListener", "(Landroid/sax/EndElementListener;)V", AccessFlags = 1)]
				public virtual void SetEndElementListener(global::Android.Sax.IEndElementListener endElementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEndTextElementListener
				/// </java-name>
				[Dot42.DexImport("setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V", AccessFlags = 1)]
				public virtual void SetEndTextElementListener(global::Android.Sax.IEndTextElementListener endTextElementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/sax/ElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/ElementListener", AccessFlags = 1537)]
		public partial interface IElementListener : global::Android.Sax.IStartElementListener, global::Android.Sax.IEndElementListener
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/sax/EndElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/EndElementListener", AccessFlags = 1537)]
		public partial interface IEndElementListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1025)]
				void End() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/sax/EndTextElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/EndTextElementListener", AccessFlags = 1537)]
		public partial interface IEndTextElementListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void End(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/sax/StartElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/StartElementListener", AccessFlags = 1537)]
		public partial interface IStartElementListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1025)]
				void Start(global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/sax/TextElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/TextElementListener", AccessFlags = 1537)]
		public partial interface ITextElementListener : global::Android.Sax.IStartElementListener, global::Android.Sax.IEndTextElementListener
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/sax/RootElement
		/// </java-name>
		[Dot42.DexImport("android/sax/RootElement", AccessFlags = 33)]
		public partial class RootElement : global::Android.Sax.Element
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public RootElement(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RootElement(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RootElement() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IContentHandler ContentHandler
				{
						[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IContentHandler); }
				}

		}

}

