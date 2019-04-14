using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultadoLoterias
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void rb_CheckedChanged(object sender, EventArgs e)
    {
      if (rbMegaSena.Checked)
      {
        if (panel1.Controls.Count > 0)
          this.panel1.Controls.RemoveAt(0);
        this.panel1.Controls.Add(new UC.UCMegaSena());
      }
      else if (rbLotofacil.Checked)
      {
        if (panel1.Controls.Count > 0)
          this.panel1.Controls.RemoveAt(0);
        this.panel1.Controls.Add(new UC.UCLotofacil());
      }
      else
      {
        if (panel1.Controls.Count > 0)
          this.panel1.Controls.RemoveAt(0);
        this.panel1.Controls.Add(new UC.UCLotomania());
      }
    }

    private void btnResult_Click(object sender, EventArgs e)
    {
      if (this.panel1.Controls.Count > 0)
      {
        txtResultado.Text = txtResultado.Text.Replace("   ", " ").Replace("  ", " ").Replace("   ", " ").Replace("  ", " ");

        if (rbMegaSena.Checked)
          ((UC.UCMegaSena)this.panel1.Controls[0]).GetResult(txtResultado.Text);
        else if (rbLotofacil.Checked)
          ((UC.UCLotofacil)this.panel1.Controls[0]).GetResult(txtResultado.Text);
        else
          ((UC.UCMegaSena)this.panel1.Controls[0]).GetResult(txtResultado.Text);
      }
    }

    private void txtResultado_TextChanged(object sender, EventArgs e)
    {
      try
      {

        txtResultado.Text = txtResultado.Text.Replace(Environment.NewLine, " ").Replace("\t", " ").Replace("     ", " ").Replace("    ", " ").Replace("   ", " ").Replace("  ", " ").TrimEnd();

        if (!txtResultado.Text.Contains(" "))
        {
          string resultado = string.Empty;

          int strLength = txtResultado.Text.Length;

          for (int i = 0; i < strLength; i++)
          {
            if(i == 0 || i % 2 != 0)
            {
              resultado += txtResultado.Text[i];
            }
            else
            {
              resultado += $" {txtResultado.Text[i]}";
            }
          }

          txtResultado.Text = resultado;
        }

        txtResultado.ScrollToCaret();
      }
      catch (Exception ex){ }
    }
  }
}

