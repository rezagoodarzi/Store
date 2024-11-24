namespace WomanStore
{
    partial class FrmAdmin
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.btnProductType = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(296, 38);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(122, 44);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "دسته بندی";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Location = new System.Drawing.Point(296, 128);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(122, 44);
            this.btnSubCategory.TabIndex = 1;
            this.btnSubCategory.Text = "زیر دسته";
            this.btnSubCategory.UseVisualStyleBackColor = true;
            this.btnSubCategory.Click += new System.EventHandler(this.btnSubCategory_Click);
            // 
            // btnProductType
            // 
            this.btnProductType.Location = new System.Drawing.Point(296, 218);
            this.btnProductType.Name = "btnProductType";
            this.btnProductType.Size = new System.Drawing.Size(122, 44);
            this.btnProductType.TabIndex = 2;
            this.btnProductType.Text = "مدل محصول";
            this.btnProductType.UseVisualStyleBackColor = true;
            this.btnProductType.Click += new System.EventHandler(this.btnProductType_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(296, 308);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(122, 44);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "محصول";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(296, 398);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(122, 44);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "رنگ";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(296, 488);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(122, 44);
            this.btnSize.TabIndex = 5;
            this.btnSize.Text = "اندازه";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(296, 578);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(122, 45);
            this.btnMaterial.TabIndex = 6;
            this.btnMaterial.Text = "جنس";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 658);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnProductType);
            this.Controls.Add(this.btnSubCategory);
            this.Controls.Add(this.btnCategory);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAdmin";
            this.Text = "ادمین";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Button btnProductType;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnMaterial;
    }
}