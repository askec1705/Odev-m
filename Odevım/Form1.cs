using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odevım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstVeri1.SelectionMode = SelectionMode.MultiSimple;
            lstVeri2.SelectionMode = SelectionMode.MultiSimple;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            int[] veriler1 = new int[5];
            veriler1[0] = 123456;
            veriler1[1] = 23456;
            veriler1[2] = 3456;
            veriler1[3] = 456;
            veriler1[4] = 56;
            for (int i = 0; i <= veriler1.Length - 1; i++)
            {
                lstVeri1.Items.Add(veriler1[i]);
            }
            int[] veriler2 = new int[5];
            veriler2[0] = 456789;
            veriler2[1] = 56789;
            veriler2[2] = 6789;
            veriler2[3] = 789;
            veriler2[4] = 89;
            for (int i = 0; i <= veriler1.Length - 1; i++)
            {
                lstVeri2.Items.Add(veriler2[i]);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = lstVeri1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstVeri2.Items.Add(lstVeri1.SelectedItems[i]);
                lstVeri1.Items.RemoveAt(lstVeri1.SelectedIndices[i]);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = lstVeri2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstVeri1.Items.Add(lstVeri2.SelectedItems[i]);
                lstVeri2.Items.RemoveAt(lstVeri2.SelectedIndices[i]);
            }
        }
    }
}
