<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Compare = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_UnwantedRowsRemover = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Menu_Open_GSTR2_File = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Menu_Open_GSTR2_Folder = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Menu_Open_GSTR2A_File = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Menu_Open_GSTR2A_Folder = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_CompareList = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Compare = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Misc = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gc_CompareList = New DevExpress.XtraGrid.GridControl()
        Me.gv_CompareList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProgressPanel_Loading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Worker_Comparer = New System.ComponentModel.BackgroundWorker()
        Me.tc_Main = New DevExpress.XtraTab.XtraTabControl()
        Me.tp_CompareItems = New DevExpress.XtraTab.XtraTabPage()
        Me.tp_GSTR2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gc_GSTR2 = New DevExpress.XtraGrid.GridControl()
        Me.gv_GSTR2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tp_GSTR2A = New DevExpress.XtraTab.XtraTabPage()
        Me.gc_GSTR2A = New DevExpress.XtraGrid.GridControl()
        Me.gv_GSTR2A = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Worker_Loader = New System.ComponentModel.BackgroundWorker()
        Me.Menu_CompareList = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_CompareList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_CompareList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tc_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Main.SuspendLayout()
        Me.tp_CompareItems.SuspendLayout()
        Me.tp_GSTR2.SuspendLayout()
        CType(Me.gc_GSTR2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_GSTR2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_GSTR2A.SuspendLayout()
        CType(Me.gc_GSTR2A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_GSTR2A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_CompareList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Add, Me.btn_Edit, Me.btn_Remove, Me.btn_Compare, Me.btn_UnwantedRowsRemover, Me.btn_Menu_Open_GSTR2_File, Me.btn_Menu_Open_GSTR2_Folder, Me.btn_Menu_Open_GSTR2A_File, Me.btn_Menu_Open_GSTR2A_Folder, Me.RibbonControl.SearchEditItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 13
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(699, 158)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btn_Add
        '
        Me.btn_Add.Caption = "Add"
        Me.btn_Add.Id = 1
        Me.btn_Add.ImageOptions.SvgImage = CType(resources.GetObject("btn_Add.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Add.Name = "btn_Add"
        ToolTipTitleItem1.Text = "Add Compare Item"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Add GSTR2 & GSTR2A Files to Compare"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btn_Add.SuperTip = SuperToolTip1
        '
        'btn_Edit
        '
        Me.btn_Edit.Caption = "Edit"
        Me.btn_Edit.Id = 2
        Me.btn_Edit.ImageOptions.SvgImage = CType(resources.GetObject("btn_Edit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Edit.Name = "btn_Edit"
        ToolTipTitleItem2.Text = "Edit Compare Item"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Edit Selected Compare Item"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btn_Edit.SuperTip = SuperToolTip2
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove"
        Me.btn_Remove.Id = 3
        Me.btn_Remove.ImageOptions.SvgImage = CType(resources.GetObject("btn_Remove.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Remove.Name = "btn_Remove"
        ToolTipTitleItem3.Text = "Remove Compare Item"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Remove Selected Compare Item"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btn_Remove.SuperTip = SuperToolTip3
        '
        'btn_Compare
        '
        Me.btn_Compare.Caption = "Start"
        Me.btn_Compare.Id = 6
        Me.btn_Compare.ImageOptions.SvgImage = CType(resources.GetObject("btn_Compare.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Compare.Name = "btn_Compare"
        ToolTipTitleItem4.Text = "Start Compare"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = resources.GetString("ToolTipItem4.Text")
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btn_Compare.SuperTip = SuperToolTip4
        '
        'btn_UnwantedRowsRemover
        '
        Me.btn_UnwantedRowsRemover.Caption = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Unwanted Rows"
        Me.btn_UnwantedRowsRemover.Id = 8
        Me.btn_UnwantedRowsRemover.ImageOptions.SvgImage = CType(resources.GetObject("btn_UnwantedRowsRemover.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_UnwantedRowsRemover.Name = "btn_UnwantedRowsRemover"
        ToolTipTitleItem5.Text = "Remove Unwanted Rows"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Remove extra rows in-between entries in GSTR2A workbook downloaded from GST site"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btn_UnwantedRowsRemover.SuperTip = SuperToolTip5
        '
        'btn_Menu_Open_GSTR2_File
        '
        Me.btn_Menu_Open_GSTR2_File.Caption = "Open GSTR2 File"
        Me.btn_Menu_Open_GSTR2_File.Id = 9
        Me.btn_Menu_Open_GSTR2_File.ImageOptions.SvgImage = CType(resources.GetObject("btn_Menu_Open_GSTR2_File.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Menu_Open_GSTR2_File.Name = "btn_Menu_Open_GSTR2_File"
        ToolTipTitleItem6.Text = "Open GSTR2 File"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Open selected GSTR2 Spreadsheet file"
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.btn_Menu_Open_GSTR2_File.SuperTip = SuperToolTip6
        '
        'btn_Menu_Open_GSTR2_Folder
        '
        Me.btn_Menu_Open_GSTR2_Folder.Caption = "Open Folder of GSTR2 File"
        Me.btn_Menu_Open_GSTR2_Folder.Id = 10
        Me.btn_Menu_Open_GSTR2_Folder.ImageOptions.SvgImage = CType(resources.GetObject("btn_Menu_Open_GSTR2_Folder.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Menu_Open_GSTR2_Folder.Name = "btn_Menu_Open_GSTR2_Folder"
        ToolTipTitleItem7.Text = "Open Folder of GSTR2 File"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Open parent directory of give GSTR2 File in explorer"
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.btn_Menu_Open_GSTR2_Folder.SuperTip = SuperToolTip7
        '
        'btn_Menu_Open_GSTR2A_File
        '
        Me.btn_Menu_Open_GSTR2A_File.Caption = "Open GSTR2A File"
        Me.btn_Menu_Open_GSTR2A_File.Id = 11
        Me.btn_Menu_Open_GSTR2A_File.ImageOptions.SvgImage = CType(resources.GetObject("btn_Menu_Open_GSTR2A_File.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Menu_Open_GSTR2A_File.Name = "btn_Menu_Open_GSTR2A_File"
        ToolTipTitleItem8.Text = "Open GSTR2A File"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Open selected GSTR2 Spreadsheet file"
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.btn_Menu_Open_GSTR2A_File.SuperTip = SuperToolTip8
        '
        'btn_Menu_Open_GSTR2A_Folder
        '
        Me.btn_Menu_Open_GSTR2A_Folder.Caption = "Open Folder of GSTR2A FIle"
        Me.btn_Menu_Open_GSTR2A_Folder.Id = 12
        Me.btn_Menu_Open_GSTR2A_Folder.ImageOptions.SvgImage = CType(resources.GetObject("btn_Menu_Open_GSTR2A_Folder.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Menu_Open_GSTR2A_Folder.Name = "btn_Menu_Open_GSTR2A_Folder"
        ToolTipTitleItem9.Text = "Open Folder of GSTR2A File"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Open parent directory of give GSTR2A File in explorer"
        SuperToolTip9.Items.Add(ToolTipTitleItem9)
        SuperToolTip9.Items.Add(ToolTipItem9)
        Me.btn_Menu_Open_GSTR2A_Folder.SuperTip = SuperToolTip9
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_CompareList, Me.rpg_Compare, Me.rpg_Misc})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_CompareList
        '
        Me.rpg_CompareList.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpg_CompareList.ItemLinks.Add(Me.btn_Add)
        Me.rpg_CompareList.ItemLinks.Add(Me.btn_Edit)
        Me.rpg_CompareList.ItemLinks.Add(Me.btn_Remove)
        Me.rpg_CompareList.Name = "rpg_CompareList"
        Me.rpg_CompareList.Text = "Comapre List"
        '
        'rpg_Compare
        '
        Me.rpg_Compare.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpg_Compare.ItemLinks.Add(Me.btn_Compare)
        Me.rpg_Compare.Name = "rpg_Compare"
        Me.rpg_Compare.Text = "Compare"
        '
        'rpg_Misc
        '
        Me.rpg_Misc.ItemLinks.Add(Me.btn_UnwantedRowsRemover)
        Me.rpg_Misc.Name = "rpg_Misc"
        Me.rpg_Misc.Text = "Misc"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 425)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(699, 24)
        '
        'gc_CompareList
        '
        Me.gc_CompareList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_CompareList.Location = New System.Drawing.Point(0, 0)
        Me.gc_CompareList.MainView = Me.gv_CompareList
        Me.gc_CompareList.MenuManager = Me.RibbonControl
        Me.gc_CompareList.Name = "gc_CompareList"
        Me.gc_CompareList.Size = New System.Drawing.Size(697, 242)
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
        'ProgressPanel_Loading
        '
        Me.ProgressPanel_Loading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Loading.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Loading.BarAnimationElementThickness = 2
        Me.ProgressPanel_Loading.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Loading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Loading.Location = New System.Drawing.Point(0, 143)
        Me.ProgressPanel_Loading.Name = "ProgressPanel_Loading"
        Me.ProgressPanel_Loading.Size = New System.Drawing.Size(699, 275)
        Me.ProgressPanel_Loading.TabIndex = 8
        Me.ProgressPanel_Loading.Visible = False
        '
        'Worker_Comparer
        '
        '
        'tc_Main
        '
        Me.tc_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_Main.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.tc_Main.Location = New System.Drawing.Point(0, 158)
        Me.tc_Main.Name = "tc_Main"
        Me.tc_Main.SelectedTabPage = Me.tp_CompareItems
        Me.tc_Main.Size = New System.Drawing.Size(699, 267)
        Me.tc_Main.TabIndex = 11
        Me.tc_Main.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp_CompareItems, Me.tp_GSTR2, Me.tp_GSTR2A})
        '
        'tp_CompareItems
        '
        Me.tp_CompareItems.Controls.Add(Me.gc_CompareList)
        Me.tp_CompareItems.Name = "tp_CompareItems"
        Me.tp_CompareItems.Size = New System.Drawing.Size(697, 242)
        Me.tp_CompareItems.Text = "Compare Items"
        '
        'tp_GSTR2
        '
        Me.tp_GSTR2.Controls.Add(Me.gc_GSTR2)
        Me.tp_GSTR2.Name = "tp_GSTR2"
        Me.tp_GSTR2.Size = New System.Drawing.Size(697, 242)
        Me.tp_GSTR2.Text = "GSTR2"
        '
        'gc_GSTR2
        '
        Me.gc_GSTR2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_GSTR2.Location = New System.Drawing.Point(0, 0)
        Me.gc_GSTR2.MainView = Me.gv_GSTR2
        Me.gc_GSTR2.MenuManager = Me.RibbonControl
        Me.gc_GSTR2.Name = "gc_GSTR2"
        Me.gc_GSTR2.Size = New System.Drawing.Size(697, 242)
        Me.gc_GSTR2.TabIndex = 6
        Me.gc_GSTR2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_GSTR2})
        '
        'gv_GSTR2
        '
        Me.gv_GSTR2.GridControl = Me.gc_GSTR2
        Me.gv_GSTR2.Name = "gv_GSTR2"
        Me.gv_GSTR2.OptionsBehavior.Editable = False
        Me.gv_GSTR2.OptionsBehavior.ReadOnly = True
        Me.gv_GSTR2.OptionsPrint.ExpandAllDetails = True
        Me.gv_GSTR2.OptionsPrint.PrintDetails = True
        Me.gv_GSTR2.OptionsPrint.ShowPrintExportProgress = False
        Me.gv_GSTR2.OptionsSelection.MultiSelect = True
        Me.gv_GSTR2.OptionsView.ShowGroupPanel = False
        '
        'tp_GSTR2A
        '
        Me.tp_GSTR2A.Controls.Add(Me.gc_GSTR2A)
        Me.tp_GSTR2A.Name = "tp_GSTR2A"
        Me.tp_GSTR2A.Size = New System.Drawing.Size(697, 242)
        Me.tp_GSTR2A.Text = "GSTR2A"
        '
        'gc_GSTR2A
        '
        Me.gc_GSTR2A.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_GSTR2A.Location = New System.Drawing.Point(0, 0)
        Me.gc_GSTR2A.MainView = Me.gv_GSTR2A
        Me.gc_GSTR2A.MenuManager = Me.RibbonControl
        Me.gc_GSTR2A.Name = "gc_GSTR2A"
        Me.gc_GSTR2A.Size = New System.Drawing.Size(697, 242)
        Me.gc_GSTR2A.TabIndex = 6
        Me.gc_GSTR2A.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_GSTR2A})
        '
        'gv_GSTR2A
        '
        Me.gv_GSTR2A.GridControl = Me.gc_GSTR2A
        Me.gv_GSTR2A.Name = "gv_GSTR2A"
        Me.gv_GSTR2A.OptionsBehavior.Editable = False
        Me.gv_GSTR2A.OptionsBehavior.ReadOnly = True
        Me.gv_GSTR2A.OptionsPrint.ExpandAllDetails = True
        Me.gv_GSTR2A.OptionsPrint.PrintDetails = True
        Me.gv_GSTR2A.OptionsPrint.ShowPrintExportProgress = False
        Me.gv_GSTR2A.OptionsSelection.MultiSelect = True
        Me.gv_GSTR2A.OptionsView.ShowGroupPanel = False
        '
        'Worker_Loader
        '
        '
        'Menu_CompareList
        '
        Me.Menu_CompareList.ItemLinks.Add(Me.btn_Menu_Open_GSTR2_File)
        Me.Menu_CompareList.ItemLinks.Add(Me.btn_Menu_Open_GSTR2_Folder)
        Me.Menu_CompareList.ItemLinks.Add(Me.btn_Menu_Open_GSTR2A_File, True)
        Me.Menu_CompareList.ItemLinks.Add(Me.btn_Menu_Open_GSTR2A_Folder)
        Me.Menu_CompareList.Name = "Menu_CompareList"
        Me.Menu_CompareList.Ribbon = Me.RibbonControl
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 449)
        Me.Controls.Add(Me.tc_Main)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_Main.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "GSTR 2A - Excel Helper Tool"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_CompareList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_CompareList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tc_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Main.ResumeLayout(False)
        Me.tp_CompareItems.ResumeLayout(False)
        Me.tp_GSTR2.ResumeLayout(False)
        CType(Me.gc_GSTR2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_GSTR2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_GSTR2A.ResumeLayout(False)
        CType(Me.gc_GSTR2A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_GSTR2A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_CompareList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents rpg_Compare As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Compare As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProgressPanel_Loading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Worker_Comparer As System.ComponentModel.BackgroundWorker
    Friend WithEvents tc_Main As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp_CompareItems As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tp_GSTR2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gc_GSTR2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_GSTR2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tp_GSTR2A As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gc_GSTR2A As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_GSTR2A As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Worker_Loader As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_UnwantedRowsRemover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Misc As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Menu_CompareList As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Menu_Open_GSTR2_File As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Menu_Open_GSTR2_Folder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Menu_Open_GSTR2A_File As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Menu_Open_GSTR2A_Folder As DevExpress.XtraBars.BarButtonItem
End Class
