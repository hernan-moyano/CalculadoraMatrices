using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatrices
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        Class_Operaciones obj_Matriz = new Class_Operaciones();
        private void btnInsertA_Click(object sender, EventArgs e)
        {
            obj_Matriz.InsertarA(txtFilaA, txtColA);
        }

        private void btnInsertB_Click(object sender, EventArgs e)
        {
            obj_Matriz.InsertarB(txtFilaB, txtColB);
        }

        private void btnMosA_Click(object sender, EventArgs e)
        {
            obj_Matriz.MostrarA(dgvA);
        }

        private void btnMosB_Click(object sender, EventArgs e)
        {
            obj_Matriz.MostrarB(dgvB);

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            obj_Matriz.Sumar(dgvC);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            obj_Matriz.Restar(dgvC);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            obj_Matriz.Multiplicar(dgvC);
        }

        private void btnTrasA_Click(object sender, EventArgs e)
        {
            obj_Matriz.TrasponerA(txtFilaA, txtColA, dgvC);
        }

        private void btnTrasB_Click(object sender, EventArgs e)
        {
            obj_Matriz.TrasponerB(dgvC);
        }

        private void btnEsXa_Click(object sender, EventArgs e)
        {
            try
            {
                obj_Matriz.EscPorMatrA(dgvC, txtEscalar);
            }
            catch (Exception)
            {
                MessageBox.Show("indique el valor del escalar");
            }
            
        }

        private void btnEsXb_Click(object sender, EventArgs e)
        {
            try
            {
                obj_Matriz.EscPorMatrB(dgvC, txtEscalar);                
            }
            catch (Exception)
            {
                MessageBox.Show("indique el valor del escalar");
            }
        }

    }
}
