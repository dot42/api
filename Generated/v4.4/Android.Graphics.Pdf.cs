// Copyright (C) 2014 dot42
//
// Original filename: Android.Graphics.Pdf.cs
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
namespace Android.Graphics.Pdf
{
		/// <java-name>
		/// android/graphics/pdf/PdfDocument
		/// </java-name>
		[Dot42.DexImport("android/graphics/pdf/PdfDocument", AccessFlags = 33)]
		public partial class PdfDocument
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PdfDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPage
				/// </java-name>
				[Dot42.DexImport("startPage", "(Landroid/graphics/pdf/PdfDocument$PageInfo;)Landroid/graphics/pdf/PdfDocument$Pa" +
    "ge;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Pdf.PdfDocument.Page StartPage(global::Android.Graphics.Pdf.PdfDocument.PageInfo pageInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Pdf.PdfDocument.Page);
				}

				/// <java-name>
				/// finishPage
				/// </java-name>
				[Dot42.DexImport("finishPage", "(Landroid/graphics/pdf/PdfDocument$Page;)V", AccessFlags = 1)]
				public virtual void FinishPage(global::Android.Graphics.Pdf.PdfDocument.Page page) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void WriteTo(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPages
				/// </java-name>
				[Dot42.DexImport("getPages", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/graphics/pdf/PdfDocument$PageInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.Graphics.Pdf.PdfDocument.PageInfo> GetPages() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Graphics.Pdf.PdfDocument.PageInfo>);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~PdfDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPages
				/// </java-name>
				public global::Java.Util.IList<global::Android.Graphics.Pdf.PdfDocument.PageInfo> Pages
				{
				[Dot42.DexImport("getPages", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/graphics/pdf/PdfDocument$PageInfo;>;")]
						get{ return GetPages(); }
				}

				/// <java-name>
				/// android/graphics/pdf/PdfDocument$Page
				/// </java-name>
				[Dot42.DexImport("android/graphics/pdf/PdfDocument$Page", AccessFlags = 25)]
				public sealed partial class Page
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Page() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getCanvas
						/// </java-name>
						[Dot42.DexImport("getCanvas", "()Landroid/graphics/Canvas;", AccessFlags = 1)]
						public global::Android.Graphics.Canvas GetCanvas() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Canvas);
						}

						/// <java-name>
						/// getInfo
						/// </java-name>
						[Dot42.DexImport("getInfo", "()Landroid/graphics/pdf/PdfDocument$PageInfo;", AccessFlags = 1)]
						public global::Android.Graphics.Pdf.PdfDocument.PageInfo GetInfo() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Pdf.PdfDocument.PageInfo);
						}

						/// <java-name>
						/// getCanvas
						/// </java-name>
						public global::Android.Graphics.Canvas Canvas
						{
						[Dot42.DexImport("getCanvas", "()Landroid/graphics/Canvas;", AccessFlags = 1)]
								get{ return GetCanvas(); }
						}

						/// <java-name>
						/// getInfo
						/// </java-name>
						public global::Android.Graphics.Pdf.PdfDocument.PageInfo Info
						{
						[Dot42.DexImport("getInfo", "()Landroid/graphics/pdf/PdfDocument$PageInfo;", AccessFlags = 1)]
								get{ return GetInfo(); }
						}

				}

				/// <java-name>
				/// android/graphics/pdf/PdfDocument$PageInfo
				/// </java-name>
				[Dot42.DexImport("android/graphics/pdf/PdfDocument$PageInfo", AccessFlags = 25)]
				public sealed partial class PageInfo
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal PageInfo() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getPageWidth
						/// </java-name>
						[Dot42.DexImport("getPageWidth", "()I", AccessFlags = 1)]
						public int GetPageWidth() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getPageHeight
						/// </java-name>
						[Dot42.DexImport("getPageHeight", "()I", AccessFlags = 1)]
						public int GetPageHeight() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getContentRect
						/// </java-name>
						[Dot42.DexImport("getContentRect", "()Landroid/graphics/Rect;", AccessFlags = 1)]
						public global::Android.Graphics.Rect GetContentRect() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Rect);
						}

						/// <java-name>
						/// getPageNumber
						/// </java-name>
						[Dot42.DexImport("getPageNumber", "()I", AccessFlags = 1)]
						public int GetPageNumber() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getPageWidth
						/// </java-name>
						public int PageWidth
						{
						[Dot42.DexImport("getPageWidth", "()I", AccessFlags = 1)]
								get{ return GetPageWidth(); }
						}

						/// <java-name>
						/// getPageHeight
						/// </java-name>
						public int PageHeight
						{
						[Dot42.DexImport("getPageHeight", "()I", AccessFlags = 1)]
								get{ return GetPageHeight(); }
						}

						/// <java-name>
						/// getContentRect
						/// </java-name>
						public global::Android.Graphics.Rect ContentRect
						{
						[Dot42.DexImport("getContentRect", "()Landroid/graphics/Rect;", AccessFlags = 1)]
								get{ return GetContentRect(); }
						}

						/// <java-name>
						/// getPageNumber
						/// </java-name>
						public int PageNumber
						{
						[Dot42.DexImport("getPageNumber", "()I", AccessFlags = 1)]
								get{ return GetPageNumber(); }
						}

						/// <java-name>
						/// android/graphics/pdf/PdfDocument$PageInfo$Builder
						/// </java-name>
						[Dot42.DexImport("android/graphics/pdf/PdfDocument$PageInfo$Builder", AccessFlags = 25)]
						public sealed partial class Builder
 /* scope: __dot42__ */ 
						{
								[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
								public Builder(int int32, int int321, int int322) /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// setContentRect
								/// </java-name>
								[Dot42.DexImport("setContentRect", "(Landroid/graphics/Rect;)Landroid/graphics/pdf/PdfDocument$PageInfo$Builder;", AccessFlags = 1)]
								public Builder SetContentRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// create
								/// </java-name>
								[Dot42.DexImport("create", "()Landroid/graphics/pdf/PdfDocument$PageInfo;", AccessFlags = 1)]
								public global::Android.Graphics.Pdf.PdfDocument.PageInfo Create() /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Pdf.PdfDocument.PageInfo);
								}

								[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
								internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
								{
								}

						}

				}

		}

}


