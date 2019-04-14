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
  public partial class UCLotofacil : UserControl
  {
    private string _numerosSorteados = string.Empty;
    private List<Lotofacil> lstApostas;

    public UCLotofacil()
    {
      InitializeComponent();
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
    }

    private void btnGenerateModel_Click(object sender, EventArgs e)
    {
      DialogResult dResult = MessageBox.Show(@"Será criado o arquivo C:\Users\Public\ExemploApostasLotofacil.xml que demonstra o modelo para o arquivo de importação. Deseja criá-lo?", "Deseja criar arquivo modelo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (dResult == DialogResult.Yes)
      {
        TextWriter txtWriter = new StreamWriter(@"C:\Users\Public\ExemploApostasLotofacil.xml");
        try
        {
          List<Lotofacil> lst = new List<Lotofacil>();
          Lotofacil lfAux = new Lotofacil
          {
            N1 = 0,
            N2 = 0,
            N3 = 0,
            N4 = 0,
            N5 = 0,
            N6 = 0,
            N7 = 0,
            N8 = 0,
            N9 = 0,
            N10 = 0,
            N11 = 0,
            N12 = 0,
            N13 = 0,
            N14 = 0,
            N15 = 0
          };
          lst.Add(lfAux);
          lst.Add(lfAux);

          XmlSerializer serializador = new XmlSerializer(typeof(List<Lotofacil>));
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

      lstApostas = new List<Lotofacil>();
      if (File.Exists(_nomeArquivo))
      {
        // Se é um XML 
        if (_nomeArquivo.EndsWith(".xml"))
        {
          XmlSerializer serializador = new XmlSerializer(typeof(List<Lotofacil>));

          using (TextReader textReader = new StreamReader(_nomeArquivo))
          {
            try
            {
              object o = serializador.Deserialize(textReader);
              lstApostas = o as List<Lotofacil>;
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
                Lotofacil jogo = new Lotofacil();

                jogo.N1 = Convert.ToInt32(aposta[0]);
                jogo.N2 = Convert.ToInt32(aposta[1]);
                jogo.N3 = Convert.ToInt32(aposta[2]);
                jogo.N4 = Convert.ToInt32(aposta[3]);
                jogo.N5 = Convert.ToInt32(aposta[4]);
                jogo.N6 = Convert.ToInt32(aposta[5]);
                jogo.N7 = Convert.ToInt32(aposta[6]);
                jogo.N8 = Convert.ToInt32(aposta[7]);
                jogo.N9 = Convert.ToInt32(aposta[8]);
                jogo.N10 = Convert.ToInt32(aposta[9]);
                jogo.N11 = Convert.ToInt32(aposta[10]);
                jogo.N12 = Convert.ToInt32(aposta[11]);
                jogo.N13 = Convert.ToInt32(aposta[12]);
                jogo.N14 = Convert.ToInt32(aposta[13]);
                jogo.N15 = Convert.ToInt32(aposta[14]);

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
      dgApostas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgApostas.Refresh();
    }

    public void GetResult(string result)
    {
      string[] strResults = result.Split(' ');
      int[] intResults = new int[15];

      try
      {
        if (strResults.Length != 15)
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
      dgApostas.Columns.Add("N7", "N7");
      dgApostas.Columns.Add("N8", "N8");
      dgApostas.Columns.Add("N9", "N9");
      dgApostas.Columns.Add("N10", "N10");
      dgApostas.Columns.Add("N11", "N11");
      dgApostas.Columns.Add("N12", "N12");
      dgApostas.Columns.Add("N13", "N13");
      dgApostas.Columns.Add("N14", "N14");
      dgApostas.Columns.Add("N15", "N15");
      dgApostas.Columns.Add("Result", "Result");

      dgApostas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

          if (lstApostas[i].N7 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N8 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N9 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N10 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N11 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N12 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N13 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N14 == intResults[j])
            lstAcertos.Add(intResults[j]);

          if (lstApostas[i].N15 == intResults[j])
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

        DataGridViewCell cellN7 = new DataGridViewTextBoxCell();
        cellN7.Value = lstApostas[i].N7;
        if (lstAcertos.Contains(Convert.ToInt32(cellN7.Value)))
          cellN7.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN8 = new DataGridViewTextBoxCell();
        cellN8.Value = lstApostas[i].N8;
        if (lstAcertos.Contains(Convert.ToInt32(cellN8.Value)))
          cellN8.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN9 = new DataGridViewTextBoxCell();
        cellN9.Value = lstApostas[i].N9;
        if (lstAcertos.Contains(Convert.ToInt32(cellN9.Value)))
          cellN9.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN10 = new DataGridViewTextBoxCell();
        cellN10.Value = lstApostas[i].N10;
        if (lstAcertos.Contains(Convert.ToInt32(cellN10.Value)))
          cellN10.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN11 = new DataGridViewTextBoxCell();
        cellN11.Value = lstApostas[i].N11;
        if (lstAcertos.Contains(Convert.ToInt32(cellN11.Value)))
          cellN11.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN12 = new DataGridViewTextBoxCell();
        cellN12.Value = lstApostas[i].N12;
        if (lstAcertos.Contains(Convert.ToInt32(cellN12.Value)))
          cellN12.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN13 = new DataGridViewTextBoxCell();
        cellN13.Value = lstApostas[i].N13;
        if (lstAcertos.Contains(Convert.ToInt32(cellN13.Value)))
          cellN13.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN14 = new DataGridViewTextBoxCell();
        cellN14.Value = lstApostas[i].N14;
        if (lstAcertos.Contains(Convert.ToInt32(cellN14.Value)))
          cellN14.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellN15 = new DataGridViewTextBoxCell();
        cellN15.Value = lstApostas[i].N15;
        if (lstAcertos.Contains(Convert.ToInt32(cellN15.Value)))
          cellN15.Style = new DataGridViewCellStyle { BackColor = Color.GreenYellow };

        DataGridViewCell cellResult = new DataGridViewTextBoxCell();
        cellResult.Value = lstAcertos.Count;

        if (Convert.ToInt32(cellResult.Value) == 11)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.Yellow, ForeColor = Color.Black };
        else if (Convert.ToInt32(cellResult.Value) == 12)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.Gold, ForeColor = Color.Black };
        else if (Convert.ToInt32(cellResult.Value) == 13)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.Orange, ForeColor = Color.Black };
        else if (Convert.ToInt32(cellResult.Value) == 14)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.DarkOrange, ForeColor = Color.White };
        else if (Convert.ToInt32(cellResult.Value) == 15)
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.Red, ForeColor = Color.White };
        else
          cellResult.Style = new DataGridViewCellStyle { BackColor = Color.White, ForeColor = Color.Black };

        row.Cells.Add(cellN1);
        row.Cells.Add(cellN2);
        row.Cells.Add(cellN3);
        row.Cells.Add(cellN4);
        row.Cells.Add(cellN5);
        row.Cells.Add(cellN6);
        row.Cells.Add(cellN7);
        row.Cells.Add(cellN8);
        row.Cells.Add(cellN9);
        row.Cells.Add(cellN10);
        row.Cells.Add(cellN11);
        row.Cells.Add(cellN12);
        row.Cells.Add(cellN13);
        row.Cells.Add(cellN14);
        row.Cells.Add(cellN15);
        row.Cells.Add(cellResult);

        dgApostas.Rows.Add(row);

      }

      dgApostas.Refresh();
    }
  }
}
