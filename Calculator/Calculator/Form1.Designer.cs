namespace Calculator
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
			this.btnCE = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnDziel = new System.Windows.Forms.Button();
			this.btnMno = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btnWynik = new System.Windows.Forms.Button();
			this.btnKropka = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.textDisplay1 = new System.Windows.Forms.TextBox();
			this.textDisplay2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCE
			// 
			this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnCE.Location = new System.Drawing.Point(3, 132);
			this.btnCE.Name = "btnCE";
			this.btnCE.Size = new System.Drawing.Size(74, 65);
			this.btnCE.TabIndex = 0;
			this.btnCE.Text = "CE";
			this.btnCE.UseVisualStyleBackColor = true;
			this.btnCE.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btnC
			// 
			this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnC.Location = new System.Drawing.Point(83, 132);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(74, 65);
			this.btnC.TabIndex = 1;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDel.Location = new System.Drawing.Point(163, 132);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(74, 65);
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "DEL";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btnDziel
			// 
			this.btnDziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDziel.Location = new System.Drawing.Point(243, 132);
			this.btnDziel.Name = "btnDziel";
			this.btnDziel.Size = new System.Drawing.Size(74, 65);
			this.btnDziel.TabIndex = 3;
			this.btnDziel.Text = "/";
			this.btnDziel.UseVisualStyleBackColor = true;
			this.btnDziel.Click += new System.EventHandler(this.Operation_Click);
			// 
			// btnMno
			// 
			this.btnMno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnMno.Location = new System.Drawing.Point(243, 203);
			this.btnMno.Name = "btnMno";
			this.btnMno.Size = new System.Drawing.Size(74, 65);
			this.btnMno.TabIndex = 7;
			this.btnMno.Text = "X";
			this.btnMno.UseVisualStyleBackColor = true;
			this.btnMno.Click += new System.EventHandler(this.Operation_Click);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn9.Location = new System.Drawing.Point(163, 203);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(74, 65);
			this.btn9.TabIndex = 6;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn8.Location = new System.Drawing.Point(83, 203);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(74, 65);
			this.btn8.TabIndex = 5;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn7.Location = new System.Drawing.Point(3, 203);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(74, 65);
			this.btn7.TabIndex = 4;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnMinus.Location = new System.Drawing.Point(243, 274);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(74, 65);
			this.btnMinus.TabIndex = 11;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.Operation_Click);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn6.Location = new System.Drawing.Point(163, 274);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(74, 65);
			this.btn6.TabIndex = 10;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn4.Location = new System.Drawing.Point(3, 274);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(74, 65);
			this.btn4.TabIndex = 8;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnPlus.Location = new System.Drawing.Point(243, 345);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(74, 65);
			this.btnPlus.TabIndex = 15;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.Operation_Click);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn3.Location = new System.Drawing.Point(163, 345);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(74, 65);
			this.btn3.TabIndex = 14;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn2.Location = new System.Drawing.Point(83, 345);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(74, 65);
			this.btn2.TabIndex = 13;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn1.Location = new System.Drawing.Point(3, 345);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(74, 65);
			this.btn1.TabIndex = 12;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btnWynik
			// 
			this.btnWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnWynik.Location = new System.Drawing.Point(243, 416);
			this.btnWynik.Name = "btnWynik";
			this.btnWynik.Size = new System.Drawing.Size(74, 65);
			this.btnWynik.TabIndex = 19;
			this.btnWynik.Text = "=";
			this.btnWynik.UseVisualStyleBackColor = true;
			this.btnWynik.Click += new System.EventHandler(this.Operation_Click);
			// 
			// btnKropka
			// 
			this.btnKropka.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnKropka.Location = new System.Drawing.Point(163, 416);
			this.btnKropka.Name = "btnKropka";
			this.btnKropka.Size = new System.Drawing.Size(74, 65);
			this.btnKropka.TabIndex = 18;
			this.btnKropka.Text = ".";
			this.btnKropka.UseVisualStyleBackColor = true;
			this.btnKropka.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn0.Location = new System.Drawing.Point(3, 416);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(154, 65);
			this.btn0.TabIndex = 17;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn5.Location = new System.Drawing.Point(83, 274);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(74, 65);
			this.btn5.TabIndex = 22;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.AllBtn_Click);
			// 
			// textDisplay1
			// 
			this.textDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textDisplay1.Location = new System.Drawing.Point(3, 55);
			this.textDisplay1.Name = "textDisplay1";
			this.textDisplay1.ReadOnly = true;
			this.textDisplay1.Size = new System.Drawing.Size(329, 13);
			this.textDisplay1.TabIndex = 23;
			this.textDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textDisplay2
			// 
			this.textDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textDisplay2.Location = new System.Drawing.Point(3, 29);
			this.textDisplay2.Name = "textDisplay2";
			this.textDisplay2.ReadOnly = true;
			this.textDisplay2.Size = new System.Drawing.Size(329, 13);
			this.textDisplay2.TabIndex = 0;
			this.textDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 533);
			this.Controls.Add(this.textDisplay2);
			this.Controls.Add(this.textDisplay1);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btnWynik);
			this.Controls.Add(this.btnKropka);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btnMno);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btnDziel);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnCE);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCE;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnDziel;
		private System.Windows.Forms.Button btnMno;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btnWynik;
		private System.Windows.Forms.Button btnKropka;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.TextBox textDisplay1;
		private System.Windows.Forms.TextBox textDisplay2;
	}
}

