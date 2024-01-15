namespace FinalProjectMokdad_Attar
{
    partial class returncar
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtelp = new System.Windows.Forms.TextBox();
            this.txtfine = new System.Windows.Forms.TextBox();
            this.grid_rented = new System.Windows.Forms.DataGridView();
            this.grid_return = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.carsDataSet = new FinalProjectMokdad_Attar.CarsDataSet();
            this.returnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnTableAdapter = new FinalProjectMokdad_Attar.CarsDataSetTableAdapters.ReturnTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfine);
            this.groupBox1.Controls.Add(this.txtelp);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtcusid);
            this.groupBox1.Controls.Add(this.txtcid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retrun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Days Elapsed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fine";
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(149, 50);
            this.txtcid.Name = "txtcid";
            this.txtcid.ReadOnly = true;
            this.txtcid.Size = new System.Drawing.Size(187, 25);
            this.txtcid.TabIndex = 5;
            // 
            // txtcusid
            // 
            this.txtcusid.Location = new System.Drawing.Point(149, 118);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.ReadOnly = true;
            this.txtcusid.Size = new System.Drawing.Size(187, 25);
            this.txtcusid.TabIndex = 6;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(149, 186);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(187, 25);
            this.txtdate.TabIndex = 7;
            // 
            // txtelp
            // 
            this.txtelp.Location = new System.Drawing.Point(149, 256);
            this.txtelp.Name = "txtelp";
            this.txtelp.Size = new System.Drawing.Size(187, 25);
            this.txtelp.TabIndex = 8;
            this.txtelp.TextChanged += new System.EventHandler(this.txtelp_TextChanged);
            // 
            // txtfine
            // 
            this.txtfine.Location = new System.Drawing.Point(149, 318);
            this.txtfine.Name = "txtfine";
            this.txtfine.ReadOnly = true;
            this.txtfine.Size = new System.Drawing.Size(187, 25);
            this.txtfine.TabIndex = 9;
            // 
            // grid_rented
            // 
            this.grid_rented.AllowUserToAddRows = false;
            this.grid_rented.AllowUserToDeleteRows = false;
            this.grid_rented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rented.Location = new System.Drawing.Point(466, 12);
            this.grid_rented.Name = "grid_rented";
            this.grid_rented.ReadOnly = true;
            this.grid_rented.Size = new System.Drawing.Size(649, 211);
            this.grid_rented.TabIndex = 10;
            this.grid_rented.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rented_CellContentClick);
            // 
            // grid_return
            // 
            this.grid_return.AllowUserToAddRows = false;
            this.grid_return.AllowUserToDeleteRows = false;
            this.grid_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_return.Location = new System.Drawing.Point(365, 248);
            this.grid_return.Name = "grid_return";
            this.grid_return.ReadOnly = true;
            this.grid_return.Size = new System.Drawing.Size(750, 285);
            this.grid_return.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rented Cars :";
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(35, 426);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(100, 50);
            this.btReturn.TabIndex = 13;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(199, 426);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 50);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "CarsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnBindingSource
            // 
            this.returnBindingSource.DataMember = "Return";
            this.returnBindingSource.DataSource = this.carsDataSet;
            // 
            // returnTableAdapter
            // 
            this.returnTableAdapter.ClearBeforeFill = true;
            // 
            // returncar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 545);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grid_return);
            this.Controls.Add(this.grid_rented);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "returncar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "returncar";
            this.Load += new System.EventHandler(this.returncar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_rented;
        private System.Windows.Forms.TextBox txtfine;
        private System.Windows.Forms.TextBox txtelp;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView grid_return;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btCancel;
        private CarsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource returnBindingSource;
        private CarsDataSetTableAdapters.ReturnTableAdapter returnTableAdapter;
    }
}