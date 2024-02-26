namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 459);
            panel1.TabIndex = 0;
            panel1.Paint += paint1_MouseClick;
            panel1.MouseClick += panel1_MouseCLick;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Sitka Subheading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.LightSeaGreen;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Items.AddRange(new object[] { "Círculo", "Rectangulo" });
            listBox1.Location = new Point(570, 17);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 144);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(828, 483);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
    }
}
