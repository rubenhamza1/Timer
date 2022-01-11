namespace Timer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblTrenVrijeme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(116, 65);
            this.lblVrijeme.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(115, 39);
            this.lblVrijeme.TabIndex = 0;
            this.lblVrijeme.Text = "label1";
            // 
            // lblTrenVrijeme
            // 
            this.lblTrenVrijeme.AutoSize = true;
            this.lblTrenVrijeme.Location = new System.Drawing.Point(12, 9);
            this.lblTrenVrijeme.Name = "lblTrenVrijeme";
            this.lblTrenVrijeme.Size = new System.Drawing.Size(344, 39);
            this.lblTrenVrijeme.TabIndex = 1;
            this.lblTrenVrijeme.Text = "Trenutačno vrijeme:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 178);
            this.Controls.Add(this.lblTrenVrijeme);
            this.Controls.Add(this.lblVrijeme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label lblTrenVrijeme;
    }
}

