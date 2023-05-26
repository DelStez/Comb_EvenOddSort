namespace CombEvenOddSort
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PageTimeSize = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.PageTimeSize.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Load_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 66);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Исходник";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(487, 32);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(168, 96);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 32);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(168, 96);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(313, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Чет-Нечет";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(487, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Расческа";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(313, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Время:   ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(313, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Кол-во перестановок: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(313, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Кол-во сравнений: ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(487, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Кол-во сравнений: ";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(487, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Кол-во перестановок: ";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(487, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Время:   ";
            // 
            // PageTimeSize
            // 
            this.PageTimeSize.Controls.Add(this.tabPage1);
            this.PageTimeSize.Controls.Add(this.tabPage2);
            this.PageTimeSize.Controls.Add(this.tabPage3);
            this.PageTimeSize.Location = new System.Drawing.Point(12, 206);
            this.PageTimeSize.Name = "PageTimeSize";
            this.PageTimeSize.SelectedIndex = 0;
            this.PageTimeSize.Size = new System.Drawing.Size(643, 380);
            this.PageTimeSize.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Время и Размер Файла";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 6);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(372, 345);
            this.zedGraphControl1.TabIndex = 21;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Размер файла и действия";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(6, 0);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(372, 345);
            this.zedGraphControl2.TabIndex = 22;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.zedGraphControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(635, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Время и дейсвтия";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Location = new System.Drawing.Point(6, 3);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(372, 345);
            this.zedGraphControl3.TabIndex = 22;
            this.zedGraphControl3.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 597);
            this.Controls.Add(this.PageTimeSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CombEvenSort";
            this.PageTimeSize.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private ZedGraph.ZedGraphControl zedGraphControl3;

        private System.Windows.Forms.TabPage tabPage3;

        private ZedGraph.ZedGraphControl zedGraphControl2;

        private ZedGraph.ZedGraphControl zedGraphControl1;

        private System.Windows.Forms.TabControl PageTimeSize;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        #endregion
    }
}