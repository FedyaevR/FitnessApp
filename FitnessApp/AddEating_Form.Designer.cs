
namespace FitnessApp
{
    partial class AddEating_Form
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Callories = new System.Windows.Forms.TextBox();
            this.textBox_Proteins = new System.Windows.Forms.TextBox();
            this.textBox_Fats = new System.Windows.Forms.TextBox();
            this.textBox_Carbohydrates = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 33);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(143, 22);
            this.textBox_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product name:";
            // 
            // textBox_Callories
            // 
            this.textBox_Callories.Location = new System.Drawing.Point(83, 80);
            this.textBox_Callories.Name = "textBox_Callories";
            this.textBox_Callories.Size = new System.Drawing.Size(51, 22);
            this.textBox_Callories.TabIndex = 2;
            // 
            // textBox_Proteins
            // 
            this.textBox_Proteins.Location = new System.Drawing.Point(83, 108);
            this.textBox_Proteins.Name = "textBox_Proteins";
            this.textBox_Proteins.Size = new System.Drawing.Size(51, 22);
            this.textBox_Proteins.TabIndex = 3;
            // 
            // textBox_Fats
            // 
            this.textBox_Fats.Location = new System.Drawing.Point(83, 139);
            this.textBox_Fats.Name = "textBox_Fats";
            this.textBox_Fats.Size = new System.Drawing.Size(51, 22);
            this.textBox_Fats.TabIndex = 4;
            // 
            // textBox_Carbohydrates
            // 
            this.textBox_Carbohydrates.Location = new System.Drawing.Point(83, 167);
            this.textBox_Carbohydrates.Multiline = true;
            this.textBox_Carbohydrates.Name = "textBox_Carbohydrates";
            this.textBox_Carbohydrates.Size = new System.Drawing.Size(51, 38);
            this.textBox_Carbohydrates.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Callories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proteins:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fats:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Carbohydrates:";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(226, 80);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(51, 22);
            this.textBox_Weight.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Weight :";
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(202, 167);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(75, 23);
            this.button_Done.TabIndex = 12;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // AddEating_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Carbohydrates);
            this.Controls.Add(this.textBox_Fats);
            this.Controls.Add(this.textBox_Proteins);
            this.Controls.Add(this.textBox_Callories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEating_Form";
            this.Text = "AddEating_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Callories;
        private System.Windows.Forms.TextBox textBox_Proteins;
        private System.Windows.Forms.TextBox textBox_Fats;
        private System.Windows.Forms.TextBox textBox_Carbohydrates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Done;
    }
}