namespace SteamBot
{
    partial class BotControlForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPersonaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPersonaState = new System.Windows.Forms.ComboBox();
            this.btnApplyPersona = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persona Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnApplyPersona);
            this.groupBox1.Controls.Add(this.cbxPersonaState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPersonaName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Info";
            // 
            // txtPersonaName
            // 
            this.txtPersonaName.Location = new System.Drawing.Point(92, 22);
            this.txtPersonaName.Name = "txtPersonaName";
            this.txtPersonaName.Size = new System.Drawing.Size(183, 20);
            this.txtPersonaName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Persona State:";
            // 
            // cbxPersonaState
            // 
            this.cbxPersonaState.FormattingEnabled = true;
            this.cbxPersonaState.Location = new System.Drawing.Point(92, 48);
            this.cbxPersonaState.Name = "cbxPersonaState";
            this.cbxPersonaState.Size = new System.Drawing.Size(183, 21);
            this.cbxPersonaState.TabIndex = 3;
            // 
            // btnApplyPersona
            // 
            this.btnApplyPersona.Location = new System.Drawing.Point(200, 75);
            this.btnApplyPersona.Name = "btnApplyPersona";
            this.btnApplyPersona.Size = new System.Drawing.Size(75, 29);
            this.btnApplyPersona.TabIndex = 4;
            this.btnApplyPersona.Text = "Apply";
            this.btnApplyPersona.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(55, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Unknown";
            // 
            // BotControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 271);
            this.Controls.Add(this.groupBox1);
            this.Name = "BotControlForm";
            this.Text = "Bot Control";
            this.Load += new System.EventHandler(this.BotControlForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.FormClosing += Form1_Closing;

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyPersona;
        private System.Windows.Forms.ComboBox cbxPersonaState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonaName;
    }
}