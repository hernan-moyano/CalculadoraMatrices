
namespace CalculadoraMatrices
{
    partial class Calculadora
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilaA = new System.Windows.Forms.TextBox();
            this.txtColA = new System.Windows.Forms.TextBox();
            this.txtFilaB = new System.Windows.Forms.TextBox();
            this.txtColB = new System.Windows.Forms.TextBox();
            this.btnInsertA = new System.Windows.Forms.Button();
            this.btnMosA = new System.Windows.Forms.Button();
            this.btnInsertB = new System.Windows.Forms.Button();
            this.btnMosB = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnTrasA = new System.Windows.Forms.Button();
            this.btnTrasB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.btnEsXa = new System.Windows.Forms.Button();
            this.btnEsXb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(21, 53);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(240, 179);
            this.dgvA.TabIndex = 0;
            // 
            // dgvB
            // 
            this.dgvB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(412, 53);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(240, 179);
            this.dgvB.TabIndex = 1;
            // 
            // dgvC
            // 
            this.dgvC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(412, 277);
            this.dgvC.Name = "dgvC";
            this.dgvC.Size = new System.Drawing.Size(240, 179);
            this.dgvC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matriz A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matriz B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matriz Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fila";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Columna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fila";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Columna";
            // 
            // txtFilaA
            // 
            this.txtFilaA.Location = new System.Drawing.Point(280, 79);
            this.txtFilaA.Name = "txtFilaA";
            this.txtFilaA.Size = new System.Drawing.Size(100, 20);
            this.txtFilaA.TabIndex = 10;
            // 
            // txtColA
            // 
            this.txtColA.Location = new System.Drawing.Point(280, 125);
            this.txtColA.Name = "txtColA";
            this.txtColA.Size = new System.Drawing.Size(100, 20);
            this.txtColA.TabIndex = 11;
            // 
            // txtFilaB
            // 
            this.txtFilaB.Location = new System.Drawing.Point(673, 79);
            this.txtFilaB.Name = "txtFilaB";
            this.txtFilaB.Size = new System.Drawing.Size(100, 20);
            this.txtFilaB.TabIndex = 12;
            // 
            // txtColB
            // 
            this.txtColB.Location = new System.Drawing.Point(673, 125);
            this.txtColB.Name = "txtColB";
            this.txtColB.Size = new System.Drawing.Size(100, 20);
            this.txtColB.TabIndex = 13;
            // 
            // btnInsertA
            // 
            this.btnInsertA.Location = new System.Drawing.Point(280, 166);
            this.btnInsertA.Name = "btnInsertA";
            this.btnInsertA.Size = new System.Drawing.Size(75, 23);
            this.btnInsertA.TabIndex = 14;
            this.btnInsertA.Text = "Insertar";
            this.btnInsertA.UseVisualStyleBackColor = true;
            this.btnInsertA.Click += new System.EventHandler(this.btnInsertA_Click);
            // 
            // btnMosA
            // 
            this.btnMosA.Location = new System.Drawing.Point(280, 209);
            this.btnMosA.Name = "btnMosA";
            this.btnMosA.Size = new System.Drawing.Size(75, 23);
            this.btnMosA.TabIndex = 15;
            this.btnMosA.Text = "Mostrar";
            this.btnMosA.UseVisualStyleBackColor = true;
            this.btnMosA.Click += new System.EventHandler(this.btnMosA_Click);
            // 
            // btnInsertB
            // 
            this.btnInsertB.Location = new System.Drawing.Point(673, 166);
            this.btnInsertB.Name = "btnInsertB";
            this.btnInsertB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertB.TabIndex = 16;
            this.btnInsertB.Text = "Insertar";
            this.btnInsertB.UseVisualStyleBackColor = true;
            this.btnInsertB.Click += new System.EventHandler(this.btnInsertB_Click);
            // 
            // btnMosB
            // 
            this.btnMosB.Location = new System.Drawing.Point(673, 209);
            this.btnMosB.Name = "btnMosB";
            this.btnMosB.Size = new System.Drawing.Size(75, 23);
            this.btnMosB.TabIndex = 17;
            this.btnMosB.Text = "Mostrar";
            this.btnMosB.UseVisualStyleBackColor = true;
            this.btnMosB.Click += new System.EventHandler(this.btnMosB_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(283, 308);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(97, 23);
            this.btnSumar.TabIndex = 18;
            this.btnSumar.Text = "Sumar A+B";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(283, 351);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(97, 23);
            this.btnRestar.TabIndex = 19;
            this.btnRestar.Text = "Restar A-B";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(283, 394);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(97, 23);
            this.btnMultiplicar.TabIndex = 20;
            this.btnMultiplicar.Text = "Multiplicar A*B";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnTrasA
            // 
            this.btnTrasA.Location = new System.Drawing.Point(82, 20);
            this.btnTrasA.Name = "btnTrasA";
            this.btnTrasA.Size = new System.Drawing.Size(75, 23);
            this.btnTrasA.TabIndex = 21;
            this.btnTrasA.Text = "Trasponer A";
            this.btnTrasA.UseVisualStyleBackColor = true;
            this.btnTrasA.Click += new System.EventHandler(this.btnTrasA_Click);
            // 
            // btnTrasB
            // 
            this.btnTrasB.Location = new System.Drawing.Point(485, 20);
            this.btnTrasB.Name = "btnTrasB";
            this.btnTrasB.Size = new System.Drawing.Size(75, 23);
            this.btnTrasB.TabIndex = 22;
            this.btnTrasB.Text = "Trasponer B";
            this.btnTrasB.UseVisualStyleBackColor = true;
            this.btnTrasB.Click += new System.EventHandler(this.btnTrasB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Escalar";
            // 
            // txtEscalar
            // 
            this.txtEscalar.Location = new System.Drawing.Point(21, 308);
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(100, 20);
            this.txtEscalar.TabIndex = 24;
            // 
            // btnEsXa
            // 
            this.btnEsXa.Location = new System.Drawing.Point(21, 351);
            this.btnEsXa.Name = "btnEsXa";
            this.btnEsXa.Size = new System.Drawing.Size(97, 23);
            this.btnEsXa.TabIndex = 25;
            this.btnEsXa.Text = "A x Escalar";
            this.btnEsXa.UseVisualStyleBackColor = true;
            this.btnEsXa.Click += new System.EventHandler(this.btnEsXa_Click);
            // 
            // btnEsXb
            // 
            this.btnEsXb.Location = new System.Drawing.Point(21, 394);
            this.btnEsXb.Name = "btnEsXb";
            this.btnEsXb.Size = new System.Drawing.Size(97, 23);
            this.btnEsXb.TabIndex = 26;
            this.btnEsXb.Text = "B x Escalar";
            this.btnEsXb.UseVisualStyleBackColor = true;
            this.btnEsXb.Click += new System.EventHandler(this.btnEsXb_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnEsXb);
            this.Controls.Add(this.btnEsXa);
            this.Controls.Add(this.txtEscalar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTrasB);
            this.Controls.Add(this.btnTrasA);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnMosB);
            this.Controls.Add(this.btnInsertB);
            this.Controls.Add(this.btnMosA);
            this.Controls.Add(this.btnInsertA);
            this.Controls.Add(this.txtColB);
            this.Controls.Add(this.txtFilaB);
            this.Controls.Add(this.txtColA);
            this.Controls.Add(this.txtFilaA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Name = "Calculadora";
            this.Text = "Calculadora de Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilaA;
        private System.Windows.Forms.TextBox txtColA;
        private System.Windows.Forms.TextBox txtFilaB;
        private System.Windows.Forms.TextBox txtColB;
        private System.Windows.Forms.Button btnInsertA;
        private System.Windows.Forms.Button btnMosA;
        private System.Windows.Forms.Button btnInsertB;
        private System.Windows.Forms.Button btnMosB;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnTrasA;
        private System.Windows.Forms.Button btnTrasB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Button btnEsXa;
        private System.Windows.Forms.Button btnEsXb;
    }
}

