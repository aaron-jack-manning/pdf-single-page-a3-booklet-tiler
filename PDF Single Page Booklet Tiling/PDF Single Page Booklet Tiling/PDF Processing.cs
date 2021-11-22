using System;
using System.IO;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;

namespace PDF_Single_Page_Booklet_Tiling
{
    class PDF_Processing
    {
        public static void TilePDF(string destinationPath, string sourcePath)
        {
            FileInfo file = new FileInfo(destinationPath);
            file.Directory.Create();

            new PDF_Processing().ManipulatePdf(destinationPath, sourcePath);
        }

        private void ManipulatePdf(string destinationPath, string sourcePath)
        {
            PdfDocument sourceDocument = new PdfDocument(new PdfReader(sourcePath));
            PdfDocument destinationDocument = new PdfDocument(new PdfWriter(destinationPath));

            int pageCount = sourceDocument.GetNumberOfPages();

            if (pageCount % 2 != 0)
            {
                throw new ArgumentException("Due to the way tiling is done, the source PDF must have an even number of pages.");
            }

            for (int i = 1; i < pageCount; i += 2)
            {
                PageSize destinationPageSize = HalfPageSize(sourceDocument.GetPage(i).GetPageSizeWithRotation());
                destinationDocument.SetDefaultPageSize(destinationPageSize);

                PdfFormXObject page1 = sourceDocument.GetPage(i).CopyAsFormXObject(destinationDocument);
                PdfFormXObject page2 = sourceDocument.GetPage(i + 1).CopyAsFormXObject(destinationDocument);

                PdfCanvas canvas;

                canvas = new PdfCanvas(destinationDocument.AddNewPage());
                canvas.AddXObjectAt(page1, -destinationPageSize.GetWidth(), 0);

                canvas = new PdfCanvas(destinationDocument.AddNewPage());
                canvas.AddXObjectAt(page2, 0, 0);

                canvas = new PdfCanvas(destinationDocument.AddNewPage());
                canvas.AddXObjectAt(page2, -destinationPageSize.GetWidth(), 0);

                canvas = new PdfCanvas(destinationDocument.AddNewPage());
                canvas.AddXObjectAt(page1, 0, 0);
            }

            destinationDocument.Close();
            sourceDocument.Close();
        }

        private static PageSize HalfPageSize(Rectangle pageSize)
        {
            float width = pageSize.GetWidth();
            float height = pageSize.GetHeight();

            return new PageSize(width / 2, height);
        }
    }
}
