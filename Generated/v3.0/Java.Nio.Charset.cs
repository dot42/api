// Copyright (C) 2014 dot42
//
// Original filename: Java.Nio.Charset.cs
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
namespace Java.Nio.Charset
{
		/// <summary>
		/// <para>A converter that can convert a byte sequence from a charset into a 16-bit Unicode character sequence. </para><para>The input byte sequence is wrapped by a ByteBuffer and the output character sequence is a CharBuffer. A decoder instance should be used in the following sequence, which is referred to as a decoding operation: <ol><li><para>invoking the reset method to reset the decoder if the decoder has been used; </para></li><li><para>invoking the decode method until the additional input is not needed, the <code>endOfInput</code> parameter must be set to false, the input buffer must be filled and the output buffer must be flushed between invocations; </para></li><li><para>invoking the decode method for the last time, and then the <code>endOfInput</code> parameter must be set to true; </para></li><li><para>invoking the flush method to flush the output. </para></li></ol></para><para>The decode method will convert as many bytes as possible, and the process won't stop until the input bytes have run out, the output buffer has been filled or some error has happened. A CoderResult instance will be returned to indicate the stop reason, and the invoker can identify the result and choose further action, which includes filling the input buffer, flushing the output buffer or recovering from an error and trying again. </para><para>There are two common decoding errors. One is named malformed and it is returned when the input byte sequence is illegal for the current specific charset, the other is named unmappable character and it is returned when a problem occurs mapping a legal input byte sequence to its Unicode character equivalent. </para><para>Both errors can be handled in three ways, the default one is to report the error to the invoker by a CoderResult instance, and the alternatives are to ignore it or to replace the erroneous input with the replacement string. The replacement string is "\uFFFD" by default and can be changed by invoking replaceWith method. The invoker of this decoder can choose one way by specifying a CodingErrorAction instance for each error type via onMalformedInput method and onUnmappableCharacter method. </para><para>This is an abstract class and encapsulates many common operations of the decoding process for all charsets. Decoders for a specific charset should extend this class and need only to implement the decodeLoop method for the basic decoding. If a subclass maintains an internal state, it should override the implFlush method and the implReset method in addition. </para><para>This class is not thread-safe.</para><para><para>java.nio.charset.Charset </para><simplesectsep></simplesectsep><para>java.nio.charset.CharsetEncoder </para></para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/CharsetDecoder
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CharsetDecoder", AccessFlags = 1057)]
		public abstract partial class CharsetDecoder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <code>CharsetDecoder</code> using the given <code>Charset</code>, average number and maximum number of characters created by this decoder for one input byte, and the default replacement string "\uFFFD".</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF)V", AccessFlags = 4)]
				protected internal CharsetDecoder(global::Java.Nio.Charset.Charset charset, float averageCharsPerByte, float maxCharsPerByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the average number of characters created by this decoder for a single input byte. </para>        
				/// </summary>
				/// <java-name>
				/// averageCharsPerByte
				/// </java-name>
				[Dot42.DexImport("averageCharsPerByte", "()F", AccessFlags = 17)]
				public float AverageCharsPerByte() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the Charset which this decoder uses. </para>        
				/// </summary>
				/// <java-name>
				/// charset
				/// </java-name>
				[Dot42.DexImport("charset", "()Ljava/nio/charset/Charset;", AccessFlags = 17)]
				public global::Java.Nio.Charset.Charset Charset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <summary>
				/// <para>This is a facade method for the decoding operation. </para><para>This method decodes the remaining byte sequence of the given byte buffer into a new character buffer. This method performs a complete decoding operation, resets at first, then decodes, and flushes at last. </para><para>This method should not be invoked while another <c> decode </c> operation is ongoing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <code>CharBuffer</code> containing the the characters produced by this decoding operation. The buffer's limit will be the position of the last character in the buffer, and the position will be zero. </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Decode(global::Java.Nio.ByteBuffer @in) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <summary>
				/// <para>Decodes bytes starting at the current position of the given input buffer, and writes the equivalent character sequence into the given output buffer from its current position. </para><para>The buffers' position will be changed with the reading and writing operation, but their limits and marks will be kept intact. </para><para>A <code>CoderResult</code> instance will be returned according to following rules: <ul><li><para>CoderResult.OVERFLOW indicates that even though not all of the input has been processed, the buffer the output is being written to has reached its capacity. In the event of this code being returned this method should be called once more with an <code>out</code> argument that has not already been filled. </para></li><li><para>CoderResult.UNDERFLOW indicates that as many bytes as possible in the input buffer have been decoded. If there is no further input and no remaining bytes in the input buffer then this operation may be regarded as complete. Otherwise, this method should be called once more with additional input. </para></li><li><para>A malformed input result indicates that some malformed input error has been encountered, and the erroneous bytes start at the input buffer's position and their number can be got by result's length. This kind of result can be returned only if the malformed action is CodingErrorAction.REPORT.  </para></li><li><para>A unmappable character result indicates that some unmappable character error has been encountered, and the erroneous bytes start at the input buffer's position and their number can be got by result's length. This kind of result can be returned only if the unmappable character action is CodingErrorAction.REPORT.  </para></li></ul></para><para>The <code>endOfInput</code> parameter indicates that the invoker cannot provide further input. This parameter is true if and only if the bytes in current input buffer are all inputs for this decoding operation. Note that it is common and won't cause an error if the invoker sets false and then can't provide more input, while it may cause an error if the invoker always sets true in several consecutive invocations. This would make the remaining input to be treated as malformed input. </para><para>This method invokes the decodeLoop method to implement the basic decode logic for a specific charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <code>CoderResult</code> instance which indicates the reason of termination. </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Decode(global::Java.Nio.ByteBuffer @in, global::Java.Nio.CharBuffer @out, bool endOfInput) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Decodes bytes into characters. This method is called by the decode method. </para><para>This method will implement the essential decoding operation, and it won't stop decoding until either all the input bytes are read, the output buffer is filled, or some exception is encountered. Then it will return a <code>CoderResult</code> object indicating the result of current decoding operation. The rules to construct the <code>CoderResult</code> are the same as for decode. When an exception is encountered in the decoding operation, most implementations of this method will return a relevant result object to the decode method, and some performance optimized implementation may handle the exception and implement the error action itself. </para><para>The buffers are scanned from their current positions, and their positions will be modified accordingly, while their marks and limits will be intact. At most in.remaining() characters will be read, and out.remaining() bytes will be written. </para><para>Note that some implementations may pre-scan the input buffer and return a <code>CoderResult.UNDERFLOW</code> until it receives sufficient input.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <code>CoderResult</code> instance indicating the result. </para>
				/// </returns>
				/// <java-name>
				/// decodeLoop
				/// </java-name>
				[Dot42.DexImport("decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 1028)]
				protected internal abstract global::Java.Nio.Charset.CoderResult DecodeLoop(global::Java.Nio.ByteBuffer @in, global::Java.Nio.CharBuffer @out) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the charset detected by this decoder; this method is optional. </para><para>If implementing an auto-detecting charset, then this decoder returns the detected charset from this method when it is available. The returned charset will be the same for the rest of the decode operation. </para><para>If insufficient bytes have been read to determine the charset, an <code>IllegalStateException</code> will be thrown. </para><para>The default implementation always throws <code>UnsupportedOperationException</code>, so it should be overridden by a subclass if needed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the charset detected by this decoder, or null if it is not yet determined. </para>
				/// </returns>
				/// <java-name>
				/// detectedCharset
				/// </java-name>
				[Dot42.DexImport("detectedCharset", "()Ljava/nio/charset/Charset;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.Charset DetectedCharset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <summary>
				/// <para>Flushes this decoder.</para><para>This method will call implFlush. Some decoders may need to write some characters to the output buffer when they have read all input bytes; subclasses can override implFlush to perform the writing operation. </para><para>The maximum number of written bytes won't be larger than out.remaining(). If some decoder wants to write more bytes than an output buffer's remaining space allows, then a <code>CoderResult.OVERFLOW</code> will be returned, and this method must be called again with a character buffer that has more remaining space. Otherwise this method will return <code>CoderResult.UNDERFLOW</code>, which means one decoding process has been completed successfully. </para><para>During the flush, the output buffer's position will be changed accordingly, while its mark and limit will be intact.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>CoderResult.UNDERFLOW</code> or <code>CoderResult.OVERFLOW</code>. </para>
				/// </returns>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Flush(global::Java.Nio.CharBuffer @out) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Flushes this decoder. The default implementation does nothing and always returns <code>CoderResult.UNDERFLOW</code>; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>CoderResult.UNDERFLOW</code> or <code>CoderResult.OVERFLOW</code>. </para>
				/// </returns>
				/// <java-name>
				/// implFlush
				/// </java-name>
				[Dot42.DexImport("implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 4)]
				protected internal virtual global::Java.Nio.Charset.CoderResult ImplFlush(global::Java.Nio.CharBuffer @out) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Notifies that this decoder's <code>CodingErrorAction</code> specified for malformed input error has been changed. The default implementation does nothing; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implOnMalformedInput
				/// </java-name>
				[Dot42.DexImport("implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnMalformedInput(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies that this decoder's <code>CodingErrorAction</code> specified for unmappable character error has been changed. The default implementation does nothing; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implOnUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies that this decoder's replacement has been changed. The default implementation does nothing; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implReplaceWith
				/// </java-name>
				[Dot42.DexImport("implReplaceWith", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void ImplReplaceWith(string newReplacement) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reset this decoder's charset related state. The default implementation does nothing; this method can be overridden if needed. </para>        
				/// </summary>
				/// <java-name>
				/// implReset
				/// </java-name>
				[Dot42.DexImport("implReset", "()V", AccessFlags = 4)]
				protected internal virtual void ImplReset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether this decoder implements an auto-detecting charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this decoder implements an auto-detecting charset. </para>
				/// </returns>
				/// <java-name>
				/// isAutoDetecting
				/// </java-name>
				[Dot42.DexImport("isAutoDetecting", "()Z", AccessFlags = 1)]
				public virtual bool IsAutoDetecting() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this decoder has detected a charset; this method is optional. </para><para>If this decoder implements an auto-detecting charset, then this method may start to return true during decoding operation to indicate that a charset has been detected in the input bytes and that the charset can be retrieved by invoking the detectedCharset method. </para><para>Note that a decoder that implements an auto-detecting charset may still succeed in decoding a portion of the given input even when it is unable to detect the charset. For this reason users should be aware that a <code>false</code> return value does not indicate that no decoding took place. </para><para>The default implementation always throws an <code>UnsupportedOperationException</code>; it should be overridden by a subclass if needed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this decoder has detected a charset. </para>
				/// </returns>
				/// <java-name>
				/// isCharsetDetected
				/// </java-name>
				[Dot42.DexImport("isCharsetDetected", "()Z", AccessFlags = 1)]
				public virtual bool IsCharsetDetected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this decoder's <code>CodingErrorAction</code> when malformed input occurred during the decoding process. </para>        
				/// </summary>
				/// <java-name>
				/// malformedInputAction
				/// </java-name>
				[Dot42.DexImport("malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.CodingErrorAction MalformedInputAction() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CodingErrorAction);
				}

				/// <summary>
				/// <para>Returns the maximum number of characters which can be created by this decoder for one input byte, must be positive. </para>        
				/// </summary>
				/// <java-name>
				/// maxCharsPerByte
				/// </java-name>
				[Dot42.DexImport("maxCharsPerByte", "()F", AccessFlags = 17)]
				public float MaxCharsPerByte() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets this decoder's action on malformed input errors.</para><para>This method will call the implOnMalformedInput method with the given new action as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this decoder. </para>
				/// </returns>
				/// <java-name>
				/// onMalformedInput
				/// </java-name>
				[Dot42.DexImport("onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder OnMalformedInput(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <summary>
				/// <para>Sets this decoder's action on unmappable character errors.</para><para>This method will call the implOnUnmappableCharacter method with the given new action as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this decoder. </para>
				/// </returns>
				/// <java-name>
				/// onUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder OnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <summary>
				/// <para>Returns the replacement string, which is never null or empty. </para>        
				/// </summary>
				/// <java-name>
				/// replacement
				/// </java-name>
				[Dot42.DexImport("replacement", "()Ljava/lang/String;", AccessFlags = 17)]
				public string Replacement() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the new replacement string.</para><para>This method first checks the given replacement's validity, then changes the replacement value, and at last calls the implReplaceWith method with the given new replacement as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this decoder. </para>
				/// </returns>
				/// <java-name>
				/// replaceWith
				/// </java-name>
				[Dot42.DexImport("replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder ReplaceWith(string replacement) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <summary>
				/// <para>Resets this decoder. This method will reset the internal status, and then calls <code>implReset()</code> to reset any status related to the specific charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this decoder. </para>
				/// </returns>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/nio/charset/CharsetDecoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetDecoder Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetDecoder);
				}

				/// <summary>
				/// <para>Returns this decoder's <code>CodingErrorAction</code> when an unmappable character error occurred during the decoding process. </para>        
				/// </summary>
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

		}

		/// <summary>
		/// <para>Transforms a sequence of 16-bit Java characters to a byte sequence in some encoding.</para><para>The input character sequence is a CharBuffer and the output byte sequence is a ByteBuffer.</para><para>Use encode(CharBuffer) to encode an entire <c> CharBuffer </c> to a new <c> ByteBuffer </c> , or encode(CharBuffer, ByteBuffer, boolean) for more control. When using the latter method, the entire operation proceeds as follows: <ol><li><para>Invoke reset() to reset the encoder if this instance has been used before. </para></li><li><para>Invoke encode with the <c> endOfInput </c> parameter set to false until additional input is not needed (as signaled by the return value). The input buffer must be filled and the output buffer must be flushed between invocations. </para><para>The encode method will convert as many characters as possible, and the process won't stop until the input buffer has been exhausted, the output buffer has been filled, or an error has occurred. A CoderResult instance will be returned to indicate the current state. The caller should fill the input buffer, flush the output buffer, or recovering from an error and try again, accordingly.  </para></li><li><para>Invoke encode for the last time with <c> endOfInput </c> set to true. </para></li><li><para>Invoke flush(ByteBuffer) to flush remaining output. </para></li></ol></para><para>There are two classes of encoding error: <b>malformed input</b> signifies that the input character sequence is not legal, while <b>unmappable character</b> signifies that the input is legal but cannot be mapped to a byte sequence (because the charset cannot represent the character, for example).</para><para>Errors can be handled in three ways. The default is to report the error to the caller. The alternatives are to ignore the error or replace the problematic input with the byte sequence returned by replacement. The disposition for each of the two kinds of error can be set independently using the onMalformedInput and onUnmappableCharacter methods.</para><para>The default replacement bytes depend on the charset but can be overridden using the replaceWith method.</para><para>This class is abstract and encapsulates many common operations of the encoding process for all charsets. Encoders for a specific charset should extend this class and need only to implement the encodeLoop method for basic encoding. If a subclass maintains internal state, it should also override the implFlush and implReset methods.</para><para>This class is not thread-safe.</para><para><para>java.nio.charset.Charset </para><simplesectsep></simplesectsep><para>java.nio.charset.CharsetDecoder </para></para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/CharsetEncoder
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CharsetEncoder", AccessFlags = 1057)]
		public abstract partial class CharsetEncoder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> CharsetEncoder </c> using the given parameters and the replacement byte array <c> { (byte) '?' } </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF)V", AccessFlags = 4)]
				protected internal CharsetEncoder(global::Java.Nio.Charset.Charset cs, float averageBytesPerChar, float maxBytesPerChar) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <code>CharsetEncoder</code> using the given <code>Charset</code>, replacement byte array, average number and maximum number of bytes created by this encoder for one input character.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF[B)V", AccessFlags = 4)]
				protected internal CharsetEncoder(global::Java.Nio.Charset.Charset cs, float averageBytesPerChar, float maxBytesPerChar, sbyte[] replacement) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <code>CharsetEncoder</code> using the given <code>Charset</code>, replacement byte array, average number and maximum number of bytes created by this encoder for one input character.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/charset/Charset;FF[B)V", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal CharsetEncoder(global::Java.Nio.Charset.Charset cs, float averageBytesPerChar, float maxBytesPerChar, byte[] replacement) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the average number of bytes created by this encoder for a single input character. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Returns the Charset which this encoder uses. </para>        
				/// </summary>
				/// <java-name>
				/// charset
				/// </java-name>
				[Dot42.DexImport("charset", "()Ljava/nio/charset/Charset;", AccessFlags = 17)]
				public global::Java.Nio.Charset.Charset Charset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <summary>
				/// <para>This is a facade method for the encoding operation. </para><para>This method encodes the remaining character sequence of the given character buffer into a new byte buffer. This method performs a complete encoding operation, resets at first, then encodes, and flushes at last. </para><para>This method should not be invoked if another encode operation is ongoing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <code>ByteBuffer</code> containing the bytes produced by this encoding operation. The buffer's limit will be the position of the last byte in the buffer, and the position will be zero. </para>
				/// </returns>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Encode(global::Java.Nio.CharBuffer @in) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Encodes characters starting at the current position of the given input buffer, and writes the equivalent byte sequence into the given output buffer from its current position. </para><para>The buffers' position will be changed with the reading and writing operation, but their limits and marks will be kept intact. </para><para>A <code>CoderResult</code> instance will be returned according to following rules: <ul><li><para>A malformed input result indicates that some malformed input error was encountered, and the erroneous characters start at the input buffer's position and their number can be got by result's length. This kind of result can be returned only if the malformed action is CodingErrorAction.REPORT. </para></li><li><para>CoderResult.UNDERFLOW indicates that as many characters as possible in the input buffer have been encoded. If there is no further input and no characters left in the input buffer then this task is complete. If this is not the case then the client should call this method again supplying some more input characters. </para></li><li><para>CoderResult.OVERFLOW indicates that the output buffer has been filled, while there are still some characters remaining in the input buffer. This method should be invoked again with a non-full output buffer. </para></li><li><para>A unmappable character result indicates that some unmappable character error was encountered, and the erroneous characters start at the input buffer's position and their number can be got by result's length. This kind of result can be returned only on CodingErrorAction.REPORT. </para></li></ul></para><para>The <code>endOfInput</code> parameter indicates if the invoker can provider further input. This parameter is true if and only if the characters in the current input buffer are all inputs for this encoding operation. Note that it is common and won't cause an error if the invoker sets false and then has no more input available, while it may cause an error if the invoker always sets true in several consecutive invocations. This would make the remaining input to be treated as malformed input. input. </para><para>This method invokes the encodeLoop method to implement the basic encode logic for a specific charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <code>CoderResult</code> instance indicating the result. </para>
				/// </returns>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Encode(global::Java.Nio.CharBuffer @in, global::Java.Nio.ByteBuffer @out, bool endOfInput) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Encodes characters into bytes. This method is called by encode. </para><para>This method will implement the essential encoding operation, and it won't stop encoding until either all the input characters are read, the output buffer is filled, or some exception is encountered. Then it will return a <code>CoderResult</code> object indicating the result of the current encoding operation. The rule to construct the <code>CoderResult</code> is the same as for encode. When an exception is encountered in the encoding operation, most implementations of this method will return a relevant result object to the encode method, and some performance optimized implementation may handle the exception and implement the error action itself. </para><para>The buffers are scanned from their current positions, and their positions will be modified accordingly, while their marks and limits will be intact. At most in.remaining() characters will be read, and out.remaining() bytes will be written. </para><para>Note that some implementations may pre-scan the input buffer and return <code>CoderResult.UNDERFLOW</code> until it receives sufficient input. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <code>CoderResult</code> instance indicating the result. </para>
				/// </returns>
				/// <java-name>
				/// encodeLoop
				/// </java-name>
				[Dot42.DexImport("encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 1028)]
				protected internal abstract global::Java.Nio.Charset.CoderResult EncodeLoop(global::Java.Nio.CharBuffer @in, global::Java.Nio.ByteBuffer @out) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Flushes this encoder. </para><para>This method will call implFlush. Some encoders may need to write some bytes to the output buffer when they have read all input characters, subclasses can overridden implFlush to perform writing action. </para><para>The maximum number of written bytes won't larger than out.remaining(). If some encoder wants to write more bytes than the output buffer's available remaining space, then <code>CoderResult.OVERFLOW</code> will be returned, and this method must be called again with a byte buffer that has free space. Otherwise this method will return <code>CoderResult.UNDERFLOW</code>, which means one encoding process has been completed successfully. </para><para>During the flush, the output buffer's position will be changed accordingly, while its mark and limit will be intact.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>CoderResult.UNDERFLOW</code> or <code>CoderResult.OVERFLOW</code>. </para>
				/// </returns>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CoderResult Flush(global::Java.Nio.ByteBuffer @out) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Flushes this encoder. The default implementation does nothing and always returns <code>CoderResult.UNDERFLOW</code>; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>CoderResult.UNDERFLOW</code> or <code>CoderResult.OVERFLOW</code>. </para>
				/// </returns>
				/// <java-name>
				/// implFlush
				/// </java-name>
				[Dot42.DexImport("implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", AccessFlags = 4)]
				protected internal virtual global::Java.Nio.Charset.CoderResult ImplFlush(global::Java.Nio.ByteBuffer @out) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Notifies that this encoder's <code>CodingErrorAction</code> specified for malformed input error has been changed. The default implementation does nothing; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implOnMalformedInput
				/// </java-name>
				[Dot42.DexImport("implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnMalformedInput(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies that this encoder's <code>CodingErrorAction</code> specified for unmappable character error has been changed. The default implementation does nothing; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implOnUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V", AccessFlags = 4)]
				protected internal virtual void ImplOnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies that this encoder's replacement has been changed. The default implementation does nothing; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implReplaceWith
				/// </java-name>
				[Dot42.DexImport("implReplaceWith", "([B)V", AccessFlags = 4)]
				protected internal virtual void ImplReplaceWith(sbyte[] newReplacement) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies that this encoder's replacement has been changed. The default implementation does nothing; this method can be overridden if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implReplaceWith
				/// </java-name>
				[Dot42.DexImport("implReplaceWith", "([B)V", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual void ImplReplaceWith(byte[] newReplacement) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resets this encoder's charset related state. The default implementation does nothing; this method can be overridden if needed. </para>        
				/// </summary>
				/// <java-name>
				/// implReset
				/// </java-name>
				[Dot42.DexImport("implReset", "()V", AccessFlags = 4)]
				protected internal virtual void ImplReset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks if the given argument is legal as this encoder's replacement byte array.</para><para>The given byte array is legal if and only if it can be decode into sixteen bits Unicode characters.</para><para>This method can be overridden for performance improvement.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the the given argument is legal as this encoder's replacement byte array. </para>
				/// </returns>
				/// <java-name>
				/// isLegalReplacement
				/// </java-name>
				[Dot42.DexImport("isLegalReplacement", "([B)Z", AccessFlags = 1)]
				public virtual bool IsLegalReplacement(sbyte[] replacement) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks if the given argument is legal as this encoder's replacement byte array.</para><para>The given byte array is legal if and only if it can be decode into sixteen bits Unicode characters.</para><para>This method can be overridden for performance improvement.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the the given argument is legal as this encoder's replacement byte array. </para>
				/// </returns>
				/// <java-name>
				/// isLegalReplacement
				/// </java-name>
				[Dot42.DexImport("isLegalReplacement", "([B)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool IsLegalReplacement(byte[] replacement) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this encoder's <code>CodingErrorAction</code> when a malformed input error occurred during the encoding process. </para>        
				/// </summary>
				/// <java-name>
				/// malformedInputAction
				/// </java-name>
				[Dot42.DexImport("malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;", AccessFlags = 1)]
				public virtual global::Java.Nio.Charset.CodingErrorAction MalformedInputAction() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CodingErrorAction);
				}

				/// <summary>
				/// <para>Returns the maximum number of bytes which can be created by this encoder for one input character, must be positive. </para>        
				/// </summary>
				/// <java-name>
				/// maxBytesPerChar
				/// </java-name>
				[Dot42.DexImport("maxBytesPerChar", "()F", AccessFlags = 17)]
				public float MaxBytesPerChar() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets this encoder's action on malformed input error.</para><para>This method will call the implOnMalformedInput method with the given new action as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this encoder. </para>
				/// </returns>
				/// <java-name>
				/// onMalformedInput
				/// </java-name>
				[Dot42.DexImport("onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder OnMalformedInput(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <summary>
				/// <para>Sets this encoder's action on unmappable character error.</para><para>This method will call the implOnUnmappableCharacter method with the given new action as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this encoder. </para>
				/// </returns>
				/// <java-name>
				/// onUnmappableCharacter
				/// </java-name>
				[Dot42.DexImport("onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder OnUnmappableCharacter(global::Java.Nio.Charset.CodingErrorAction newAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <summary>
				/// <para>Returns the replacement byte array, which is never null or empty. </para>        
				/// </summary>
				/// <java-name>
				/// replacement
				/// </java-name>
				[Dot42.DexImport("replacement", "()[B", AccessFlags = 17)]
				public sbyte[] JavaReplacement() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the replacement byte array, which is never null or empty. </para>        
				/// </summary>
				/// <java-name>
				/// replacement
				/// </java-name>
				[Dot42.DexImport("replacement", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Replacement() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Sets the new replacement value.</para><para>This method first checks the given replacement's validity, then changes the replacement value and finally calls the implReplaceWith method with the given new replacement as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this encoder. </para>
				/// </returns>
				/// <java-name>
				/// replaceWith
				/// </java-name>
				[Dot42.DexImport("replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder ReplaceWith(sbyte[] replacement) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <summary>
				/// <para>Sets the new replacement value.</para><para>This method first checks the given replacement's validity, then changes the replacement value and finally calls the implReplaceWith method with the given new replacement as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this encoder. </para>
				/// </returns>
				/// <java-name>
				/// replaceWith
				/// </java-name>
				[Dot42.DexImport("replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17, IgnoreFromJava = true)]
				public global::Java.Nio.Charset.CharsetEncoder ReplaceWith(byte[] replacement) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <summary>
				/// <para>Resets this encoder. This method will reset the internal status and then calls <code>implReset()</code> to reset any status related to the specific charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this encoder. </para>
				/// </returns>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/nio/charset/CharsetEncoder;", AccessFlags = 17)]
				public global::Java.Nio.Charset.CharsetEncoder Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CharsetEncoder);
				}

				/// <summary>
				/// <para>Returns this encoder's <code>CodingErrorAction</code> when unmappable character occurred during encoding process. </para>        
				/// </summary>
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

		/// <summary>
		/// <para>Used to indicate the result of encoding/decoding. There are four types of results: <ol><li><para>UNDERFLOW indicates that all input has been processed but more input is required. It is represented by the unique object <code>CoderResult.UNDERFLOW</code>. </para></li><li><para>OVERFLOW indicates an insufficient output buffer size. It is represented by the unique object <code>CoderResult.OVERFLOW</code>. </para></li><li><para>A malformed-input error indicates that an unrecognizable sequence of input units has been encountered. Get an instance of this type of result by calling <code>CoderResult.malformedForLength(int)</code> with the length of the malformed-input. </para></li><li><para>An unmappable-character error indicates that a sequence of input units can not be mapped to the output charset. Get an instance of this type of result by calling <code>CoderResult.unmappableForLength(int)</code> with the input sequence size indicating the identity of the unmappable character. </para></li></ol></para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/CoderResult
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CoderResult", AccessFlags = 33)]
		public partial class CoderResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Result object indicating that there is insufficient data in the encoding/decoding buffer or that additional data is required. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERFLOW
				/// </java-name>
				[Dot42.DexImport("UNDERFLOW", "Ljava/nio/charset/CoderResult;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CoderResult UNDERFLOW;
				/// <summary>
				/// <para>Result object used to indicate that the output buffer does not have enough space available to store the result of the encoding/decoding. </para>        
				/// </summary>
				/// <java-name>
				/// OVERFLOW
				/// </java-name>
				[Dot42.DexImport("OVERFLOW", "Ljava/nio/charset/CoderResult;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CoderResult OVERFLOW;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CoderResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets a <code>CoderResult</code> object indicating a malformed-input error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <code>CoderResult</code> object indicating a malformed-input error. </para>
				/// </returns>
				/// <java-name>
				/// malformedForLength
				/// </java-name>
				[Dot42.DexImport("malformedForLength", "(I)Ljava/nio/charset/CoderResult;", AccessFlags = 41)]
				public static global::Java.Nio.Charset.CoderResult MalformedForLength(int length) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Gets a <code>CoderResult</code> object indicating an unmappable character error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <code>CoderResult</code> object indicating an unmappable character error. </para>
				/// </returns>
				/// <java-name>
				/// unmappableForLength
				/// </java-name>
				[Dot42.DexImport("unmappableForLength", "(I)Ljava/nio/charset/CoderResult;", AccessFlags = 41)]
				public static global::Java.Nio.Charset.CoderResult UnmappableForLength(int length) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.CoderResult);
				}

				/// <summary>
				/// <para>Returns true if this result is an underflow condition.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if an underflow, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isUnderflow
				/// </java-name>
				[Dot42.DexImport("isUnderflow", "()Z", AccessFlags = 1)]
				public virtual bool IsUnderflow() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this result represents a malformed-input error or an unmappable-character error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this is a malformed-input error or an unmappable-character error, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isError
				/// </java-name>
				[Dot42.DexImport("isError", "()Z", AccessFlags = 1)]
				public virtual bool IsError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this result represents a malformed-input error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this is a malformed-input error, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isMalformed
				/// </java-name>
				[Dot42.DexImport("isMalformed", "()Z", AccessFlags = 1)]
				public virtual bool IsMalformed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this result is an overflow condition.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this is an overflow, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isOverflow
				/// </java-name>
				[Dot42.DexImport("isOverflow", "()Z", AccessFlags = 1)]
				public virtual bool IsOverflow() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this result represents an unmappable-character error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this is an unmappable-character error, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isUnmappable
				/// </java-name>
				[Dot42.DexImport("isUnmappable", "()Z", AccessFlags = 1)]
				public virtual bool IsUnmappable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the length of the erroneous input. The length is only meaningful to a malformed-input error or an unmappable character error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length, as an integer, of this object's erroneous input. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Throws an exception corresponding to this coder result.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// throwException
				/// </java-name>
				[Dot42.DexImport("throwException", "()V", AccessFlags = 1)]
				public virtual void ThrowException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a text description of this result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a text description of this result. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>A <c> CharacterCodingException </c> is thrown when an encoding or decoding error occurs. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/CharacterCodingException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CharacterCodingException", AccessFlags = 33)]
		public partial class CharacterCodingException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> CharacterCodingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CharacterCodingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> IllegalCharsetNameException </c> is thrown when an illegal charset name is encountered. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/IllegalCharsetNameException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/IllegalCharsetNameException", AccessFlags = 33)]
		public partial class IllegalCharsetNameException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IllegalCharsetNameException </c> with the supplied charset name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalCharsetNameException(string charsetName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the encountered illegal charset name. </para>        
				/// </summary>
				/// <java-name>
				/// getCharsetName
				/// </java-name>
				[Dot42.DexImport("getCharsetName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCharsetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IllegalCharsetNameException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the encountered illegal charset name. </para>        
				/// </summary>
				/// <java-name>
				/// getCharsetName
				/// </java-name>
				public string CharsetName
				{
				[Dot42.DexImport("getCharsetName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCharsetName(); }
				}

		}

		/// <summary>
		/// <para>An <c> UnsupportedCharsetException </c> is thrown when an unsupported charset name is encountered. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/UnsupportedCharsetException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/UnsupportedCharsetException", AccessFlags = 33)]
		public partial class UnsupportedCharsetException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> UnsupportedCharsetException </c> with the supplied charset name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedCharsetException(string charsetName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the encountered unsupported charset name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encountered unsupported charset name. </para>
				/// </returns>
				/// <java-name>
				/// getCharsetName
				/// </java-name>
				[Dot42.DexImport("getCharsetName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCharsetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnsupportedCharsetException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the encountered unsupported charset name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encountered unsupported charset name. </para>
				/// </returns>
				/// <java-name>
				/// getCharsetName
				/// </java-name>
				public string CharsetName
				{
				[Dot42.DexImport("getCharsetName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCharsetName(); }
				}

		}

		/// <summary>
		/// <para>A charset is a named mapping between Unicode characters and byte sequences. Every <c> Charset </c> can <b>decode</b>, converting a byte sequence into a sequence of characters, and some can also <b>encode</b>, converting a sequence of characters into a byte sequence. Use the method canEncode to find out whether a charset supports both.</para><para><h4>Characters</h4></para><para>In the context of this class, <b>character</b> always refers to a Java character: a Unicode code point in the range U+0000 to U+FFFF. (Java represents supplementary characters using surrogates.) Not all byte sequences will represent a character, and not all characters can necessarily be represented by a given charset. The method contains can be used to determine whether every character representable by one charset can also be represented by another (meaning that a lossless transformation is possible from the contained to the container).</para><para><h4>Encodings</h4></para><para>There are many possible ways to represent Unicode characters as byte sequences. See  for detailed discussion.</para><para>The most important mappings capable of representing every character are the Unicode Transformation Format (UTF) charsets. Of those, UTF-8 and the UTF-16 family are the most common. UTF-8 (described in ) encodes a character using 1 to 4 bytes. UTF-16 uses exactly 2 bytes per character (potentially wasting space, but allowing efficient random access into BMP text), and UTF-32 uses exactly 4 bytes per character (trading off even more space for efficient random access into text that includes supplementary characters).</para><para>UTF-16 and UTF-32 encode characters directly, using their code point as a two- or four-byte integer. This means that any given UTF-16 or UTF-32 byte sequence is either big- or little-endian. To assist decoders, Unicode includes a special <b>byte order mark</b> (BOM) character U+FEFF used to determine the endianness of a sequence. The corresponding byte-swapped code point U+FFFE is guaranteed never to be assigned. If a UTF-16 decoder sees <c> 0xfe, 0xff </c> , for example, it knows it's reading a big-endian byte sequence, while <c> 0xff, 0xfe </c> , would indicate a little-endian byte sequence.</para><para>UTF-8 can contain a BOM, but since the UTF-8 encoding of a character always uses the same byte sequence, there is no information about endianness to convey. Seeing the bytes corresponding to the UTF-8 encoding of U+FEFF (<c> 0xef, 0xbb, 0xbf </c> ) would only serve to suggest that you're reading UTF-8. Note that BOMs are decoded as the U+FEFF character, and will appear in the output character sequence. This means that a disadvantage to including a BOM in UTF-8 is that most applications that use UTF-8 do not expect to see a BOM. (This is also a reason to prefer UTF-8: it's one less complication to worry about.)</para><para>Because a BOM indicates how the data that follows should be interpreted, a BOM should occur as the first character in a character sequence.</para><para>See the  for more about dealing with BOMs.</para><para><h4>Endianness and BOM behavior</h4></para><para>The following tables show the endianness and BOM behavior of the UTF-16 variants.</para><para>This table shows what the encoder writes. "BE" means that the byte sequence is big-endian, "LE" means little-endian. "BE BOM" means a big-endian BOM (that is, <c> 0xfe, 0xff </c> ). </para><para><table><row><entry><para>Charset </para></entry><entry><para>Encoder writes  </para></entry></row><row><entry><para>UTF-16BE </para></entry><entry><para>BE, no BOM  </para></entry></row><row><entry><para>UTF-16LE </para></entry><entry><para>LE, no BOM  </para></entry></row><row><entry><para>UTF-16 </para></entry><entry><para>BE, with BE BOM  </para></entry></row></table></para><para>The next table shows how each variant's decoder behaves when reading a byte sequence. The exact meaning of "failure" in the table is dependent on the CodingErrorAction supplied to CharsetDecoder#malformedInputAction, so "BE, failure" means "the byte sequence is treated as big-endian, and a little-endian BOM   triggers the malformedInputAction".</para><para>The phrase "includes BOM" means that the output includes the U+FEFF byte order mark character.</para><para><table><row><entry><para>Charset </para></entry><entry><para>BE BOM </para></entry><entry><para>LE BOM </para></entry><entry><para>No BOM  </para></entry></row><row><entry><para>UTF-16BE </para></entry><entry><para>BE, includes BOM </para></entry><entry><para>BE, failure </para></entry><entry><para>BE  </para></entry></row><row><entry><para>UTF-16LE </para></entry><entry><para>LE, failure </para></entry><entry><para>LE, includes BOM </para></entry><entry><para>LE  </para></entry></row><row><entry><para>UTF-16 </para></entry><entry><para>BE </para></entry><entry><para>LE </para></entry><entry><para>BE  </para></entry></row></table></para><para><h4>Charset names</h4></para><para>A charset has a canonical name, returned by name. Most charsets will also have one or more aliases, returned by aliases. A charset can be looked up by canonical name or any of its aliases using forName.</para><para><h4>Guaranteed-available charsets</h4></para><para>The following charsets are available on every Java implementation: <ul><li><para>ISO-8859-1 </para></li><li><para>US-ASCII </para></li><li><para>UTF-16 </para></li><li><para>UTF-16BE </para></li><li><para>UTF-16LE </para></li><li><para>UTF-8 </para></li></ul></para><para>All of these charsets support both decoding and encoding. The charsets whose names begin "UTF" can represent all characters, as mentioned above. The "ISO-8859-1" and "US-ASCII" charsets can only represent small subsets of these characters. Except when required to do otherwise for compatibility, new code should use one of the UTF charsets listed above. The platform's default charset is UTF-8. (This is in contrast to some older implementations, where the default charset depended on the user's locale.)</para><para>Most implementations will support hundreds of charsets. Use availableCharsets or isSupported to see what's available. If you intend to use the charset if it's available, just call forName and catch the exceptions it throws if the charset isn't available.</para><para>Additional charsets can be made available by configuring one or more charset providers through provider configuration files. Such files are always named as "java.nio.charset.spi.CharsetProvider" and located in the "META-INF/services" directory of one or more classpaths. The files should be encoded in "UTF-8". Each line of their content specifies the class name of a charset provider which extends java.nio.charset.spi.CharsetProvider. A line should end with '', '<br></br>' or '<br></br>'. Leading and trailing whitespace is trimmed. Blank lines, and lines (after trimming) starting with "#" which are regarded as comments, are both ignored. Duplicates of names already found are also ignored. Both the configuration files and the provider classes will be loaded using the thread context class loader.</para><para>Although class is thread-safe, the CharsetDecoder and CharsetEncoder instances it returns are inherently stateful. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/Charset
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/Charset", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/nio/charset/Charset;>;")]
		public abstract partial class Charset : global::System.IComparable<global::Java.Nio.Charset.Charset>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <code>Charset</code> object. Duplicated aliases are ignored.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Charset(string canonicalName, string[] aliases) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an immutable case-insensitive map from canonical names to <c> Charset </c> instances. If multiple charsets have the same canonical name, it is unspecified which is returned in the map. This method may be slow. If you know which charset you're looking for, use forName. </para>        
				/// </summary>
				/// <returns>
				/// <para>an immutable case-insensitive map from canonical names to <c> Charset </c> instances </para>
				/// </returns>
				/// <java-name>
				/// availableCharsets
				/// </java-name>
				[Dot42.DexImport("availableCharsets", "()Ljava/util/SortedMap;", AccessFlags = 9, Signature = "()Ljava/util/SortedMap<Ljava/lang/String;Ljava/nio/charset/Charset;>;")]
				public static global::Java.Util.ISortedMap<string, global::Java.Nio.Charset.Charset> AvailableCharsets() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<string, global::Java.Nio.Charset.Charset>);
				}

				/// <summary>
				/// <para>Returns a <c> Charset </c> instance for the named charset.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forName
				/// </java-name>
				[Dot42.DexImport("forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", AccessFlags = 9)]
				public static global::Java.Nio.Charset.Charset ForName(string charsetName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Charset.Charset);
				}

				/// <summary>
				/// <para>Determines whether the specified charset is supported by this runtime.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the specified charset is supported, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isSupported
				/// </java-name>
				[Dot42.DexImport("isSupported", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsSupported(string charsetName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Determines whether this charset is a superset of the given charset. A charset C1 contains charset C2 if every character representable by C2 is also representable by C1. This means that lossless conversion is possible from C2 to C1 (but not necessarily the other way round). It does <b>not</b> imply that the two charsets use the same byte sequences for the characters they share.</para><para>Note that this method is allowed to be conservative, and some implementations may return false when this charset does contain the other charset. Android's implementation is precise, and will always return true in such cases.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this charset is a super set of the given charset, false if it's unknown or this charset is not a superset of the given charset. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/nio/charset/Charset;)Z", AccessFlags = 1025)]
				public abstract bool Contains(global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets a new instance of an encoder for this charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of an encoder for this charset. </para>
				/// </returns>
				/// <java-name>
				/// newEncoder
				/// </java-name>
				[Dot42.DexImport("newEncoder", "()Ljava/nio/charset/CharsetEncoder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Charset.CharsetEncoder NewEncoder() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets a new instance of a decoder for this charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of a decoder for this charset. </para>
				/// </returns>
				/// <java-name>
				/// newDecoder
				/// </java-name>
				[Dot42.DexImport("newDecoder", "()Ljava/nio/charset/CharsetDecoder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Charset.CharsetDecoder NewDecoder() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the canonical name of this charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this charset's name in canonical form. </para>
				/// </returns>
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 17)]
				public string Name() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the set of this charset's aliases.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an unmodifiable set of this charset's aliases. </para>
				/// </returns>
				/// <java-name>
				/// aliases
				/// </java-name>
				[Dot42.DexImport("aliases", "()Ljava/util/Set;", AccessFlags = 17, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public global::Java.Util.ISet<string> Aliases() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				/// <para>Gets the name of this charset for the default locale.</para><para>The default implementation returns the canonical name of this charset. Subclasses may return a localized display name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this charset for the default locale. </para>
				/// </returns>
				/// <java-name>
				/// displayName
				/// </java-name>
				[Dot42.DexImport("displayName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string DisplayName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the name of this charset for the specified locale.</para><para>The default implementation returns the canonical name of this charset. Subclasses may return a localized display name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this charset for the specified locale </para>
				/// </returns>
				/// <java-name>
				/// displayName
				/// </java-name>
				[Dot42.DexImport("displayName", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string DisplayName(global::Java.Util.Locale l) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Indicates whether this charset is known to be registered in the IANA Charset Registry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the charset is known to be registered, otherwise returns false. </para>
				/// </returns>
				/// <java-name>
				/// isRegistered
				/// </java-name>
				[Dot42.DexImport("isRegistered", "()Z", AccessFlags = 17)]
				public bool IsRegistered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this charset supports encoding, false otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this charset supports encoding, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// canEncode
				/// </java-name>
				[Dot42.DexImport("canEncode", "()Z", AccessFlags = 1)]
				public virtual bool CanEncode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a new <c> ByteBuffer </c> containing the bytes encoding the characters from <c> buffer </c> . This method uses <c> CodingErrorAction.REPLACE </c> .</para><para>Applications should generally create a CharsetEncoder using newEncoder for performance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result of the encoding. </para>
				/// </returns>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Encode(global::Java.Nio.CharBuffer buffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Returns a new <c> ByteBuffer </c> containing the bytes encoding the characters from <c> buffer </c> . This method uses <c> CodingErrorAction.REPLACE </c> .</para><para>Applications should generally create a CharsetEncoder using newEncoder for performance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result of the encoding. </para>
				/// </returns>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Encode(string buffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Returns a new <c> CharBuffer </c> containing the characters decoded from <c> buffer </c> . This method uses <c> CodingErrorAction.REPLACE </c> .</para><para>Applications should generally create a CharsetDecoder using newDecoder for performance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a character buffer containing the output of the decoding. </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Decode(global::Java.Nio.ByteBuffer buffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <summary>
				/// <para>Compares this charset with the given charset. This comparison is based on the case insensitive canonical names of the charsets.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative integer if less than the given object, a positive integer if larger than it, or 0 if equal to it. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/charset/Charset;)I", AccessFlags = 17)]
				public int CompareTo(global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines whether this charset equals to the given object. They are considered to be equal if they have the same canonical name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if they have the same canonical name, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the hash code of this charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code of this charset. </para>
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
				/// <para>Gets a string representation of this charset. Usually this contains the canonical name of the charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string representation of this charset. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the system's default charset. This is determined during VM startup, and will not change thereafter. On Android, the default charset is UTF-8. </para>        
				/// </summary>
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

		}

		/// <summary>
		/// <para>A <c> MalformedInputException </c> is thrown when a malformed input is encountered, for example if a byte sequence is illegal for the given charset. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/MalformedInputException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/MalformedInputException", AccessFlags = 33)]
		public partial class MalformedInputException : global::Java.Nio.Charset.CharacterCodingException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> MalformedInputException </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public MalformedInputException(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the length of the malformed input.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the malformed input. </para>
				/// </returns>
				/// <java-name>
				/// getInputLength
				/// </java-name>
				[Dot42.DexImport("getInputLength", "()I", AccessFlags = 1)]
				public virtual int GetInputLength() /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <summary>
				/// <para>Gets the length of the malformed input.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the malformed input. </para>
				/// </returns>
				/// <java-name>
				/// getInputLength
				/// </java-name>
				public int InputLength
				{
				[Dot42.DexImport("getInputLength", "()I", AccessFlags = 1)]
						get{ return GetInputLength(); }
				}

		}

		/// <summary>
		/// <para>An <c> UnmappableCharacterException </c> is thrown when an unmappable character for the given charset is encountered. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/UnmappableCharacterException
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/UnmappableCharacterException", AccessFlags = 33)]
		public partial class UnmappableCharacterException : global::Java.Nio.Charset.CharacterCodingException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> UnmappableCharacterException </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public UnmappableCharacterException(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the length of the unmappable character. </para>        
				/// </summary>
				/// <java-name>
				/// getInputLength
				/// </java-name>
				[Dot42.DexImport("getInputLength", "()I", AccessFlags = 1)]
				public virtual int GetInputLength() /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <summary>
				/// <para>Returns the length of the unmappable character. </para>        
				/// </summary>
				/// <java-name>
				/// getInputLength
				/// </java-name>
				public int InputLength
				{
				[Dot42.DexImport("getInputLength", "()I", AccessFlags = 1)]
						get{ return GetInputLength(); }
				}

		}

		/// <summary>
		/// <para>A <c> CoderMalfunctionError </c> is thrown when the encoder/decoder is malfunctioning. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/CoderMalfunctionError
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CoderMalfunctionError", AccessFlags = 33)]
		public partial class CoderMalfunctionError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> CoderMalfunctionError </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public CoderMalfunctionError(global::System.Exception ex) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CoderMalfunctionError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Used to indicate what kind of actions to take in case of encoding/decoding errors. Currently three actions are defined: <c> IGNORE </c> , <c> REPLACE </c> and <c> REPORT </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/CodingErrorAction
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/CodingErrorAction", AccessFlags = 33)]
		public partial class CodingErrorAction
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Denotes the action to ignore any errors. </para>        
				/// </summary>
				/// <java-name>
				/// IGNORE
				/// </java-name>
				[Dot42.DexImport("IGNORE", "Ljava/nio/charset/CodingErrorAction;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CodingErrorAction IGNORE;
				/// <summary>
				/// <para>Denotes the action to fill in the output with a replacement character when malformed input or an unmappable character is encountered. </para>        
				/// </summary>
				/// <java-name>
				/// REPLACE
				/// </java-name>
				[Dot42.DexImport("REPLACE", "Ljava/nio/charset/CodingErrorAction;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CodingErrorAction REPLACE;
				/// <summary>
				/// <para>Denotes the action to report the encountered error in an appropriate manner, for example to throw an exception or return an informative result. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT
				/// </java-name>
				[Dot42.DexImport("REPORT", "Ljava/nio/charset/CodingErrorAction;", AccessFlags = 25)]
				public static readonly global::Java.Nio.Charset.CodingErrorAction REPORT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CodingErrorAction() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a text description of this action indication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a text description of this action indication. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

}


