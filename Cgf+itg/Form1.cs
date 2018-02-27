using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using System.Text.RegularExpressions;

namespace Cgf_itg
{
    public partial class Form1 : Form
    {
        public OpenFileDialog openFiles;
        public string nameXX = "";
        public string archive;
        public string MyFileName;
        public ZipFile zip;
        public SaveFileDialog saveFile;
        public FolderBrowserDialog saveDialog;
        public string path = "";
        public string newFolderName = "";
        public string newFolderName1 = "";
        public string newFolderName2 = "";
        public string newFolderName3 = "";
        public string a1 = "";
        public string a2 = "";
        public string a3 = "";
        public string a4 = "";
        public int DostParsF = 0;
        public int DostParsK = 0;
        public int OprInt = 0;
        public int OneTick=0;
        public int DostParsN=0;
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
                openFiles.Title = "Выберите архив ОБД СЛП, который необходимо разархивировать";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    archive = openFiles.FileName;
                    //Linkitg.Text = archive;
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
            File.Copy(Path.Combine(newFolderName1, textBox2.Text), Path.Combine(newFolderName, textBox2.Text), true);
            
            //удаляем временную папку для архива
            DirectoryInfo source1 = new DirectoryInfo(newFolderName1);
            source1.Delete(true);
            //закрыть выбор для извлчения файлов из архива
            itg.Enabled = false;
            button2.Enabled = true;
            textBox2.Enabled = false;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFiles = new OpenFileDialog();
                openFiles.Title = "Выберите архив ОБД ШГС, который необходимо разархивировать";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    archive = openFiles.FileName;
                    //Linkcfg.Text = archive;
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
            File.Copy(Path.Combine(newFolderName2, textBox3.Text), Path.Combine(newFolderName, textBox3.Text), true);

            //удаляем временную папку для архива
            DirectoryInfo source2 = new DirectoryInfo(newFolderName2);
            source2.Delete(true);
            //закрыть выбор для извлчения файлов из архива
            button2.Enabled = false;
           // button1.Enabled = true;
            textBox3.Enabled = false;



           // button1.Enabled = false;
            //GO.Enabled = true;
            //confirm.Enabled = true;
            GO.Enabled = true;
            //textBox4.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // тут обработка и работа с файлами

            //File.Create(newFolderName + "\\"+ NameNewFile.Text);
            var encod = System.Text.Encoding.GetEncoding(866);
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(newFolderName + "\\" + NameNewFile.Text);
            textFile.Close();

            int count = System.IO.File.ReadAllLines(newFolderName +  "\\" + textBox3.Text).Length;
            int count1 = System.IO.File.ReadAllLines(newFolderName + "\\"+ textBox2.Text).Length;

            StreamReader fileIn = new StreamReader(newFolderName + "\\"+ textBox2.Text, encod);
            string line = null;

            StreamWriter fileOut = new StreamWriter(newFolderName + "\\" + NameNewFile.Text, true, encod);
            fileOut.WriteLine("/*VERPO=");
            while ((line = fileIn.ReadLine()) != "/*BDSLP")
            {
             fileOut.WriteLine(line);
            }
            fileOut.WriteLine("/*BDSLP");

            fileIn.Close();
            fileOut.Close();
            //поиск из файла Diagn.cfg  Input Period
            StreamReader fileInCfg = new StreamReader(newFolderName + "\\" + textBox3.Text, encod);
            string line1 = null;
            
            StreamWriter fileOutNew = new StreamWriter(newFolderName + "\\" + NameNewFile.Text, true, encod);

            for (int i = 0; i < count; i++)
            {
                DostParsF = 0;
                DostParsK = 0;
                OprInt = 0;

                line1 = fileInCfg.ReadLine();
          
                    string[] words = line1.Split(new Char[] { ' ','\t' });

                if (DostParsN == 2)
                {
                    DostParsN ++;
                }
                //ищем нужное слово и заменяем
                for (int k = 0; k <= words.Length - 1; k++)
                {
                    if (OneTick == 0)
                    {

                        if (words[k] == "Period" | words[k] == "Type")
                        {
                            if (k == 0)
                            {
                                DostParsN = 0;
                            }
                            else
                            {
                                DostParsN++;
                            }
                        }
                    }
                    if (words[k] == "Count" | words[k] == "Buff")
                        DostParsK ++;
                    if (words[k] == "EndSection")
                        DostParsF = 1;
                   
                    if (words[k] == "\"UINT\";")
                        OprInt = 1;

                }

                //работа с файлом Diagn.cfg
if (DostParsN==3 && DostParsK!=2 && DostParsF!=1)
{
	OneTick=1;
//выдать отпарс строку
                     string[] split = line1.Split(new Char[] { '"', '.', '.', '"', ' ', '"', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

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
                                            if (s == "UINT" && OprInt==1)
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

else
{
	if(DostParsK==2)
			{ 
				OneTick=0;
				DostParsN=0;
			}
			else
			{
				if(DostParsF ==1)
				{
					break;
					
				}
			}
}

            }

            fileInCfg.Close();
            //fileOutNew.Close();

            StreamReader fileInItg = new StreamReader(newFolderName + "\\"+ textBox2.Text, encod);
            string line2 = null;
            fileOutNew.WriteLine("/*BDSHGS");
            for (int l = 0; l <= count1; l++)
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
            File.Delete(newFolderName + "\\"+ textBox2.Text);
            File.Delete(newFolderName + "\\"+ textBox3.Text);
            //foreach (var file in Directory.GetFiles(newFolderName))
            //    if ((file != (newFolderName + "\\" + NameNewFile.Text)) | (file != (newFolderName + "\\"+ textBox4.Text)))
            //        File.Delete(file);

            // открыть место файла
            System.Diagnostics.Process.Start("explorer.exe", newFolderName );

            //закрыть обработчик
            //Close();
            groupBox2.Enabled = true;
            groupBox4.Enabled = true;

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
                DirectoryInfo drInfo3 = new DirectoryInfo(path + "\\tmp3");
                drInfo3.Create();
                newFolderName3 = drInfo3.FullName;
                DirectoryInfo drInfo = new DirectoryInfo(path+"\\tmp");
                drInfo.Create();

                //Linknew.Text = drInfo.FullName;
                newFolderName = drInfo.FullName;
            }
            button3.Enabled = false;
            
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
            DriveInfo[] allDrivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrivers)
            {
                if (d.RootDirectory.Exists)
                {
                    NameDisk.Items.Add(d.Name);
                }
                
            }
            
        }






        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFiles = new OpenFileDialog();
                openFiles.Title = "Выберите архив СЛП, который необходимо разархивировать";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    archive = openFiles.FileName;
                    //textBox1.Text = archive;
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
                    zip.ExtractAll(newFolderName3, ExtractExistingFileAction.OverwriteSilently);
                    zip = null;
                }

                MessageBox.Show("Данные успешно извлечены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при попытки сохранения архива, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //копируем в tmp файл для работы
            File.Copy(Path.Combine(newFolderName3, textBox4.Text), Path.Combine(newFolderName, textBox4.Text), true);

            //удаляем временную папку для архива
            DirectoryInfo source3 = new DirectoryInfo(newFolderName3);
            source3.Delete(true);
            //закрыть выбор для извлчения файлов из архива
            button1.Enabled = false;
            //GO.Enabled = true;
            confirm.Enabled = true;
            textBox4.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //GO.Enabled = true;
            //confirm.Enabled = false;
        }

        private void x2_CheckedChanged(object sender, EventArgs e)
        {
            ISX_X.Text = "/*VERPO=\r\n#ОБД ХОСТ=12,МАРК=ОБД1_2СЛП\r\n#АПКС НС=1,АДРЕС=12\r\n#АПКС НС=2,АДРЕС=12, АДГР={110}\r\n/*BDSLP";
            button4.Enabled = true;
            textBox5.Text = "LP002";
        }

        private void x3_CheckedChanged(object sender, EventArgs e)
        {
            ISX_X.Text = "/*VERPO=\r\n#ОБД ХОСТ=13,МАРК=ОБД1_3СЛП\r\n#АПКС НС=1,АДРЕС=13\r\n#АПКС НС=2,АДРЕС=13, АДГР={110}\r\n/*BDSLP";
            button4.Enabled = true;
            textBox5.Text = "LP003";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (x2.Checked == true || x3.Checked == false)
            {
                nameXX = "newOBD1_SLP2.itg";
                File.Delete(newFolderName + "\\" + nameXX);
            }
            else
            {
                if (x2.Checked == false || x3.Checked == true)
                {
                    nameXX = "newOBD1_SLP3.itg";
                    File.Delete(newFolderName + "\\" + nameXX);
                }
                else
                {
                    return;
                }
            }
            
            var encod = System.Text.Encoding.GetEncoding(866);

            int count = System.IO.File.ReadAllLines(newFolderName + "\\" + NameNewFile.Text).Length;

            StreamReader fileIn = new StreamReader(newFolderName + "\\" + NameNewFile.Text, encod);
            string line = null;

            StreamWriter fileOut = new StreamWriter(newFolderName + "\\" + nameXX, true, encod);
            fileOut.Write(ISX_X.Text);
            fileOut.WriteLine("\n");
            for (int l = 0; l <= count; l++)
            {
                if ((line = fileIn.ReadLine()) == "/*BDSLP")
                {
                    while ((line = fileIn.ReadLine()) != "#КОНЕЦ")
                    {
                        line = line.Replace(textBox1.Text, textBox5.Text);
                        fileOut.WriteLine(line);
                        
                    }

                }
            }
            fileOut.WriteLine("#КОНЕЦ");

            fileIn.Close();
            fileOut.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "#ОБД ХОСТ=10,МАРК=\"ОБД_1ШГС\"\r\n#АПКС НС=2,АДРЕС=10, АДГР={120}\r\n#АПКС НС=3,АДРЕС=10, АДГР={130}\r\n/*прием данных  от СЛП\r\n#БД_ВН НОМЕР=5,АБН={С:2:11}\r\n#БД_ВН НОМЕР=5,АБН={С:2:12}\r\n/*приме данных ПОЧТОВЫХ ЯЩИКОВ от СД\r\n#БД_ВН НОМЕР=1,АБН={С:3:100}\r\n";
            textBox9.Text = "GS001";
            textBox7.Text = "/*_описание блока данных ОД выдачи в СД\n /*_данные_Линейного_пункта_LP001\n#БД НОМЕР=6,ТИП=ВЫВОД,АБН={С:3:140:Г},ЦИКЛ=100, ДАННЫЕ=\n{";
            textBox11.Text = "/*_описание блока данных ОД выдачи в СД\n/*_обобщенные_данные_Перегона_PG001002\n#БД НОМЕР=7,ТИП=ВЫВОД,АБН={С:3:140:Г},ЦИКЛ=100, ДАННЫЕ=\n{";
            button5.Enabled = true;
            textBox12.Text = "/*_описание_блока_диагн_данных_от_шлюзового_процесса \r\n#ДИАГН_НРС_ВН АБН={С:3:200}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "#ОБД ХОСТ=20,МАРК=\"ОБД_2ШГС\"\r\n#АПКС НС=2,АДРЕС=20, АДГР={120}\r\n#АПКС НС=3,АДРЕС=20, АДГР={130}\r\n/*прием данных  от СЛП\r\n#БД_ВН НОМЕР=5,АБН={С:2:11}\r\n#БД_ВН НОМЕР=5,АБН={С:2:12}\r\n/*приме данных ПОЧТОВЫХ ЯЩИКОВ от СД\r\n#БД_ВН НОМЕР=1,АБН={С:3:100}\r\n";
            textBox9.Text = "GS004";
            textBox7.Text = "/*_описание блока данных ОД выдачи в СД\n /*_данные_Линейного_пункта_LP001\n#БД НОМЕР=6,ТИП=ВЫВОД,АБН={С:3:140:Г},ЦИКЛ=100, ДАННЫЕ=\n{";
            textBox11.Text = "/*_описание блока данных ОД выдачи в СД\n/*_обобщенные_данные_Перегона_PG001002\n#БД НОМЕР=7,ТИП=ВЫВОД,АБН={С:3:140:Г},ЦИКЛ=100, ДАННЫЕ=\n{";
            button5.Enabled = true;
            textBox12.Text = "/*_описание_блока_диагн_данных_от_шлюзового_процесса \r\n#ДИАГН_НРС_ВН АБН={С:3:200}";

        }





        private void button5_Click(object sender, EventArgs e)
        {
            if (y1.Checked == true || y2.Checked == false)
            {
                nameXX = "newOBD_SHGS1.itg";
                File.Delete(newFolderName + "\\" + nameXX);
            }
            else
            {

            if (y1.Checked == false || y2.Checked == true)
            {
                nameXX = "newOBD_SHGS2.itg";
                File.Delete(newFolderName + "\\" + nameXX);
            }
            else
            {
                return;
            }
            }

            var encod = System.Text.Encoding.GetEncoding(866);

            int count = System.IO.File.ReadAllLines(newFolderName + "\\" + NameNewFile.Text).Length;

            StreamReader fileIn = new StreamReader(newFolderName + "\\" + NameNewFile.Text, encod);
            string line = null;

            StreamWriter fileOut = new StreamWriter(newFolderName + "\\" + nameXX, true, encod);
            fileOut.Write(textBox6.Text);
            fileOut.WriteLine("\n");


            for (int l = 0; l <= count; l++)
            {
                if ((line = fileIn.ReadLine()) == "/*BDSLP")
                {
                    while ((line = fileIn.ReadLine()) != "/*BDSHGS")
                    {
                        line = line.Replace(textBox10.Text + textBox8.Text + ",", textBox9.Text + textBox8.Text + ",");
                        line = line.Replace(textBox10.Text + ",", textBox9.Text + textBox10.Text + ",");
                        line = line.Replace("K06_123", textBox9.Text + "K06_123");
                       fileOut.WriteLine(line);

                    }

                }
                fileOut.WriteLine("\n");
                if ((line = fileIn.ReadLine()) == "/*BD2")
                {
                    fileOut.WriteLine(textBox11.Text); 
                    while ((line = fileIn.ReadLine()) != "/*BD1")
                    {
                        line = line.Replace(textBox10.Text + textBox8.Text + ".", textBox9.Text + textBox8.Text + ".");
                        line = line.Replace(textBox10.Text + ".", textBox9.Text + textBox10.Text + ".");
                        line = line.Replace("K06_123", textBox9.Text + "K06_123");
                        fileOut.WriteLine(line);

                    }
                    fileOut.WriteLine("}");
                    fileOut.WriteLine("\n");

                    fileOut.WriteLine(textBox7.Text);
                    while ((line = fileIn.ReadLine()) != "#КОНЕЦ")
                    {
                        line = line.Replace(textBox10.Text + textBox8.Text + ".", textBox9.Text + textBox8.Text + ".");
                        line = line.Replace(textBox10.Text + ".", textBox9.Text + textBox10.Text + ".");
                        line = line.Replace("K06_123", textBox9.Text + "K06_123");
                        fileOut.WriteLine(line);

                    }
                    fileOut.WriteLine(textBox12.Text);
                    fileOut.WriteLine("\n");
                    fileOut.WriteLine("#КОНЕЦ");
                    break;
                }
          


            }
            fileIn.Close();
            fileOut.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                openFiles = new OpenFileDialog();
                openFiles.Title = "Выберите архив ОБД СЛП, который необходимо разархивировать";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    MyFileName = openFiles.FileName;
                    //Linkitg.Text = archive;
                }
                else return;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время выбора архива для разархивации, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }



        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                openFiles = new OpenFileDialog();
                openFiles.Title = "Выберите архив ОБД СЛП, который необходимо разархивировать";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    MyFileName = openFiles.FileName;
                    //Linkitg.Text = archive;
                }
                else return;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время выбора архива для разархивации, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }



        private void button8_Click(object sender, EventArgs e)
        {


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\" + Diagn20400.Text))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\" + Diagn20400.Text);
              
                //string tmp="";
                var encod = System.Text.Encoding.GetEncoding(866);
            int count = System.IO.File.ReadAllLines(MyFileName).Length;

            StreamReader fileInCfg = new StreamReader(MyFileName, encod);
            string line1 = null;

            StreamWriter fileOutNew = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\" + Diagn20400.Text, true, encod);

            for (int i = 0; i < count; i++)
            {
                DostParsF = 0;
                DostParsK = 0;
                OprInt = 0;

                line1 = fileInCfg.ReadLine();

                string[] words = line1.Split(new Char[] { ' ', '\t' });

                if (DostParsN == 2)
                {
                    DostParsN++;
                }
                //ищем нужное слово и заменяем
                for (int k = 0; k <= words.Length - 1; k++)
                {
                    if (OneTick == 0)
                    {

                        if (words[k] == "TIME.ZONE" )
                        {
                            if (k == 0)
                            {
                                DostParsN = 0;
                            }
                            else
                            {
                                DostParsN=+2;
                            }
                        }
                    }
                 //   if (words[k] == "Тип" | words[k] == "ВЫВОД")
                 //     DostParsK++;
                   if (words[k] == "ВЫВОД")
                        DostParsF = 1;

                    if (words[k] == "\"UINT\";")
                        OprInt = 1;

                }

                //работа с файлом Diagn.cfg
                if (DostParsN == 3 && DostParsK != 2 && DostParsF != 1)
                {
                    OneTick = 1;
                    //выдать отпарс строку
                    string[] split = line1.Split(new Char[] { '"', '.', '.', '"', ' ', '"', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

                    foreach (string s in split)
                    {

                        if (s.Trim() != "")
                            if (s != "Off")
                            {
                                //числа не записывать в новый файл!!!
                                bool IsDigit = s.All(char.IsDigit);

                                if (!IsDigit)
                                {

                                    j++;

                                    //if (j == 1)
                                    //{
                                        a1 = LPName.Text;
                                    //}
                                    if (j == 1)
                                    {
                                        a2 = s;
                                    }
                                    if (j == 2)
                                    {
                                        a3 = s;
                                    }
                                    if (j == 3)
                                    {
                                        if (s == "UNSIGNED_INT")
                                        {

                                            a4 = "UINT";

                                            fileOutNew.WriteLine("#ТЕХ ПРЕФИКС=" + a1 + ",\tПАРАМ=" + a2 + ",\tАТР=" + a3 + ",\tТИП=" + a4);
                                            j = 0;
                                        }
                                        else
                                        {
                                            if (s == "UNSIGNED_CHAR")
                                            {

                                                a4 = "UCHAR";
                                                fileOutNew.WriteLine("#ТЕХ ПРЕФИКС=" + a1 + ",\tПАРАМ=" + a2 + ",\tАТР=" + a3 + ",\tТИП=" + a4);
                                                j = 0;
                                            }
                                            else
                                            {

                                                a4 = "BOOL";

                                                fileOutNew.WriteLine("#ТЕХ ПРЕФИКС=" + a1 + ",\tПАРАМ=" + a2 + ",\tАТР=" + a3 + ",\tТИП=" + a4);
                                                j = 0;
                                            }
                                        }

                                    }

                                }

                            }
                    }
                }

                else
                {
                    if (DostParsK == 2)
                    {
                        OneTick = 0;
                        DostParsN = 0;
                    }
                    else
                    {
                        if (DostParsF == 1)
                        {
                            DostParsN = 0;
                            OneTick = 0;
                            break;

                        }
                    }
                }

            }

            fileInCfg.Close();
            fileOutNew.Close();
            MessageBox.Show("Готово", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }



        private void NameDisk_TextChanged(object sender, EventArgs e)
        {
            NameDir.Items.Clear();
            if (NameDisk.Text != "")
            {
               string pattern = ".*_20400.*";
               // string[] FoldersName = Directory.GetDirectories(NameDisk.Text);
                foreach (string d  in Directory.GetDirectories(NameDisk.Text))
                {
                    MatchCollection matches = Regex.Matches(d, pattern);
                    foreach (Match match in matches)
                    {
                        NameDir.Items.Add(match.Value);
                    }
                }
            }
        }



 





        private void NameDir_SelectedValueChanged_1(object sender, EventArgs e)
        {

            if (Directory.Exists(NameDir.Text + "\\KRU\\"))
            {
                string[] files = Directory.GetFiles(NameDir.Text + "\\KRU\\", "*.bd");
                if (files.Length == 0)
                {
                    StDir.ForeColor = Color.Red;
                    StDir.Text = "Error find: " + "  KRU.bd";
                    But20400.Enabled = false;
                }
                else
                {
                    StDir.ForeColor = Color.Green;
                    StDir.Text = files.First();
                    MyFileName = files.First();
                    But20400.Enabled = true;
                }
            }
            else
            {
                But20400.Enabled = false;
                StDir.ForeColor = Color.Red;
                StDir.Text = "Видимо проект не собирался. Собери пожалуйста.";
            }
               
        }
    }
}
