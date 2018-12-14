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

Imports System.ComponentModel

Namespace Objects.GSTR
    Public Class Invoice

#Region "Properties"
        <DisplayName("Invoice Number")>
        ReadOnly Property InvoiceNo As String
        <DisplayName("Invoice Date")>
        ReadOnly Property InvoiceDate As Date
        ReadOnly Property Items As New List(Of Item)

        <DisplayName("Items Count")>
        ReadOnly Property ItemCount As Integer
            Get
                Return Items.Count
            End Get
        End Property

        <DisplayName("Total Invoice Value")>
        ReadOnly Property InvoiceValue As Double
            Get
                Dim Total As Double = 0
                For Each i As Item In Items
                    Total = i.TaxableValue + (i.TaxableValue * i.Rate / 100)
                Next
                Return Total
            End Get
        End Property
#End Region

#Region "Events"

#End Region

#Region "Subs"
        Sub New(ByVal InvoiceNo As String, ByVal InvoiceDate As Date)
            Me.InvoiceNo = InvoiceNo
            Me.InvoiceDate = InvoiceDate
        End Sub
#End Region

    End Class
End Namespace