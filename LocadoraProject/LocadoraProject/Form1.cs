using System;
using System.Windows.Forms;

namespace LocadoraProject
{
    public partial class Form1 : Form
    {
        public static string name_box, composer_box;
        public Form1()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {

        }

        private void atualizar(object sender, EventArgs e)
        {//transformar listview com um construtor separado para popular o list view com o listAlbum.
            foreach (var item in Lista.ListAlbum())
            {

                var row = new string[] { item._name, item._composer };
                var lvi = new ListViewItem (row);
                listView1.Items.Add(lvi);
                //listView1.Items.Add(item._composer);
               
            }

        }

        private void Add(object sender, EventArgs e)
        {
            name_box = maskedTextBox1.Text;
            composer_box = maskedTextBox2.Text;
            
        }
    }
}
