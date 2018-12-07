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

Public Class frm_Main

#Region "Properties"
    ReadOnly Property CompareList As List(Of Objects.ComareItem)
        Get
            If gc_CompareList.DataSource Is Nothing Then
                gc_CompareList.DataSource = New List(Of Objects.ComareItem)
            End If
            Return CType(gc_CompareList.DataSource, List(Of Objects.ComareItem))
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gc_CompareList.DataSource = New List(Of Objects.ComareItem)
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
        Dim D As New Dialogs.frm_CompareItem
        If D.ShowDialog() = DialogResult.OK Then
            CompareList.Add(D.CompareItem)
            gc_CompareList.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Edit.ItemClick
        If gv_CompareList.GetSelectedRows.Count = 1 Then
            Dim Item As Objects.ComareItem = gv_CompareList.GetRow(gv_CompareList.GetSelectedRows(0))
            Dim D As New Dialogs.frm_CompareItem
            D.CompareItem = Item
            If D.ShowDialog = DialogResult.OK Then
                Item.GSTR1 = D.CompareItem.GSTR1
                Item.GSTR2A = D.CompareItem.GSTR2A
                gc_CompareList.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Remove.ItemClick
        If gv_CompareList.GetSelectedRows.Count > 0 Then
            Dim toRemove As New List(Of Objects.ComareItem)
            For Each i As Integer In gv_CompareList.GetSelectedRows
                toRemove.Add(gv_CompareList.GetRow(i))
            Next
            For Each i As Objects.ComareItem In toRemove
                CompareList.Remove(i)
            Next
            gc_CompareList.RefreshDataSource()
        End If
    End Sub
#End Region

End Class