Partial Friend Class Dashboard_Main
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Dim dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim columnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_Main))
        Dim dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim chartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
        Dim simpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
        Dim dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim measure5 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim measure6 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim measure7 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim dashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
        Dim dashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
        Dim dashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim dashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim dashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim dashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
        Dim dashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim dashboardLayoutItem5 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim dashboardLayoutItem6 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
        Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
        Me.pivotDashboardItem2 = New DevExpress.DashboardCommon.PivotDashboardItem()
        Me.chartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
        Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
        Me.pieDashboardItem3 = New DevExpress.DashboardCommon.PieDashboardItem()
        Me.pieDashboardItem2 = New DevExpress.DashboardCommon.PieDashboardItem()
        CType((Me.pivotDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((dimension1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((measure1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((measure2), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((measure3), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.dashboardSqlDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.pivotDashboardItem2), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((dimension2), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.chartDashboardItem2), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((dimension3), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((measure4), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((dimension4), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.pieDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((dimension5), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((measure5), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.pieDashboardItem3), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((dimension6), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((measure6), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.pieDashboardItem2), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((dimension7), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((measure7), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
        dimension1.DataMember = "Branch"
        measure1.DataMember = "InterestBalance"
        measure1.Name = "Interest (Sum)"
        measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
        measure1.NumericFormat.IncludeGroupSeparator = True
        measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
        dimension1.SortByMeasure = measure1
        dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
        measure2.DataMember = "PrincipalBalance"
        measure2.Name = "Principal (Sum)"
        measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
        measure2.NumericFormat.IncludeGroupSeparator = True
        measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
        measure3.DataMember = "OutstandingBalance"
        measure3.Name = "Outstanding (Sum)"
        measure3.NumericFormat.CurrencyCultureName = "en-PH"
        measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
        measure3.NumericFormat.IncludeGroupSeparator = True
        measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
        Me.pivotDashboardItem1.DataItemRepository.Clear()
        Me.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
        Me.pivotDashboardItem1.DataItemRepository.Add(measure2, "DataItem1")
        Me.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem2")
        Me.pivotDashboardItem1.DataItemRepository.Add(measure3, "DataItem3")
        Me.pivotDashboardItem1.DataMember = "CustAccount"
        Me.pivotDashboardItem1.DataSource = Me.dashboardSqlDataSource1
        Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
        Me.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
        Me.pivotDashboardItem1.Name = "Accounts Receivable"
        Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension1})
        Me.pivotDashboardItem1.ShowCaption = True
        Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {measure2, measure1, measure3})
        Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
        Me.dashboardSqlDataSource1.ConnectionName = "ics.ICS.dbo"
        Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
        columnExpression1.ColumnName = "BranchCode"
        table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""837"" />"
        table1.Name = "view_Payment_Transactions"
        columnExpression1.Table = table1
        column1.Expression = columnExpression1
        columnExpression2.ColumnName = "Branch"
        columnExpression2.Table = table1
        column2.Expression = columnExpression2
        columnExpression3.ColumnName = "AccountNumber"
        columnExpression3.Table = table1
        column3.Expression = columnExpression3
        columnExpression4.ColumnName = "LedgerSetNumber"
        columnExpression4.Table = table1
        column4.Expression = columnExpression4
        columnExpression5.ColumnName = "AccountName"
        columnExpression5.Table = table1
        column5.Expression = columnExpression5
        columnExpression6.ColumnName = "AccountStatus"
        columnExpression6.Table = table1
        column6.Expression = columnExpression6
        columnExpression7.ColumnName = "Brand"
        columnExpression7.Table = table1
        column7.Expression = columnExpression7
        columnExpression8.ColumnName = "Principal"
        columnExpression8.Table = table1
        column8.Expression = columnExpression8
        columnExpression9.ColumnName = "Interest"
        columnExpression9.Table = table1
        column9.Expression = columnExpression9
        columnExpression10.ColumnName = "AmountPaid"
        columnExpression10.Table = table1
        column10.Expression = columnExpression10
        columnExpression11.ColumnName = "PrincipalBalance"
        columnExpression11.Table = table1
        column11.Expression = columnExpression11
        columnExpression12.ColumnName = "InterestBalance"
        columnExpression12.Table = table1
        column12.Expression = columnExpression12
        selectQuery1.Columns.Add(column1)
        selectQuery1.Columns.Add(column2)
        selectQuery1.Columns.Add(column3)
        selectQuery1.Columns.Add(column4)
        selectQuery1.Columns.Add(column5)
        selectQuery1.Columns.Add(column6)
        selectQuery1.Columns.Add(column7)
        selectQuery1.Columns.Add(column8)
        selectQuery1.Columns.Add(column9)
        selectQuery1.Columns.Add(column10)
        selectQuery1.Columns.Add(column11)
        selectQuery1.Columns.Add(column12)
        selectQuery1.Name = "view_Payment_Transactions"
        selectQuery1.Tables.Add(table1)
        columnExpression13.ColumnName = "BranchCode"
        table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""1084"" />"
        table2.Name = "CustAccount"
        columnExpression13.Table = table2
        column13.Expression = columnExpression13
        columnExpression14.ColumnName = "Branch"
        table3.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""153"" />"
        table3.Name = "BranchParameters"
        columnExpression14.Table = table3
        column14.Expression = columnExpression14
        columnExpression15.ColumnName = "AccountNumber"
        columnExpression15.Table = table2
        column15.Expression = columnExpression15
        columnExpression16.ColumnName = "AccountName"
        columnExpression16.Table = table2
        column16.Expression = columnExpression16
        columnExpression17.ColumnName = "whCode"
        columnExpression17.Table = table2
        column17.Expression = columnExpression17
        columnExpression18.ColumnName = "Brand"
        columnExpression18.Table = table2
        column18.Expression = columnExpression18
        columnExpression19.ColumnName = "SaleType"
        columnExpression19.Table = table2
        column19.Expression = columnExpression19
        columnExpression20.ColumnName = "PrincipalBalance"
        columnExpression20.Table = table2
        column20.Expression = columnExpression20
        columnExpression21.ColumnName = "InterestBalance"
        columnExpression21.Table = table2
        column21.Expression = columnExpression21
        columnExpression22.ColumnName = "ReleaseType"
        columnExpression22.Table = table2
        column22.Expression = columnExpression22
        columnExpression23.ColumnName = "sequenceNo"
        columnExpression23.Table = table2
        column23.Expression = columnExpression23
        columnExpression24.ColumnName = "AccountStatus"
        columnExpression24.Table = table2
        column24.Expression = columnExpression24
        columnExpression25.ColumnName = "OutstandingBalance"
        columnExpression25.Table = table2
        column25.Expression = columnExpression25
        selectQuery2.Columns.Add(column13)
        selectQuery2.Columns.Add(column14)
        selectQuery2.Columns.Add(column15)
        selectQuery2.Columns.Add(column16)
        selectQuery2.Columns.Add(column17)
        selectQuery2.Columns.Add(column18)
        selectQuery2.Columns.Add(column19)
        selectQuery2.Columns.Add(column20)
        selectQuery2.Columns.Add(column21)
        selectQuery2.Columns.Add(column22)
        selectQuery2.Columns.Add(column23)
        selectQuery2.Columns.Add(column24)
        selectQuery2.Columns.Add(column25)
        selectQuery2.Name = "CustAccount"
        relationColumnInfo1.NestedKeyColumn = "BranchCode"
        relationColumnInfo1.ParentKeyColumn = "BranchCode"
        join1.KeyColumns.Add(relationColumnInfo1)
        join1.Nested = table3
        join1.Parent = table2
        selectQuery2.Relations.Add(join1)
        columnExpression26.ColumnName = "sequenceNo"
        columnExpression26.Table = table2
        sorting1.Expression = columnExpression26
        selectQuery2.Sorting.Add(sorting1)
        selectQuery2.Tables.Add(table2)
        selectQuery2.Tables.Add(table3)
        Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2})
        Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
        Me.pivotDashboardItem2.ComponentName = "pivotDashboardItem2"
        dimension2.DataMember = "Branch"
        Me.pivotDashboardItem2.DataItemRepository.Clear()
        Me.pivotDashboardItem2.DataItemRepository.Add(dimension2, "DataItem0")
        Me.pivotDashboardItem2.DataMember = "view_Payment_Transactions"
        Me.pivotDashboardItem2.DataSource = Me.dashboardSqlDataSource1
        Me.pivotDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
        Me.pivotDashboardItem2.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
        Me.pivotDashboardItem2.Name = "Collections"
        Me.pivotDashboardItem2.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension2})
        Me.pivotDashboardItem2.ShowCaption = True
        dimension3.DataMember = "Branch"
        Me.chartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension3})
        Me.chartDashboardItem2.AxisX.TitleVisible = False
        Me.chartDashboardItem2.ComponentName = "chartDashboardItem2"
        measure4.DataMember = "AccountNumber"
        measure4.Name = "Accounts (Count Distinct)"
        measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
        dimension4.DataMember = "AccountStatus"
        Me.chartDashboardItem2.DataItemRepository.Clear()
        Me.chartDashboardItem2.DataItemRepository.Add(dimension3, "DataItem0")
        Me.chartDashboardItem2.DataItemRepository.Add(measure4, "DataItem1")
        Me.chartDashboardItem2.DataItemRepository.Add(dimension4, "DataItem2")
        Me.chartDashboardItem2.DataMember = "CustAccount"
        Me.chartDashboardItem2.DataSource = Me.dashboardSqlDataSource1
        Me.chartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
        Me.chartDashboardItem2.Name = "Customers"
        chartPane1.Name = "Pane 1"
        chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
        chartPane1.PrimaryAxisY.ShowGridLines = True
        chartPane1.PrimaryAxisY.TitleVisible = True
        chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
        chartPane1.SecondaryAxisY.ShowGridLines = False
        chartPane1.SecondaryAxisY.TitleVisible = True
        simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
        simpleSeries1.AddDataItem("Value", measure4)
        chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {simpleSeries1})
        Me.chartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {chartPane1})
        Me.chartDashboardItem2.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension4})
        Me.chartDashboardItem2.ShowCaption = True
        dimension5.DataMember = "whCode"
        Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension5})
        Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
        measure5.DataMember = "whCode"
        measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
        Me.pieDashboardItem1.DataItemRepository.Clear()
        Me.pieDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0")
        Me.pieDashboardItem1.DataItemRepository.Add(measure5, "DataItem1")
        Me.pieDashboardItem1.DataMember = "CustAccount"
        Me.pieDashboardItem1.DataSource = Me.dashboardSqlDataSource1
        Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
        Me.pieDashboardItem1.Name = "Warehouse"
        Me.pieDashboardItem1.ShowCaption = True
        Me.pieDashboardItem1.ShowPieCaptions = False
        Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {measure5})
        dimension6.DataMember = "SaleType"
        Me.pieDashboardItem3.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension6})
        Me.pieDashboardItem3.ComponentName = "pieDashboardItem3"
        measure6.DataMember = "SaleType"
        measure6.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
        Me.pieDashboardItem3.DataItemRepository.Clear()
        Me.pieDashboardItem3.DataItemRepository.Add(measure6, "DataItem0")
        Me.pieDashboardItem3.DataItemRepository.Add(dimension6, "DataItem1")
        Me.pieDashboardItem3.DataMember = "CustAccount"
        Me.pieDashboardItem3.DataSource = Me.dashboardSqlDataSource1
        Me.pieDashboardItem3.InteractivityOptions.IgnoreMasterFilters = False
        Me.pieDashboardItem3.Name = "Sales"
        Me.pieDashboardItem3.ShowCaption = True
        Me.pieDashboardItem3.ShowPieCaptions = False
        Me.pieDashboardItem3.Values.AddRange(New DevExpress.DashboardCommon.Measure() {measure6})
        dimension7.DataMember = "Brand"
        Me.pieDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension7})
        Me.pieDashboardItem2.ComponentName = "pieDashboardItem2"
        measure7.DataMember = "Brand"
        measure7.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
        Me.pieDashboardItem2.DataItemRepository.Clear()
        Me.pieDashboardItem2.DataItemRepository.Add(measure7, "DataItem0")
        Me.pieDashboardItem2.DataItemRepository.Add(dimension7, "DataItem1")
        Me.pieDashboardItem2.DataMember = "CustAccount"
        Me.pieDashboardItem2.DataSource = Me.dashboardSqlDataSource1
        Me.pieDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
        Me.pieDashboardItem2.Name = "Brand by Sales"
        Me.pieDashboardItem2.ShowCaption = True
        Me.pieDashboardItem2.Values.AddRange(New DevExpress.DashboardCommon.Measure() {measure7})
        Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
        Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.pieDashboardItem1, Me.pieDashboardItem3, Me.pieDashboardItem2, Me.chartDashboardItem2, Me.pivotDashboardItem1, Me.pivotDashboardItem2})
        dashboardLayoutItem1.DashboardItem = Me.pivotDashboardItem1
        dashboardLayoutItem1.Weight = 35.775862068965516R
        dashboardLayoutItem2.DashboardItem = Me.pivotDashboardItem2
        dashboardLayoutItem2.Weight = 17.5R
        dashboardLayoutItem3.DashboardItem = Me.chartDashboardItem2
        dashboardLayoutItem3.Weight = 46.724137931034484R
        dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutItem1, dashboardLayoutItem2, dashboardLayoutItem3})
        dashboardLayoutGroup2.DashboardItem = Nothing
        dashboardLayoutGroup2.Weight = 50.316055625790142R
        dashboardLayoutItem4.DashboardItem = Me.pieDashboardItem1
        dashboardLayoutItem4.Weight = 31.896551724137932R
        dashboardLayoutItem5.DashboardItem = Me.pieDashboardItem3
        dashboardLayoutItem5.Weight = 31.896551724137932R
        dashboardLayoutItem6.DashboardItem = Me.pieDashboardItem2
        dashboardLayoutItem6.Weight = 36.206896551724135R
        dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutItem4, dashboardLayoutItem5, dashboardLayoutItem6})
        dashboardLayoutGroup3.DashboardItem = Nothing
        dashboardLayoutGroup3.Weight = 49.683944374209858R
        dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutGroup2, dashboardLayoutGroup3})
        dashboardLayoutGroup1.DashboardItem = Nothing
        dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
        Me.LayoutRoot = dashboardLayoutGroup1
        Me.Title.Text = "Dashboard"
        CType((measure1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((dimension1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((measure2), System.ComponentModel.ISupportInitialize).EndInit()
        CType((measure3), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.pivotDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.dashboardSqlDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((dimension2), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.pivotDashboardItem2), System.ComponentModel.ISupportInitialize).EndInit()
        CType((dimension3), System.ComponentModel.ISupportInitialize).EndInit()
        CType((measure4), System.ComponentModel.ISupportInitialize).EndInit()
        CType((dimension4), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.chartDashboardItem2), System.ComponentModel.ISupportInitialize).EndInit()
        CType((dimension5), System.ComponentModel.ISupportInitialize).EndInit()
        CType((measure5), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.pieDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((dimension6), System.ComponentModel.ISupportInitialize).EndInit()
        CType((measure6), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.pieDashboardItem3), System.ComponentModel.ISupportInitialize).EndInit()
        CType((dimension7), System.ComponentModel.ISupportInitialize).EndInit()
        CType((measure7), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.pieDashboardItem2), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
    End Sub

    Private dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
    Private pieDashboardItem2 As DevExpress.DashboardCommon.PieDashboardItem
    Private chartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
    Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
    Private pieDashboardItem3 As DevExpress.DashboardCommon.PieDashboardItem
    Private pivotDashboardItem2 As DevExpress.DashboardCommon.PivotDashboardItem
    Private pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
End Class

