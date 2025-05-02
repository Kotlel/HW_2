using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.Initialize();
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            var loadForm = new LoadFileForm();
            loadForm.ShowDialog();
            UpdateItemNames();
        }
        private void UpdateItemNames()
        {
            Elements_cb.Items.Clear();

            foreach (var name in DatabaseManager.GetCampNames())
                Elements_cb.Items.Add(name);

            foreach (var name in DatabaseManager.GetRefugeeNames())
                Elements_cb.Items.Add(name);

            foreach (var name in DatabaseManager.GetEmployeeNames())
                Elements_cb.Items.Add(name);
        }
        private void Elements_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Elements_cb.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItem)) return;

            Elements_tb.Clear();

            if (selectedItem.StartsWith("Camp_"))
            {
                var camp = DatabaseManager.GetCampByName(selectedItem);
                if (camp != null)
                {
                    Elements_tb.Text = $"ТИП: Лагерь\n" +
                                          $"ID: {camp.Id}\n" +
                                          $"Название: {camp.Name}\n" +
                                          $"Страна: {camp.Location.Country}\n" +
                                          $"Город: {camp.Location.City}\n" +
                                          $"Вместимость: {camp.Capacity}\n" +
                                          $"Основан: {camp.EstablishedYear}";
                }
            }
            else if (selectedItem.StartsWith("Refugee_"))
            {
                var refugee = DatabaseManager.GetRefugeeByName(selectedItem);
                if (refugee != null)
                {
                    Elements_tb.Text = $"ТИП: Беженец\n" +
                                          $"ID: {refugee.Id}\n" +
                                          $"Имя: {refugee.Name}\n" +
                                          $"Возраст: {refugee.Age}\n" +
                                          $"Страна: {refugee.Nationality}\n" +
                                          $"Документ: {refugee.Documents.DocumentType} ({refugee.Documents.DocumentNumber})\n" +
                                          $"Группа крови: {refugee.HealthInfo.BloodGroup}\n" +
                                          $"Хронические болезни: {refugee.HealthInfo.ChronicDiseases}";
                }
            }
            else if (selectedItem.StartsWith("Staff_"))
            {
                var employee = DatabaseManager.GetEmployeeByName(selectedItem);
                if (employee != null)
                {
                    Elements_tb.Text = $"ТИП: Сотрудник\n" +
                                          $"ID: {employee.Id}\n" +
                                          $"Имя: {employee.Name}\n" +
                                          $"Должность: {employee.Position}\n" +
                                          $"Опыт: {employee.ExperienceYears} лет\n" +
                                          $"Навыки: {string.Join(", ", employee.Skills)}\n" +
                                          $"Дата рождения: {employee.PersonalInfo.BirthDate}\n" +
                                          $"Гражданство: {employee.PersonalInfo.Citizenship}";
                }
            }
        }
    }
}
