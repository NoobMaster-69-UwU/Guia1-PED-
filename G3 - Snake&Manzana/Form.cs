using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<PictureBox> cuerpoSnake = new List<PictureBox>();
        int largoSnake = 26, tiempo = 10; 
        PictureBox Comida = new PictureBox();  
        String Direccion = "Der"; 

        public Form()
        {
            InitializeComponent();
            Start();
                
        }

        //Metodo pal juego
        public void Start() 
        { 
            timer1.Interval = 200;
            cuerpoSnake = new List<PictureBox>();
            //se crea el cuerpo con 2 piezas
            for (int i = 1; 0 <= i; i--)
            {
                CreateSnake(cuerpoSnake, this, (i * largoSnake) + 200, 200);
            }
            Manzana();
        } 
        //Metodo para la creacion del Gusano 
        public void CreateSnake(List<PictureBox> ListaPelota, System.Windows.Forms.Form formulario, int posicionX, int posicionY)
        {
            //se setea valores de serpiente
            PictureBox pb = new PictureBox();
            //poscion
            pb.Location = new Point(posicionX, posicionY);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Cuerpo");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            //Se añade mas posiciones a la serpiente
            ListaPelota.Add(pb);
            formulario.Controls.Add(pb); 
        }
        private void Manzana()
        {
            Random rnd = new Random();
            //valor radom pa donde aparecera la manzana
            int mX = rnd.Next(1, this.Width - largoSnake - 10);
            int mY = rnd.Next(1, this.Height - largoSnake - 40);
            //aqui se va a settear valores de manzana
            PictureBox pb = new PictureBox(); 
            pb.Location = new Point(mX, mY);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Manzana");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            //Creamos manzana
            Comida = pb;
            this.Controls.Add(pb);

        }
        //se obtiene tecla apretada y se le asigna valor segun la direccion
        private void Snake_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Left)
            {
                Direccion = "Izq";
            }
            else if (e.KeyCode == Keys.Right)
            {
                Direccion = "Der";
            }
            else if (e.KeyCode == Keys.Up)
            {
                Direccion = "Up";
            }
            else if (e.KeyCode == Keys.Down)
            {
                Direccion = "Down";
            }

        }

        //se reinicia 
        public void Reinicar() 
        { 

            foreach (PictureBox Serpiente in cuerpoSnake) { this.Controls.Remove(Serpiente); }
            this.Controls.Remove(Comida);
            Start();
        
        }

        //no se ocupa :D
        private void Snake_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = cuerpoSnake[0].Location.X;
            int y = cuerpoSnake[0].Location.Y;
            cuerpoSnake[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Snake" + Direccion + ".png");

            for (int i = cuerpoSnake.Count-1;i>=0;i--)
            {
                if (i == 0)  // se evalua si la pieza es la img de cabeza
                {
                    if (Direccion == "Der") x = x + largoSnake;
                    else if (Direccion == "Izq") x = x - largoSnake;
                    else if (Direccion == "Up") y = y - largoSnake;
                    else if (Direccion == "Down") y = y + largoSnake;

                    cuerpoSnake[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Snake" + Direccion);
                    cuerpoSnake[0].Location = new Point(x, y);
                }
                else 
                {
                    //efecto de Transicion, fila anterior por fila nueva
                    cuerpoSnake[i].Location = new Point((cuerpoSnake[i - 1].Location.X), (cuerpoSnake[i].Location.Y));
                    cuerpoSnake[i].Location = new Point((cuerpoSnake[i].Location.X), (cuerpoSnake[i - 1].Location.Y));
                }
            }

            //la magia pa contar manzanas
            for (int cantImg=1; cantImg < cuerpoSnake.Count; cantImg++)
                {       //vemos si choca la snake con la manzana
                    if(cuerpoSnake[cantImg].Bounds.IntersectsWith(Comida.Bounds))
                    {
                        this.Controls.Remove(Comida);
                        tiempo = Convert.ToInt32(timer1.Interval);
                        if (tiempo > 10) { timer1.Interval = tiempo - 10; }
                    // se suma puntos
                    lblScore.Text=(Convert.ToInt32(lblScore.Text) + 1).ToString();
                    //generamos nueva manzana
                        Manzana();
                    //ponemos una nueva parte del cuerpo
                        CreateSnake(cuerpoSnake, this, cuerpoSnake[cuerpoSnake.Count - 1].Location.X * largoSnake, 0);

                    }
                
                }

            //Si choca en pared se reincia xdd
            if ((cuerpoSnake[0].Location.X>= this.Width-15) || (cuerpoSnake[0].Location.Y>= this.Height-50) || (cuerpoSnake[0].Location.Y < -10) || (cuerpoSnake[0].Location.X < -30))
            {
                Reinicar();
            }

           



        }



    }
}
