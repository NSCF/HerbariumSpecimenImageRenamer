using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

namespace HerbariumSpecimenImageRenamer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.newFileNames = new List<string>();
        }

        private void openDocFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtExcelFile.Text = openFileDialog.FileName;
                btnRenameFiles.Enabled = true;
            }
        }

        private void btnRenameFiles_Click(object sender, EventArgs e)
        {
            this.wd = Path.GetDirectoryName(txtExcelFile.Text);

            this.readExcelFile();

            //check that there are not duplicate names in the Excel file
            //from https://stackoverflow.com/questions/454601/how-to-count-duplicates-in-list-with-linq
            var counts = from x in this.newFileNames
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };

            if (counts.Any(x =>x.Count > 1))
            {
                string message = "There are duplicate names in the spreadsheet. Please check and correct these as each specimen should have a unique code/number" + Environment.NewLine + Environment.NewLine;

                var duplicates = counts.Where(x => x.Count > 1);
                foreach (var duplicate in duplicates)
                {
                    message += duplicate.Value + ": " + duplicate.Count + Environment.NewLine;
                }

                MessageBox.Show(message);

                return;

            }

            this.oldFileNames = Directory.GetFiles(this.wd).ToList();

            //remove the name of the excel file
            this.oldFileNames.Remove(this.txtExcelFile.Text);

            //check if the numbers match
            if (this.newFileNames.Count != this.oldFileNames.Count)
            {
                MessageBox.Show("The number of files in the spreadsheet and in the folder do not match. Check them and correct before continuing");
                Application.Exit();
                return;
            }

            //else
            for (int i = 0; i < newFileNames.Count; i++)
            {
                
                string oldFileName = oldFileNames[i];
                string fileExt = Path.GetExtension(oldFileName);

                string newFileName = this.wd + "\\" + newFileNames[i] + fileExt;

                File.Move(oldFileName, newFileName);

            }

            MessageBox.Show("File names have been changed. It is recommended that you check the first, the middle, and the last file to make sure the changes were applied correctly");
            Application.Exit();
            return;
        }

        private void readExcelFile()
        {
            //get the distribution records
            string excelFilePath = txtExcelFile.Text;
            IWorkbook workbook;
            try
            {
                using (FileStream stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(stream);

                    ISheet sheet = workbook.GetSheetAt(0); // zero-based index of your target sheet

                    // write the rest
                    int rowIndex = 0;
                    foreach (IRow row in sheet)
                    {
                        // skip header row
                        if (rowIndex++ == 0) continue;
                        string rowFileName = row.GetCell(0).ToString().Trim(); //remove full stops if there are any

                        this.newFileNames.Add(rowFileName);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Application.Exit();
                return;
            }
        }

        string wd { get; set; }
        List<string> newFileNames { get; set; }
        List<string> oldFileNames { get; set; }
    }
}
