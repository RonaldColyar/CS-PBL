using Microsoft.Win32;
using System;

namespace FileSelector
{
    public class FileHandler
    {

        private  OpenFileDialog openFileDialog = new OpenFileDialog();
        public string filepath = string.Empty;
        System.Media.SoundPlayer player;

        private  void setUpFileDialog()
        {
            openFileDialog.InitialDirectory = "c:\\";
           
            openFileDialog.FilterIndex = 0;
            //maybe better false..
            openFileDialog.RestoreDirectory = true;
        }
    
        public  void SelectFileToPlay()
        {
            setUpFileDialog();
            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                player = new System.Media.SoundPlayer(openFileDialog.FileName);
                player.Play();

            }
            else {
                System.Windows.Forms.MessageBox.Show("Error Selecting Audio File!");
            
            }
            Console.WriteLine(result);
        }
    }
}