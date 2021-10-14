using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MyClassLibrary.Forms
{
    [DesignerGenerated()]
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            ImageCollection16 = new DevExpress.Utils.ImageCollection(components);
            _AlertControl = new DevExpress.XtraBars.Alerter.AlertControl(components);
            _AlertControl.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(AlertControl_AlertClick);
            PopupMenu = new DevExpress.XtraBars.PopupMenu(components);
            BarManager = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ToastNotificationsManager = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            ((System.ComponentModel.ISupportInitialize)ImageCollection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PopupMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ToastNotificationsManager).BeginInit();
            SuspendLayout();
            // 
            // ImageCollection16
            // 
            ImageCollection16.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("ImageCollection16.ImageStream");
            ImageCollection16.Images.SetKeyName(0, "managedatasource_16x16.png");
            ImageCollection16.Images.SetKeyName(1, "info_16x16.png");
            ImageCollection16.Images.SetKeyName(2, "warning_16x16.png");
            ImageCollection16.Images.SetKeyName(3, "cancel_16x16.png");
            ImageCollection16.Images.SetKeyName(4, "add_16x16.png");
            ImageCollection16.Images.SetKeyName(5, "apply_16x16.png");
            ImageCollection16.Images.SetKeyName(6, "remove_16x16.png");
            // 
            // AlertControl
            // 
            _AlertControl.AllowHotTrack = false;
            _AlertControl.AutoHeight = true;
            _AlertControl.Images = ImageCollection16;
            _AlertControl.PopupMenu = PopupMenu;
            // 
            // PopupMenu
            // 
            PopupMenu.Manager = BarManager;
            PopupMenu.Name = "PopupMenu";
            // 
            // BarManager
            // 
            BarManager.DockControls.Add(barDockControlTop);
            BarManager.DockControls.Add(barDockControlBottom);
            BarManager.DockControls.Add(barDockControlLeft);
            BarManager.DockControls.Add(barDockControlRight);
            BarManager.Form = this;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = BarManager;
            barDockControlTop.Size = new Size(290, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 268);
            barDockControlBottom.Manager = BarManager;
            barDockControlBottom.Size = new Size(290, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = BarManager;
            barDockControlLeft.Size = new Size(0, 268);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(290, 0);
            barDockControlRight.Manager = BarManager;
            barDockControlRight.Size = new Size(0, 268);
            // 
            // ToastNotificationsManager
            // 
            ToastNotificationsManager.ApplicationId = "53af1649-0266-4746-9ade-de5681f823dc";
            ToastNotificationsManager.ApplicationName = "SagaAccounting";
            ToastNotificationsManager.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] { new DevExpress.XtraBars.ToastNotifications.ToastNotification("7cb9ef5b-6ed8-4a1f-8f07-b1f6d3c94ca8", null, "Header", "Body", "Body2", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text02) });
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 268);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "XtraForm1";
            Text = "XtraForm1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)ImageCollection16).EndInit();
            ((System.ComponentModel.ISupportInitialize)PopupMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)ToastNotificationsManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DevExpress.XtraBars.Alerter.AlertControl _AlertControl;

        public DevExpress.XtraBars.Alerter.AlertControl AlertControl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AlertControl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AlertControl != null)
                {
                    _AlertControl.AlertClick -= AlertControl_AlertClick;
                }

                _AlertControl = value;
                if (_AlertControl != null)
                {
                    _AlertControl.AlertClick += AlertControl_AlertClick;
                }
            }
        }

        public DevExpress.XtraBars.PopupMenu PopupMenu;
        public DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager ToastNotificationsManager;
        public DevExpress.Utils.ImageCollection ImageCollection16;
        internal DevExpress.XtraBars.BarManager BarManager;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}