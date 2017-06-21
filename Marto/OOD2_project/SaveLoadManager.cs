using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD2_project
{
    class SaveLoadManager
    {

        private static string savedFile;
        public static void OpenFile(ref Project project)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;

                openFileDialog.Filter = "SimulatorExtension files (*.simex)|*.simex";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;


                fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                Project loadproject = (Project)(bf.Deserialize(fs));
                project = loadproject;
                project.listComponents = loadproject.listComponents;
                project.listLinks = loadproject.listLinks;
              
            }
        }
        public static bool SaveAs(Project flow)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.FileName = "Simulation1";
            dialog.Filter = "SimulatorExtension files (*.simex)|*.simex";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;

                fs = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                savedFile = dialog.FileName;
                bf.Serialize(fs, flow);
                fs.Close();
                return true;

            }
            return false;

        }
    }
}
