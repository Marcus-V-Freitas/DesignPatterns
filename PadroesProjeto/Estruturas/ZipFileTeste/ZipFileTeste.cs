using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace PadroesProjeto.Estruturas.ZipFileTeste
{
    public class ZipFileTeste
    {
        public void Executar()
        {

            string source = @"e:\Documentos\Programas uteis";
            string target = @"E:\Documentos\Arquivos";
            string filename = @"e:\Documentos\Arquivos.zip";

            ZipFile.CreateFromDirectory(source, filename);

            ZipFile.ExtractToDirectory(target, filename);

        }
    }
}
