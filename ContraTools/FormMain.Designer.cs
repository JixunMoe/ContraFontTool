namespace ContraTools
{
    partial class FormMain
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
            this.canvasOrig = new System.Windows.Forms.Label();
            this.canvasReorder = new System.Windows.Forms.Label();
            this.canvasOrigBorder = new System.Windows.Forms.Label();
            this.canvasReorderBorder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinePreview = new System.Windows.Forms.TextBox();
            this.canvas4x = new System.Windows.Forms.Label();
            this.canvas4xBorder = new System.Windows.Forms.Label();
            this.txtDialog = new System.Windows.Forms.TextBox();
            this.btnGenFont = new System.Windows.Forms.Button();
            this.listLines = new System.Windows.Forms.ListBox();
            this.chkSplit = new System.Windows.Forms.CheckBox();
            this.btnCopyImage = new System.Windows.Forms.Button();
            this.txtPpu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodes = new System.Windows.Forms.TextBox();
            this.btnCopyCode = new System.Windows.Forms.Button();
            this.btnGenCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canvasOrig
            // 
            this.canvasOrig.Location = new System.Drawing.Point(13, 9);
            this.canvasOrig.Name = "canvasOrig";
            this.canvasOrig.Size = new System.Drawing.Size(128, 32);
            this.canvasOrig.TabIndex = 0;
            this.canvasOrig.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // canvasReorder
            // 
            this.canvasReorder.Location = new System.Drawing.Point(13, 47);
            this.canvasReorder.Name = "canvasReorder";
            this.canvasReorder.Size = new System.Drawing.Size(128, 32);
            this.canvasReorder.TabIndex = 0;
            this.canvasReorder.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasReorder_Paint);
            // 
            // canvasOrigBorder
            // 
            this.canvasOrigBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.canvasOrigBorder.Enabled = false;
            this.canvasOrigBorder.Location = new System.Drawing.Point(12, 8);
            this.canvasOrigBorder.Name = "canvasOrigBorder";
            this.canvasOrigBorder.Size = new System.Drawing.Size(130, 34);
            this.canvasOrigBorder.TabIndex = 0;
            // 
            // canvasReorderBorder
            // 
            this.canvasReorderBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.canvasReorderBorder.Enabled = false;
            this.canvasReorderBorder.Location = new System.Drawing.Point(12, 46);
            this.canvasReorderBorder.Name = "canvasReorderBorder";
            this.canvasReorderBorder.Size = new System.Drawing.Size(130, 34);
            this.canvasReorderBorder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "字模";
            // 
            // txtLinePreview
            // 
            this.txtLinePreview.Location = new System.Drawing.Point(12, 99);
            this.txtLinePreview.Multiline = true;
            this.txtLinePreview.Name = "txtLinePreview";
            this.txtLinePreview.ReadOnly = true;
            this.txtLinePreview.Size = new System.Drawing.Size(129, 39);
            this.txtLinePreview.TabIndex = 40;
            // 
            // canvas4x
            // 
            this.canvas4x.Location = new System.Drawing.Point(148, 9);
            this.canvas4x.Name = "canvas4x";
            this.canvas4x.Size = new System.Drawing.Size(512, 128);
            this.canvas4x.TabIndex = 4;
            this.canvas4x.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas4x_Paint);
            // 
            // canvas4xBorder
            // 
            this.canvas4xBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.canvas4xBorder.Enabled = false;
            this.canvas4xBorder.Location = new System.Drawing.Point(147, 8);
            this.canvas4xBorder.Name = "canvas4xBorder";
            this.canvas4xBorder.Size = new System.Drawing.Size(514, 130);
            this.canvas4xBorder.TabIndex = 5;
            // 
            // txtDialog
            // 
            this.txtDialog.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDialog.Location = new System.Drawing.Point(12, 144);
            this.txtDialog.Multiline = true;
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.Size = new System.Drawing.Size(256, 151);
            this.txtDialog.TabIndex = 0;
            this.txtDialog.Text = "公元２６３１年\r\n一颗神秘的陨石从天而降，\r\n坠落于新西兰附近的\r\n加鲁加群岛。";
            // 
            // btnGenFont
            // 
            this.btnGenFont.Location = new System.Drawing.Point(274, 145);
            this.btnGenFont.Name = "btnGenFont";
            this.btnGenFont.Size = new System.Drawing.Size(75, 23);
            this.btnGenFont.TabIndex = 10;
            this.btnGenFont.Text = "生成字模";
            this.btnGenFont.UseVisualStyleBackColor = true;
            this.btnGenFont.Click += new System.EventHandler(this.btnGenFont_Click);
            // 
            // listLines
            // 
            this.listLines.FormattingEnabled = true;
            this.listLines.Location = new System.Drawing.Point(274, 174);
            this.listLines.Name = "listLines";
            this.listLines.Size = new System.Drawing.Size(212, 121);
            this.listLines.TabIndex = 20;
            this.listLines.SelectedIndexChanged += new System.EventHandler(this.listLines_SelectedIndexChanged);
            // 
            // chkSplit
            // 
            this.chkSplit.AutoSize = true;
            this.chkSplit.Checked = true;
            this.chkSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSplit.Location = new System.Drawing.Point(355, 149);
            this.chkSplit.Name = "chkSplit";
            this.chkSplit.Size = new System.Drawing.Size(50, 17);
            this.chkSplit.TabIndex = 11;
            this.chkSplit.Text = "切割";
            this.chkSplit.UseVisualStyleBackColor = true;
            this.chkSplit.CheckedChanged += new System.EventHandler(this.chkSplit_CheckedChanged);
            // 
            // btnCopyImage
            // 
            this.btnCopyImage.Location = new System.Drawing.Point(411, 145);
            this.btnCopyImage.Name = "btnCopyImage";
            this.btnCopyImage.Size = new System.Drawing.Size(75, 23);
            this.btnCopyImage.TabIndex = 12;
            this.btnCopyImage.Text = "复制位图";
            this.btnCopyImage.UseVisualStyleBackColor = true;
            this.btnCopyImage.Click += new System.EventHandler(this.btnCopyImage_Click);
            // 
            // txtPpu
            // 
            this.txtPpu.Location = new System.Drawing.Point(534, 147);
            this.txtPpu.Name = "txtPpu";
            this.txtPpu.Size = new System.Drawing.Size(127, 20);
            this.txtPpu.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "PPU";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(534, 173);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(127, 20);
            this.txtBank.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "BANK";
            // 
            // txtCodes
            // 
            this.txtCodes.Location = new System.Drawing.Point(495, 199);
            this.txtCodes.Multiline = true;
            this.txtCodes.Name = "txtCodes";
            this.txtCodes.ReadOnly = true;
            this.txtCodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodes.Size = new System.Drawing.Size(165, 67);
            this.txtCodes.TabIndex = 102;
            // 
            // btnCopyCode
            // 
            this.btnCopyCode.Location = new System.Drawing.Point(495, 272);
            this.btnCopyCode.Name = "btnCopyCode";
            this.btnCopyCode.Size = new System.Drawing.Size(75, 23);
            this.btnCopyCode.TabIndex = 103;
            this.btnCopyCode.Text = "复制代码";
            this.btnCopyCode.UseVisualStyleBackColor = true;
            this.btnCopyCode.Click += new System.EventHandler(this.btnCopyCode_Click);
            // 
            // btnGenCode
            // 
            this.btnGenCode.Location = new System.Drawing.Point(586, 272);
            this.btnGenCode.Name = "btnGenCode";
            this.btnGenCode.Size = new System.Drawing.Size(75, 23);
            this.btnGenCode.TabIndex = 104;
            this.btnGenCode.Text = "生成代码";
            this.btnGenCode.UseVisualStyleBackColor = true;
            this.btnGenCode.Click += new System.EventHandler(this.btnGenCode_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 305);
            this.Controls.Add(this.btnGenCode);
            this.Controls.Add(this.btnCopyCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodes);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtPpu);
            this.Controls.Add(this.chkSplit);
            this.Controls.Add(this.listLines);
            this.Controls.Add(this.btnCopyImage);
            this.Controls.Add(this.btnGenFont);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.canvas4x);
            this.Controls.Add(this.canvas4xBorder);
            this.Controls.Add(this.txtLinePreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvasReorder);
            this.Controls.Add(this.canvasOrig);
            this.Controls.Add(this.canvasOrigBorder);
            this.Controls.Add(this.canvasReorderBorder);
            this.Name = "FormMain";
            this.Text = "魂斗罗 16x16 中文字库工具 by Jixun";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label canvasOrig;
        private System.Windows.Forms.Label canvasReorder;
        private System.Windows.Forms.Label canvasOrigBorder;
        private System.Windows.Forms.Label canvasReorderBorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinePreview;
        private System.Windows.Forms.Label canvas4x;
        private System.Windows.Forms.Label canvas4xBorder;
        private System.Windows.Forms.TextBox txtDialog;
        private System.Windows.Forms.Button btnGenFont;
        private System.Windows.Forms.ListBox listLines;
        private System.Windows.Forms.CheckBox chkSplit;
        private System.Windows.Forms.Button btnCopyImage;
        private System.Windows.Forms.TextBox txtPpu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodes;
        private System.Windows.Forms.Button btnCopyCode;
        private System.Windows.Forms.Button btnGenCode;
    }
}

