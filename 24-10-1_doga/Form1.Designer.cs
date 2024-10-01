
namespace _24_10_1_doga
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.nameTExt = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.mennyiseg = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.ár = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 251);
            this.listBox1.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(199, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // nameTExt
            // 
            this.nameTExt.Location = new System.Drawing.Point(240, 41);
            this.nameTExt.Name = "nameTExt";
            this.nameTExt.Size = new System.Drawing.Size(100, 20);
            this.nameTExt.TabIndex = 2;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(240, 100);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(100, 20);
            this.quantityText.TabIndex = 4;
            // 
            // mennyiseg
            // 
            this.mennyiseg.AutoSize = true;
            this.mennyiseg.Location = new System.Drawing.Point(177, 103);
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.Size = new System.Drawing.Size(58, 13);
            this.mennyiseg.TabIndex = 3;
            this.mennyiseg.Text = "Mennyiség";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(240, 161);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 20);
            this.priceText.TabIndex = 6;
            // 
            // ár
            // 
            this.ár.AutoSize = true;
            this.ár.Location = new System.Drawing.Point(199, 164);
            this.ár.Name = "ár";
            this.ár.Size = new System.Drawing.Size(17, 13);
            this.ár.TabIndex = 5;
            this.ár.Text = "Ár";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(188, 231);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "button1";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(294, 231);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "button2";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 292);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.ár);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.mennyiseg);
            this.Controls.Add(this.nameTExt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameTExt;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label mennyiseg;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label ár;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

