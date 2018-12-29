using System;
using System.Windows.Forms;
using System.IO;

namespace Copy_Files_Structure
{
    public partial class MainFrom : Form
    {
        public static string LOADPATH;
        public static string FILETYPE = ".*";
        public static string FILTERTEXT;
        public static DateTime NULLDATE;
        public static DateTime FROMDATEMODIFY;
        public static DateTime TODATEMODIFY = new DateTime(2199, 1, 1);
        public static DateTime FROMDATECREATE;
        public static DateTime TODATECREATE = new DateTime(2199, 1, 1);
        public static string COPYPATH;
        public static bool SAVESTRUCTURE = false;

        public MainFrom()
        {
            InitializeComponent();
        }

        private void From_modify_date_pickup_ValueChanged(object sender, EventArgs e)
        {
            FROMDATEMODIFY = Convert.ToDateTime(from_modify_date_pickup.Value.ToShortDateString());
        }

        private void To_modify_date_pickup_ValueChanged(object sender, EventArgs e)
        {
            TODATEMODIFY = Convert.ToDateTime(to_modify_date_pickup.Value.ToShortDateString());
        }

        private void From_creation_date_pickup_ValueChanged(object sender, EventArgs e)
        {
            FROMDATECREATE = Convert.ToDateTime(from_creation_date_pickup.Value.ToShortDateString());
        }

        private void To_creation_date_pickup_ValueChanged(object sender, EventArgs e)
        {
            TODATECREATE = Convert.ToDateTime(to_creation_date_pickup.Value.ToShortDateString());
        }

        private void Save_structure_CheckedChanged(object sender, EventArgs e)
        {
            SAVESTRUCTURE = save_structure.Checked;
        }

        private void Select_file_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILETYPE = select_file_type.SelectedItem.ToString();
        }

        private void Load_path_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Folder selection"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LOADPATH = Get_path(ofd.FileName);
                load_path.Text = LOADPATH;
            }
        }

        private string Get_path(string str)
        {
            return str.Substring(0, Get_last_slash(str));
        }

        private int Get_last_slash(string str)
        {
            for (int i = str.Length - 1; i > 0; i--)
            {
                if (str.Substring(i, 1) == "\\") return i;
            }
            return 0;
        }

        private void Copy_path_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Folder selection"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                COPYPATH = Get_path(ofd.FileName);
                copy_path.Text = COPYPATH;
            }
        }

        private void Start_copying_Click(object sender, EventArgs e)
        {
            FILETYPE = select_file_type.Text.ToString();

            if (FILETYPE == "Select file type...") FILETYPE = ".*";

            FILTERTEXT = filter_text.Text.ToString();
            if (FILTERTEXT == "Type text...")
            {
                FILTERTEXT = "*";
            } else
            {
                FILTERTEXT = "*" + filter_text.Text.ToString() + "*";
            }

            if ((LOADPATH != null) && (COPYPATH != null)) CopyFiles();
            else MessageBox.Show("Select Load & Copy path", "Alert");
        }

        private string ShowDialogFile()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
            }

            return null;
        }

        private void CopyFiles()
        {
            var copy_files_qty = 0;
            string[] files = Directory.GetFiles(LOADPATH, FILTERTEXT + FILETYPE, SearchOption.AllDirectories);

            foreach (String path in files)
            {
                var file = new FileInfo(path);
                DateTime modify_date = file.LastWriteTimeUtc;
                DateTime create_date = file.CreationTime;

                string full_copy_path;
                string file_name = path.Substring(GetOnlyFile(path));

                if ((modify_date >= FROMDATEMODIFY && modify_date <= TODATEMODIFY) &&
                    (create_date >= FROMDATECREATE  && create_date <= TODATECREATE))
                {
                    // save structures
                    if (SAVESTRUCTURE)
                    {
                        string directory = Path.GetDirectoryName(path.Replace(LOADPATH, COPYPATH));
                        CreateDirectory(new DirectoryInfo(directory));
                        full_copy_path = COPYPATH + path.Replace(LOADPATH, "");
                    }
                    else
                    // without structure
                    {
                        full_copy_path = COPYPATH + "\\" + file_name;
                    }

                    File.Copy(path, full_copy_path, true);
                    copy_files_qty++;
                }
            }

            MessageBox.Show("Copy files: " + copy_files_qty, "Message");
        }

        private void CreateDirectory(DirectoryInfo directory)
        {
            if (!directory.Parent.Exists)
                CreateDirectory(directory.Parent);
            directory.Create();
        }

        private int GetOnlyFile(string path)
        {
            char[] charArray = path.ToCharArray();
            Array.Reverse(charArray);

            int chars = path.Length;
            foreach (char ch in charArray)
            {
                if (ch == Convert.ToChar("\\"))
                {
                    return chars;
                }
                chars--;
            }

            return chars;
        }
    }
}
