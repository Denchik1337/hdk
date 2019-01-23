using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string reg(string password, string kpass)
        {
            string Password = textBox3.Text;
            int g = 0;
            if (Password != kpass)
            {
                g++;
                return "Пароли не совпадают";
            }
            if (Password.Length < 6 || Password.Length > 18)
            {
                g++;
                return "Длина символов пароля недостаточна или превышает лимит";
            }
            if (Password.Contains('0') | Password.Contains('1') | Password.Contains('2') | Password.Contains('3') | Password.Contains('4') | Password.Contains('5') | Password.Contains('6') | Password.Contains('7') | Password.Contains('8') | Password.Contains('9'))
            {

            }
            else
            {
                g++;
                return "В пароле должны присутствовать цифры";
            }
            if (Password.Contains('*') | Password.Contains('&') | Password.Contains('{') | Password.Contains('}') | Password.Contains('|') | Password.Contains('+') | Password.Contains('.'))
            {

            }
            else
            {
                g++;
                return "Отсутсвует обязательный символ из допустимого набора: * & { } | + .";
            }
            for (int i = 0; i < Password.Length - 2; i++)
            {
                if (Password[i] == Password[i + 1] && Password[i + 1] == Password[i + 2])
                {
                    g++;
                    return "Не должно присутствовать 3 повторных символов";


                }
            }
            if (g == 0)
            {
                return "Вы зарегестрированы";
            }
                else 
            { return "Вы не зареганы"; }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string Email = textBox2.Text;
            string Password = textBox3.Text;
            string kpass = textBox4.Text;
            int g = 0;
        }
    }
}