using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualDemoOfSorting
{
    public partial class sortButton : Form
    {
        public sortButton()
        {
            InitializeComponent();
        }
        static void InsertionSort<T>(ref T[] a) where T : IComparable<T>
        {
            T key;
            for (int j = 1, i = 0; j < a.Length; j++)
            {
                key = a[j];
                for (i = j - 1; i >= 0 && a[i].CompareTo(key) > 0; i--)
                {
                    //copy element
                    a[i + 1] = a[i];
                }
                //we have found the place for key
                a[i + 1] = key;
            }
        }
        static void BubbleSort<T>(ref T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length; i++) // n
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j].CompareTo(a[j + 1]) > 0)
                    {
                        //swaping
                        T tmp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }
        static void SelectionSort<T>(ref T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i].CompareTo(a[j]) > 0)
                    {
                        //swaping
                        T tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                    }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[5];
            a[0] = int.Parse(a1.Text);
            a[1] = int.Parse(a2.Text);
            a[2] = int.Parse(a3.Text);
            a[3] = int.Parse(a4.Text);
            a[4] = int.Parse(a5.Text);
            if (selectSortBox.SelectedItem.ToString() == "Bubble Sort")
            {
                BubbleSort(ref a);
                MessageBox.Show("Bubble sorting!","Message");
            }
            else if (selectSortBox.SelectedItem.ToString() == "Insertion Sort")
            {
                InsertionSort(ref a);
                MessageBox.Show("Insertion sorting!");
            }
            else if (selectSortBox.SelectedItem.ToString() == "Selection Sort")
            {
                SelectionSort(ref a);
                MessageBox.Show("Selection sorting!");
            }
            out1.Text = a[0].ToString();
            out2.Text = a[1].ToString();
            out3.Text = a[2].ToString();
            out4.Text = a[3].ToString();
            out5.Text = a[4].ToString();
        }

        private void sortButton_Load(object sender, EventArgs e)
        {
            selectSortBox.SelectedItem = "Bubble Sort";
        }
    }
}
