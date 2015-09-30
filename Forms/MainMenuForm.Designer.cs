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
            this.MainMenuControlsWrapper = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Menu";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(640, 360);
            // 
            // MainMenuControlsWrapper
            // 
            this.MainMenuControlsWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuControlsWrapper.Location = new System.Drawing.Point(0, 80);
            this.MainMenuControlsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenuControlsWrapper.Name = "MainMenuControlsWrapper";
            this.MainMenuControlsWrapper.Size = new System.Drawing.Size(640, 360);
            this.MainMenuControlsWrapper.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.MainMenuControlsWrapper);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Controls.SetChildIndex(this.BaseContentPanel, 0);
            this.Controls.SetChildIndex(this.MainMenuControlsWrapper, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuControlsWrapper;
    }
}