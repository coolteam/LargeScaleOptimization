using System.Windows.Forms;

namespace LargeScaleOptimization
{
    public class UiHelper
    {
        public static void SetGridSettings(DataGridView inputAGrid, DataGridView inputCGrid, int n, int m)
        {
            inputCGrid.RowCount = 1;
            inputCGrid.ColumnCount = 2 * n + 2;
            inputCGrid.Columns[2 * n].ReadOnly = true;
            inputCGrid.Columns[2 * n + 1].ReadOnly = true;
            inputCGrid.Columns[2 * n].DefaultCellStyle.BackColor = System.Drawing.Color.PapayaWhip;
            inputCGrid.Columns[2 * n + 1].DefaultCellStyle.BackColor = System.Drawing.Color.NavajoWhite;
            inputCGrid[2 * n, 0].Value = "-->";
            inputCGrid[2 * n + 1, 0].Value = "min";

            inputAGrid.ColumnCount = 2 * n + 2;
            inputAGrid.RowCount = m;
            for (var i = 0; i < 2 * n; i += 2)
            {
                inputCGrid[i, 0].Value = 0;
                inputCGrid[i + 1, 0].Value = "c" + (i / 2 + 1);
                inputCGrid.Columns[i].ReadOnly = false;
                inputCGrid.Columns[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                inputCGrid.Columns[i + 1].ReadOnly = true;
                inputCGrid.Columns[i + 1].DefaultCellStyle.BackColor = System.Drawing.Color.GhostWhite;

                inputAGrid.Columns[i].ReadOnly = false;
                inputAGrid.Columns[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                inputAGrid.Columns[i + 1].ReadOnly = true;
                inputAGrid.Columns[i + 1].DefaultCellStyle.BackColor = System.Drawing.Color.GhostWhite;
                for (var j = 0; j < m; ++j)
                {
                    inputAGrid[i, j].Value = 0;
                    inputAGrid[i + 1, j].Value = "x" + (i / 2 + 1);
                }
            }


            inputAGrid.Columns[2 * n].ReadOnly = true;
            inputAGrid.Columns[2 * n].DefaultCellStyle.BackColor = System.Drawing.Color.PapayaWhip;
            inputAGrid.Columns[2 * n + 1].ReadOnly = false;
            inputAGrid.Columns[2 * n + 1].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            for (var j = 0; j < m; ++j)
            {
                inputAGrid[2 * n, j].Value = "<=";
                inputAGrid[2 * n + 1, j].Value = 0;
            }
        }
    }
}
