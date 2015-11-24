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
            this.tabEcho = new System.Windows.Forms.TabPage();
            this.inputEcho = new System.Windows.Forms.TextBox();
            this.buttonEcho = new System.Windows.Forms.Button();
            this.responceEcho = new System.Windows.Forms.Label();
            this.tabStateful = new System.Windows.Forms.TabPage();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.inputAdd = new System.Windows.Forms.TextBox();
            this.responceState = new System.Windows.Forms.Label();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.tabDataContract = new System.Windows.Forms.TabPage();
            this.personName = new System.Windows.Forms.Label();
            this.personDOB = new System.Windows.Forms.Label();
            this.personHeight = new System.Windows.Forms.Label();
            this.personCitizenship = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.citizenshipBox = new System.Windows.Forms.ComboBox();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.addPersonResult = new System.Windows.Forms.Label();
            this.findBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.findResult = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabEcho.SuspendLayout();
            this.tabStateful.SuspendLayout();
            this.tabDataContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabEcho);
            this.tabControl.Controls.Add(this.tabStateful);
            this.tabControl.Controls.Add(this.tabDataContract);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 544);
            this.tabControl.TabIndex = 0;
            // 
            // tabEcho
            // 
            this.tabEcho.Controls.Add(this.inputEcho);
            this.tabEcho.Controls.Add(this.buttonEcho);
            this.tabEcho.Controls.Add(this.responceEcho);
            this.tabEcho.Location = new System.Drawing.Point(4, 29);
            this.tabEcho.Name = "tabEcho";
            this.tabEcho.Padding = new System.Windows.Forms.Padding(3);
            this.tabEcho.Size = new System.Drawing.Size(760, 511);
            this.tabEcho.TabIndex = 0;
            this.tabEcho.Text = "Echo Test";
            this.tabEcho.UseVisualStyleBackColor = true;
            // 
            // inputEcho
            // 
            this.inputEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputEcho.Location = new System.Drawing.Point(187, 67);
            this.inputEcho.Name = "inputEcho";
            this.inputEcho.Size = new System.Drawing.Size(333, 32);
            this.inputEcho.TabIndex = 0;
            // 
            // buttonEcho
            // 
            this.buttonEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEcho.Location = new System.Drawing.Point(526, 67);
            this.buttonEcho.Name = "buttonEcho";
            this.buttonEcho.Size = new System.Drawing.Size(92, 36);
            this.buttonEcho.TabIndex = 1;
            this.buttonEcho.Text = "Send";
            this.buttonEcho.UseVisualStyleBackColor = true;
            this.buttonEcho.Click += new System.EventHandler(this.OnButtonEchoClick);
            // 
            // responceEcho
            // 
            this.responceEcho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responceEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responceEcho.Location = new System.Drawing.Point(3, 3);
            this.responceEcho.Name = "responceEcho";
            this.responceEcho.Size = new System.Drawing.Size(754, 505);
            this.responceEcho.TabIndex = 2;
            this.responceEcho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabStateful
            // 
            this.tabStateful.Controls.Add(this.buttonDone);
            this.tabStateful.Controls.Add(this.buttonInit);
            this.tabStateful.Controls.Add(this.buttonResult);
            this.tabStateful.Controls.Add(this.buttonAdd);
            this.tabStateful.Controls.Add(this.inputAdd);
            this.tabStateful.Controls.Add(this.responceState);
            this.tabStateful.Location = new System.Drawing.Point(4, 29);
            this.tabStateful.Name = "tabStateful";
            this.tabStateful.Size = new System.Drawing.Size(760, 511);
            this.tabStateful.TabIndex = 1;
            this.tabStateful.Text = "Stateful Test";
            this.tabStateful.UseVisualStyleBackColor = true;
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(337, 142);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(92, 36);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.OnButtonStatelessResultClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(385, 79);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OnButtonStatelessAddClick);
            // 
            // inputAdd
            // 
            this.inputAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAdd.Location = new System.Drawing.Point(286, 79);
            this.inputAdd.Name = "inputAdd";
            this.inputAdd.Size = new System.Drawing.Size(93, 32);
            this.inputAdd.TabIndex = 1;
            // 
            // responceState
            // 
            this.responceState.Font = new System.Drawing.Font("Verdana", 10F);
            this.responceState.Location = new System.Drawing.Point(3, 215);
            this.responceState.Name = "responceState";
            this.responceState.Size = new System.Drawing.Size(757, 30);
            this.responceState.TabIndex = 4;
            this.responceState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInit
            // 
            this.buttonInit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInit.Location = new System.Drawing.Point(287, 37);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(92, 36);
            this.buttonInit.TabIndex = 5;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.Location = new System.Drawing.Point(385, 37);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(92, 36);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            // 
            // tabDataContract
            // 
            this.tabDataContract.AutoScroll = true;
            this.tabDataContract.Controls.Add(this.findResult);
            this.tabDataContract.Controls.Add(this.findButton);
            this.tabDataContract.Controls.Add(this.findBox);
            this.tabDataContract.Controls.Add(this.addPersonResult);
            this.tabDataContract.Controls.Add(this.buttonAddPerson);
            this.tabDataContract.Controls.Add(this.citizenshipBox);
            this.tabDataContract.Controls.Add(this.dobBox);
            this.tabDataContract.Controls.Add(this.heightBox);
            this.tabDataContract.Controls.Add(this.nameBox);
            this.tabDataContract.Controls.Add(this.personCitizenship);
            this.tabDataContract.Controls.Add(this.personHeight);
            this.tabDataContract.Controls.Add(this.personDOB);
            this.tabDataContract.Controls.Add(this.personName);
            this.tabDataContract.Location = new System.Drawing.Point(4, 29);
            this.tabDataContract.Name = "tabDataContract";
            this.tabDataContract.Size = new System.Drawing.Size(760, 511);
            this.tabDataContract.TabIndex = 2;
            this.tabDataContract.Text = "Data Contract Test";
            this.tabDataContract.UseVisualStyleBackColor = true;
            // 
            // personName
            // 
            this.personName.Font = new System.Drawing.Font("Verdana", 10F);
            this.personName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personName.Location = new System.Drawing.Point(208, 53);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(144, 30);
            this.personName.TabIndex = 5;
            this.personName.Text = "Name";
            this.personName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personDOB
            // 
            this.personDOB.Font = new System.Drawing.Font("Verdana", 10F);
            this.personDOB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personDOB.Location = new System.Drawing.Point(208, 86);
            this.personDOB.Name = "personDOB";
            this.personDOB.Size = new System.Drawing.Size(144, 30);
            this.personDOB.TabIndex = 6;
            this.personDOB.Text = "Date of Birth";
            this.personDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personHeight
            // 
            this.personHeight.Font = new System.Drawing.Font("Verdana", 10F);
            this.personHeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personHeight.Location = new System.Drawing.Point(208, 123);
            this.personHeight.Name = "personHeight";
            this.personHeight.Size = new System.Drawing.Size(144, 30);
            this.personHeight.TabIndex = 7;
            this.personHeight.Text = "Height";
            this.personHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personCitizenship
            // 
            this.personCitizenship.Font = new System.Drawing.Font("Verdana", 10F);
            this.personCitizenship.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personCitizenship.Location = new System.Drawing.Point(208, 160);
            this.personCitizenship.Name = "personCitizenship";
            this.personCitizenship.Size = new System.Drawing.Size(144, 30);
            this.personCitizenship.TabIndex = 8;
            this.personCitizenship.Text = "Citizenship";
            this.personCitizenship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(358, 51);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 32);
            this.nameBox.TabIndex = 9;
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightBox.Location = new System.Drawing.Point(358, 121);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(200, 32);
            this.heightBox.TabIndex = 10;
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(358, 89);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(200, 26);
            this.dobBox.TabIndex = 11;
            // 
            // citizenshipBox
            // 
            this.citizenshipBox.FormattingEnabled = true;
            this.citizenshipBox.Location = new System.Drawing.Point(358, 160);
            this.citizenshipBox.Name = "citizenshipBox";
            this.citizenshipBox.Size = new System.Drawing.Size(200, 28);
            this.citizenshipBox.TabIndex = 12;
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPerson.Location = new System.Drawing.Point(358, 203);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(92, 36);
            this.buttonAddPerson.TabIndex = 13;
            this.buttonAddPerson.Text = "Add";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.OnButtonAddPersonClick);
            // 
            // addPersonResult
            // 
            this.addPersonResult.Font = new System.Drawing.Font("Verdana", 10F);
            this.addPersonResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPersonResult.Location = new System.Drawing.Point(3, 257);
            this.addPersonResult.Name = "addPersonResult";
            this.addPersonResult.Size = new System.Drawing.Size(754, 30);
            this.addPersonResult.TabIndex = 14;
            this.addPersonResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findBox
            // 
            this.findBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBox.Location = new System.Drawing.Point(213, 312);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(211, 32);
            this.findBox.TabIndex = 15;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(430, 309);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(92, 36);
            this.findButton.TabIndex = 16;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.OnButtonFindPersonClick);
            // 
            // findResult
            // 
            this.findResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findResult.Font = new System.Drawing.Font("Verdana", 8F);
            this.findResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findResult.Location = new System.Drawing.Point(3, 363);
            this.findResult.Name = "findResult";
            this.findResult.Size = new System.Drawing.Size(754, 128);
            this.findResult.TabIndex = 17;
            this.findResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 543);
            this.Controls.Add(this.tabControl);
            this.Name = "Shell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell";
            this.tabControl.ResumeLayout(false);
            this.tabEcho.ResumeLayout(false);
            this.tabEcho.PerformLayout();
            this.tabStateful.ResumeLayout(false);
            this.tabStateful.PerformLayout();
            this.tabDataContract.ResumeLayout(false);
            this.tabDataContract.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEcho;
        private System.Windows.Forms.Button buttonEcho;
        private System.Windows.Forms.TextBox inputEcho;
        private System.Windows.Forms.Label responceEcho;
        private System.Windows.Forms.TabPage tabStateful;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox inputAdd;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label responceState;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TabPage tabDataContract;
        private System.Windows.Forms.Label personName;
        private System.Windows.Forms.Label personDOB;
        private System.Windows.Forms.Label personHeight;
        private System.Windows.Forms.Label personCitizenship;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DateTimePicker dobBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.ComboBox citizenshipBox;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Label addPersonResult;
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label findResult;
    }
}