
namespace FitnessApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Users = new System.Windows.Forms.ListBox();
            this.label_UserInfo = new System.Windows.Forms.Label();
            this.button_AddAction = new System.Windows.Forms.Button();
            this.button_ShowAllUsers = new System.Windows.Forms.Button();
            this.button_ClearListUsers = new System.Windows.Forms.Button();
            this.comboBox_Action = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Exercise = new System.Windows.Forms.Label();
            this.label_Eating = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Users
            // 
            this.listBox_Users.FormattingEnabled = true;
            this.listBox_Users.ItemHeight = 16;
            this.listBox_Users.Location = new System.Drawing.Point(12, 12);
            this.listBox_Users.Name = "listBox_Users";
            this.listBox_Users.Size = new System.Drawing.Size(203, 244);
            this.listBox_Users.TabIndex = 0;
            this.listBox_Users.SelectedIndexChanged += new System.EventHandler(this.listBox_Users_SelectedIndexChanged);
            // 
            // label_UserInfo
            // 
            this.label_UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_UserInfo.Location = new System.Drawing.Point(12, 259);
            this.label_UserInfo.Name = "label_UserInfo";
            this.label_UserInfo.Size = new System.Drawing.Size(203, 182);
            this.label_UserInfo.TabIndex = 2;
            // 
            // button_AddAction
            // 
            this.button_AddAction.Location = new System.Drawing.Point(219, 194);
            this.button_AddAction.Name = "button_AddAction";
            this.button_AddAction.Size = new System.Drawing.Size(203, 40);
            this.button_AddAction.TabIndex = 3;
            this.button_AddAction.Text = "Add action";
            this.button_AddAction.UseVisualStyleBackColor = true;
            this.button_AddAction.Click += new System.EventHandler(this.button_AddAction_Click);
            // 
            // button_ShowAllUsers
            // 
            this.button_ShowAllUsers.Location = new System.Drawing.Point(221, 13);
            this.button_ShowAllUsers.Name = "button_ShowAllUsers";
            this.button_ShowAllUsers.Size = new System.Drawing.Size(203, 40);
            this.button_ShowAllUsers.TabIndex = 4;
            this.button_ShowAllUsers.Text = "Show all users";
            this.button_ShowAllUsers.UseVisualStyleBackColor = true;
            this.button_ShowAllUsers.Click += new System.EventHandler(this.button_ShowAllUsers_Click);
            // 
            // button_ClearListUsers
            // 
            this.button_ClearListUsers.Location = new System.Drawing.Point(221, 59);
            this.button_ClearListUsers.Name = "button_ClearListUsers";
            this.button_ClearListUsers.Size = new System.Drawing.Size(201, 32);
            this.button_ClearListUsers.TabIndex = 5;
            this.button_ClearListUsers.Text = "clear the list of users shown";
            this.button_ClearListUsers.UseVisualStyleBackColor = true;
            this.button_ClearListUsers.Click += new System.EventHandler(this.button_ClearListUsers_Click);
            // 
            // comboBox_Action
            // 
            this.comboBox_Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Action.FormattingEnabled = true;
            this.comboBox_Action.Items.AddRange(new object[] {
            "Enter eating",
            "Enter exercise"});
            this.comboBox_Action.Location = new System.Drawing.Point(220, 164);
            this.comboBox_Action.Name = "comboBox_Action";
            this.comboBox_Action.Size = new System.Drawing.Size(202, 24);
            this.comboBox_Action.TabIndex = 6;
            this.comboBox_Action.SelectedIndexChanged += new System.EventHandler(this.comboBox_Action_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose action:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(481, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 281);
            this.panel1.TabIndex = 8;
            // 
            // label_Exercise
            // 
            this.label_Exercise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Exercise.Location = new System.Drawing.Point(481, 320);
            this.label_Exercise.Name = "label_Exercise";
            this.label_Exercise.Size = new System.Drawing.Size(307, 115);
            this.label_Exercise.TabIndex = 9;
            // 
            // label_Eating
            // 
            this.label_Eating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Eating.Location = new System.Drawing.Point(219, 259);
            this.label_Eating.Name = "label_Eating";
            this.label_Eating.Size = new System.Drawing.Size(256, 182);
            this.label_Eating.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "List of exercise:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Eating);
            this.Controls.Add(this.label_Exercise);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Action);
            this.Controls.Add(this.button_ClearListUsers);
            this.Controls.Add(this.button_ShowAllUsers);
            this.Controls.Add(this.button_AddAction);
            this.Controls.Add(this.label_UserInfo);
            this.Controls.Add(this.listBox_Users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Users;
        private System.Windows.Forms.Label label_UserInfo;
        private System.Windows.Forms.Button button_AddAction;
        private System.Windows.Forms.Button button_ShowAllUsers;
        private System.Windows.Forms.Button button_ClearListUsers;
        private System.Windows.Forms.ComboBox comboBox_Action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Exercise;
        private System.Windows.Forms.Label label_Eating;
        private System.Windows.Forms.Label label2;
    }
}

