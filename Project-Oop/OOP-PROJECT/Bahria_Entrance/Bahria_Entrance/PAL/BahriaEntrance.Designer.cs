namespace Bahria_Entrance
{
    partial class BahriaEntrance
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
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnResident = new System.Windows.Forms.Button();
            this.btnConnectDb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.Color.Tan;
            this.btnVisitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisitor.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.Location = new System.Drawing.Point(56, 354);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(117, 38);
            this.btnVisitor.TabIndex = 0;
            this.btnVisitor.Text = "Visitor";
            this.btnVisitor.UseVisualStyleBackColor = false;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // btnResident
            // 
            this.btnResident.BackColor = System.Drawing.Color.Tan;
            this.btnResident.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResident.Location = new System.Drawing.Point(554, 354);
            this.btnResident.Name = "btnResident";
            this.btnResident.Size = new System.Drawing.Size(117, 38);
            this.btnResident.TabIndex = 1;
            this.btnResident.Text = "Resident";
            this.btnResident.UseVisualStyleBackColor = false;
            this.btnResident.Click += new System.EventHandler(this.btnResident_Click);
            // 
            // btnConnectDb
            // 
            this.btnConnectDb.BackColor = System.Drawing.Color.Tan;
            this.btnConnectDb.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDb.Location = new System.Drawing.Point(307, 354);
            this.btnConnectDb.Name = "btnConnectDb";
            this.btnConnectDb.Size = new System.Drawing.Size(117, 38);
            this.btnConnectDb.TabIndex = 2;
            this.btnConnectDb.Text = "Connection";
            this.btnConnectDb.UseVisualStyleBackColor = false;
            this.btnConnectDb.Click += new System.EventHandler(this.btnConnectDb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(216, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bahria Housing Society";
            // 
            // BahriaEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Bahria_Entrance.Properties.Resources.WhatsApp_Image_2022_02_20_at_4_53_26_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(742, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnectDb);
            this.Controls.Add(this.btnResident);
            this.Controls.Add(this.btnVisitor);
            this.DoubleBuffered = true;
            this.Name = "BahriaEntrance";
            this.Text = "BahriaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Button btnResident;
        private System.Windows.Forms.Button btnConnectDb;
        private System.Windows.Forms.Label label1;
    }
}

