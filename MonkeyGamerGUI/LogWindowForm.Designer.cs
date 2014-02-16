namespace MonkeyGamerGUI
{
    partial class LogWindowForm
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
            this.logWindowListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // logWindowListView
            // 
            this.logWindowListView.Location = new System.Drawing.Point(-2, -1);
            this.logWindowListView.Name = "logWindowListView";
            this.logWindowListView.Size = new System.Drawing.Size(287, 263);
            this.logWindowListView.TabIndex = 0;
            this.logWindowListView.UseCompatibleStateImageBehavior = false;
            this.logWindowListView.View = System.Windows.Forms.View.List;
            // 
            // LogWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logWindowListView);
            this.Name = "LogWindowForm";
            this.Text = "Log Window";
            this.Load += new System.EventHandler(this.LogWindowForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView logWindowListView;
    }
}