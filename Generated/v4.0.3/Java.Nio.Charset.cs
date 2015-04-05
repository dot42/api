#pragma warning disable 1717
namespace Java.Nio.Charset
{
		/// <java-name>
		/// java/nio/charset/CharacterCodingException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CharacterCodingException", AccessFlags = 33)]
		public partial class CharacterCodingException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CharacterCodingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/charset/Charset
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/Charset", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/nio/charset/Charset;>;")]
		public abstract partial class Charset : global::System.IComparable<global::Java.Nio.Charset.Charset>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Charset(string @string, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// availableCharsets
				/// </java-name>
				[Dot42.DexImport("availableCharsets", "()Ljava/util/SortedMap;", AccessFlags = 9, Signature = "()Ljava/util/SortedMap<Ljava/lang/String;Ljava/nio/charset/Charset;>;")]
				public static global::Java.Util.ISortedMap<string, global::Java.Nio.Charset.Charset> AvailableCharsets() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<string, global::Java.Nio.Charset.Charset>);
				}

				/// <java-name>
				/// forName
				/// </java-name>
				[Dot42.DexImport("forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", AccessFlags = 9)]
				public static global::Java.Nio.Charset.Charset ForName(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <java-name>
				/// isSupported
				/// </java-name>
				[Dot42.DexImport("isSupported", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsSupported(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/nio/charset/Charset;)Z", AccessFlags = 1025)]
				public abstract bool Contains(global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newEncoder
				/// </java-name>
				[Dot42.DexImport("newEncoder", "()Ljava/nio/charset/CharsetEncoder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Charset.CharsetEncoder NewEncoder() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newDecoder
				/// </java-name>
				[Dot42.DexImport("newDecoder", "()Ljava/nio/charset/CharsetDecoder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Charset.CharsetDecoder NewDecoder() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 17)]
				public string Name() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// aliases
				/// </java-name>
				[Dot42.DexImport("aliases", "()Ljava/util/Set;", AccessFlags = 17, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public global::Java.Util.ISet<string> Aliases() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// displayName
				/// </java-name>
				[Dot42.DexImport("displayName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string DisplayName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// displayName
				/// </java-name>
				[Dot42.DexImport("displayName", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string DisplayName(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Encode(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Encode(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Decode(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/charset/Charset;)I", AccessFlags = 17)]
				public int CompareTo(global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// defaultCharset
				/// </java-name>
				[Dot42.DexImport("defaultCharset", "()Ljava/nio/charset/Charset;", AccessFlags = 9)]
				public static global::Java.Nio.Charset.Charset DefaultCharset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Charset() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isRegistered
				/// </java-name>
				public bool IsRegistered
				{
						[Dot42.DexImport("isRegistered", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// canEncode
				/// </java-name>
				public virtual bool CanEncode
				{
						[Dot42.DexImport("canEncode", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/charset/CharsetDecoder
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CharsetDecoder", AccessFlags = 1057)]
		public abstract partial class CharsetDecoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF)V", AccessFlags = 4)]
				protected internal CharsetDecoder(global::Java.Nio.Charset.Charset charset, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// averageCharsPerByte
				/// </java-name>
				[Dot42.DexImport("averageCharsPerByte", "()F", AccessFlags = 17)]
				public float AverageCharsPerByte() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// charset
				/// </java-name>
				[Dot42.DexImport("charset", "()Ljava/nio/charset/Charset;", AccessFlags = 17)]
				public global::Java.Nio.Charset.Charset Charset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Decode(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Decode(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.CharBuffer charBuffer, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// decodeLoop
				/// </java-name>
				[Dot42.DexImport("decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 1028)]
				protected internal abstract global::Java.Nio.Charset.CoderResult DecodeLoop(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// detectedCharset
				/// </java-name>
				[Dot42.DexImport("detectedCharset", "()Ljava/nio/charset/Charset;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.Charset DetectedCharset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Flush(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// implFlush
				/// </java-name>
				[Dot42.DexImport("implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 4)]
				protected internal virtual global::Java.Nio.Charset.CoderResult ImplFlush(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// implOnMalformedInput
				/// </java-name>
				[Dot42.DexImport("implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnMalformedInput(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implOnUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implReplaceWith
				/// </java-name>
				[Dot42.DexImport("implReplaceWith", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void ImplReplaceWith(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implReset
				/// </java-name>
				[Dot42.DexImport("implReset", "()V", AccessFlags = 4)]
				protected internal virtual void ImplReset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// malformedInputAction
				/// </java-name>
				[Dot42.DexImport("malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.CodingErrorAction MalformedInputAction() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CodingErrorAction);
				}

				/// <java-name>
				/// maxCharsPerByte
				/// </java-name>
				[Dot42.DexImport("maxCharsPerByte", "()F", AccessFlags = 17)]
				public float MaxCharsPerByte() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// onMalformedInput
				/// </java-name>
				[Dot42.DexImport("onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder OnMalformedInput(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <java-name>
				/// onUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder OnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <java-name>
				/// replacement
				/// </java-name>
				[Dot42.DexImport("replacement", "()Ljava/lang/String;", AccessFlags = 17)]
				public string Replacement() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// replaceWith
				/// </java-name>
				[Dot42.DexImport("replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder ReplaceWith(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <java-name>
				/// unmappableCharacterAction
				/// </java-name>
				[Dot42.DexImport("unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.CodingErrorAction UnmappableCharacterAction() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CodingErrorAction);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharsetDecoder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isAutoDetecting
				/// </java-name>
				public virtual bool IsAutoDetecting
				{
						[Dot42.DexImport("isAutoDetecting", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isCharsetDetected
				/// </java-name>
				public virtual bool IsCharsetDetected
				{
						[Dot42.DexImport("isCharsetDetected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/charset/CharsetEncoder
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CharsetEncoder", AccessFlags = 1057)]
		public abstract partial class CharsetEncoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF)V", AccessFlags = 4)]
				protected internal CharsetEncoder(global::Java.Nio.Charset.Charset charset, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF[B)V", AccessFlags = 4)]
				protected internal CharsetEncoder(global::Java.Nio.Charset.Charset charset, float single, float single1, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF[B)V", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal CharsetEncoder(global::Java.Nio.Charset.Charset charset, float single, float single1, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// averageBytesPerChar
				/// </java-name>
				[Dot42.DexImport("averageBytesPerChar", "()F", AccessFlags = 17)]
				public float AverageBytesPerChar() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// canEncode
				/// </java-name>
				[Dot42.DexImport("canEncode", "(C)Z", AccessFlags = 1)]
				public virtual bool CanEncode(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// canEncode
				/// </java-name>
				[Dot42.DexImport("canEncode", "(Ljava/lang/CharSequence;)Z", AccessFlags = 1)]
				public virtual bool CanEncode(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// charset
				/// </java-name>
				[Dot42.DexImport("charset", "()Ljava/nio/charset/Charset;", AccessFlags = 17)]
				public global::Java.Nio.Charset.Charset Charset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Encode(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Encode(global::Java.Nio.CharBuffer charBuffer, global::Java.Nio.ByteBuffer byteBuffer, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// encodeLoop
				/// </java-name>
				[Dot42.DexImport("encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 1028)]
				protected internal abstract global::Java.Nio.Charset.CoderResult EncodeLoop(global::Java.Nio.CharBuffer charBuffer, global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Flush(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// implFlush
				/// </java-name>
				[Dot42.DexImport("implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 4)]
				protected internal virtual global::Java.Nio.Charset.CoderResult ImplFlush(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// implOnMalformedInput
				/// </java-name>
				[Dot42.DexImport("implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnMalformedInput(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implOnUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implReplaceWith
				/// </java-name>
				[Dot42.DexImport("implReplaceWith", "([B)V", AccessFlags = 4)]
				protected internal virtual void ImplReplaceWith(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implReplaceWith
				/// </java-name>
				[Dot42.DexImport("implReplaceWith", "([B)V", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual void ImplReplaceWith(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implReset
				/// </java-name>
				[Dot42.DexImport("implReset", "()V", AccessFlags = 4)]
				protected internal virtual void ImplReset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLegalReplacement
				/// </java-name>
				[Dot42.DexImport("isLegalReplacement", "([B)Z", AccessFlags = 1)]
				public virtual bool IsLegalReplacement(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLegalReplacement
				/// </java-name>
				[Dot42.DexImport("isLegalReplacement", "([B)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool IsLegalReplacement(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// malformedInputAction
				/// </java-name>
				[Dot42.DexImport("malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.CodingErrorAction MalformedInputAction() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CodingErrorAction);
				}

				/// <java-name>
				/// maxBytesPerChar
				/// </java-name>
				[Dot42.DexImport("maxBytesPerChar", "()F", AccessFlags = 17)]
				public float MaxBytesPerChar() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// onMalformedInput
				/// </java-name>
				[Dot42.DexImport("onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder OnMalformedInput(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <java-name>
				/// onUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder OnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction codingErrorAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <java-name>
				/// replacement
				/// </java-name>
				[Dot42.DexImport("replacement", "()[B", AccessFlags = 17)]
				public sbyte[] JavaReplacement() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// replacement
				/// </java-name>
				[Dot42.DexImport("replacement", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Replacement() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// replaceWith
				/// </java-name>
				[Dot42.DexImport("replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder ReplaceWith(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <java-name>
				/// replaceWith
				/// </java-name>
				[Dot42.DexImport("replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17, IgnoreFromJava = true)]
				public global::Java.Nio.Charset.CharsetEncoder ReplaceWith(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <java-name>
				/// unmappableCharacterAction
				/// </java-name>
				[Dot42.DexImport("unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.CodingErrorAction UnmappableCharacterAction() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CodingErrorAction);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharsetEncoder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/charset/CoderMalfunctionError
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CoderMalfunctionError", AccessFlags = 33)]
		public partial class CoderMalfunctionError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public CoderMalfunctionError(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CoderMalfunctionError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/charset/CoderResult
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CoderResult", AccessFlags = 33)]
		public partial class CoderResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNDERFLOW
				/// </java-name>
				[Dot42.DexImport("UNDERFLOW", "Ljava/nio/charset/CoderResult;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CoderResult UNDERFLOW;
				/// <java-name>
				/// OVERFLOW
				/// </java-name>
				[Dot42.DexImport("OVERFLOW", "Ljava/nio/charset/CoderResult;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CoderResult OVERFLOW;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CoderResult() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// malformedForLength
				/// </java-name>
				[Dot42.DexImport("malformedForLength", "(I)Ljava/nio/charset/CoderResult;", AccessFlags = 41)]
				public static global::Java.Nio.Charset.CoderResult MalformedForLength(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// unmappableForLength
				/// </java-name>
				[Dot42.DexImport("unmappableForLength", "(I)Ljava/nio/charset/CoderResult;", AccessFlags = 41)]
				public static global::Java.Nio.Charset.CoderResult UnmappableForLength(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// throwException
				/// </java-name>
				[Dot42.DexImport("throwException", "()V", AccessFlags = 1)]
				public virtual void ThrowException() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// isUnderflow
				/// </java-name>
				public virtual bool IsUnderflow
				{
						[Dot42.DexImport("isUnderflow", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isError
				/// </java-name>
				public virtual bool IsError
				{
						[Dot42.DexImport("isError", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMalformed
				/// </java-name>
				public virtual bool IsMalformed
				{
						[Dot42.DexImport("isMalformed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isOverflow
				/// </java-name>
				public virtual bool IsOverflow
				{
						[Dot42.DexImport("isOverflow", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isUnmappable
				/// </java-name>
				public virtual bool IsUnmappable
				{
						[Dot42.DexImport("isUnmappable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/charset/CodingErrorAction
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CodingErrorAction", AccessFlags = 33)]
		public partial class CodingErrorAction
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// IGNORE
				/// </java-name>
				[Dot42.DexImport("IGNORE", "Ljava/nio/charset/CodingErrorAction;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CodingErrorAction IGNORE;
				/// <java-name>
				/// REPLACE
				/// </java-name>
				[Dot42.DexImport("REPLACE", "Ljava/nio/charset/CodingErrorAction;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CodingErrorAction REPLACE;
				/// <java-name>
				/// REPORT
				/// </java-name>
				[Dot42.DexImport("REPORT", "Ljava/nio/charset/CodingErrorAction;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CodingErrorAction REPORT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CodingErrorAction() /* MethodBuilder.Create */ 
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
		/// java/nio/charset/IllegalCharsetNameException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/IllegalCharsetNameException", AccessFlags = 33)]
		public partial class IllegalCharsetNameException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalCharsetNameException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IllegalCharsetNameException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCharsetName
				/// </java-name>
				public virtual string CharsetName
				{
						[Dot42.DexImport("getCharsetName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/nio/charset/MalformedInputException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/MalformedInputException", AccessFlags = 33)]
		public partial class MalformedInputException : global::Java.Nio.Charset.CharacterCodingException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public MalformedInputException(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MalformedInputException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getInputLength
				/// </java-name>
				public virtual int InputLength
				{
						[Dot42.DexImport("getInputLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/nio/charset/UnmappableCharacterException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/UnmappableCharacterException", AccessFlags = 33)]
		public partial class UnmappableCharacterException : global::Java.Nio.Charset.CharacterCodingException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public UnmappableCharacterException(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnmappableCharacterException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getInputLength
				/// </java-name>
				public virtual int InputLength
				{
						[Dot42.DexImport("getInputLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/nio/charset/UnsupportedCharsetException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/UnsupportedCharsetException", AccessFlags = 33)]
		public partial class UnsupportedCharsetException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedCharsetException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnsupportedCharsetException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCharsetName
				/// </java-name>
				public virtual string CharsetName
				{
						[Dot42.DexImport("getCharsetName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

