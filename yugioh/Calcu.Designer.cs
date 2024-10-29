namespace yugioh
{
    partial class Calcu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calcu));
            this.Resultado = new System.Windows.Forms.Button();
            this.Resultado2 = new System.Windows.Forms.Button();
            this.soma1000 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(30, 375);
            this.Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(285, 67);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "8000";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.ResultSoma);
            // 
            // Resultado2
            // 
            this.Resultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado2.Location = new System.Drawing.Point(675, 375);
            this.Resultado2.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado2.Name = "Resultado2";
            this.Resultado2.Size = new System.Drawing.Size(289, 67);
            this.Resultado2.TabIndex = 1;
            this.Resultado2.Text = "8000";
            this.Resultado2.UseVisualStyleBackColor = true;
            this.Resultado2.Click += new System.EventHandler(this.ResultSoma2p);
            // 
            // soma1000
            // 
            this.soma1000.Location = new System.Drawing.Point(99, 252);
            this.soma1000.Margin = new System.Windows.Forms.Padding(2);
            this.soma1000.Name = "soma1000";
            this.soma1000.Size = new System.Drawing.Size(143, 37);
            this.soma1000.TabIndex = 8;
            this.soma1000.Text = "+1000";
            this.soma1000.UseVisualStyleBackColor = true;
            this.soma1000.Click += new System.EventHandler(this.Soma1000);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "0000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "+500";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Soma500);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 301);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 33);
            this.button3.TabIndex = 16;
            this.button3.Text = "+100";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Soma100);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 301);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "+50";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Soma50);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Duelista 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(753, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Duelista 2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 525);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 37);
            this.button5.TabIndex = 20;
            this.button5.Text = "-1000";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Sub1000);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(57, 474);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 33);
            this.button6.TabIndex = 23;
            this.button6.Text = "-500";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Sub500);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(139, 474);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 33);
            this.button7.TabIndex = 22;
            this.button7.Text = "-100";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Sub100);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(223, 474);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 33);
            this.button8.TabIndex = 21;
            this.button8.Text = "-50";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Sub50);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 456);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "0000";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(866, 254);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 33);
            this.button9.TabIndex = 27;
            this.button9.Text = "+50";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Soma50p2);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(782, 254);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(78, 33);
            this.button10.TabIndex = 26;
            this.button10.Text = "+100";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Soma100p2);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(700, 254);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(78, 33);
            this.button11.TabIndex = 25;
            this.button11.Text = "+500";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Soma500p2);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(753, 297);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(143, 37);
            this.button12.TabIndex = 28;
            this.button12.Text = "+1000";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Soma1000p2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(753, 474);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 32;
            this.button2.Text = "-1000";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Sub10002p);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(866, 523);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 33);
            this.button13.TabIndex = 31;
            this.button13.Text = "-50";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Sub502p);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(782, 523);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(78, 33);
            this.button14.TabIndex = 30;
            this.button14.Text = "-100";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Sub1002p);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(700, 523);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(78, 33);
            this.button15.TabIndex = 29;
            this.button15.Text = "-500";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Sub5002p);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(453, 550);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 45);
            this.button16.TabIndex = 33;
            this.button16.Text = "reset";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 107);
            this.label3.TabIndex = 34;
            this.label3.Text = "60:00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(426, 204);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(156, 43);
            this.button17.TabIndex = 37;
            this.button17.Text = "REINICIAR";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(322, 154);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(167, 44);
            this.button18.TabIndex = 36;
            this.button18.Text = "PAUSAR";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(514, 154);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(151, 44);
            this.button19.TabIndex = 35;
            this.button19.Text = "DUELO!";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // Calcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yugioh.Properties.Resources.nayiurs83qnc1;
            this.ClientSize = new System.Drawing.Size(1013, 616);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soma1000);
            this.Controls.Add(this.Resultado2);
            this.Controls.Add(this.Resultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Calcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de LP ";
            this.Load += new System.EventHandler(this.Calcu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.Button Resultado2;
        private System.Windows.Forms.Button soma1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}
