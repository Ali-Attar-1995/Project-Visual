namespace FinalProjectMokdad_Attar
{
    partial class carReg
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
            this.btdelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.grid_car = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAv = new System.Windows.Forms.ComboBox();
            this.txtregno = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(272, 457);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(100, 50);
            this.btdelete.TabIndex = 15;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(150, 457);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 50);
            this.btEdit.TabIndex = 14;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // grid_car
            // 
            this.grid_car.AllowUserToAddRows = false;
            this.grid_car.AllowUserToDeleteRows = false;
            this.grid_car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car.Location = new System.Drawing.Point(379, 63);
            this.grid_car.Name = "grid_car";
            this.grid_car.ReadOnly = true;
            this.grid_car.Size = new System.Drawing.Size(625, 380);
            this.grid_car.TabIndex = 13;
            this.grid_car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_car_CellContentClick);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(88, 513);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 50);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(212, 513);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 50);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(26, 457);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 50);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAv);
            this.groupBox1.Controls.Add(this.txtregno);
            this.groupBox1.Controls.Add(this.txttype);
            this.groupBox1.Controls.Add(this.txtmodel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(346, 380);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Regestration";
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(114, 329);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(181, 25);
            this.txtfee.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fee";
            // 
            // txtAv
            // 
            this.txtAv.FormattingEnabled = true;
            this.txtAv.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.txtAv.Location = new System.Drawing.Point(114, 274);
            this.txtAv.Name = "txtAv";
            this.txtAv.Size = new System.Drawing.Size(181, 25);
            this.txtAv.TabIndex = 7;
            // 
            // txtregno
            // 
            this.txtregno.Location = new System.Drawing.Point(114, 57);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(181, 25);
            this.txtregno.TabIndex = 6;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(114, 121);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(181, 25);
            this.txttype.TabIndex = 5;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(114, 192);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(181, 25);
            this.txtmodel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(12, 129);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 17);
            this.Type.TabIndex = 1;
            this.Type.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RegNo";
            // 
            // carReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 617);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.grid_car);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "carReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carReg";
            this.Load += new System.EventHandler(this.carReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_car)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridView grid_car;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtAv;
        private System.Windows.Forms.TextBox txtregno;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label1;
    }
}