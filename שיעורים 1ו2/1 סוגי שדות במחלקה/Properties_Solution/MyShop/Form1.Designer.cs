namespace MyShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewProductBtn
            // 
            this.AddNewProductBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewProductBtn.Location = new System.Drawing.Point(322, 163);
            this.AddNewProductBtn.Name = "AddNewProductBtn";
            this.AddNewProductBtn.Size = new System.Drawing.Size(210, 50);
            this.AddNewProductBtn.TabIndex = 0;
            this.AddNewProductBtn.Text = "הוספת מוצר חדש";
            this.AddNewProductBtn.UseVisualStyleBackColor = true;
            this.AddNewProductBtn.Click += new System.EventHandler(this.AddNewProductBtn_Click);
            this.AddNewProductBtn.MouseLeave += new System.EventHandler(this.AddNewProductBtn_MouseLeave);
            this.AddNewProductBtn.MouseHover += new System.EventHandler(this.AddNewProductBtn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(303, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ברוכים הבאים לחנות";
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateProduct.Location = new System.Drawing.Point(322, 248);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(210, 50);
            this.UpdateProduct.TabIndex = 2;
            this.UpdateProduct.Text = "עדכון מוצר";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(333, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "מחרוזות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNewProductBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddNewProductBtn;
        private Label label1;
        private Button UpdateProduct;
        private Button button1;
    }
}