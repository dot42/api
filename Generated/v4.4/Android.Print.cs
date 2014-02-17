// Copyright (C) 2014 dot42
//
// Original filename: Android.Print.cs
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
namespace Android.Print
{
		/// <java-name>
		/// android/print/PageRange
		/// </java-name>
		[Dot42.DexImport("android/print/PageRange", AccessFlags = 49)]
		public sealed partial class PageRange : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ALL_PAGES
				/// </java-name>
				[Dot42.DexImport("ALL_PAGES", "Landroid/print/PageRange;", AccessFlags = 25)]
				public static readonly global::Android.Print.PageRange ALL_PAGES;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PageRange> CREATOR;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PageRange(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStart
				/// </java-name>
				[Dot42.DexImport("getStart", "()I", AccessFlags = 1)]
				public int GetStart() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEnd
				/// </java-name>
				[Dot42.DexImport("getEnd", "()I", AccessFlags = 1)]
				public int GetEnd() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getStart
				/// </java-name>
				public int Start
				{
				[Dot42.DexImport("getStart", "()I", AccessFlags = 1)]
						get{ return GetStart(); }
				}

				/// <java-name>
				/// getEnd
				/// </java-name>
				public int End
				{
				[Dot42.DexImport("getEnd", "()I", AccessFlags = 1)]
						get{ return GetEnd(); }
				}

		}

		/// <java-name>
		/// android/print/PrintJobId
		/// </java-name>
		[Dot42.DexImport("android/print/PrintJobId", AccessFlags = 49)]
		public sealed partial class PrintJobId : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PrintJobId> CREATOR;
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/print/PrintJobInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrintJobInfo", AccessFlags = 49)]
		public sealed partial class PrintJobInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATE_CREATED
				/// </java-name>
				[Dot42.DexImport("STATE_CREATED", "I", AccessFlags = 25)]
				public const int STATE_CREATED = 1;
				/// <java-name>
				/// STATE_QUEUED
				/// </java-name>
				[Dot42.DexImport("STATE_QUEUED", "I", AccessFlags = 25)]
				public const int STATE_QUEUED = 2;
				/// <java-name>
				/// STATE_STARTED
				/// </java-name>
				[Dot42.DexImport("STATE_STARTED", "I", AccessFlags = 25)]
				public const int STATE_STARTED = 3;
				/// <java-name>
				/// STATE_BLOCKED
				/// </java-name>
				[Dot42.DexImport("STATE_BLOCKED", "I", AccessFlags = 25)]
				public const int STATE_BLOCKED = 4;
				/// <java-name>
				/// STATE_COMPLETED
				/// </java-name>
				[Dot42.DexImport("STATE_COMPLETED", "I", AccessFlags = 25)]
				public const int STATE_COMPLETED = 5;
				/// <java-name>
				/// STATE_FAILED
				/// </java-name>
				[Dot42.DexImport("STATE_FAILED", "I", AccessFlags = 25)]
				public const int STATE_FAILED = 6;
				/// <java-name>
				/// STATE_CANCELED
				/// </java-name>
				[Dot42.DexImport("STATE_CANCELED", "I", AccessFlags = 25)]
				public const int STATE_CANCELED = 7;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PrintJobInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintJobInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
				public global::Android.Print.PrintJobId GetId() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintJobId);
				}

				/// <java-name>
				/// getLabel
				/// </java-name>
				[Dot42.DexImport("getLabel", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetLabel() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPrinterId
				/// </java-name>
				[Dot42.DexImport("getPrinterId", "()Landroid/print/PrinterId;", AccessFlags = 1)]
				public global::Android.Print.PrinterId GetPrinterId() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrinterId);
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
				public int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCreationTime
				/// </java-name>
				[Dot42.DexImport("getCreationTime", "()J", AccessFlags = 1)]
				public long GetCreationTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getCopies
				/// </java-name>
				[Dot42.DexImport("getCopies", "()I", AccessFlags = 1)]
				public int GetCopies() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPages
				/// </java-name>
				[Dot42.DexImport("getPages", "()[Landroid/print/PageRange;", AccessFlags = 1)]
				public global::Android.Print.PageRange[] GetPages() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PageRange[]);
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes GetAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				/// getId
				/// </java-name>
				public global::Android.Print.PrintJobId Id
				{
				[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getLabel
				/// </java-name>
				public string Label
				{
				[Dot42.DexImport("getLabel", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLabel(); }
				}

				/// <java-name>
				/// getPrinterId
				/// </java-name>
				public global::Android.Print.PrinterId PrinterId
				{
				[Dot42.DexImport("getPrinterId", "()Landroid/print/PrinterId;", AccessFlags = 1)]
						get{ return GetPrinterId(); }
				}

				/// <java-name>
				/// getState
				/// </java-name>
				public int State
				{
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return GetState(); }
				}

				/// <java-name>
				/// getCreationTime
				/// </java-name>
				public long CreationTime
				{
				[Dot42.DexImport("getCreationTime", "()J", AccessFlags = 1)]
						get{ return GetCreationTime(); }
				}

				/// <java-name>
				/// getCopies
				/// </java-name>
				public int Copies
				{
				[Dot42.DexImport("getCopies", "()I", AccessFlags = 1)]
						get{ return GetCopies(); }
				}

				/// <java-name>
				/// getPages
				/// </java-name>
				public global::Android.Print.PageRange[] Pages
				{
				[Dot42.DexImport("getPages", "()[Landroid/print/PageRange;", AccessFlags = 1)]
						get{ return GetPages(); }
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				public global::Android.Print.PrintAttributes Attributes
				{
				[Dot42.DexImport("getAttributes", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
						get{ return GetAttributes(); }
				}

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

						/// <java-name>
						/// setCopies
						/// </java-name>
						[Dot42.DexImport("setCopies", "(I)V", AccessFlags = 1)]
						public void SetCopies(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setAttributes
						/// </java-name>
						[Dot42.DexImport("setAttributes", "(Landroid/print/PrintAttributes;)V", AccessFlags = 1)]
						public void SetAttributes(global::Android.Print.PrintAttributes printAttributes) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setPages
						/// </java-name>
						[Dot42.DexImport("setPages", "([Landroid/print/PageRange;)V", AccessFlags = 1)]
						public void SetPages(global::Android.Print.PageRange[] pageRange) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getPrintJobs
				/// </java-name>
				[Dot42.DexImport("getPrintJobs", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintJob;>;")]
				public global::Java.Util.IList<global::Android.Print.PrintJob> GetPrintJobs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Print.PrintJob>);
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/String;Landroid/print/PrintDocumentAdapter;Landroid/print/PrintAttrib" +
    "utes;)Landroid/print/PrintJob;", AccessFlags = 1)]
				public global::Android.Print.PrintJob Print(string @string, global::Android.Print.PrintDocumentAdapter printDocumentAdapter, global::Android.Print.PrintAttributes printAttributes) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintJob);
				}

				/// <java-name>
				/// getPrintJobs
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrintJob> PrintJobs
				{
				[Dot42.DexImport("getPrintJobs", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintJob;>;")]
						get{ return GetPrintJobs(); }
				}

		}

		/// <java-name>
		/// android/print/PrintAttributes
		/// </java-name>
		[Dot42.DexImport("android/print/PrintAttributes", AccessFlags = 49)]
		public sealed partial class PrintAttributes : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// COLOR_MODE_MONOCHROME
				/// </java-name>
				[Dot42.DexImport("COLOR_MODE_MONOCHROME", "I", AccessFlags = 25)]
				public const int COLOR_MODE_MONOCHROME = 1;
				/// <java-name>
				/// COLOR_MODE_COLOR
				/// </java-name>
				[Dot42.DexImport("COLOR_MODE_COLOR", "I", AccessFlags = 25)]
				public const int COLOR_MODE_COLOR = 2;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PrintAttributes> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintAttributes() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMediaSize
				/// </java-name>
				[Dot42.DexImport("getMediaSize", "()Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes.MediaSize GetMediaSize() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes.MediaSize);
				}

				/// <java-name>
				/// getResolution
				/// </java-name>
				[Dot42.DexImport("getResolution", "()Landroid/print/PrintAttributes$Resolution;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes.Resolution GetResolution() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes.Resolution);
				}

				/// <java-name>
				/// getMinMargins
				/// </java-name>
				[Dot42.DexImport("getMinMargins", "()Landroid/print/PrintAttributes$Margins;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes.Margins GetMinMargins() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes.Margins);
				}

				/// <java-name>
				/// getColorMode
				/// </java-name>
				[Dot42.DexImport("getColorMode", "()I", AccessFlags = 1)]
				public int GetColorMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getMinMargins
				/// </java-name>
				public global::Android.Print.PrintAttributes.Margins MinMargins
				{
				[Dot42.DexImport("getMinMargins", "()Landroid/print/PrintAttributes$Margins;", AccessFlags = 1)]
						get{ return GetMinMargins(); }
				}

				/// <java-name>
				/// getColorMode
				/// </java-name>
				public int ColorMode
				{
				[Dot42.DexImport("getColorMode", "()I", AccessFlags = 1)]
						get{ return GetColorMode(); }
				}

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

						/// <java-name>
						/// setMediaSize
						/// </java-name>
						[Dot42.DexImport("setMediaSize", "(Landroid/print/PrintAttributes$MediaSize;)Landroid/print/PrintAttributes$Builder" +
    ";", AccessFlags = 1)]
						public Builder SetMediaSize(global::Android.Print.PrintAttributes.MediaSize mediaSize) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setResolution
						/// </java-name>
						[Dot42.DexImport("setResolution", "(Landroid/print/PrintAttributes$Resolution;)Landroid/print/PrintAttributes$Builde" +
    "r;", AccessFlags = 1)]
						public Builder SetResolution(global::Android.Print.PrintAttributes.Resolution resolution) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMinMargins
						/// </java-name>
						[Dot42.DexImport("setMinMargins", "(Landroid/print/PrintAttributes$Margins;)Landroid/print/PrintAttributes$Builder;", AccessFlags = 1)]
						public Builder SetMinMargins(global::Android.Print.PrintAttributes.Margins margins) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setColorMode
						/// </java-name>
						[Dot42.DexImport("setColorMode", "(I)Landroid/print/PrintAttributes$Builder;", AccessFlags = 1)]
						public Builder SetColorMode(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
						public global::Android.Print.PrintAttributes Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Print.PrintAttributes);
						}

				}

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
						/// getLeftMils
						/// </java-name>
						[Dot42.DexImport("getLeftMils", "()I", AccessFlags = 1)]
						public int GetLeftMils() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getTopMils
						/// </java-name>
						[Dot42.DexImport("getTopMils", "()I", AccessFlags = 1)]
						public int GetTopMils() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getRightMils
						/// </java-name>
						[Dot42.DexImport("getRightMils", "()I", AccessFlags = 1)]
						public int GetRightMils() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getBottomMils
						/// </java-name>
						[Dot42.DexImport("getBottomMils", "()I", AccessFlags = 1)]
						public int GetBottomMils() /* MethodBuilder.Create */ 
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
						public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// getLeftMils
						/// </java-name>
						public int LeftMils
						{
						[Dot42.DexImport("getLeftMils", "()I", AccessFlags = 1)]
								get{ return GetLeftMils(); }
						}

						/// <java-name>
						/// getTopMils
						/// </java-name>
						public int TopMils
						{
						[Dot42.DexImport("getTopMils", "()I", AccessFlags = 1)]
								get{ return GetTopMils(); }
						}

						/// <java-name>
						/// getRightMils
						/// </java-name>
						public int RightMils
						{
						[Dot42.DexImport("getRightMils", "()I", AccessFlags = 1)]
								get{ return GetRightMils(); }
						}

						/// <java-name>
						/// getBottomMils
						/// </java-name>
						public int BottomMils
						{
						[Dot42.DexImport("getBottomMils", "()I", AccessFlags = 1)]
								get{ return GetBottomMils(); }
						}

				}

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
						/// getId
						/// </java-name>
						[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						public string GetId() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getLabel
						/// </java-name>
						[Dot42.DexImport("getLabel", "()Ljava/lang/String;", AccessFlags = 1)]
						public string GetLabel() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getHorizontalDpi
						/// </java-name>
						[Dot42.DexImport("getHorizontalDpi", "()I", AccessFlags = 1)]
						public int GetHorizontalDpi() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getVerticalDpi
						/// </java-name>
						[Dot42.DexImport("getVerticalDpi", "()I", AccessFlags = 1)]
						public int GetVerticalDpi() /* MethodBuilder.Create */ 
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
						public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// getId
						/// </java-name>
						public string Id
						{
						[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetId(); }
						}

						/// <java-name>
						/// getLabel
						/// </java-name>
						public string Label
						{
						[Dot42.DexImport("getLabel", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLabel(); }
						}

						/// <java-name>
						/// getHorizontalDpi
						/// </java-name>
						public int HorizontalDpi
						{
						[Dot42.DexImport("getHorizontalDpi", "()I", AccessFlags = 1)]
								get{ return GetHorizontalDpi(); }
						}

						/// <java-name>
						/// getVerticalDpi
						/// </java-name>
						public int VerticalDpi
						{
						[Dot42.DexImport("getVerticalDpi", "()I", AccessFlags = 1)]
								get{ return GetVerticalDpi(); }
						}

				}

				/// <java-name>
				/// android/print/PrintAttributes$MediaSize
				/// </java-name>
				[Dot42.DexImport("android/print/PrintAttributes$MediaSize", AccessFlags = 25)]
				public sealed partial class MediaSize
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// UNKNOWN_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_PORTRAIT", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize UNKNOWN_PORTRAIT;
						/// <java-name>
						/// UNKNOWN_LANDSCAPE
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_LANDSCAPE", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize UNKNOWN_LANDSCAPE;
						/// <java-name>
						/// ISO_A0
						/// </java-name>
						[Dot42.DexImport("ISO_A0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A0;
						/// <java-name>
						/// ISO_A1
						/// </java-name>
						[Dot42.DexImport("ISO_A1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A1;
						/// <java-name>
						/// ISO_A2
						/// </java-name>
						[Dot42.DexImport("ISO_A2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A2;
						/// <java-name>
						/// ISO_A3
						/// </java-name>
						[Dot42.DexImport("ISO_A3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A3;
						/// <java-name>
						/// ISO_A4
						/// </java-name>
						[Dot42.DexImport("ISO_A4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A4;
						/// <java-name>
						/// ISO_A5
						/// </java-name>
						[Dot42.DexImport("ISO_A5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A5;
						/// <java-name>
						/// ISO_A6
						/// </java-name>
						[Dot42.DexImport("ISO_A6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A6;
						/// <java-name>
						/// ISO_A7
						/// </java-name>
						[Dot42.DexImport("ISO_A7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A7;
						/// <java-name>
						/// ISO_A8
						/// </java-name>
						[Dot42.DexImport("ISO_A8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A8;
						/// <java-name>
						/// ISO_A9
						/// </java-name>
						[Dot42.DexImport("ISO_A9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A9;
						/// <java-name>
						/// ISO_A10
						/// </java-name>
						[Dot42.DexImport("ISO_A10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_A10;
						/// <java-name>
						/// ISO_B0
						/// </java-name>
						[Dot42.DexImport("ISO_B0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B0;
						/// <java-name>
						/// ISO_B1
						/// </java-name>
						[Dot42.DexImport("ISO_B1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B1;
						/// <java-name>
						/// ISO_B2
						/// </java-name>
						[Dot42.DexImport("ISO_B2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B2;
						/// <java-name>
						/// ISO_B3
						/// </java-name>
						[Dot42.DexImport("ISO_B3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B3;
						/// <java-name>
						/// ISO_B4
						/// </java-name>
						[Dot42.DexImport("ISO_B4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B4;
						/// <java-name>
						/// ISO_B5
						/// </java-name>
						[Dot42.DexImport("ISO_B5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B5;
						/// <java-name>
						/// ISO_B6
						/// </java-name>
						[Dot42.DexImport("ISO_B6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B6;
						/// <java-name>
						/// ISO_B7
						/// </java-name>
						[Dot42.DexImport("ISO_B7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B7;
						/// <java-name>
						/// ISO_B8
						/// </java-name>
						[Dot42.DexImport("ISO_B8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B8;
						/// <java-name>
						/// ISO_B9
						/// </java-name>
						[Dot42.DexImport("ISO_B9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B9;
						/// <java-name>
						/// ISO_B10
						/// </java-name>
						[Dot42.DexImport("ISO_B10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_B10;
						/// <java-name>
						/// ISO_C0
						/// </java-name>
						[Dot42.DexImport("ISO_C0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C0;
						/// <java-name>
						/// ISO_C1
						/// </java-name>
						[Dot42.DexImport("ISO_C1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C1;
						/// <java-name>
						/// ISO_C2
						/// </java-name>
						[Dot42.DexImport("ISO_C2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C2;
						/// <java-name>
						/// ISO_C3
						/// </java-name>
						[Dot42.DexImport("ISO_C3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C3;
						/// <java-name>
						/// ISO_C4
						/// </java-name>
						[Dot42.DexImport("ISO_C4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C4;
						/// <java-name>
						/// ISO_C5
						/// </java-name>
						[Dot42.DexImport("ISO_C5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C5;
						/// <java-name>
						/// ISO_C6
						/// </java-name>
						[Dot42.DexImport("ISO_C6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C6;
						/// <java-name>
						/// ISO_C7
						/// </java-name>
						[Dot42.DexImport("ISO_C7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C7;
						/// <java-name>
						/// ISO_C8
						/// </java-name>
						[Dot42.DexImport("ISO_C8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C8;
						/// <java-name>
						/// ISO_C9
						/// </java-name>
						[Dot42.DexImport("ISO_C9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C9;
						/// <java-name>
						/// ISO_C10
						/// </java-name>
						[Dot42.DexImport("ISO_C10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ISO_C10;
						/// <java-name>
						/// NA_LETTER
						/// </java-name>
						[Dot42.DexImport("NA_LETTER", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_LETTER;
						/// <java-name>
						/// NA_GOVT_LETTER
						/// </java-name>
						[Dot42.DexImport("NA_GOVT_LETTER", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_GOVT_LETTER;
						/// <java-name>
						/// NA_LEGAL
						/// </java-name>
						[Dot42.DexImport("NA_LEGAL", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_LEGAL;
						/// <java-name>
						/// NA_JUNIOR_LEGAL
						/// </java-name>
						[Dot42.DexImport("NA_JUNIOR_LEGAL", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_JUNIOR_LEGAL;
						/// <java-name>
						/// NA_LEDGER
						/// </java-name>
						[Dot42.DexImport("NA_LEDGER", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_LEDGER;
						/// <java-name>
						/// NA_TABLOID
						/// </java-name>
						[Dot42.DexImport("NA_TABLOID", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_TABLOID;
						/// <java-name>
						/// NA_INDEX_3X5
						/// </java-name>
						[Dot42.DexImport("NA_INDEX_3X5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_INDEX_3X5;
						/// <java-name>
						/// NA_INDEX_4X6
						/// </java-name>
						[Dot42.DexImport("NA_INDEX_4X6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_INDEX_4X6;
						/// <java-name>
						/// NA_INDEX_5X8
						/// </java-name>
						[Dot42.DexImport("NA_INDEX_5X8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_INDEX_5X8;
						/// <java-name>
						/// NA_MONARCH
						/// </java-name>
						[Dot42.DexImport("NA_MONARCH", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_MONARCH;
						/// <java-name>
						/// NA_QUARTO
						/// </java-name>
						[Dot42.DexImport("NA_QUARTO", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_QUARTO;
						/// <java-name>
						/// NA_FOOLSCAP
						/// </java-name>
						[Dot42.DexImport("NA_FOOLSCAP", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize NA_FOOLSCAP;
						/// <java-name>
						/// ROC_8K
						/// </java-name>
						[Dot42.DexImport("ROC_8K", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ROC_8K;
						/// <java-name>
						/// ROC_16K
						/// </java-name>
						[Dot42.DexImport("ROC_16K", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize ROC_16K;
						/// <java-name>
						/// PRC_1
						/// </java-name>
						[Dot42.DexImport("PRC_1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_1;
						/// <java-name>
						/// PRC_2
						/// </java-name>
						[Dot42.DexImport("PRC_2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_2;
						/// <java-name>
						/// PRC_3
						/// </java-name>
						[Dot42.DexImport("PRC_3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_3;
						/// <java-name>
						/// PRC_4
						/// </java-name>
						[Dot42.DexImport("PRC_4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_4;
						/// <java-name>
						/// PRC_5
						/// </java-name>
						[Dot42.DexImport("PRC_5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_5;
						/// <java-name>
						/// PRC_6
						/// </java-name>
						[Dot42.DexImport("PRC_6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_6;
						/// <java-name>
						/// PRC_7
						/// </java-name>
						[Dot42.DexImport("PRC_7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_7;
						/// <java-name>
						/// PRC_8
						/// </java-name>
						[Dot42.DexImport("PRC_8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_8;
						/// <java-name>
						/// PRC_9
						/// </java-name>
						[Dot42.DexImport("PRC_9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_9;
						/// <java-name>
						/// PRC_10
						/// </java-name>
						[Dot42.DexImport("PRC_10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_10;
						/// <java-name>
						/// PRC_16K
						/// </java-name>
						[Dot42.DexImport("PRC_16K", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize PRC_16K;
						/// <java-name>
						/// OM_PA_KAI
						/// </java-name>
						[Dot42.DexImport("OM_PA_KAI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize OM_PA_KAI;
						/// <java-name>
						/// OM_DAI_PA_KAI
						/// </java-name>
						[Dot42.DexImport("OM_DAI_PA_KAI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize OM_DAI_PA_KAI;
						/// <java-name>
						/// OM_JUURO_KU_KAI
						/// </java-name>
						[Dot42.DexImport("OM_JUURO_KU_KAI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize OM_JUURO_KU_KAI;
						/// <java-name>
						/// JIS_B10
						/// </java-name>
						[Dot42.DexImport("JIS_B10", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B10;
						/// <java-name>
						/// JIS_B9
						/// </java-name>
						[Dot42.DexImport("JIS_B9", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B9;
						/// <java-name>
						/// JIS_B8
						/// </java-name>
						[Dot42.DexImport("JIS_B8", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B8;
						/// <java-name>
						/// JIS_B7
						/// </java-name>
						[Dot42.DexImport("JIS_B7", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B7;
						/// <java-name>
						/// JIS_B6
						/// </java-name>
						[Dot42.DexImport("JIS_B6", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B6;
						/// <java-name>
						/// JIS_B5
						/// </java-name>
						[Dot42.DexImport("JIS_B5", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B5;
						/// <java-name>
						/// JIS_B4
						/// </java-name>
						[Dot42.DexImport("JIS_B4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B4;
						/// <java-name>
						/// JIS_B3
						/// </java-name>
						[Dot42.DexImport("JIS_B3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B3;
						/// <java-name>
						/// JIS_B2
						/// </java-name>
						[Dot42.DexImport("JIS_B2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B2;
						/// <java-name>
						/// JIS_B1
						/// </java-name>
						[Dot42.DexImport("JIS_B1", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B1;
						/// <java-name>
						/// JIS_B0
						/// </java-name>
						[Dot42.DexImport("JIS_B0", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_B0;
						/// <java-name>
						/// JIS_EXEC
						/// </java-name>
						[Dot42.DexImport("JIS_EXEC", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JIS_EXEC;
						/// <java-name>
						/// JPN_CHOU4
						/// </java-name>
						[Dot42.DexImport("JPN_CHOU4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_CHOU4;
						/// <java-name>
						/// JPN_CHOU3
						/// </java-name>
						[Dot42.DexImport("JPN_CHOU3", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_CHOU3;
						/// <java-name>
						/// JPN_CHOU2
						/// </java-name>
						[Dot42.DexImport("JPN_CHOU2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_CHOU2;
						/// <java-name>
						/// JPN_HAGAKI
						/// </java-name>
						[Dot42.DexImport("JPN_HAGAKI", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_HAGAKI;
						/// <java-name>
						/// JPN_OUFUKU
						/// </java-name>
						[Dot42.DexImport("JPN_OUFUKU", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_OUFUKU;
						/// <java-name>
						/// JPN_KAHU
						/// </java-name>
						[Dot42.DexImport("JPN_KAHU", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_KAHU;
						/// <java-name>
						/// JPN_KAKU2
						/// </java-name>
						[Dot42.DexImport("JPN_KAKU2", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_KAKU2;
						/// <java-name>
						/// JPN_YOU4
						/// </java-name>
						[Dot42.DexImport("JPN_YOU4", "Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 25)]
						public static readonly MediaSize JPN_YOU4;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;II)V", AccessFlags = 1)]
						public MediaSize(string @string, string string1, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getId
						/// </java-name>
						[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						public string GetId() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getLabel
						/// </java-name>
						[Dot42.DexImport("getLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/String;", AccessFlags = 1)]
						public string GetLabel(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getWidthMils
						/// </java-name>
						[Dot42.DexImport("getWidthMils", "()I", AccessFlags = 1)]
						public int GetWidthMils() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getHeightMils
						/// </java-name>
						[Dot42.DexImport("getHeightMils", "()I", AccessFlags = 1)]
						public int GetHeightMils() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// isPortrait
						/// </java-name>
						[Dot42.DexImport("isPortrait", "()Z", AccessFlags = 1)]
						public bool IsPortrait() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// asPortrait
						/// </java-name>
						[Dot42.DexImport("asPortrait", "()Landroid/print/PrintAttributes$MediaSize;", AccessFlags = 1)]
						public MediaSize AsPortrait() /* MethodBuilder.Create */ 
						{
								return default(MediaSize);
						}

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
						public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// getId
						/// </java-name>
						public string Id
						{
						[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetId(); }
						}

						/// <java-name>
						/// getWidthMils
						/// </java-name>
						public int WidthMils
						{
						[Dot42.DexImport("getWidthMils", "()I", AccessFlags = 1)]
								get{ return GetWidthMils(); }
						}

						/// <java-name>
						/// getHeightMils
						/// </java-name>
						public int HeightMils
						{
						[Dot42.DexImport("getHeightMils", "()I", AccessFlags = 1)]
								get{ return GetHeightMils(); }
						}

				}

		}

		/// <java-name>
		/// android/print/PrintDocumentInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrintDocumentInfo", AccessFlags = 49)]
		public sealed partial class PrintDocumentInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PAGE_COUNT_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("PAGE_COUNT_UNKNOWN", "I", AccessFlags = 25)]
				public const int PAGE_COUNT_UNKNOWN = -1;
				/// <java-name>
				/// CONTENT_TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_UNKNOWN = -1;
				/// <java-name>
				/// CONTENT_TYPE_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_DOCUMENT", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_DOCUMENT = 0;
				/// <java-name>
				/// CONTENT_TYPE_PHOTO
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_PHOTO", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_PHOTO = 1;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PrintDocumentInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintDocumentInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPageCount
				/// </java-name>
				[Dot42.DexImport("getPageCount", "()I", AccessFlags = 1)]
				public int GetPageCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getContentType
				/// </java-name>
				[Dot42.DexImport("getContentType", "()I", AccessFlags = 1)]
				public int GetContentType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDataSize
				/// </java-name>
				[Dot42.DexImport("getDataSize", "()J", AccessFlags = 1)]
				public long GetDataSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getPageCount
				/// </java-name>
				public int PageCount
				{
				[Dot42.DexImport("getPageCount", "()I", AccessFlags = 1)]
						get{ return GetPageCount(); }
				}

				/// <java-name>
				/// getContentType
				/// </java-name>
				public int ContentType
				{
				[Dot42.DexImport("getContentType", "()I", AccessFlags = 1)]
						get{ return GetContentType(); }
				}

				/// <java-name>
				/// getDataSize
				/// </java-name>
				public long DataSize
				{
				[Dot42.DexImport("getDataSize", "()J", AccessFlags = 1)]
						get{ return GetDataSize(); }
				}

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

						/// <java-name>
						/// setPageCount
						/// </java-name>
						[Dot42.DexImport("setPageCount", "(I)Landroid/print/PrintDocumentInfo$Builder;", AccessFlags = 1)]
						public Builder SetPageCount(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setContentType
						/// </java-name>
						[Dot42.DexImport("setContentType", "(I)Landroid/print/PrintDocumentInfo$Builder;", AccessFlags = 1)]
						public Builder SetContentType(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

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

		/// <java-name>
		/// android/print/PrinterInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrinterInfo", AccessFlags = 49)]
		public sealed partial class PrinterInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATUS_IDLE
				/// </java-name>
				[Dot42.DexImport("STATUS_IDLE", "I", AccessFlags = 25)]
				public const int STATUS_IDLE = 1;
				/// <java-name>
				/// STATUS_BUSY
				/// </java-name>
				[Dot42.DexImport("STATUS_BUSY", "I", AccessFlags = 25)]
				public const int STATUS_BUSY = 2;
				/// <java-name>
				/// STATUS_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("STATUS_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int STATUS_UNAVAILABLE = 3;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PrinterInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrinterInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Landroid/print/PrinterId;", AccessFlags = 1)]
				public global::Android.Print.PrinterId GetId() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrinterId);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getStatus
				/// </java-name>
				[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
				public int GetStatus() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetDescription() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCapabilities
				/// </java-name>
				[Dot42.DexImport("getCapabilities", "()Landroid/print/PrinterCapabilitiesInfo;", AccessFlags = 1)]
				public global::Android.Print.PrinterCapabilitiesInfo GetCapabilities() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrinterCapabilitiesInfo);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getId
				/// </java-name>
				public global::Android.Print.PrinterId Id
				{
				[Dot42.DexImport("getId", "()Landroid/print/PrinterId;", AccessFlags = 1)]
						get{ return GetId(); }
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
				/// getStatus
				/// </java-name>
				public int Status
				{
				[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
						get{ return GetStatus(); }
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				public string Description
				{
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDescription(); }
				}

				/// <java-name>
				/// getCapabilities
				/// </java-name>
				public global::Android.Print.PrinterCapabilitiesInfo Capabilities
				{
				[Dot42.DexImport("getCapabilities", "()Landroid/print/PrinterCapabilitiesInfo;", AccessFlags = 1)]
						get{ return GetCapabilities(); }
				}

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

						/// <java-name>
						/// setStatus
						/// </java-name>
						[Dot42.DexImport("setStatus", "(I)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetStatus(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setName
						/// </java-name>
						[Dot42.DexImport("setName", "(Ljava/lang/String;)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetName(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setDescription
						/// </java-name>
						[Dot42.DexImport("setDescription", "(Ljava/lang/String;)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetDescription(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setCapabilities
						/// </java-name>
						[Dot42.DexImport("setCapabilities", "(Landroid/print/PrinterCapabilitiesInfo;)Landroid/print/PrinterInfo$Builder;", AccessFlags = 1)]
						public Builder SetCapabilities(global::Android.Print.PrinterCapabilitiesInfo printerCapabilitiesInfo) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

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

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
				public global::Android.Print.PrintJobId GetId() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintJobId);
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				[Dot42.DexImport("getInfo", "()Landroid/print/PrintJobInfo;", AccessFlags = 1)]
				public global::Android.Print.PrintJobInfo GetInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintJobInfo);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restart
				/// </java-name>
				[Dot42.DexImport("restart", "()V", AccessFlags = 1)]
				public void Restart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isQueued
				/// </java-name>
				[Dot42.DexImport("isQueued", "()Z", AccessFlags = 1)]
				public bool IsQueued() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isStarted
				/// </java-name>
				[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
				public bool IsStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBlocked
				/// </java-name>
				[Dot42.DexImport("isBlocked", "()Z", AccessFlags = 1)]
				public bool IsBlocked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isCompleted
				/// </java-name>
				[Dot42.DexImport("isCompleted", "()Z", AccessFlags = 1)]
				public bool IsCompleted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFailed
				/// </java-name>
				[Dot42.DexImport("isFailed", "()Z", AccessFlags = 1)]
				public bool IsFailed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isCancelled
				/// </java-name>
				[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1)]
				public bool IsCancelled() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// getId
				/// </java-name>
				public global::Android.Print.PrintJobId Id
				{
				[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				public global::Android.Print.PrintJobInfo Info
				{
				[Dot42.DexImport("getInfo", "()Landroid/print/PrintJobInfo;", AccessFlags = 1)]
						get{ return GetInfo(); }
				}

		}

		/// <java-name>
		/// android/print/PrintDocumentAdapter
		/// </java-name>
		[Dot42.DexImport("android/print/PrintDocumentAdapter", AccessFlags = 1057)]
		public abstract partial class PrintDocumentAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EXTRA_PRINT_PREVIEW
				/// </java-name>
				[Dot42.DexImport("EXTRA_PRINT_PREVIEW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PRINT_PREVIEW = "EXTRA_PRINT_PREVIEW";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PrintDocumentAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(Landroid/print/PrintAttributes;Landroid/print/PrintAttributes;Landroid/os/Cancel" +
    "lationSignal;Landroid/print/PrintDocumentAdapter$LayoutResultCallback;Landroid/o" +
    "s/Bundle;)V", AccessFlags = 1025)]
				public abstract void OnLayout(global::Android.Print.PrintAttributes printAttributes, global::Android.Print.PrintAttributes printAttributes1, global::Android.Os.CancellationSignal cancellationSignal, global::Android.Print.PrintDocumentAdapter.LayoutResultCallback layoutResultCallback, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onWrite
				/// </java-name>
				[Dot42.DexImport("onWrite", "([Landroid/print/PageRange;Landroid/os/ParcelFileDescriptor;Landroid/os/Cancellat" +
    "ionSignal;Landroid/print/PrintDocumentAdapter$WriteResultCallback;)V", AccessFlags = 1025)]
				public abstract void OnWrite(global::Android.Print.PageRange[] pageRange, global::Android.Os.ParcelFileDescriptor parcelFileDescriptor, global::Android.Os.CancellationSignal cancellationSignal, global::Android.Print.PrintDocumentAdapter.WriteResultCallback writeResultCallback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onFinish
				/// </java-name>
				[Dot42.DexImport("onFinish", "()V", AccessFlags = 1)]
				public virtual void OnFinish() /* MethodBuilder.Create */ 
				{
				}

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

						/// <java-name>
						/// onLayoutFinished
						/// </java-name>
						[Dot42.DexImport("onLayoutFinished", "(Landroid/print/PrintDocumentInfo;Z)V", AccessFlags = 1)]
						public virtual void OnLayoutFinished(global::Android.Print.PrintDocumentInfo printDocumentInfo, bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onLayoutFailed
						/// </java-name>
						[Dot42.DexImport("onLayoutFailed", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						public virtual void OnLayoutFailed(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onLayoutCancelled
						/// </java-name>
						[Dot42.DexImport("onLayoutCancelled", "()V", AccessFlags = 1)]
						public virtual void OnLayoutCancelled() /* MethodBuilder.Create */ 
						{
						}

				}

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

						/// <java-name>
						/// onWriteFinished
						/// </java-name>
						[Dot42.DexImport("onWriteFinished", "([Landroid/print/PageRange;)V", AccessFlags = 1)]
						public virtual void OnWriteFinished(global::Android.Print.PageRange[] pageRange) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onWriteFailed
						/// </java-name>
						[Dot42.DexImport("onWriteFailed", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						public virtual void OnWriteFailed(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onWriteCancelled
						/// </java-name>
						[Dot42.DexImport("onWriteCancelled", "()V", AccessFlags = 1)]
						public virtual void OnWriteCancelled() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/print/PrinterCapabilitiesInfo
		/// </java-name>
		[Dot42.DexImport("android/print/PrinterCapabilitiesInfo", AccessFlags = 49)]
		public sealed partial class PrinterCapabilitiesInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PrinterCapabilitiesInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrinterCapabilitiesInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMediaSizes
				/// </java-name>
				[Dot42.DexImport("getMediaSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintAttributes$MediaSize;>;")]
				public global::Java.Util.IList<global::Android.Print.PrintAttributes.MediaSize> GetMediaSizes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Print.PrintAttributes.MediaSize>);
				}

				/// <java-name>
				/// getResolutions
				/// </java-name>
				[Dot42.DexImport("getResolutions", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintAttributes$Resolution;>;")]
				public global::Java.Util.IList<global::Android.Print.PrintAttributes.Resolution> GetResolutions() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Print.PrintAttributes.Resolution>);
				}

				/// <java-name>
				/// getMinMargins
				/// </java-name>
				[Dot42.DexImport("getMinMargins", "()Landroid/print/PrintAttributes$Margins;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes.Margins GetMinMargins() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes.Margins);
				}

				/// <java-name>
				/// getColorModes
				/// </java-name>
				[Dot42.DexImport("getColorModes", "()I", AccessFlags = 1)]
				public int GetColorModes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDefaults
				/// </java-name>
				[Dot42.DexImport("getDefaults", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
				public global::Android.Print.PrintAttributes GetDefaults() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintAttributes);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getMediaSizes
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrintAttributes.MediaSize> MediaSizes
				{
				[Dot42.DexImport("getMediaSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintAttributes$MediaSize;>;")]
						get{ return GetMediaSizes(); }
				}

				/// <java-name>
				/// getResolutions
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrintAttributes.Resolution> Resolutions
				{
				[Dot42.DexImport("getResolutions", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/print/PrintAttributes$Resolution;>;")]
						get{ return GetResolutions(); }
				}

				/// <java-name>
				/// getMinMargins
				/// </java-name>
				public global::Android.Print.PrintAttributes.Margins MinMargins
				{
				[Dot42.DexImport("getMinMargins", "()Landroid/print/PrintAttributes$Margins;", AccessFlags = 1)]
						get{ return GetMinMargins(); }
				}

				/// <java-name>
				/// getColorModes
				/// </java-name>
				public int ColorModes
				{
				[Dot42.DexImport("getColorModes", "()I", AccessFlags = 1)]
						get{ return GetColorModes(); }
				}

				/// <java-name>
				/// getDefaults
				/// </java-name>
				public global::Android.Print.PrintAttributes Defaults
				{
				[Dot42.DexImport("getDefaults", "()Landroid/print/PrintAttributes;", AccessFlags = 1)]
						get{ return GetDefaults(); }
				}

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

						/// <java-name>
						/// addMediaSize
						/// </java-name>
						[Dot42.DexImport("addMediaSize", "(Landroid/print/PrintAttributes$MediaSize;Z)Landroid/print/PrinterCapabilitiesInf" +
    "o$Builder;", AccessFlags = 1)]
						public Builder AddMediaSize(global::Android.Print.PrintAttributes.MediaSize mediaSize, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addResolution
						/// </java-name>
						[Dot42.DexImport("addResolution", "(Landroid/print/PrintAttributes$Resolution;Z)Landroid/print/PrinterCapabilitiesIn" +
    "fo$Builder;", AccessFlags = 1)]
						public Builder AddResolution(global::Android.Print.PrintAttributes.Resolution resolution, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMinMargins
						/// </java-name>
						[Dot42.DexImport("setMinMargins", "(Landroid/print/PrintAttributes$Margins;)Landroid/print/PrinterCapabilitiesInfo$B" +
    "uilder;", AccessFlags = 1)]
						public Builder SetMinMargins(global::Android.Print.PrintAttributes.Margins margins) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setColorModes
						/// </java-name>
						[Dot42.DexImport("setColorModes", "(II)Landroid/print/PrinterCapabilitiesInfo$Builder;", AccessFlags = 1)]
						public Builder SetColorModes(int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

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

		/// <java-name>
		/// android/print/PrinterId
		/// </java-name>
		[Dot42.DexImport("android/print/PrinterId", AccessFlags = 49)]
		public sealed partial class PrinterId : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Print.PrinterId> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrinterId() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalId
				/// </java-name>
				[Dot42.DexImport("getLocalId", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetLocalId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getLocalId
				/// </java-name>
				public string LocalId
				{
				[Dot42.DexImport("getLocalId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocalId(); }
				}

		}

}


