using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOTW_File_Finder {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private Dictionary<string, string> botwItems = new Dictionary<string, string>();
        private Dictionary<string, List<string>> itemFileAssociations = new Dictionary<string, List<string>>();
        string baseGame = "";
        string update = "";
        string dlc = "";
        private List<string> files;
        private FileInfo[] currentFiles;
        private bool forceExit;
        private string currentCopyText;
        private string currentPathText;
        private bool canDoDragDrop;
        private Point startPos;
        private bool valueSetByProgram;

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (itemView.Items.Contains(searchBar.Text)) {
                int index = itemView.Items.IndexOf(searchBar.Text);
                if (index > -1) {
                    itemView.SelectedIndex = index;
                }
            } else {
                int index = GetClosestResult(itemView.Items, searchBar.Text);
                itemView.SelectedIndex = index > -1 ? index : itemView.SelectedIndex;
            }
            if (!valueSetByProgram) {
                int originalSelection = searchBar.SelectionStart;
                searchBar.Items.Clear();
                if (searchBar.Text.Length > 0) {
                    foreach (string item in itemView.Items) {
                        if (item.ToLower().Contains(searchBar.Text.ToLower())) {
                            searchBar.Items.Add(item);
                        }
                    }
                    searchBar.Focus();
                    searchBar.SelectionStart = originalSelection;
                    if (searchBar.Items.Count > 1) {
                        dropdownTimer.Stop();
                        dropdownTimer.Start();
                    }
                }
            } else {
                dropdownTimer.Stop();
                valueSetByProgram = false;
            }
        }

        private int GetClosestResult(ListBox.ObjectCollection items, string text) {
            for (int i = 0; i < items.Count; i++) {
                string stringItem = items[i] as string;
                if (stringItem.ToLower().Contains(text.ToLower())) {
                    return i;
                }
            }
            return -1;
        }

        private void Form1_Load(object sender, EventArgs e) {
            Text = "BOTW File Finder v" + Application.ProductVersion;
            // read file into a string and deserialize JSON to a type
            botwItems = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "botw_names.json")));
            baseGame = GetDirectory("baseGame.dir");
            FolderSelectDialog dialog = new FolderSelectDialog();
            if (string.IsNullOrEmpty(baseGame) || !Directory.Exists(Path.Combine(baseGame, @"content\Model"))) {
                while (true) {
                    if (MessageBox.Show("Please assign the base game folder for your BoTW dump", "BoTW File Finder") == DialogResult.OK) {
                        if (dialog.ShowDialog() == DialogResult.OK) {
                            baseGame = dialog.SelectedPath;
                            if (Directory.Exists(Path.Combine(baseGame, @"content\Model"))) {
                                SaveDirectory("baseGame.dir", baseGame);
                                break;
                            } else {
                                MessageBox.Show("Invalid directory", "BoTW File Finder");
                            }
                        } else {
                            if (MessageBox.Show("A valid game dump is required for this tool to function properly", "BoTW File Finder") == DialogResult.OK) {
                                if (MessageBox.Show("Quit program?", "BoTW File Finder", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                                    Application.Exit();
                                    forceExit = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (!forceExit) {
                update = GetDirectory("update.dir");
                if (string.IsNullOrEmpty(update) || !Directory.Exists(Path.Combine(update, @"content\Model"))) {
                    while (true) {
                        if (MessageBox.Show("Please assign the update folder for your BoTW dump", "BoTW File Finder") == DialogResult.OK) {
                            if (dialog.ShowDialog() == DialogResult.OK) {
                                update = dialog.SelectedPath;
                                if (Directory.Exists(Path.Combine(update, @"content\Model"))) {
                                    SaveDirectory("update.dir", update);
                                    break;
                                } else {
                                    MessageBox.Show("Invalid directory", "BoTW File Finder");
                                }
                            } else {
                                if (MessageBox.Show("A valid game dump is required for this tool to function properly", "BoTW File Finder") == DialogResult.OK) {
                                    if (MessageBox.Show("Quit program?", "BoTW File Finder", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                                        Application.Exit();
                                        forceExit = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (var item in botwItems.Keys) {
                    if (!itemFileAssociations.ContainsKey(botwItems[item])) {
                        itemFileAssociations.Add(botwItems[item], new List<string>() { item });
                        itemView.Items.Add(botwItems[item]);
                    } else {
                        itemFileAssociations[botwItems[item]].Add(item);
                    }
                }
            }
            CheckToolDirectory();
        }

        private void itemView_SelectedValueChanged(object sender, EventArgs e) {
            currentPathText = "";
            fullPathText.Text = currentPathText;
            objectNameView.Items.Clear();
            fileNameView.Items.Clear();
            objectNameView.Items.AddRange(itemFileAssociations[itemView.SelectedItem as string].ToArray());
            currentCopyText = itemView.SelectedItem.ToString();
            copyBox.Text = currentCopyText;
        }
        private string GetDirectory(string name) {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name);
            return OpenFile(path);
            return null;
        }

        private string OpenFile(string path) {
            if (File.Exists(path)) {
                using (StreamReader reader = new StreamReader(path)) {
                    return reader.ReadLine();
                }
            }
            return "";
        }

        private void SaveDirectory(string name, string value) {
            using (StreamWriter writer = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name))) {
                writer.WriteLine(value);
            }
        }
        private void objectNameView_SelectedValueChanged(object sender, EventArgs e) {
            currentPathText = "";
            fullPathText.Text = currentPathText;
            fileNameView.Items.Clear();
            files = new List<string>();
            files.AddRange(Directory.EnumerateFiles(Path.Combine(baseGame, @"content\Model")));
            files.AddRange(Directory.EnumerateFiles(Path.Combine(update, @"content\Model")));
            files.AddRange(Directory.EnumerateFiles(Path.Combine(update, @"content\Actor\Pack")));
            files.AddRange(Directory.EnumerateFiles(Path.Combine(update, @"content\UI\StockItem")));
            if (objectNameView.SelectedItem != null) {
                currentCopyText = objectNameView.SelectedItem.ToString();
            }
            copyBox.Text = currentCopyText;
            //files.AddRange(Directory.EnumerateFiles(Path.Combine(dlc, @"content\Model")));
            if (objectNameView.SelectedItem != null) {
                currentFiles = files.Select(x => new FileInfo(x))
                                           .Where(x => x.Name.Contains(objectNameView.SelectedItem as string))
                                           .ToArray();
                foreach (var file in currentFiles) {
                    fileNameView.Items.Add(file.Name);
                }
            }
        }

        private void fileNameView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (fileNameView.SelectedItem != null) {
                Process.Start(currentFiles[fileNameView.SelectedIndex].FullName);
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e) {

        }

        private void objectNameView_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void fileNameView_SelectedValueChanged(object sender, EventArgs e) {
            if (fileNameView.SelectedItem != null) {
                currentCopyText = fileNameView.SelectedItem.ToString();
                currentPathText = currentFiles[fileNameView.SelectedIndex].FullName;
            }
            fullPathText.Text = currentPathText;
            copyBox.Text = currentCopyText;
        }

        private void copyBox_TextChanged(object sender, EventArgs e) {
            copyBox.Text = currentCopyText;
        }

        private void copyBox_KeyDown(object sender, KeyEventArgs e) {
            copyBox.Text = currentCopyText;
        }

        private void copyBox_KeyPress(object sender, KeyPressEventArgs e) {
            copyBox.Text = currentCopyText;
        }

        private void copyBox_KeyUp(object sender, KeyEventArgs e) {
            copyBox.Text = currentCopyText;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void fullPathText_TextChanged(object sender, EventArgs e) {
            fullPathText.Text = currentPathText;
        }

        private void fileNameView_MouseDown(object sender, MouseEventArgs e) {
            startPos = e.Location;
            canDoDragDrop = true;
        }

        private void fileNameView_MouseMove(object sender, MouseEventArgs e) {
            if ((e.X != startPos.X || startPos.Y != e.Y) && canDoDragDrop) {
                List<string> fileList = new List<string>();
                foreach (int item in fileNameView.SelectedIndices) {
                    fileList.Add(currentFiles[item].FullName);
                }
                if (fileList.Count > 0) {
                    DataObject fileDragData = new DataObject(DataFormats.FileDrop, fileList.ToArray());
                    DoDragDrop(fileDragData, DragDropEffects.Copy);
                }
                canDoDragDrop = false;
            }
        }

        private void fileNameView_MouseUp(object sender, MouseEventArgs e) {
            canDoDragDrop = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (fileNameView.SelectedItem != null) {
                string args = "";
                foreach (int item in fileNameView.SelectedIndices) {
                    args += @"""" + currentFiles[item].FullName + @"""";
                }
                //Process.Start(toolbox, args);
            }
        }

        private void addOptionToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable |*.exe";
            if (MessageBox.Show("Please assign the tool you'd like to open with.", "BoTW File Finder") == DialogResult.OK) {
                if (dialog.ShowDialog() == DialogResult.OK) {
                    string toolpath = dialog.FileName;
                    SaveDirectory(@"tooldir\" + Path.GetFileName(dialog.FileName), toolpath);
                    Process.Start(toolpath, currentFiles[fileNameView.SelectedIndex].FullName);
                } else {
                    if (MessageBox.Show("Nothing was selected", "BoTW File Finder") == DialogResult.OK) {
                    }
                }
            }
            CheckToolDirectory();
        }
        private void CheckToolDirectory() {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"tooldir");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            openWithToolStripMenuItem.DropDownItems.Clear();
            foreach (string itemPath in Directory.GetFiles(path)) {
                ToolStripMenuItem strip = new ToolStripMenuItem();
                strip.Click += delegate {
                    string filePath = OpenFile(itemPath);
                    Process.Start(filePath, currentFiles[fileNameView.SelectedIndex].FullName);
                };
                strip.Text = "&" + Path.GetFileNameWithoutExtension(itemPath);
                openWithToolStripMenuItem.DropDownItems.Add(strip);
            }
            ToolStripMenuItem strip2 = new ToolStripMenuItem();
            strip2.Click += addOptionToolStripMenuItem_Click;
            strip2.Text = "&Add tool";
            openWithToolStripMenuItem.DropDownItems.Add(strip2);
        }

        private void openWithToolStripMenuItem_DropDownOpened(object sender, EventArgs e) {
        }

        private void fileMenu_Opening(object sender, CancelEventArgs e) {
            if (fileNameView.SelectedItem == null) {
                e.Cancel = true;
            }
        }

        private void searchBar_SelectedIndexChanged(object sender, EventArgs e) {
            valueSetByProgram = true;
        }


        private void searchBar_SelectionChangeCommitted(object sender, EventArgs e) {
            valueSetByProgram = true;
        }

        private void dropdownTimer_Tick(object sender, EventArgs e) {
            if (!searchBar.DroppedDown) {
                searchBar.DroppedDown = true;
            }
            dropdownTimer.Stop();
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Down) {
                valueSetByProgram = true;
            }
            dropdownTimer.Stop();
        }
    }
}
