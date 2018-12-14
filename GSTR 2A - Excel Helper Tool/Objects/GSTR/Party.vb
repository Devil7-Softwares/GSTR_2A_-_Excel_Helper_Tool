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
    Public Class Party

#Region "Properties"
        ReadOnly Property GSTIN As String
        ReadOnly Property Invoices As New List(Of Invoice)

        <DisplayName("Invoice Count")>
        ReadOnly Property InvoiceCount As Integer
            Get
                Return Invoices.Count
            End Get
        End Property

        <DisplayName("Invoice Total")>
        ReadOnly Property InvoiceTotal As Double
            Get
                Dim Total As Double = 0
                For Each i As Invoice In Invoices
                    Total += i.InvoiceValue
                Next
                Return Total
            End Get
        End Property
#End Region

#Region "Constructors"
        Sub New(ByVal GSTIN As String)
            Me.GSTIN = GSTIN
        End Sub
#End Region

    End Class
End Namespace