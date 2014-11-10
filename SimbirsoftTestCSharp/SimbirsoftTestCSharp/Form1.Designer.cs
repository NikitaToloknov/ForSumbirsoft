namespace SimbirsoftTestCSharp
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.tb_PathFile = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.ofd_Dictionary = new System.Windows.Forms.OpenFileDialog();
            this.label_Size = new System.Windows.Forms.Label();
            this.ofd_wordBook = new System.Windows.Forms.OpenFileDialog();
            this.tb_OpenWordBook = new System.Windows.Forms.TextBox();
            this.btn_OpenWordBook = new System.Windows.Forms.Button();
            this.lb_sizeWordBook = new System.Windows.Forms.Label();
            this.lbox_WordBook = new System.Windows.Forms.ListBox();
            this.cb_bold = new System.Windows.Forms.CheckBox();
            this.cb_italic = new System.Windows.Forms.CheckBox();
            this.tb_SaveFile = new System.Windows.Forms.TextBox();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.Color.White;
            this.btn_OpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_OpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenFile.Location = new System.Drawing.Point(590, 43);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(153, 29);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Выбрать файл";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // tb_PathFile
            // 
            this.tb_PathFile.AllowDrop = true;
            this.tb_PathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PathFile.Location = new System.Drawing.Point(12, 43);
            this.tb_PathFile.Name = "tb_PathFile";
            this.tb_PathFile.Size = new System.Drawing.Size(559, 29);
            this.tb_PathFile.TabIndex = 1;
            this.tb_PathFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_PathFile_DragDrop);
            this.tb_PathFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_PathFile_DragEnter);
            this.tb_PathFile.MouseEnter += new System.EventHandler(this.tb_PathFile_MouseEnter);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(729, 6);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(20, 20);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ofd_Dictionary
            // 
            this.ofd_Dictionary.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Dictionary_FileOk);
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Size.Location = new System.Drawing.Point(12, 75);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(0, 16);
            this.label_Size.TabIndex = 4;
            // 
            // ofd_wordBook
            // 
            this.ofd_wordBook.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_wordBook_FileOk);
            // 
            // tb_OpenWordBook
            // 
            this.tb_OpenWordBook.AllowDrop = true;
            this.tb_OpenWordBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_OpenWordBook.Location = new System.Drawing.Point(12, 104);
            this.tb_OpenWordBook.Name = "tb_OpenWordBook";
            this.tb_OpenWordBook.Size = new System.Drawing.Size(559, 29);
            this.tb_OpenWordBook.TabIndex = 5;
            this.tb_OpenWordBook.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_OpenWordBook_DragDrop);
            this.tb_OpenWordBook.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_OpenWordBook_DragEnter);
            // 
            // btn_OpenWordBook
            // 
            this.btn_OpenWordBook.BackColor = System.Drawing.Color.White;
            this.btn_OpenWordBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_OpenWordBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_OpenWordBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenWordBook.Location = new System.Drawing.Point(590, 107);
            this.btn_OpenWordBook.Name = "btn_OpenWordBook";
            this.btn_OpenWordBook.Size = new System.Drawing.Size(153, 29);
            this.btn_OpenWordBook.TabIndex = 6;
            this.btn_OpenWordBook.Text = "Загрузить словарь";
            this.btn_OpenWordBook.UseVisualStyleBackColor = false;
            this.btn_OpenWordBook.Click += new System.EventHandler(this.btn_OpenWordBook_Click);
            // 
            // lb_sizeWordBook
            // 
            this.lb_sizeWordBook.AutoSize = true;
            this.lb_sizeWordBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_sizeWordBook.Location = new System.Drawing.Point(12, 136);
            this.lb_sizeWordBook.Name = "lb_sizeWordBook";
            this.lb_sizeWordBook.Size = new System.Drawing.Size(0, 16);
            this.lb_sizeWordBook.TabIndex = 7;
            // 
            // lbox_WordBook
            // 
            this.lbox_WordBook.FormattingEnabled = true;
            this.lbox_WordBook.Location = new System.Drawing.Point(12, 249);
            this.lbox_WordBook.Name = "lbox_WordBook";
            this.lbox_WordBook.Size = new System.Drawing.Size(237, 147);
            this.lbox_WordBook.TabIndex = 8;
            // 
            // cb_bold
            // 
            this.cb_bold.AutoSize = true;
            this.cb_bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_bold.Location = new System.Drawing.Point(264, 296);
            this.cb_bold.Name = "cb_bold";
            this.cb_bold.Size = new System.Drawing.Size(108, 20);
            this.cb_bold.TabIndex = 9;
            this.cb_bold.Text = "Полужирный";
            this.cb_bold.UseVisualStyleBackColor = true;
            this.cb_bold.CheckedChanged += new System.EventHandler(this.cb_bold_CheckedChanged);
            // 
            // cb_italic
            // 
            this.cb_italic.AutoSize = true;
            this.cb_italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_italic.Location = new System.Drawing.Point(264, 249);
            this.cb_italic.Name = "cb_italic";
            this.cb_italic.Size = new System.Drawing.Size(71, 20);
            this.cb_italic.TabIndex = 10;
            this.cb_italic.Text = "Курсив";
            this.cb_italic.UseVisualStyleBackColor = true;
            this.cb_italic.CheckedChanged += new System.EventHandler(this.cb_italic_CheckedChanged);
            // 
            // tb_SaveFile
            // 
            this.tb_SaveFile.AllowDrop = true;
            this.tb_SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_SaveFile.Location = new System.Drawing.Point(12, 166);
            this.tb_SaveFile.Name = "tb_SaveFile";
            this.tb_SaveFile.Size = new System.Drawing.Size(559, 29);
            this.tb_SaveFile.TabIndex = 11;
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.BackColor = System.Drawing.Color.White;
            this.btn_SaveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveFile.Location = new System.Drawing.Point(590, 166);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(153, 29);
            this.btn_SaveFile.TabIndex = 12;
            this.btn_SaveFile.Text = "Сохранить как";
            this.btn_SaveFile.UseVisualStyleBackColor = false;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(408, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 163);
            this.button1.TabIndex = 13;
            this.button1.Text = "Поехали!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.tb_SaveFile);
            this.Controls.Add(this.cb_italic);
            this.Controls.Add(this.cb_bold);
            this.Controls.Add(this.lbox_WordBook);
            this.Controls.Add(this.lb_sizeWordBook);
            this.Controls.Add(this.btn_OpenWordBook);
            this.Controls.Add(this.tb_OpenWordBook);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tb_PathFile);
            this.Controls.Add(this.btn_OpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "SinbirsoftTestCSharp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.TextBox tb_PathFile;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.OpenFileDialog ofd_Dictionary;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.OpenFileDialog ofd_wordBook;
        private System.Windows.Forms.TextBox tb_OpenWordBook;
        private System.Windows.Forms.Button btn_OpenWordBook;
        private System.Windows.Forms.Label lb_sizeWordBook;
        private System.Windows.Forms.ListBox lbox_WordBook;
        private System.Windows.Forms.CheckBox cb_bold;
        private System.Windows.Forms.CheckBox cb_italic;
        private System.Windows.Forms.TextBox tb_SaveFile;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

