﻿
namespace Restaurant
{
    partial class ManagerMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainMenu));
            this.checkInButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.editStaffButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.showStaffButton = new System.Windows.Forms.Button();
            this.removeStaffButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffIDBox = new System.Windows.Forms.TextBox();
            this.closeLabel = new System.Windows.Forms.Label();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.showCalendarButton = new System.Windows.Forms.Button();
            this.newCalendarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkInButton
            // 
            this.checkInButton.BackColor = System.Drawing.Color.Transparent;
            this.checkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.checkInButton.ForeColor = System.Drawing.Color.White;
            this.checkInButton.Location = new System.Drawing.Point(43, 578);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(148, 49);
            this.checkInButton.TabIndex = 2;
            this.checkInButton.Text = "Check in";
            this.checkInButton.UseVisualStyleBackColor = false;
            // 
            // checkOutButton
            // 
            this.checkOutButton.BackColor = System.Drawing.Color.Transparent;
            this.checkOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.checkOutButton.ForeColor = System.Drawing.Color.White;
            this.checkOutButton.Location = new System.Drawing.Point(290, 578);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(148, 49);
            this.checkOutButton.TabIndex = 3;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(497, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 518);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1020, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 518);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1031, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dishes";
            // 
            // addStaffButton
            // 
            this.addStaffButton.BackColor = System.Drawing.Color.Transparent;
            this.addStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.addStaffButton.ForeColor = System.Drawing.Color.White;
            this.addStaffButton.Location = new System.Drawing.Point(565, 576);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(148, 49);
            this.addStaffButton.TabIndex = 9;
            this.addStaffButton.Text = "Add Staff";
            this.addStaffButton.UseVisualStyleBackColor = false;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // editStaffButton
            // 
            this.editStaffButton.BackColor = System.Drawing.Color.Transparent;
            this.editStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.editStaffButton.ForeColor = System.Drawing.Color.White;
            this.editStaffButton.Location = new System.Drawing.Point(812, 578);
            this.editStaffButton.Name = "editStaffButton";
            this.editStaffButton.Size = new System.Drawing.Size(148, 49);
            this.editStaffButton.TabIndex = 10;
            this.editStaffButton.Text = "Edit Staff";
            this.editStaffButton.UseVisualStyleBackColor = false;
            this.editStaffButton.Click += new System.EventHandler(this.editStaffButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1093, 578);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 49);
            this.button4.TabIndex = 11;
            this.button4.Text = "Check in";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1343, 578);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 49);
            this.button5.TabIndex = 12;
            this.button5.Text = "Check in";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(163, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(74, 24);
            this.welcomeLabel.TabIndex = 13;
            this.welcomeLabel.Text = "Welcome";
            // 
            // showStaffButton
            // 
            this.showStaffButton.BackColor = System.Drawing.Color.Transparent;
            this.showStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.showStaffButton.ForeColor = System.Drawing.Color.White;
            this.showStaffButton.Location = new System.Drawing.Point(565, 476);
            this.showStaffButton.Name = "showStaffButton";
            this.showStaffButton.Size = new System.Drawing.Size(395, 49);
            this.showStaffButton.TabIndex = 14;
            this.showStaffButton.Text = "Show Full Staff";
            this.showStaffButton.UseVisualStyleBackColor = false;
            this.showStaffButton.Click += new System.EventHandler(this.showStaffButton_Click);
            // 
            // removeStaffButton
            // 
            this.removeStaffButton.BackColor = System.Drawing.Color.Transparent;
            this.removeStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.removeStaffButton.ForeColor = System.Drawing.Color.Black;
            this.removeStaffButton.Location = new System.Drawing.Point(37, 136);
            this.removeStaffButton.Name = "removeStaffButton";
            this.removeStaffButton.Size = new System.Drawing.Size(395, 49);
            this.removeStaffButton.TabIndex = 15;
            this.removeStaffButton.Text = "Remove Staff";
            this.removeStaffButton.UseVisualStyleBackColor = false;
            this.removeStaffButton.Click += new System.EventHandler(this.removeStaffButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.staffIDBox);
            this.groupBox1.Controls.Add(this.removeStaffButton);
            this.groupBox1.Location = new System.Drawing.Point(528, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 203);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enter Staff\'s ID";
            // 
            // staffIDBox
            // 
            this.staffIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.staffIDBox.Location = new System.Drawing.Point(37, 60);
            this.staffIDBox.Margin = new System.Windows.Forms.Padding(0);
            this.staffIDBox.Name = "staffIDBox";
            this.staffIDBox.Size = new System.Drawing.Size(395, 30);
            this.staffIDBox.TabIndex = 17;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.closeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeLabel.Location = new System.Drawing.Point(1520, -4);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(22, 25);
            this.closeLabel.TabIndex = 18;
            this.closeLabel.Text = "x";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // imgPanel
            // 
            this.imgPanel.Location = new System.Drawing.Point(26, 12);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(131, 151);
            this.imgPanel.TabIndex = 19;
            // 
            // showCalendarButton
            // 
            this.showCalendarButton.BackColor = System.Drawing.Color.Transparent;
            this.showCalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCalendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.showCalendarButton.ForeColor = System.Drawing.Color.White;
            this.showCalendarButton.Location = new System.Drawing.Point(43, 476);
            this.showCalendarButton.Name = "showCalendarButton";
            this.showCalendarButton.Size = new System.Drawing.Size(395, 49);
            this.showCalendarButton.TabIndex = 20;
            this.showCalendarButton.Text = "Show Calendar";
            this.showCalendarButton.UseVisualStyleBackColor = false;
            // 
            // newCalendarButton
            // 
            this.newCalendarButton.BackColor = System.Drawing.Color.Transparent;
            this.newCalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCalendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.newCalendarButton.ForeColor = System.Drawing.Color.White;
            this.newCalendarButton.Location = new System.Drawing.Point(43, 396);
            this.newCalendarButton.Name = "newCalendarButton";
            this.newCalendarButton.Size = new System.Drawing.Size(395, 49);
            this.newCalendarButton.TabIndex = 21;
            this.newCalendarButton.Text = "New Calendar";
            this.newCalendarButton.UseVisualStyleBackColor = false;
            this.newCalendarButton.Click += new System.EventHandler(this.newCalendarButton_Click);
            // 
            // ManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1544, 669);
            this.Controls.Add(this.newCalendarButton);
            this.Controls.Add(this.showCalendarButton);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showStaffButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.editStaffButton);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.checkInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerMainMenu";
            this.Text = "ManagerMainMenu";
            this.Load += new System.EventHandler(this.ManagerMainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.Button editStaffButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button showStaffButton;
        private System.Windows.Forms.Button removeStaffButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox staffIDBox;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.Button showCalendarButton;
        private System.Windows.Forms.Button newCalendarButton;
    }
}