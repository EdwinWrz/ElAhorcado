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

                int NumeroElemento = 1; // GetRandomNumber(0.0, Palabras.Count());
                string SelectedWord = Palabras[NumeroElemento].ToString();
                int Size = SelectedWord.Length;
                switch (Size)
                {
                    case 4:
                        p1.Visible = true;
                        break;
                    case 5:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
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
