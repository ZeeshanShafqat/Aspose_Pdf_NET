//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Forms;

namespace CSharp.AsposePdf.Forms
{
    public class FillFormField
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            //open document
            Document pdfDocument = new Document(dataDir + "FillFormField.pdf");

            //get a field
            TextBoxField textBoxField = pdfDocument.Form["textbox1"] as TextBoxField;
            
            //modify field value
            textBoxField.Value = "Value to be filled in the field";
            
            //save updated document
            pdfDocument.Save(dataDir + "FillFormField_out.pdf");

        }
    }
}