namespace FinalProjectMokdad_Attar
{
    partial class Main2
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.btRental = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(120, 364);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(130, 50);
            this.btLogout.TabIndex = 14;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(120, 276);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(130, 50);
            this.btReturn.TabIndex = 13;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btRental
            // 
            this.btRental.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRental.Location = new System.Drawing.Point(120, 194);
            this.btRental.Name = "btRental";
            this.btRental.Size = new System.Drawing.Size(130, 50);
            this.btRental.TabIndex = 12;
            this.btRental.Text = "Rental";
            this.btRental.UseVisualStyleBackColor = true;
            this.btRental.Click += new System.EventHandler(this.btRental_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomer.Location = new System.Drawing.Point(120, 109);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(130, 50);
            this.btCustomer.TabIndex = 11;
            this.btCustomer.Text = "Customer";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 557);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btRental);
            this.Controls.Add(this.btCustomer);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btRental;
        private System.Windows.Forms.Button btCustomer;
    }
}