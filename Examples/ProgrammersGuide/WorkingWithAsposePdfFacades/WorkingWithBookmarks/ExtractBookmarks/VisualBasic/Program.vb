'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System

Namespace ExtractBookmarksExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create PdfBookmarkEditor
			Dim bookmarkEditor As New PdfBookmarkEditor()
			'open PDF file
			bookmarkEditor.BindPdf(dataDir & "input.pdf")
			'extract bookmarks
			Dim bookmarks As Bookmarks = bookmarkEditor.ExtractBookmarks()

			For Each bookmark As Bookmark In bookmarks
				Console.WriteLine("Title: {0}", bookmark.Title)
				Console.WriteLine("Page Number: {0}", bookmark.PageNumber)
			Next bookmark



		End Sub
	End Class
End Namespace