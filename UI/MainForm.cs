using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Core;
using Core.Methods;

namespace UI
{
    public partial class MainForm : Form
    {
        Matrix matrixA;
        IMethod method;
        Logger log;
        public MainForm()
        {
            InitializeComponent();
            matrixGrid.ForeColor = Color.Black;
            resultGrid.ForeColor = Color.Black;
            vectorBGrid.ForeColor = Color.Black;
            matrixGrid.RowCount = 2;
            matrixGrid.ColumnCount = 2;
            vectorBGrid.ColumnCount = 1;
            vectorBGrid.RowCount = 2;
            resultGrid.RowCount = 2;
            resultGrid.ColumnCount = 1;
            matrixA = new Matrix(2);
            matrixA.CellChanged += MatrixA_CellChanged;
            log = new Logger();
            log.Write += Log_Write;
            log.WriteException += Log_WriteException;
            method = new successive_overrelaxation();
            method.Log = log;
        }

        private void Log_WriteException(string msg)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToString() + " " + msg);
        }

        private void Log_Write(string msg)
        {
            logBox.AppendText(msg + "\n");
            logBox.ScrollToCaret();
        }

        private void size_ValueChanged(object sender, EventArgs e)
        {
            matrixGrid.RowCount = Convert.ToInt32(size.Value);
            matrixGrid.ColumnCount = Convert.ToInt32(size.Value);
            vectorBGrid.ColumnCount = 1;
            vectorBGrid.RowCount = Convert.ToInt32(size.Value);
            resultGrid.RowCount = Convert.ToInt32(size.Value);
            resultGrid.ColumnCount = 1;
            matrixA = new Matrix(Convert.ToInt32(size.Value));
            matrixA.CellChanged += MatrixA_CellChanged;
        }

        private void MatrixA_CellChanged(int row, int column, double value)
        {
            matrixGrid[column, row].Value = value;
        }

        private void randomMatrix_Click(object sender, EventArgs e)
        {
            matrixA = Matrix.GetRandomMatrix(Convert.ToInt32(size.Value), MatrixA_CellChanged);
            matrixA.CellChanged += MatrixA_CellChanged;
        }

        private void methodSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
