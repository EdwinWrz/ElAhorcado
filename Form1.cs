using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ahorcado;

namespace Ahorcado
{
    public partial class fAhorcado : Form
    {
        List<string> Palabras = new List<string>();
        AhorcadoComponents AhorcadoClase;
        public fAhorcado()
        {
            InitializeComponent();
        }
        private void Ahorcado_Load(object sender, EventArgs e)
        {
            AhorcadoClase = new AhorcadoComponents();
            Palabras = AhorcadoClase.SetWords();
        }
        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                int NumeroElemento = GetRandomNumber(0.0, Palabras.Count());
                string SelectedWord = Palabras[NumeroElemento].ToString();
                int Size = SelectedWord.Length;
                switch (Size)
                {
                    case 1:
                        p1.Visible = true;
                        break;
                    case 2:
                        p1.Visible = true;
                        p2.Visible = true;
                        break;
                    case 3:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        break;
                    case 4:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        break;
                    case 5:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        break;
                    case 6:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = true;
                        break;
                    case 7:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = true;
                        p7.Visible = true;
                        break;
                    case 8:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = true;
                        p7.Visible = true;
                        p8.Visible = true;
                        break;
                    case 9:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = true;
                        p7.Visible = true;
                        p8.Visible = true;
                        p9.Visible = true;
                        break;
                    case 10:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = true;
                        p7.Visible = true;
                        p8.Visible = true;
                        p9.Visible = true;
                        p10.Visible = true;
                        break;

                }


            }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }

          }

         public int GetRandomNumber(double min, double max)
        {
            Random rnd = new Random();
            return Convert.ToInt32(rnd.NextDouble() * (max - min) + min);
        }
    }
}
