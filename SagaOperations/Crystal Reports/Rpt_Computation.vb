﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System
Imports System.ComponentModel


Public Class Rpt_Computation
    Inherits ReportClass

    Public Sub New()
        MyBase.New
    End Sub

    Public Overrides Property ResourceName() As String
        Get
            Return "Rpt_Computation.rpt"
        End Get
        Set
            'Do nothing
        End Set
    End Property

    Public Overrides Property NewGenerator() As Boolean
        Get
            Return true
        End Get
        Set
            'Do nothing
        End Set
    End Property

    Public Overrides Property FullResourceName() As String
        Get
            Return "IntegratedSystems.Rpt_Computation.rpt"
        End Get
        Set
            'Do nothing
        End Set
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property ReportHeaderSection1() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(0)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property PageHeaderSection1() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(1)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property DetailSection1() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(2)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property ReportFooterSection1() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(3)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property PageFooterSection1() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(4)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_BranchName() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(0)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_RefNo() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(1)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_AccountName() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(2)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_AccountAddress() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(3)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_Brand() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(4)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_Model() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(5)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_EngineNo() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(6)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_ChassisNo() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(7)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_Color() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(8)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_Terms() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(9)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_AmountPaid() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(10)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_AOC() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(11)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_LCP() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(12)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_FinancedAmount() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(13)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_TotalInterest() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(14)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_OutstandingBalance() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(15)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_PMT() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(16)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_MaturityDate() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(17)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_FirstPaymentDate() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(18)
        End Get
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property Parameter_DateGranted() As CrystalDecisions.[Shared].IParameterField
        Get
            Return Me.DataDefinition.ParameterFields(19)
        End Get
    End Property
End Class

<System.Drawing.ToolboxBitmapAttribute(GetType(CrystalDecisions.[Shared].ExportOptions), "report.bmp")> _
Public Class CachedRpt_Computation
    Inherits Component
    Implements ICachedReport

    Public Sub New()
        MyBase.New
    End Sub

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Overridable Property IsCacheable() As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
        Get
            Return true
        End Get
        Set
            '
        End Set
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Overridable Property ShareDBLogonInfo() As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
        Get
            Return false
        End Get
        Set
            '
        End Set
    End Property

    <Browsable(false), _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Overridable Property CacheTimeOut() As System.TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
        Get
            Return CachedReportConstants.DEFAULT_TIMEOUT
        End Get
        Set
            '
        End Set
    End Property

    Public Overridable Function CreateReport() As CrystalDecisions.CrystalReports.Engine.ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
        Dim rpt As Rpt_Computation = New Rpt_Computation()
        rpt.Site = Me.Site
        Return rpt
    End Function

    Public Overridable Function GetCustomizedCacheKey(ByVal request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
        Dim key As [String] = Nothing
        '// The following is the code used to generate the default
        '// cache key for caching report jobs in the ASP.NET Cache.
        '// Feel free to modify this code to suit your needs.
        '// Returning key == null causes the default cache key to
        '// be generated.
        '
        'key = RequestContext.BuildCompleteCacheKey(
        '    request,
        '    null,       // sReportFilename
        '    this.GetType(),
        '    this.ShareDBLogonInfo );
        Return key
    End Function
End Class
