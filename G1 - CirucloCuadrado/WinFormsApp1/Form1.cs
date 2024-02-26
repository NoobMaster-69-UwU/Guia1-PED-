namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseCLick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void paint1_MouseClick(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            //generamos el color al azar de entre la lista
            List<Color> colores = new List<Color> { Color.Green, Color.Blue, Color.Red, Color.Beige, Color.DarkBlue, Color.DeepPink, Color.Indigo};
            Random colorRnd = new Random();

            int iColor = colorRnd.Next(0, colores.Count);
            Color colorRandom = colores[iColor];

            //tamano dimension random

            int dimensionRnd = colorRnd.Next(50, 200);
            //se crea circulo
            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(colorRandom);
                g.DrawEllipse(lapiz, x - 50, y - 50, dimensionRnd, dimensionRnd);
                g.FillEllipse(sb, x - 50, y - 50, dimensionRnd, dimensionRnd);

            }
            //se crea rectangulo
            if(listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(colorRandom);
                g.DrawRectangle(lapiz, x - 50, y - 50, dimensionRnd, dimensionRnd);
                g.FillRectangle(sb, x - 50, y - 50, dimensionRnd, dimensionRnd);
            }
        }
    }
}
