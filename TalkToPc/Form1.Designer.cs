namespace TalkToPc
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
            this.tboxInput = new System.Windows.Forms.TextBox();
            this.tboxOutput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxInput
            // 
            this.tboxInput.Location = new System.Drawing.Point(39, 90);
            this.tboxInput.Multiline = true;
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(257, 164);
            this.tboxInput.TabIndex = 0;
            this.tboxInput.TextChanged += new System.EventHandler(this.tboxInput_TextChanged);
            this.tboxInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tboxInput_MouseDoubleClick);
            // 
            // tboxOutput
            // 
            this.tboxOutput.Location = new System.Drawing.Point(398, 90);
            this.tboxOutput.Multiline = true;
            this.tboxOutput.Name = "tboxOutput";
            this.tboxOutput.Size = new System.Drawing.Size(257, 164);
            this.tboxOutput.TabIndex = 1;
            this.tboxOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tboxOutput_MouseDoubleClick);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(36, 64);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(54, 13);
            this.lbInput.TabIndex = 2;
            this.lbInput.Text = "Text Here";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(395, 64);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(162, 13);
            this.lbOutput.TabIndex = 3;
            this.lbOutput.Text = "Here is what your PC understand";
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.Location = new System.Drawing.Point(308, 263);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(75, 23);
            this.btnClearTxt.TabIndex = 5;
            this.btnClearTxt.Text = "Clear Text";
            this.btnClearTxt.UseVisualStyleBackColor = true;
            this.btnClearTxt.Click += new System.EventHandler(this.btnClearTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Double Click Text Box to Clear text or press the button to clear both";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.tboxOutput);
            this.Controls.Add(this.tboxInput);
            this.Name = "Form1";
            this.Text = "TalkToPc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxInput;
        private System.Windows.Forms.TextBox tboxOutput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.Label label1;
    }
}

