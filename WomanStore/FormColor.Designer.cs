namespace WomanStore
{
    partial class FrmColor
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.grdShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(666, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(122, 64);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "اضافه کردن";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // grdShow
            // 
            this.grdShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShow.Location = new System.Drawing.Point(27, 100);
            this.grdShow.Name = "grdShow";
            this.grdShow.RowHeadersWidth = 51;
            this.grdShow.RowTemplate.Height = 24;
            this.grdShow.Size = new System.Drawing.Size(761, 327);
            this.grdShow.TabIndex = 2;
            this.grdShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdShow_CellContentClick);
            // 
            // FrmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdShow);
            this.Controls.Add(this.btnInsert);
            this.Name = "FrmColor";
            this.Text = "رنگ";
            this.Load += new System.EventHandler(this.FrmColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView grdShow;
    }
}