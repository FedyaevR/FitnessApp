
namespace FitnessApp
{
    partial class AddUser_Form
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
            this.comboBox_UserGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_UserWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_UserHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_UserGender
            // 
            this.comboBox_UserGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UserGender.FormattingEnabled = true;
            this.comboBox_UserGender.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.comboBox_UserGender.Location = new System.Drawing.Point(15, 49);
            this.comboBox_UserGender.Name = "comboBox_UserGender";
            this.comboBox_UserGender.Size = new System.Drawing.Size(121, 24);
            this.comboBox_UserGender.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose your gender:";
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(298, 47);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_BirthDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input your birthdate:";
            // 
            // textBox_UserWeight
            // 
            this.textBox_UserWeight.Location = new System.Drawing.Point(298, 97);
            this.textBox_UserWeight.Name = "textBox_UserWeight";
            this.textBox_UserWeight.Size = new System.Drawing.Size(174, 22);
            this.textBox_UserWeight.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input your weight:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_UserHeight
            // 
            this.textBox_UserHeight.Location = new System.Drawing.Point(298, 143);
            this.textBox_UserHeight.Name = "textBox_UserHeight";
            this.textBox_UserHeight.Size = new System.Drawing.Size(174, 22);
            this.textBox_UserHeight.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Input your height:";
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(12, 142);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(120, 23);
            this.button_AddUser.TabIndex = 10;
            this.button_AddUser.Text = "Add user";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // AddUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 255);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_UserHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_UserWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_BirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_UserGender);
            this.Name = "AddUser_Form";
            this.Text = "AddUser_Formcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUser_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_UserGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_UserWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_UserHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_AddUser;
    }
}