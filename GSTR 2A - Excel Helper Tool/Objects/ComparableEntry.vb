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

Namespace Objects
    Public Class ComparableEntry

#Region "Properties"
        ReadOnly Property GSTIN As String
        ReadOnly Property InvoiceNo As String
        ReadOnly Property InvoiceDate As Date
        ReadOnly Property TaxableValue As Double
        ReadOnly Property TaxRate As Double
        ReadOnly Property Row As DevExpress.Spreadsheet.Row

        Dim Matched_ As Boolean = False
        ReadOnly Property Matched As Boolean
            Get
                Return Matched_
            End Get
        End Property
#End Region

#Region "Subs"
        Sub New(ByVal GSTIN As String, ByVal InvoiceNo As String, ByVal InvoiceDate As Date, ByVal TaxableValue As Double, ByVal TaxRate As Double, ByVal Row As DevExpress.Spreadsheet.Row)
            Me.GSTIN = GSTIN
            Me.InvoiceNo = InvoiceNo
            Me.InvoiceDate = InvoiceDate
            Me.TaxableValue = TaxableValue
            Me.TaxRate = TaxRate
            Me.Row = Row
        End Sub

        Sub SetMatched(Optional Value As Boolean = False)
            Matched_ = Value
        End Sub
#End Region

    End Class
End Namespace