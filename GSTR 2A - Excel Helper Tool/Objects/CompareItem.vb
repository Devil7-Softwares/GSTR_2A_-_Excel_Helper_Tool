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

Namespace Objects
    Public Class CompareItem

#Region "Properties"
        <DisplayName("GSTR2A Excel")>
        <Description("GSTR 2A Excel File Downloaded from GST Website.")>
        Property GSTR2A As String

        <DisplayName("GSTR2 Excel")>
        <Description("GSTR 2 Excel Template Used to Upload GSTR 2")>
        Property GSTR2 As String

        Dim GSTR2Data_ As List(Of GSTR.Party)
        <Browsable(False)>
        ReadOnly Property GSTR2Data As List(Of GSTR.Party)
            Get
                Return GSTR2Data_
            End Get
        End Property

        Dim GSTR2AData_ As List(Of GSTR.Party)
        <Browsable(False)>
        ReadOnly Property GSTR2AData As List(Of GSTR.Party)
            Get
                Return GSTR2AData_
            End Get
        End Property
#End Region

#Region "Subs"
        Sub New(ByVal GSTR2 As String, ByVal GSTR2A As String)
            Me.GSTR2 = GSTR2
            Me.GSTR2A = GSTR2A
        End Sub

        Sub LoadData(ByVal WB_GSTR2 As Workbook, ByVal WB_GSTR2A As Workbook)
            If GSTR2 <> "" AndAlso My.Computer.FileSystem.FileExists(GSTR2) Then
                GSTR2Data_ = PublicFunctions.ReadGSTR2_B2B(WB_GSTR2)
            End If
            If GSTR2A <> "" AndAlso My.Computer.FileSystem.FileExists(GSTR2A) Then
                GSTR2AData_ = PublicFunctions.ReadGSTR2A_B2B(WB_GSTR2A)
            End If
        End Sub
#End Region

    End Class
End Namespace