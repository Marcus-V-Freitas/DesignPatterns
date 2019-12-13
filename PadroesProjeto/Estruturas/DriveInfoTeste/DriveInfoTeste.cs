using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.DriveInfoTeste
{
    public class DriveInfoTeste
    {
        DriveInfo[] drives = DriveInfo.GetDrives();


        public void Executar() {
            Console.WriteLine("Total " + drives.Length.ToString());
            foreach (var drive in drives)
            {
                
                if (!drive.IsReady)
                    continue;
                Console.WriteLine("-----------------------");
                Console.WriteLine("Nome "+ drive.Name);
                Console.WriteLine("Label "+drive.VolumeLabel);
                Console.WriteLine("Size " +drive.TotalSize);
                Console.WriteLine("Free Space "+ drive.TotalFreeSpace.ToString());
                Console.WriteLine("Is Ready "+drive.IsReady);
                Console.WriteLine("Format "+drive.DriveFormat.ToString());
                Console.WriteLine("Root "+drive.RootDirectory);
            }


  }

    }
}
