Namespace Win_Dashboards
    Partial Public Class Dashboard_Journal
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim CalculatedField1 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DashboardObjectDataSource_Journal_Entries = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.TreemapDashboardItem1 = New DevExpress.DashboardCommon.TreemapDashboardItem()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardObjectDataSource_Journal_Entries, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TreemapDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ChartDashboardItem1
            '
            Dimension1.DataMember = "Branch_Code"
            Dimension1.TextGroupInterval = DevExpress.DashboardCommon.TextGroupInterval.Alphabetical
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Dimension2.DataMember = "Posting_Date"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
            Measure1.DataMember = "Journal_Debit_Credit"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.ChartDashboardItem1.DataSource = Me.DashboardObjectDataSource_Journal_Entries
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Journal Entries"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedLine
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'DashboardObjectDataSource_Journal_Entries
            '
            CalculatedField1.Expression = "[Journal_Debit] + [Journal_Credit]"
            CalculatedField1.Name = "Journal_Debit_Credit"
            Me.DashboardObjectDataSource_Journal_Entries.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() {CalculatedField1})
            Me.DashboardObjectDataSource_Journal_Entries.ComponentName = "DashboardObjectDataSource_Journal_Entries"
            Me.DashboardObjectDataSource_Journal_Entries.DataMember = "view_Journal_Entries"
            Me.DashboardObjectDataSource_Journal_Entries.Name = "Object Data Source"
            '
            'TreemapDashboardItem1
            '
            Dimension3.DataMember = "Journal_Type"
            Me.TreemapDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.TreemapDashboardItem1.ComponentName = "TreemapDashboardItem1"
            Measure2.DataMember = "Journal_Debit_Credit"
            Me.TreemapDashboardItem1.DataItemRepository.Clear()
            Me.TreemapDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.TreemapDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.TreemapDashboardItem1.DataSource = Me.DashboardObjectDataSource_Journal_Entries
            Me.TreemapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.TreemapDashboardItem1.Name = "Treemap 1"
            Me.TreemapDashboardItem1.ShowCaption = True
            Me.TreemapDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            '
            'Dashboard_Journal
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource_Journal_Entries})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.TreemapDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem1.Weight = 0.5R
            DashboardLayoutItem2.DashboardItem = Me.TreemapDashboardItem1
            DashboardLayoutItem2.Weight = 0.5R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardObjectDataSource_Journal_Entries, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TreemapDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardObjectDataSource_Journal_Entries As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents TreemapDashboardItem1 As DevExpress.DashboardCommon.TreemapDashboardItem

#End Region
    End Class
End Namespace