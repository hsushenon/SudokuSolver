using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=403352&clcid=0x409

namespace SudokuSolver
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool success = ReadFromGrid();
                if (success)
                {
                    int[,] solutionArray = SudokuManager.GenerateSolution(0);
                    SetGrid(solutionArray);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private bool ReadFromGrid()
        {
            ///Row 1
            if (!SetSudoku(0, 0, txtR1C1.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 1, txtR1C2.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 2, txtR1C3.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 3, txtR1C4.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 4, txtR1C5.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 5, txtR1C6.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 6, txtR1C7.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 7, txtR1C8.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(0, 8, txtR1C9.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            ///Row 2
            if (!SetSudoku(1, 0, txtR2C1.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 1, txtR2C2.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 2, txtR2C3.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 3, txtR2C4.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 4, txtR2C5.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 5, txtR2C6.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 6, txtR2C7.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 7, txtR2C8.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(1, 8, txtR2C9.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }
            
            ///Row 3
            if (!SetSudoku(2, 0, txtR3C1.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 1, txtR3C2.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 2, txtR3C3.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 3, txtR3C4.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 4, txtR3C5.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 5, txtR3C6.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 6, txtR3C7.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 7, txtR3C8.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(2, 8, txtR3C9.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            ///Row 4
            if (!SetSudoku(3, 0, txtR4C1.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 1, txtR4C2.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 2, txtR4C3.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 3, txtR4C4.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 4, txtR4C5.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 5, txtR4C6.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 6, txtR4C7.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 7, txtR4C8.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            if (!SetSudoku(3, 8, txtR4C9.Text))
            {
                tbMessage.Text = "Incorrect entry, enter again.";
                return false;
            }

            return true;
        }

        private bool SetSudoku(int r, int c, string no)
        {
            if (no == string.Empty)
                return true;

            int number = 0;
            if (int.TryParse(no, out number))
            {
                bool result = SudokuManager.SetSudoku(r, c, number);
                return result;
            }
            return false;
        }

        private void SetGrid(int[,] solutionArray)
        {
            ///Row 1
            txtR1C1.Text = solutionArray[0, 0].ToString();
            txtR1C2.Text = solutionArray[0, 1].ToString();
            txtR1C3.Text = solutionArray[0, 2].ToString();
            txtR1C4.Text = solutionArray[0, 3].ToString();
            txtR1C5.Text = solutionArray[0, 4].ToString();
            txtR1C6.Text = solutionArray[0, 5].ToString();
            txtR1C7.Text = solutionArray[0, 6].ToString();
            txtR1C8.Text = solutionArray[0, 7].ToString();
            txtR1C9.Text = solutionArray[0, 8].ToString();

            ///Row 2
            txtR2C1.Text = solutionArray[1, 0].ToString();
            txtR2C2.Text = solutionArray[1, 1].ToString();
            txtR2C3.Text = solutionArray[1, 2].ToString();
            txtR2C4.Text = solutionArray[1, 3].ToString();
            txtR2C5.Text = solutionArray[1, 4].ToString();
            txtR2C6.Text = solutionArray[1, 5].ToString();
            txtR2C7.Text = solutionArray[1, 6].ToString();
            txtR2C8.Text = solutionArray[1, 7].ToString();
            txtR2C9.Text = solutionArray[1, 8].ToString();

            ///Row 3
            txtR3C1.Text = solutionArray[2, 0].ToString();
            txtR3C2.Text = solutionArray[2, 1].ToString();
            txtR3C3.Text = solutionArray[2, 2].ToString();
            txtR3C4.Text = solutionArray[2, 3].ToString();
            txtR3C5.Text = solutionArray[2, 4].ToString();
            txtR3C6.Text = solutionArray[2, 5].ToString();
            txtR3C7.Text = solutionArray[2, 6].ToString();
            txtR3C8.Text = solutionArray[2, 7].ToString();
            txtR3C9.Text = solutionArray[2, 8].ToString();

            ///Row 4
            txtR4C1.Text = solutionArray[3, 0].ToString();
            txtR4C2.Text = solutionArray[3, 1].ToString();
            txtR4C3.Text = solutionArray[3, 2].ToString();
            txtR4C4.Text = solutionArray[3, 3].ToString();
            txtR4C5.Text = solutionArray[3, 4].ToString();
            txtR4C6.Text = solutionArray[3, 5].ToString();
            txtR4C7.Text = solutionArray[3, 6].ToString();
            txtR4C8.Text = solutionArray[3, 7].ToString();
            txtR4C9.Text = solutionArray[3, 8].ToString();

            ///Row 5
            txtR5C1.Text = solutionArray[4, 0].ToString();
            txtR5C2.Text = solutionArray[4, 1].ToString();
            txtR5C3.Text = solutionArray[4, 2].ToString();
            txtR5C4.Text = solutionArray[4, 3].ToString();
            txtR5C5.Text = solutionArray[4, 4].ToString();
            txtR5C6.Text = solutionArray[4, 5].ToString();
            txtR5C7.Text = solutionArray[4, 6].ToString();
            txtR5C8.Text = solutionArray[4, 7].ToString();
            txtR5C9.Text = solutionArray[4, 8].ToString();

            ///Row 6
            txtR6C1.Text = solutionArray[5, 0].ToString();
            txtR6C2.Text = solutionArray[5, 1].ToString();
            txtR6C3.Text = solutionArray[5, 2].ToString();
            txtR6C4.Text = solutionArray[5, 3].ToString();
            txtR6C5.Text = solutionArray[5, 4].ToString();
            txtR6C6.Text = solutionArray[5, 5].ToString();
            txtR6C7.Text = solutionArray[5, 6].ToString();
            txtR6C8.Text = solutionArray[5, 7].ToString();
            txtR6C9.Text = solutionArray[5, 8].ToString();


            ///Row 7
            txtR7C1.Text = solutionArray[6, 0].ToString();
            txtR7C2.Text = solutionArray[6, 1].ToString();
            txtR7C3.Text = solutionArray[6, 2].ToString();
            txtR7C4.Text = solutionArray[6, 3].ToString();
            txtR7C5.Text = solutionArray[6, 4].ToString();
            txtR7C6.Text = solutionArray[6, 5].ToString();
            txtR7C7.Text = solutionArray[6, 6].ToString();
            txtR7C8.Text = solutionArray[6, 7].ToString();
            txtR7C9.Text = solutionArray[6, 8].ToString();

            ///Row 8
            txtR8C1.Text = solutionArray[7, 0].ToString();
            txtR8C2.Text = solutionArray[7, 1].ToString();
            txtR8C3.Text = solutionArray[7, 2].ToString();
            txtR8C4.Text = solutionArray[7, 3].ToString();
            txtR8C5.Text = solutionArray[7, 4].ToString();
            txtR8C6.Text = solutionArray[7, 5].ToString();
            txtR8C7.Text = solutionArray[7, 6].ToString();
            txtR8C8.Text = solutionArray[7, 7].ToString();
            txtR8C9.Text = solutionArray[7, 8].ToString();

            ///Row 9
            txtR9C1.Text = solutionArray[8, 0].ToString();
            txtR9C2.Text = solutionArray[8, 1].ToString();
            txtR9C3.Text = solutionArray[8, 2].ToString();
            txtR9C4.Text = solutionArray[8, 3].ToString();
            txtR9C5.Text = solutionArray[8, 4].ToString();
            txtR9C6.Text = solutionArray[8, 5].ToString();
            txtR9C7.Text = solutionArray[8, 6].ToString();
            txtR9C8.Text = solutionArray[8, 7].ToString();
            txtR9C9.Text = solutionArray[8, 8].ToString();
        }
    }
}
