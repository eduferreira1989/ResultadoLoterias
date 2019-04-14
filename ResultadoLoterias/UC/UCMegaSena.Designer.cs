namespace ResultadoLoterias.UC
{
    partial class UCMegaSena
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMegaSena));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnImport = new System.Windows.Forms.Button();
      this.btnGenerateModel = new System.Windows.Forms.Button();
      this.dgApostas = new System.Windows.Forms.DataGridView();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.dgApostas)).BeginInit();
      this.SuspendLayout();
      // 
      // btnImport
      // 
      this.btnImport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
      this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnImport.Location = new System.Drawing.Point(0, 2);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(149, 29);
      this.btnImport.TabIndex = 0;
      this.btnImport.Text = "Importar Apostas";
      this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // btnGenerateModel
      // 
      this.btnGenerateModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGenerateModel.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateModel.Image")));
      this.btnGenerateModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnGenerateModel.Location = new System.Drawing.Point(162, 2);
      this.btnGenerateModel.Name = "btnGenerateModel";
      this.btnGenerateModel.Size = new System.Drawing.Size(224, 29);
      this.btnGenerateModel.TabIndex = 1;
      this.btnGenerateModel.Text = "Gerar Modelo de Importação";
      this.btnGenerateModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnGenerateModel.UseVisualStyleBackColor = true;
      this.btnGenerateModel.Click += new System.EventHandler(this.btnGenerateModel_Click);
      // 
      // dgApostas
      // 
      this.dgApostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgApostas.DefaultCellStyle = dataGridViewCellStyle1;
      this.dgApostas.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dgApostas.Location = new System.Drawing.Point(0, 35);
      this.dgApostas.Name = "dgApostas";
      this.dgApostas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.dgApostas.Size = new System.Drawing.Size(693, 418);
      this.dgApostas.TabIndex = 2;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
      // 
      // UCMegaSena
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgApostas);
      this.Controls.Add(this.btnGenerateModel);
      this.Controls.Add(this.btnImport);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "UCMegaSena";
      this.Size = new System.Drawing.Size(693, 453);
      ((System.ComponentModel.ISupportInitialize)(this.dgApostas)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnGenerateModel;
        private System.Windows.Forms.DataGridView dgApostas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
