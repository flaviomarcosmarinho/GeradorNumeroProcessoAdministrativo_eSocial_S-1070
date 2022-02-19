using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorNumeroProcessoAdministrativo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // Criar um objeto aleatório
            // Random rnd = new Random ();
            // Criar um objeto aleatório com uma semente com um grau de pseudoaleatória
            Random rnd = new Random (DateTime.Now.Millisecond);

            // Gerando um número aleátório entre 0 e 9
            int n1 = rnd.Next(9);
            int n2 = rnd.Next(9);
            int n3 = rnd.Next(9);
            int n4 = rnd.Next(9);
            int n5 = rnd.Next(9);
            int n6 = rnd.Next(9);
            int n7 = rnd.Next(9);
            int n8 = rnd.Next(9);
            int n9 = rnd.Next(9);
            int n10 = rnd.Next(9);
            int n11 = rnd.Next(9);
            int n12 = rnd.Next(9);
            int n13 = rnd.Next(9);
            int n14 = rnd.Next(9);
            int n15 = rnd.Next(9);

            //Exemplo:  35041.000387/2000
            //a)(0x2)+(0x3)+(0x4)+(2x5)+(7x6)+(8x7)+(3x8)+(0x9)+(0x10)+(0x11)+(1x12)+(4x13)+(0x14)+(5x15)+(3x16);
            //b) 0+0+0+10+42+56+24+0+0+0+12+52+0+75+48= 319
            //c) 319÷11 = 29; RESTO = 0;
            //d) 11-0= 11- despreza-se a casa da dezena; e
            //e) o 1º DV será 1 (um).

            int temp = (n15 * 2) + (n14 * 3) + (n13 * 4) + (n12 * 5) + (n11 * 6) + (n10 * 7) + (n9 * 8) + (n8 * 9) + (n7 * 10) + (n6 * 11) + (n5 * 12) + (n4 * 13) + (n3 * 14) + (n2 * 15) + (n1 * 16);
            temp = (temp % 11);
            temp = 11 - temp;

            int dv1 = (temp > 9) ? (temp % 10) : temp; //despreza-se a casa da dezena pegando somente a unidade.
            

            //a)(lx2)+(0x3)+(0x4)+(0x5)+(2x6)+(7x7)+(8x8)+(3x9)+(0x10)+(0x11)+(0x12)+(1x13)+(4x14)+(0x15)+(5x16)+(3x17);
            //b) 2+0+0+0+12+49+64+27+0+0+0+13+56+0+80+51= 354
            //c) 354÷11 = 32; RESTO = 2;
            //d) 11-2= 9; e
            //e) O 2º DV será 9 (nove).

            temp = (dv1 * 2) + (n15 * 3) + (n14 * 4) + (n13 * 5) + (n12 * 6) + (n11 * 7) + (n10 * 8) + (n9 * 9) + (n8 * 10) + (n7 * 11) + (n6 * 12) + (n5 * 13) + (n4 * 14) + (n3 * 15) + (n2 * 16) + (n1 * 17);
            temp = (temp % 11);
            temp = 11 - temp;

            int dv2 = (temp > 9) ? (temp % 10) : temp; //despreza-se a casa da dezena pegando somente a unidade.

            txtGerar.Text = n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + "." + 
                            n6.ToString() + n7.ToString() + n8.ToString() + n9.ToString() + n10.ToString() + n11.ToString() + "/" + 
                            n12.ToString() + n13.ToString() + n14.ToString() + n15.ToString() + "-" + dv1.ToString() + dv2.ToString(); 
        }
    }
}
