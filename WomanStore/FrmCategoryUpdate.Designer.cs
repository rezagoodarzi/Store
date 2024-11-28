namespace WomanStore
{
    partial class FrmCategoryUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.edtCategory = new System.Windows.Forms.TextBox();
            this.edtDescription = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "دسته بندی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "توضیحات";
            // 
            // edtCategory
            // 
            this.edtCategory.Location = new System.Drawing.Point(241, 63);
            this.edtCategory.Name = "edtCategory";
            this.edtCategory.Size = new System.Drawing.Size(194, 23);
            this.edtCategory.TabIndex = 2;
            this.edtCategory.TextChanged += new System.EventHandler(this.edtCategory_TextChanged);
            // 
            // edtDescription
            // 
            this.edtDescription.Location = new System.Drawing.Point(241, 139);
            this.edtDescription.Name = "edtDescription";
            this.edtDescription.Size = new System.Drawing.Size(194, 23);
            this.edtDescription.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmCategoryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.edtDescription);
            this.Controls.Add(this.edtCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCategoryUpdate";
            this.Text = "آپدیت کردن دسته بندی";
            this.Load += new System.EventHandler(this.FrmCategoryUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtCategory;
        private System.Windows.Forms.TextBox edtDescription;
        private System.Windows.Forms.Button btnUpdate;
    }
}