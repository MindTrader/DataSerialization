using System;
using System.IO;
using System.Windows.Forms;

namespace DataSerialization
{
    public partial class fMain : Form
    {
        string XmlPath { get; set; }

        public fMain()
        {
            InitializeComponent();
        }

        private void btnSelectXml_Click(object sender, EventArgs e)
        {
            //Выбор файла XML, проверка на расширение
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialog.FileName) != ".xml")
                    {
                        fMsg mes = new fMsg();

                        if (mes.ShowDialog() != DialogResult.Yes)
                            return;
                    }
                    XmlPath = fileDialog.FileName;
                    tbXmlPath.Text = XmlPath;
                    btnSerialize.Enabled = true;
                }
            }
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                //Запуск сериализации и вывод результата
                string jsonStr = Serializer.Serialize(XmlPath);

                MessageBox.Show("Сериализация выполнена успешна!\n\nСохраните результат");

                //Сохранение результатов сериализации
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON File|*.json";
                saveFileDialog.Title = "Save the serialization's result";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                    File.WriteAllText(saveFileDialog.FileName, jsonStr);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка сериалиазации!\n\n" + exc.Message);
            }

            XmlPath = "";
            tbXmlPath.Text = "Выберите .xml файл для дальнейшей сериализации";
            btnSerialize.Enabled = false;
        }
    }
}
