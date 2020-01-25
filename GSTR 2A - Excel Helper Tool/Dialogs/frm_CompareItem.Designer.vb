Imports DevExpress.XtraEditors

Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_CompareItem
        Inherits XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CompareItem))
            Me.lbl_GSTR2 = New DevExpress.XtraEditors.LabelControl()
            Me.lbl_GSTR2A = New DevExpress.XtraEditors.LabelControl()
            Me.txt_GSTR2 = New DevExpress.XtraEditors.ButtonEdit()
            Me.txt_GSTR2A = New DevExpress.XtraEditors.ButtonEdit()
            Me.browse_Excel = New System.Windows.Forms.OpenFileDialog()
            Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_SaveGSTR2_Format = New DevExpress.XtraEditors.HyperlinkLabelControl()
            Me.save_GSTR2 = New System.Windows.Forms.SaveFileDialog()
            CType(Me.txt_GSTR2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_GSTR2A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lbl_GSTR2
            '
            Me.lbl_GSTR2.Location = New System.Drawing.Point(19, 15)
            Me.lbl_GSTR2.Name = "lbl_GSTR2"
            Me.lbl_GSTR2.Size = New System.Drawing.Size(70, 13)
            Me.lbl_GSTR2.TabIndex = 0
            Me.lbl_GSTR2.Text = "GSTR 2 Excel :"
            '
            'lbl_GSTR2A
            '
            Me.lbl_GSTR2A.Location = New System.Drawing.Point(12, 41)
            Me.lbl_GSTR2A.Name = "lbl_GSTR2A"
            Me.lbl_GSTR2A.Size = New System.Drawing.Size(77, 13)
            Me.lbl_GSTR2A.TabIndex = 1
            Me.lbl_GSTR2A.Text = "GSTR 2A Excel :"
            '
            'txt_GSTR2
            '
            Me.txt_GSTR2.AllowDrop = True
            Me.txt_GSTR2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_GSTR2.Location = New System.Drawing.Point(95, 12)
            Me.txt_GSTR2.Name = "txt_GSTR2"
            Me.txt_GSTR2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.txt_GSTR2.Properties.ReadOnly = True
            Me.txt_GSTR2.Size = New System.Drawing.Size(360, 20)
            Me.txt_GSTR2.TabIndex = 2
            Me.txt_GSTR2.ToolTip = "Select GSTR2 File that contains the data used to upload & file GSTR2 in given for" &
    "mat"
            '
            'txt_GSTR2A
            '
            Me.txt_GSTR2A.AllowDrop = True
            Me.txt_GSTR2A.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_GSTR2A.Location = New System.Drawing.Point(95, 38)
            Me.txt_GSTR2A.Name = "txt_GSTR2A"
            Me.txt_GSTR2A.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.txt_GSTR2A.Properties.ReadOnly = True
            Me.txt_GSTR2A.Size = New System.Drawing.Size(360, 20)
            Me.txt_GSTR2A.TabIndex = 3
            Me.txt_GSTR2A.ToolTip = "Select GSTR 2A File downloaded from GST site to match with above given GSTR2 data" &
    ""
            '
            'browse_Excel
            '
            Me.browse_Excel.Filter = "Excel Spreadsheets (*.xlsx)|*.xlsx"
            Me.browse_Excel.FilterIndex = 0
            '
            'btn_Done
            '
            Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btn_Done.ImageOptions.SvgImage = CType(resources.GetObject("btn_Done.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.btn_Done.Location = New System.Drawing.Point(380, 64)
            Me.btn_Done.Name = "btn_Done"
            Me.btn_Done.Size = New System.Drawing.Size(75, 32)
            Me.btn_Done.TabIndex = 4
            Me.btn_Done.Text = "Done"
            '
            'btn_SaveGSTR2_Format
            '
            Me.btn_SaveGSTR2_Format.Location = New System.Drawing.Point(278, 71)
            Me.btn_SaveGSTR2_Format.Name = "btn_SaveGSTR2_Format"
            Me.btn_SaveGSTR2_Format.Size = New System.Drawing.Size(96, 13)
            Me.btn_SaveGSTR2_Format.TabIndex = 5
            Me.btn_SaveGSTR2_Format.Text = "Save GSTR2 Format"
            '
            'save_GSTR2
            '
            Me.save_GSTR2.FileName = "GSTR2 Format.xlsx"
            Me.save_GSTR2.Filter = "Microsoft Excel Spreadsheet Files (*.xlsx)|*.xlsx"
            '
            'frm_CompareItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(467, 104)
            Me.Controls.Add(Me.btn_SaveGSTR2_Format)
            Me.Controls.Add(Me.btn_Done)
            Me.Controls.Add(Me.txt_GSTR2A)
            Me.Controls.Add(Me.txt_GSTR2)
            Me.Controls.Add(Me.lbl_GSTR2A)
            Me.Controls.Add(Me.lbl_GSTR2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_CompareItem"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Compare Item"
            CType(Me.txt_GSTR2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_GSTR2A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lbl_GSTR2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lbl_GSTR2A As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_GSTR2 As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents txt_GSTR2A As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents browse_Excel As OpenFileDialog
        Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_SaveGSTR2_Format As DevExpress.XtraEditors.HyperlinkLabelControl
        Friend WithEvents save_GSTR2 As SaveFileDialog
    End Class
End Namespace