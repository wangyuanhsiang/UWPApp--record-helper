using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace UWPApp__record_helper
{
    public class Class1
    {
        public async void recordhelper(string e)
        {
            FileSavePicker picker = new FileSavePicker();
            picker.FileTypeChoices.Add("file style", new string[] { ".txt" });
            picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            picker.SuggestedFileName = "test.txt";
            StorageFile file = await picker.PickSaveFileAsync();
            if (file != null)
            {
                //byte[] data = new byte[200];
                //Random rand = new Random();
                //rand.NextBytes(data);
                //await FileIO.WriteBytesAsync(file, data);

                await FileIO.WriteTextAsync(file, e);
            }
        }
    }
}
