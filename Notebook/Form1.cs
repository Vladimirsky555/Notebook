using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class Form1 : Form
    {
        Model current = null;

        public Form1()
        {
            InitializeComponent();

            if (System.IO.File.Exists("test"))
            {
                var fs = System.IO.File.OpenRead("test");
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    List<Model> m = (List<Model>)bf.Deserialize(fs);
                    foreach (var item in m)
                    {
                        lbxAll.Items.Add(item);
                    }
                } catch (Exception ex) { }
                fs.Close();
            }
        }


        private void resetForm()
        {
            tbxLabel.Clear();
            tbxText.Clear();
        }

        private void fillForm()
        {
            if (current == null)
            {
                resetForm();
            }
            else
            {
                tbxLabel.Text = current.Label;
                tbxText.Text = current.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            current = null;
            fillForm();
            panel1.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            current = null;
            fillForm();
            panel1.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxLabel.Text) ||
                string.IsNullOrWhiteSpace(tbxText.Text))
            {
                MessageBox.Show("Все поля обязательны");
            }

            if (current == null)
            {
                current = new Model();
                current.Text = tbxText.Text;
                current.Label = tbxLabel.Text;

                lbxAll.Items.Add(current);
            } else
            {
                current.Text = tbxText.Text;
                current.Label = tbxLabel.Text;

                lbxAll.Refresh();
            }

            current = null;
            fillForm();
            panel1.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbxAll.SelectedIndex != -1)
                lbxAll.Items.RemoveAt(lbxAll.SelectedIndex);
        }

        private void lbxAll_DoubleClick(object sender, EventArgs e)
        {
            current = (Model)lbxAll.SelectedItem;
            fillForm();
            panel1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var fs = System.IO.File.OpenWrite("test");

            List<Model> m = new List<Model>();
            foreach (Model i in lbxAll.Items)
            {
                m.Add(i);
            }

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m);
            fs.Close();
        }
    }
}
