using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Web;

namespace SimbirsoftTestCSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Point last;
        FileInfo fileInfo;
        List<string> listWordBook;
        Html_Method htm;

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DrawLineForForm()
        {
            Pen myPen;
            myPen = new System.Drawing.Pen(Color.Red,5);
            Graphics gr = this.CreateGraphics();
           // gr.DrawLines(myPen, a);
            gr.DrawRectangle(myPen, 0, 0, this.Width-1, this.Height-1);
            myPen.Dispose();
            gr.Dispose();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            DrawLineForForm();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tb_PathFile.Text = openFileDialog1.FileName;
            fileInfo = new FileInfo(openFileDialog1.FileName);
            label_Size.Text = "Размер файла: " + fileInfo.Length / 1024 + "," + +fileInfo.Length % 1024 + " KB"; 
            DictionaryConf.Default.text = openFileDialog1.FileName;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьНовыйСловарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd_Dictionary.ShowDialog();
        }

        private void ofd_Dictionary_FileOk(object sender, CancelEventArgs e)
        {
            //DictionaryConf.Default.text = ofd_Dictionary.FileName.Split('/').Last();
            DictionaryConf.Default.wordBook = ofd_Dictionary.FileName;
        }

        private void tb_PathFile_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tb_PathFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] s= (string [])e.Data.GetData(DataFormats.FileDrop, false);

            if (s[0].Split('/').Last().Split('.').Last() == "txt")
            {
                tb_PathFile.Text = s[0];
                openFileDialog1.FileName = s[0];
                fileInfo = new FileInfo(openFileDialog1.FileName);
                label_Size.Text = "Размер файла: " + fileInfo.Length / 1024 + "," + +fileInfo.Length % 1024 + " KB";
                DictionaryConf.Default.text = openFileDialog1.FileName;
            }
            else
                MessageBox.Show("Неверный формат документа!");
        }
         
        private void tb_PathFile_DragEnter(object sender, DragEventArgs e)
        {
           if (e.Data.GetDataPresent(DataFormats.FileDrop))
             e.Effect = DragDropEffects.Copy; 
           else
             e.Effect = DragDropEffects.None;
        }

        private void tb_OpenWordBook_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (s[0].Split('/').Last().Split('.').Last() == "txt")
            {
                tb_OpenWordBook.Text = s[0];
                ofd_wordBook.FileName = s[0];
                fileInfo = new FileInfo(ofd_wordBook.FileName);
                lb_sizeWordBook.Text = "Размер файла: " + fileInfo.Length / 1024 + "," + +fileInfo.Length % 1024 + " KB";
                DictionaryConf.Default.wordBook = ofd_Dictionary.FileName;
                fillLbox();
            }
            else
                MessageBox.Show("Неверный формат документа!");
        }

        private void tb_OpenWordBook_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void btn_OpenWordBook_Click(object sender, EventArgs e)
        {
            ofd_wordBook.Filter = "(*.txt)|*.txt";
            ofd_wordBook.ShowDialog();
        }

        private void ofd_wordBook_FileOk(object sender, CancelEventArgs e)
        {
            ofd_wordBook.Filter = "(*.txt)|*.txt";
            tb_OpenWordBook.Text = ofd_wordBook.FileName;
            fileInfo = new FileInfo(ofd_wordBook.FileName);
            lb_sizeWordBook.Text = "Размер файла: " + fileInfo.Length / 1024 + "," + +fileInfo.Length % 1024 + " KB"; 
            DictionaryConf.Default.wordBook = ofd_Dictionary.FileName;
            fillLbox();
        }

        public void fillLbox()
        {
            Diction wordBook = new Diction(ofd_wordBook.FileName);
            listWordBook = new List<string>();
            listWordBook = wordBook.LoadWordBook();

            foreach (string i in listWordBook)
            {
                lbox_WordBook.Items.Add(i);
            }
        }

        private void cb_bold_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_bold.Checked == true)
            {
                cb_italic.Checked = false;
                DictionaryConf.Default.tag = "bold";
            }
        }

        private void cb_italic_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_italic.Checked == true)
            {
                cb_bold.Checked = false;
                DictionaryConf.Default.tag = "italic";
            }
        }
        public void StartReadFile()
        {
            htm = new Html_Method(DictionaryConf.Default.save);
            htm.NewHtmlDocument();
            htm.Start();
            FileStream fs;
            fs = new FileStream(DictionaryConf.Default.text, FileMode.Open);

            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (DictionaryConf.Default.tag == "bold")
                    {
                        htm.writeFile(htm.processingLine(listWordBook, line, Html_Method.Style.Bold));
                    }
                    else {
                         htm.writeFile(htm.processingLine(listWordBook, line, Html_Method.Style.Italic));
                    }
                }
            }
            htm.End();
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tb_SaveFile.Text = DictionaryConf.Default.save = saveFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartReadFile();
            MessageBox.Show("Всё готово!");
        }

    }
}
