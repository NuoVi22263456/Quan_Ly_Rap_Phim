﻿
namespace GUI.AdminUserControls
{
    partial class StaffUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.lblStaffINumber = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffBirth = new System.Windows.Forms.Label();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.txtStaffBirth = new System.Windows.Forms.TextBox();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.txtStaffINumber = new System.Windows.Forms.TextBox();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.grpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(465, 206);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(91, 32);
            this.btnAddStaff.TabIndex = 28;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchStaff.Location = new System.Drawing.Point(998, 210);
            this.btnSearchStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(27, 26);
            this.btnSearchStaff.TabIndex = 30;
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(24, 75);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(73, 23);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Họ tên:";
            // 
            // grpStaff
            // 
            this.grpStaff.BackColor = System.Drawing.Color.Transparent;
            this.grpStaff.Controls.Add(this.lblStaffID);
            this.grpStaff.Controls.Add(this.txtStaffId);
            this.grpStaff.Controls.Add(this.txtStaffAddress);
            this.grpStaff.Controls.Add(this.lblStaffINumber);
            this.grpStaff.Controls.Add(this.txtStaffName);
            this.grpStaff.Controls.Add(this.lblStaffBirth);
            this.grpStaff.Controls.Add(this.txtStaffPhone);
            this.grpStaff.Controls.Add(this.lblStaffPhone);
            this.grpStaff.Controls.Add(this.txtStaffBirth);
            this.grpStaff.Controls.Add(this.lblStaffAddress);
            this.grpStaff.Controls.Add(this.txtStaffINumber);
            this.grpStaff.Controls.Add(this.lblStaffName);
            this.grpStaff.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaff.Location = new System.Drawing.Point(82, 56);
            this.grpStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaff.Size = new System.Drawing.Size(720, 145);
            this.grpStaff.TabIndex = 31;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Thông tin nhân viên";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(24, 39);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(76, 23);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Mã NV:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffId.Location = new System.Drawing.Point(149, 32);
            this.txtStaffId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(191, 30);
            this.txtStaffId.TabIndex = 2;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAddress.Location = new System.Drawing.Point(503, 36);
            this.txtStaffAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(191, 30);
            this.txtStaffAddress.TabIndex = 2;
            // 
            // lblStaffINumber
            // 
            this.lblStaffINumber.AutoSize = true;
            this.lblStaffINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffINumber.Location = new System.Drawing.Point(408, 108);
            this.lblStaffINumber.Name = "lblStaffINumber";
            this.lblStaffINumber.Size = new System.Drawing.Size(77, 23);
            this.lblStaffINumber.TabIndex = 4;
            this.lblStaffINumber.Text = "CMND:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(149, 71);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(191, 30);
            this.txtStaffName.TabIndex = 2;
            // 
            // lblStaffBirth
            // 
            this.lblStaffBirth.AutoSize = true;
            this.lblStaffBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffBirth.Location = new System.Drawing.Point(24, 108);
            this.lblStaffBirth.Name = "lblStaffBirth";
            this.lblStaffBirth.Size = new System.Drawing.Size(99, 23);
            this.lblStaffBirth.TabIndex = 4;
            this.lblStaffBirth.Text = "Ngày sinh:";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPhone.Location = new System.Drawing.Point(503, 71);
            this.txtStaffPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(191, 30);
            this.txtStaffPhone.TabIndex = 2;
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPhone.Location = new System.Drawing.Point(408, 75);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(69, 23);
            this.lblStaffPhone.TabIndex = 4;
            this.lblStaffPhone.Text = "Số ĐT:";
            // 
            // txtStaffBirth
            // 
            this.txtStaffBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffBirth.Location = new System.Drawing.Point(149, 106);
            this.txtStaffBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffBirth.Name = "txtStaffBirth";
            this.txtStaffBirth.Size = new System.Drawing.Size(191, 30);
            this.txtStaffBirth.TabIndex = 2;
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAddress.Location = new System.Drawing.Point(408, 39);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(75, 23);
            this.lblStaffAddress.TabIndex = 4;
            this.lblStaffAddress.Text = "Địa chỉ:";
            // 
            // txtStaffINumber
            // 
            this.txtStaffINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffINumber.Location = new System.Drawing.Point(503, 108);
            this.txtStaffINumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffINumber.Name = "txtStaffINumber";
            this.txtStaffINumber.Size = new System.Drawing.Size(191, 30);
            this.txtStaffINumber.TabIndex = 2;
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Location = new System.Drawing.Point(859, 213);
            this.txtSearchStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(132, 22);
            this.txtSearchStaff.TabIndex = 29;
            this.txtSearchStaff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchStaff_KeyDown);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(713, 206);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(91, 32);
            this.btnDeleteStaff.TabIndex = 26;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(590, 206);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(91, 32);
            this.btnUpdateStaff.TabIndex = 27;
            this.btnUpdateStaff.Text = "Sửa";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Location = new System.Drawing.Point(82, 204);
            this.btnShowStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(88, 34);
            this.btnShowStaff.TabIndex = 25;
            this.btnShowStaff.Text = "Xem";
            this.btnShowStaff.UseVisualStyleBackColor = true;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.AllowUserToDeleteRows = false;
            this.dtgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(82, 246);
            this.dtgvStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.Size = new System.Drawing.Size(941, 375);
            this.dtgvStaff.TabIndex = 24;
            // 
            // StaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnShowStaff);
            this.Controls.Add(this.dtgvStaff);
            this.Name = "StaffUC";
            this.Size = new System.Drawing.Size(1107, 676);
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.Label lblStaffINumber;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffBirth;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.TextBox txtStaffBirth;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.TextBox txtStaffINumber;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnShowStaff;
        private System.Windows.Forms.DataGridView dtgvStaff;
    }
}
