namespace ejercicio1._7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt00 = new System.Windows.Forms.TextBox();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.txt03 = new System.Windows.Forms.TextBox();
            this.txt04 = new System.Windows.Forms.TextBox();
            this.txt06 = new System.Windows.Forms.TextBox();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.txt05 = new System.Windows.Forms.TextBox();
            this.txt07 = new System.Windows.Forms.TextBox();
            this.txt08 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.txt07, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt06, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt04, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt03, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt00, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt05, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt08, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(107, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(189, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRIZ 3X3 INGRESA DATOS ENTEROS EN CADA RECUADRO";
            // 
            // txt00
            // 
            this.txt00.Location = new System.Drawing.Point(3, 3);
            this.txt00.Name = "txt00";
            this.txt00.Size = new System.Drawing.Size(213, 20);
            this.txt00.TabIndex = 0;
            this.txt00.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(222, 3);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(205, 20);
            this.txt01.TabIndex = 1;
            // 
            // txt03
            // 
            this.txt03.Location = new System.Drawing.Point(3, 94);
            this.txt03.Name = "txt03";
            this.txt03.Size = new System.Drawing.Size(213, 20);
            this.txt03.TabIndex = 2;
            // 
            // txt04
            // 
            this.txt04.Location = new System.Drawing.Point(222, 94);
            this.txt04.Name = "txt04";
            this.txt04.Size = new System.Drawing.Size(205, 20);
            this.txt04.TabIndex = 3;
            // 
            // txt06
            // 
            this.txt06.Location = new System.Drawing.Point(3, 185);
            this.txt06.Name = "txt06";
            this.txt06.Size = new System.Drawing.Size(205, 20);
            this.txt06.TabIndex = 4;
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(442, 3);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(204, 20);
            this.txt02.TabIndex = 5;
            // 
            // txt05
            // 
            this.txt05.Location = new System.Drawing.Point(442, 94);
            this.txt05.Name = "txt05";
            this.txt05.Size = new System.Drawing.Size(204, 20);
            this.txt05.TabIndex = 1;
            // 
            // txt07
            // 
            this.txt07.Location = new System.Drawing.Point(222, 185);
            this.txt07.Name = "txt07";
            this.txt07.Size = new System.Drawing.Size(205, 20);
            this.txt07.TabIndex = 6;
            // 
            // txt08
            // 
            this.txt08.Location = new System.Drawing.Point(442, 185);
            this.txt08.Name = "txt08";
            this.txt08.Size = new System.Drawing.Size(204, 20);
            this.txt08.TabIndex = 7;
            this.txt08.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "CALCULAR SUMA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(220, 351);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(23, 31);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = ":";
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt08;
        private System.Windows.Forms.TextBox txt07;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.TextBox txt06;
        private System.Windows.Forms.TextBox txt04;
        private System.Windows.Forms.TextBox txt03;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.TextBox txt00;
        private System.Windows.Forms.TextBox txt05;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
    }
}

