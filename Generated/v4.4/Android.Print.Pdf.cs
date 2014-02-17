// Copyright (C) 2014 dot42
//
// Original filename: Android.Print.Pdf.cs
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
namespace Android.Print.Pdf
{
		/// <java-name>
		/// android/print/pdf/PrintedPdfDocument
		/// </java-name>
		[Dot42.DexImport("android/print/pdf/PrintedPdfDocument", AccessFlags = 33)]
		public partial class PrintedPdfDocument : global::Android.Graphics.Pdf.PdfDocument
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/print/PrintAttributes;)V", AccessFlags = 1)]
				public PrintedPdfDocument(global::Android.Content.Context context, global::Android.Print.PrintAttributes printAttributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPage
				/// </java-name>
				[Dot42.DexImport("startPage", "(I)Landroid/graphics/pdf/PdfDocument$Page;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Pdf.PdfDocument.Page StartPage(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Pdf.PdfDocument.Page);
				}

				/// <java-name>
				/// getPageWidth
				/// </java-name>
				[Dot42.DexImport("getPageWidth", "()I", AccessFlags = 1)]
				public virtual int GetPageWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPageHeight
				/// </java-name>
				[Dot42.DexImport("getPageHeight", "()I", AccessFlags = 1)]
				public virtual int GetPageHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPageContentRect
				/// </java-name>
				[Dot42.DexImport("getPageContentRect", "()Landroid/graphics/Rect;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Rect GetPageContentRect() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintedPdfDocument() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
				/// getPageContentRect
				/// </java-name>
				public global::Android.Graphics.Rect PageContentRect
				{
				[Dot42.DexImport("getPageContentRect", "()Landroid/graphics/Rect;", AccessFlags = 1)]
						get{ return GetPageContentRect(); }
				}

		}

}


