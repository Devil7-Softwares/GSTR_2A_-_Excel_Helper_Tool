﻿'=========================================================================='
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

Imports DevExpress.Data
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_Main

#Region "Variables"
    Dim LastUpdatedItemIndex As Integer = -1
#End Region

#Region "Properties"
    ReadOnly Property CompareList As List(Of Objects.CompareItem)
        Get
            If gc_CompareList.DataSource Is Nothing Then
                gc_CompareList.DataSource = New List(Of Objects.CompareItem)
            End If
            Return CType(gc_CompareList.DataSource, List(Of Objects.CompareItem))
        End Get
    End Property
#End Region

#Region "Subs"
    Private Sub EnableControls()
        rpg_Compare.Enabled = True
        rpg_CompareList.Enabled = True

        ProgressPanel_Loading.Visible = False
    End Sub

    Private Sub DisableControls()
        rpg_Compare.Enabled = False
        rpg_CompareList.Enabled = False

        ProgressPanel_Loading.Visible = True
    End Sub

    Private Sub UpdateProgress(ByVal Caption As String, ByVal Description As String)
        If InvokeRequired Then
            Invoke(Sub() UpdateProgress(Caption, Description))
        Else
            If Caption <> "" Then ProgressPanel_Loading.Caption = Caption
            If Description <> "" Then ProgressPanel_Loading.Description = Description
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load a dummy workbook instance to speed up the process when the end-user selects compare item files
        Using DummySpreadsheet As New Workbook
            DummySpreadsheet.LoadDocument(My.Resources.dummy)
        End Using

        gc_CompareList.DataSource = New List(Of Objects.CompareItem)
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
        Dim D As New Dialogs.frm_CompareItem
        If D.ShowDialog() = DialogResult.OK Then
            CompareList.Add(D.CompareItem)
            LastUpdatedItemIndex = CompareList.IndexOf(D.CompareItem)
            Worker_Loader.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Edit.ItemClick
        If gv_CompareList.GetSelectedRows.Count = 1 Then
            Dim Item As Objects.CompareItem = gv_CompareList.GetRow(gv_CompareList.GetSelectedRows(0))
            Dim D As New Dialogs.frm_CompareItem
            D.CompareItem = Item
            If D.ShowDialog = DialogResult.OK Then
                Item.GSTR2 = D.CompareItem.GSTR2
                Item.GSTR2A = D.CompareItem.GSTR2A
                LastUpdatedItemIndex = CompareList.IndexOf(Item)
                Worker_Loader.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Remove.ItemClick
        If gv_CompareList.GetSelectedRows.Count > 0 Then
            Dim toRemove As New List(Of Objects.CompareItem)
            For Each i As Integer In gv_CompareList.GetSelectedRows
                toRemove.Add(gv_CompareList.GetRow(i))
            Next
            For Each i As Objects.CompareItem In toRemove
                CompareList.Remove(i)
            Next
            gc_CompareList.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Compare_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Compare.ItemClick
        If Not Worker_Comparer.IsBusy Then Worker_Comparer.RunWorkerAsync()
    End Sub

    Private Sub btn_UnwantedRowsRemover_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_UnwantedRowsRemover.ItemClick
        Dim D As New frm_UnwantedRowRemover
        D.ShowDialog()
    End Sub
#End Region

#Region "Menu Events"
    Private Sub gv_CompareList_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles gv_CompareList.PopupMenuShowing
        If e.HitInfo.HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell AndAlso gv_CompareList.SelectedRowsCount > 0 Then
            e.Allow = False
            Menu_CompareList.ShowPopup(gc_CompareList.PointToScreen(e.Point))
        End If
    End Sub

    Private Sub btn_Menu_Open_GSTR2_File_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Menu_Open_GSTR2_File.ItemClick
        If gv_CompareList.SelectedRowsCount > 0 Then
            For Each i As Integer In gv_CompareList.GetSelectedRows
                Dim Item As Objects.CompareItem = gv_CompareList.GetRow(i)
                Process.Start(Item.GSTR2)
            Next
        End If
    End Sub

    Private Sub btn_Menu_Open_GSTR2A_File_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Menu_Open_GSTR2A_File.ItemClick
        If gv_CompareList.SelectedRowsCount > 0 Then
            For Each i As Integer In gv_CompareList.GetSelectedRows
                Dim Item As Objects.CompareItem = gv_CompareList.GetRow(i)
                Process.Start(Item.GSTR2A)
            Next
        End If
    End Sub

    Private Sub btn_Menu_Open_GSTR2_Folder_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Menu_Open_GSTR2_Folder.ItemClick
        If gv_CompareList.SelectedRowsCount > 0 Then
            For Each i As Integer In gv_CompareList.GetSelectedRows
                Dim Item As Objects.CompareItem = gv_CompareList.GetRow(i)
                Process.Start(My.Computer.FileSystem.GetFileInfo(Item.GSTR2).Directory.FullName)
            Next
        End If
    End Sub

    Private Sub btn_Menu_Open_GSTR2A_Folder_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Menu_Open_GSTR2A_Folder.ItemClick
        If gv_CompareList.SelectedRowsCount > 0 Then
            For Each i As Integer In gv_CompareList.GetSelectedRows
                Dim Item As Objects.CompareItem = gv_CompareList.GetRow(i)
                Process.Start(My.Computer.FileSystem.GetFileInfo(Item.GSTR2A).Directory.FullName)
            Next
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub Worker_Comparer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_Comparer.DoWork
        Invoke(Sub() DisableControls())

        Try
            For ItemIndex As Integer = 0 To CompareList.Count - 1
                UpdateProgress(String.Format("Comparing Items {0} of {1}, Please Wait...", ItemIndex + 1, CompareList.Count), "")

                Dim Item As Objects.CompareItem = CompareList(ItemIndex)
                If My.Computer.FileSystem.FileExists(Item.GSTR2) AndAlso My.Computer.FileSystem.FileExists(Item.GSTR2A) Then
                    Dim GSTR2 As New Workbook
                    Dim GSTR2A As New Workbook

                    UpdateProgress("", "Loading Workbooks...")
                    GSTR2.LoadDocument(Item.GSTR2)
                    GSTR2A.LoadDocument(Item.GSTR2A)

                    UpdateProgress("", "Reading Entries...")
                    Dim GSTR2_B2B As List(Of Objects.GSTR.Party) = PublicFunctions.ReadGSTR2_B2B(GSTR2)
                    Dim GSTR2A_B2B As List(Of Objects.GSTR.Party) = PublicFunctions.ReadGSTR2A_B2B(GSTR2A)
                    PublicFunctions.Compare(GSTR2_B2B, GSTR2A_B2B)

                    UpdateProgress("", "Saving Workbooks...")
                    GSTR2.SaveDocument(Item.GSTR2)
                    GSTR2A.SaveDocument(Item.GSTR2A)

                    If GSTR2.IsDisposed = False Then GSTR2.Dispose()
                    If GSTR2A.IsDisposed = False Then GSTR2A.Dispose()
                End If
            Next
            MsgBox("Successfully Completed!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
        Catch ex As Exception
            MsgBox("Unable to Complete the Process!" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub() EnableControls())
    End Sub

    Private Sub gv_CompareList_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gv_CompareList.SelectionChanged
        If gv_CompareList.SelectedRowsCount > 0 Then
            Dim CompareItem As Objects.CompareItem = gv_CompareList.GetRow(gv_CompareList.GetSelectedRows(0))
            gc_GSTR2.DataSource = CompareItem.GSTR2Data
            gc_GSTR2A.DataSource = CompareItem.GSTR2AData
        End If
    End Sub

    Private Sub Worker_Loader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_Loader.DoWork
        Invoke(Sub() DisableControls())

        UpdateProgress("Please Wait...", "")

        Dim Item As Objects.CompareItem = CompareList(LastUpdatedItemIndex)
        If Item IsNot Nothing Then
            Dim GSTR2 As New Workbook
            Dim GSTR2A As New Workbook

            UpdateProgress("", "Loading Workbooks...")
            GSTR2.LoadDocument(Item.GSTR2)
            GSTR2A.LoadDocument(Item.GSTR2A)

            UpdateProgress("", "Reading Entries...")
            Item.LoadData(GSTR2, GSTR2A)
            For Each i As Objects.GSTR.Party In Item.GSTR2Data

            Next

            If GSTR2.IsDisposed = False Then GSTR2.Dispose()
            If GSTR2A.IsDisposed = False Then GSTR2A.Dispose()
        End If

        Invoke(Sub()
                   EnableControls()
                   gc_CompareList.RefreshDataSource()
               End Sub)
    End Sub
#End Region

End Class