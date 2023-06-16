namespace Bahria_Entrance.PAL
{
    partial class SearchResident
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
            this.txtSearchCard = new System.Windows.Forms.TextBox();
            this.btnSearchResident = new System.Windows.Forms.Button();
            this.grdShowSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // txtSearchCard
            // 
            this.txtSearchCard.Location = new System.Drawing.Point(378, 180);
            this.txtSearchCard.Name = "txtSearchCard";
            this.txtSearchCard.Size = new System.Drawing.Size(133, 20);
            this.txtSearchCard.TabIndex = 1;
            // 
            // btnSearchResident
            // 
            this.btnSearchResident.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchResident.Location = new System.Drawing.Point(296, 242);
            this.btnSearchResident.Name = "btnSearchResident";
            this.btnSearchResident.Size = new System.Drawing.Size(122, 30);
            this.btnSearchResident.TabIndex = 2;
            this.btnSearchResident.Text = "Search";
            this.btnSearchResident.UseVisualStyleBackColor = true;
            this.btnSearchResident.Click += new System.EventHandler(this.btnSearchResident_Click);
            // 
            // grdShowSearch
            // 
            this.grdShowSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShowSearch.Location = new System.Drawing.Point(1, 329);
            this.grdShowSearch.Name = "grdShowSearch";
            this.grdShowSearch.Size = new System.Drawing.Size(657, 100);
            this.grdShowSearch.TabIndex = 3;
            this.grdShowSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdShowSearch_CellContentClick);
            // 
            // SearchResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bahria_Entrance.Properties.Resources.abstract_vector_background_bright_infinite_tunnel_glowing_segments_395079_7486;
            this.ClientSize = new System.Drawing.Size(658, 430);
            this.Controls.Add(this.grdShowSearch);
            this.Controls.Add(this.btnSearchResident);
            this.Controls.Add(this.txtSearchCard);
            this.Controls.Add(this.label1);
            this.Name = "SearchResident";
            this.Text = "SearchResident";
            ((System.ComponentModel.ISupportInitialize)(this.grdShowSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCard;
        private System.Windows.Forms.Button btnSearchResident;
        private System.Windows.Forms.DataGridView grdShowSearch;
    }
}