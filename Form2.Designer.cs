
namespace Tests_Planetas
{
    partial class Form2
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
            this.butAtbilde1 = new System.Windows.Forms.Button();
            this.butAtbilde2 = new System.Windows.Forms.Button();
            this.butAtbilde3 = new System.Windows.Forms.Button();
            this.labJautajums = new System.Windows.Forms.Label();
            this.labPiemers = new System.Windows.Forms.Label();
            this.labPunkti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butAtbilde1
            // 
            this.butAtbilde1.BackColor = System.Drawing.Color.Lime;
            this.butAtbilde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde1.Location = new System.Drawing.Point(49, 301);
            this.butAtbilde1.Name = "butAtbilde1";
            this.butAtbilde1.Size = new System.Drawing.Size(170, 69);
            this.butAtbilde1.TabIndex = 1;
            this.butAtbilde1.Text = "1.variants";
            this.butAtbilde1.UseVisualStyleBackColor = false;
            this.butAtbilde1.Click += new System.EventHandler(this.butAtbilde1_Click);
            // 
            // butAtbilde2
            // 
            this.butAtbilde2.BackColor = System.Drawing.Color.Lime;
            this.butAtbilde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde2.Location = new System.Drawing.Point(249, 301);
            this.butAtbilde2.Name = "butAtbilde2";
            this.butAtbilde2.Size = new System.Drawing.Size(170, 69);
            this.butAtbilde2.TabIndex = 2;
            this.butAtbilde2.Text = "2.variants";
            this.butAtbilde2.UseVisualStyleBackColor = false;
            this.butAtbilde2.Click += new System.EventHandler(this.butAtbilde2_Click);
            // 
            // butAtbilde3
            // 
            this.butAtbilde3.BackColor = System.Drawing.Color.Lime;
            this.butAtbilde3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde3.Location = new System.Drawing.Point(462, 301);
            this.butAtbilde3.Name = "butAtbilde3";
            this.butAtbilde3.Size = new System.Drawing.Size(170, 69);
            this.butAtbilde3.TabIndex = 3;
            this.butAtbilde3.Text = "3.variants";
            this.butAtbilde3.UseVisualStyleBackColor = false;
            this.butAtbilde3.Click += new System.EventHandler(this.butAtbilde3_Click);
            // 
            // labJautajums
            // 
            this.labJautajums.BackColor = System.Drawing.Color.LightGray;
            this.labJautajums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labJautajums.Location = new System.Drawing.Point(49, 73);
            this.labJautajums.Name = "labJautajums";
            this.labJautajums.Size = new System.Drawing.Size(583, 103);
            this.labJautajums.TabIndex = 4;
            this.labJautajums.Text = "Jautājums";
            this.labJautajums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPiemers
            // 
            this.labPiemers.AutoSize = true;
            this.labPiemers.BackColor = System.Drawing.Color.LightGray;
            this.labPiemers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labPiemers.Location = new System.Drawing.Point(30, 407);
            this.labPiemers.Name = "labPiemers";
            this.labPiemers.Size = new System.Drawing.Size(82, 25);
            this.labPiemers.TabIndex = 5;
            this.labPiemers.Text = "1. no 10";
            // 
            // labPunkti
            // 
            this.labPunkti.AutoSize = true;
            this.labPunkti.BackColor = System.Drawing.Color.LightGray;
            this.labPunkti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labPunkti.Location = new System.Drawing.Point(550, 407);
            this.labPunkti.Name = "labPunkti";
            this.labPunkti.Size = new System.Drawing.Size(80, 25);
            this.labPunkti.TabIndex = 6;
            this.labPunkti.Text = "0 punkti";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tests_Planetas.Properties.Resources.Saules_sistemas_planeetas__1_;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.labPunkti);
            this.Controls.Add(this.labPiemers);
            this.Controls.Add(this.labJautajums);
            this.Controls.Add(this.butAtbilde3);
            this.Controls.Add(this.butAtbilde2);
            this.Controls.Add(this.butAtbilde1);
            this.Name = "Form2";
            this.Text = "tests";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAtbilde1;
        private System.Windows.Forms.Button butAtbilde2;
        private System.Windows.Forms.Button butAtbilde3;
        private System.Windows.Forms.Label labJautajums;
        private System.Windows.Forms.Label labPiemers;
        private System.Windows.Forms.Label labPunkti;
    }
}