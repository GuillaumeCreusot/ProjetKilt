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
        /// <summary>
        /// Permet d'ouvrir l'explorateur de fichier pour choisir un fichier
        /// </summary>
        /// <param name="initDirPath">chemin d'accées du fichier initiale</param>
        /// <param name="contentName">Nom du contenue</param>
        /// <param name="extension"></param>
        /// <returns>Info sur le fichier sélectionné</returns>
        public static FileInfo GetFileByBrowser(string initDirPath, string contentName, string extension = "txt")
        {
            // windows file explorer
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
