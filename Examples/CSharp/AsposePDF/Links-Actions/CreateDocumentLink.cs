//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Annotations;
using Aspose.Pdf.InteractiveFeatures;

namespace CSharp.AsposePdf.LinksActions
{
    public class CreateDocumentLink
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();


            //open document
            Document document = new Document(dataDir+ "CreateDocumentLink.pdf");

            //create link
            Page page = document.Pages[1];
            LinkAnnotation link = new LinkAnnotation(page, new Aspose.Pdf.Rectangle(100, 100, 300, 300));
            link.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);
            link.Action = new GoToRemoteAction(dataDir + "blank.pdf", 1);
            page.Annotations.Add(link);

            //save updated document
            document.Save(dataDir + "CreateDocumentLink_out.pdf");
            
        }
    }
}