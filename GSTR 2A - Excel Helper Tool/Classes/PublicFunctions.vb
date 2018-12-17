'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Imports DevExpress.Spreadsheet
Imports System.Math

Public Class PublicFunctions

#Region "Colors"
    Private Shared ReadOnly MatchedColor As Color = Color.FromArgb(8, 204, 112)
    Private Shared ReadOnly NotMatchedColor As Color = Color.FromArgb(242, 67, 67)
#End Region

#Region "GSTR Entries Reader"
    Public Shared Function ReadGSTR2_B2B(ByVal WorkBook As Workbook) As List(Of Objects.GSTR.Party)
        Dim R As New List(Of Objects.GSTR.Party)
        Try
            ' Row & Column Indexes
            Dim GSTR2_Start_Index As Integer = 3 ' Zero Based Index of Row from which entries are beginning
            Dim GSTIN_Index As Integer = 1
            Dim InvoiceNo_Index As Integer = 2
            Dim InvoiceDate_Index As Integer = 3
            Dim InvoiceVal_Index As Integer = 4
            Dim Rate_Index As Integer = 5
            Dim TaxableVal_Index As Integer = 7

            Dim B2BSheet As Worksheet = WorkBook.Worksheets("b2b")

            Try
                Dim HeaderRow As Row = B2BSheet.Rows(2)
                For i As Integer = 0 To 20
                    Try
                        Dim Value As CellValue = HeaderRow.Item(i).Value
                        If Value.IsText AndAlso Value.TextValue.ToUpper.Contains("TAXABLE") Then
                            TaxableVal_Index = i
                            Exit For
                        End If
                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try

            For Index As Integer = GSTR2_Start_Index To B2BSheet.Rows.LastUsedIndex
                Try
                    Dim Row As Row = B2BSheet.Rows.Item(Index)
                    Dim GSTIN As String = GetString(Row, GSTIN_Index)

                    If GSTIN <> "" Then
                        Dim InvoiceNumber As String = GetString(Row, InvoiceNo_Index)
                        Dim InvoiceDate As Date = GetDate(Row, InvoiceDate_Index)
                        Dim InvoiceValue As Double = GetString(Row, InvoiceVal_Index)
                        Dim Rate As Double = GetString(Row, Rate_Index)
                        Dim TaxableValue As Double = GetString(Row, TaxableVal_Index)
                        AddInvoice(R, GSTIN, InvoiceNumber, InvoiceDate, InvoiceValue, Rate, TaxableValue, Row)
                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception
            MsgBox("Unable to load GSTR2." & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return R
    End Function

    Private Shared Sub AddInvoice(ByVal List As List(Of Objects.GSTR.Party), GSTIN As String, ByVal InvoiceNumber As String, ByVal InvoiceDate As Date, ByVal InvoiceValue As Double, ByVal Rate As Double, ByVal TaxableValue As Double, ByVal Row As Row)
        Dim Party As Objects.GSTR.Party = List.Find(Function(c) c.GSTIN.ToUpper.Equals(GSTIN.ToUpper))
        If Party Is Nothing Then
            Party = New Objects.GSTR.Party(GSTIN)
            List.Add(Party)
        End If

        Dim Invoice As Objects.GSTR.Invoice = Party.Invoices.ToList.Find(Function(c) c.InvoiceNo.ToUpper.Equals(InvoiceNumber.ToUpper) AndAlso c.InvoiceDate.Equals(InvoiceDate))
        If Invoice Is Nothing Then
            Invoice = New Objects.GSTR.Invoice(InvoiceNumber, InvoiceDate)
            Party.Invoices.Add(Invoice)
        End If

        Invoice.Items.Add(New Objects.GSTR.Item(Rate, TaxableValue, Row))
    End Sub

    Public Shared Function ReadGSTR2A_B2B(ByVal WorkBook As Workbook) As List(Of Objects.GSTR.Party)
        Dim R As New List(Of Objects.GSTR.Party)
        Try
            ' Row & Column Indexes
            Dim GSTR2_Start_Index As Integer = 6 ' Zero Based Index of Row from which entries are beginning
            Dim GSTIN_Index As Integer = 0
            Dim InvoiceNo_Index As Integer = 2
            Dim InvoiceDate_Index As Integer = 4
            Dim InvoiceVal_Index As Integer = 5
            Dim Rate_Index As Integer = 8
            Dim TaxableVal_Index As Integer = 9

            Dim B2BSheet As Worksheet = WorkBook.Worksheets("B2B")

            For Index As Integer = GSTR2_Start_Index To B2BSheet.Rows.LastUsedIndex
                Dim Row As Row = B2BSheet.Rows.Item(Index)
                Try
                    Dim GSTIN As String = GetString(Row, GSTIN_Index)

                    If GSTIN <> "" Then
                        Dim InvoiceNumber As String = GetString(Row, InvoiceNo_Index)
                        Dim InvoiceDate As Date = GetDate(Row, InvoiceDate_Index)
                        Dim InvoiceValue As Double = GetString(Row, InvoiceVal_Index)
                        Dim Rate As Double = GetString(Row, Rate_Index)
                        Dim TaxableValue As Double = GetString(Row, TaxableVal_Index)
                        If InvoiceNumber.Contains("-Total") Then Continue For
                        AddInvoice(R, GSTIN, InvoiceNumber, InvoiceDate, InvoiceValue, Rate, TaxableValue, Row)
                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception
            MsgBox("Unable to load GSTR2." & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return R
    End Function
#End Region

#Region "Comparer"
    Public Shared Sub Compare(ByVal List1 As List(Of Objects.GSTR.Party), ByVal List2 As List(Of Objects.GSTR.Party))
        Dim Data1 As List(Of Objects.ComparableEntry) = ConvertToComparable(List1)
        Dim Data2 As List(Of Objects.ComparableEntry) = ConvertToComparable(List2)
        CompareLists(Data1, Data2)
        CompareLists(Data2, Data1)
        CompareInvoiceWithList(List1, Data2)
        CompareInvoiceWithList(List2, Data1)
    End Sub

    Private Shared Function IsEqual(Value1 As Double, Value2 As Double,
            Optional Tolerance As Double = 0.9) As Boolean
        If Abs(Value1 - Value2) < Tolerance Then
            IsEqual = True
        Else
            IsEqual = False
        End If
    End Function

    Private Shared Sub CompareLists(ByVal List1 As List(Of Objects.ComparableEntry), ByVal List2 As List(Of Objects.ComparableEntry))
        For Each Item1 As Objects.ComparableEntry In List1
            Dim Item2 As Objects.ComparableEntry = List2.Find(Function(Item) CompareItems(Item, Item1))
            If Item2 Is Nothing Then
                Item1.SetMatched(Objects.MatchStatus.NotMatched)
                Item1.Row.Font.Color = NotMatchedColor
            Else
                Item1.SetMatched(Objects.MatchStatus.Matched)
                Item1.Row.Font.Color = MatchedColor
                Item2.SetMatched(Objects.MatchStatus.Matched)
                Item2.Row.Font.Color = MatchedColor
            End If
        Next
    End Sub

    Private Shared Sub CompareInvoiceWithList(ByVal List1 As List(Of Objects.GSTR.Party), ByVal List2 As List(Of Objects.ComparableEntry))
        For Each Party In List1
            For Each Invoice As Objects.GSTR.Invoice In Party.Invoices
                Dim Item2 As Objects.ComparableEntry = List2.Find(Function(Item) CompareItems(Item, Party, Invoice))
                If Item2 IsNot Nothing Then
                    For Each Item As Objects.GSTR.Item In Invoice.Items
                        Item.Row.Font.Color = MatchedColor
                    Next
                    Item2.SetMatched(Objects.MatchStatus.Matched)
                    Item2.Row.Font.Color = MatchedColor
                End If
            Next
        Next
    End Sub

    Private Shared Function CompareItems(ByVal Item As Objects.ComparableEntry, ByVal Party As Objects.GSTR.Party, ByVal Invoice As Objects.GSTR.Invoice) As Boolean
        If (Item.Matched = Objects.MatchStatus.NotMatched) AndAlso Item.GSTIN.ToUpper.Equals(Party.GSTIN.ToUpper) AndAlso Item.InvoiceDate.Equals(Invoice.InvoiceDate) AndAlso IsEqual(Item.InvoiceValue, Invoice.InvoiceValue) Then Return True
        Return False
    End Function

    Private Shared Function CompareItems(ByVal Item1 As Objects.ComparableEntry, ByVal Item2 As Objects.ComparableEntry) As Boolean
        If (Item1.Matched = Objects.MatchStatus.Unknown AndAlso Item2.Matched = Objects.MatchStatus.Unknown) AndAlso (Item1.GSTIN.ToUpper.Equals(Item2.GSTIN.ToUpper) AndAlso Item1.InvoiceDate.Equals(Item2.InvoiceDate) AndAlso IsEqual(Item1.TaxableValue, Item2.TaxableValue)) Then Return True
        Return False
    End Function
#End Region

#Region "Excel Reader Functions"
    Private Shared Function GetString(ByVal Row As Row, ByVal Index As Integer) As String
        Dim Value As CellValue = Row.Item(Index).Value
        If Not Value.IsEmpty Then
            If Value.IsText Then
                Return Value.TextValue.Trim
            ElseIf Value.IsNumeric Then
                Return Value.NumericValue.ToString
            End If
        End If
        Return ""
    End Function

    Private Shared Function GetDouble(ByVal Row As Row, ByVal Index As Integer) As Double
        Dim R As Double = 0
        If Not Row.Item(Index).Value.IsEmpty AndAlso Row.Item(Index).Value.IsNumeric Then
            R = Row.Item(Index).Value.NumericValue
        End If
        Return R
    End Function

    Private Shared Function GetDate(ByVal Row As Row, ByVal Index As Integer) As Date
        Dim R As Date = Nothing
        Dim Value As CellValue = Row.Item(Index).Value
        If Not Value.IsEmpty Then
            If Value.IsDateTime Then
                R = Row.Item(Index).Value.DateTimeValue
            ElseIf Value.IsText Then
                Date.TryParse(Value.TextValue, R)
            End If
        End If
        Return R
    End Function
#End Region

#Region "Misc"
    Private Shared Function ConvertToComparable(ByVal List As List(Of Objects.GSTR.Party)) As List(Of Objects.ComparableEntry)
        Dim R As New List(Of Objects.ComparableEntry)
        For Each Party As Objects.GSTR.Party In List
            For Each Invoice As Objects.GSTR.Invoice In Party.Invoices
                Dim InvoiceValue As Double = Invoice.InvoiceValue
                For Each Item As Objects.GSTR.Item In Invoice.Items
                    R.Add(New Objects.ComparableEntry(Party.GSTIN, Invoice.InvoiceNo, Invoice.InvoiceDate, Item.InvoiceValue, Item.TaxableValue, Item.Rate, Item.Row))
                Next
            Next
        Next
        Return R
    End Function
#End Region

End Class
