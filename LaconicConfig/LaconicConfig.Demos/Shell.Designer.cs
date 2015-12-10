namespace LaconicConfig.Demos
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
            this.tabAttributes = new System.Windows.Forms.TabPage();
            this.tableLayoutAttributes = new System.Windows.Forms.TableLayoutPanel();
            this.infoAttributes = new System.Windows.Forms.RichTextBox();
            this.confAttributes = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultAttributes = new System.Windows.Forms.Label();
            this.btnAttributes = new System.Windows.Forms.Button();
            this.tabMerge = new System.Windows.Forms.TabPage();
            this.tabInclude = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabAttributes.SuspendLayout();
            this.tableLayoutAttributes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAttributes);
            this.tabControl.Controls.Add(this.tabMerge);
            this.tabControl.Controls.Add(this.tabInclude);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(898, 669);
            this.tabControl.TabIndex = 0;
            // 
            // tabAttributes
            // 
            this.tabAttributes.Controls.Add(this.tableLayoutAttributes);
            this.tabAttributes.Location = new System.Drawing.Point(4, 25);
            this.tabAttributes.Name = "tabAttributes";
            this.tabAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttributes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabAttributes.Size = new System.Drawing.Size(890, 640);
            this.tabAttributes.TabIndex = 0;
            this.tabAttributes.Text = "Attributes";
            this.tabAttributes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutAttributes
            // 
            this.tableLayoutAttributes.ColumnCount = 3;
            this.tableLayoutAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutAttributes.Controls.Add(this.infoAttributes, 0, 0);
            this.tableLayoutAttributes.Controls.Add(this.confAttributes, 0, 1);
            this.tableLayoutAttributes.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutAttributes.Controls.Add(this.btnAttributes, 1, 1);
            this.tableLayoutAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAttributes.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutAttributes.Name = "tableLayoutAttributes";
            this.tableLayoutAttributes.RowCount = 2;
            this.tableLayoutAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutAttributes.Size = new System.Drawing.Size(884, 634);
            this.tableLayoutAttributes.TabIndex = 8;
            // 
            // infoAttributes
            // 
            this.infoAttributes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutAttributes.SetColumnSpan(this.infoAttributes, 3);
            this.infoAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoAttributes.Enabled = false;
            this.infoAttributes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoAttributes.ForeColor = System.Drawing.Color.Blue;
            this.infoAttributes.Location = new System.Drawing.Point(3, 3);
            this.infoAttributes.Name = "infoAttributes";
            this.infoAttributes.Size = new System.Drawing.Size(878, 89);
            this.infoAttributes.TabIndex = 0;
            this.infoAttributes.TabStop = false;
            this.infoAttributes.Text = "";
            // 
            // confAttributes
            // 
            this.confAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confAttributes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confAttributes.Location = new System.Drawing.Point(3, 98);
            this.confAttributes.Name = "confAttributes";
            this.confAttributes.Size = new System.Drawing.Size(436, 533);
            this.confAttributes.TabIndex = 2;
            this.confAttributes.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultAttributes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(533, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 533);
            this.panel1.TabIndex = 3;
            // 
            // resultAttributes
            // 
            this.resultAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultAttributes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultAttributes.Location = new System.Drawing.Point(0, 0);
            this.resultAttributes.Name = "resultAttributes";
            this.resultAttributes.Size = new System.Drawing.Size(348, 533);
            this.resultAttributes.TabIndex = 1;
            // 
            // btnAttributes
            // 
            this.btnAttributes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAttributes.Location = new System.Drawing.Point(456, 334);
            this.btnAttributes.Name = "btnAttributes";
            this.btnAttributes.Size = new System.Drawing.Size(60, 60);
            this.btnAttributes.TabIndex = 1;
            this.btnAttributes.Text = ">";
            this.btnAttributes.UseVisualStyleBackColor = true;
            this.btnAttributes.Click += new System.EventHandler(this.btnAttributes_Click);
            // 
            // tabMerge
            // 
            this.tabMerge.Location = new System.Drawing.Point(4, 25);
            this.tabMerge.Name = "tabMerge";
            this.tabMerge.Padding = new System.Windows.Forms.Padding(3);
            this.tabMerge.Size = new System.Drawing.Size(890, 640);
            this.tabMerge.TabIndex = 1;
            this.tabMerge.Text = "Merge";
            this.tabMerge.UseVisualStyleBackColor = true;
            // 
            // tabInclude
            // 
            this.tabInclude.Location = new System.Drawing.Point(4, 25);
            this.tabInclude.Name = "tabInclude";
            this.tabInclude.Padding = new System.Windows.Forms.Padding(3);
            this.tabInclude.Size = new System.Drawing.Size(890, 640);
            this.tabInclude.TabIndex = 2;
            this.tabInclude.Text = "Include";
            this.tabInclude.UseVisualStyleBackColor = true;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 669);
            this.Controls.Add(this.tabControl);
            this.Name = "Shell";
            this.Text = "Laconic configuration demos";
            this.tabControl.ResumeLayout(false);
            this.tabAttributes.ResumeLayout(false);
            this.tableLayoutAttributes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAttributes;
        private System.Windows.Forms.TabPage tabMerge;
        private System.Windows.Forms.TabPage tabInclude;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAttributes;
        private System.Windows.Forms.RichTextBox infoAttributes;
        private System.Windows.Forms.Button btnAttributes;
        private System.Windows.Forms.RichTextBox confAttributes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultAttributes;
    }
}

