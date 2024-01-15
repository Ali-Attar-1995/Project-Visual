namespace FinalProjectMokdad_Attar
{
    partial class rental
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grid_rental = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grid_cus = new System.Windows.Forms.DataGridView();
            this.grid_car = new System.Windows.Forms.DataGridView();
            this.lbAv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dt_Due = new System.Windows.Forms.DateTimePicker();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btFee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(125, 530);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 50);
            this.btCancel.TabIndex = 28;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(125, 459);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 50);
            this.btClear.TabIndex = 27;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(19, 459);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 50);
            this.btAdd.TabIndex = 25;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grid_rental
            // 
            this.grid_rental.AllowUserToAddRows = false;
            this.grid_rental.AllowUserToDeleteRows = false;
            this.grid_rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rental.Location = new System.Drawing.Point(452, 352);
            this.grid_rental.Name = "grid_rental";
            this.grid_rental.ReadOnly = true;
            this.grid_rental.Size = new System.Drawing.Size(660, 292);
            this.grid_rental.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Customers :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cars :";
            // 
            // grid_cus
            // 
            this.grid_cus.AllowUserToAddRows = false;
            this.grid_cus.AllowUserToDeleteRows = false;
            this.grid_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cus.Location = new System.Drawing.Point(580, 168);
            this.grid_cus.Name = "grid_cus";
            this.grid_cus.ReadOnly = true;
            this.grid_cus.Size = new System.Drawing.Size(445, 150);
            this.grid_cus.TabIndex = 22;
            this.grid_cus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cus_CellContentClick);
            // 
            // grid_car
            // 
            this.grid_car.AllowUserToAddRows = false;
            this.grid_car.AllowUserToDeleteRows = false;
            this.grid_car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car.Location = new System.Drawing.Point(580, 12);
            this.grid_car.Name = "grid_car";
            this.grid_car.ReadOnly = true;
            this.grid_car.Size = new System.Drawing.Size(445, 150);
            this.grid_car.TabIndex = 21;
            this.grid_car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_car_CellContentClick);
            // 
            // lbAv
            // 
            this.lbAv.AutoSize = true;
            this.lbAv.ForeColor = System.Drawing.Color.Red;
            this.lbAv.Location = new System.Drawing.Point(370, 487);
            this.lbAv.Name = "lbAv";
            this.lbAv.Size = new System.Drawing.Size(0, 17);
            this.lbAv.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Available";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.dt_Due);
            this.groupBox1.Controls.Add(this.dt_Date);
            this.groupBox1.Controls.Add(this.txtfee);
            this.groupBox1.Controls.Add(this.txtcusname);
            this.groupBox1.Controls.Add(this.txtcusid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(426, 429);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental";
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtId.Location = new System.Drawing.Point(166, 64);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(237, 25);
            this.txtId.TabIndex = 12;
            // 
            // dt_Due
            // 
            this.dt_Due.Location = new System.Drawing.Point(166, 381);
            this.dt_Due.Name = "dt_Due";
            this.dt_Due.Size = new System.Drawing.Size(237, 25);
            this.dt_Due.TabIndex = 11;
            // 
            // dt_Date
            // 
            this.dt_Date.Location = new System.Drawing.Point(166, 311);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(237, 25);
            this.dt_Date.TabIndex = 10;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(166, 243);
            this.txtfee.Name = "txtfee";
            this.txtfee.ReadOnly = true;
            this.txtfee.Size = new System.Drawing.Size(237, 25);
            this.txtfee.TabIndex = 9;
            // 
            // txtcusname
            // 
            this.txtcusname.Location = new System.Drawing.Point(166, 179);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.ReadOnly = true;
            this.txtcusname.Size = new System.Drawing.Size(237, 25);
            this.txtcusname.TabIndex = 8;
            // 
            // txtcusid
            // 
            this.txtcusid.Location = new System.Drawing.Point(166, 124);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.ReadOnly = true;
            this.txtcusid.Size = new System.Drawing.Size(237, 25);
            this.txtcusid.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rental Fee Per Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car ID";
            // 
            // btFee
            // 
            this.btFee.Location = new System.Drawing.Point(231, 459);
            this.btFee.Name = "btFee";
            this.btFee.Size = new System.Drawing.Size(100, 50);
            this.btFee.TabIndex = 29;
            this.btFee.Text = "Total Fee";
            this.btFee.UseVisualStyleBackColor = true;
            this.btFee.Click += new System.EventHandler(this.btFee_Click);
            // 
            // rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 657);
            this.Controls.Add(this.btFee);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.grid_rental);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grid_cus);
            this.Controls.Add(this.grid_car);
            this.Controls.Add(this.lbAv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rental";
            this.Load += new System.EventHandler(this.rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_rental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView grid_rental;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grid_cus;
        private System.Windows.Forms.DataGridView grid_car;
        private System.Windows.Forms.Label lbAv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dt_Due;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFee;
    }
}