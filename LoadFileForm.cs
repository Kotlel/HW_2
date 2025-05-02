using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WinForms_homework2.Classes;

namespace WinForms_homework2
{
    public partial class LoadFileForm : Form
    {
        public LoadFileForm()
        {
            InitializeComponent();
        }
        private void XML_btn_Click(object sender, EventArgs e)
        {
            LoadFile(".xml");
        }

        private void JSON_btn_Click(object sender, EventArgs e)
        {
            LoadFile(".json");
        }
        private void LoadFile(string fileExtension)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = fileExtension == ".xml" ? "XML files (*.xml)|*.xml" : "JSON files (*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string content = File.ReadAllText(ofd.FileName);
                    RootObject data = null;

                    if (fileExtension == ".json")
                    {
                        try
                        {
                            data = JsonConvert.DeserializeObject<RootObject>(content);
                        }
                        catch (JsonReaderException ex)
                        {
                            MessageBox.Show($"Ошибка при десериализации JSON: {ex.Message}");
                            return;
                        }
                    }
                    else
                    {
                        var serializer = new XmlSerializer(typeof(RootData));
                        using (var reader = new StringReader(content))
                        {
                            var root = (RootData)serializer.Deserialize(reader);
                            data = new RootObject { root = root };
                        }
                    }

                    if (data != null)
                    {
                        foreach (var camp in data.root.camps)
                            DatabaseManager.SaveCamp(camp);

                        foreach (var refugee in data.root.refugees)
                            DatabaseManager.SaveRefugee(refugee);

                        foreach (var employee in data.root.staff)
                            DatabaseManager.SaveEmployee(employee);
                    }
                }
            }

            MessageBox.Show("Данные успешно загружены в БД");
            this.Close();
        }
    }
}
