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

namespace PhoneBook
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
                }
                catch (Exception ex) { }
                fs.Close();
            }
        }


        private void resetForm()
        {
            tbxLabel.Clear();
            tbxText.Clear();
            tbxPhone1.Clear();
            tbxPhone2.Clear();
            tbxPhone3.Clear();
            tbxPhone4.Clear();
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
                tbxPhone1.Text = current.Phone1;
                tbxPhone2.Text = current.Phone2;
                tbxPhone3.Text = current.Phone3;
                tbxPhone4.Text = current.Phone4;
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
                current.Phone1 = tbxPhone1.Text;
                current.Phone2 = tbxPhone2.Text;
                current.Phone3 = tbxPhone3.Text;
                current.Phone4 = tbxPhone4.Text;

                lbxAll.Items.Add(current);
            }
            else
            {
                current.Text = tbxText.Text;
                current.Label = tbxLabel.Text;
                current.Phone1 = tbxPhone1.Text;
                current.Phone2 = tbxPhone2.Text;
                current.Phone3 = tbxPhone3.Text;
                current.Phone4 = tbxPhone4.Text;

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

        bool LTest(Model m)
        {
            if (m.Label == "1")
                return true;
            else
                return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var first = new List<Model>();

            foreach (Model m in lbxAll.Items)
                first.Add(m);

            {
                //Простой поиск
                var result = new List<Model>();
                foreach (var item in first)
                {
                    if (item.Label == "1")
                        result.Add(item);
                }
            }
            {
                //Более сложный поиск
                var result = new List<Model>();
                foreach (var item in first)
                {
                    if (LTest(item))
                        result.Add(item);
                }

            }

            {
                //Поиск при помощи указателя на функцию
                var result = first.Where(LTest);
            }

            {
                //Поиск при помощи лямбда функции
                var result = 
                    first.Where((Model item) => {
                        if (item.Label == "1")
                            return true;
                        else
                            return false;
                    });
            }

            {
                //Поиск при помощи лямбда функции 1
                var result =
                    first.Where((Model item) => {
                        return item.Label == "1";
                    });
            }

            {
                //Поиск при помощи лямбда функции 2
                var result =
                    first.Where((Model item) =>  item.Label == "1" );
            }

            {
                //Поиск при помощи лямбда функции 3
                var result =
                    first.Where(item => item.Label == "1");
            }
            {
                var result =
                    //Фильтрация по условию
                    first.Where(item => item.Label == "1")
                    //Сортировка
                    .OrderBy(f => f.Phone1)
                    //Обратная сортировка
                    .OrderByDescending(f => f.Phone2)
                    //Объединние наборов данных по определенному критерию
                    //.Join()
                    //Групировка по критерию (Поиск уникальных)
                    .GroupBy(f => f.Phone4);
            }


            

            if (!string.IsNullOrWhiteSpace(sName.Text))
                first = first
                    .Where(f => 
                        f.Label.Contains(sName.Text)
                        || f.Text.Contains(sName.Text))
                    .ToList();

            if (!string.IsNullOrWhiteSpace(sPhone.Text))
                first = first
                    .Where(f =>
                        f.Phone1.Contains(sPhone.Text)
                        || f.Phone2.Contains(sPhone.Text)
                        || f.Phone3.Contains(sPhone.Text)
                        || f.Phone4.Contains(sPhone.Text))
                    .ToList();

            searchAll.Items.Clear();
            foreach (var item in first)
                searchAll.Items.Add(item);
        }
    }
}
