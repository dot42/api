#pragma warning disable 1717
namespace Android.Graphics.Pdf
{
		/// <summary>
		///  <para>This class enables generating a PDF document from native Android content. You open a new document and then for every page you want to add you start a page, write content to the page, and finish the page. After you are done with all pages, you write the document to an output stream and close the document. After a document is closed you should not use it anymore. Note that pages are created one by one, i.e. you can have only a single page to which you are writing at any given time. This class is not thread safe. </para> <para>A typical use of the APIs looks like this: </para> <para> <pre>
		/// // create a new document
		/// PdfDocument document = new PdfDocument();</pre></para> <para> <pre>// crate a page description
		/// PageInfo pageInfo = new PageInfo.Builder(new Rect(0, 0, 100, 100), 1).create();</pre></para> <para> <pre>// start a page
		/// Page page = document.startPage(pageInfo);</pre></para> <para> <pre>// draw something on the page
		/// View content = getContentView();
		/// content.draw(page.getCanvas());</pre></para> <para> <pre>// finish the page
		/// document.finishPage(page);
		/// . . .
		/// // add more pages
		/// . . .
		/// // write the document content
		/// document.writeTo(getOutputStream());</pre></para> <para> <pre>//close the document
		/// document.close();
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/pdf/PdfDocument
		/// </java-name>
		[Dot42.DexImport("android/graphics/pdf/PdfDocument", AccessFlags = 33)]
		public partial class PdfDocument
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PdfDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts a page using the provided PageInfo. After the page is created you can draw arbitrary content on the page's canvas which you can get by calling Page#getCanvas(). After you are done drawing the content you should finish the page by calling finishPage(Page). After the page is finished you should no longer access the page or its canvas. </para> <para> <b>Note:</b> Do not call this method after close(). Also do not call this method if the last page returned by this method is not finished by calling finishPage(Page). </para> <para> <para>finishPage(Page) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A blank page.</para>
				/// </returns>
				/// <java-name>
				/// startPage
				/// </java-name>
				[Dot42.DexImport("startPage", "(Landroid/graphics/pdf/PdfDocument$PageInfo;)Landroid/graphics/pdf/PdfDocument$Pa" +
    "ge;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Pdf.PdfDocument.Page StartPage(global::Android.Graphics.Pdf.PdfDocument.PageInfo pageInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Pdf.PdfDocument.Page);
				}

				/// <summary>
				///  <para>Finishes a started page. You should always finish the last started page. </para> <para> <b>Note:</b> Do not call this method after close(). You should not finish the same page more than once. </para> <para> <para>startPage(PageInfo) </para></para>        
				/// </summary>
				/// <java-name>
				/// finishPage
				/// </java-name>
				[Dot42.DexImport("finishPage", "(Landroid/graphics/pdf/PdfDocument$Page;)V", AccessFlags = 1)]
				public virtual void FinishPage(global::Android.Graphics.Pdf.PdfDocument.Page page) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the document to an output stream. You can call this method multiple times. </para> <para> <b>Note:</b> Do not call this method after close(). Also do not call this method if a page returned by PageInfo) is not finished by calling finishPage(Page). </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void WriteTo(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this document. This method should be called after you are done working with the document. After this call the document is considered closed and none of its methods should be called. </para> <para> <b>Note:</b> Do not call this method if the page returned by startPage(PageInfo) is not finished by calling finishPage(Page). </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Gets the pages of the document.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The pages or an empty list. </para>
				/// </returns>
				/// <java-name>
				/// getPages
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Graphics.Pdf.PdfDocument.PageInfo> Pages
				{
						[Dot42.DexImport("getPages", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/graphics/pdf/PdfDocument$PageInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Graphics.Pdf.PdfDocument.PageInfo>); }
				}

				/// <summary>
				///  <para>This class represents a PDF document page. It has associated a canvas on which you can draw content and is acquired by a call to getCanvas(). It also has associated a PageInfo instance that describes its attributes. Also a page has </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Gets the Canvas of the page.</para> <para> <b>Note: </b> There are some draw operations that are not yet supported by the canvas returned by this method. More specifically:  <ul> <li> <para>Inverse path clipping performed via android.graphics.Region.Op) Canvas.clipPath(android.graphics.Path, android.graphics.Region.Op) for Region.Op#REVERSE_DIFFERENCE operations. </para></li> <li> <para>int, float[], int, float[], int, int[], int, short[], int, int, android.graphics.Paint) Canvas.drawVertices( android.graphics.Canvas.VertexMode, int, float[], int, float[], int, int[], int, short[], int, int, android.graphics.Paint) </para></li> <li> <para>Color filters set via android.graphics.ColorFilter) </para></li> <li> <para>Mask filters set via android.graphics.MaskFilter) </para></li> <li> <para>Some XFER modes such as PorterDuff.Mode SRC, PorterDuff.DST_ATOP, PorterDuff.XOR, PorterDuff.ADD </para></li></ul></para> <para> <para>PdfDocument::finishPage(Page) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>The canvas if the page is not finished, null otherwise.</para>
						/// </returns>
						/// <java-name>
						/// getCanvas
						/// </java-name>
						public global::Android.Graphics.Canvas Canvas
						{
								[Dot42.DexImport("getCanvas", "()Landroid/graphics/Canvas;", AccessFlags = 1)]
								get{ return default(global::Android.Graphics.Canvas); }
						}

						/// <summary>
						///  <para>Gets the PageInfo with meta-data for the page.</para> <para> <para>PdfDocument::finishPage(Page) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>The page info.</para>
						/// </returns>
						/// <java-name>
						/// getInfo
						/// </java-name>
						public global::Android.Graphics.Pdf.PdfDocument.PageInfo Info
						{
								[Dot42.DexImport("getInfo", "()Landroid/graphics/pdf/PdfDocument$PageInfo;", AccessFlags = 1)]
								get{ return default(global::Android.Graphics.Pdf.PdfDocument.PageInfo); }
						}

				}

				/// <summary>
				///  <para>This class represents meta-data that describes a PDF Page. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Gets the page width in PostScript points (1/72th of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The page width. </para>
						/// </returns>
						/// <java-name>
						/// getPageWidth
						/// </java-name>
						public int PageWidth
						{
								[Dot42.DexImport("getPageWidth", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Gets the page height in PostScript points (1/72th of an inch).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The page height. </para>
						/// </returns>
						/// <java-name>
						/// getPageHeight
						/// </java-name>
						public int PageHeight
						{
								[Dot42.DexImport("getPageHeight", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Get the content rectangle in PostScript points (1/72th of an inch). This is the area that contains the page content and is relative to the page top left.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The content rectangle. </para>
						/// </returns>
						/// <java-name>
						/// getContentRect
						/// </java-name>
						public global::Android.Graphics.Rect ContentRect
						{
								[Dot42.DexImport("getContentRect", "()Landroid/graphics/Rect;", AccessFlags = 1)]
								get{ return default(global::Android.Graphics.Rect); }
						}

						/// <summary>
						///  <para>Gets the page number.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The page number. </para>
						/// </returns>
						/// <java-name>
						/// getPageNumber
						/// </java-name>
						public int PageNumber
						{
								[Dot42.DexImport("getPageNumber", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Builder for creating a PageInfo. </para>    
						/// </summary>
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

								/// <summary>
								///  <para>Sets the content rectangle in PostScript point (1/72th of an inch). This is the area that contains the page content and is relative to the page top left.</para> <para></para>        
								/// </summary>
								/// <java-name>
								/// setContentRect
								/// </java-name>
								[Dot42.DexImport("setContentRect", "(Landroid/graphics/Rect;)Landroid/graphics/pdf/PdfDocument$PageInfo$Builder;", AccessFlags = 1)]
								public Builder SetContentRect(global::Android.Graphics.Rect contentRect) /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Creates a new PageInfo.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>The new instance. </para>
								/// </returns>
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

