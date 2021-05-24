
namespace Restaurant
{
    partial class MyCalendar
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
            this.myShiftView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myShiftView)).BeginInit();
            this.SuspendLayout();
            // 
            // myShiftView
            // 
            this.myShiftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myShiftView.Location = new System.Drawing.Point(0, 0);
            this.myShiftView.Name = "myShiftView";
            this.myShiftView.RowTemplate.Height = 30;
            this.myShiftView.Size = new System.Drawing.Size(302, 233);
            this.myShiftView.TabIndex = 0;
            // 
            // MyCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 233);
            this.Controls.Add(this.myShiftView);
            this.Name = "MyCalendar";
            this.Text = "MyShift";
            this.Load += new System.EventHandler(this.MyShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myShiftView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myShiftView;
    }
}