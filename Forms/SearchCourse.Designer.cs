namespace HCI.Forms
{
    partial class SearchCourse
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
            this.panel_searchBox = new System.Windows.Forms.Panel();
            this.tb_searchText = new System.Windows.Forms.TextBox();
            this.cb_searchWhat = new System.Windows.Forms.ComboBox();
            this.lbl_PlaceHolding = new System.Windows.Forms.Label();
            this.lb_searchDesc = new System.Windows.Forms.Label();
            this.lb_searchResult = new System.Windows.Forms.ListBox();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.panel_searchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Search Course";
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.lb_searchResult);
            this.BaseContentWrapper.Controls.Add(this.lb_searchDesc);
            this.BaseContentWrapper.Controls.Add(this.panel_searchBox);
            // 
            // panel_searchBox
            // 
            this.panel_searchBox.Controls.Add(this.tb_searchText);
            this.panel_searchBox.Controls.Add(this.cb_searchWhat);
            this.panel_searchBox.Controls.Add(this.lbl_PlaceHolding);
            this.panel_searchBox.Location = new System.Drawing.Point(54, 166);
            this.panel_searchBox.Name = "panel_searchBox";
            this.panel_searchBox.Size = new System.Drawing.Size(626, 70);
            this.panel_searchBox.TabIndex = 14;
            // 
            // tb_searchText
            // 
            this.tb_searchText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tb_searchText.Location = new System.Drawing.Point(261, 20);
            this.tb_searchText.Multiline = true;
            this.tb_searchText.Name = "tb_searchText";
            this.tb_searchText.ShortcutsEnabled = false;
            this.tb_searchText.Size = new System.Drawing.Size(328, 29);
            this.tb_searchText.TabIndex = 21;
            this.tb_searchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_searchText_KeyUp);
            // 
            // cb_searchWhat
            // 
            this.cb_searchWhat.BackColor = System.Drawing.Color.White;
            this.cb_searchWhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_searchWhat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_searchWhat.FormattingEnabled = true;
            this.cb_searchWhat.Items.AddRange(new object[] {
            "Price",
            "Price Range",
            "Available Places (AP)",
            "AP for Day Of Week"});
            this.cb_searchWhat.Location = new System.Drawing.Point(41, 20);
            this.cb_searchWhat.Name = "cb_searchWhat";
            this.cb_searchWhat.Size = new System.Drawing.Size(214, 31);
            this.cb_searchWhat.TabIndex = 20;
            // 
            // lbl_PlaceHolding
            // 
            this.lbl_PlaceHolding.AutoSize = true;
            this.lbl_PlaceHolding.Location = new System.Drawing.Point(37, 40);
            this.lbl_PlaceHolding.Name = "lbl_PlaceHolding";
            this.lbl_PlaceHolding.Size = new System.Drawing.Size(0, 23);
            this.lbl_PlaceHolding.TabIndex = 5;
            // 
            // lb_searchDesc
            // 
            this.lb_searchDesc.AutoSize = true;
            this.lb_searchDesc.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lb_searchDesc.Location = new System.Drawing.Point(261, 108);
            this.lb_searchDesc.Name = "lb_searchDesc";
            this.lb_searchDesc.Size = new System.Drawing.Size(221, 30);
            this.lb_searchDesc.TabIndex = 23;
            this.lb_searchDesc.Text = "Enter search term";
            // 
            // lb_searchResult
            // 
            this.lb_searchResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.lb_searchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_searchResult.FormattingEnabled = true;
            this.lb_searchResult.ItemHeight = 23;
            this.lb_searchResult.Location = new System.Drawing.Point(54, 361);
            this.lb_searchResult.Margin = new System.Windows.Forms.Padding(0);
            this.lb_searchResult.Name = "lb_searchResult";
            this.lb_searchResult.Size = new System.Drawing.Size(626, 23);
            this.lb_searchResult.TabIndex = 24;
            this.lb_searchResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_searchResult_MouseDoubleClick);
            // 
            // SearchCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "SearchCourse";
            this.Text = "SearchCourse";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.BaseNavigationAction.ResumeLayout(false);
            this.panel_searchBox.ResumeLayout(false);
            this.panel_searchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_searchBox;
        private System.Windows.Forms.Label lbl_PlaceHolding;
        private System.Windows.Forms.ComboBox cb_searchWhat;
        private System.Windows.Forms.TextBox tb_searchText;
        private System.Windows.Forms.Label lb_searchDesc;
        private System.Windows.Forms.ListBox lb_searchResult;

    }
}