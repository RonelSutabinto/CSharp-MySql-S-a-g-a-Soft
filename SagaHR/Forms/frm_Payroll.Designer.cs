using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaHR.Forms
{
    public partial class frm_Payroll : DevExpress.XtraEditors.XtraForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        private void InitializeComponent()
        {
            BarManager = new DevExpress.XtraBars.BarManager();
            Bar1 = new DevExpress.XtraBars.Bar();
            btn_Save = new DevExpress.XtraBars.BarButtonItem();
            btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(btn_Save_ItemClick);
            btn_Save_Close = new DevExpress.XtraBars.BarButtonItem();
            btn_Save_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(btn_Save_Close_ItemClick);
            btn_Close = new DevExpress.XtraBars.BarButtonItem();
            btn_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(btn_Close_ItemClick);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            xuc_Payroll = new Controls.xuc_Payroll();
            ((System.ComponentModel.ISupportInitialize)BarManager).BeginInit();
            SuspendLayout();
            // 
            // BarManager
            // 
            BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { Bar1 });
            BarManager.DockControls.Add(barDockControlTop);
            BarManager.DockControls.Add(barDockControlBottom);
            BarManager.DockControls.Add(barDockControlLeft);
            BarManager.DockControls.Add(barDockControlRight);
            BarManager.Form = this;
            BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btn_Save, btn_Close, btn_Save_Close });
            BarManager.MaxItemId = 3;
            // 
            // Bar1
            // 
            Bar1.BarName = "Tools";
            Bar1.DockCol = 0;
            Bar1.DockRow = 0;
            Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btn_Save), new DevExpress.XtraBars.LinkPersistInfo(btn_Save_Close), new DevExpress.XtraBars.LinkPersistInfo(btn_Close) });
            Bar1.Text = "Tools";
            // 
            // btn_Save
            // 
            btn_Save.Caption = "Save";
            btn_Save.Id = 0;
            btn_Save.Name = "btn_Save";
            // 
            // btn_Save_Close
            // 
            btn_Save_Close.Caption = "Save and Close";
            btn_Save_Close.Id = 2;
            btn_Save_Close.Name = "btn_Save_Close";
            // 
            // btn_Close
            // 
            btn_Close.Caption = "Close";
            btn_Close.Id = 1;
            btn_Close.Name = "btn_Close";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = BarManager;
            barDockControlTop.Size = new System.Drawing.Size(300, 29);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 448);
            barDockControlBottom.Manager = BarManager;
            barDockControlBottom.Size = new System.Drawing.Size(300, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            barDockControlLeft.Manager = BarManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(300, 29);
            barDockControlRight.Manager = BarManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // xuc_Payroll
            // 
            xuc_Payroll.Dock = System.Windows.Forms.DockStyle.Fill;
            xuc_Payroll.Location = new System.Drawing.Point(0, 29);
            xuc_Payroll.Name = "xuc_Payroll";
            xuc_Payroll.Size = new System.Drawing.Size(300, 419);
            xuc_Payroll.TabIndex = 4;
            // 
            // frm_Payroll
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 448);
            Controls.Add(xuc_Payroll);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frm_Payroll";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)BarManager).EndInit();
            Load += new EventHandler(frm_Payroll_Load);
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(frm_Payroll_FormClosing);
            ResumeLayout(false);
            PerformLayout();
        }

        internal DevExpress.XtraBars.BarManager BarManager;
        internal DevExpress.XtraBars.Bar Bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Save;
        private DevExpress.XtraBars.BarButtonItem btn_Save_Close;
        private DevExpress.XtraBars.BarButtonItem btn_Close;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        internal Controls.xuc_Payroll xuc_Payroll;
    }
}