namespace Thatsanee
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunttonclear = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunttonclear
            // 
            this.bunttonclear.Location = new System.Drawing.Point(463, 122);
            this.bunttonclear.Name = "bunttonclear";
            this.bunttonclear.Size = new System.Drawing.Size(94, 81);
            this.bunttonclear.TabIndex = 2;
            this.bunttonclear.Text = "clear";
            this.bunttonclear.UseVisualStyleBackColor = true;
            this.bunttonclear.Click += new System.EventHandler(this.bunttonclear_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(238, 122);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 26);
            this.textBoxC.TabIndex = 3;
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(238, 163);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 26);
            this.textBoxF.TabIndex = 4;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(339, 125);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(20, 20);
            this.C.TabIndex = 5;
            this.C.Text = "C";
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(344, 166);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(19, 20);
            this.F.TabIndex = 6;
            this.F.Text = "F";
            this.F.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F);
            this.Controls.Add(this.C);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.bunttonclear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bunttonclear;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label F;
    }
}

