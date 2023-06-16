namespace Bahria_Entrance.PAL
{
    partial class ResidentDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeleteCNIC = new System.Windows.Forms.TextBox();
            this.btnSubmitDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(221, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNIC";
            // 
            // txtDeleteCNIC
            // 
            this.txtDeleteCNIC.Location = new System.Drawing.Point(303, 199);
            this.txtDeleteCNIC.Name = "txtDeleteCNIC";
            this.txtDeleteCNIC.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteCNIC.TabIndex = 1;
            // 
            // btnSubmitDelete
            // 
            this.btnSubmitDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitDelete.Location = new System.Drawing.Point(251, 252);
            this.btnSubmitDelete.Name = "btnSubmitDelete";
            this.btnSubmitDelete.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitDelete.TabIndex = 2;
            this.btnSubmitDelete.Text = "Submit";
            this.btnSubmitDelete.UseVisualStyleBackColor = true;
            this.btnSubmitDelete.Click += new System.EventHandler(this.btnSubmitDelete_Click);
            // 
            // ResidentDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bahria_Entrance.Properties.Resources.istockphoto_1190671385_612x612;
            this.ClientSize = new System.Drawing.Size(570, 400);
            this.Controls.Add(this.btnSubmitDelete);
            this.Controls.Add(this.txtDeleteCNIC);
            this.Controls.Add(this.label1);
            this.Name = "ResidentDelete";
            this.Text = "ResidentDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeleteCNIC;
        private System.Windows.Forms.Button btnSubmitDelete;
    }
}