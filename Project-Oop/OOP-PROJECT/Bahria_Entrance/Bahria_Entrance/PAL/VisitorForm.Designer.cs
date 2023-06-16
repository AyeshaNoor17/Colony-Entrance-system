namespace Bahria_Entrance.PAL
{
    partial class VisitorForm
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
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplayVisitor = new System.Windows.Forms.Button();
            this.grdVisitor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddRecord.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(41, 352);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(144, 48);
            this.btnAddRecord.TabIndex = 0;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(41, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 47);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplayVisitor
            // 
            this.btnDisplayVisitor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDisplayVisitor.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayVisitor.Location = new System.Drawing.Point(41, 459);
            this.btnDisplayVisitor.Name = "btnDisplayVisitor";
            this.btnDisplayVisitor.Size = new System.Drawing.Size(144, 39);
            this.btnDisplayVisitor.TabIndex = 2;
            this.btnDisplayVisitor.Text = "Display";
            this.btnDisplayVisitor.UseVisualStyleBackColor = false;
            this.btnDisplayVisitor.Click += new System.EventHandler(this.btnDisplayVisitor_Click);
            // 
            // grdVisitor
            // 
            this.grdVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisitor.Location = new System.Drawing.Point(1, 504);
            this.grdVisitor.Name = "grdVisitor";
            this.grdVisitor.Size = new System.Drawing.Size(1026, 153);
            this.grdVisitor.TabIndex = 3;
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bahria_Entrance.Properties.Resources.d73aea0f7e1c4e45d248c4066d3d5e6e;
            this.ClientSize = new System.Drawing.Size(1027, 656);
            this.Controls.Add(this.grdVisitor);
            this.Controls.Add(this.btnDisplayVisitor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddRecord);
            this.Name = "VisitorForm";
            this.Text = "VisitorForm";
            this.Load += new System.EventHandler(this.VisitorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplayVisitor;
        private System.Windows.Forms.DataGridView grdVisitor;
    }
}