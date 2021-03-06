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
Imports Aspose.Pdf.Devices

Namespace VisualBasic.AsposePdf.Images
    Public Class PageToTIFF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            'Open document
            Dim pdfDocument As New Document(dataDir & "PageToTIFF.pdf")

            'Create Resolution object
            Dim resolution As New Resolution(300)

            'Create TiffSettings object
            Dim tiffSettings As New TiffSettings()
            tiffSettings.Compression = CompressionType.None
            tiffSettings.Depth = ColorDepth.Default
            tiffSettings.Shape = ShapeType.Landscape
            tiffSettings.SkipBlankPages = False

            'Create TIFF device
            Dim tiffDevice As New TiffDevice(resolution, tiffSettings)


            'Convert a particular page and save the image to stream
            tiffDevice.Process(pdfDocument, 1, 1, dataDir & "output.tif")

        End Sub
    End Class
End Namespace