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
        Property CompareItem As Objects.CompareItem
#End Region

#Region "Form Events"
        Private Sub frm_CompareItem_Load(sender As Object, e As EventArgs) Handles Me.Load
            If CompareItem IsNot Nothing Then
                txt_GSTR2.Text = CompareItem.GSTR2
                txt_GSTR2A.Text = CompareItem.GSTR2A
            End If
        End Sub
#End Region

#Region "Other Events"
        Private Sub txt_GSTR_DragEnter(sender As Object, e As DragEventArgs) Handles txt_GSTR2.DragEnter, txt_GSTR2A.DragEnter
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.Copy
            End If
        End Sub

        Private Sub txt_GSTR_DragDrop(sender As Object, e As DragEventArgs) Handles txt_GSTR2.DragDrop, txt_GSTR2A.DragDrop
            Dim Files As String() = e.Data.GetData(DataFormats.FileDrop)
            If Files.Count > 0 Then
                CType(sender, DevExpress.XtraEditors.ButtonEdit).Text = Files(0)
            End If
        End Sub
#End Region

#Region "Button Events"
        Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
            If txt_GSTR2.Text.Trim = "" OrElse Not My.Computer.FileSystem.FileExists(txt_GSTR2.Text) Then
                MsgBox("Invalid target GSTR2 file.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If
            If txt_GSTR2A.Text.Trim = "" OrElse Not My.Computer.FileSystem.FileExists(txt_GSTR2A.Text) Then
                MsgBox("Invalid target GSTR2A file.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If
            CompareItem = New Objects.CompareItem(txt_GSTR2.Text, txt_GSTR2A.Text)
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub txt_GSTR2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txt_GSTR2.ButtonClick
            If My.Settings.LastGSTR2 <> "" AndAlso My.Computer.FileSystem.FileExists(My.Settings.LastGSTR2) Then
                browse_Excel.FileName = My.Settings.LastGSTR2
            End If
            If browse_Excel.ShowDialog = DialogResult.OK Then
                txt_GSTR2.Text = browse_Excel.FileName
                My.Settings.LastGSTR2 = browse_Excel.FileName
                My.Settings.Save()
            End If
        End Sub

        Private Sub txt_GSTR2A_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txt_GSTR2A.ButtonClick
            If My.Settings.LastGSTR2A <> "" AndAlso My.Computer.FileSystem.FileExists(My.Settings.LastGSTR2A) Then
                browse_Excel.FileName = My.Settings.LastGSTR2A
            End If
            If browse_Excel.ShowDialog = DialogResult.OK Then
                txt_GSTR2A.Text = browse_Excel.FileName
                My.Settings.LastGSTR2A = browse_Excel.FileName
                My.Settings.Save()
            End If
        End Sub

        Private Sub btn_SaveGSTR2_Format_Click(sender As Object, e As EventArgs) Handles btn_SaveGSTR2_Format.Click
            If save_GSTR2.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllBytes(save_GSTR2.FileName, My.Resources.GSTR2Format, False)
            End If
        End Sub
#End Region

    End Class
End Namespace