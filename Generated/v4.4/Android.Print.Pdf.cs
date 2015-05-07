#pragma warning disable 1717
namespace Android.Print.Pdf
{
		/// <summary>
		///  <para>This class is a helper for creating a PDF file for given print attributes. It is useful for implementing printing via the native Android graphics APIs. </para> <para>This class computes the page width, page height, and content rectangle from the provided print attributes and these precomputed values can be accessed via getPageWidth(), getPageHeight(), and getPageContentRect(), respectively. The startPage(int) methods creates pages whose PageInfo is initialized with the precomputed values for width, height, and content rectangle. </para> <para>A typical use of the APIs looks like this: </para> <para> <pre>
		/// // open a new document
		/// PrintedPdfDocument document = new PrintedPdfDocument(context,
		///         printAttributes);</pre></para> <para> <pre>// start a page
		/// Page page = document.startPage(0);</pre></para> <para> <pre>// draw something on the page
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
		/// android/print/pdf/PrintedPdfDocument
		/// </java-name>
		[Dot42.DexImport("android/print/pdf/PrintedPdfDocument", AccessFlags = 33)]
		public partial class PrintedPdfDocument : global::Android.Graphics.Pdf.PdfDocument
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new document. </para> <para> <b>Note:</b> You must close the document after you are done by calling close(). </para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/print/PrintAttributes;)V", AccessFlags = 1)]
				public PrintedPdfDocument(global::Android.Content.Context context, global::Android.Print.PrintAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts a new page. The page is created using width, height and content rectangle computed from the print attributes passed in the constructor and the given page number to create an appropriate PageInfo. </para> <para>After the page is created you can draw arbitrary content on the page's canvas which you can get by calling Page.getCanvas(). After you are done drawing the content you should finish the page by calling finishPage(Page). After the page is finished you should no longer access the page or its canvas. </para> <para> <b>Note:</b> Do not call this method after close(). Also do not call this method if the last page returned by this method is not finished by calling finishPage(Page). </para> <para> <para>finishPage(Page) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A blank page.</para>
				/// </returns>
				/// <java-name>
				/// startPage
				/// </java-name>
				[Dot42.DexImport("startPage", "(I)Landroid/graphics/pdf/PdfDocument$Page;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Pdf.PdfDocument.Page StartPage(int pageNumber) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Pdf.PdfDocument.Page);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintedPdfDocument() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the page width.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The page width in PostScript points (1/72th of an inch). </para>
				/// </returns>
				/// <java-name>
				/// getPageWidth
				/// </java-name>
				public virtual int PageWidth
				{
						[Dot42.DexImport("getPageWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the page height.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The page height in PostScript points (1/72th of an inch). </para>
				/// </returns>
				/// <java-name>
				/// getPageHeight
				/// </java-name>
				public virtual int PageHeight
				{
						[Dot42.DexImport("getPageHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the content rectangle. This is the area of the page that contains printed data and is relative to the page top left.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The content rectangle. </para>
				/// </returns>
				/// <java-name>
				/// getPageContentRect
				/// </java-name>
				public virtual global::Android.Graphics.Rect PageContentRect
				{
						[Dot42.DexImport("getPageContentRect", "()Landroid/graphics/Rect;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Rect); }
				}

		}

}

