//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace CSharp.AsposePDFFacades.Images
{
    public class ExtractImages
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();

            //open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractImages.pdf");

            //extract all the images
            pdfExtractor.ExtractImage();

            //get all the extracted images
            while (pdfExtractor.HasNextImage())
                pdfExtractor.GetNextImage(dataDir+ DateTime.Now.Ticks.ToString() + ".jpg");
 
            
            
        }
    }
}