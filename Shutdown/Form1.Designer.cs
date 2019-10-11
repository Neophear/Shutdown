namespace Shutdown
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSeperator1 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSeperator2 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.cmbbxAction = new System.Windows.Forms.ComboBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.mtxtbxHour = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbxMin = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbxSec = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(46, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(12, 80);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(36, 25);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "00";
            // 
            // lblSeperator1
            // 
            this.lblSeperator1.AutoSize = true;
            this.lblSeperator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperator1.Location = new System.Drawing.Point(54, 80);
            this.lblSeperator1.Name = "lblSeperator1";
            this.lblSeperator1.Size = new System.Drawing.Size(18, 25);
            this.lblSeperator1.TabIndex = 7;
            this.lblSeperator1.Text = ":";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(78, 80);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(36, 25);
            this.lblMin.TabIndex = 8;
            this.lblMin.Text = "00";
            // 
            // lblSeperator2
            // 
            this.lblSeperator2.AutoSize = true;
            this.lblSeperator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperator2.Location = new System.Drawing.Point(120, 80);
            this.lblSeperator2.Name = "lblSeperator2";
            this.lblSeperator2.Size = new System.Drawing.Size(18, 25);
            this.lblSeperator2.TabIndex = 9;
            this.lblSeperator2.Text = ":";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(144, 80);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(36, 25);
            this.lblSec.TabIndex = 10;
            this.lblSec.Text = "00";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(64, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Nulstil";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // cmbbxAction
            // 
            this.cmbbxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxAction.FormattingEnabled = true;
            this.cmbbxAction.Items.AddRange(new object[] {
            "Shutdown",
            "Restart"});
            this.cmbbxAction.Location = new System.Drawing.Point(12, 108);
            this.cmbbxAction.Name = "cmbbxAction";
            this.cmbbxAction.Size = new System.Drawing.Size(121, 21);
            this.cmbbxAction.TabIndex = 12;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblH.Location = new System.Drawing.Point(9, 9);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(39, 16);
            this.lblH.TabIndex = 13;
            this.lblH.Text = "Hour:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblM.Location = new System.Drawing.Point(51, 9);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(33, 16);
            this.lblM.TabIndex = 14;
            this.lblM.Text = "Min:";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblS.Location = new System.Drawing.Point(87, 9);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(35, 16);
            this.lblS.TabIndex = 15;
            this.lblS.Text = "Sec:";
            // 
            // mtxtbxHour
            // 
            this.mtxtbxHour.Location = new System.Drawing.Point(12, 28);
            this.mtxtbxHour.Mask = "00";
            this.mtxtbxHour.Name = "mtxtbxHour";
            this.mtxtbxHour.Size = new System.Drawing.Size(36, 20);
            this.mtxtbxHour.TabIndex = 0;
            this.mtxtbxHour.TextChanged += new System.EventHandler(this.mtxtbxHour_TextChanged);
            // 
            // mtxtbxMin
            // 
            this.mtxtbxMin.Location = new System.Drawing.Point(54, 28);
            this.mtxtbxMin.Mask = "00";
            this.mtxtbxMin.Name = "mtxtbxMin";
            this.mtxtbxMin.Size = new System.Drawing.Size(30, 20);
            this.mtxtbxMin.TabIndex = 1;
            this.mtxtbxMin.TextChanged += new System.EventHandler(this.mtxtbxMin_TextChanged);
            // 
            // mtxtbxSec
            // 
            this.mtxtbxSec.Location = new System.Drawing.Point(90, 28);
            this.mtxtbxSec.Mask = "00";
            this.mtxtbxSec.Name = "mtxtbxSec";
            this.mtxtbxSec.Size = new System.Drawing.Size(32, 20);
            this.mtxtbxSec.TabIndex = 2;
            this.mtxtbxSec.TextChanged += new System.EventHandler(this.mtxtbxSec_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(191, 140);
            this.Controls.Add(this.mtxtbxSec);
            this.Controls.Add(this.mtxtbxMin);
            this.Controls.Add(this.mtxtbxHour);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.cmbbxAction);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblSeperator2);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSeperator1);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Shutdown";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSeperator1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSeperator2;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.ComboBox cmbbxAction;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.MaskedTextBox mtxtbxHour;
        private System.Windows.Forms.MaskedTextBox mtxtbxMin;
        private System.Windows.Forms.MaskedTextBox mtxtbxSec;
    }
}

