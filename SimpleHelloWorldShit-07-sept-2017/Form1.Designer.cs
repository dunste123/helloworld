namespace SimpleHelloWorldShit_07_sept_2017
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
            this.BtnShowMessageDSte = new System.Windows.Forms.Button();
            this.LblClickDSte = new System.Windows.Forms.Label();
            this.BtnClearTextDSte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowMessageDSte
            // 
            this.BtnShowMessageDSte.Location = new System.Drawing.Point(30, 112);
            this.BtnShowMessageDSte.Name = "BtnShowMessageDSte";
            this.BtnShowMessageDSte.Size = new System.Drawing.Size(207, 108);
            this.BtnShowMessageDSte.TabIndex = 0;
            this.BtnShowMessageDSte.Text = "Click ME";
            this.BtnShowMessageDSte.UseVisualStyleBackColor = true;
            this.BtnShowMessageDSte.Click += new System.EventHandler(this.BtnShowMessage_Click);
            // 
            // LblClickDSte
            // 
            this.LblClickDSte.AutoSize = true;
            this.LblClickDSte.Location = new System.Drawing.Point(262, 34);
            this.LblClickDSte.Name = "LblClickDSte";
            this.LblClickDSte.Size = new System.Drawing.Size(119, 20);
            this.LblClickDSte.TabIndex = 1;
            this.LblClickDSte.Text = "Click the button";
            // 
            // BtnClearTextDSte
            // 
            this.BtnClearTextDSte.Location = new System.Drawing.Point(288, 112);
            this.BtnClearTextDSte.Name = "BtnClearTextDSte";
            this.BtnClearTextDSte.Size = new System.Drawing.Size(353, 120);
            this.BtnClearTextDSte.TabIndex = 2;
            this.BtnClearTextDSte.Text = "OR CLICK ME, I\'M BETTER";
            this.BtnClearTextDSte.UseVisualStyleBackColor = true;
            this.BtnClearTextDSte.Click += new System.EventHandler(this.BtnClearMessageDSte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 244);
            this.Controls.Add(this.BtnClearTextDSte);
            this.Controls.Add(this.LblClickDSte);
            this.Controls.Add(this.BtnShowMessageDSte);
            this.Name = "Form1";
            this.Text = "A form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowMessageDSte;
        private System.Windows.Forms.Label LblClickDSte;
        private System.Windows.Forms.Button BtnClearTextDSte;
    }
}

