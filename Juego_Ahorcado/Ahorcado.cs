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
using System.IO;

namespace Juego_Ahorcado
{
    public partial class Ahorcado : Form
    {
        List<string> Palabras = new List<string>();
        AhorcadoComponents AhorcadoClase;
        string SelectedWord; //Palabra seleccionada
        int ContadorErrores = 0;
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
            tIntento.Enabled = true;
            bIntentar.Enabled = true;
            this.ActiveControl = tIntento;
            try
             {
                int NumeroElemento = GetRandomNumber(0.0, Palabras.Count());
                SelectedWord = Palabras[NumeroElemento].ToString();
                int Size = SelectedWord.Length;

                MessageBox.Show(SelectedWord);

                switch (Size)
                {
                    case 3:
                        p0.Visible = true;
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = false;
                        p4.Visible = false;
                        p5.Visible = false;
                        p6.Visible = false;
                        p7.Visible = false;
                        p8.Visible = false;
                        p9.Visible = false;
                        p10.Visible = false;
                        break;
                    case 4:
                        p0.Visible = true;
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
                        break;
                    case 5:
                        p0.Visible = true;
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
                        break;
                    case 6:
                        p0.Visible = true;
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
                        break;
                    case 7:
                        p0.Visible = true;
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
                        break;
                    case 8:
                        p0.Visible = true;
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
                        break;
                    case 9:
                        p0.Visible = true;
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
                        break;
                    case 10:
                        p0.Visible = true;
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
                        break;

                    case 11:
                        p0.Visible = true;
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

        private void bIntentar_Click(object sender, EventArgs e)
        {
            FuncionContarErrores(tIntento.Text, SelectedWord);
            List<int> Posiciones = GetPositions(tIntento.Text, SelectedWord);
            SetWordInPictureBox(Posiciones);
            tIntento.Clear();
            SetErrorsInPictureBox();

            string ImageLocation;
            String Equivocaiones = Convert.ToString(ContadorErrores);
            ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\bin\" + ContadorErrores + ".jpg";
            pAhorcado.ImageLocation = ImageLocation;
            tEquivocaciones.Text = Equivocaiones;

            MessageBox.Show(ContadorErrores.ToString());
            if (ContadorErrores >5)
            {
                MessageBox.Show("Ud ha perdido");
                bIntentar.Enabled = false;

            }
            
            
        }

        void FuncionContarErrores(string letra, string palabra)
        {
            if(palabra.Contains(letra)==false)
            {
                ContadorErrores++;
            }
        }

        List<int> GetPositions(string letra, string palabra)
        {
            List<int> Positions = new List<int>();

            for (int i = 0; i < palabra.Length; i++)
            {
                if(letra==palabra.ElementAt(i).ToString())
                {
                    Positions.Add(i);
                }
            }

            return Positions;
        }

        void SetWordInPictureBox(List<int> Palabras)
        {
            string ImageLocation;
            foreach(int i in Palabras)
            {
                ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\bin\" + SelectedWord.ElementAt(i) + ".jpg";
                switch (i)
                {
                    case 0:
                        p0.ImageLocation = ImageLocation;
                        break;
                    case 1:
                        p1.ImageLocation = ImageLocation;
                        break;
                    case 2:
                        p2.ImageLocation = ImageLocation;
                        break;
                    case 3:
                        p3.ImageLocation = ImageLocation;
                        break;
                    case 4:
                        p4.ImageLocation = ImageLocation;
                        break;
                    case 5:
                        p5.ImageLocation = ImageLocation;
                        break;
                    case 6:
                        p6.ImageLocation = ImageLocation;
                        break;
                    case 7:
                        p7.ImageLocation = ImageLocation;
                        break;
                    case 8:
                        p8.ImageLocation = ImageLocation;
                        break;
                    case 9:
                        p9.ImageLocation = ImageLocation;
                        break;
                    case 10:
                        p10.ImageLocation = ImageLocation;
                        break;
                }
            }
        }

        void SetErrorsInPictureBox()
        {
            //Aqui agregar codigo que evalúa cuántos errores hay y asignar a Picturebox de Errores la imagen que corresponde según la cantidad de errores
            //El picture box debe estar inicializado en Visible=false, para que el usuario no vea al principio
            //Cuando se equivoca, aparece con la imagen "Ahorcado" de la carpeta Bin
            //Cuando llega a 6 (o 7, no recuerdo), entonces debe aparecer un mensaje que diga que perdió
            //Cuando el usuario pierde, entonces todo se reinicia (selectedWord, Cantidad de Errores, Pictures Boxes mostrados, etc...)
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tIntento_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bIntentar_Click(sender, e);
            }
        }

        private void tIntento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if(tIntento.Text.Length > 0)
                //{
                //    tIntento.Text = tIntento.Text.Substring(0, 1);
                //}
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }
    }
}
