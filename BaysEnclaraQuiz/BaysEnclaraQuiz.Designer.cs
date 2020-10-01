namespace BaysEnclaraQuiz
{
    partial class BaysEnclaraQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaysEnclaraQuiz));
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbParagraphInput = new System.Windows.Forms.RichTextBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(351, 553);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(165, 70);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 1;
            // 
            // rtbParagraphInput
            // 
            this.rtbParagraphInput.Location = new System.Drawing.Point(72, 13);
            this.rtbParagraphInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbParagraphInput.Name = "rtbParagraphInput";
            this.rtbParagraphInput.ReadOnly = true;
            this.rtbParagraphInput.Size = new System.Drawing.Size(732, 202);
            this.rtbParagraphInput.TabIndex = 0;
            this.rtbParagraphInput.Text = resources.GetString("rtbParagraphInput.Text");
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(72, 275);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(732, 238);
            this.rtbResults.TabIndex = 2;
            this.rtbResults.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Results";
            // 
            // BaysEnclaraQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.rtbParagraphInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaysEnclaraQuiz";
            this.Text = "Chris Bays Enclara Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbParagraphInput;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Label label1;
    }
}

