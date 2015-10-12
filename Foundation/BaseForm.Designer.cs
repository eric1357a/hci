namespace HCI.Foundation
{
    partial class BaseForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseTable = new System.Windows.Forms.TableLayoutPanel();
            this.BaseWindowBar = new System.Windows.Forms.Panel();
            this.BaseButtonHideWindow = new System.Windows.Forms.LinkLabel();
            this.BaseButtonCloseWindow = new System.Windows.Forms.LinkLabel();
            this.BaseNavigation = new System.Windows.Forms.Panel();
            this.BaseNavigationText = new System.Windows.Forms.LinkLabel();
            this.BaseContentPanel = new System.Windows.Forms.Panel();
            this.BaseContentWrapper = new System.Windows.Forms.Panel();
            this.BaseNavigationAction = new System.Windows.Forms.Panel();
            this.BaseTable.SuspendLayout();
            this.BaseWindowBar.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseTable
            // 
            this.BaseTable.AutoSize = true;
            this.BaseTable.ColumnCount = 1;
            this.BaseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseTable.Controls.Add(this.BaseWindowBar, 0, 0);
            this.BaseTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseTable.Location = new System.Drawing.Point(0, 0);
            this.BaseTable.Margin = new System.Windows.Forms.Padding(0);
            this.BaseTable.Name = "BaseTable";
            this.BaseTable.RowCount = 1;
            this.BaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.BaseTable.Size = new System.Drawing.Size(720, 44);
            this.BaseTable.TabIndex = 0;
            // 
            // BaseWindowBar
            // 
            this.BaseWindowBar.BackColor = System.Drawing.Color.Transparent;
            this.BaseWindowBar.Controls.Add(this.BaseButtonHideWindow);
            this.BaseWindowBar.Controls.Add(this.BaseButtonCloseWindow);
            this.BaseWindowBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseWindowBar.Location = new System.Drawing.Point(0, 0);
            this.BaseWindowBar.Margin = new System.Windows.Forms.Padding(0);
            this.BaseWindowBar.Name = "BaseWindowBar";
            this.BaseWindowBar.Size = new System.Drawing.Size(720, 44);
            this.BaseWindowBar.TabIndex = 0;
            this.BaseWindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseWindowActions_MouseDown);
            // 
            // BaseButtonHideWindow
            // 
            this.BaseButtonHideWindow.ActiveLinkColor = System.Drawing.Color.Black;
            this.BaseButtonHideWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaseButtonHideWindow.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.BaseButtonHideWindow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BaseButtonHideWindow.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(183)))));
            this.BaseButtonHideWindow.Location = new System.Drawing.Point(640, 0);
            this.BaseButtonHideWindow.Margin = new System.Windows.Forms.Padding(0);
            this.BaseButtonHideWindow.Name = "BaseButtonHideWindow";
            this.BaseButtonHideWindow.Size = new System.Drawing.Size(40, 44);
            this.BaseButtonHideWindow.TabIndex = 2;
            this.BaseButtonHideWindow.TabStop = true;
            this.BaseButtonHideWindow.Text = "_";
            this.BaseButtonHideWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BaseButtonHideWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BaseButtonHideWindow_LinkClicked);
            // 
            // BaseButtonCloseWindow
            // 
            this.BaseButtonCloseWindow.ActiveLinkColor = System.Drawing.Color.Black;
            this.BaseButtonCloseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaseButtonCloseWindow.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.BaseButtonCloseWindow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BaseButtonCloseWindow.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(183)))));
            this.BaseButtonCloseWindow.Location = new System.Drawing.Point(680, 0);
            this.BaseButtonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.BaseButtonCloseWindow.Name = "BaseButtonCloseWindow";
            this.BaseButtonCloseWindow.Size = new System.Drawing.Size(40, 44);
            this.BaseButtonCloseWindow.TabIndex = 1;
            this.BaseButtonCloseWindow.TabStop = true;
            this.BaseButtonCloseWindow.Text = "×";
            this.BaseButtonCloseWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BaseButtonCloseWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BaseButtonCloseWindow_LinkClicked);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Controls.Add(this.BaseNavigationAction);
            this.BaseNavigation.Controls.Add(this.BaseNavigationText);
            this.BaseNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseNavigation.Location = new System.Drawing.Point(0, 0);
            this.BaseNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.BaseNavigation.Name = "BaseNavigation";
            this.BaseNavigation.Size = new System.Drawing.Size(720, 54);
            this.BaseNavigation.TabIndex = 1;
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.ActiveLinkColor = System.Drawing.Color.Black;
            this.BaseNavigationText.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.BaseNavigationText.Dock = System.Windows.Forms.DockStyle.Left;
            this.BaseNavigationText.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.BaseNavigationText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(183)))));
            this.BaseNavigationText.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BaseNavigationText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(183)))));
            this.BaseNavigationText.Location = new System.Drawing.Point(0, 0);
            this.BaseNavigationText.Margin = new System.Windows.Forms.Padding(0);
            this.BaseNavigationText.Name = "BaseNavigationText";
            this.BaseNavigationText.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BaseNavigationText.Size = new System.Drawing.Size(336, 54);
            this.BaseNavigationText.TabIndex = 0;
            this.BaseNavigationText.TabStop = true;
            this.BaseNavigationText.Text = "Title";
            this.BaseNavigationText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.BaseContentWrapper);
            this.BaseContentPanel.Controls.Add(this.BaseNavigation);
            this.BaseContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseContentPanel.Location = new System.Drawing.Point(0, 44);
            this.BaseContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BaseContentPanel.Name = "BaseContentPanel";
            this.BaseContentPanel.Size = new System.Drawing.Size(720, 436);
            this.BaseContentPanel.TabIndex = 1;
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseContentWrapper.Location = new System.Drawing.Point(0, 54);
            this.BaseContentWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.BaseContentWrapper.Name = "BaseContentWrapper";
            this.BaseContentWrapper.Size = new System.Drawing.Size(720, 382);
            this.BaseContentWrapper.TabIndex = 2;
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaseNavigationAction.Location = new System.Drawing.Point(443, 0);
            this.BaseNavigationAction.Name = "BaseNavigationAction";
            this.BaseNavigationAction.Size = new System.Drawing.Size(277, 54);
            this.BaseNavigationAction.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.BaseContentPanel);
            this.Controls.Add(this.BaseTable);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(183)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.BaseTable.ResumeLayout(false);
            this.BaseWindowBar.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BaseTable;
        private System.Windows.Forms.Panel BaseWindowBar;
        private System.Windows.Forms.LinkLabel BaseButtonCloseWindow;
        private System.Windows.Forms.LinkLabel BaseButtonHideWindow;
        public System.Windows.Forms.LinkLabel BaseNavigationText;
        public System.Windows.Forms.Panel BaseContentPanel;
        public System.Windows.Forms.Panel BaseNavigation;
        public System.Windows.Forms.Panel BaseContentWrapper;
        public System.Windows.Forms.Panel BaseNavigationAction;
    }
}