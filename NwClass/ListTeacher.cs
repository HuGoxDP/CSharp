using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
 using Xamarin.Forms.PlatformConfiguration;
using Windows.Storage.Pickers;
using Windows.Storage;

namespace NwClass
{
    internal class ListTeacher
    {
        public ListTeacher()
        {
			List = new List<Teacher>();
        }

        public void Add(Teacher human)
        {
			List.Add(human);
        }
        public void Show()
        {
            for (int n = 0; n < List.Count; n++)
				List[n].PrintInfo();
        }
		public List<Teacher> List { get; set; }
		public void Save_json()
        {
			const string fileName = "Teachers.json";
            string jsonString = JsonSerializer.Serialize(this.List);
            File.WriteAllText(fileName, jsonString);
        }

        public string T_Txt()
        {
            string res = "";
            for (int n = 0; n < List.Count; n++)
            {
                res += List[n].ToStr();
                res += "\n \n";
            }

            return res;
        }
        public void TextsWriter(string url)
        {
            StreamWriter sw = new StreamWriter(url);
            sw.WriteLine(T_Txt());
            sw.Close();
        }
        private async Task UrlSelecterAsync()
        {
            var folderPicker = new FolderPicker();
            folderPicker.SuggestedStartLocation = PickerLocationId.ComputerFolder;
            folderPicker.FileTypeFilter.Add("*");
            StorageFolder pickedFolder = await folderPicker.PickSingleFolderAsync();
            if (pickedFolder != null)
            {
                // Folder was picked you can now use it
                var files = await pickedFolder.GetFilesAsync();
            }
            else
            {
                // No folder was picked or the dialog was cancelled.
            }
        }
    }
}
