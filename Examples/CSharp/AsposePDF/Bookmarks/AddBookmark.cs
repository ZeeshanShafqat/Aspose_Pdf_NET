//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Bookmarks
{
    public class AddBookmark
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            //open document
            Document pdfDocument = new Document(dataDir + "AddBookmark.pdf");

            //create a bookmark object
            OutlineItemCollection pdfOutline = new OutlineItemCollection(pdfDocument.Outlines);
            pdfOutline.Title = "Test Outline";
            pdfOutline.Italic = true;
            pdfOutline.Bold = true;

            //set the destination page number
            pdfOutline.Action = new Aspose.Pdf.InteractiveFeatures.GoToAction(pdfDocument.Pages[1]);

            //add bookmark in the document's outline collection.
            pdfDocument.Outlines.Add(pdfOutline);

            //save output
            pdfDocument.Save(dataDir + "AddBookmark_out.pdf");
        }
    }
}