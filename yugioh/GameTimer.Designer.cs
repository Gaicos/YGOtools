﻿namespace yugioh
{
    partial class GameTimer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameTimer));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "50:00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "DUELO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Iniciar_Timer);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "PAUSAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Pausar_Timer);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 91);
            this.button3.TabIndex = 3;
            this.button3.Text = "REINICIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Rein_Timer);
            // 
            // GameTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yugioh.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameTimer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
