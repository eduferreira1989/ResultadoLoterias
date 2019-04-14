namespace ResultadoLoterias.UC
{
    partial class UCLotofacil
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLotofacil));
      this.dgApostas = new System.Windows.Forms.DataGridView();
      this.btnGenerateModel = new System.Windows.Forms.Button();
      this.btnImport = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.dgApostas)).BeginInit();
      this.SuspendLayout();
      // 
      // dgApostas
      // 
      this.dgApostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgApostas.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dgApostas.Location = new System.Drawing.Point(0, 35);
      this.dgApostas.Name = "dgApostas";
      this.dgApostas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.dgApostas.Size = new System.Drawing.Size(693, 418);
      this.dgApostas.TabIndex = 5;
      // 
      // btnGenerateModel
      // 
      this.btnGenerateModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGenerateModel.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateModel.Image")));
      this.btnGenerateModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnGenerateModel.Location = new System.Drawing.Point(162, 2);
      this.btnGenerateModel.Name = "btnGenerateModel";
      this.btnGenerateModel.Size = new System.Drawing.Size(224, 27);
      this.btnGenerateModel.TabIndex = 4;
      this.btnGenerateModel.Text = "Gerar Modelo de Importação";
      this.btnGenerateModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnGenerateModel.UseVisualStyleBackColor = true;
      this.btnGenerateModel.Click += new System.EventHandler(this.btnGenerateModel_Click);
      // 
      // btnImport
      // 
      this.btnImport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
      this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnImport.Location = new System.Drawing.Point(0, 2);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(149, 27);
      this.btnImport.TabIndex = 3;
      this.btnImport.Text = "Importar Apostas";
      this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
      // 
      // UCLotofacil
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgApostas);
      this.Controls.Add(this.btnGenerateModel);
      this.Controls.Add(this.btnImport);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "UCLotofacil";
      this.Size = new System.Drawing.Size(693, 453);
      ((System.ComponentModel.ISupportInitialize)(this.dgApostas)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgApostas;
        private System.Windows.Forms.Button btnGenerateModel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
