namespace Bahria_Entrance.PAL
{
    partial class UpdateVisitor
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateSubmit = new System.Windows.Forms.Button();
            this.txtUpadateVisit = new System.Windows.Forms.TextBox();
            this.txtUpdateCNIC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.LightGray;
            this.lable1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(302, 277);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(49, 19);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "CNIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visit Number";
            // 
            // btnUpdateSubmit
            // 
            this.btnUpdateSubmit.BackColor = System.Drawing.Color.Tan;
            this.btnUpdateSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSubmit.Location = new System.Drawing.Point(370, 364);
            this.btnUpdateSubmit.Name = "btnUpdateSubmit";
            this.btnUpdateSubmit.Size = new System.Drawing.Size(116, 40);
            this.btnUpdateSubmit.TabIndex = 2;
            this.btnUpdateSubmit.Text = "Submit";
            this.btnUpdateSubmit.UseVisualStyleBackColor = false;
            this.btnUpdateSubmit.Click += new System.EventHandler(this.btnUpdateSubmit_Click);
            // 
            // txtUpadateVisit
            // 
            this.txtUpadateVisit.Location = new System.Drawing.Point(297, 314);
            this.txtUpadateVisit.Name = "txtUpadateVisit";
            this.txtUpadateVisit.Size = new System.Drawing.Size(100, 20);
            this.txtUpadateVisit.TabIndex = 3;
            // 
            // txtUpdateCNIC
            // 
            this.txtUpdateCNIC.Location = new System.Drawing.Point(445, 314);
            this.txtUpdateCNIC.Name = "txtUpdateCNIC";
            this.txtUpdateCNIC.Size = new System.Drawing.Size(119, 20);
            this.txtUpdateCNIC.TabIndex = 4;
            // 
            // UpdateVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bahria_Entrance.Properties.Resources.WhatsApp_Image_2022_02_20_at_4_53_45_PM;
            this.ClientSize = new System.Drawing.Size(738, 416);
            this.Controls.Add(this.txtUpdateCNIC);
            this.Controls.Add(this.txtUpadateVisit);
            this.Controls.Add(this.btnUpdateSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Name = "UpdateVisitor";
            this.Text = "UpdateVisitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateSubmit;
        private System.Windows.Forms.TextBox txtUpadateVisit;
        private System.Windows.Forms.TextBox txtUpdateCNIC;
    }
}