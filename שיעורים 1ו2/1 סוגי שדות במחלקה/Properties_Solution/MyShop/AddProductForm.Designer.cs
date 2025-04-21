namespace MyShop
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddNewProductBtn = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PriceNum = new System.Windows.Forms.NumericUpDown();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.ByWeightCB = new System.Windows.Forms.CheckBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Purple;
            this.Title.Location = new System.Drawing.Point(161, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(304, 32);
            this.Title.TabIndex = 2;
            this.Title.Text = "יש להכניס את פרטי המוצר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "מחיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(109, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "תאריך תפוגה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(109, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "לפי משקל";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(109, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "קטגוריה";
            // 
            // AddNewProductBtn
            // 
            this.AddNewProductBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewProductBtn.Location = new System.Drawing.Point(244, 379);
            this.AddNewProductBtn.Name = "AddNewProductBtn";
            this.AddNewProductBtn.Size = new System.Drawing.Size(141, 50);
            this.AddNewProductBtn.TabIndex = 8;
            this.AddNewProductBtn.Text = "שמור";
            this.AddNewProductBtn.UseVisualStyleBackColor = true;
            this.AddNewProductBtn.Click += new System.EventHandler(this.AddNewProductBtn_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(265, 126);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(143, 23);
            this.NameTB.TabIndex = 9;
            // 
            // PriceNum
            // 
            this.PriceNum.DecimalPlaces = 2;
            this.PriceNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.PriceNum.Location = new System.Drawing.Point(265, 167);
            this.PriceNum.Name = "PriceNum";
            this.PriceNum.Size = new System.Drawing.Size(120, 23);
            this.PriceNum.TabIndex = 10;
            // 
            // ExpDate
            // 
            this.ExpDate.Location = new System.Drawing.Point(265, 210);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(200, 23);
            this.ExpDate.TabIndex = 11;
            // 
            // ByWeightCB
            // 
            this.ByWeightCB.AutoSize = true;
            this.ByWeightCB.Location = new System.Drawing.Point(265, 252);
            this.ByWeightCB.Name = "ByWeightCB";
            this.ByWeightCB.Size = new System.Drawing.Size(15, 14);
            this.ByWeightCB.TabIndex = 12;
            this.ByWeightCB.UseVisualStyleBackColor = true;
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(264, 294);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(121, 23);
            this.CategoryCombo.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 66);
            this.button1.TabIndex = 14;
            this.button1.Text = "שינוי צבע רקע";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.ByWeightCB);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.PriceNum);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.AddNewProductBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Name = "AddProductForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוספת מוצר חדש";
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button AddNewProductBtn;
        private TextBox NameTB;
        private NumericUpDown PriceNum;
        private DateTimePicker ExpDate;
        private CheckBox ByWeightCB;
        private ComboBox CategoryCombo;
        private ErrorProvider errorProvider1;
        private Button button1;
        private ColorDialog colorDialog1;
    }
}