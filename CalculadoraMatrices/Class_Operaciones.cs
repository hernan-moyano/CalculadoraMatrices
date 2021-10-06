using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CalculadoraMatrices
{
    class Class_Operaciones
    {
        #region atributos

        float[,] matrizA = new float[100,100];
        float[,] matrizB = new float[100,100];
        float[,] operacionResult = new float[100, 100];
        float escalar;
        int fila1, columna1, fila2, columna2;
        
        #endregion

        #region Metodos
        //sector matriz A

        public void InsertarA(TextBox txtFilaA, TextBox txtColA)
        {
            if(txtFilaA.Text =="" || txtColA.Text == "")
            {
                MessageBox.Show("Cargue los datos");
            }
            else
            {
                try
                {
                    fila1 = int.Parse(txtFilaA.Text);
                    columna1 = int.Parse(txtColA.Text);
                    for (int i = 0; i < fila1; i++)
                    {
                        for (int j = 0; j < columna1; j++)
                        {
                         matrizA[i, j] = float.Parse(Interaction.InputBox("Datos en fila i", "Datos en columna j", "", fila1, columna1));
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        public void MostrarA(DataGridView dgvA)
        {
            try
            {
                dgvA.RowCount = fila1;
                dgvA.ColumnCount = columna1;

                for (int i = 0; i < fila1; i++)
                {
                    for (int j = 0; j < columna1; j++)
                    {
                        dgvA.Rows[i].Cells[j].Value = matrizA[i, j].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public void TrasponerA(TextBox txtFilaA, TextBox txtColA, DataGridView dgvC)
        {
            /* 
            dgvC.RowCount = fila1;
            dgvC.ColumnCount = columna1;
             */
            try
            {
                dgvC.RowCount = columna1;
                dgvC.ColumnCount = fila1;

                for (int i = 0; i < columna1; i++)
                {
                    for (int j = 0; j < fila1; j++)
                    {
                        dgvC.Rows[i].Cells[j].Value = matrizA[j, i].ToString();
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }


        }
        
        public void EscPorMatrA(DataGridView escalarXA, TextBox txtEscalar)
        {
            try
            {
                escalar = float.Parse(txtEscalar.Text);
                escalarXA.RowCount = fila1;
                escalarXA.ColumnCount = columna1;
                for (int i = 0; i < fila1; i++)
                {
                    for (int j = 0; j < columna1; j++)
                    {
                        operacionResult[i, j] = matrizA[i, j] * escalar;
                        escalarXA.Rows[i].Cells[j].Value = operacionResult[i, j].ToString();
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }


        }

        //sector matriz B

        public void InsertarB(TextBox txtFilaB, TextBox txtColB)
        {
            if (txtFilaB.Text == "" || txtColB.Text == "")
            {
                MessageBox.Show("Cargue los datos");
            }
            else
            {
                fila2 = int.Parse(txtFilaB.Text);
                columna2 = int.Parse(txtColB.Text);
                for (int i = 0; i < fila2; i++)
                {
                    for (int j = 0; j < columna2; j++)
                    {
                        matrizB[i, j] = float.Parse(Interaction.InputBox("Datos en fila ", "Datos en columna ", "", fila2, columna2));
                    }
                }
            }
        }

        public void MostrarB(DataGridView dgvB)
        {
            dgvB.RowCount = fila2;
            dgvB.ColumnCount = columna2;

            for (int i = 0; i < fila2; i++)
            {
                for (int j = 0; j < columna2; j++)
                {
                    dgvB.Rows[i].Cells[j].Value = matrizB[i, j].ToString();
                }
            }
        }

        public void TrasponerB(DataGridView dgvC)
        {
            //fila
            dgvC.RowCount = columna2;
            //columna
            dgvC.ColumnCount = fila2;

            for (int i = 0; i < columna2; i++)
            {
                for (int j = 0; j < fila2; j++)
                {
                    dgvC.Rows[i].Cells[j].Value = matrizB[j, i].ToString();
                }
            }
        }

        public void EscPorMatrB(DataGridView escalarXB, TextBox txtEscalar)
        {
            try
            {
                escalar = float.Parse(txtEscalar.Text);
                escalarXB.RowCount = fila2;
                escalarXB.ColumnCount = columna2;
                for (int i = 0; i < fila2; i++)
                {
                    for (int j = 0; j < columna2; j++)
                    {
                        operacionResult[i, j] = matrizB[i, j] * escalar;
                        escalarXB.Rows[i].Cells[j].Value = operacionResult[i, j].ToString();
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

        }

        //sector operaciones comunes

        public void Sumar(DataGridView suma)
        {
            if (fila1 == fila2 && columna1 == columna2)
            {
                suma.RowCount = fila1;
                suma.ColumnCount = columna2;
                for (int i = 0; i < fila1; i++)
                {
                    for (int j = 0; j < columna2; j++)
                    {
                        operacionResult[i, j] = matrizA[i, j] + matrizB[i, j];
                        suma.Rows[i].Cells[j].Value = operacionResult[i, j].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Las matices deben ser de igual dimensión");
            }

        }       

        public void Restar(DataGridView resta)
        {
            if (fila1 == fila2 && columna1 == columna2)
            {
                resta.RowCount = fila1;
                resta.ColumnCount = columna2;
                for (int i = 0; i < fila1; i++)
                {
                    for (int j = 0; j < columna2; j++)
                    {
                        operacionResult[i, j] = matrizA[i, j] - matrizB[i, j];
                        resta.Rows[i].Cells[j].Value = operacionResult[i, j].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Las matices deben ser de igual dimensión");
            }

        }

        //filas de la primera matriz se multiplican por columnas de la segunda matriz.
        public void Multiplicar(DataGridView multiplo)
        {
            if ( columna1 == fila2)
            {
                //creacion de la matriz resultado
                multiplo.RowCount = fila1;
                multiplo.ColumnCount = columna2;
                //recorre fila de matriz A
                for (int i = 0; i < fila1; i++)
                {
                    //recorre columna de matriz B
                    for (int j = 0; j < columna2; j++)
                    {
                        //inicializa la operacion de resultado
                        operacionResult[i, j] = 0;
                        //recorre la matriz resultado para comenzar a llenarla
                        for (int z = 0; z < columna1; z++)
                        {
                            operacionResult[i, j] = (matrizA[i, z] * matrizB[z, j]+ operacionResult[i, j]);
                            multiplo.Rows[i].Cells[j].Value = operacionResult[i, j].ToString();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("La cantidad de columnas de la  matriz A debe ser igual a la cantidad de filas de la Matriz B");
            }

        }

        #endregion
    }
}
