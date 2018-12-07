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

Imports DevExpress.XtraEditors.Controls

Namespace Dialogs
    Public Class frm_CompareItem

#Region "Properties"
        Property CompareItem As Objects.ComareItem
#End Region

#Region "Form Events"
        Private Sub frm_CompareItem_Load(sender As Object, e As EventArgs) Handles Me.Load
            If CompareItem IsNot Nothing Then
                txt_GSTR1.Text = CompareItem.GSTR1
                txt_GSTR2A.Text = CompareItem.GSTR2A
            End If
        End Sub
#End Region

#Region "Button Events"
        Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
            If txt_GSTR1.Text.Trim = "" OrElse Not My.Computer.FileSystem.FileExists(txt_GSTR1.Text) Then
                MsgBox("Invalid target GSTR1 file.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If
            If txt_GSTR2A.Text.Trim = "" OrElse Not My.Computer.FileSystem.FileExists(txt_GSTR2A.Text) Then
                MsgBox("Invalid target GSTR2A file.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If
            CompareItem = New Objects.ComareItem(txt_GSTR1.Text, txt_GSTR2A.Text)
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub txt_GSTR1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txt_GSTR1.ButtonClick
            If browse_Excel.ShowDialog = DialogResult.OK Then
                txt_GSTR1.Text = browse_Excel.FileName
            End If
        End Sub

        Private Sub txt_GSTR2A_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txt_GSTR2A.ButtonClick
            If browse_Excel.ShowDialog = DialogResult.OK Then
                txt_GSTR2A.Text = browse_Excel.FileName
            End If
        End Sub
#End Region

    End Class
End Namespace