using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App
{
    class FileBrowser
    {
        public static FileInfo GetFileByBrowser(string initDirPath, string contentName, string extension = "txt")
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = $"Sélectionnez votre fichier contenant {contentName}.";
            op.InitialDirectory = initDirPath;
            op.Multiselect = false;
            op.Filter = $"Question File|*.{extension}";
            if (op.ShowDialog() == DialogResult.OK)
            {
                return new FileInfo(op.FileName);
            }
            return null;

        }
    }
}
