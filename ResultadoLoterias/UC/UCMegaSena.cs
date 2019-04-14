using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ResultadoLoterias.UC
{
  public partial class UCMegaSena : UserControl
  {
    private string _numerosSorteados = string.Empty;
    private List<MegaSena> lstApostas;

    public UCMegaSena()
    {
      InitializeComponent();
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
    }

    private void btnGenerateModel_Click(object sender, EventArgs e)
    {
      DialogResult dResult = MessageBox.Show(@"Será criado o arquivo C:\Users\Public\ExemploApostasMegaSena.xml que demonstra o modelo para o arquivo de importação. Deseja criá-lo?", "Deseja criar arquivo modelo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (dResult == DialogResult.Yes)
      {
        TextWriter txtWriter = new StreamWriter(@"C:\Users\Public\ExemploApostasMegaSena.xml");
        try
        {
          List<MegaSena> lst = new List<MegaSena>();
          MegaSena msAux = new MegaSena
          {
            N1 = 0,
            N2 = 0,
            N3 = 0,
            N4 = 0,
            N5 = 0,
            N6 = 0
          };
          lst.Add(msAux);
          lst.Add(msAux);

          XmlSerializer serializador = new XmlSerializer(typeof(List<MegaSena>));
          serializador.Serialize(txtWriter, lst);
        }
        finally
        {
          txtWriter.Close();
        }
      }
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      string _nomeArquivo = openFileDialog1.FileName;

      lstApostas = new List<MegaSena>();
      if (File.Exists(_nomeArquivo))
      {
        // Se é um XML 
        if (_nomeArquivo.EndsWith(".xml"))
        {
          XmlSerializer serializador = new XmlSerializer(typeof(List<MegaSena>));

          using (TextReader textReader = new StreamReader(_nomeArquivo))
          {
            try
            {
              object o = serializador.Deserialize(textReader);
              lstApostas = o as List<MegaSena>;
            }
            catch
            {
              MessageBox.Show("Arquivo de importação de apostas corrompido, favor verificar dados inseridos.", "Arquivo corrompido", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }
          }
        }
        // Se é um txt separado por tabs
        else
        {
          using (TextReader textReader = new StreamReader(_nomeArquivo))
          {
            try
            {
              string[] apostasArray = textReader.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

              for (int i = 0; i < apostasArray.Length; i++)
              {
                string[] aposta = apostasArray[i].Split('\t');
                MegaSena jogo = new MegaSena();

                jogo.N1 = Convert.ToInt32(aposta[0]);
                jogo.N2 = Convert.ToInt32(aposta[1]);
                jogo.N3 = Convert.ToInt32(aposta[2]);
                jogo.N4 = Convert.ToInt32(aposta[3]);
                jogo.N5 = Convert.ToInt32(aposta[4]);
                jogo.N6 = Convert.ToInt32(aposta[5]);

                lstApostas.Add(jogo);
              }
            }
            catch
            {
              MessageBox.Show("Arquivo de importação de apostas corrompido, favor verificar dados inseridos.", "Arquivo corrompido", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }
          }
        }
      }

      dgApostas.Columns.Clear();
      dgApostas.DataSource = lstApostas;
      dgApostas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgApostas.Refresh();

    }

    public void GetResult(string result)
    {
      string[] strResults = result.Split(' ');
      int[] intResults = new int[6];

      try
      {
        if (strResults.Length != 6)
          throw new Exception();

        for (int i = 0; i < strResults.Length; i++)
        {
          intResults[i] = Convert.ToInt32(strResults[i]);
        }
      }
      catch
      {
        MessageBox.Show("Resultado está fora do formato/número de dezenas do jogo, favor verificar dados inseridos.", "Resultado incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      dgApostas.Columns.Clear();
      dgApostas.DataSource = null;
      dgApostas.Columns.Add("N1", "N1");
      dgApostas.Columns.Add("N2", "N2");
      dgApostas.Columns.Add("N3", "N3");
      dgApostas.Columns.Add("N4", "N4");
      dgApostas.Columns.Add("N5", "N5");
      dgApostas.Columns.Add("N6", "N6");
      dgApostas.Columns.Add("Result", "Result");

      dgApostas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

      for (int i = 0; i < lstApostas.Count; i++)
      {
        List<int> lstAcertos = new List<int>();

        for (int j = 0; j < intResults.Length; j++)
        {
          if (lstApostas[i].N1 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N2 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N3 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N4 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N5 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N6 == intResults[j])
            lstAcertos.Add(intResults[j]);

        }

        DataGridViewRow row = new DataGridViewRow();

        DataGridViewCell cellN1 = new DataGridViewTextBoxCell();
        cellN1.Value = lstApostas[i].N1;
        if (lstAcertos.Contains(Convert.ToInt32(cellN1.Value)))
          cellN1.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN2 = new DataGridViewTextBoxCell();
        cellN2.Value = lstApostas[i].N2;
        if (lstAcertos.Contains(Convert.ToInt32(cellN2.Value)))
          cellN2.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN3 = new DataGridViewTextBoxCell();
        cellN3.Value = lstApostas[i].N3;
        if (lstAcertos.Contains(Convert.ToInt32(cellN3.Value)))
          cellN3.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN4 = new DataGridViewTextBoxCell();
        cellN4.Value = lstApostas[i].N4;
        if (lstAcertos.Contains(Convert.ToInt32(cellN4.Value)))
          cellN4.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN5 = new DataGridViewTextBoxCell();
        cellN5.Value = lstApostas[i].N5;
        if (lstAcertos.Contains(Convert.ToInt32(cellN5.Value)))
          cellN5.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN6 = new DataGridViewTextBoxCell();
        cellN6.Value = lstApostas[i].N6;
        if (lstAcertos.Contains(Convert.ToInt32(cellN6.Value)))
          cellN6.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellResult = new DataGridViewTextBoxCell();
        cellResult.Value = lstAcertos.Count;

        if (Convert.ToInt32(cellResult.Value) == 4)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.Yellow, ForeColor = Color.Black };
        else if (Convert.ToInt32(cellResult.Value) == 5)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.Gold, ForeColor = Color.Black };
        else if (Convert.ToInt32(cellResult.Value) == 6)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.Red, ForeColor = Color.White };
        else
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.White, ForeColor = Color.Black };

        row.Cells.Add(cellN1);
        row.Cells.Add(cellN2);
        row.Cells.Add(cellN3);
        row.Cells.Add(cellN4);
        row.Cells.Add(cellN5);
        row.Cells.Add(cellN6);
        row.Cells.Add(cellResult);

        dgApostas.Rows.Add(row);

      }

      dgApostas.Refresh();
    }
  }
}
