<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_CompareList = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gc_CompareList = New DevExpress.XtraGrid.GridControl()
        Me.gv_CompareList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.rpg_Compare = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btn_SaveSeparate = New DevExpress.XtraBars.BarButtonItem()
        Me.rpg_Options = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btn_SelectFolder = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Compare = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_CompareList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_CompareList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Add, Me.btn_Edit, Me.btn_Remove, Me.btn_SaveSeparate, Me.btn_SelectFolder, Me.btn_Compare})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 7
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.Size = New System.Drawing.Size(699, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_CompareList, Me.rpg_Options, Me.rpg_Compare})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_CompareList
        '
        Me.rpg_CompareList.ItemLinks.Add(Me.btn_Add)
        Me.rpg_CompareList.ItemLinks.Add(Me.btn_Edit)
        Me.rpg_CompareList.ItemLinks.Add(Me.btn_Remove)
        Me.rpg_CompareList.Name = "rpg_CompareList"
        Me.rpg_CompareList.ShowCaptionButton = False
        Me.rpg_CompareList.Text = "Comapre List"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(699, 31)
        '
        'gc_CompareList
        '
        Me.gc_CompareList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_CompareList.Location = New System.Drawing.Point(0, 143)
        Me.gc_CompareList.MainView = Me.gv_CompareList
        Me.gc_CompareList.MenuManager = Me.RibbonControl
        Me.gc_CompareList.Name = "gc_CompareList"
        Me.gc_CompareList.Size = New System.Drawing.Size(699, 275)
        Me.gc_CompareList.TabIndex = 5
        Me.gc_CompareList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_CompareList})
        '
        'gv_CompareList
        '
        Me.gv_CompareList.GridControl = Me.gc_CompareList
        Me.gv_CompareList.Name = "gv_CompareList"
        Me.gv_CompareList.OptionsBehavior.Editable = False
        Me.gv_CompareList.OptionsBehavior.ReadOnly = True
        Me.gv_CompareList.OptionsSelection.MultiSelect = True
        Me.gv_CompareList.OptionsView.ShowGroupPanel = False
        '
        'btn_Add
        '
        Me.btn_Add.Caption = "Add"
        Me.btn_Add.Id = 1
        Me.btn_Add.ImageOptions.SvgImage = CType(resources.GetObject("btn_Add.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Add.Name = "btn_Add"
        '
        'btn_Edit
        '
        Me.btn_Edit.Caption = "Edit"
        Me.btn_Edit.Id = 2
        Me.btn_Edit.ImageOptions.SvgImage = CType(resources.GetObject("btn_Edit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Edit.Name = "btn_Edit"
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove"
        Me.btn_Remove.Id = 3
        Me.btn_Remove.ImageOptions.SvgImage = CType(resources.GetObject("btn_Remove.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Remove.Name = "btn_Remove"
        '
        'rpg_Compare
        '
        Me.rpg_Compare.ItemLinks.Add(Me.btn_Compare)
        Me.rpg_Compare.Name = "rpg_Compare"
        Me.rpg_Compare.ShowCaptionButton = False
        Me.rpg_Compare.Text = "Compare"
        '
        'btn_SaveSeparate
        '
        Me.btn_SaveSeparate.Caption = "Save Result in Separate File"
        Me.btn_SaveSeparate.Id = 4
        Me.btn_SaveSeparate.ImageOptions.SvgImage = CType(resources.GetObject("btn_SaveSeparate.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_SaveSeparate.Name = "btn_SaveSeparate"
        '
        'rpg_Options
        '
        Me.rpg_Options.ItemLinks.Add(Me.btn_SaveSeparate)
        Me.rpg_Options.ItemLinks.Add(Me.btn_SelectFolder)
        Me.rpg_Options.Name = "rpg_Options"
        Me.rpg_Options.Text = "Options"
        '
        'btn_SelectFolder
        '
        Me.btn_SelectFolder.Caption = "Select Folder"
        Me.btn_SelectFolder.Id = 5
        Me.btn_SelectFolder.ImageOptions.SvgImage = CType(resources.GetObject("btn_SelectFolder.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_SelectFolder.Name = "btn_SelectFolder"
        '
        'btn_Compare
        '
        Me.btn_Compare.Caption = "Start"
        Me.btn_Compare.Id = 6
        Me.btn_Compare.ImageOptions.SvgImage = CType(resources.GetObject("btn_Compare.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Compare.Name = "btn_Compare"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 449)
        Me.Controls.Add(Me.gc_CompareList)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "GSTR 2A - Excel Helper Tool"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_CompareList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_CompareList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_CompareList As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents gc_CompareList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_CompareList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SaveSeparate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Compare As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_SelectFolder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Options As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Compare As DevExpress.XtraBars.BarButtonItem
End Class
