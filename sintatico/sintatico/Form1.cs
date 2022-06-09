using sintatico.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sintatico
{
    public partial class Form1 : Form
    {
        String ruta;
        List<Token> tokens;
        Analisis analizador;
      
        List<ErroresSintacticos> erroresSintacticos;
        List<ErroresLexicos> erroresLexicos;
      
        List<PictureBox> lienzo;
        List<TabPage> seccion;
        Boolean errores;

        public Form1()
        {
            InitializeComponent();
            ruta = "";

            analizador = new Analisis();
           
            erroresSintacticos = new List<ErroresSintacticos>();
            
            tokens = new List<Token>();

            lienzo = new List<PictureBox>();
            seccion = new List<TabPage>();

            errores = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            analizador = new Analisis();
            tokens = new List<Token>();
            erroresLexicos = new List<ErroresLexicos>();
            erroresSintacticos = new List<ErroresSintacticos>();

            tokens = analizador.analizar(editor.Text);
            erroresLexicos = analizador.obtenerErroresLexicos();
            erroresSintacticos = analizador.obtenerErroresSintacticos();
            this.Cursor = Cursors.Default;
            Consola.Text = "Análisis completado. . .";

            if (erroresLexicos.Count == 0 && erroresSintacticos.Count == 0)
            {
                MessageBox.Show("Análisis realizado correctamente");
                errores = false;
            }
            else
            {
                if (erroresLexicos.Count > 0)
                    MessageBox.Show("¡Hay errores léxicos!");

                if (erroresSintacticos.Count > 0)
                    MessageBox.Show("¡Hay errores sintácticos!");
                errores = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            editor.Text = "";
            Consola.Text = "";
        }
    }
}
