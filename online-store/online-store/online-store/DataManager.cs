using System.IO;
using System.Windows.Forms;

namespace online_store
{
    internal class DataManager
    {
        public void ExportAllData()
        {
            var dialog = new SaveFileDialog();
            dialog.Title = "Сохранить Json...";
            dialog.OverwritePrompt = true;
            dialog.CheckPathExists = true;
            dialog.Filter = "Json Files (*.JSON)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                // Убираем из имени расширение файла
                string strFilExtn = fileName.Remove(0, fileName.Length - 4);
                File.WriteAllText(fileName, strFilExtn);
                
            }
        }
        public void ImportAllData()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Json Files (*.JSON)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(dialog.FileName);
                MessageBox.Show("Данные из json файла успешно импортированы.");
            }
        }
    }
}
