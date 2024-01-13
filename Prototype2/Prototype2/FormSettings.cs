using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype2
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int Min = 0;
            int Max = 20;

            int[] arr = new int[5];

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }

            try
            {
                int itemFind = Convert.ToInt32(txtUserName.Text);
                int temp;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    lblRandomNum.Text = "Цифрой была: ";
                    lblRandomNum.Text += arr[i];
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[i] == itemFind)
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                if (BinarySearch(arr, 0, arr.Length - 1, itemFind) != -1)
                {
                    MessageBox.Show("Поздравляем! Вы выиграли скидку 5% на покупки. Быстрее используйте ее, пока она не истекла.", "Выигрыш", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("К сожалению, вы не выиграли скидку 5%. Вы можете попробовать еще раз.", "Проигрыш", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! Введите цифру.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int BinarySearch(int[] arr, int l, int h, int itemFind)
        {
            if (l <= h)
            {
                int mid = (l + h) / 2;
                if (arr[mid] == itemFind)
                {
                    return itemFind;
                }
                if (arr[mid] > itemFind)
                {
                    return BinarySearch(arr, 0, mid - 1, itemFind);
                }
                else
                {
                    return BinarySearch(arr, mid + 1,h, itemFind);
                }
            }
            return -1;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            FormReview newForm = new FormReview();
            newForm.Show();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            FormProfitCalc newForm = new FormProfitCalc();
            newForm.Show();
        }

        private void btnPersoInfo_Click(object sender, EventArgs e)
        {
            FormPersInfo newForm = new FormPersInfo();
            newForm.Show();
        }
    }
}
