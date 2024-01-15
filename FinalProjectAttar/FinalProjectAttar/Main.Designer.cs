namespace FinalProjectMokdad_Attar
{
    partial class Main
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
            this.btReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(123, 424);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(130, 50);
            this.btLogout.TabIndex = 9;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(123, 336);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(130, 50);
            this.btReturn.TabIndex = 8;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btRental
            // 
            this.btRental.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRental.Location = new System.Drawing.Point(123, 254);
            this.btRental.Name = "btRental";
            this.btRental.Size = new System.Drawing.Size(130, 50);
            this.btRental.TabIndex = 7;
            this.btRental.Text = "Rental";
            this.btRental.UseVisualStyleBackColor = true;
            this.btRental.Click += new System.EventHandler(this.btRental_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomer.Location = new System.Drawing.Point(123, 169);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(130, 50);
            this.btCustomer.TabIndex = 6;
            this.btCustomer.Text = "Customer";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btReg
            // 
            this.btReg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReg.Location = new System.Drawing.Point(123, 86);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(130, 50);
            this.btReg.TabIndex = 5;
            this.btReg.Text = "Car Registration";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btRental);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.btReg);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btRental;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btReg;
    }
}