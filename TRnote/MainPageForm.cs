using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRnote
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void ajouterUneNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addNote = new addNoteForm();
            addNote.FormClosing += addNote_FormClosed;
            this.Enabled = false;
            addNote.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void addNote_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addNote = new addNoteForm();
            addNote.FormClosing += addNote_FormClosed;
            this.Enabled = false;
            addNote.Show();
        }
    }
}
