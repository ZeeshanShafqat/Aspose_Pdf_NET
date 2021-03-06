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
using System.Drawing;
using System.Drawing.Imaging;

namespace CSharp.AsposePDFFacades.Images
{
    public class ExtractImageExtractionMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            //open input PDF
            PdfExtractor extractor = new PdfExtractor();
            extractor.BindPdf(dataDir+ "ExtractImageExtractionMode.pdf");

            //Specify Image Extraction Mode
            extractor.ExtractImageMode = ExtractImageMode.DefinedInResources;

            //Extract Images based on Image Extraction Mode
            extractor.ExtractImage();

            //Get all the extracted images
            while (extractor.HasNextImage())
            {
                extractor.GetNextImage(dataDir+ DateTime.Now.Ticks.ToString() + ".png" , System.Drawing.Imaging.ImageFormat.Png);
            }
 
            
            
        }
    }
}