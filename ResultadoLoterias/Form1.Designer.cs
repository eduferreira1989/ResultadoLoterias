namespace ResultadoLoterias
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.rbMegaSena = new System.Windows.Forms.RadioButton();
      this.rbLotofacil = new System.Windows.Forms.RadioButton();
      this.rbLotomania = new System.Windows.Forms.RadioButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.txtResultado = new System.Windows.Forms.TextBox();
      this.btnResult = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // rbMegaSena
      // 
      this.rbMegaSena.AutoSize = true;
      this.rbMegaSena.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbMegaSena.Location = new System.Drawing.Point(5, 3);
      this.rbMegaSena.Name = "rbMegaSena";
      this.rbMegaSena.Size = new System.Drawing.Size(99, 23);
      this.rbMegaSena.TabIndex = 0;
      this.rbMegaSena.TabStop = true;
      this.rbMegaSena.Text = "Mega Sena";
      this.rbMegaSena.UseVisualStyleBackColor = true;
      this.rbMegaSena.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // rbLotofacil
      // 
      this.rbLotofacil.AutoSize = true;
      this.rbLotofacil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbLotofacil.Location = new System.Drawing.Point(107, 3);
      this.rbLotofacil.Name = "rbLotofacil";
      this.rbLotofacil.Size = new System.Drawing.Size(83, 23);
      this.rbLotofacil.TabIndex = 1;
      this.rbLotofacil.TabStop = true;
      this.rbLotofacil.Text = "Lotofácil";
      this.rbLotofacil.UseVisualStyleBackColor = true;
      this.rbLotofacil.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // rbLotomania
      // 
      this.rbLotomania.AutoSize = true;
      this.rbLotomania.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbLotomania.Location = new System.Drawing.Point(203, 3);
      this.rbLotomania.Name = "rbLotomania";
      this.rbLotomania.Size = new System.Drawing.Size(95, 23);
      this.rbLotomania.TabIndex = 2;
      this.rbLotomania.TabStop = true;
      this.rbLotomania.Text = "Lotomania";
      this.rbLotomania.UseVisualStyleBackColor = true;
      this.rbLotomania.Visible = false;
      this.rbLotomania.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(4, 75);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(693, 453);
      this.panel1.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(1, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(410, 19);
      this.label1.TabIndex = 4;
      this.label1.Text = "Informe os números sorteados separados por espaço simples:";
      // 
      // txtResultado
      // 
      this.txtResultado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResultado.Location = new System.Drawing.Point(4, 41);
      this.txtResultado.Multiline = true;
      this.txtResultado.Name = "txtResultado";
      this.txtResultado.Size = new System.Drawing.Size(510, 29);
      this.txtResultado.TabIndex = 5;
      this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
      // 
      // btnResult
      // 
      this.btnResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
      this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnResult.Location = new System.Drawing.Point(529, 41);
      this.btnResult.Margin = new System.Windows.Forms.Padding(0);
      this.btnResult.Name = "btnResult";
      this.btnResult.Size = new System.Drawing.Size(168, 29);
      this.btnResult.TabIndex = 6;
      this.btnResult.Text = "Processar Resultado";
      this.btnResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnResult.UseVisualStyleBackColor = true;
      this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(701, 531);
      this.Controls.Add(this.btnResult);
      this.Controls.Add(this.txtResultado);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.rbLotomania);
      this.Controls.Add(this.rbLotofacil);
      this.Controls.Add(this.rbMegaSena);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(717, 570);
      this.MinimumSize = new System.Drawing.Size(717, 570);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Resultados de Loterias Caixa";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMegaSena;
        private System.Windows.Forms.RadioButton rbLotofacil;
        private System.Windows.Forms.RadioButton rbLotomania;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnResult;
    }
}

