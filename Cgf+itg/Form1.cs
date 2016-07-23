using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;


namespace Cgf_itg
{
    public partial class Form1 : Form
    {
        public OpenFileDialog openFiles;
        public string archive;
        public ZipFile zip;
        public SaveFileDialog saveFile;
        public FolderBrowserDialog saveDialog;
        public string path = "";
        public string newFolderName = "";
        public string newFolderName1 = "";
        public string newFolderName2 = "";
        public string a1 = "";
        public string a2 = "";
        public string a3 = "";
        public string a4 = "";

        public int j =0;
        public Form1()
       
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFiles = new OpenFileDialog();
                openFiles.Title = "Выберите архив, который необходимо разархивировать";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    archive = openFiles.FileName;
                    Linkitg.Text = archive;
                }
                else return;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время выбора архива для разархивации, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            try
            {

                //Создаем объект для работы с архивом
                using (zip = new ZipFile(archive, Encoding.UTF8))
                {
                    //Задаем системную директорию TEMP для временных файлов
                    zip.TempFileFolder = System.IO.Path.GetTempPath();
                    //Добавляем файл и указываем где он будет располагаться в архиве
                    zip.ExtractAll(newFolderName1, ExtractExistingFileAction.OverwriteSilently);
                    zip = null;
                }

                MessageBox.Show("Данные успешно извлечены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при попытки сохранения архива, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //копируем в tmp файл для работы
            File.Copy(Path.Combine(newFolderName1, "obd1_slp.itg"), Path.Combine(newFolderName, "obd1_slp.itg"), true);
            
            //удаляем временную папку для архива
            DirectoryInfo source1 = new DirectoryInfo(newFolderName1);
            source1.Delete(true);
            //закрыть выбор для извлчения файлов из архива
            itg.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFiles = new OpenFileDialog();
                openFiles.Title = "Выберите архив, который необходимо разархивировать";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    archive = openFiles.FileName;
                    Linkcfg.Text = archive;
                }
                else return;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время выбора архива для разархивации, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            try
            {

                //Создаем объект для работы с архивом
                using (zip = new ZipFile(archive, Encoding.UTF8))
                {
                    //Задаем системную директорию TEMP для временных файлов
                    zip.TempFileFolder = System.IO.Path.GetTempPath();
                    //Добавляем файл и указываем где он будет располагаться в архиве
                    zip.ExtractAll(newFolderName2, ExtractExistingFileAction.OverwriteSilently);
                    zip = null;
                }

                MessageBox.Show("Данные успешно извлечены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при попытки сохранения архива, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            //копируем в tmp файл для работы
            File.Copy(Path.Combine(newFolderName2, "Diagn.cfg"), Path.Combine(newFolderName, "Diagn.cfg"), true);

            //удаляем временную папку для архива
            DirectoryInfo source2 = new DirectoryInfo(newFolderName2);
            source2.Delete(true);
            //закрыть выбор для извлчения файлов из архива
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // тут обработка и работа с файлами

            //File.Create(newFolderName + "\\"+ NameNewFile.Text);
            var encod = System.Text.Encoding.GetEncoding(866);
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(newFolderName + "\\" + NameNewFile.Text);
            textFile.Close();

            int count = System.IO.File.ReadAllLines(newFolderName +  "\\Diagn.cfg").Length;
            int count1 = System.IO.File.ReadAllLines(newFolderName + "\\obd1_slp.itg").Length;

            StreamReader fileIn = new StreamReader(newFolderName + "\\obd1_slp.itg", encod);
            string line = null;

            StreamWriter fileOut = new StreamWriter(newFolderName + "\\" + NameNewFile.Text, true, encod);

            while ((line = fileIn.ReadLine()) != "/*BDSLP")
            {
             fileOut.WriteLine(line);
            }
            fileOut.WriteLine("/*BDSLP");
            
            //while ((line = fileIn.ReadLine()) == "/*BDSHGS")
            //{
            //
            //    fileOut.WriteLine(line);
            //
            //    for (int i = 0; i >= count; i++)
            //    {
            //        line = fileIn.ReadLine();
            //        fileOut.WriteLine(line);
            //    }
            //}
            fileIn.Close();
            fileOut.Close();
            //поиск из файла Diagn.cfg  Input Period
            StreamReader fileInCfg = new StreamReader(newFolderName + "\\Diagn.cfg", encod);
            string line1 = null;
            
            StreamWriter fileOutNew = new StreamWriter(newFolderName + "\\" + NameNewFile.Text, true, encod);

                for (int i = 0; i <= count; i++)
                {
                if ((line1 = fileInCfg.ReadLine()) == "	Block	[00001]	Num 5 LN 4 Version 0x0 Type Input Period 100000	{ ")
                {
                    while ((line1 = fileInCfg.ReadLine()) != "	 }  Size Block 399 Count Buff 30 Size 399;")
                    {
                        string[] split = line1.Split(new Char[] { '"', '.', '.', '"',' ', '"', ';','\t' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

                        foreach (string s in split)
                        {

                            if (s.Trim() != "")
                            if (s!="Off")
                            {
                                    //числа не записывать в новый файл!!!
                                    bool IsDigit = s.All(char.IsDigit);

                                    if (!IsDigit)
                                    {
                                   
                                            j++;
                                            
                                                if (j==1)
                                                {
                                                    a1 = s;
                                                }
                                                if (j == 2)
                                                {
                                                    a2 = s;
                                                }
                                                if (j == 3)
                                                {
                                                    a3 = s;
                                                }
                                        if (j == 4)
                                        {
                                            if (s == "UINT" && (a3 == "COUNT_ST_BKZ" | a3 == "M_NOMER" | a3 == "VP"))
                                            {
                                                a4 = "INT";

                                                fileOutNew.WriteLine("#ТЕХ ПРЕФИКС=" + a1 + ", ПАРАМ=" + a2 + ", АТР=" + a3 + ", ТИП=" + a4);
                                                j = 0;
                                            }
                                            else
                                            {
                                                if (s != "UINT")
                                                {
                                                    a4 = s;
                                                    fileOutNew.WriteLine("#ТЕХ ПРЕФИКС=" + a1 + ", ПАРАМ=" + a2 + ", АТР=" + a3 + ", ТИП=" + a4);
                                                    j = 0;
                                                }
                                                else
                                                {
                                                    a4 = "BOOL";

                                                    fileOutNew.WriteLine("#ТЕХ ПРЕФИКС=" + a1 + ", ПАРАМ=" + a2 + ", АТР=" + a3 + ", ТИП=" + a4);
                                                    j = 0;
                                                }
                                            }
                                        }

                                            

                                        
                                    }
                                    

                                }
                                
                        }
                    }
                }

            }
            fileInCfg.Close();
            //fileOutNew.Close();
            StreamReader fileInItg = new StreamReader(newFolderName + "\\obd1_slp.itg", encod);
            string line2 = null;
            for (int i = 0; i <= count1; i++)
            {
                if ((line1 = fileInItg.ReadLine()) == "/*BDSHGS")
                {
                    while ((line2 = fileInItg.ReadLine()) != " #КОНЕЦ")
                    {
                        fileOutNew.WriteLine(line2);
                    }

                }
                    }
            fileOutNew.WriteLine("#КОНЕЦ");
            fileInItg.Close();
            fileOutNew.Close();
            //удалить файлы лишние 


            // открыть место файла
            System.Diagnostics.Process.Start("explorer.exe", newFolderName );

            //закрыть обработчик
            Close();


            //         while ((line1 = fileInCfg.ReadLine()) != "Input Period")
            //         {
            //
            //         
            //         while ((line1 = fileInCfg.ReadLine()) == "Input Period")
            //         {
            //             while ((line1 = fileInCfg.ReadLine()) != "Size Block")
            //             {
            //                 string[] split = line1.Split(new Char[] {'"','.', '.', '"', '"','"'});
            //
            //                 foreach (string s in split)
            //                 {
            //
            //                     if (s.Trim() != "")
            //                         fileOutNew.WriteLine(s);
            //                 }
            //             }
            //         }
            //         }
            //




            //StreamReader fileInCfg = new StreamReader(newFolderName + "\\Diagn.cfg", encod);
            //string line1 = null;
            //
            //StreamWriter fileOutNew = new StreamWriter(newFolderName + "\\" + NameNewFile.Text, true, encod);
            //
            //while ((line = fileIn.ReadLine()) == "Input Period")
            //{
            //    while ((line = fileIn.ReadLine()) != "Size Block")
            //                    
            //    for (int i = 0; i <= line.Length; i++)
            //    {
            //            char p = line[i];
            //           
            //    }
            //    //fileOut.WriteLine(line);
            //}


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            saveDialog = new FolderBrowserDialog();
            saveDialog.Description = "Выберите папку для разархивации";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveDialog.SelectedPath;

                DirectoryInfo drInfo1 = new DirectoryInfo(path + "\\tmp1");
                drInfo1.Create();
                newFolderName1 = drInfo1.FullName;
                DirectoryInfo drInfo2 = new DirectoryInfo(path + "\\tmp2");
                drInfo2.Create();
                newFolderName2 = drInfo2.FullName;
                DirectoryInfo drInfo = new DirectoryInfo(path+"\\tmp");
                drInfo.Create();

                Linknew.Text = drInfo.FullName;
                newFolderName = drInfo.FullName;
            }
            button3.Enabled = false;
            button2.Enabled = true;
            itg.Enabled = true;
            NameNewFile.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (NameNewFile.Text == "Имя файла")
            {
                button3.Enabled = false;
            }
            else
                button3.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GO_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void GO_EnabledChanged_1(object sender, EventArgs e)
        {
        
        }


        private void GO_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
