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
Imports System.ComponentModel

Namespace Objects.GSTR
    Public Class Item

#Region "Properties"
        ReadOnly Property Rate As Double
        ReadOnly Property TaxableValue As Double

        Dim InvoiceValue_ As Double
        ReadOnly Property InvoiceValue As Double
            Get
                Return InvoiceValue_
            End Get
        End Property

        <Browsable(False)>
        ReadOnly Property Row As Row
#End Region

#Region "Subs"
        Sub New(ByVal Rate As Double, ByVal TaxableValue As Double, ByVal Row As Row)
            Me.Rate = Rate
            Me.TaxableValue = TaxableValue
            Me.Row = Row
        End Sub

        Sub SetInvoiceValue(ByVal Value As String)
            InvoiceValue_ = Value
        End Sub
#End Region

    End Class
End Namespace