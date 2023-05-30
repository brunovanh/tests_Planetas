
namespace Tests_Planetas
{
    partial class Form3
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
            this.labRezultats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(192, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "TESTA REZULTĀTS";
            // 
            // labRezultats
            // 
            this.labRezultats.AutoSize = true;
            this.labRezultats.BackColor = System.Drawing.Color.Lime;
            this.labRezultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labRezultats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labRezultats.Location = new System.Drawing.Point(301, 290);
            this.labRezultats.Name = "labRezultats";
            this.labRezultats.Size = new System.Drawing.Size(100, 37);
            this.labRezultats.TabIndex = 3;
            this.labRezultats.Text = "balles";
            this.labRezultats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labRezultats.Click += new System.EventHandler(this.labRezultats_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tests_Planetas.Properties.Resources.Saules_sistemas_planeetas__1_;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.labRezultats);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "tests";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labRezultats;
    }
}