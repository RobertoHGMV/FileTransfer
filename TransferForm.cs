using System;
using System.Windows.Forms;

namespace FileTransfer
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex);
            }
        }

        #region Copy File

        private void btnSouceFile_Click(object sender, EventArgs e)
        {
            try
            {
                GetSourceFile();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex);
            }
        }

        private void btnTargetPath_Click(object sender, EventArgs e)
        {
            try
            {
                GetTargetPath();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Copy();
                ShowMessageSuccess();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex);
            }
        }

        private void GetSourceFile()
        {
            var fileDialog = new OpenFileDialog { Multiselect = false };
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            txtSouceFile.Text = fileDialog.FileName;
        }

        private void GetTargetPath()
        {
            var folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            txtTargetPath.Text = folderDialog.SelectedPath;
        }

        private void Copy()
        {
            new TransferFileHelper().CopyFile(txtSouceFile.Text, txtTargetPath.Text);
        }

        #endregion

        #region CopyAll

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            try
            {
                GetSourceFolder();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex);
            }
        }

        private void btnDestFolder_Click(object sender, EventArgs e)
        {
            try
            {
                GetDestFolder();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex);
            }
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            try
            {
                CopyAll();
                ShowMessageSuccess();
            }
            catch (Exception ex)
            {
                ShowMessageError(ex);
            }
        }

        private void GetSourceFolder()
        {
            var folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            txtSourceFolder.Text = folderDialog.SelectedPath;
        }

        private void GetDestFolder()
        {
            var folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            txtDestFolder.Text = folderDialog.SelectedPath;
        }
        private void CopyAll()
        {
            new TransferFileHelper().CopyAll(txtSourceFolder.Text, txtDestFolder.Text);
        }

        #endregion

        #region Messages

        private void ShowMessageSuccess()
        {
            MessageBox.Show(
                "Operação realizada com sucesso",
                "Mensagem do sistemma!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowMessageError(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Mensagem do sistemma!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        #endregion
    }
}
