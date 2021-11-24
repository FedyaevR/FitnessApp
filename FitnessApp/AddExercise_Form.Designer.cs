
namespace FitnessApp
{
    partial class AddExercise_Form
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
            this.textBox_ExerciseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Energy = new System.Windows.Forms.TextBox();
            this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_EndTime = new System.Windows.Forms.DateTimePicker();
            this.button_Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ExerciseName
            // 
            this.textBox_ExerciseName.Location = new System.Drawing.Point(12, 26);
            this.textBox_ExerciseName.Name = "textBox_ExerciseName";
            this.textBox_ExerciseName.Size = new System.Drawing.Size(198, 22);
            this.textBox_ExerciseName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter exercise name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter energy consumption:";
            // 
            // textBox_Energy
            // 
            this.textBox_Energy.Location = new System.Drawing.Point(12, 71);
            this.textBox_Energy.Name = "textBox_Energy";
            this.textBox_Energy.Size = new System.Drawing.Size(198, 22);
            this.textBox_Energy.TabIndex = 3;
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(12, 118);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_StartTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter time of start exercise:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter time of end exercise:";
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(12, 163);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_EndTime.TabIndex = 7;
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(12, 191);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(75, 23);
            this.button_Done.TabIndex = 8;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // AddExercise_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.dateTimePicker_EndTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_StartTime);
            this.Controls.Add(this.textBox_Energy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ExerciseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExercise_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExercise_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ExerciseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Energy;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndTime;
        private System.Windows.Forms.Button button_Done;
    }
}