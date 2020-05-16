using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public class AhorcadoComponents
    {
        public List<string> SetWords()
        {
            List<string> Word = new List<string>();
            Word.Add("arbol");
            Word.Add("perro");
            Word.Add("computadora");
            Word.Add("lapiz");
            Word.Add("pastel");
            Word.Add("manzana");
            Word.Add("pizza");
            Word.Add("dato");
            Word.Add("cacahuate");
            Word.Add("motocicleta");
            Word.Add("automovil");
            Word.Add("estudiante");
            Word.Add("cucaracha");
            Word.Add("cuarentena");
            return Word;
        }
    }
}