﻿
namespace Restaurant
{
    partial class ChangeManagerPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeManagerPassword));
            this.label2 = new System.Windows.Forms.Label();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(47, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password:";
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(188, 37);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.PasswordChar = '*';
            this.newPassBox.Size = new System.Drawing.Size(199, 20);
            this.newPassBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password:";
            // 
            // confirmBox
            // 
            this.confirmBox.Location = new System.Drawing.Point(188, 87);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.PasswordChar = '*';
            this.confirmBox.Size = new System.Drawing.Size(199, 20);
            this.confirmBox.TabIndex = 8;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.changeButton.Location = new System.Drawing.Point(25, 162);
            this.changeButton.Margin = new System.Windows.Forms.Padding(0);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(148, 46);
            this.changeButton.TabIndex = 34;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cancelButton.Location = new System.Drawing.Point(226, 162);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 46);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ChangeManagerPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(399, 217);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.label2);
            this.Name = "ChangeManagerPassword";
            this.Text = "ChangeManagerPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}