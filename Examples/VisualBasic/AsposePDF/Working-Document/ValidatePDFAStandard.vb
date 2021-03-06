'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf

Namespace VisualBasic.AsposePdf.WorkingDocuments
    Public Class ValidatePDFAStandard
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            'open document
            Dim pdfDocument As New Document(dataDir & "ValidatePDFAStandard.pdf")

            'validate PDF for PDF/A-1a
            pdfDocument.Validate(dataDir & "validation-result-A1A.xml", PdfFormat.PDF_A_1A)

        End Sub
    End Class
End Namespace