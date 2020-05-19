using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Juego_Ahorcado
{
    public partial class Ahorcado : Form
    {
            List<string> Palabras = new List<string>();
            AhorcadoComponents AhorcadoClase;
            public Ahorcado()
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
                                string str1 = "Test";
                                for (int ctr = 0; ctr <= str1.Length - 1; ctr++)
                                    Console.Write("{0} ", str1[ctr]);
            try
                  {
                        int NumeroElemento = GetRandomNumber(0.0, Palabras.Count());
                        string SelectedWord = Palabras[NumeroElemento].ToString();
                        int Size = SelectedWord.Length;
                        string[] word = SelectedWord.Split(' ');
                    MessageBox.Show(Palabras[NumeroElemento].ToString());


                        switch (Size)
                        {
       
                    case 3:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = false;
                        p5.Visible = false;
                        p6.Visible = false;
                        p7.Visible = false;
                        p8.Visible = false;
                        p9.Visible = false;
                        p10.Visible = false;
                        p11.Visible = false;
                        break;
                    case 4:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = false;
                        p6.Visible = false;
                        p7.Visible = false;
                        p8.Visible = false;
                        p9.Visible = false;
                        p10.Visible = false;
                        p11.Visible = false;
                        break;
                    case 5:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = false;
                        p7.Visible = false;
                        p8.Visible = false;
                        p9.Visible = false;
                        p10.Visible = false;
                        p11.Visible = false;
                        break;
                    case 6:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = true;
                        p7.Visible = false;
                        p8.Visible = false;
                        p9.Visible = false;
                        p10.Visible = false;
                        p11.Visible = false;
                        break;
                    case 7:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        p6.Visible = true;
                        p7.Visible = true;
                        p8.Visible = false;
                        p9.Visible = false;
                        p10.Visible = false;
                        p11.Visible = false;
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
                        p9.Visible = false;
                        p10.Visible = false;
                        p11.Visible = false;
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
                        p10.Visible = false;
                        p11.Visible = false;
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
                        p11.Visible = false;
                        break;

                    case 11:
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
                        p11.Visible = true;
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

        private void bIntentar_Click(object sender, EventArgs e)
        {



        }
    }
}
