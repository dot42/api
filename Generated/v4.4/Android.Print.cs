#pragma warning disable 1717
namespace Android.Print
{
		/// <summary>
		///  <para>Represents a range of pages. The start and end page indices of the range are zero based and inclusive. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PageRange
		/// </java-name>
		[Dot42.DexImport("android/print/PageRange", AccessFlags = 49)]
		public sealed partial class PageRange : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constant for specifying all pages. </para>        
				/// </summary>
				/// <java-name>
				/// ALL_PAGES
				/// </java-name>
				[Dot42.DexImport("ALL_PAGES", "Landroid/print/PageRange;", AccessFlags = 25)]
				public static readonly global::Android.Print.PageRange ALL_PAGES;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PageRange> CREATOR;
				/// <summary>
				///  <para>Creates a new instance.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PageRange(int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				internal PageRange() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the start page index (zero based and inclusive).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The start page index. </para>
				/// </returns>
				/// <java-name>
				/// getStart
				/// </java-name>
				public int Start
				{
						[Dot42.DexImport("getStart", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the end page index (zero based and inclusive).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The end page index. </para>
				/// </returns>
				/// <java-name>
				/// getEnd
				/// </java-name>
				public int End
				{
						[Dot42.DexImport("getEnd", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>This class represents the attributes of a print job. These attributes describe how the printed content should be laid out. For example, the print attributes may state that the content should be laid out on a letter size with 300 DPI (dots per inch) resolution, have a margin of 10 mills (thousand of an inch) on all sides, and be black and white. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrintAttributes
		/// </java-name>
		[Dot42.DexImport("android/print/PrintAttributes", AccessFlags = 49)]
		public sealed partial class PrintAttributes : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Color mode: Monochrome color scheme, for example one color is used. </para>        
				/// </summary>
				/// <java-name>
				/// COLOR_MODE_MONOCHROME
				/// </java-name>
				[Dot42.DexImport("COLOR_MODE_MONOCHROME", "I", AccessFlags = 25)]
				public const int COLOR_MODE_MONOCHROME = 1;
				/// <summary>
				///  <para>Color mode: Color color scheme, for example many colors are used. </para>        
				/// </summary>
				/// <java-name>
				/// COLOR_MODE_COLOR
				/// </java-name>
				[Dot42.DexImport("COLOR_MODE_COLOR", "I", AccessFlags = 25)]
				public const int COLOR_MODE_COLOR = 2;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PrintAttributes> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintAttributes() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the media size.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The media size or  <code>null</code> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getMediaSize
				/// </java-name>
				[Dot42.DexImport("getMediaSize", "()Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes.MediaSize GetMediaSize() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes.MediaSize);
				}

				/// <summary>
				///  <para>Gets the resolution.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The resolution or  <code>null</code> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getResolution
				/// </java-name>
				[Dot42.DexImport("getResolution", "()Landroid/print/PrintAttributes$Resolution;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes.Resolution GetResolution() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes.Resolution);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets the minimal margins. If the content does not fit these margins it will be clipped.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The margins or  <code>null</code> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getMinMargins
				/// </java-name>
				public global::Android.Print.PrintAttributes.Margins MinMargins
				{
						[Dot42.DexImport("getMinMargins", "()Landroid/print/PrintAttributes$Margins;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintAttributes.Margins); }
				}

				/// <summary>
				///  <para>Gets the color mode.</para> <para> <para>COLOR_MODE_COLOR </para> <para>COLOR_MODE_MONOCHROME </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The color mode or zero if not set.</para>
				/// </returns>
				/// <java-name>
				/// getColorMode
				/// </java-name>
				public int ColorMode
				{
						[Dot42.DexImport("getColorMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Builder for creating PrintAttributes. </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintAttributes$Builder
				/// </java-name>
				[Dot42.DexImport("android/print/PrintAttributes$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Builder() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the media size.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder. </para>
						/// </returns>
						/// <java-name>
						/// setMediaSize
						/// </java-name>
						[Dot42.DexImport("setMediaSize", "(Landroid/print/PrintAttributes$MediaSize;)Landroid/print/PrintAttributes$Builder" +
    ";", AccessFlags = 1)]
						public Builder SetMediaSize(global::Android.Print.PrintAttributes.MediaSize mediaSize) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the resolution.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder. </para>
						/// </returns>
						/// <java-name>
						/// setResolution
						/// </java-name>
						[Dot42.DexImport("setResolution", "(Landroid/print/PrintAttributes$Resolution;)Landroid/print/PrintAttributes$Builde" +
    "r;", AccessFlags = 1)]
						public Builder SetResolution(global::Android.Print.PrintAttributes.Resolution resolution) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the minimal margins. If the content does not fit these margins it will be clipped.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder. </para>
						/// </returns>
						/// <java-name>
						/// setMinMargins
						/// </java-name>
						[Dot42.DexImport("setMinMargins", "(Landroid/print/PrintAttributes$Margins;)Landroid/print/PrintAttributes$Builder;", AccessFlags = 1)]
						public Builder SetMinMargins(global::Android.Print.PrintAttributes.Margins margins) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the color mode.</para> <para> <para>PrintAttributes::COLOR_MODE_MONOCHROME </para> <para>PrintAttributes::COLOR_MODE_COLOR </para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder.</para>
						/// </returns>
						/// <java-name>
						/// setColorMode
						/// </java-name>
						[Dot42.DexImport("setColorMode", "(I)Landroid/print/PrintAttributes$Builder;", AccessFlags = 1)]
						public Builder SetColorMode(int colorMode) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Creates a new PrintAttributes instance.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The new instance. </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
						public global::Android.Print.PrintAttributes Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Print.PrintAttributes);
						}

				}

				/// <summary>
				///  <para>This class specifies content margins. Margins define the white space around the content where the left margin defines the amount of white space on the left of the content and so on. </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintAttributes$Margins
				/// </java-name>
				[Dot42.DexImport("android/print/PrintAttributes$Margins", AccessFlags = 25)]
				public sealed partial class Margins
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NO_MARGINS
						/// </java-name>
						[Dot42.DexImport("NO_MARGINS", "Landroid/print/PrintAttributes$Margins;", AccessFlags = 25)]
						public static readonly Margins NO_MARGINS;
						[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
						public Margins(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
						{
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
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
						public override bool Equals(object obj) /* MethodBuilder.Create */ 
						{
								return default(bool);
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
						internal Margins() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Gets the left margin in mils (thousands of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The left margin. </para>
						/// </returns>
						/// <java-name>
						/// getLeftMils
						/// </java-name>
						public int LeftMils
						{
								[Dot42.DexImport("getLeftMils", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Gets the top margin in mils (thousands of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The top margin. </para>
						/// </returns>
						/// <java-name>
						/// getTopMils
						/// </java-name>
						public int TopMils
						{
								[Dot42.DexImport("getTopMils", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Gets the right margin in mils (thousands of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The right margin. </para>
						/// </returns>
						/// <java-name>
						/// getRightMils
						/// </java-name>
						public int RightMils
						{
								[Dot42.DexImport("getRightMils", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Gets the bottom margin in mils (thousands of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The bottom margin. </para>
						/// </returns>
						/// <java-name>
						/// getBottomMils
						/// </java-name>
						public int BottomMils
						{
								[Dot42.DexImport("getBottomMils", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

				}

				/// <summary>
				///  <para>This class specifies a supported resolution in DPI (dots per inch). Resolution defines how many points with different color can be placed on one inch in horizontal or vertical direction of the target media. For example, a printer with 600 DPI can produce higher quality images the one with 300 DPI resolution. </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintAttributes$Resolution
				/// </java-name>
				[Dot42.DexImport("android/print/PrintAttributes$Resolution", AccessFlags = 25)]
				public sealed partial class Resolution
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;II)V", AccessFlags = 1)]
						public Resolution(string @string, string string1, int int32, int int321) /* MethodBuilder.Create */ 
						{
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
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
						public override bool Equals(object obj) /* MethodBuilder.Create */ 
						{
								return default(bool);
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
						internal Resolution() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Gets the unique resolution id. It is unique amongst other resolutions supported by the printer. </para> <para>This id is defined by the client that generated the resolution instance and should not be interpreted by other parties. </para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The unique resolution id. </para>
						/// </returns>
						/// <java-name>
						/// getId
						/// </java-name>
						public string Id
						{
								[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para>Gets the resolution human readable label.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The human readable label. </para>
						/// </returns>
						/// <java-name>
						/// getLabel
						/// </java-name>
						public string Label
						{
								[Dot42.DexImport("getLabel", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para>Gets the horizontal resolution in DPI (dots per inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The horizontal resolution. </para>
						/// </returns>
						/// <java-name>
						/// getHorizontalDpi
						/// </java-name>
						public int HorizontalDpi
						{
								[Dot42.DexImport("getHorizontalDpi", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Gets the vertical resolution in DPI (dots per inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The vertical resolution. </para>
						/// </returns>
						/// <java-name>
						/// getVerticalDpi
						/// </java-name>
						public int VerticalDpi
						{
								[Dot42.DexImport("getVerticalDpi", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

				}

				/// <summary>
				///  <para>This class specifies a supported media size. Media size is the dimension of the media on which the content is printed. For example, the NA_LETTER media size designates a page with size 8.5" x 11". </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintAttributes$MediaSize
				/// </java-name>
				[Dot42.DexImport("android/print/PrintAttributes$MediaSize", AccessFlags = 25)]
				public sealed partial class MediaSize
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Unknown media size in portrait mode. </para> <para> <b>Note: </b>This is for specifying orientation without media size. You should not use the dimensions reported by this instance. </para>        
						/// </summary>
						/// <java-name>
						/// UNKNOWN_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_PORTRAIT", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize UNKNOWN_PORTRAIT;
						/// <summary>
						///  <para>Unknown media size in landscape mode. </para> <para> <b>Note: </b>This is for specifying orientation without media size. You should not use the dimensions reported by this instance. </para>        
						/// </summary>
						/// <java-name>
						/// UNKNOWN_LANDSCAPE
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_LANDSCAPE", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize UNKNOWN_LANDSCAPE;
						/// <summary>
						///  <para>ISO A0 media size: 841mm x 1189mm (33.11" x 46.81") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A0
						/// </java-name>
						[Dot42.DexImport("ISO_A0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A0;
						/// <summary>
						///  <para>ISO A1 media size: 594mm x 841mm (23.39" x 33.11") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A1
						/// </java-name>
						[Dot42.DexImport("ISO_A1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A1;
						/// <summary>
						///  <para>ISO A2 media size: 420mm x 594mm (16.54" x 23.39") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A2
						/// </java-name>
						[Dot42.DexImport("ISO_A2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A2;
						/// <summary>
						///  <para>ISO A3 media size: 297mm x 420mm (11.69" x 16.54") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A3
						/// </java-name>
						[Dot42.DexImport("ISO_A3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A3;
						/// <summary>
						///  <para>ISO A4 media size: 210mm x 297mm (8.27" x 11.69") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A4
						/// </java-name>
						[Dot42.DexImport("ISO_A4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A4;
						/// <summary>
						///  <para>ISO A5 media size: 148mm x 210mm (5.83" x 8.27") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A5
						/// </java-name>
						[Dot42.DexImport("ISO_A5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A5;
						/// <summary>
						///  <para>ISO A6 media size: 105mm x 148mm (4.13" x 5.83") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A6
						/// </java-name>
						[Dot42.DexImport("ISO_A6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A6;
						/// <summary>
						///  <para>ISO A7 media size: 74mm x 105mm (2.91" x 4.13") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A7
						/// </java-name>
						[Dot42.DexImport("ISO_A7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A7;
						/// <summary>
						///  <para>ISO A8 media size: 52mm x 74mm (2.05" x 2.91") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A8
						/// </java-name>
						[Dot42.DexImport("ISO_A8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A8;
						/// <summary>
						///  <para>ISO A9 media size: 37mm x 52mm (1.46" x 2.05") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A9
						/// </java-name>
						[Dot42.DexImport("ISO_A9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A9;
						/// <summary>
						///  <para>ISO A10 media size: 26mm x 37mm (1.02" x 1.46") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_A10
						/// </java-name>
						[Dot42.DexImport("ISO_A10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A10;
						/// <summary>
						///  <para>ISO B0 media size: 1000mm x 1414mm (39.37" x 55.67") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B0
						/// </java-name>
						[Dot42.DexImport("ISO_B0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B0;
						/// <summary>
						///  <para>ISO B1 media size: 707mm x 1000mm (27.83" x 39.37") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B1
						/// </java-name>
						[Dot42.DexImport("ISO_B1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B1;
						/// <summary>
						///  <para>ISO B2 media size: 500mm x 707mm (19.69" x 27.83") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B2
						/// </java-name>
						[Dot42.DexImport("ISO_B2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B2;
						/// <summary>
						///  <para>ISO B3 media size: 353mm x 500mm (13.90" x 19.69") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B3
						/// </java-name>
						[Dot42.DexImport("ISO_B3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B3;
						/// <summary>
						///  <para>ISO B4 media size: 250mm x 353mm (9.84" x 13.90") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B4
						/// </java-name>
						[Dot42.DexImport("ISO_B4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B4;
						/// <summary>
						///  <para>ISO B5 media size: 176mm x 250mm (6.93" x 9.84") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B5
						/// </java-name>
						[Dot42.DexImport("ISO_B5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B5;
						/// <summary>
						///  <para>ISO B6 media size: 125mm x 176mm (4.92" x 6.93") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B6
						/// </java-name>
						[Dot42.DexImport("ISO_B6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B6;
						/// <summary>
						///  <para>ISO B7 media size: 88mm x 125mm (3.46" x 4.92") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B7
						/// </java-name>
						[Dot42.DexImport("ISO_B7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B7;
						/// <summary>
						///  <para>ISO B8 media size: 62mm x 88mm (2.44" x 3.46") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B8
						/// </java-name>
						[Dot42.DexImport("ISO_B8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B8;
						/// <summary>
						///  <para>ISO B9 media size: 44mm x 62mm (1.73" x 2.44") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B9
						/// </java-name>
						[Dot42.DexImport("ISO_B9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B9;
						/// <summary>
						///  <para>ISO B10 media size: 31mm x 44mm (1.22" x 1.73") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_B10
						/// </java-name>
						[Dot42.DexImport("ISO_B10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B10;
						/// <summary>
						///  <para>ISO C0 media size: 917mm x 1297mm (36.10" x 51.06") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C0
						/// </java-name>
						[Dot42.DexImport("ISO_C0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C0;
						/// <summary>
						///  <para>ISO C1 media size: 648mm x 917mm (25.51" x 36.10") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C1
						/// </java-name>
						[Dot42.DexImport("ISO_C1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C1;
						/// <summary>
						///  <para>ISO C2 media size: 458mm x 648mm (18.03" x 25.51") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C2
						/// </java-name>
						[Dot42.DexImport("ISO_C2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C2;
						/// <summary>
						///  <para>ISO C3 media size: 324mm x 458mm (12.76" x 18.03") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C3
						/// </java-name>
						[Dot42.DexImport("ISO_C3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C3;
						/// <summary>
						///  <para>ISO C4 media size: 229mm x 324mm (9.02" x 12.76") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C4
						/// </java-name>
						[Dot42.DexImport("ISO_C4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C4;
						/// <summary>
						///  <para>ISO C5 media size: 162mm x 229mm (6.38" x 9.02") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C5
						/// </java-name>
						[Dot42.DexImport("ISO_C5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C5;
						/// <summary>
						///  <para>ISO C6 media size: 114mm x 162mm (4.49" x 6.38") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C6
						/// </java-name>
						[Dot42.DexImport("ISO_C6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C6;
						/// <summary>
						///  <para>ISO C7 media size: 81mm x 114mm (3.19" x 4.49") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C7
						/// </java-name>
						[Dot42.DexImport("ISO_C7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C7;
						/// <summary>
						///  <para>ISO C8 media size: 57mm x 81mm (2.24" x 3.19") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C8
						/// </java-name>
						[Dot42.DexImport("ISO_C8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C8;
						/// <summary>
						///  <para>ISO C9 media size: 40mm x 57mm (1.57" x 2.24") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C9
						/// </java-name>
						[Dot42.DexImport("ISO_C9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C9;
						/// <summary>
						///  <para>ISO C10 media size: 28mm x 40mm (1.10" x 1.57") </para>        
						/// </summary>
						/// <java-name>
						/// ISO_C10
						/// </java-name>
						[Dot42.DexImport("ISO_C10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C10;
						/// <summary>
						///  <para>North America Letter media size: 8.5" x 11" (279mm x 216mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_LETTER
						/// </java-name>
						[Dot42.DexImport("NA_LETTER", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_LETTER;
						/// <summary>
						///  <para>North America Government-Letter media size: 8.0" x 10.5" (203mm x 267mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_GOVT_LETTER
						/// </java-name>
						[Dot42.DexImport("NA_GOVT_LETTER", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_GOVT_LETTER;
						/// <summary>
						///  <para>North America Legal media size: 8.5" x 14" (216mm x 356mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_LEGAL
						/// </java-name>
						[Dot42.DexImport("NA_LEGAL", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_LEGAL;
						/// <summary>
						///  <para>North America Junior Legal media size: 8.0" x 5.0" (203mm × 127mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_JUNIOR_LEGAL
						/// </java-name>
						[Dot42.DexImport("NA_JUNIOR_LEGAL", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_JUNIOR_LEGAL;
						/// <summary>
						///  <para>North America Ledger media size: 17" x 11" (432mm × 279mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_LEDGER
						/// </java-name>
						[Dot42.DexImport("NA_LEDGER", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_LEDGER;
						/// <summary>
						///  <para>North America Tabloid media size: 11" x 17" (279mm × 432mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_TABLOID
						/// </java-name>
						[Dot42.DexImport("NA_TABLOID", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_TABLOID;
						/// <summary>
						///  <para>North America Index Card 3x5 media size: 3" x 5" (76mm x 127mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_INDEX_3X5
						/// </java-name>
						[Dot42.DexImport("NA_INDEX_3X5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_INDEX_3X5;
						/// <summary>
						///  <para>North America Index Card 4x6 media size: 4" x 6" (102mm x 152mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_INDEX_4X6
						/// </java-name>
						[Dot42.DexImport("NA_INDEX_4X6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_INDEX_4X6;
						/// <summary>
						///  <para>North America Index Card 5x8 media size: 5" x 8" (127mm x 203mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_INDEX_5X8
						/// </java-name>
						[Dot42.DexImport("NA_INDEX_5X8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_INDEX_5X8;
						/// <summary>
						///  <para>North America Monarch media size: 7.25" x 10.5" (184mm x 267mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_MONARCH
						/// </java-name>
						[Dot42.DexImport("NA_MONARCH", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_MONARCH;
						/// <summary>
						///  <para>North America Quarto media size: 8" x 10" (203mm x 254mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_QUARTO
						/// </java-name>
						[Dot42.DexImport("NA_QUARTO", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_QUARTO;
						/// <summary>
						///  <para>North America Foolscap media size: 8" x 13" (203mm x 330mm) </para>        
						/// </summary>
						/// <java-name>
						/// NA_FOOLSCAP
						/// </java-name>
						[Dot42.DexImport("NA_FOOLSCAP", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_FOOLSCAP;
						/// <summary>
						///  <para>Chinese ROC 8K media size: 270mm x 390mm (10.629" x 15.3543") </para>        
						/// </summary>
						/// <java-name>
						/// ROC_8K
						/// </java-name>
						[Dot42.DexImport("ROC_8K", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ROC_8K;
						/// <summary>
						///  <para>Chinese ROC 16K media size: 195mm x 270mm (7.677" x 10.629") </para>        
						/// </summary>
						/// <java-name>
						/// ROC_16K
						/// </java-name>
						[Dot42.DexImport("ROC_16K", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ROC_16K;
						/// <summary>
						///  <para>Chinese PRC 1 media size: 102mm x 165mm (4.015" x 6.496") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_1
						/// </java-name>
						[Dot42.DexImport("PRC_1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_1;
						/// <summary>
						///  <para>Chinese PRC 2 media size: 102mm x 176mm (4.015" x 6.929") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_2
						/// </java-name>
						[Dot42.DexImport("PRC_2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_2;
						/// <summary>
						///  <para>Chinese PRC 3 media size: 125mm x 176mm (4.921" x 6.929") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_3
						/// </java-name>
						[Dot42.DexImport("PRC_3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_3;
						/// <summary>
						///  <para>Chinese PRC 4 media size: 110mm x 208mm (4.330" x 8.189") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_4
						/// </java-name>
						[Dot42.DexImport("PRC_4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_4;
						/// <summary>
						///  <para>Chinese PRC 5 media size: 110mm x 220mm (4.330" x 8.661") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_5
						/// </java-name>
						[Dot42.DexImport("PRC_5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_5;
						/// <summary>
						///  <para>Chinese PRC 6 media size: 120mm x 320mm (4.724" x 12.599") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_6
						/// </java-name>
						[Dot42.DexImport("PRC_6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_6;
						/// <summary>
						///  <para>Chinese PRC 7 media size: 160mm x 230mm (6.299" x 9.055") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_7
						/// </java-name>
						[Dot42.DexImport("PRC_7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_7;
						/// <summary>
						///  <para>Chinese PRC 8 media size: 120mm x 309mm (4.724" x 12.165") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_8
						/// </java-name>
						[Dot42.DexImport("PRC_8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_8;
						/// <summary>
						///  <para>Chinese PRC 9 media size: 229mm x 324mm (9.016" x 12.756") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_9
						/// </java-name>
						[Dot42.DexImport("PRC_9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_9;
						/// <summary>
						///  <para>Chinese PRC 10 media size: 324mm x 458mm (12.756" x 18.032") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_10
						/// </java-name>
						[Dot42.DexImport("PRC_10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_10;
						/// <summary>
						///  <para>Chinese PRC 16k media size: 146mm x 215mm (5.749" x 8.465") </para>        
						/// </summary>
						/// <java-name>
						/// PRC_16K
						/// </java-name>
						[Dot42.DexImport("PRC_16K", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_16K;
						/// <summary>
						///  <para>Chinese Pa Kai media size: 267mm x 389mm (10.512" x 15.315") </para>        
						/// </summary>
						/// <java-name>
						/// OM_PA_KAI
						/// </java-name>
						[Dot42.DexImport("OM_PA_KAI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize OM_PA_KAI;
						/// <summary>
						///  <para>Chinese Dai Pa Kai media size: 275mm x 395mm (10.827" x 15.551") </para>        
						/// </summary>
						/// <java-name>
						/// OM_DAI_PA_KAI
						/// </java-name>
						[Dot42.DexImport("OM_DAI_PA_KAI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize OM_DAI_PA_KAI;
						/// <summary>
						///  <para>Chinese Jurro Ku Kai media size: 198mm x 275mm (7.796" x 10.827") </para>        
						/// </summary>
						/// <java-name>
						/// OM_JUURO_KU_KAI
						/// </java-name>
						[Dot42.DexImport("OM_JUURO_KU_KAI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize OM_JUURO_KU_KAI;
						/// <summary>
						///  <para>Japanese JIS B10 media size: 32mm x 45mm (1.259" x 1.772") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B10
						/// </java-name>
						[Dot42.DexImport("JIS_B10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B10;
						/// <summary>
						///  <para>Japanese JIS B9 media size: 45mm x 64mm (1.772" x 2.52") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B9
						/// </java-name>
						[Dot42.DexImport("JIS_B9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B9;
						/// <summary>
						///  <para>Japanese JIS B8 media size: 64mm x 91mm (2.52" x 3.583") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B8
						/// </java-name>
						[Dot42.DexImport("JIS_B8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B8;
						/// <summary>
						///  <para>Japanese JIS B7 media size: 91mm x 128mm (3.583" x 5.049") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B7
						/// </java-name>
						[Dot42.DexImport("JIS_B7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B7;
						/// <summary>
						///  <para>Japanese JIS B6 media size: 128mm x 182mm (5.049" x 7.165") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B6
						/// </java-name>
						[Dot42.DexImport("JIS_B6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B6;
						/// <summary>
						///  <para>Japanese JIS B5 media size: 182mm x 257mm (7.165" x 10.118") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B5
						/// </java-name>
						[Dot42.DexImport("JIS_B5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B5;
						/// <summary>
						///  <para>Japanese JIS B4 media size: 257mm x 364mm (10.118" x 14.331") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B4
						/// </java-name>
						[Dot42.DexImport("JIS_B4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B4;
						/// <summary>
						///  <para>Japanese JIS B3 media size: 364mm x 515mm (14.331" x 20.276") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B3
						/// </java-name>
						[Dot42.DexImport("JIS_B3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B3;
						/// <summary>
						///  <para>Japanese JIS B2 media size: 515mm x 728mm (20.276" x 28.661") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B2
						/// </java-name>
						[Dot42.DexImport("JIS_B2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B2;
						/// <summary>
						///  <para>Japanese JIS B1 media size: 728mm x 1030mm (28.661" x 40.551") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B1
						/// </java-name>
						[Dot42.DexImport("JIS_B1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B1;
						/// <summary>
						///  <para>Japanese JIS B0 media size: 1030mm x 1456mm (40.551" x 57.323") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_B0
						/// </java-name>
						[Dot42.DexImport("JIS_B0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B0;
						/// <summary>
						///  <para>Japanese JIS Exec media size: 216mm x 330mm (8.504" x 12.992") </para>        
						/// </summary>
						/// <java-name>
						/// JIS_EXEC
						/// </java-name>
						[Dot42.DexImport("JIS_EXEC", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_EXEC;
						/// <summary>
						///  <para>Japanese Chou4 media size: 90mm x 205mm (3.543" x 8.071") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_CHOU4
						/// </java-name>
						[Dot42.DexImport("JPN_CHOU4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_CHOU4;
						/// <summary>
						///  <para>Japanese Chou3 media size: 120mm x 235mm (4.724" x 9.252") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_CHOU3
						/// </java-name>
						[Dot42.DexImport("JPN_CHOU3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_CHOU3;
						/// <summary>
						///  <para>Japanese Chou2 media size: 111.1mm x 146mm (4.374" x 5.748") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_CHOU2
						/// </java-name>
						[Dot42.DexImport("JPN_CHOU2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_CHOU2;
						/// <summary>
						///  <para>Japanese Hagaki media size: 100mm x 148mm (3.937" x 5.827") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_HAGAKI
						/// </java-name>
						[Dot42.DexImport("JPN_HAGAKI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_HAGAKI;
						/// <summary>
						///  <para>Japanese Oufuku media size: 148mm x 200mm (5.827" x 7.874") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_OUFUKU
						/// </java-name>
						[Dot42.DexImport("JPN_OUFUKU", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_OUFUKU;
						/// <summary>
						///  <para>Japanese Kahu media size: 240mm x 322.1mm (9.449" x 12.681") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_KAHU
						/// </java-name>
						[Dot42.DexImport("JPN_KAHU", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_KAHU;
						/// <summary>
						///  <para>Japanese Kaku2 media size: 240mm x 332mm (9.449" x 13.071") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_KAKU2
						/// </java-name>
						[Dot42.DexImport("JPN_KAKU2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_KAKU2;
						/// <summary>
						///  <para>Japanese You4 media size: 105mm x 235mm (4.134" x 9.252") </para>        
						/// </summary>
						/// <java-name>
						/// JPN_YOU4
						/// </java-name>
						[Dot42.DexImport("JPN_YOU4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_YOU4;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;II)V", AccessFlags = 1)]
						public MediaSize(string @string, string string1, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Gets the human readable media size label.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The human readable label. </para>
						/// </returns>
						/// <java-name>
						/// getLabel
						/// </java-name>
						[Dot42.DexImport("getLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/String;", AccessFlags = 1)]
						public string GetLabel(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Returns a new media size instance in a portrait orientation, which is the height is the greater dimension.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>New instance in landscape orientation if this one is in landscape, otherwise this instance. </para>
						/// </returns>
						/// <java-name>
						/// asPortrait
						/// </java-name>
						[Dot42.DexImport("asPortrait", "()Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 1)]
						public MediaSize AsPortrait() /* MethodBuilder.Create */ 
						{
								return default(MediaSize);
						}

						/// <summary>
						///  <para>Returns a new media size instance in a landscape orientation, which is the height is the lesser dimension.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>New instance in landscape orientation if this one is in portrait, otherwise this instance. </para>
						/// </returns>
						/// <java-name>
						/// asLandscape
						/// </java-name>
						[Dot42.DexImport("asLandscape", "()Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 1)]
						public MediaSize AsLandscape() /* MethodBuilder.Create */ 
						{
								return default(MediaSize);
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
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
						public override bool Equals(object obj) /* MethodBuilder.Create */ 
						{
								return default(bool);
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
						internal MediaSize() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Gets the unique media size id. It is unique amongst other media sizes supported by the printer. </para> <para>This id is defined by the client that generated the media size instance and should not be interpreted by other parties. </para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The unique media size id. </para>
						/// </returns>
						/// <java-name>
						/// getId
						/// </java-name>
						public string Id
						{
								[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para>Gets the media width in mils (thousands of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The media width. </para>
						/// </returns>
						/// <java-name>
						/// getWidthMils
						/// </java-name>
						public int WidthMils
						{
								[Dot42.DexImport("getWidthMils", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Gets the media height in mils (thousands of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The media height. </para>
						/// </returns>
						/// <java-name>
						/// getHeightMils
						/// </java-name>
						public int HeightMils
						{
								[Dot42.DexImport("getHeightMils", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Gets whether this media size is in portrait which is the height is greater or equal to the width.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the media size is in portrait, false if it is in landscape. </para>
						/// </returns>
						/// <java-name>
						/// isPortrait
						/// </java-name>
						public bool IsPortrait
						{
								[Dot42.DexImport("isPortrait", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

				}

		}

		/// <summary>
		///  <para>Base class that provides the content of a document to be printed.</para> <para> <h3>Lifecycle</h3></para> <para> <ul> <li> <para>Initially, you will receive a call to onStart(). This callback can be used to allocate resources.  </para></li> <li> <para>Next, you will get one or more calls to PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle) to inform you that the print attributes (page size, density, etc) changed giving you an opportunity to layout the content to match the new constraints.  </para></li> <li> <para>After every call to PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle), you  <b>may</b> get a call to ParcelFileDescriptor, CancellationSignal, WriteResultCallback) asking you to write a PDF file with the content for specific pages.  </para></li> <li> <para>Finally, you will receive a call to onFinish(). You can use this callback to release resources allocated in onStart().  </para></li></ul></para> <para>The onStart() callback is always the first call you will receive and is useful for doing one time setup or resource allocation before printing. You will not receive a subsequent call here. </para> <para>The PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle) callback requires that you layout the content based on the current PrintAttributes. The execution of this method is not considered completed until you invoke one of the methods on the passed in callback instance. Hence, you will not receive a subsequent call to any other method of this class until the execution of this method is complete by invoking one of the callback methods. </para> <para>The ParcelFileDescriptor, CancellationSignal, WriteResultCallback) requires that you render and write the content of some pages to the provided destination. The execution of this method is not considered complete until you invoke one of the methods on the passed in callback instance. Hence, you will not receive a subsequent call to any other method of this class until the execution of this method is complete by invoking one of the callback methods. You will never receive a sequence of one or more calls to this method without a previous call to PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle). </para> <para>The onFinish() callback is always the last call you will receive and is useful for doing one time cleanup or resource deallocation after printing. You will not receive a subsequent call here. </para> <para> <h3>Implementation</h3></para> <para>The APIs defined in this class are designed to enable doing part or all of the work on an arbitrary thread. For example, if the printed content does not depend on the UI state, i.e. on what is shown on the screen, then you can offload the entire work on a dedicated thread, thus making your application interactive while the print work is being performed. Note that while your activity is covered by the system print UI and a user cannot interact with it, doing the printing work on the main application thread may affect the performance of your other application components as they are also executed on that thread. </para> <para>You can also do work on different threads, for example if you print UI content, you can handle onStart() and PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle) on the UI thread (assuming onStart initializes resources needed for layout). This will ensure that the UI does not change while you are laying out the printed content. Then you can handle ParcelFileDescriptor, CancellationSignal, WriteResultCallback) and onFinish() on another thread. This will ensure that the main thread is busy for a minimal amount of time. Also this assumes that you will generate the printed content in PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle) which is not mandatory. If you use multiple threads, you are responsible for proper synchronization. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrintDocumentAdapter
		/// </java-name>
		[Dot42.DexImport("android/print/PrintDocumentAdapter", AccessFlags = 1057)]
		public abstract partial class PrintDocumentAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Extra: mapped to a boolean value that is  <code>true</code> if the current layout is for a print preview,  <code>false</code> otherwise. This extra is provided in the Bundle argument of the PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle) callback.</para> <para> <para>onLayout(PrintAttributes, PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PRINT_PREVIEW
				/// </java-name>
				[Dot42.DexImport("EXTRA_PRINT_PREVIEW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PRINT_PREVIEW = "EXTRA_PRINT_PREVIEW";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PrintDocumentAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when printing starts. You can use this callback to allocate resources. This method is invoked on the main thread. </para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the print attributes (page size, density, etc) changed giving you a chance to layout the content such that it matches the new constraints. This method is invoked on the main thread. </para> <para>After you are done laying out, you  <b>must</b> invoke: LayoutResultCallback#onLayoutFinished(PrintDocumentInfo, boolean) with the last argument  <code>true</code> or  <code>false</code> depending on whether the layout changed the content or not, respectively; or LayoutResultCallback#onLayoutFailed(CharSequence), if an error occurred; or LayoutResultCallback#onLayoutCancelled() if layout was cancelled in a response to a cancellation request via the passed in CancellationSignal. Note that you  <b>must</b> call one of the methods of the given callback for this method to be considered complete which is you will not receive any calls to this adapter until the current layout operation is complete by invoking a method on the callback instance. The callback methods can be invoked from an arbitrary thread. </para> <para>One of the arguments passed to this method is a CancellationSignal which is used to propagate requests from the system to your application for canceling the current layout operation. For example, a cancellation may be requested if the user changes a print option that may affect layout while you are performing a layout operation. In such a case the system will make an attempt to cancel the current layout as another one will have to be performed. Typically, you should register a cancellation callback in the cancellation signal. The cancellation callback  <b>will not</b> be made on the main thread and can be registered as follows: </para> <para> <pre>
				/// cancellationSignal.setOnCancelListener(new OnCancelListener() {
				///     &amp;#064;Override
				///     public void onCancel() {
				///         // Cancel layout
				///     }
				/// });
				/// </pre> </para> <para> <b>Note:</b> If the content is large and a layout will be performed, it is a good practice to schedule the work on a dedicated thread and register an observer in the provided CancellationSignal upon invocation of which you should stop the layout. </para> <para> <para>LayoutResultCallback </para> <para>CancellationSignal </para> <para>EXTRA_PRINT_PREVIEW </para></para>        
				/// </summary>
				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(Landroid/print/PrintAttributes;Landroid/print/PrintAttributes;Landroid/os/Cancel" +
    "lationSignal;Landroid/print/PrintDocumentAdapter$LayoutResultCallback;Landroid/o" +
    "s/Bundle;)V", AccessFlags = 1025)]
				public abstract void OnLayout(global::Android.Print.PrintAttributes oldAttributes, global::Android.Print.PrintAttributes newAttributes, global::Android.OS.CancellationSignal cancellationSignal, global::Android.Print.PrintDocumentAdapter.LayoutResultCallback callback, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when specific pages of the content should be written in the form of a PDF file to the given file descriptor. This method is invoked on the main thread. </para> <para>After you are done writing, you should close the file descriptor and invoke WriteResultCallback#onWriteFinished(PageRange[]), if writing completed successfully; or CharSequence), if an error occurred; or WriteResultCallback#onWriteCancelled(), if writing was cancelled in a response to a cancellation request via the passed in CancellationSignal. Note that you  <b>must</b> call one of the methods of the given callback for this method to be considered complete which is you will not receive any calls to this adapter until the current write operation is complete by invoking a method on the callback instance. The callback methods can be invoked from an arbitrary thread. </para> <para>One of the arguments passed to this method is a CancellationSignal which is used to propagate requests from the system to your application for canceling the current write operation. For example, a cancellation may be requested if the user changes a print option that may affect layout while you are performing a write operation. In such a case the system will make an attempt to cancel the current write as a layout will have to be performed which then may be followed by a write. Typically, you should register a cancellation callback in the cancellation signal. The cancellation callback  <b>will not</b> be made on the main thread and can be registered as follows: </para> <para> <pre>
				///  cancellationSignal.setOnCancelListener(new OnCancelListener() {
				///      &amp;#064;Override
				///      public void onCancel() {
				///          // Cancel write
				///      }
				///  });
				///  </pre> </para> <para> <b>Note:</b> If the printed content is large, it is a good practice to schedule writing it on a dedicated thread and register an observer in the provided CancellationSignal upon invocation of which you should stop writing. </para> <para> <para>WriteResultCallback </para> <para>CancellationSignal </para></para>        
				/// </summary>
				/// <java-name>
				/// onWrite
				/// </java-name>
				[Dot42.DexImport("onWrite", "([Landroid/print/PageRange;Landroid/os/ParcelFileDescriptor;Landroid/os/Cancellat" +
    "ionSignal;Landroid/print/PrintDocumentAdapter$WriteResultCallback;)V", AccessFlags = 1025)]
				public abstract void OnWrite(global::Android.Print.PageRange[] pages, global::Android.OS.ParcelFileDescriptor destination, global::Android.OS.CancellationSignal cancellationSignal, global::Android.Print.PrintDocumentAdapter.WriteResultCallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when printing finishes. You can use this callback to release resources acquired in onStart(). This method is invoked on the main thread. </para>        
				/// </summary>
				/// <java-name>
				/// onFinish
				/// </java-name>
				[Dot42.DexImport("onFinish", "()V", AccessFlags = 1)]
				public virtual void OnFinish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Base class for implementing a callback for the result of PrintAttributes, CancellationSignal, LayoutResultCallback, Bundle). </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintDocumentAdapter$LayoutResultCallback
				/// </java-name>
				[Dot42.DexImport("android/print/PrintDocumentAdapter$LayoutResultCallback", AccessFlags = 1033)]
				public abstract partial class LayoutResultCallback
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal LayoutResultCallback() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notifies that the layout finished and whether the content changed.</para> <para> <para>PrintDocumentInfo </para></para>        
						/// </summary>
						/// <java-name>
						/// onLayoutFinished
						/// </java-name>
						[Dot42.DexImport("onLayoutFinished", "(Landroid/print/PrintDocumentInfo;Z)V", AccessFlags = 1)]
						public virtual void OnLayoutFinished(global::Android.Print.PrintDocumentInfo info, bool changed) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notifies that an error occurred while laying out the document.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onLayoutFailed
						/// </java-name>
						[Dot42.DexImport("onLayoutFailed", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						public virtual void OnLayoutFailed(global::Java.Lang.ICharSequence error) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notifies that layout was cancelled as a result of a cancellation request. </para>        
						/// </summary>
						/// <java-name>
						/// onLayoutCancelled
						/// </java-name>
						[Dot42.DexImport("onLayoutCancelled", "()V", AccessFlags = 1)]
						public virtual void OnLayoutCancelled() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Base class for implementing a callback for the result of ParcelFileDescriptor, CancellationSignal, WriteResultCallback). </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintDocumentAdapter$WriteResultCallback
				/// </java-name>
				[Dot42.DexImport("android/print/PrintDocumentAdapter$WriteResultCallback", AccessFlags = 1033)]
				public abstract partial class WriteResultCallback
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal WriteResultCallback() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notifies that all the data was written.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onWriteFinished
						/// </java-name>
						[Dot42.DexImport("onWriteFinished", "([Landroid/print/PageRange;)V", AccessFlags = 1)]
						public virtual void OnWriteFinished(global::Android.Print.PageRange[] pages) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notifies that an error occurred while writing the data.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onWriteFailed
						/// </java-name>
						[Dot42.DexImport("onWriteFailed", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						public virtual void OnWriteFailed(global::Java.Lang.ICharSequence error) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notifies that write was cancelled as a result of a cancellation request. </para>        
						/// </summary>
						/// <java-name>
						/// onWriteCancelled
						/// </java-name>
						[Dot42.DexImport("onWriteCancelled", "()V", AccessFlags = 1)]
						public virtual void OnWriteCancelled() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>This class encapsulates information about a document for printing purposes. This meta-data is used by the platform and print services, components that interact with printers. For example, this class contains the number of pages contained in the document it describes and this number of pages is shown to the user allowing him/her to select the range to print. Also a print service may optimize the printing process based on the content type, such as document or photo. </para> <para>Instances of this class are created by the printing application and passed to the PrintDocumentInfo, boolean) PrintDocumentAdapter.LayoutResultCallback.onLayoutFinished( PrintDocumentInfo, boolean) callback after successfully laying out the content which is performed in PrintAttributes, android.os.CancellationSignal, PrintDocumentAdapter.LayoutResultCallback, android.os.Bundle) PrintDocumentAdapter.onLayout(PrintAttributes, PrintAttributes, android.os.CancellationSignal, PrintDocumentAdapter.LayoutResultCallback, android.os.Bundle). </para> <para>An example usage looks like this:  <pre></pre></para> <para> <pre>. . .</pre></para> <para> <pre>public void onLayout(PrintAttributes oldAttributes, PrintAttributes newAttributes,
		///         CancellationSignal cancellationSignal, LayoutResultCallback callback,
		///         Bundle metadata) {</pre></para> <para> <pre>       // Assume the app defined a LayoutResult class which contains
		///        // the layout result data and that the content is a document.
		///        LayoutResult result = doSomeLayoutWork();</pre></para> <para> <pre>       PrintDocumentInfo info = new PrintDocumentInfo
		///                .Builder("printed_file.pdf")
		///                .setContentType(PrintDocumentInfo.CONTENT_TYPE_DOCUMENT)
		///                .setPageCount(result.getPageCount())
		///                .build();</pre></para> <para> <pre>      callback.onLayoutFinished(info, result.getContentChanged());
		///   }</pre></para> <para> <pre>  . . .</pre></para> <para> <pre></pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrintDocumentInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrintDocumentInfo", AccessFlags = 49)]
		public sealed partial class PrintDocumentInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constant for unknown page count. </para>        
				/// </summary>
				/// <java-name>
				/// PAGE_COUNT_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("PAGE_COUNT_UNKNOWN", "I", AccessFlags = 25)]
				public const int PAGE_COUNT_UNKNOWN = -1;
				/// <summary>
				///  <para>Content type: unknown. </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_UNKNOWN = -1;
				/// <summary>
				///  <para>Content type: document. </para> <para>A print service may use normal paper to print the content instead of dedicated photo paper. Also it may use a lower quality printing process as the content is not as sensitive to print quality variation as a photo is. </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_TYPE_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_DOCUMENT", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_DOCUMENT = 0;
				/// <summary>
				///  <para>Content type: photo. </para> <para>A print service may use dedicated photo paper to print the content instead of normal paper. Also it may use a higher quality printing process as the content is more sensitive to print quality variation than a document. </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_TYPE_PHOTO
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_PHOTO", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_PHOTO = 1;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PrintDocumentInfo> CREATOR;
				/// <summary>
				///  <para>Creates a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintDocumentInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets the document name. This name may be shown to the user.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The document name. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the total number of pages.</para> <para> <para>PAGE_COUNT_UNKNOWN </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of pages.</para>
				/// </returns>
				/// <java-name>
				/// getPageCount
				/// </java-name>
				public int PageCount
				{
						[Dot42.DexImport("getPageCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the content type.</para> <para> <para>CONTENT_TYPE_UNKNOWN </para> <para>CONTENT_TYPE_DOCUMENT </para> <para>CONTENT_TYPE_PHOTO </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The content type.</para>
				/// </returns>
				/// <java-name>
				/// getContentType
				/// </java-name>
				public int ContentType
				{
						[Dot42.DexImport("getContentType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the document data size in bytes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The data size. </para>
				/// </returns>
				/// <java-name>
				/// getDataSize
				/// </java-name>
				public long DataSize
				{
						[Dot42.DexImport("getDataSize", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Builder for creating a PrintDocumentInfo. </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintDocumentInfo$Builder
				/// </java-name>
				[Dot42.DexImport("android/print/PrintDocumentInfo$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Builder(string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the total number of pages. </para> <para> <b>Default: </b> PAGE_COUNT_UNKNOWN </para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setPageCount
						/// </java-name>
						[Dot42.DexImport("setPageCount", "(I)Landroid/print/PrintDocumentInfo$Builder;", AccessFlags = 1)]
						public Builder SetPageCount(int pageCount) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the content type. </para> <para> <b>Default: </b> CONTENT_TYPE_UNKNOWN </para> <para> <para>CONTENT_TYPE_UNKNOWN </para> <para>CONTENT_TYPE_DOCUMENT </para> <para>CONTENT_TYPE_PHOTO </para></para>        
						/// </summary>
						/// <java-name>
						/// setContentType
						/// </java-name>
						[Dot42.DexImport("setContentType", "(I)Landroid/print/PrintDocumentInfo$Builder;", AccessFlags = 1)]
						public Builder SetContentType(int type) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Creates a new PrintDocumentInfo instance.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The new instance. </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/print/PrintDocumentInfo;", AccessFlags = 1)]
						public global::Android.Print.PrintDocumentInfo Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Print.PrintDocumentInfo);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>This class represents the capabilities of a printer. Instances of this class are created by a print service to report the capabilities of a printer it manages. The capabilities of a printer specify how it can print content. For example, what are the media sizes supported by the printer, what are the minimal margins of the printer based on its technical design, etc. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrinterCapabilitiesInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrinterCapabilitiesInfo", AccessFlags = 49)]
		public sealed partial class PrinterCapabilitiesInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PrinterCapabilitiesInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrinterCapabilitiesInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets the supported media sizes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The media sizes. </para>
				/// </returns>
				/// <java-name>
				/// getMediaSizes
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrintAttributes.MediaSize> MediaSizes
				{
						[Dot42.DexImport("getMediaSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintAttributes$MediaSize;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Print.PrintAttributes.MediaSize>); }
				}

				/// <summary>
				///  <para>Gets the supported resolutions.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The resolutions. </para>
				/// </returns>
				/// <java-name>
				/// getResolutions
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrintAttributes.Resolution> Resolutions
				{
						[Dot42.DexImport("getResolutions", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintAttributes$Resolution;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Print.PrintAttributes.Resolution>); }
				}

				/// <summary>
				///  <para>Gets the minimal margins. These are the minimal margins the printer physically supports.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The minimal margins. </para>
				/// </returns>
				/// <java-name>
				/// getMinMargins
				/// </java-name>
				public global::Android.Print.PrintAttributes.Margins MinMargins
				{
						[Dot42.DexImport("getMinMargins", "()Landroid/print/PrintAttributes$Margins;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintAttributes.Margins); }
				}

				/// <summary>
				///  <para>Gets the bit mask of supported color modes.</para> <para> <para>PrintAttributes::COLOR_MODE_COLOR </para> <para>PrintAttributes::COLOR_MODE_MONOCHROME </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The bit mask of supported color modes.</para>
				/// </returns>
				/// <java-name>
				/// getColorModes
				/// </java-name>
				public int ColorModes
				{
						[Dot42.DexImport("getColorModes", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the default print attributes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The default attributes. </para>
				/// </returns>
				/// <java-name>
				/// getDefaults
				/// </java-name>
				public global::Android.Print.PrintAttributes Defaults
				{
						[Dot42.DexImport("getDefaults", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintAttributes); }
				}

				/// <summary>
				///  <para>Builder for creating of a PrinterCapabilitiesInfo. This class is responsible to enforce that all required attributes have at least one default value. In other words, this class creates only well-formed PrinterCapabilitiesInfos. </para> <para>Look at the individual methods for a reference whether a property is required or if it is optional. </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrinterCapabilitiesInfo$Builder
				/// </java-name>
				[Dot42.DexImport("android/print/PrinterCapabilitiesInfo$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/print/PrinterId;)V", AccessFlags = 1)]
						public Builder(global::Android.Print.PrinterId printerId) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Adds a supported media size. </para> <para> <b>Required:</b> Yes </para> <para> <para>PrintAttributes.MediaSize </para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder. </para>
						/// </returns>
						/// <java-name>
						/// addMediaSize
						/// </java-name>
						[Dot42.DexImport("addMediaSize", "(Landroid/print/PrintAttributes$MediaSize;Z)Landroid/print/PrinterCapabilitiesInf" +
    "o$Builder;", AccessFlags = 1)]
						public Builder AddMediaSize(global::Android.Print.PrintAttributes.MediaSize mediaSize, bool isDefault) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Adds a supported resolution. </para> <para> <b>Required:</b> Yes </para> <para> <para>PrintAttributes.Resolution </para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder.</para>
						/// </returns>
						/// <java-name>
						/// addResolution
						/// </java-name>
						[Dot42.DexImport("addResolution", "(Landroid/print/PrintAttributes$Resolution;Z)Landroid/print/PrinterCapabilitiesIn" +
    "fo$Builder;", AccessFlags = 1)]
						public Builder AddResolution(global::Android.Print.PrintAttributes.Resolution resolution, bool isDefault) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the minimal margins. These are the minimal margins the printer physically supports.</para> <para> <b>Required:</b> Yes </para> <para> <para>PrintAttributes.Margins </para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder.</para>
						/// </returns>
						/// <java-name>
						/// setMinMargins
						/// </java-name>
						[Dot42.DexImport("setMinMargins", "(Landroid/print/PrintAttributes$Margins;)Landroid/print/PrinterCapabilitiesInfo$B" +
    "uilder;", AccessFlags = 1)]
						public Builder SetMinMargins(global::Android.Print.PrintAttributes.Margins margins) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the color modes. </para> <para> <b>Required:</b> Yes </para> <para> <para>PrintAttributes::COLOR_MODE_COLOR </para> <para>PrintAttributes::COLOR_MODE_MONOCHROME </para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder.</para>
						/// </returns>
						/// <java-name>
						/// setColorModes
						/// </java-name>
						[Dot42.DexImport("setColorModes", "(II)Landroid/print/PrinterCapabilitiesInfo$Builder;", AccessFlags = 1)]
						public Builder SetColorModes(int colorModes, int defaultColorMode) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Crates a new PrinterCapabilitiesInfo enforcing that all required properties have been specified. See individual methods in this class for reference about required attributes.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>A new PrinterCapabilitiesInfo.</para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/print/PrinterCapabilitiesInfo;", AccessFlags = 1)]
						public global::Android.Print.PrinterCapabilitiesInfo Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Print.PrinterCapabilitiesInfo);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>This class represents the unique id of a printer. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrinterId
		/// </java-name>
		[Dot42.DexImport("android/print/PrinterId", AccessFlags = 49)]
		public sealed partial class PrinterId : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PrinterId> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrinterId() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets the id of this printer which is unique in the context of the print service that manages it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The printer name. </para>
				/// </returns>
				/// <java-name>
				/// getLocalId
				/// </java-name>
				public string LocalId
				{
						[Dot42.DexImport("getLocalId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>This class represents the description of a printer. Instances of this class are created by print services to report to the system the printers they manage. The information of this class has two major components, printer properties such as name, id, status, description and printer capabilities which describe the various print modes a printer supports such as media sizes, margins, etc. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrinterInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrinterInfo", AccessFlags = 49)]
		public sealed partial class PrinterInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Printer status: the printer is idle and ready to print. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_IDLE
				/// </java-name>
				[Dot42.DexImport("STATUS_IDLE", "I", AccessFlags = 25)]
				public const int STATUS_IDLE = 1;
				/// <summary>
				///  <para>Printer status: the printer is busy printing. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_BUSY
				/// </java-name>
				[Dot42.DexImport("STATUS_BUSY", "I", AccessFlags = 25)]
				public const int STATUS_BUSY = 2;
				/// <summary>
				///  <para>Printer status: the printer is not available. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("STATUS_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int STATUS_UNAVAILABLE = 3;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PrinterInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrinterInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Get the globally unique printer id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The printer id. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public global::Android.Print.PrinterId Id
				{
						[Dot42.DexImport("getId", "()Landroid/print/PrinterId;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrinterId); }
				}

				/// <summary>
				///  <para>Get the printer name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The printer name. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the printer status.</para> <para> <para>STATUS_BUSY </para> <para>STATUS_IDLE </para> <para>STATUS_UNAVAILABLE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The status.</para>
				/// </returns>
				/// <java-name>
				/// getStatus
				/// </java-name>
				public int Status
				{
						[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the printer description.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The description. </para>
				/// </returns>
				/// <java-name>
				/// getDescription
				/// </java-name>
				public string Description
				{
						[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the printer capabilities.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The capabilities. </para>
				/// </returns>
				/// <java-name>
				/// getCapabilities
				/// </java-name>
				public global::Android.Print.PrinterCapabilitiesInfo Capabilities
				{
						[Dot42.DexImport("getCapabilities", "()Landroid/print/PrinterCapabilitiesInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrinterCapabilitiesInfo); }
				}

				/// <summary>
				///  <para>Builder for creating of a PrinterInfo. </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrinterInfo$Builder
				/// </java-name>
				[Dot42.DexImport("android/print/PrinterInfo$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/print/PrinterId;Ljava/lang/String;I)V", AccessFlags = 1)]
						public Builder(global::Android.Print.PrinterId printerId, string @string, int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/print/PrinterInfo;)V", AccessFlags = 1)]
						public Builder(global::Android.Print.PrinterInfo printerInfo) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the printer status.</para> <para> <para>PrinterInfo::STATUS_IDLE </para> <para>PrinterInfo::STATUS_BUSY </para> <para>PrinterInfo::STATUS_UNAVAILABLE </para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder.</para>
						/// </returns>
						/// <java-name>
						/// setStatus
						/// </java-name>
						[Dot42.DexImport("setStatus", "(I)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetStatus(int status) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the  <b>localized</b> printer name which is shown to the user</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder. </para>
						/// </returns>
						/// <java-name>
						/// setName
						/// </java-name>
						[Dot42.DexImport("setName", "(Ljava/lang/String;)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetName(string name) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the  <b>localized</b> printer description which is shown to the user</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder. </para>
						/// </returns>
						/// <java-name>
						/// setDescription
						/// </java-name>
						[Dot42.DexImport("setDescription", "(Ljava/lang/String;)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetDescription(string description) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the printer capabilities.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This builder. </para>
						/// </returns>
						/// <java-name>
						/// setCapabilities
						/// </java-name>
						[Dot42.DexImport("setCapabilities", "(Landroid/print/PrinterCapabilitiesInfo;)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetCapabilities(global::Android.Print.PrinterCapabilitiesInfo capabilities) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Creates a new PrinterInfo.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>A new PrinterInfo. </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/print/PrinterInfo;", AccessFlags = 1)]
						public global::Android.Print.PrinterInfo Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Print.PrinterInfo);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>This class represents a print job from the perspective of an application. It contains behavior methods for performing operations on it as well as methods for querying its state. A snapshot of the print job state is represented by the PrintJobInfo class. The state of a print job may change over time. An application receives instances of this class when creating a print job or querying for its print jobs. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrintJob
		/// </java-name>
		[Dot42.DexImport("android/print/PrintJob", AccessFlags = 49)]
		public sealed partial class PrintJob
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintJob() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancels this print job. You can request cancellation of a queued, started, blocked, or failed print job.</para> <para> <para>isQueued() </para> <para>isStarted() </para> <para>isBlocked() </para> <para>isFailed() </para></para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Restarts this print job. You can request restart of a failed print job.</para> <para> <para>isFailed() </para></para>        
				/// </summary>
				/// <java-name>
				/// restart
				/// </java-name>
				[Dot42.DexImport("restart", "()V", AccessFlags = 1)]
				public void Restart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Gets the unique print job id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public global::Android.Print.PrintJobId Id
				{
						[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintJobId); }
				}

				/// <summary>
				///  <para>Gets the PrintJobInfo that describes this job. </para> <para> <b>Node:</b>The returned info object is a snapshot of the current print job state. Every call to this method returns a fresh info object that reflects the current print job state. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The print job info. </para>
				/// </returns>
				/// <java-name>
				/// getInfo
				/// </java-name>
				public global::Android.Print.PrintJobInfo Info
				{
						[Dot42.DexImport("getInfo", "()Landroid/print/PrintJobInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintJobInfo); }
				}

				/// <summary>
				///  <para>Gets whether this print job is queued. Such a print job is ready to be printed. You can request a cancellation via cancel().</para> <para> <para>cancel() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is queued.</para>
				/// </returns>
				/// <java-name>
				/// isQueued
				/// </java-name>
				public bool IsQueued
				{
						[Dot42.DexImport("isQueued", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is started. Such a print job is being printed. You can request a cancellation via cancel().</para> <para> <para>cancel() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is started.</para>
				/// </returns>
				/// <java-name>
				/// isStarted
				/// </java-name>
				public bool IsStarted
				{
						[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is blocked. Such a print job is halted due to an abnormal condition. You can request a cancellation via cancel().</para> <para> <para>cancel() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is blocked.</para>
				/// </returns>
				/// <java-name>
				/// isBlocked
				/// </java-name>
				public bool IsBlocked
				{
						[Dot42.DexImport("isBlocked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is completed. Such a print job is successfully printed. You can neither cancel nor restart such a print job.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is completed. </para>
				/// </returns>
				/// <java-name>
				/// isCompleted
				/// </java-name>
				public bool IsCompleted
				{
						[Dot42.DexImport("isCompleted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is failed. Such a print job is not successfully printed due to an error. You can request a restart via restart() or cancel via cancel().</para> <para> <para>restart() </para> <para>cancel() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is failed.</para>
				/// </returns>
				/// <java-name>
				/// isFailed
				/// </java-name>
				public bool IsFailed
				{
						[Dot42.DexImport("isFailed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is cancelled. Such a print job was cancelled as a result of a user request. This is a final state. You cannot restart such a print job.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is cancelled. </para>
				/// </returns>
				/// <java-name>
				/// isCancelled
				/// </java-name>
				public bool IsCancelled
				{
						[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>This class represents the id of a print job. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrintJobId
		/// </java-name>
		[Dot42.DexImport("android/print/PrintJobId", AccessFlags = 49)]
		public sealed partial class PrintJobId : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PrintJobId> CREATOR;
				/// <summary>
				///  <para>Creates a new instance.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintJobId() /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>This class represents the description of a print job. The print job state includes properties such as its id, print attributes used for generating the content, and so on. Note that the print jobs state may change over time and this class represents a snapshot of this state. </para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrintJobInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrintJobInfo", AccessFlags = 49)]
		public sealed partial class PrintJobInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Print job state: The print job is being created but not yet ready to be printed. </para> <para>Next valid states: STATE_QUEUED </para>        
				/// </summary>
				/// <java-name>
				/// STATE_CREATED
				/// </java-name>
				[Dot42.DexImport("STATE_CREATED", "I", AccessFlags = 25)]
				public const int STATE_CREATED = 1;
				/// <summary>
				///  <para>Print job state: The print jobs is created, it is ready to be printed and should be processed. </para> <para>Next valid states: STATE_STARTED, STATE_FAILED, STATE_CANCELED </para>        
				/// </summary>
				/// <java-name>
				/// STATE_QUEUED
				/// </java-name>
				[Dot42.DexImport("STATE_QUEUED", "I", AccessFlags = 25)]
				public const int STATE_QUEUED = 2;
				/// <summary>
				///  <para>Print job state: The print job is being printed. </para> <para>Next valid states: STATE_COMPLETED, STATE_FAILED, STATE_CANCELED, STATE_BLOCKED </para>        
				/// </summary>
				/// <java-name>
				/// STATE_STARTED
				/// </java-name>
				[Dot42.DexImport("STATE_STARTED", "I", AccessFlags = 25)]
				public const int STATE_STARTED = 3;
				/// <summary>
				///  <para>Print job state: The print job is blocked. </para> <para>Next valid states: STATE_FAILED, STATE_CANCELED, STATE_STARTED </para>        
				/// </summary>
				/// <java-name>
				/// STATE_BLOCKED
				/// </java-name>
				[Dot42.DexImport("STATE_BLOCKED", "I", AccessFlags = 25)]
				public const int STATE_BLOCKED = 4;
				/// <summary>
				///  <para>Print job state: The print job is successfully printed. This is a terminal state. </para> <para>Next valid states: None </para>        
				/// </summary>
				/// <java-name>
				/// STATE_COMPLETED
				/// </java-name>
				[Dot42.DexImport("STATE_COMPLETED", "I", AccessFlags = 25)]
				public const int STATE_COMPLETED = 5;
				/// <summary>
				///  <para>Print job state: The print job was printing but printing failed. </para> <para>Next valid states: STATE_CANCELED, STATE_STARTED </para>        
				/// </summary>
				/// <java-name>
				/// STATE_FAILED
				/// </java-name>
				[Dot42.DexImport("STATE_FAILED", "I", AccessFlags = 25)]
				public const int STATE_FAILED = 6;
				/// <summary>
				///  <para>Print job state: The print job is canceled. This is a terminal state. </para> <para>Next valid states: None </para>        
				/// </summary>
				/// <java-name>
				/// STATE_CANCELED
				/// </java-name>
				[Dot42.DexImport("STATE_CANCELED", "I", AccessFlags = 25)]
				public const int STATE_CANCELED = 7;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Print.PrintJobInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintJobInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Gets the unique print job id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public global::Android.Print.PrintJobId Id
				{
						[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintJobId); }
				}

				/// <summary>
				///  <para>Gets the human readable job label.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The label. </para>
				/// </returns>
				/// <java-name>
				/// getLabel
				/// </java-name>
				public string Label
				{
						[Dot42.DexImport("getLabel", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the unique target printer id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The target printer id. </para>
				/// </returns>
				/// <java-name>
				/// getPrinterId
				/// </java-name>
				public global::Android.Print.PrinterId PrinterId
				{
						[Dot42.DexImport("getPrinterId", "()Landroid/print/PrinterId;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrinterId); }
				}

				/// <summary>
				///  <para>Gets the current job state.</para> <para> <para>STATE_CREATED </para> <para>STATE_QUEUED </para> <para>STATE_STARTED </para> <para>STATE_COMPLETED </para> <para>STATE_BLOCKED </para> <para>STATE_FAILED </para> <para>STATE_CANCELED </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The job state.</para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				public int State
				{
						[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the wall time in millisecond when this print job was created.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The creation time in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getCreationTime
				/// </java-name>
				public long CreationTime
				{
						[Dot42.DexImport("getCreationTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Gets the number of copies.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of copies or zero if not set. </para>
				/// </returns>
				/// <java-name>
				/// getCopies
				/// </java-name>
				public int Copies
				{
						[Dot42.DexImport("getCopies", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the included pages.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The included pages or  <code>null</code> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getPages
				/// </java-name>
				public global::Android.Print.PageRange[] Pages
				{
						[Dot42.DexImport("getPages", "()[Landroid/print/PageRange;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PageRange[]); }
				}

				/// <summary>
				///  <para>Gets the print job attributes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The attributes. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				public global::Android.Print.PrintAttributes Attributes
				{
						[Dot42.DexImport("getAttributes", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintAttributes); }
				}

				/// <summary>
				///  <para>Builder for creating a PrintJobInfo. </para>    
				/// </summary>
				/// <java-name>
				/// android/print/PrintJobInfo$Builder
				/// </java-name>
				[Dot42.DexImport("android/print/PrintJobInfo$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/print/PrintJobInfo;)V", AccessFlags = 1)]
						public Builder(global::Android.Print.PrintJobInfo printJobInfo) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the number of copies.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setCopies
						/// </java-name>
						[Dot42.DexImport("setCopies", "(I)V", AccessFlags = 1)]
						public void SetCopies(int copies) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the print job attributes.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setAttributes
						/// </java-name>
						[Dot42.DexImport("setAttributes", "(Landroid/print/PrintAttributes;)V", AccessFlags = 1)]
						public void SetAttributes(global::Android.Print.PrintAttributes attributes) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the included pages.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setPages
						/// </java-name>
						[Dot42.DexImport("setPages", "([Landroid/print/PageRange;)V", AccessFlags = 1)]
						public void SetPages(global::Android.Print.PageRange[] pages) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// putAdvancedOption
						/// </java-name>
						[Dot42.DexImport("putAdvancedOption", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public void PutAdvancedOption(string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// putAdvancedOption
						/// </java-name>
						[Dot42.DexImport("putAdvancedOption", "(Ljava/lang/String;I)V", AccessFlags = 1)]
						public void PutAdvancedOption(string @string, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Creates a new PrintJobInfo instance.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The new instance. </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/print/PrintJobInfo;", AccessFlags = 1)]
						public global::Android.Print.PrintJobInfo Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Print.PrintJobInfo);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>System level service for accessing the printing capabilities of the platform. </para> <para>To obtain a handle to the print manager do the following: </para> <para> <pre>
		/// PrintManager printManager =
		///         (PrintManager) context.getSystemService(Context.PRINT_SERVICE);
		/// </pre></para> <para> <h3>Print mechanics</h3></para> <para>The key idea behind printing on the platform is that the content to be printed should be laid out for the currently selected print options resulting in an optimized output and higher user satisfaction. To achieve this goal the platform declares a contract that the printing application has to follow which is defined by the PrintDocumentAdapter class. At a higher level the contract is that when the user selects some options from the print UI that may affect the way content is laid out, for example page size, the application receives a callback allowing it to layout the content to better fit these new constraints. After a layout pass the system may ask the application to render one or more pages one or more times. For example, an application may produce a single column list for smaller page sizes and a multi-column table for larger page sizes. </para> <para> <h3>Print jobs</h3></para> <para>Print jobs are started by calling the PrintDocumentAdapter, PrintAttributes) from an activity which results in bringing up the system print UI. Once the print UI is up, when the user changes a selected print option that affects the way content is laid out the system starts to interact with the application following the mechanics described the section above. </para> <para>Print jobs can be in created, queued, started, blocked, completed, failed, and canceled state. Print jobs are stored in dedicated system spooler until they are handled which is they are cancelled or completed. Active print jobs, ones that are not cancelled or completed, are considered failed if the device reboots as the new boot may be after a very long time. The user may choose to restart such print jobs. Once a print job is queued all relevant content is stored in the system spooler and its lifecycle becomes detached from this of the application that created it. </para> <para>An applications can query the print spooler for current print jobs it created but not print jobs created by other applications. </para> <para> <para>PrintJob </para> <para>PrintJobInfo </para></para>    
		/// </summary>
		/// <java-name>
		/// android/print/PrintManager
		/// </java-name>
		[Dot42.DexImport("android/print/PrintManager", AccessFlags = 49)]
		public sealed partial class PrintManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a print job for printing a PrintDocumentAdapter with default print attributes. </para> <para>Calling this method brings the print UI allowing the user to customize the print job and returns a PrintJob object without waiting for the user to customize or confirm the print job. The returned print job instance is in a created state. </para> <para>This method can be called only from an Activity. The rationale is that printing from a service will create an inconsistent user experience as the print UI would appear without any context. </para> <para>Also the passed in PrintDocumentAdapter will be considered invalid if your activity is finished. The rationale is that once the activity that initiated printing is finished, the provided adapter may be in an inconsistent state as it may depend on the UI presented by the activity. </para> <para>The default print attributes are a hint to the system how the data is to be printed. For example, a photo editor may look at the photo aspect ratio to determine the default orientation and provide a hint whether the printing should be in portrait or landscape. The system will do a best effort to selected the hinted options in the print dialog, given the current printer supports them. </para> <para> <para>PrintJob </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The created print job on success or null on failure. </para>
				/// </returns>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/String;Landroid/print/PrintDocumentAdapter;Landroid/print/PrintAttrib" +
    "utes;)Landroid/print/PrintJob;", AccessFlags = 1)]
				public global::Android.Print.PrintJob Print(string printJobName, global::Android.Print.PrintDocumentAdapter documentAdapter, global::Android.Print.PrintAttributes attributes) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintJob);
				}

				/// <summary>
				///  <para>Gets the print jobs for this application.</para> <para> <para>PrintJob </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The print job list. </para>
				/// </returns>
				/// <java-name>
				/// getPrintJobs
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrintJob> PrintJobs
				{
						[Dot42.DexImport("getPrintJobs", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintJob;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Print.PrintJob>); }
				}

		}

}

