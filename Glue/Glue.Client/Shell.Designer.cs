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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shell));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEcho = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.inputEcho = new System.Windows.Forms.TextBox();
            this.buttonEcho = new System.Windows.Forms.Button();
            this.responceEcho = new System.Windows.Forms.Label();
            this.tabStateful = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.inputAdd = new System.Windows.Forms.TextBox();
            this.responseState = new System.Windows.Forms.Label();
            this.tabDataContract = new System.Windows.Forms.TabPage();
            this.dataContractResult = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.findBox = new System.Windows.Forms.TextBox();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.citizenshipBox = new System.Windows.Forms.ComboBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.personCitizenship = new System.Windows.Forms.Label();
            this.personHeight = new System.Windows.Forms.Label();
            this.personDOB = new System.Windows.Forms.Label();
            this.personName = new System.Windows.Forms.Label();
            this.tabHighLoad = new System.Windows.Forms.TabPage();
            this.chkParallel = new System.Windows.Forms.CheckBox();
            this.totalTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.performance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startElemButton = new System.Windows.Forms.Button();
            this.highLoadResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabEcho.SuspendLayout();
            this.tabStateful.SuspendLayout();
            this.tabDataContract.SuspendLayout();
            this.tabHighLoad.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabHighLoad);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 544);
            this.tabControl.TabIndex = 0;
            // 
            // tabEcho
            // 
            this.tabEcho.Controls.Add(this.label4);
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 8F);
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(717, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "A simple echo server. Type any text in the textbox and press \'Send\' button.\r\nYou " +
    "should see server responce below.";
            // 
            // inputEcho
            // 
            this.inputEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputEcho.Location = new System.Drawing.Point(172, 138);
            this.inputEcho.Name = "inputEcho";
            this.inputEcho.Size = new System.Drawing.Size(333, 32);
            this.inputEcho.TabIndex = 0;
            // 
            // buttonEcho
            // 
            this.buttonEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEcho.Location = new System.Drawing.Point(511, 138);
            this.buttonEcho.Name = "buttonEcho";
            this.buttonEcho.Size = new System.Drawing.Size(92, 36);
            this.buttonEcho.TabIndex = 1;
            this.buttonEcho.Text = "Send";
            this.buttonEcho.UseVisualStyleBackColor = true;
            this.buttonEcho.Click += new System.EventHandler(this.OnButtonEchoClick);
            // 
            // responceEcho
            // 
            this.responceEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responceEcho.Location = new System.Drawing.Point(3, 218);
            this.responceEcho.Name = "responceEcho";
            this.responceEcho.Size = new System.Drawing.Size(754, 290);
            this.responceEcho.TabIndex = 2;
            this.responceEcho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabStateful
            // 
            this.tabStateful.Controls.Add(this.label3);
            this.tabStateful.Controls.Add(this.buttonDone);
            this.tabStateful.Controls.Add(this.buttonInit);
            this.tabStateful.Controls.Add(this.buttonResult);
            this.tabStateful.Controls.Add(this.buttonAdd);
            this.tabStateful.Controls.Add(this.inputAdd);
            this.tabStateful.Controls.Add(this.responseState);
            this.tabStateful.Location = new System.Drawing.Point(4, 29);
            this.tabStateful.Name = "tabStateful";
            this.tabStateful.Size = new System.Drawing.Size(760, 511);
            this.tabStateful.TabIndex = 1;
            this.tabStateful.Text = "Stateful Test";
            this.tabStateful.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 8F);
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(717, 129);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // buttonDone
            // 
            this.buttonDone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.Location = new System.Drawing.Point(387, 190);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(92, 36);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.OnButtonStatelessDoneClick);
            // 
            // buttonInit
            // 
            this.buttonInit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInit.Location = new System.Drawing.Point(289, 190);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(92, 36);
            this.buttonInit.TabIndex = 5;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.OnButtonStatelessInitClick);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(339, 295);
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
            this.buttonAdd.Location = new System.Drawing.Point(387, 232);
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
            this.inputAdd.Location = new System.Drawing.Point(288, 232);
            this.inputAdd.Name = "inputAdd";
            this.inputAdd.Size = new System.Drawing.Size(93, 32);
            this.inputAdd.TabIndex = 1;
            // 
            // responseState
            // 
            this.responseState.Font = new System.Drawing.Font("Verdana", 8F);
            this.responseState.Location = new System.Drawing.Point(3, 363);
            this.responseState.Name = "responseState";
            this.responseState.Size = new System.Drawing.Size(757, 142);
            this.responseState.TabIndex = 4;
            this.responseState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDataContract
            // 
            this.tabDataContract.AutoScroll = true;
            this.tabDataContract.Controls.Add(this.label7);
            this.tabDataContract.Controls.Add(this.dataContractResult);
            this.tabDataContract.Controls.Add(this.findButton);
            this.tabDataContract.Controls.Add(this.findBox);
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
            // dataContractResult
            // 
            this.dataContractResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataContractResult.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataContractResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataContractResult.Location = new System.Drawing.Point(3, 328);
            this.dataContractResult.Name = "dataContractResult";
            this.dataContractResult.Size = new System.Drawing.Size(754, 183);
            this.dataContractResult.TabIndex = 17;
            this.dataContractResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(665, 136);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(92, 36);
            this.findButton.TabIndex = 16;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.OnButtonFindPersonClick);
            // 
            // findBox
            // 
            this.findBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBox.Location = new System.Drawing.Point(448, 139);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(211, 32);
            this.findBox.TabIndex = 15;
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPerson.Location = new System.Drawing.Point(168, 259);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(92, 36);
            this.buttonAddPerson.TabIndex = 13;
            this.buttonAddPerson.Text = "Add";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.OnButtonAddPersonClick);
            // 
            // citizenshipBox
            // 
            this.citizenshipBox.FormattingEnabled = true;
            this.citizenshipBox.Location = new System.Drawing.Point(168, 216);
            this.citizenshipBox.Name = "citizenshipBox";
            this.citizenshipBox.Size = new System.Drawing.Size(200, 28);
            this.citizenshipBox.TabIndex = 12;
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(168, 145);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(200, 26);
            this.dobBox.TabIndex = 11;
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightBox.Location = new System.Drawing.Point(168, 177);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(200, 32);
            this.heightBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(168, 107);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 32);
            this.nameBox.TabIndex = 9;
            // 
            // personCitizenship
            // 
            this.personCitizenship.Font = new System.Drawing.Font("Verdana", 10F);
            this.personCitizenship.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personCitizenship.Location = new System.Drawing.Point(18, 216);
            this.personCitizenship.Name = "personCitizenship";
            this.personCitizenship.Size = new System.Drawing.Size(144, 30);
            this.personCitizenship.TabIndex = 8;
            this.personCitizenship.Text = "Citizenship";
            this.personCitizenship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personHeight
            // 
            this.personHeight.Font = new System.Drawing.Font("Verdana", 10F);
            this.personHeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personHeight.Location = new System.Drawing.Point(18, 179);
            this.personHeight.Name = "personHeight";
            this.personHeight.Size = new System.Drawing.Size(144, 30);
            this.personHeight.TabIndex = 7;
            this.personHeight.Text = "Height";
            this.personHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personDOB
            // 
            this.personDOB.Font = new System.Drawing.Font("Verdana", 10F);
            this.personDOB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personDOB.Location = new System.Drawing.Point(18, 142);
            this.personDOB.Name = "personDOB";
            this.personDOB.Size = new System.Drawing.Size(144, 30);
            this.personDOB.TabIndex = 6;
            this.personDOB.Text = "Date of Birth";
            this.personDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personName
            // 
            this.personName.Font = new System.Drawing.Font("Verdana", 10F);
            this.personName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personName.Location = new System.Drawing.Point(18, 109);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(144, 30);
            this.personName.TabIndex = 5;
            this.personName.Text = "Name";
            this.personName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabHighLoad
            // 
            this.tabHighLoad.Controls.Add(this.label1);
            this.tabHighLoad.Controls.Add(this.highLoadResult);
            this.tabHighLoad.Controls.Add(this.chkParallel);
            this.tabHighLoad.Controls.Add(this.totalTime);
            this.tabHighLoad.Controls.Add(this.label6);
            this.tabHighLoad.Controls.Add(this.label5);
            this.tabHighLoad.Controls.Add(this.iterationsBox);
            this.tabHighLoad.Controls.Add(this.performance);
            this.tabHighLoad.Controls.Add(this.label2);
            this.tabHighLoad.Controls.Add(this.startElemButton);
            this.tabHighLoad.Location = new System.Drawing.Point(4, 29);
            this.tabHighLoad.Name = "tabHighLoad";
            this.tabHighLoad.Size = new System.Drawing.Size(760, 511);
            this.tabHighLoad.TabIndex = 3;
            this.tabHighLoad.Text = "High Load Test";
            this.tabHighLoad.UseVisualStyleBackColor = true;
            // 
            // chkParallel
            // 
            this.chkParallel.AutoSize = true;
            this.chkParallel.Location = new System.Drawing.Point(355, 162);
            this.chkParallel.Name = "chkParallel";
            this.chkParallel.Size = new System.Drawing.Size(85, 24);
            this.chkParallel.TabIndex = 25;
            this.chkParallel.Text = "parallel";
            this.chkParallel.UseVisualStyleBackColor = true;
            // 
            // totalTime
            // 
            this.totalTime.Font = new System.Drawing.Font("Verdana", 10F);
            this.totalTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalTime.Location = new System.Drawing.Point(433, 213);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(96, 30);
            this.totalTime.TabIndex = 24;
            this.totalTime.Text = "-";
            this.totalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(248, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "total time (ms):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(215, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "iterations";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iterationsBox
            // 
            this.iterationsBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterationsBox.Location = new System.Drawing.Point(327, 109);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(148, 32);
            this.iterationsBox.TabIndex = 21;
            // 
            // performance
            // 
            this.performance.Font = new System.Drawing.Font("Verdana", 10F);
            this.performance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.performance.Location = new System.Drawing.Point(433, 254);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(96, 30);
            this.performance.TabIndex = 19;
            this.performance.Text = "-";
            this.performance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(333, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "ops/sec:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startElemButton
            // 
            this.startElemButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startElemButton.Location = new System.Drawing.Point(481, 109);
            this.startElemButton.Name = "startElemButton";
            this.startElemButton.Size = new System.Drawing.Size(92, 36);
            this.startElemButton.TabIndex = 14;
            this.startElemButton.Text = "Start";
            this.startElemButton.UseVisualStyleBackColor = true;
            this.startElemButton.Click += new System.EventHandler(this.OnButtonElemStartClick);
            // 
            // highLoadResult
            // 
            this.highLoadResult.Font = new System.Drawing.Font("Verdana", 8F);
            this.highLoadResult.Location = new System.Drawing.Point(0, 328);
            this.highLoadResult.Name = "highLoadResult";
            this.highLoadResult.Size = new System.Drawing.Size(757, 183);
            this.highLoadResult.TabIndex = 26;
            this.highLoadResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 8F);
            this.label7.Location = new System.Drawing.Point(20, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(717, 67);
            this.label7.TabIndex = 18;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8F);
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 59);
            this.label1.TabIndex = 27;
            this.label1.Text = "The imitation of hight-load server.\r\nEnter iterations number and press \'Start\'. Y" +
    "ou can also choose between parallel and syncronous version of the test.";
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
            this.tabHighLoad.ResumeLayout(false);
            this.tabHighLoad.PerformLayout();
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
        private System.Windows.Forms.Label responseState;
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
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label dataContractResult;
        private System.Windows.Forms.TabPage tabHighLoad;
        private System.Windows.Forms.Button startElemButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label performance;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.CheckBox chkParallel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label highLoadResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}