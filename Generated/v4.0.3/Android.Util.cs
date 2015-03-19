#pragma warning disable 1717
namespace Android.Util
{
		/// <java-name>
		/// android/util/JsonWriter
		/// </java-name>
		[Dot42.DexImport("android/util/JsonWriter", AccessFlags = 49)]
		public sealed partial class JsonWriter : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public JsonWriter(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIndent
				/// </java-name>
				[Dot42.DexImport("setIndent", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetIndent(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLenient
				/// </java-name>
				[Dot42.DexImport("setLenient", "(Z)V", AccessFlags = 1)]
				public void SetLenient(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLenient
				/// </java-name>
				[Dot42.DexImport("isLenient", "()Z", AccessFlags = 1)]
				public bool IsLenient() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// beginArray
				/// </java-name>
				[Dot42.DexImport("beginArray", "()Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter BeginArray() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// endArray
				/// </java-name>
				[Dot42.DexImport("endArray", "()Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter EndArray() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// beginObject
				/// </java-name>
				[Dot42.DexImport("beginObject", "()Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter BeginObject() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// endObject
				/// </java-name>
				[Dot42.DexImport("endObject", "()Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter EndObject() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "(Ljava/lang/String;)Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter Name(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(Ljava/lang/String;)Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter Value(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// nullValue
				/// </java-name>
				[Dot42.DexImport("nullValue", "()Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter NullValue() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(Z)Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter Value(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(D)Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter Value(double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(J)Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter Value(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(Ljava/lang/Number;)Landroid/util/JsonWriter;", AccessFlags = 1)]
				public global::Android.Util.JsonWriter Value(global::Java.Lang.Number number) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonWriter);
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JsonWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/SparseIntArray
		/// </java-name>
		[Dot42.DexImport("android/util/SparseIntArray", AccessFlags = 33)]
		public partial class SparseIntArray : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SparseIntArray() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SparseIntArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/util/SparseIntArray;", AccessFlags = 1)]
				public virtual global::Android.Util.SparseIntArray Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseIntArray);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 1)]
				public virtual int Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)I", AccessFlags = 1)]
				public virtual int Get(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(I)V", AccessFlags = 1)]
				public virtual void Delete(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAt
				/// </java-name>
				[Dot42.DexImport("removeAt", "(I)V", AccessFlags = 1)]
				public virtual void RemoveAt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(II)V", AccessFlags = 1)]
				public virtual void Put(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// keyAt
				/// </java-name>
				[Dot42.DexImport("keyAt", "(I)I", AccessFlags = 1)]
				public virtual int KeyAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueAt
				/// </java-name>
				[Dot42.DexImport("valueAt", "(I)I", AccessFlags = 1)]
				public virtual int ValueAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOfKey
				/// </java-name>
				[Dot42.DexImport("indexOfKey", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfKey(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOfValue
				/// </java-name>
				[Dot42.DexImport("indexOfValue", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfValue(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(II)V", AccessFlags = 1)]
				public virtual void Append(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/util/DisplayMetrics
		/// </java-name>
		[Dot42.DexImport("android/util/DisplayMetrics", AccessFlags = 33)]
		public partial class DisplayMetrics
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DENSITY_LOW
				/// </java-name>
				[Dot42.DexImport("DENSITY_LOW", "I", AccessFlags = 25)]
				public const int DENSITY_LOW = 120;
				/// <java-name>
				/// DENSITY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("DENSITY_MEDIUM", "I", AccessFlags = 25)]
				public const int DENSITY_MEDIUM = 160;
				/// <java-name>
				/// DENSITY_TV
				/// </java-name>
				[Dot42.DexImport("DENSITY_TV", "I", AccessFlags = 25)]
				public const int DENSITY_TV = 213;
				/// <java-name>
				/// DENSITY_HIGH
				/// </java-name>
				[Dot42.DexImport("DENSITY_HIGH", "I", AccessFlags = 25)]
				public const int DENSITY_HIGH = 240;
				/// <java-name>
				/// DENSITY_XHIGH
				/// </java-name>
				[Dot42.DexImport("DENSITY_XHIGH", "I", AccessFlags = 25)]
				public const int DENSITY_XHIGH = 320;
				/// <java-name>
				/// DENSITY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("DENSITY_DEFAULT", "I", AccessFlags = 25)]
				public const int DENSITY_DEFAULT = 160;
				/// <java-name>
				/// widthPixels
				/// </java-name>
				[Dot42.DexImport("widthPixels", "I", AccessFlags = 1)]
				public int WidthPixels;
				/// <java-name>
				/// heightPixels
				/// </java-name>
				[Dot42.DexImport("heightPixels", "I", AccessFlags = 1)]
				public int HeightPixels;
				/// <java-name>
				/// density
				/// </java-name>
				[Dot42.DexImport("density", "F", AccessFlags = 1)]
				public float Density;
				/// <java-name>
				/// densityDpi
				/// </java-name>
				[Dot42.DexImport("densityDpi", "I", AccessFlags = 1)]
				public int DensityDpi;
				/// <java-name>
				/// scaledDensity
				/// </java-name>
				[Dot42.DexImport("scaledDensity", "F", AccessFlags = 1)]
				public float ScaledDensity;
				/// <java-name>
				/// xdpi
				/// </java-name>
				[Dot42.DexImport("xdpi", "F", AccessFlags = 1)]
				public float Xdpi;
				/// <java-name>
				/// ydpi
				/// </java-name>
				[Dot42.DexImport("ydpi", "F", AccessFlags = 1)]
				public float Ydpi;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DisplayMetrics() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTo
				/// </java-name>
				[Dot42.DexImport("setTo", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void SetTo(global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setToDefaults
				/// </java-name>
				[Dot42.DexImport("setToDefaults", "()V", AccessFlags = 1)]
				public virtual void SetToDefaults() /* MethodBuilder.Create */ 
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
		/// android/util/FloatMath
		/// </java-name>
		[Dot42.DexImport("android/util/FloatMath", AccessFlags = 33)]
		public partial class FloatMath
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FloatMath() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(F)F", AccessFlags = 265)]
				public static float Floor(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// ceil
				/// </java-name>
				[Dot42.DexImport("ceil", "(F)F", AccessFlags = 265)]
				public static float Ceil(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// sin
				/// </java-name>
				[Dot42.DexImport("sin", "(F)F", AccessFlags = 265)]
				public static float Sin(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// cos
				/// </java-name>
				[Dot42.DexImport("cos", "(F)F", AccessFlags = 265)]
				public static float Cos(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// sqrt
				/// </java-name>
				[Dot42.DexImport("sqrt", "(F)F", AccessFlags = 265)]
				public static float Sqrt(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/util/MalformedJsonException
		/// </java-name>
		[Dot42.DexImport("android/util/MalformedJsonException", AccessFlags = 49)]
		public sealed partial class MalformedJsonException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedJsonException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MalformedJsonException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/Base64DataException
		/// </java-name>
		[Dot42.DexImport("android/util/Base64DataException", AccessFlags = 33)]
		public partial class Base64DataException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Base64DataException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Base64DataException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/PrintStreamPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/PrintStreamPrinter", AccessFlags = 33)]
		public partial class PrintStreamPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public PrintStreamPrinter(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintStreamPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/TimeFormatException
		/// </java-name>
		[Dot42.DexImport("android/util/TimeFormatException", AccessFlags = 33)]
		public partial class TimeFormatException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TimeFormatException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/util/Patterns
		/// </java-name>
		[Dot42.DexImport("android/util/Patterns", AccessFlags = 33)]
		public partial class Patterns
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TOP_LEVEL_DOMAIN_STR
				/// </java-name>
				[Dot42.DexImport("TOP_LEVEL_DOMAIN_STR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TOP_LEVEL_DOMAIN_STR = @"((aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(biz|b[abdefghijmnorstvwyz])|(cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(edu|e[cegrstu])|f[ijkmor]|(gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(info|int|i[delmnoqrst])|(jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(name|net|n[acefgilopruz])|(org|om)|(pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(δοκιμή|испытание|рф|срб|טעסט|آزمایشی|إختبار|الاردن|الجزائر|السعودية|المغرب|امارات|بھارت|تونس|سورية|فلسطين|قطر|مصر|परीक्षा|भारत|ভারত|ਭਾਰਤ|ભારત|இந்தியா|இலங்கை|சிங்கப்பூர்|பரிட்சை|భారత్|ලංකා|ไทย|テスト|中国|中國|台湾|台灣|新加坡|测试|測試|香港|테스트|한국|xn\-\-0zwm56d|xn\-\-11b5bs3a9aj6g|xn\-\-3e0b707e|xn\-\-45brj9c|xn\-\-80akhbyknj4f|xn\-\-90a3ac|xn\-\-9t4b11yi5a|xn\-\-clchc0ea0b2g2a9gcd|xn\-\-deba0ad|xn\-\-fiqs8s|xn\-\-fiqz9s|xn\-\-fpcrj9c3d|xn\-\-fzc2c9e2c|xn\-\-g6w251d|xn\-\-gecrj9c|xn\-\-h2brj9c|xn\-\-hgbk6aj7f53bba|xn\-\-hlcj6aya9esc7a|xn\-\-j6w193g|xn\-\-jxalpdlp|xn\-\-kgbechtv|xn\-\-kprw13d|xn\-\-kpry57d|xn\-\-lgbbat1ad8j|xn\-\-mgbaam7a8h|xn\-\-mgbayh7gpa|xn\-\-mgbbh1a71e|xn\-\-mgbc0a9azcg|xn\-\-mgberp4a5d4ar|xn\-\-o3cw4h|xn\-\-ogbpf8fl|xn\-\-p1ai|xn\-\-pgbs0dh|xn\-\-s9brj9c|xn\-\-wgbh1c|xn\-\-wgbl6a|xn\-\-xkc2al3hye2a|xn\-\-xkc2dl3a5ee0h|xn\-\-yfro4i67o|xn\-\-ygbi2ammx|xn\-\-zckzah|xxx)|y[et]|z[amw])";
				/// <java-name>
				/// TOP_LEVEL_DOMAIN
				/// </java-name>
				[Dot42.DexImport("TOP_LEVEL_DOMAIN", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern TOP_LEVEL_DOMAIN;
				/// <java-name>
				/// TOP_LEVEL_DOMAIN_STR_FOR_WEB_URL
				/// </java-name>
				[Dot42.DexImport("TOP_LEVEL_DOMAIN_STR_FOR_WEB_URL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TOP_LEVEL_DOMAIN_STR_FOR_WEB_URL = @"(?:(?:aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(?:biz|b[abdefghijmnorstvwyz])|(?:cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(?:edu|e[cegrstu])|f[ijkmor]|(?:gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(?:info|int|i[delmnoqrst])|(?:jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(?:mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(?:name|net|n[acefgilopruz])|(?:org|om)|(?:pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(?:tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(?:δοκιμή|испытание|рф|срб|טעסט|آزمایشی|إختبار|الاردن|الجزائر|السعودية|المغرب|امارات|بھارت|تونس|سورية|فلسطين|قطر|مصر|परीक्षा|भारत|ভারত|ਭਾਰਤ|ભારત|இந்தியா|இலங்கை|சிங்கப்பூர்|பரிட்சை|భారత్|ලංකා|ไทย|テスト|中国|中國|台湾|台灣|新加坡|测试|測試|香港|테스트|한국|xn\-\-0zwm56d|xn\-\-11b5bs3a9aj6g|xn\-\-3e0b707e|xn\-\-45brj9c|xn\-\-80akhbyknj4f|xn\-\-90a3ac|xn\-\-9t4b11yi5a|xn\-\-clchc0ea0b2g2a9gcd|xn\-\-deba0ad|xn\-\-fiqs8s|xn\-\-fiqz9s|xn\-\-fpcrj9c3d|xn\-\-fzc2c9e2c|xn\-\-g6w251d|xn\-\-gecrj9c|xn\-\-h2brj9c|xn\-\-hgbk6aj7f53bba|xn\-\-hlcj6aya9esc7a|xn\-\-j6w193g|xn\-\-jxalpdlp|xn\-\-kgbechtv|xn\-\-kprw13d|xn\-\-kpry57d|xn\-\-lgbbat1ad8j|xn\-\-mgbaam7a8h|xn\-\-mgbayh7gpa|xn\-\-mgbbh1a71e|xn\-\-mgbc0a9azcg|xn\-\-mgberp4a5d4ar|xn\-\-o3cw4h|xn\-\-ogbpf8fl|xn\-\-p1ai|xn\-\-pgbs0dh|xn\-\-s9brj9c|xn\-\-wgbh1c|xn\-\-wgbl6a|xn\-\-xkc2al3hye2a|xn\-\-xkc2dl3a5ee0h|xn\-\-yfro4i67o|xn\-\-ygbi2ammx|xn\-\-zckzah|xxx)|y[et]|z[amw]))";
				/// <java-name>
				/// GOOD_IRI_CHAR
				/// </java-name>
				[Dot42.DexImport("GOOD_IRI_CHAR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string GOOD_IRI_CHAR = "a-zA-Z0-9 -퟿豈-﷏ﷰ-￯";
				/// <java-name>
				/// WEB_URL
				/// </java-name>
				[Dot42.DexImport("WEB_URL", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern WEB_URL;
				/// <java-name>
				/// IP_ADDRESS
				/// </java-name>
				[Dot42.DexImport("IP_ADDRESS", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern IP_ADDRESS;
				/// <java-name>
				/// DOMAIN_NAME
				/// </java-name>
				[Dot42.DexImport("DOMAIN_NAME", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern DOMAIN_NAME;
				/// <java-name>
				/// EMAIL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("EMAIL_ADDRESS", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern EMAIL_ADDRESS;
				/// <java-name>
				/// PHONE
				/// </java-name>
				[Dot42.DexImport("PHONE", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern PHONE;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Patterns() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// concatGroups
				/// </java-name>
				[Dot42.DexImport("concatGroups", "(Ljava/util/regex/Matcher;)Ljava/lang/String;", AccessFlags = 25)]
				public static string ConcatGroups(global::Java.Util.Regex.Matcher matcher) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// digitsAndPlusOnly
				/// </java-name>
				[Dot42.DexImport("digitsAndPlusOnly", "(Ljava/util/regex/Matcher;)Ljava/lang/String;", AccessFlags = 25)]
				public static string DigitsAndPlusOnly(global::Java.Util.Regex.Matcher matcher) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/util/MonthDisplayHelper
		/// </java-name>
		[Dot42.DexImport("android/util/MonthDisplayHelper", AccessFlags = 33)]
		public partial class MonthDisplayHelper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public MonthDisplayHelper(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public MonthDisplayHelper(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
				public virtual int GetYear() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
				public virtual int GetMonth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWeekStartDay
				/// </java-name>
				[Dot42.DexImport("getWeekStartDay", "()I", AccessFlags = 1)]
				public virtual int GetWeekStartDay() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFirstDayOfMonth
				/// </java-name>
				[Dot42.DexImport("getFirstDayOfMonth", "()I", AccessFlags = 1)]
				public virtual int GetFirstDayOfMonth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNumberOfDaysInMonth
				/// </java-name>
				[Dot42.DexImport("getNumberOfDaysInMonth", "()I", AccessFlags = 1)]
				public virtual int GetNumberOfDaysInMonth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
				public virtual int GetOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDigitsForRow
				/// </java-name>
				[Dot42.DexImport("getDigitsForRow", "(I)[I", AccessFlags = 1)]
				public virtual int[] GetDigitsForRow(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getDayAt
				/// </java-name>
				[Dot42.DexImport("getDayAt", "(II)I", AccessFlags = 1)]
				public virtual int GetDayAt(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRowOf
				/// </java-name>
				[Dot42.DexImport("getRowOf", "(I)I", AccessFlags = 1)]
				public virtual int GetRowOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnOf
				/// </java-name>
				[Dot42.DexImport("getColumnOf", "(I)I", AccessFlags = 1)]
				public virtual int GetColumnOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// previousMonth
				/// </java-name>
				[Dot42.DexImport("previousMonth", "()V", AccessFlags = 1)]
				public virtual void PreviousMonth() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextMonth
				/// </java-name>
				[Dot42.DexImport("nextMonth", "()V", AccessFlags = 1)]
				public virtual void NextMonth() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isWithinCurrentMonth
				/// </java-name>
				[Dot42.DexImport("isWithinCurrentMonth", "(II)Z", AccessFlags = 1)]
				public virtual bool IsWithinCurrentMonth(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MonthDisplayHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				public int Year
				{
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return GetYear(); }
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				public int Month
				{
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return GetMonth(); }
				}

				/// <java-name>
				/// getWeekStartDay
				/// </java-name>
				public int WeekStartDay
				{
				[Dot42.DexImport("getWeekStartDay", "()I", AccessFlags = 1)]
						get{ return GetWeekStartDay(); }
				}

				/// <java-name>
				/// getFirstDayOfMonth
				/// </java-name>
				public int FirstDayOfMonth
				{
				[Dot42.DexImport("getFirstDayOfMonth", "()I", AccessFlags = 1)]
						get{ return GetFirstDayOfMonth(); }
				}

				/// <java-name>
				/// getNumberOfDaysInMonth
				/// </java-name>
				public int NumberOfDaysInMonth
				{
				[Dot42.DexImport("getNumberOfDaysInMonth", "()I", AccessFlags = 1)]
						get{ return GetNumberOfDaysInMonth(); }
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				public int Offset
				{
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
						get{ return GetOffset(); }
				}

		}

		/// <java-name>
		/// android/util/EventLogTags
		/// </java-name>
		[Dot42.DexImport("android/util/EventLogTags", AccessFlags = 33)]
		public partial class EventLogTags
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EventLogTags() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/BufferedReader;)V", AccessFlags = 1)]
				public EventLogTags(global::Java.Io.BufferedReader bufferedReader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;", AccessFlags = 1)]
				public virtual global::Android.Util.EventLogTags.Description Get(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.EventLogTags.Description);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Landroid/util/EventLogTags$Description;", AccessFlags = 1)]
				public virtual global::Android.Util.EventLogTags.Description Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.EventLogTags.Description);
				}

				/// <java-name>
				/// android/util/EventLogTags$Description
				/// </java-name>
				[Dot42.DexImport("android/util/EventLogTags$Description", AccessFlags = 9)]
				public partial class Description
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mTag
						/// </java-name>
						[Dot42.DexImport("mTag", "I", AccessFlags = 17)]
						public readonly int MTag;
						/// <java-name>
						/// mName
						/// </java-name>
						[Dot42.DexImport("mName", "Ljava/lang/String;", AccessFlags = 17)]
						public readonly string MName;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Description() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/util/Pair
		/// </java-name>
		[Dot42.DexImport("android/util/Pair", AccessFlags = 33, Signature = "<F:Ljava/lang/Object;S:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class Pair<F, S>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "Ljava/lang/Object;", AccessFlags = 17)]
				public readonly F First;
				/// <java-name>
				/// second
				/// </java-name>
				[Dot42.DexImport("second", "Ljava/lang/Object;", AccessFlags = 17)]
				public readonly S Second;
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TF;TS;)V")]
				public Pair(F f, S s) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;", AccessFlags = 9, Signature = "<A:Ljava/lang/Object;B:Ljava/lang/Object;>(TA;TB;)Landroid/util/Pair<TA;TB;>;")]
				public static global::Android.Util.Pair<A, B> Create<A, B>(A a, B b) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.Pair<A, B>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Pair() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/StringBuilderPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/StringBuilderPrinter", AccessFlags = 33)]
		public partial class StringBuilderPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/StringBuilder;)V", AccessFlags = 1)]
				public StringBuilderPrinter(global::System.Text.StringBuilder stringBuilder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringBuilderPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/TimingLogger
		/// </java-name>
		[Dot42.DexImport("android/util/TimingLogger", AccessFlags = 33)]
		public partial class TimingLogger
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public TimingLogger(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Reset(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSplit
				/// </java-name>
				[Dot42.DexImport("addSplit", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddSplit(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpToLog
				/// </java-name>
				[Dot42.DexImport("dumpToLog", "()V", AccessFlags = 1)]
				public virtual void DumpToLog() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TimingLogger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/JsonReader
		/// </java-name>
		[Dot42.DexImport("android/util/JsonReader", AccessFlags = 49)]
		public sealed partial class JsonReader : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public JsonReader(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLenient
				/// </java-name>
				[Dot42.DexImport("setLenient", "(Z)V", AccessFlags = 1)]
				public void SetLenient(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLenient
				/// </java-name>
				[Dot42.DexImport("isLenient", "()Z", AccessFlags = 1)]
				public bool IsLenient() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// beginArray
				/// </java-name>
				[Dot42.DexImport("beginArray", "()V", AccessFlags = 1)]
				public void BeginArray() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endArray
				/// </java-name>
				[Dot42.DexImport("endArray", "()V", AccessFlags = 1)]
				public void EndArray() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginObject
				/// </java-name>
				[Dot42.DexImport("beginObject", "()V", AccessFlags = 1)]
				public void BeginObject() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endObject
				/// </java-name>
				[Dot42.DexImport("endObject", "()V", AccessFlags = 1)]
				public void EndObject() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Landroid/util/JsonToken;", AccessFlags = 1)]
				public global::Android.Util.JsonToken Peek() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonToken);
				}

				/// <java-name>
				/// nextName
				/// </java-name>
				[Dot42.DexImport("nextName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string NextName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// nextString
				/// </java-name>
				[Dot42.DexImport("nextString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string NextString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// nextBoolean
				/// </java-name>
				[Dot42.DexImport("nextBoolean", "()Z", AccessFlags = 1)]
				public bool NextBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextNull
				/// </java-name>
				[Dot42.DexImport("nextNull", "()V", AccessFlags = 1)]
				public void NextNull() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "()D", AccessFlags = 1)]
				public double NextDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextLong
				/// </java-name>
				[Dot42.DexImport("nextLong", "()J", AccessFlags = 1)]
				public long NextLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "()I", AccessFlags = 1)]
				public int NextInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skipValue
				/// </java-name>
				[Dot42.DexImport("skipValue", "()V", AccessFlags = 1)]
				public void SkipValue() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JsonReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/NoSuchPropertyException
		/// </java-name>
		[Dot42.DexImport("android/util/NoSuchPropertyException", AccessFlags = 33)]
		public partial class NoSuchPropertyException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchPropertyException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NoSuchPropertyException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/LruCache
		/// </java-name>
		[Dot42.DexImport("android/util/LruCache", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class LruCache<K, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LruCache(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(TK;)TV;")]
				public V Get(K k) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(TK;TV;)TV;")]
				public V Put(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(TK;)TV;")]
				public V Remove(K k) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// entryRemoved
				/// </java-name>
				[Dot42.DexImport("entryRemoved", "(ZLjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 4, Signature = "(ZTK;TV;TV;)V")]
				protected internal virtual void EntryRemoved(bool boolean, K k, V v, V v1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 4, Signature = "(TK;)TV;")]
				protected internal virtual V Create(K k) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// sizeOf
				/// </java-name>
				[Dot42.DexImport("sizeOf", "(Ljava/lang/Object;Ljava/lang/Object;)I", AccessFlags = 4, Signature = "(TK;TV;)I")]
				protected internal virtual int SizeOf(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// evictAll
				/// </java-name>
				[Dot42.DexImport("evictAll", "()V", AccessFlags = 17)]
				public void EvictAll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 49)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// maxSize
				/// </java-name>
				[Dot42.DexImport("maxSize", "()I", AccessFlags = 49)]
				public int MaxSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hitCount
				/// </java-name>
				[Dot42.DexImport("hitCount", "()I", AccessFlags = 49)]
				public int HitCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// missCount
				/// </java-name>
				[Dot42.DexImport("missCount", "()I", AccessFlags = 49)]
				public int MissCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// createCount
				/// </java-name>
				[Dot42.DexImport("createCount", "()I", AccessFlags = 49)]
				public int CreateCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// putCount
				/// </java-name>
				[Dot42.DexImport("putCount", "()I", AccessFlags = 49)]
				public int PutCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// evictionCount
				/// </java-name>
				[Dot42.DexImport("evictionCount", "()I", AccessFlags = 49)]
				public int EvictionCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// snapshot
				/// </java-name>
				[Dot42.DexImport("snapshot", "()Ljava/util/Map;", AccessFlags = 49, Signature = "()Ljava/util/Map<TK;TV;>;")]
				public global::Java.Util.IMap<K, V> Snapshot() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 49)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LruCache() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/Base64
		/// </java-name>
		[Dot42.DexImport("android/util/Base64", AccessFlags = 33)]
		public partial class Base64
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
				public const int DEFAULT = 0;
				/// <java-name>
				/// NO_PADDING
				/// </java-name>
				[Dot42.DexImport("NO_PADDING", "I", AccessFlags = 25)]
				public const int NO_PADDING = 1;
				/// <java-name>
				/// NO_WRAP
				/// </java-name>
				[Dot42.DexImport("NO_WRAP", "I", AccessFlags = 25)]
				public const int NO_WRAP = 2;
				/// <java-name>
				/// CRLF
				/// </java-name>
				[Dot42.DexImport("CRLF", "I", AccessFlags = 25)]
				public const int CRLF = 4;
				/// <java-name>
				/// URL_SAFE
				/// </java-name>
				[Dot42.DexImport("URL_SAFE", "I", AccessFlags = 25)]
				public const int URL_SAFE = 8;
				/// <java-name>
				/// NO_CLOSE
				/// </java-name>
				[Dot42.DexImport("NO_CLOSE", "I", AccessFlags = 25)]
				public const int NO_CLOSE = 16;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Base64() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;I)[B", AccessFlags = 9)]
				public static sbyte[] JavaDecode(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;I)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BI)[B", AccessFlags = 9)]
				public static sbyte[] Decode(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BI)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BIII)[B", AccessFlags = 9)]
				public static sbyte[] Decode(sbyte[] sByte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BIII)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(byte[] @byte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BI)Ljava/lang/String;", AccessFlags = 9)]
				public static string EncodeToString(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BI)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string EncodeToString(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BIII)Ljava/lang/String;", AccessFlags = 9)]
				public static string EncodeToString(sbyte[] sByte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BIII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string EncodeToString(byte[] @byte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BI)[B", AccessFlags = 9)]
				public static sbyte[] Encode(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BI)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Encode(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BIII)[B", AccessFlags = 9)]
				public static sbyte[] Encode(sbyte[] sByte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BIII)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Encode(byte[] @byte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

		}

		/// <java-name>
		/// android/util/SparseArray
		/// </java-name>
		[Dot42.DexImport("android/util/SparseArray", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Cloneable;")]
		public partial class SparseArray<E> : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SparseArray() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SparseArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/util/SparseArray;", AccessFlags = 1, Signature = "()Landroid/util/SparseArray<TE;>;")]
				public virtual global::Android.Util.SparseArray<E> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseArray<E>);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public virtual E Get(int int32, E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(I)V", AccessFlags = 1)]
				public virtual void Delete(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)V", AccessFlags = 1)]
				public virtual void Remove(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAt
				/// </java-name>
				[Dot42.DexImport("removeAt", "(I)V", AccessFlags = 1)]
				public virtual void RemoveAt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void Put(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// keyAt
				/// </java-name>
				[Dot42.DexImport("keyAt", "(I)I", AccessFlags = 1)]
				public virtual int KeyAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueAt
				/// </java-name>
				[Dot42.DexImport("valueAt", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E ValueAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// setValueAt
				/// </java-name>
				[Dot42.DexImport("setValueAt", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void SetValueAt(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// indexOfKey
				/// </java-name>
				[Dot42.DexImport("indexOfKey", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfKey(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOfValue
				/// </java-name>
				[Dot42.DexImport("indexOfValue", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TE;)I")]
				public virtual int IndexOfValue(E e) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void Append(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/util/Property
		/// </java-name>
		[Dot42.DexImport("android/util/Property", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class Property<T, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TV;>;Ljava/lang/String;)V")]
				public Property(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Landroid/util/Property;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;Ljava/lang/Class" +
    "<TV;>;Ljava/lang/String;)Landroid/util/Property<TT;TV;>;")]
				public static global::Android.Util.Property<JavaT, JavaV> Of<JavaT, JavaV>(global::System.Type type, global::System.Type type1, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.Property<JavaT, JavaV>);
				}

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
				public virtual bool IsReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;TV;)V")]
				public virtual void Set(T t, V v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TT;)TV;")]
				public abstract V Get(T t) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TV;>;")]
				public new virtual global::System.Type GetType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Property() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public global::System.Type Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TV;>;")]
						get{ return GetType(); }
				}

		}

		/// <java-name>
		/// android/util/Xml
		/// </java-name>
		[Dot42.DexImport("android/util/Xml", AccessFlags = 33)]
		public partial class Xml
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE_RELAXED
				/// </java-name>
				[Dot42.DexImport("FEATURE_RELAXED", "Ljava/lang/String;", AccessFlags = 9)]
				public static string FEATURE_RELAXED;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Xml() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Lorg/xml/sax/ContentHandler;)V", AccessFlags = 9)]
				public static void Parse(string @string, global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/Reader;Lorg/xml/sax/ContentHandler;)V", AccessFlags = 9)]
				public static void Parse(global::Java.Io.Reader reader, global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Landroid/util/Xml$Encoding;Lorg/xml/sax/ContentHandler;)V", AccessFlags = 9)]
				public static void Parse(global::Java.Io.InputStream inputStream, global::Android.Util.Xml.Encoding encoding, global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newPullParser
				/// </java-name>
				[Dot42.DexImport("newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;", AccessFlags = 9)]
				public static global::Org.Xmlpull.V1.IXmlPullParser NewPullParser() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlPullParser);
				}

				/// <java-name>
				/// newSerializer
				/// </java-name>
				[Dot42.DexImport("newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 9)]
				public static global::Org.Xmlpull.V1.IXmlSerializer NewSerializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlSerializer);
				}

				/// <java-name>
				/// findEncodingByName
				/// </java-name>
				[Dot42.DexImport("findEncodingByName", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;", AccessFlags = 9)]
				public static global::Android.Util.Xml.Encoding FindEncodingByName(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.Xml.Encoding);
				}

				/// <java-name>
				/// asAttributeSet
				/// </java-name>
				[Dot42.DexImport("asAttributeSet", "(Lorg/xmlpull/v1/XmlPullParser;)Landroid/util/AttributeSet;", AccessFlags = 9)]
				public static global::Android.Util.IAttributeSet AsAttributeSet(global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.IAttributeSet);
				}

				/// <java-name>
				/// android/util/Xml$Encoding
				/// </java-name>
				[Dot42.DexImport("android/util/Xml$Encoding", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/util/Xml$Encoding;>;")]
				public sealed class Encoding
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ISO_8859_1
						/// </java-name>
						[Dot42.DexImport("ISO_8859_1", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding ISO_8859_1;
						/// <java-name>
						/// US_ASCII
						/// </java-name>
						[Dot42.DexImport("US_ASCII", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding US_ASCII;
						/// <java-name>
						/// UTF_16
						/// </java-name>
						[Dot42.DexImport("UTF_16", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding UTF_16;
						/// <java-name>
						/// UTF_8
						/// </java-name>
						[Dot42.DexImport("UTF_8", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding UTF_8;
						private Encoding() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/util/Xml$Encoding;", AccessFlags = 9)]
						public static Encoding[] Values() /* MethodBuilder.Create */ 
						{
								return default(Encoding[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;", AccessFlags = 9)]
						public static Encoding ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Encoding);
						}

				}

		}

		/// <java-name>
		/// android/util/Log
		/// </java-name>
		[Dot42.DexImport("android/util/Log", AccessFlags = 49)]
		public sealed partial class Log
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// VERBOSE
				/// </java-name>
				[Dot42.DexImport("VERBOSE", "I", AccessFlags = 25)]
				public const int VERBOSE = 2;
				/// <java-name>
				/// DEBUG
				/// </java-name>
				[Dot42.DexImport("DEBUG", "I", AccessFlags = 25)]
				public const int DEBUG = 3;
				/// <java-name>
				/// INFO
				/// </java-name>
				[Dot42.DexImport("INFO", "I", AccessFlags = 25)]
				public const int INFO = 4;
				/// <java-name>
				/// WARN
				/// </java-name>
				[Dot42.DexImport("WARN", "I", AccessFlags = 25)]
				public const int WARN = 5;
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = 6;
				/// <java-name>
				/// ASSERT
				/// </java-name>
				[Dot42.DexImport("ASSERT", "I", AccessFlags = 25)]
				public const int ASSERT = 7;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Log() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// v
				/// </java-name>
				[Dot42.DexImport("v", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int V(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// v
				/// </java-name>
				[Dot42.DexImport("v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int V(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// d
				/// </java-name>
				[Dot42.DexImport("d", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int D(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// d
				/// </java-name>
				[Dot42.DexImport("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int D(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// i
				/// </java-name>
				[Dot42.DexImport("i", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int I(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// i
				/// </java-name>
				[Dot42.DexImport("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int I(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int W(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int W(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/lang/String;I)Z", AccessFlags = 265)]
				public static bool IsLoggable(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "(Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int W(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// e
				/// </java-name>
				[Dot42.DexImport("e", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int E(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// e
				/// </java-name>
				[Dot42.DexImport("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int E(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// wtf
				/// </java-name>
				[Dot42.DexImport("wtf", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int Wtf(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// wtf
				/// </java-name>
				[Dot42.DexImport("wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int Wtf(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// wtf
				/// </java-name>
				[Dot42.DexImport("wtf", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int Wtf(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStackTraceString
				/// </java-name>
				[Dot42.DexImport("getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetStackTraceString(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(ILjava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int Println(int int32, string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/util/EventLog
		/// </java-name>
		[Dot42.DexImport("android/util/EventLog", AccessFlags = 33)]
		public partial class EventLog
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EventLog() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(II)I", AccessFlags = 265)]
				public static int WriteEvent(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(IJ)I", AccessFlags = 265)]
				public static int WriteEvent(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(ILjava/lang/String;)I", AccessFlags = 265)]
				public static int WriteEvent(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(I[Ljava/lang/Object;)I", AccessFlags = 393)]
				public static int WriteEvent(int int32, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readEvents
				/// </java-name>
				[Dot42.DexImport("readEvents", "([ILjava/util/Collection;)V", AccessFlags = 265, Signature = "([ILjava/util/Collection<Landroid/util/EventLog$Event;>;)V")]
				public static void ReadEvents(int[] int32, global::Java.Util.ICollection<global::Android.Util.EventLog.Event> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTagName
				/// </java-name>
				[Dot42.DexImport("getTagName", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetTagName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTagCode
				/// </java-name>
				[Dot42.DexImport("getTagCode", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetTagCode(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// android/util/EventLog$Event
				/// </java-name>
				[Dot42.DexImport("android/util/EventLog$Event", AccessFlags = 25)]
				public sealed partial class Event
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Event() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getProcessId
						/// </java-name>
						[Dot42.DexImport("getProcessId", "()I", AccessFlags = 1)]
						public int GetProcessId() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getThreadId
						/// </java-name>
						[Dot42.DexImport("getThreadId", "()I", AccessFlags = 1)]
						public int GetThreadId() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getTimeNanos
						/// </java-name>
						[Dot42.DexImport("getTimeNanos", "()J", AccessFlags = 1)]
						public long GetTimeNanos() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// getTag
						/// </java-name>
						[Dot42.DexImport("getTag", "()I", AccessFlags = 1)]
						public int GetTag() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getData
						/// </java-name>
						[Dot42.DexImport("getData", "()Ljava/lang/Object;", AccessFlags = 33)]
						public object GetData() /* MethodBuilder.Create */ 
						{
								return default(object);
						}

						/// <java-name>
						/// getProcessId
						/// </java-name>
						public int ProcessId
						{
						[Dot42.DexImport("getProcessId", "()I", AccessFlags = 1)]
								get{ return GetProcessId(); }
						}

						/// <java-name>
						/// getThreadId
						/// </java-name>
						public int ThreadId
						{
						[Dot42.DexImport("getThreadId", "()I", AccessFlags = 1)]
								get{ return GetThreadId(); }
						}

						/// <java-name>
						/// getTimeNanos
						/// </java-name>
						public long TimeNanos
						{
						[Dot42.DexImport("getTimeNanos", "()J", AccessFlags = 1)]
								get{ return GetTimeNanos(); }
						}

						/// <java-name>
						/// getTag
						/// </java-name>
						public int Tag
						{
						[Dot42.DexImport("getTag", "()I", AccessFlags = 1)]
								get{ return GetTag(); }
						}

						/// <java-name>
						/// getData
						/// </java-name>
						public object Data
						{
						[Dot42.DexImport("getData", "()Ljava/lang/Object;", AccessFlags = 33)]
								get{ return GetData(); }
						}

				}

		}

		/// <java-name>
		/// android/util/SparseBooleanArray
		/// </java-name>
		[Dot42.DexImport("android/util/SparseBooleanArray", AccessFlags = 33)]
		public partial class SparseBooleanArray : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SparseBooleanArray() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SparseBooleanArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/util/SparseBooleanArray;", AccessFlags = 1)]
				public virtual global::Android.Util.SparseBooleanArray Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseBooleanArray);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Z", AccessFlags = 1)]
				public virtual bool Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(IZ)Z", AccessFlags = 1)]
				public virtual bool Get(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(I)V", AccessFlags = 1)]
				public virtual void Delete(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IZ)V", AccessFlags = 1)]
				public virtual void Put(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// keyAt
				/// </java-name>
				[Dot42.DexImport("keyAt", "(I)I", AccessFlags = 1)]
				public virtual int KeyAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueAt
				/// </java-name>
				[Dot42.DexImport("valueAt", "(I)Z", AccessFlags = 1)]
				public virtual bool ValueAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// indexOfKey
				/// </java-name>
				[Dot42.DexImport("indexOfKey", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfKey(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOfValue
				/// </java-name>
				[Dot42.DexImport("indexOfValue", "(Z)I", AccessFlags = 1)]
				public virtual int IndexOfValue(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(IZ)V", AccessFlags = 1)]
				public virtual void Append(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/util/Base64OutputStream
		/// </java-name>
		[Dot42.DexImport("android/util/Base64OutputStream", AccessFlags = 33)]
		public partial class Base64OutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;I)V", AccessFlags = 1)]
				public Base64OutputStream(global::Java.Io.OutputStream outputStream, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Base64OutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/PrintWriterPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/PrintWriterPrinter", AccessFlags = 33)]
		public partial class PrintWriterPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public PrintWriterPrinter(global::Java.Io.PrintWriter printWriter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintWriterPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/Printer
		/// </java-name>
		[Dot42.DexImport("android/util/Printer", AccessFlags = 1537)]
		public partial interface IPrinter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Println(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/util/StateSet
		/// </java-name>
		[Dot42.DexImport("android/util/StateSet", AccessFlags = 33)]
		public partial class StateSet
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// WILD_CARD
				/// </java-name>
				[Dot42.DexImport("WILD_CARD", "[I", AccessFlags = 25)]
				public static readonly int[] WILD_CARD;
				/// <java-name>
				/// NOTHING
				/// </java-name>
				[Dot42.DexImport("NOTHING", "[I", AccessFlags = 25)]
				public static readonly int[] NOTHING;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal StateSet() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isWildCard
				/// </java-name>
				[Dot42.DexImport("isWildCard", "([I)Z", AccessFlags = 9)]
				public static bool IsWildCard(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stateSetMatches
				/// </java-name>
				[Dot42.DexImport("stateSetMatches", "([I[I)Z", AccessFlags = 9)]
				public static bool StateSetMatches(int[] int32, int[] int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stateSetMatches
				/// </java-name>
				[Dot42.DexImport("stateSetMatches", "([II)Z", AccessFlags = 9)]
				public static bool StateSetMatches(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// trimStateSet
				/// </java-name>
				[Dot42.DexImport("trimStateSet", "([II)[I", AccessFlags = 9)]
				public static int[] TrimStateSet(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "([I)Ljava/lang/String;", AccessFlags = 9)]
				public static string Dump(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/util/Base64InputStream
		/// </java-name>
		[Dot42.DexImport("android/util/Base64InputStream", AccessFlags = 33)]
		public partial class Base64InputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public Base64InputStream(global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Base64InputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/AndroidException
		/// </java-name>
		[Dot42.DexImport("android/util/AndroidException", AccessFlags = 33)]
		public partial class AndroidException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AndroidException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AndroidException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AndroidException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public AndroidException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/util/AndroidRuntimeException
		/// </java-name>
		[Dot42.DexImport("android/util/AndroidRuntimeException", AccessFlags = 33)]
		public partial class AndroidRuntimeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AndroidRuntimeException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AndroidRuntimeException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AndroidRuntimeException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public AndroidRuntimeException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/util/Config
		/// </java-name>
		[Dot42.DexImport("android/util/Config", AccessFlags = 49)]
		public sealed partial class Config
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEBUG
				/// </java-name>
				[Dot42.DexImport("DEBUG", "Z", AccessFlags = 25)]
				public const bool DEBUG = false;
				/// <java-name>
				/// RELEASE
				/// </java-name>
				[Dot42.DexImport("RELEASE", "Z", AccessFlags = 25)]
				public const bool RELEASE = true;
				/// <java-name>
				/// PROFILE
				/// </java-name>
				[Dot42.DexImport("PROFILE", "Z", AccessFlags = 25)]
				public const bool PROFILE = false;
				/// <java-name>
				/// LOGV
				/// </java-name>
				[Dot42.DexImport("LOGV", "Z", AccessFlags = 25)]
				public const bool LOGV = false;
				/// <java-name>
				/// LOGD
				/// </java-name>
				[Dot42.DexImport("LOGD", "Z", AccessFlags = 25)]
				public const bool LOGD = true;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Config() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/util/TimeUtils
		/// </java-name>
		[Dot42.DexImport("android/util/TimeUtils", AccessFlags = 33)]
		public partial class TimeUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TimeUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "(IZJLjava/lang/String;)Ljava/util/TimeZone;", AccessFlags = 9)]
				public static global::Java.Util.TimeZone GetTimeZone(int int32, bool boolean, long int64, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.TimeZone);
				}

				/// <java-name>
				/// getTimeZoneDatabaseVersion
				/// </java-name>
				[Dot42.DexImport("getTimeZoneDatabaseVersion", "()Ljava/lang/String;", AccessFlags = 9)]
				public static string GetTimeZoneDatabaseVersion() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTimeZoneDatabaseVersion
				/// </java-name>
				public static string TimeZoneDatabaseVersion
				{
				[Dot42.DexImport("getTimeZoneDatabaseVersion", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return GetTimeZoneDatabaseVersion(); }
				}

		}

		/// <java-name>
		/// android/util/TypedValue
		/// </java-name>
		[Dot42.DexImport("android/util/TypedValue", AccessFlags = 33)]
		public partial class TypedValue
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("TYPE_NULL", "I", AccessFlags = 25)]
				public const int TYPE_NULL = 0;
				/// <java-name>
				/// TYPE_REFERENCE
				/// </java-name>
				[Dot42.DexImport("TYPE_REFERENCE", "I", AccessFlags = 25)]
				public const int TYPE_REFERENCE = 1;
				/// <java-name>
				/// TYPE_ATTRIBUTE
				/// </java-name>
				[Dot42.DexImport("TYPE_ATTRIBUTE", "I", AccessFlags = 25)]
				public const int TYPE_ATTRIBUTE = 2;
				/// <java-name>
				/// TYPE_STRING
				/// </java-name>
				[Dot42.DexImport("TYPE_STRING", "I", AccessFlags = 25)]
				public const int TYPE_STRING = 3;
				/// <java-name>
				/// TYPE_FLOAT
				/// </java-name>
				[Dot42.DexImport("TYPE_FLOAT", "I", AccessFlags = 25)]
				public const int TYPE_FLOAT = 4;
				/// <java-name>
				/// TYPE_DIMENSION
				/// </java-name>
				[Dot42.DexImport("TYPE_DIMENSION", "I", AccessFlags = 25)]
				public const int TYPE_DIMENSION = 5;
				/// <java-name>
				/// TYPE_FRACTION
				/// </java-name>
				[Dot42.DexImport("TYPE_FRACTION", "I", AccessFlags = 25)]
				public const int TYPE_FRACTION = 6;
				/// <java-name>
				/// TYPE_FIRST_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_FIRST_INT", "I", AccessFlags = 25)]
				public const int TYPE_FIRST_INT = 16;
				/// <java-name>
				/// TYPE_INT_DEC
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_DEC", "I", AccessFlags = 25)]
				public const int TYPE_INT_DEC = 16;
				/// <java-name>
				/// TYPE_INT_HEX
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_HEX", "I", AccessFlags = 25)]
				public const int TYPE_INT_HEX = 17;
				/// <java-name>
				/// TYPE_INT_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_BOOLEAN", "I", AccessFlags = 25)]
				public const int TYPE_INT_BOOLEAN = 18;
				/// <java-name>
				/// TYPE_FIRST_COLOR_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_FIRST_COLOR_INT", "I", AccessFlags = 25)]
				public const int TYPE_FIRST_COLOR_INT = 28;
				/// <java-name>
				/// TYPE_INT_COLOR_ARGB8
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_ARGB8", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_ARGB8 = 28;
				/// <java-name>
				/// TYPE_INT_COLOR_RGB8
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_RGB8", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_RGB8 = 29;
				/// <java-name>
				/// TYPE_INT_COLOR_ARGB4
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_ARGB4", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_ARGB4 = 30;
				/// <java-name>
				/// TYPE_INT_COLOR_RGB4
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_RGB4", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_RGB4 = 31;
				/// <java-name>
				/// TYPE_LAST_COLOR_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_LAST_COLOR_INT", "I", AccessFlags = 25)]
				public const int TYPE_LAST_COLOR_INT = 31;
				/// <java-name>
				/// TYPE_LAST_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_LAST_INT", "I", AccessFlags = 25)]
				public const int TYPE_LAST_INT = 31;
				/// <java-name>
				/// COMPLEX_UNIT_SHIFT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_SHIFT", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_SHIFT = 0;
				/// <java-name>
				/// COMPLEX_UNIT_MASK
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_MASK", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_MASK = 15;
				/// <java-name>
				/// COMPLEX_UNIT_PX
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_PX", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_PX = 0;
				/// <java-name>
				/// COMPLEX_UNIT_DIP
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_DIP", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_DIP = 1;
				/// <java-name>
				/// COMPLEX_UNIT_SP
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_SP", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_SP = 2;
				/// <java-name>
				/// COMPLEX_UNIT_PT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_PT", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_PT = 3;
				/// <java-name>
				/// COMPLEX_UNIT_IN
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_IN", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_IN = 4;
				/// <java-name>
				/// COMPLEX_UNIT_MM
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_MM", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_MM = 5;
				/// <java-name>
				/// COMPLEX_UNIT_FRACTION
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_FRACTION", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_FRACTION = 0;
				/// <java-name>
				/// COMPLEX_UNIT_FRACTION_PARENT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_FRACTION_PARENT", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_FRACTION_PARENT = 1;
				/// <java-name>
				/// COMPLEX_RADIX_SHIFT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_SHIFT", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_SHIFT = 4;
				/// <java-name>
				/// COMPLEX_RADIX_MASK
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_MASK", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_MASK = 3;
				/// <java-name>
				/// COMPLEX_RADIX_23p0
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_23p0", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_23p0 = 0;
				/// <java-name>
				/// COMPLEX_RADIX_16p7
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_16p7", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_16p7 = 1;
				/// <java-name>
				/// COMPLEX_RADIX_8p15
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_8p15", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_8p15 = 2;
				/// <java-name>
				/// COMPLEX_RADIX_0p23
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_0p23", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_0p23 = 3;
				/// <java-name>
				/// COMPLEX_MANTISSA_SHIFT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_MANTISSA_SHIFT", "I", AccessFlags = 25)]
				public const int COMPLEX_MANTISSA_SHIFT = 8;
				/// <java-name>
				/// COMPLEX_MANTISSA_MASK
				/// </java-name>
				[Dot42.DexImport("COMPLEX_MANTISSA_MASK", "I", AccessFlags = 25)]
				public const int COMPLEX_MANTISSA_MASK = 16777215;
				/// <java-name>
				/// DENSITY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("DENSITY_DEFAULT", "I", AccessFlags = 25)]
				public const int DENSITY_DEFAULT = 0;
				/// <java-name>
				/// DENSITY_NONE
				/// </java-name>
				[Dot42.DexImport("DENSITY_NONE", "I", AccessFlags = 25)]
				public const int DENSITY_NONE = 65535;
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 1)]
				public int Type;
				/// <java-name>
				/// string
				/// </java-name>
				[Dot42.DexImport("string", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence String;
				/// <java-name>
				/// data
				/// </java-name>
				[Dot42.DexImport("data", "I", AccessFlags = 1)]
				public int Data;
				/// <java-name>
				/// assetCookie
				/// </java-name>
				[Dot42.DexImport("assetCookie", "I", AccessFlags = 1)]
				public int AssetCookie;
				/// <java-name>
				/// resourceId
				/// </java-name>
				[Dot42.DexImport("resourceId", "I", AccessFlags = 1)]
				public int ResourceId;
				/// <java-name>
				/// changingConfigurations
				/// </java-name>
				[Dot42.DexImport("changingConfigurations", "I", AccessFlags = 1)]
				public int ChangingConfigurations;
				/// <java-name>
				/// density
				/// </java-name>
				[Dot42.DexImport("density", "I", AccessFlags = 1)]
				public int Density;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TypedValue() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "()F", AccessFlags = 17)]
				public float GetFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// complexToFloat
				/// </java-name>
				[Dot42.DexImport("complexToFloat", "(I)F", AccessFlags = 9)]
				public static float ComplexToFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// complexToDimension
				/// </java-name>
				[Dot42.DexImport("complexToDimension", "(ILandroid/util/DisplayMetrics;)F", AccessFlags = 9)]
				public static float ComplexToDimension(int int32, global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// complexToDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("complexToDimensionPixelOffset", "(ILandroid/util/DisplayMetrics;)I", AccessFlags = 9)]
				public static int ComplexToDimensionPixelOffset(int int32, global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// complexToDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("complexToDimensionPixelSize", "(ILandroid/util/DisplayMetrics;)I", AccessFlags = 9)]
				public static int ComplexToDimensionPixelSize(int int32, global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// complexToDimensionNoisy
				/// </java-name>
				[Dot42.DexImport("complexToDimensionNoisy", "(ILandroid/util/DisplayMetrics;)F", AccessFlags = 9)]
				public static float ComplexToDimensionNoisy(int int32, global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// applyDimension
				/// </java-name>
				[Dot42.DexImport("applyDimension", "(IFLandroid/util/DisplayMetrics;)F", AccessFlags = 9)]
				public static float ApplyDimension(int int32, float single, global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(Landroid/util/DisplayMetrics;)F", AccessFlags = 1)]
				public virtual float GetDimension(global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// complexToFraction
				/// </java-name>
				[Dot42.DexImport("complexToFraction", "(IFF)F", AccessFlags = 9)]
				public static float ComplexToFraction(int int32, float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getFraction
				/// </java-name>
				[Dot42.DexImport("getFraction", "(FF)F", AccessFlags = 1)]
				public virtual float GetFraction(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// coerceToString
				/// </java-name>
				[Dot42.DexImport("coerceToString", "()Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence CoerceToString() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// coerceToString
				/// </java-name>
				[Dot42.DexImport("coerceToString", "(II)Ljava/lang/String;", AccessFlags = 25)]
				public static string CoerceToString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setTo
				/// </java-name>
				[Dot42.DexImport("setTo", "(Landroid/util/TypedValue;)V", AccessFlags = 1)]
				public virtual void SetTo(global::Android.Util.TypedValue typedValue) /* MethodBuilder.Create */ 
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
				/// getFloat
				/// </java-name>
				public float Float
				{
				[Dot42.DexImport("getFloat", "()F", AccessFlags = 17)]
						get{ return GetFloat(); }
				}

		}

		/// <java-name>
		/// android/util/DebugUtils
		/// </java-name>
		[Dot42.DexImport("android/util/DebugUtils", AccessFlags = 33)]
		public partial class DebugUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DebugUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isObjectSelected
				/// </java-name>
				[Dot42.DexImport("isObjectSelected", "(Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool IsObjectSelected(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// android/util/AttributeSet
		/// </java-name>
		[Dot42.DexImport("android/util/AttributeSet", AccessFlags = 1537)]
		public partial interface IAttributeSet
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAttributeCount
				/// </java-name>
				[Dot42.DexImport("getAttributeCount", "()I", AccessFlags = 1025)]
				int GetAttributeCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeName
				/// </java-name>
				[Dot42.DexImport("getAttributeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPositionDescription
				/// </java-name>
				[Dot42.DexImport("getPositionDescription", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPositionDescription() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeNameResource
				/// </java-name>
				[Dot42.DexImport("getAttributeNameResource", "(I)I", AccessFlags = 1025)]
				int GetAttributeNameResource(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeListValue
				/// </java-name>
				[Dot42.DexImport("getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeListValue(string @string, string string1, string[] string2, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeBooleanValue
				/// </java-name>
				[Dot42.DexImport("getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				bool GetAttributeBooleanValue(string @string, string string1, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeResourceValue
				/// </java-name>
				[Dot42.DexImport("getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeResourceValue(string @string, string string1, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeIntValue(string @string, string string1, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeUnsignedIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeUnsignedIntValue(string @string, string string1, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeFloatValue
				/// </java-name>
				[Dot42.DexImport("getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F", AccessFlags = 1025)]
				float GetAttributeFloatValue(string @string, string string1, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeListValue
				/// </java-name>
				[Dot42.DexImport("getAttributeListValue", "(I[Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeListValue(int int32, string[] @string, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeBooleanValue
				/// </java-name>
				[Dot42.DexImport("getAttributeBooleanValue", "(IZ)Z", AccessFlags = 1025)]
				bool GetAttributeBooleanValue(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeResourceValue
				/// </java-name>
				[Dot42.DexImport("getAttributeResourceValue", "(II)I", AccessFlags = 1025)]
				int GetAttributeResourceValue(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeIntValue", "(II)I", AccessFlags = 1025)]
				int GetAttributeIntValue(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeUnsignedIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeUnsignedIntValue", "(II)I", AccessFlags = 1025)]
				int GetAttributeUnsignedIntValue(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeFloatValue
				/// </java-name>
				[Dot42.DexImport("getAttributeFloatValue", "(IF)F", AccessFlags = 1025)]
				float GetAttributeFloatValue(int int32, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIdAttribute
				/// </java-name>
				[Dot42.DexImport("getIdAttribute", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetIdAttribute() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClassAttribute
				/// </java-name>
				[Dot42.DexImport("getClassAttribute", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetClassAttribute() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIdAttributeResourceValue
				/// </java-name>
				[Dot42.DexImport("getIdAttributeResourceValue", "(I)I", AccessFlags = 1025)]
				int GetIdAttributeResourceValue(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStyleAttribute
				/// </java-name>
				[Dot42.DexImport("getStyleAttribute", "()I", AccessFlags = 1025)]
				int GetStyleAttribute() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/util/LogPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/LogPrinter", AccessFlags = 33)]
		public partial class LogPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public LogPrinter(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LogPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/JsonToken
		/// </java-name>
		[Dot42.DexImport("android/util/JsonToken", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Landroid/util/JsonToken;>;")]
		public sealed class JsonToken
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BEGIN_ARRAY
				/// </java-name>
				[Dot42.DexImport("BEGIN_ARRAY", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken BEGIN_ARRAY;
				/// <java-name>
				/// BEGIN_OBJECT
				/// </java-name>
				[Dot42.DexImport("BEGIN_OBJECT", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken BEGIN_OBJECT;
				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken BOOLEAN;
				/// <java-name>
				/// END_ARRAY
				/// </java-name>
				[Dot42.DexImport("END_ARRAY", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken END_ARRAY;
				/// <java-name>
				/// END_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("END_DOCUMENT", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken END_DOCUMENT;
				/// <java-name>
				/// END_OBJECT
				/// </java-name>
				[Dot42.DexImport("END_OBJECT", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken END_OBJECT;
				/// <java-name>
				/// NAME
				/// </java-name>
				[Dot42.DexImport("NAME", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken NAME;
				/// <java-name>
				/// NULL
				/// </java-name>
				[Dot42.DexImport("NULL", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken NULL;
				/// <java-name>
				/// NUMBER
				/// </java-name>
				[Dot42.DexImport("NUMBER", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken NUMBER;
				/// <java-name>
				/// STRING
				/// </java-name>
				[Dot42.DexImport("STRING", "Landroid/util/JsonToken;", AccessFlags = 16409)]
				public static readonly global::Android.Util.JsonToken STRING;
				private JsonToken() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Landroid/util/JsonToken;", AccessFlags = 9)]
				public static global::Android.Util.JsonToken[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonToken[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/util/JsonToken;", AccessFlags = 9)]
				public static global::Android.Util.JsonToken ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.JsonToken);
				}

		}

}

