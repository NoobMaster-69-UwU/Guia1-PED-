namespace CreacionLineas
{
    public partial class Form1 : Form
    {
        Graphics area;
        
        public Form1()
        {
            InitializeComponent();
            area = areaDibujo.CreateGraphics();
        }

        private void botonDibujar(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);

            //los colores a escoger xdd

            switch(cmbcolor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }
            //pa que ingresen cant lineas y el espaciado
            int iteraciones = int.Parse(textcantidad.Text);
            int espacio = int.Parse(textespaciado.Text);

            area.Clear(Color.White);
            //ponemos pa que ingresen punto inicio y fin
            int puntoInicio = int.Parse(textInicio.Text);
            int puntoFin = int.Parse(textFin.Text);

            //creamos lineas
            for(int i = 0; i < iteraciones; i++) 
            { 
                area.DrawLine(lapicero, 20, puntoInicio + (espacio *i), 300, puntoFin + (espacio *i));   
            }
        }
    }
}
