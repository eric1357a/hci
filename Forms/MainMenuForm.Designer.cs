namespace HCI.Forms
{
    partial class MainMenuForm
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
            this.btn_view = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.MainMenuControlsWrapper = new System.Windows.Forms.Panel();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.MainMenuControlsWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.BaseNavigationText.Text = "Menu";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.MainMenuControlsWrapper);
            this.BaseContentPanel.Size = new System.Drawing.Size(642, 389);
            this.BaseContentPanel.Controls.SetChildIndex(this.BaseContentWrapper, 0);
            this.BaseContentPanel.Controls.SetChildIndex(this.BaseNavigation, 0);
            this.BaseContentPanel.Controls.SetChildIndex(this.MainMenuControlsWrapper, 0);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Size = new System.Drawing.Size(642, 66);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Location = new System.Drawing.Point(0, 0);
            this.BaseContentWrapper.Size = new System.Drawing.Size(642, 389);
            // 
            // btn_view
            // 
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Location = new System.Drawing.Point(141, 40);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(336, 105);
            this.btn_view.TabIndex = 0;
            this.btn_view.Text = "View Course Details";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_viewcourse_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(141, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(336, 105);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search Courses";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainMenuControlsWrapper
            // 
            this.MainMenuControlsWrapper.Controls.Add(this.btnSearch);
            this.MainMenuControlsWrapper.Controls.Add(this.btn_view);
            this.MainMenuControlsWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuControlsWrapper.Location = new System.Drawing.Point(0, 66);
            this.MainMenuControlsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenuControlsWrapper.Name = "MainMenuControlsWrapper";
            this.MainMenuControlsWrapper.Size = new System.Drawing.Size(642, 323);
            this.MainMenuControlsWrapper.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(642, 443);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.MainMenuControlsWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel MainMenuControlsWrapper;
    }
}