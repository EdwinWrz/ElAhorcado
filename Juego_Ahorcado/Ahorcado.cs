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
        int ContadorAciertos = 0;
        int JuegoTotal = 0;
        int Win = 0;
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
            bSeleccionar.Enabled = false;
            tIntento.Visible = true;
            tIntento.Enabled = true;
            bIntentar.Enabled = true;
            this.ActiveControl = tIntento;
            try
            {
                int NumeroElemento = 0;//GetRandomNumber(0.0, Palabras.Count());
                SelectedWord = Palabras[NumeroElemento].ToString();
                int Size = SelectedWord.Length;

                MessageBox.Show(SelectedWord);
                string ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\bin\" + "inte" + ".jpg";
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
                        p4.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
                        p4.ImageLocation = ImageLocation;
                        p5.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
                        p4.ImageLocation = ImageLocation;
                        p5.ImageLocation = ImageLocation;
                        p6.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
                        p4.ImageLocation = ImageLocation;
                        p5.ImageLocation = ImageLocation;
                        p6.ImageLocation = ImageLocation;
                        p7.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
                        p4.ImageLocation = ImageLocation;
                        p5.ImageLocation = ImageLocation;
                        p6.ImageLocation = ImageLocation;
                        p7.ImageLocation = ImageLocation;
                        p8.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
                        p4.ImageLocation = ImageLocation;
                        p5.ImageLocation = ImageLocation;
                        p6.ImageLocation = ImageLocation;
                        p7.ImageLocation = ImageLocation;
                        p8.ImageLocation = ImageLocation;
                        p9.ImageLocation = ImageLocation;
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
                        p0.ImageLocation = ImageLocation;
                        p1.ImageLocation = ImageLocation;
                        p2.ImageLocation = ImageLocation;
                        p3.ImageLocation = ImageLocation;
                        p4.ImageLocation = ImageLocation;
                        p5.ImageLocation = ImageLocation;
                        p6.ImageLocation = ImageLocation;
                        p7.ImageLocation = ImageLocation;
                        p8.ImageLocation = ImageLocation;
                        p9.ImageLocation = ImageLocation;
                        p10.ImageLocation = ImageLocation;
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
            pAhorcado.Visible = true;
            FuncionContarErrores(tIntento.Text, SelectedWord);
            List<int> Posiciones = GetPositions(tIntento.Text, SelectedWord);
            SetWordInPictureBox(Posiciones);
            tIntento.Clear();
            SetErrorsInPictureBox();

            //Codigo para mostrar imagen de progreso de errores
            string ImagenLocacion;
            ImagenLocacion = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\bin\" + ContadorErrores + ".jpg";
            pAhorcado.ImageLocation = ImagenLocacion;
            int Acier = SelectedWord.Length;
            //MessageBox.Show(ContadorErrores.ToString());
            //MessageBox.Show(ContadorAciertos.ToString());
            
            //Declarar perdedor
            if (ContadorErrores > 5)
            {
                MessageBox.Show("Ud ha perdido");
                pAhorcado.Visible = false;
                bSeleccionar.Enabled = true;
                bIntentar.Enabled = false;
                tIntento.Visible = false;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                JuegoTotal++;
                PicClear();
            }
            //contador juegos ganados 
            int i =0;
            //
            string PicAcertadas = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\bin\" + SelectedWord.ElementAt(i) + ".jpg";
            /*if ((p0.ImageLocation==PicAcertadas&& p1.ImageLocation == PicAcertadas&& p2.ImageLocation == PicAcertadas&& p3.ImageLocation == PicAcertadas&&
                p4.ImageLocation == PicAcertadas&& p5.ImageLocation == PicAcertadas&& p6.ImageLocation == PicAcertadas && p7.ImageLocation == PicAcertadas &&
                p8.ImageLocation == PicAcertadas && p9.ImageLocation == PicAcertadas&& p10.ImageLocation == PicAcertadas) || (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas &&
                p4.ImageLocation == PicAcertadas && p5.ImageLocation == PicAcertadas && p6.ImageLocation == PicAcertadas && p7.ImageLocation == PicAcertadas &&
                p8.ImageLocation == PicAcertadas && p9.ImageLocation == PicAcertadas) || (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas &&
                p4.ImageLocation == PicAcertadas && p5.ImageLocation == PicAcertadas && p6.ImageLocation == PicAcertadas && p7.ImageLocation == PicAcertadas &&
                p8.ImageLocation == PicAcertadas) || (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas &&
                p4.ImageLocation == PicAcertadas && p5.ImageLocation == PicAcertadas && p6.ImageLocation == PicAcertadas && p7.ImageLocation == PicAcertadas)
                || (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas &&
                p4.ImageLocation == PicAcertadas && p5.ImageLocation == PicAcertadas && p6.ImageLocation == PicAcertadas) || (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas &&
                p4.ImageLocation == PicAcertadas && p5.ImageLocation == PicAcertadas) || (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas &&
                p4.ImageLocation == PicAcertadas) || (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas))*/
            
                if(ContadorAciertos == Convert.ToInt32(Acier))
                { 
                MessageBox.Show("Ganador!!!!");
                bSeleccionar.Enabled = true;
                bIntentar.Enabled = false;
                tIntento.Visible = false;
                pAhorcado.Visible = false;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                Win++;
                JuegoTotal++;
                PicClear();
                }
            //Contadores de tableros del juego
            string Equivocaiones = Convert.ToString(ContadorErrores);
            string Aciertos = Convert.ToString(ContadorAciertos);
            string Won = Convert.ToString(Win);
            string JuegosTotales = Convert.ToString(JuegoTotal);
            tEquivocaciones.Text = Equivocaiones;
            tAciertos.Text = Aciertos;
            tWin.Text = Won;
            tJuegosTotal.Text = JuegosTotales;
        }
        void PicClear()
        {
            p0.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p6.Visible = false;
            p7.Visible = false;
            p8.Visible = false;
            p9.Visible = false;
            p10.Visible = false;
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
                    ContadorAciertos++;
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
