using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraiWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private List<TextBox> Text_Boxes = new List<TextBox>();
        private List<DateTimePicker> Dates = new List<DateTimePicker>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int db = (int)dbSzam.Value;
            for (int i = 0; i < db; i++)
            {
                TextBox tb = new TextBox();
                tb.SetBounds(10, 50 + i * 25, 200, tb.Height);
                this.Controls.Add(tb);

                DateTimePicker dtp = new DateTimePicker();
                dtp.SetBounds(230, 50 + i * 25, 75, dtp.Height);
                this.Controls.Add(dtp);

                Button b = new Button();
                b.Text = "Megjelenít";
                b.SetBounds(330, 50 + i * 25, 75, b.Height);
                this.Controls.Add(b);
                this.Text_Boxes.Add(tb);
                this.Dates.Add(dtp);
                b.MouseUp += (sender1, args) => {
                    if (args.Button == MouseButtons.Left)
                    {
                        MessageBox.Show("Tartalom: " + tb.Text + ", " + dtp.Text);
                    }
                };

                Button del = new Button();
                del.Text = "Törlés";
                del.SetBounds(430, 50 + i * 25, 75, del.Height);
                del.Click += (sender2, args2) =>
                {
                    Text_Boxes.Remove(tb);
                    this.Controls.Remove(tb);
                    this.Controls.Remove(b);
                    this.Controls.Remove(dtp);
                };
                this.Controls.Add(del);
            }
        }

        private void getAllDataOut_Click(object sender, EventArgs e)
        {
            string text = "";
                foreach (var tb in this.Text_Boxes)
                {
                    text += tb.Text + ", ";
                }
                foreach (var dtp in Dates)
                {
                    text += dtp.Text + "\n";
                }
                MessageBox.Show(text);
                File.AppendAllText("output.txt",text);
            
            
        }
    }
}
