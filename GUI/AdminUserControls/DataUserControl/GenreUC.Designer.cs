
namespace GUI.AdminUserControls.DataUserControl
{
    partial class GenreUC
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
            this.lblGenreID = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.txtGenreDesc = new System.Windows.Forms.TextBox();
            this.lblGenreDesc = new System.Windows.Forms.Label();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnInsertGenre = new System.Windows.Forms.Button();
            this.panel38 = new System.Windows.Forms.Panel();
            this.btnShowGenre = new System.Windows.Forms.Button();
            this.panel40 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvGenre = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreID.Location = new System.Drawing.Point(4, 11);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(126, 24);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Mã thể loại :";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(167, 10);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(329, 22);
            this.txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreName.Location = new System.Drawing.Point(4, 11);
            this.lblGenreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(134, 24);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Tên thể loại :";
            // 
            // txtGenreDesc
            // 
            this.txtGenreDesc.Location = new System.Drawing.Point(88, 10);
            this.txtGenreDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenreDesc.Multiline = true;
            this.txtGenreDesc.Name = "txtGenreDesc";
            this.txtGenreDesc.Size = new System.Drawing.Size(408, 156);
            this.txtGenreDesc.TabIndex = 1;
            // 
            // lblGenreDesc
            // 
            this.lblGenreDesc.AutoSize = true;
            this.lblGenreDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreDesc.Location = new System.Drawing.Point(4, 11);
            this.lblGenreDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreDesc.Name = "lblGenreDesc";
            this.lblGenreDesc.Size = new System.Drawing.Size(76, 24);
            this.lblGenreDesc.TabIndex = 0;
            this.lblGenreDesc.Text = "Mô tả :";
            // 
            // txtGenreID
            // 
            this.txtGenreID.Location = new System.Drawing.Point(167, 10);
            this.txtGenreID.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(329, 22);
            this.txtGenreID.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtGenreDesc);
            this.panel5.Controls.Add(this.lblGenreDesc);
            this.panel5.Location = new System.Drawing.Point(4, 131);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(526, 182);
            this.panel5.TabIndex = 5;
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Location = new System.Drawing.Point(220, 4);
            this.btnUpdateGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(100, 57);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "Sửa";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(112, 4);
            this.btnDeleteGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(100, 57);
            this.btnDeleteGenre.TabIndex = 1;
            this.btnDeleteGenre.Text = "Xóa";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnInsertGenre
            // 
            this.btnInsertGenre.Location = new System.Drawing.Point(4, 4);
            this.btnInsertGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertGenre.Name = "btnInsertGenre";
            this.btnInsertGenre.Size = new System.Drawing.Size(100, 57);
            this.btnInsertGenre.TabIndex = 0;
            this.btnInsertGenre.Text = "Thêm";
            this.btnInsertGenre.UseVisualStyleBackColor = true;
            this.btnInsertGenre.Click += new System.EventHandler(this.btnInsertGenre_Click);
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.txtGenreName);
            this.panel38.Controls.Add(this.lblGenreName);
            this.panel38.Location = new System.Drawing.Point(4, 69);
            this.panel38.Margin = new System.Windows.Forms.Padding(4);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(526, 54);
            this.panel38.TabIndex = 4;
            // 
            // btnShowGenre
            // 
            this.btnShowGenre.Location = new System.Drawing.Point(328, 4);
            this.btnShowGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowGenre.Name = "btnShowGenre";
            this.btnShowGenre.Size = new System.Drawing.Size(100, 57);
            this.btnShowGenre.TabIndex = 3;
            this.btnShowGenre.Text = "Xem";
            this.btnShowGenre.UseVisualStyleBackColor = true;
            this.btnShowGenre.Click += new System.EventHandler(this.btnShowGenre_Click);
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.btnShowGenre);
            this.panel40.Controls.Add(this.btnUpdateGenre);
            this.panel40.Controls.Add(this.btnDeleteGenre);
            this.panel40.Controls.Add(this.btnInsertGenre);
            this.panel40.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel40.Location = new System.Drawing.Point(0, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(4);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(1306, 62);
            this.panel40.TabIndex = 12;
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.txtGenreID);
            this.panel39.Controls.Add(this.lblGenreID);
            this.panel39.Location = new System.Drawing.Point(4, 8);
            this.panel39.Margin = new System.Windows.Forms.Padding(4);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(526, 54);
            this.panel39.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvGenre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 757);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel38);
            this.panel2.Controls.Add(this.panel39);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(779, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 757);
            this.panel2.TabIndex = 0;
            // 
            // dtgvGenre
            // 
            this.dtgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGenre.Location = new System.Drawing.Point(3, 68);
            this.dtgvGenre.Name = "dtgvGenre";
            this.dtgvGenre.RowHeadersWidth = 51;
            this.dtgvGenre.RowTemplate.Height = 24;
            this.dtgvGenre.Size = new System.Drawing.Size(777, 689);
            this.dtgvGenre.TabIndex = 1;
            this.dtgvGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGenre_CellContentClick_1);
            // 
            // GenreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel40);
            this.Controls.Add(this.panel1);
            this.Name = "GenreUC";
            this.Size = new System.Drawing.Size(1306, 757);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel40.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.TextBox txtGenreDesc;
        private System.Windows.Forms.Label lblGenreDesc;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnInsertGenre;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Button btnShowGenre;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvGenre;
    }
}
