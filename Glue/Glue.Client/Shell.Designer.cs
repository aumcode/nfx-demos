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
            this.tbEcho = new System.Windows.Forms.TextBox();
            this.btnEcho = new System.Windows.Forms.Button();
            this.resultEcho = new System.Windows.Forms.Label();
            this.tabStateful = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnStatefulResult = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.resultStateful = new System.Windows.Forms.Label();
            this.tabDataContract = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.resultDataContract = new System.Windows.Forms.Label();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.tbFindPerson = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cbCitizenship = new System.Windows.Forms.ComboBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbCitizenship = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tabHighLoad = new System.Windows.Forms.TabPage();
            this.chkOneWay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.highLoadResult = new System.Windows.Forms.Label();
            this.chkParallel = new System.Windows.Forms.CheckBox();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.lbPerformance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartHighLoad = new System.Windows.Forms.Button();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.chkPresident = new System.Windows.Forms.CheckBox();
            this.lblSecureResponse = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnSecureSend = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUPwd = new System.Windows.Forms.TextBox();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabEcho.SuspendLayout();
            this.tabStateful.SuspendLayout();
            this.tabDataContract.SuspendLayout();
            this.tabHighLoad.SuspendLayout();
            this.tabSecurity.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabSecurity);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(917, 690);
            this.tabControl.TabIndex = 0;
            // 
            // tabEcho
            // 
            this.tabEcho.Controls.Add(this.label4);
            this.tabEcho.Controls.Add(this.tbEcho);
            this.tabEcho.Controls.Add(this.btnEcho);
            this.tabEcho.Controls.Add(this.resultEcho);
            this.tabEcho.Location = new System.Drawing.Point(4, 29);
            this.tabEcho.Name = "tabEcho";
            this.tabEcho.Padding = new System.Windows.Forms.Padding(3);
            this.tabEcho.Size = new System.Drawing.Size(909, 657);
            this.tabEcho.TabIndex = 0;
            this.tabEcho.Text = "Echo Test";
            this.tabEcho.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(851, 58);
            this.label4.TabIndex = 8;
            this.label4.Text = "A simple echo server. Type any text in the textbox and press \'Send\' button.\r\nYou " +
    "should see server responce below.";
            // 
            // tbEcho
            // 
            this.tbEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEcho.Location = new System.Drawing.Point(241, 183);
            this.tbEcho.Name = "tbEcho";
            this.tbEcho.Size = new System.Drawing.Size(333, 32);
            this.tbEcho.TabIndex = 0;
            // 
            // btnEcho
            // 
            this.btnEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEcho.Location = new System.Drawing.Point(580, 183);
            this.btnEcho.Name = "btnEcho";
            this.btnEcho.Size = new System.Drawing.Size(92, 36);
            this.btnEcho.TabIndex = 1;
            this.btnEcho.Text = "Send";
            this.btnEcho.UseVisualStyleBackColor = true;
            this.btnEcho.Click += new System.EventHandler(this.OnButtonEchoClick);
            // 
            // resultEcho
            // 
            this.resultEcho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultEcho.Location = new System.Drawing.Point(3, 286);
            this.resultEcho.Name = "resultEcho";
            this.resultEcho.Size = new System.Drawing.Size(906, 371);
            this.resultEcho.TabIndex = 2;
            this.resultEcho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabStateful
            // 
            this.tabStateful.Controls.Add(this.label3);
            this.tabStateful.Controls.Add(this.btnDone);
            this.tabStateful.Controls.Add(this.btnInit);
            this.tabStateful.Controls.Add(this.btnStatefulResult);
            this.tabStateful.Controls.Add(this.btnAdd);
            this.tabStateful.Controls.Add(this.tbAdd);
            this.tabStateful.Controls.Add(this.resultStateful);
            this.tabStateful.Location = new System.Drawing.Point(4, 29);
            this.tabStateful.Name = "tabStateful";
            this.tabStateful.Size = new System.Drawing.Size(909, 657);
            this.tabStateful.TabIndex = 1;
            this.tabStateful.Text = "Stateful Test";
            this.tabStateful.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(879, 195);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDone.Location = new System.Drawing.Point(462, 256);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(92, 36);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.OnButtonStatelessDoneClick);
            // 
            // btnInit
            // 
            this.btnInit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInit.Location = new System.Drawing.Point(364, 256);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(92, 36);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.OnButtonStatelessInitClick);
            // 
            // btnStatefulResult
            // 
            this.btnStatefulResult.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatefulResult.Location = new System.Drawing.Point(414, 361);
            this.btnStatefulResult.Name = "btnStatefulResult";
            this.btnStatefulResult.Size = new System.Drawing.Size(92, 36);
            this.btnStatefulResult.TabIndex = 3;
            this.btnStatefulResult.Text = "Result";
            this.btnStatefulResult.UseVisualStyleBackColor = true;
            this.btnStatefulResult.Click += new System.EventHandler(this.OnButtonStatelessResultClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(462, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnButtonStatelessAddClick);
            // 
            // tbAdd
            // 
            this.tbAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdd.Location = new System.Drawing.Point(363, 298);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(93, 32);
            this.tbAdd.TabIndex = 1;
            // 
            // resultStateful
            // 
            this.resultStateful.Font = new System.Drawing.Font("Verdana", 10F);
            this.resultStateful.Location = new System.Drawing.Point(3, 424);
            this.resultStateful.Name = "resultStateful";
            this.resultStateful.Size = new System.Drawing.Size(906, 233);
            this.resultStateful.TabIndex = 4;
            this.resultStateful.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabDataContract
            // 
            this.tabDataContract.AutoScroll = true;
            this.tabDataContract.Controls.Add(this.label7);
            this.tabDataContract.Controls.Add(this.resultDataContract);
            this.tabDataContract.Controls.Add(this.btnFindPerson);
            this.tabDataContract.Controls.Add(this.tbFindPerson);
            this.tabDataContract.Controls.Add(this.btnAddPerson);
            this.tabDataContract.Controls.Add(this.cbCitizenship);
            this.tabDataContract.Controls.Add(this.dtDOB);
            this.tabDataContract.Controls.Add(this.tbHeight);
            this.tabDataContract.Controls.Add(this.tbName);
            this.tabDataContract.Controls.Add(this.lbCitizenship);
            this.tabDataContract.Controls.Add(this.lbHeight);
            this.tabDataContract.Controls.Add(this.lbDOB);
            this.tabDataContract.Controls.Add(this.lbName);
            this.tabDataContract.Location = new System.Drawing.Point(4, 29);
            this.tabDataContract.Name = "tabDataContract";
            this.tabDataContract.Size = new System.Drawing.Size(909, 657);
            this.tabDataContract.TabIndex = 2;
            this.tabDataContract.Text = "Data Contract Test";
            this.tabDataContract.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(878, 113);
            this.label7.TabIndex = 18;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // resultDataContract
            // 
            this.resultDataContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDataContract.Font = new System.Drawing.Font("Verdana", 10F);
            this.resultDataContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultDataContract.Location = new System.Drawing.Point(3, 447);
            this.resultDataContract.Name = "resultDataContract";
            this.resultDataContract.Size = new System.Drawing.Size(903, 210);
            this.resultDataContract.TabIndex = 17;
            this.resultDataContract.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindPerson.Location = new System.Drawing.Point(523, 387);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(92, 36);
            this.btnFindPerson.TabIndex = 16;
            this.btnFindPerson.Text = "Find";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.OnButtonFindPersonClick);
            // 
            // tbFindPerson
            // 
            this.tbFindPerson.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFindPerson.Location = new System.Drawing.Point(306, 390);
            this.tbFindPerson.Name = "tbFindPerson";
            this.tbFindPerson.Size = new System.Drawing.Size(211, 32);
            this.tbFindPerson.TabIndex = 15;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPerson.Location = new System.Drawing.Point(425, 317);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(92, 36);
            this.btnAddPerson.TabIndex = 13;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.OnButtonAddPersonClick);
            // 
            // cbCitizenship
            // 
            this.cbCitizenship.FormattingEnabled = true;
            this.cbCitizenship.Location = new System.Drawing.Point(425, 269);
            this.cbCitizenship.Name = "cbCitizenship";
            this.cbCitizenship.Size = new System.Drawing.Size(200, 28);
            this.cbCitizenship.TabIndex = 12;
            // 
            // dtDOB
            // 
            this.dtDOB.Font = new System.Drawing.Font("Verdana", 10F);
            this.dtDOB.Location = new System.Drawing.Point(425, 193);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(200, 32);
            this.dtDOB.TabIndex = 11;
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHeight.Location = new System.Drawing.Point(425, 231);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(200, 32);
            this.tbHeight.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(425, 155);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 32);
            this.tbName.TabIndex = 9;
            // 
            // lbCitizenship
            // 
            this.lbCitizenship.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbCitizenship.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCitizenship.Location = new System.Drawing.Point(275, 267);
            this.lbCitizenship.Name = "lbCitizenship";
            this.lbCitizenship.Size = new System.Drawing.Size(144, 30);
            this.lbCitizenship.TabIndex = 8;
            this.lbCitizenship.Text = "Citizenship";
            this.lbCitizenship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHeight
            // 
            this.lbHeight.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbHeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeight.Location = new System.Drawing.Point(275, 231);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(144, 30);
            this.lbHeight.TabIndex = 7;
            this.lbHeight.Text = "Height";
            this.lbHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDOB
            // 
            this.lbDOB.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbDOB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDOB.Location = new System.Drawing.Point(275, 193);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(144, 30);
            this.lbDOB.TabIndex = 6;
            this.lbDOB.Text = "Date of Birth";
            this.lbDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.Location = new System.Drawing.Point(275, 157);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(144, 30);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabHighLoad
            // 
            this.tabHighLoad.Controls.Add(this.chkOneWay);
            this.tabHighLoad.Controls.Add(this.label1);
            this.tabHighLoad.Controls.Add(this.highLoadResult);
            this.tabHighLoad.Controls.Add(this.chkParallel);
            this.tabHighLoad.Controls.Add(this.lbTotalTime);
            this.tabHighLoad.Controls.Add(this.label6);
            this.tabHighLoad.Controls.Add(this.label5);
            this.tabHighLoad.Controls.Add(this.tbIterations);
            this.tabHighLoad.Controls.Add(this.lbPerformance);
            this.tabHighLoad.Controls.Add(this.label2);
            this.tabHighLoad.Controls.Add(this.btnStartHighLoad);
            this.tabHighLoad.Location = new System.Drawing.Point(4, 29);
            this.tabHighLoad.Name = "tabHighLoad";
            this.tabHighLoad.Size = new System.Drawing.Size(909, 657);
            this.tabHighLoad.TabIndex = 3;
            this.tabHighLoad.Text = "High Load Test";
            this.tabHighLoad.UseVisualStyleBackColor = true;
            // 
            // chkOneWay
            // 
            this.chkOneWay.AutoSize = true;
            this.chkOneWay.Checked = true;
            this.chkOneWay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOneWay.Font = new System.Drawing.Font("Verdana", 10F);
            this.chkOneWay.Location = new System.Drawing.Point(373, 234);
            this.chkOneWay.Name = "chkOneWay";
            this.chkOneWay.Size = new System.Drawing.Size(124, 29);
            this.chkOneWay.TabIndex = 28;
            this.chkOneWay.Text = "one-way";
            this.chkOneWay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 92);
            this.label1.TabIndex = 27;
            this.label1.Text = "The imitation of hight-load server.\r\nEnter iterations number and press \'Start\'. Y" +
    "ou can also choose between parallel and syncronous version of the test.";
            // 
            // highLoadResult
            // 
            this.highLoadResult.Font = new System.Drawing.Font("Verdana", 10F);
            this.highLoadResult.Location = new System.Drawing.Point(3, 446);
            this.highLoadResult.Name = "highLoadResult";
            this.highLoadResult.Size = new System.Drawing.Size(903, 211);
            this.highLoadResult.TabIndex = 26;
            this.highLoadResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkParallel
            // 
            this.chkParallel.AutoSize = true;
            this.chkParallel.Font = new System.Drawing.Font("Verdana", 10F);
            this.chkParallel.Location = new System.Drawing.Point(373, 194);
            this.chkParallel.Name = "chkParallel";
            this.chkParallel.Size = new System.Drawing.Size(113, 29);
            this.chkParallel.TabIndex = 25;
            this.chkParallel.Text = "parallel";
            this.chkParallel.UseVisualStyleBackColor = true;
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbTotalTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTotalTime.Location = new System.Drawing.Point(429, 346);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(96, 30);
            this.lbTotalTime.TabIndex = 24;
            this.lbTotalTime.Text = "-";
            this.lbTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(244, 346);
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
            this.label5.Location = new System.Drawing.Point(261, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "iterations";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIterations
            // 
            this.tbIterations.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIterations.Location = new System.Drawing.Point(373, 142);
            this.tbIterations.Name = "tbIterations";
            this.tbIterations.Size = new System.Drawing.Size(148, 32);
            this.tbIterations.TabIndex = 21;
            // 
            // lbPerformance
            // 
            this.lbPerformance.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbPerformance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPerformance.Location = new System.Drawing.Point(429, 387);
            this.lbPerformance.Name = "lbPerformance";
            this.lbPerformance.Size = new System.Drawing.Size(96, 30);
            this.lbPerformance.TabIndex = 19;
            this.lbPerformance.Text = "-";
            this.lbPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(329, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "ops/sec:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartHighLoad
            // 
            this.btnStartHighLoad.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartHighLoad.Location = new System.Drawing.Point(373, 280);
            this.btnStartHighLoad.Name = "btnStartHighLoad";
            this.btnStartHighLoad.Size = new System.Drawing.Size(92, 36);
            this.btnStartHighLoad.TabIndex = 14;
            this.btnStartHighLoad.Text = "Start";
            this.btnStartHighLoad.UseVisualStyleBackColor = true;
            this.btnStartHighLoad.Click += new System.EventHandler(this.OnButtonElemStartClick);
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.chkPresident);
            this.tabSecurity.Controls.Add(this.lblSecureResponse);
            this.tabSecurity.Controls.Add(this.tbMessage);
            this.tabSecurity.Controls.Add(this.btnSecureSend);
            this.tabSecurity.Controls.Add(this.label10);
            this.tabSecurity.Controls.Add(this.label9);
            this.tabSecurity.Controls.Add(this.label8);
            this.tabSecurity.Controls.Add(this.tbUPwd);
            this.tabSecurity.Controls.Add(this.tbUID);
            this.tabSecurity.Location = new System.Drawing.Point(4, 29);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(909, 657);
            this.tabSecurity.TabIndex = 4;
            this.tabSecurity.Text = "Security Test";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // chkPresident
            // 
            this.chkPresident.AutoSize = true;
            this.chkPresident.Font = new System.Drawing.Font("Verdana", 10F);
            this.chkPresident.Location = new System.Drawing.Point(382, 238);
            this.chkPresident.Name = "chkPresident";
            this.chkPresident.Size = new System.Drawing.Size(132, 29);
            this.chkPresident.TabIndex = 8;
            this.chkPresident.Text = "president";
            this.chkPresident.UseVisualStyleBackColor = true;
            // 
            // lblSecureResponse
            // 
            this.lblSecureResponse.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecureResponse.Location = new System.Drawing.Point(3, 399);
            this.lblSecureResponse.Name = "lblSecureResponse";
            this.lblSecureResponse.Size = new System.Drawing.Size(906, 258);
            this.lblSecureResponse.TabIndex = 7;
            this.lblSecureResponse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.Location = new System.Drawing.Point(253, 316);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(333, 32);
            this.tbMessage.TabIndex = 5;
            // 
            // btnSecureSend
            // 
            this.btnSecureSend.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSecureSend.Location = new System.Drawing.Point(592, 316);
            this.btnSecureSend.Name = "btnSecureSend";
            this.btnSecureSend.Size = new System.Drawing.Size(92, 36);
            this.btnSecureSend.TabIndex = 6;
            this.btnSecureSend.Text = "Send";
            this.btnSecureSend.UseVisualStyleBackColor = true;
            this.btnSecureSend.Click += new System.EventHandler(this.btnSecureSend_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(297, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(361, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Use clinton/billy or obama/chicago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F);
            this.label9.Location = new System.Drawing.Point(254, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F);
            this.label8.Location = new System.Drawing.Point(254, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "User ID";
            // 
            // tbUPwd
            // 
            this.tbUPwd.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbUPwd.Location = new System.Drawing.Point(382, 193);
            this.tbUPwd.Name = "tbUPwd";
            this.tbUPwd.Size = new System.Drawing.Size(204, 32);
            this.tbUPwd.TabIndex = 1;
            // 
            // tbUID
            // 
            this.tbUID.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbUID.Location = new System.Drawing.Point(382, 155);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(204, 32);
            this.tbUID.TabIndex = 0;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 689);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEcho;
        private System.Windows.Forms.Button btnEcho;
        private System.Windows.Forms.TextBox tbEcho;
        private System.Windows.Forms.Label resultEcho;
        private System.Windows.Forms.TabPage tabStateful;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button btnStatefulResult;
        private System.Windows.Forms.Label resultStateful;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TabPage tabDataContract;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbCitizenship;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.ComboBox cbCitizenship;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox tbFindPerson;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Label resultDataContract;
        private System.Windows.Forms.TabPage tabHighLoad;
        private System.Windows.Forms.Button btnStartHighLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPerformance;
        private System.Windows.Forms.TextBox tbIterations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.CheckBox chkParallel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label highLoadResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOneWay;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUPwd;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnSecureSend;
        private System.Windows.Forms.Label lblSecureResponse;
        private System.Windows.Forms.CheckBox chkPresident;
    }
}