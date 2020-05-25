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
                int NumeroElemento =GetRandomNumber(0.0, Palabras.Count());
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
            //Declara ganador dependiendo de las caantidad de caracteres contador juegos ganados ContadorAciertos == Convert.ToInt32(Acier)

            int largeWord = SelectedWord.Length;
            //MessageBox.Show(largeWord.ToString());
            string PicAcertadas = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\bin\";
            if (p0.ImageLocation == PicAcertadas && p1.ImageLocation == PicAcertadas && p2.ImageLocation == PicAcertadas && p3.ImageLocation == PicAcertadas && p4.ImageLocation == PicAcertadas)
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
            switch (largeWord)
            {
                case 3:
                    string c30 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c31 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c32 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    if (p0.ImageLocation == c30 && p1.ImageLocation == c31 && p2.ImageLocation ==c32)
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
                    break;
                case 4:
                    string c40 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c41 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c42 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c43 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    if (p0.ImageLocation == c40 && p1.ImageLocation == c41 && p2.ImageLocation == c42&&p3.ImageLocation==c43)
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
                    break;
                case 5:
                    string c50 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c51 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c52 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c53 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    string c54 = PicAcertadas + SelectedWord.ElementAt(4) + ".jpg";
                    if (p0.ImageLocation == c50 && p1.ImageLocation == c51 && p2.ImageLocation == c52 && p3.ImageLocation == c53&&p4.ImageLocation==c54)
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
                    break;
                case 6:
                    string c60 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c61 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c62 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c63 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    string c64 = PicAcertadas + SelectedWord.ElementAt(4) + ".jpg";
                    string c65 = PicAcertadas + SelectedWord.ElementAt(5) + ".jpg";
                    if (p0.ImageLocation == c60 && p1.ImageLocation == c61 && p2.ImageLocation == c62 && p3.ImageLocation == c63 && p4.ImageLocation == c64&&p5.ImageLocation==c65)
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
                    break;
                case 7:
                    string c70 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c71 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c72 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c73 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    string c74 = PicAcertadas + SelectedWord.ElementAt(4) + ".jpg";
                    string c75 = PicAcertadas + SelectedWord.ElementAt(5) + ".jpg";
                    string c76 = PicAcertadas + SelectedWord.ElementAt(6) + ".jpg";
                    if (p0.ImageLocation == c70 && p1.ImageLocation == c71 && p2.ImageLocation == c72 && p3.ImageLocation == c73 && p4.ImageLocation == c74 && p5.ImageLocation == c75&&p6.ImageLocation==c76)
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
                    break;
                case 8:
                    string c80 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c81 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c82 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c83 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    string c84 = PicAcertadas + SelectedWord.ElementAt(4) + ".jpg";
                    string c85 = PicAcertadas + SelectedWord.ElementAt(5) + ".jpg";
                    string c86 = PicAcertadas + SelectedWord.ElementAt(6) + ".jpg";
                    string c87 = PicAcertadas + SelectedWord.ElementAt(7) + ".jpg";
                    if (p0.ImageLocation == c80 && p1.ImageLocation == c81 && p2.ImageLocation == c82 && p3.ImageLocation == c83 && p4.ImageLocation == c84 && p5.ImageLocation == c85 && p6.ImageLocation == c86&&
                        p7.ImageLocation==c87)
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
                    break;
                case 9:
                    string c90 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c91 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c92 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c93 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    string c94 = PicAcertadas + SelectedWord.ElementAt(4) + ".jpg";
                    string c95 = PicAcertadas + SelectedWord.ElementAt(5) + ".jpg";
                    string c96 = PicAcertadas + SelectedWord.ElementAt(6) + ".jpg";
                    string c97 = PicAcertadas + SelectedWord.ElementAt(7) + ".jpg";
                    string c98 = PicAcertadas + SelectedWord.ElementAt(8) + ".jpg";
                    if (p0.ImageLocation == c90 && p1.ImageLocation == c91 && p2.ImageLocation == c92 && p3.ImageLocation == c93 && p4.ImageLocation == c94 && p5.ImageLocation == c95 && p6.ImageLocation == c96 &&
                        p7.ImageLocation == c97&&p8.ImageLocation==c98)
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
                    break;
                case 10:
                    string c100 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c101 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c102 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c103 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    string c104 = PicAcertadas + SelectedWord.ElementAt(4) + ".jpg";
                    string c105 = PicAcertadas + SelectedWord.ElementAt(5) + ".jpg";
                    string c106 = PicAcertadas + SelectedWord.ElementAt(6) + ".jpg";
                    string c107 = PicAcertadas + SelectedWord.ElementAt(7) + ".jpg";
                    string c108 = PicAcertadas + SelectedWord.ElementAt(8) + ".jpg";
                    string c109 = PicAcertadas + SelectedWord.ElementAt(9) + ".jpg";
                    if (p0.ImageLocation == c100 && p1.ImageLocation == c101 && p2.ImageLocation == c102 && p3.ImageLocation == c103 && p4.ImageLocation == c104 && p5.ImageLocation == c105 && p6.ImageLocation == c106 &&
                        p7.ImageLocation == c107 && p8.ImageLocation == c108&&p9.ImageLocation==c109)
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
                    break;
                case 11:
                    string c110 = PicAcertadas + SelectedWord.ElementAt(0) + ".jpg";
                    string c111 = PicAcertadas + SelectedWord.ElementAt(1) + ".jpg";
                    string c112 = PicAcertadas + SelectedWord.ElementAt(2) + ".jpg";
                    string c113 = PicAcertadas + SelectedWord.ElementAt(3) + ".jpg";
                    string c114 = PicAcertadas + SelectedWord.ElementAt(4) + ".jpg";
                    string c115 = PicAcertadas + SelectedWord.ElementAt(5) + ".jpg";
                    string c116 = PicAcertadas + SelectedWord.ElementAt(6) + ".jpg";
                    string c117 = PicAcertadas + SelectedWord.ElementAt(7) + ".jpg";
                    string c118 = PicAcertadas + SelectedWord.ElementAt(8) + ".jpg";
                    string c119 = PicAcertadas + SelectedWord.ElementAt(9) + ".jpg";
                    string c1110 = PicAcertadas + SelectedWord.ElementAt(10) + ".jpg";
                    if (p0.ImageLocation == c110 && p1.ImageLocation == c111 && p2.ImageLocation == c112 && p3.ImageLocation == c113 && p4.ImageLocation == c114 && p5.ImageLocation == c115 && p6.ImageLocation == c116 &&
                        p7.ImageLocation == c117 && p8.ImageLocation == c118 && p9.ImageLocation == c119&&p10.ImageLocation==c1110)
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
                    break;
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
