using System;
using System.IO;

namespace FileTransfer
{
    public class TransferFileHelper
    {
        public void CopyFile(string sourcePath, string targetPath)
        {
            if (!File.Exists(sourcePath))
                throw new Exception("Arquivo não encontrado");

            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            var fileName = Path.GetFileName(sourcePath);
            var destFile = Path.Combine(targetPath, fileName);
            File.Copy(sourcePath, destFile, true);
        }

        public void CopyAll(string sourcePath, string targetPath)
        {
            try
            {
                if (!Directory.Exists(sourcePath))
                    throw new Exception("Diretório de origem não encontrado");

                if (!Directory.Exists(targetPath))
                    throw new Exception("Diretório de destino não encontrado");

                var files = Directory.GetFiles(sourcePath);

                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file);
                    var destFile = Path.Combine(targetPath, fileName);
                    File.Copy(sourcePath, destFile);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception($"O acesso ao caminho [{sourcePath}] foi negado");
            }
        }
    }
}
