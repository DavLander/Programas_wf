namespace WF_Sucecion_de_Fibonacci
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblLimit = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.Resultados = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chcSum = new System.Windows.Forms.CheckBox();
            this.chcRestar = new System.Windows.Forms.CheckBox();
            this.chcDividir = new System.Windows.Forms.CheckBox();
            this.chcMultiplicar = new System.Windows.Forms.CheckBox();
            this.lblSucesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultados.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(325, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(12, 100);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(34, 13);
            this.lblLimit.TabIndex = 1;
            this.lblLimit.Text = "Limite";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(52, 97);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 2;
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // Resultados
            // 
            this.Resultados.Controls.Add(this.txtResult);
            this.Resultados.Location = new System.Drawing.Point(12, 169);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(388, 100);
            this.Resultados.TabIndex = 3;
            this.Resultados.TabStop = false;
            this.Resultados.Text = "Resultados";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult.Location = new System.Drawing.Point(6, 19);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(376, 79);
            this.txtResult.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // chcSum
            // 
            this.chcSum.AutoSize = true;
            this.chcSum.Location = new System.Drawing.Point(12, 132);
            this.chcSum.Name = "chcSum";
            this.chcSum.Size = new System.Drawing.Size(56, 17);
            this.chcSum.TabIndex = 5;
            this.chcSum.Text = "Sumar";
            this.chcSum.UseVisualStyleBackColor = true;
            this.chcSum.CheckedChanged += new System.EventHandler(this.chcSum_CheckedChanged);
            // 
            // chcRestar
            // 
            this.chcRestar.AutoSize = true;
            this.chcRestar.Location = new System.Drawing.Point(74, 132);
            this.chcRestar.Name = "chcRestar";
            this.chcRestar.Size = new System.Drawing.Size(57, 17);
            this.chcRestar.TabIndex = 6;
            this.chcRestar.Text = "Restar";
            this.chcRestar.UseVisualStyleBackColor = true;
            // 
            // chcDividir
            // 
            this.chcDividir.AutoSize = true;
            this.chcDividir.Location = new System.Drawing.Point(216, 132);
            this.chcDividir.Name = "chcDividir";
            this.chcDividir.Size = new System.Drawing.Size(55, 17);
            this.chcDividir.TabIndex = 7;
            this.chcDividir.Text = "Dividir";
            this.chcDividir.UseVisualStyleBackColor = true;
            this.chcDividir.CheckedChanged += new System.EventHandler(this.chcDividir_CheckedChanged);
            // 
            // chcMultiplicar
            // 
            this.chcMultiplicar.AutoSize = true;
            this.chcMultiplicar.Location = new System.Drawing.Point(137, 132);
            this.chcMultiplicar.Name = "chcMultiplicar";
            this.chcMultiplicar.Size = new System.Drawing.Size(73, 17);
            this.chcMultiplicar.TabIndex = 8;
            this.chcMultiplicar.Text = "Multiplicar";
            this.chcMultiplicar.UseVisualStyleBackColor = true;
            // 
            // lblSucesion
            // 
            this.lblSucesion.AutoSize = true;
            this.lblSucesion.BackColor = System.Drawing.Color.Transparent;
            this.lblSucesion.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucesion.Location = new System.Drawing.Point(171, 36);
            this.lblSucesion.Name = "lblSucesion";
            this.lblSucesion.Size = new System.Drawing.Size(61, 18);
            this.lblSucesion.TabIndex = 9;
            this.lblSucesion.Text = "Sucesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fibonacci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSucesion);
            this.Controls.Add(this.chcMultiplicar);
            this.Controls.Add(this.chcDividir);
            this.Controls.Add(this.chcRestar);
            this.Controls.Add(this.chcSum);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resultados.ResumeLayout(false);
            this.Resultados.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.GroupBox Resultados;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.CheckBox chcSum;
        private System.Windows.Forms.CheckBox chcRestar;
        private System.Windows.Forms.CheckBox chcDividir;
        private System.Windows.Forms.CheckBox chcMultiplicar;
        private System.Windows.Forms.Label lblSucesion;
        private System.Windows.Forms.Label label1;
    }
}

