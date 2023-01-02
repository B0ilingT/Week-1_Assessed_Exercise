
namespace Assessed_Exercise_task_A
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
            this.inputTaskTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.currentTaskTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTaskTextBox
            // 
            this.inputTaskTextBox.Location = new System.Drawing.Point(162, 47);
            this.inputTaskTextBox.Multiline = true;
            this.inputTaskTextBox.Name = "inputTaskTextBox";
            this.inputTaskTextBox.Size = new System.Drawing.Size(125, 81);
            this.inputTaskTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(293, 46);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Location = new System.Drawing.Point(393, 179);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(102, 29);
            this.removeTaskButton.TabIndex = 2;
            this.removeTaskButton.Text = "Completed";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter a task:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Task:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(452, 108);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(17, 20);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "0";
            this.countLabel.Click += new System.EventHandler(this.countLabel_Click);
            // 
            // currentTaskTextBox
            // 
            this.currentTaskTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentTaskTextBox.Location = new System.Drawing.Point(162, 179);
            this.currentTaskTextBox.Multiline = true;
            this.currentTaskTextBox.Name = "currentTaskTextBox";
            this.currentTaskTextBox.ReadOnly = true;
            this.currentTaskTextBox.Size = new System.Drawing.Size(225, 82);
            this.currentTaskTextBox.TabIndex = 7;
            this.currentTaskTextBox.TextChanged += new System.EventHandler(this.currentTaskTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of tasks to-do:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentTaskTextBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.inputTaskTextBox);
            this.Name = "Form1";
            this.Text = "To do list";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTaskTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox currentTaskTextBox;
        private System.Windows.Forms.Label label3;
    }
}

