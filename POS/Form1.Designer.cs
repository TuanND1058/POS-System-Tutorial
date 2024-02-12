﻿namespace POS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnMngCategory = new System.Windows.Forms.Button();
            this.btnSysSettings = new System.Windows.Forms.Button();
            this.btnMngProduct = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnMngSales = new System.Windows.Forms.Button();
            this.btnMngBrand = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnUserSettings);
            this.panel2.Controls.Add(this.btnMngCategory);
            this.panel2.Controls.Add(this.btnSysSettings);
            this.panel2.Controls.Add(this.btnMngProduct);
            this.panel2.Controls.Add(this.btnRecords);
            this.panel2.Controls.Add(this.btnMngSales);
            this.panel2.Controls.Add(this.btnMngBrand);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 558);
            this.panel2.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(72, 45);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(134, 20);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Adminstrator";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.lblName.Location = new System.Drawing.Point(72, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::POS.Properties.Resources.icons8_logout_30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(16, 508);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 38);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.Image = global::POS.Properties.Resources.icons8_user_30;
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.Location = new System.Drawing.Point(16, 416);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(190, 38);
            this.btnUserSettings.TabIndex = 2;
            this.btnUserSettings.Text = "User Settings";
            this.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserSettings.UseVisualStyleBackColor = true;
            // 
            // btnMngCategory
            // 
            this.btnMngCategory.FlatAppearance.BorderSize = 0;
            this.btnMngCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngCategory.ForeColor = System.Drawing.Color.White;
            this.btnMngCategory.Image = global::POS.Properties.Resources.icons8_folder_30;
            this.btnMngCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngCategory.Location = new System.Drawing.Point(16, 240);
            this.btnMngCategory.Name = "btnMngCategory";
            this.btnMngCategory.Size = new System.Drawing.Size(190, 38);
            this.btnMngCategory.TabIndex = 2;
            this.btnMngCategory.Text = "Manage Category";
            this.btnMngCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngCategory.UseVisualStyleBackColor = true;
            // 
            // btnSysSettings
            // 
            this.btnSysSettings.FlatAppearance.BorderSize = 0;
            this.btnSysSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSysSettings.ForeColor = System.Drawing.Color.White;
            this.btnSysSettings.Image = global::POS.Properties.Resources.icons8_setting_30;
            this.btnSysSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSysSettings.Location = new System.Drawing.Point(16, 372);
            this.btnSysSettings.Name = "btnSysSettings";
            this.btnSysSettings.Size = new System.Drawing.Size(190, 38);
            this.btnSysSettings.TabIndex = 2;
            this.btnSysSettings.Text = "System Settings";
            this.btnSysSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSysSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSysSettings.UseVisualStyleBackColor = true;
            // 
            // btnMngProduct
            // 
            this.btnMngProduct.FlatAppearance.BorderSize = 0;
            this.btnMngProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngProduct.ForeColor = System.Drawing.Color.White;
            this.btnMngProduct.Image = global::POS.Properties.Resources.icons8_strategy_30;
            this.btnMngProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngProduct.Location = new System.Drawing.Point(16, 196);
            this.btnMngProduct.Name = "btnMngProduct";
            this.btnMngProduct.Size = new System.Drawing.Size(190, 38);
            this.btnMngProduct.TabIndex = 2;
            this.btnMngProduct.Text = "Magnage Product";
            this.btnMngProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngProduct.UseVisualStyleBackColor = true;
            // 
            // btnRecords
            // 
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.ForeColor = System.Drawing.Color.White;
            this.btnRecords.Image = global::POS.Properties.Resources.icons8_database_view_30;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(16, 328);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(190, 38);
            this.btnRecords.TabIndex = 2;
            this.btnRecords.Text = "Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecords.UseVisualStyleBackColor = true;
            // 
            // btnMngSales
            // 
            this.btnMngSales.FlatAppearance.BorderSize = 0;
            this.btnMngSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngSales.ForeColor = System.Drawing.Color.White;
            this.btnMngSales.Image = global::POS.Properties.Resources.icons8_cart_30;
            this.btnMngSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngSales.Location = new System.Drawing.Point(16, 152);
            this.btnMngSales.Name = "btnMngSales";
            this.btnMngSales.Size = new System.Drawing.Size(190, 38);
            this.btnMngSales.TabIndex = 2;
            this.btnMngSales.Text = "Manage sales";
            this.btnMngSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngSales.UseVisualStyleBackColor = true;
            // 
            // btnMngBrand
            // 
            this.btnMngBrand.FlatAppearance.BorderSize = 0;
            this.btnMngBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngBrand.ForeColor = System.Drawing.Color.White;
            this.btnMngBrand.Image = global::POS.Properties.Resources.icons8_brand_30;
            this.btnMngBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngBrand.Location = new System.Drawing.Point(16, 284);
            this.btnMngBrand.Name = "btnMngBrand";
            this.btnMngBrand.Size = new System.Drawing.Size(190, 38);
            this.btnMngBrand.TabIndex = 2;
            this.btnMngBrand.Text = "Manage Brand";
            this.btnMngBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngBrand.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::POS.Properties.Resources.icons8_dashboard_30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(16, 108);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(190, 38);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources.icons8_user_94;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 598);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Button btnMngCategory;
        private System.Windows.Forms.Button btnSysSettings;
        private System.Windows.Forms.Button btnMngProduct;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnMngSales;
        private System.Windows.Forms.Button btnMngBrand;
        private System.Windows.Forms.Button btnLogout;
    }
}

