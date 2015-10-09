namespace HCI.Forms
{
    partial class Loading
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
            this.LabelHolder = new System.Windows.Forms.Panel();
            this.lb_Loading = new System.Windows.Forms.Label();
            this.LabelHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHolder
            // 
            this.LabelHolder.Controls.Add(this.lb_Loading);
            this.LabelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHolder.Location = new System.Drawing.Point(0, 0);
            this.LabelHolder.Name = "LabelHolder";
            this.LabelHolder.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.LabelHolder.Size = new System.Drawing.Size(191, 71);
            this.LabelHolder.TabIndex = 0;
            // 
            // lb_Loading
            // 
            this.lb_Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Loading.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.lb_Loading.Location = new System.Drawing.Point(25, 0);
            this.lb_Loading.Margin = new System.Windows.Forms.Padding(10);
            this.lb_Loading.Name = "lb_Loading";
            this.lb_Loading.Size = new System.Drawing.Size(166, 71);
            this.lb_Loading.TabIndex = 2;
            this.lb_Loading.Text = "Loading /";
            this.lb_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Loading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(191, 71);
            this.Controls.Add(this.LabelHolder);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LabelHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LabelHolder;
        private System.Windows.Forms.Label lb_Loading;
    }
}