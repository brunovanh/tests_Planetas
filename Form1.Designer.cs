
namespace Tests_Planetas
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
            this.butSakt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSakt
            // 
            this.butSakt.BackColor = System.Drawing.Color.SpringGreen;
            this.butSakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSakt.Location = new System.Drawing.Point(275, 210);
            this.butSakt.Name = "butSakt";
            this.butSakt.Size = new System.Drawing.Size(135, 73);
            this.butSakt.TabIndex = 0;
            this.butSakt.Text = "START";
            this.butSakt.UseVisualStyleBackColor = false;
            this.butSakt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAULES SISTĒMAS PLANĒTAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tests_Planetas.Properties.Resources.Saules_sistemas_planeetas__1_;
            this.ClientSize = new System.Drawing.Size(698, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSakt);
            this.Name = "Form1";
            this.Text = "tests";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSakt;
        private System.Windows.Forms.Label label1;
    }
}

