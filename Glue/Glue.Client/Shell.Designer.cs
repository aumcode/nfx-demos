namespace Glue.Client
{
    partial class Shell
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.responceEchoLabel = new System.Windows.Forms.Label();
            this.echoButton = new System.Windows.Forms.Button();
            this.inputEchoTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 544);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputEchoTextBox);
            this.tabPage1.Controls.Add(this.echoButton);
            this.tabPage1.Controls.Add(this.responceEchoLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Echo Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // responceEchoLabel
            // 
            this.responceEchoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responceEchoLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responceEchoLabel.Location = new System.Drawing.Point(3, 3);
            this.responceEchoLabel.Name = "responceEchoLabel";
            this.responceEchoLabel.Size = new System.Drawing.Size(754, 505);
            this.responceEchoLabel.TabIndex = 2;
            this.responceEchoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // echoButton
            // 
            this.echoButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.echoButton.Location = new System.Drawing.Point(526, 67);
            this.echoButton.Name = "echoButton";
            this.echoButton.Size = new System.Drawing.Size(92, 35);
            this.echoButton.TabIndex = 1;
            this.echoButton.Text = "Send";
            this.echoButton.UseVisualStyleBackColor = true;
            this.echoButton.Click += new System.EventHandler(this.echoButton_Click);
            // 
            // inputEchoTextBox
            // 
            this.inputEchoTextBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputEchoTextBox.Location = new System.Drawing.Point(187, 67);
            this.inputEchoTextBox.Name = "inputEchoTextBox";
            this.inputEchoTextBox.Size = new System.Drawing.Size(333, 32);
            this.inputEchoTextBox.TabIndex = 0;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 543);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Shell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button echoButton;
        private System.Windows.Forms.TextBox inputEchoTextBox;
        private System.Windows.Forms.Label responceEchoLabel;
    }
}