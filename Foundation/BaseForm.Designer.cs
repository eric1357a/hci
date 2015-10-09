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
            this.BaseHeader = new System.Windows.Forms.TableLayoutPanel();
            this.BaseMenuActions = new System.Windows.Forms.Panel();
            this.BaseNavigation = new System.Windows.Forms.Panel();
            this.BaseNavigationText = new System.Windows.Forms.LinkLabel();
            this.BaseContentPanel = new System.Windows.Forms.Panel();
            this.BaseTable.SuspendLayout();
            this.BaseWindowBar.SuspendLayout();
            this.BaseHeader.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseTable
            // 
            this.BaseTable.AutoSize = true;
            this.BaseTable.ColumnCount = 1;
            this.BaseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseTable.Controls.Add(this.BaseWindowBar, 0, 0);
            this.BaseTable.Controls.Add(this.BaseHeader, 0, 1);
            this.BaseTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseTable.Location = new System.Drawing.Point(0, 0);
            this.BaseTable.Margin = new System.Windows.Forms.Padding(0);
            this.BaseTable.Name = "BaseTable";
            this.BaseTable.RowCount = 2;
            this.BaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.BaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.BaseTable.Size = new System.Drawing.Size(720, 120);
            this.BaseTable.TabIndex = 0;
            // 
            // BaseWindowBar
            // 
            this.BaseWindowBar.AutoSize = true;
            this.BaseWindowBar.BackColor = System.Drawing.Color.Transparent;
            this.BaseWindowBar.Controls.Add(this.BaseButtonHideWindow);
            this.BaseWindowBar.Controls.Add(this.BaseButtonCloseWindow);
            this.BaseWindowBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseWindowBar.Location = new System.Drawing.Point(0, 0);
            this.BaseWindowBar.Margin = new System.Windows.Forms.Padding(0);
            this.BaseWindowBar.Name = "BaseWindowBar";
            this.BaseWindowBar.Size = new System.Drawing.Size(720, 54);
            this.BaseWindowBar.TabIndex = 0;
            this.BaseWindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseWindowActions_MouseDown);
            // 
            // BaseButtonHideWindow
            // 
            this.BaseButtonHideWindow.ActiveLinkColor = System.Drawing.Color.MediumPurple;
            this.BaseButtonHideWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaseButtonHideWindow.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BaseButtonHideWindow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BaseButtonHideWindow.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.BaseButtonHideWindow.Location = new System.Drawing.Point(608, 0);
            this.BaseButtonHideWindow.Margin = new System.Windows.Forms.Padding(0);
            this.BaseButtonHideWindow.Name = "BaseButtonHideWindow";
            this.BaseButtonHideWindow.Size = new System.Drawing.Size(56, 54);
            this.BaseButtonHideWindow.TabIndex = 2;
            this.BaseButtonHideWindow.TabStop = true;
            this.BaseButtonHideWindow.Text = "_";
            this.BaseButtonHideWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BaseButtonHideWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BaseButtonHideWindow_LinkClicked);
            // 
            // BaseButtonCloseWindow
            // 
            this.BaseButtonCloseWindow.ActiveLinkColor = System.Drawing.Color.MediumPurple;
            this.BaseButtonCloseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaseButtonCloseWindow.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BaseButtonCloseWindow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BaseButtonCloseWindow.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.BaseButtonCloseWindow.Location = new System.Drawing.Point(664, 0);
            this.BaseButtonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.BaseButtonCloseWindow.Name = "BaseButtonCloseWindow";
            this.BaseButtonCloseWindow.Size = new System.Drawing.Size(56, 54);
            this.BaseButtonCloseWindow.TabIndex = 1;
            this.BaseButtonCloseWindow.TabStop = true;
            this.BaseButtonCloseWindow.Text = "×";
            this.BaseButtonCloseWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BaseButtonCloseWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BaseButtonCloseWindow_LinkClicked);
            // 
            // BaseHeader
            // 
            this.BaseHeader.BackColor = System.Drawing.Color.Transparent;
            this.BaseHeader.ColumnCount = 2;
            this.BaseHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.BaseHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BaseHeader.Controls.Add(this.BaseMenuActions, 1, 0);
            this.BaseHeader.Controls.Add(this.BaseNavigation, 0, 0);
            this.BaseHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseHeader.Location = new System.Drawing.Point(0, 54);
            this.BaseHeader.Margin = new System.Windows.Forms.Padding(0);
            this.BaseHeader.Name = "BaseHeader";
            this.BaseHeader.RowCount = 1;
            this.BaseHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseHeader.Size = new System.Drawing.Size(720, 66);
            this.BaseHeader.TabIndex = 2;
            // 
            // BaseMenuActions
            // 
            this.BaseMenuActions.AutoSize = true;
            this.BaseMenuActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseMenuActions.Location = new System.Drawing.Point(400, 0);
            this.BaseMenuActions.Margin = new System.Windows.Forms.Padding(0);
            this.BaseMenuActions.Name = "BaseMenuActions";
            this.BaseMenuActions.Size = new System.Drawing.Size(320, 66);
            this.BaseMenuActions.TabIndex = 0;
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Controls.Add(this.BaseNavigationText);
            this.BaseNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseNavigation.Location = new System.Drawing.Point(0, 0);
            this.BaseNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.BaseNavigation.Name = "BaseNavigation";
            this.BaseNavigation.Size = new System.Drawing.Size(400, 66);
            this.BaseNavigation.TabIndex = 1;
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.ActiveLinkColor = System.Drawing.Color.MediumPurple;
            this.BaseNavigationText.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.BaseNavigationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseNavigationText.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BaseNavigationText.ForeColor = System.Drawing.Color.White;
            this.BaseNavigationText.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BaseNavigationText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.BaseNavigationText.Location = new System.Drawing.Point(0, 0);
            this.BaseNavigationText.Margin = new System.Windows.Forms.Padding(0);
            this.BaseNavigationText.Name = "BaseNavigationText";
            this.BaseNavigationText.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BaseNavigationText.Size = new System.Drawing.Size(400, 66);
            this.BaseNavigationText.TabIndex = 0;
            this.BaseNavigationText.TabStop = true;
            this.BaseNavigationText.Text = "Title";
            this.BaseNavigationText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseContentPanel.Location = new System.Drawing.Point(0, 120);
            this.BaseContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BaseContentPanel.Name = "BaseContentPanel";
            this.BaseContentPanel.Size = new System.Drawing.Size(720, 360);
            this.BaseContentPanel.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.BaseContentPanel);
            this.Controls.Add(this.BaseTable);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.BaseTable.ResumeLayout(false);
            this.BaseTable.PerformLayout();
            this.BaseWindowBar.ResumeLayout(false);
            this.BaseHeader.ResumeLayout(false);
            this.BaseHeader.PerformLayout();
            this.BaseNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BaseTable;
        private System.Windows.Forms.Panel BaseWindowBar;
        private System.Windows.Forms.TableLayoutPanel BaseHeader;
        private System.Windows.Forms.Panel BaseNavigation;
        private System.Windows.Forms.LinkLabel BaseButtonCloseWindow;
        private System.Windows.Forms.LinkLabel BaseButtonHideWindow;
        public System.Windows.Forms.LinkLabel BaseNavigationText;
        public System.Windows.Forms.Panel BaseContentPanel;
        public System.Windows.Forms.Panel BaseMenuActions;
    }
}