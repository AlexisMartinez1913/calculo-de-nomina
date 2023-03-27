using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina_Objectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                valornomina nomina = new valornomina();
                nomina.nombre = textBox1.Text;
                nomina.año_ingreso = int.Parse(textBox2.Text);
                nomina.cedula = int.Parse(textBox3.Text);
                nomina.horas_trabajadas = int.Parse(textBox4.Text);

                if (radioButton1.Checked || radioButton2.Checked == true)
                {
                    if (nomina.horas_trabajadas > 48)
                    {

                        nomina.horas_extras = nomina.horas_trabajadas - 48;
                        nomina.calcular_Extras(nomina.horas_extras);
                        textBox6.Text = nomina.valor_extras.ToString();

                    }
                    nomina.valor_base = 8000;
                    nomina.calcular_salario(nomina.valor_base, nomina.horas_trabajadas);
                    textBox5.Text = nomina.salario.ToString();

                    nomina.calcular_alimentos(nomina.salario);
                    textBox7.Text = nomina.subsidio_alimentacion.ToString();

                    nomina.calcular_transporte(nomina.salario);
                    textBox8.Text = nomina.subsidio_transporte.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    nomina.valor_base = 10000;
                    nomina.calcular_salario(nomina.valor_base, nomina.horas_trabajadas);
                    textBox5.Text = nomina.salario.ToString();
                }
                if (radioButton4.Checked == true)
                {
                    nomina.valor_base = 30000;
                    nomina.calcular_salario(nomina.valor_base, nomina.horas_trabajadas);
                    textBox5.Text = nomina.salario.ToString();
                }

                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked == true)
                {
                    nomina.años_en_empresa(nomina.año_ingreso);
                    if (nomina.años_empresa > 5 && nomina.años_empresa < 10)
                    {
                        nomina.calcular_bonificacion1(nomina.salario);
                        textBox9.Text = nomina.bonificacion.ToString();
                    }
                    else if (nomina.años_empresa > 10)
                    {
                        nomina.calcular_bonificacion2(nomina.salario);
                        textBox9.Text = nomina.bonificacion.ToString();

                    }
                }
                nomina.totalgeneral(nomina.salario, nomina.valor_extras, nomina.subsidio_alimentacion, nomina.subsidio_transporte, nomina.bonificacion);
                textBox10.Text = nomina.total.ToString();


            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
            


           





        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
