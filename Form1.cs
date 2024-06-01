using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DoomLauncher2
{
    public partial class BetterDoomLauncher2 : Form
    {
        private string gzdoomDir;
        private string zandronumDir;
        private string boomDir;
        private string wadDir;

        private string projectFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private string imageFail;

        private string appDataPath;
        private string configFile;

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ImageList targetImageList;

        public BetterDoomLauncher2()
        {
            InitializeComponent();
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DoomLauncher2");
            configFile = Path.Combine(appDataPath, "config.txt");

            Directory.CreateDirectory(appDataPath);

            imageFail = Directory.GetParent(projectFolder).FullName;
            imageFail = Directory.GetParent(imageFail).FullName;
            imageFail = Path.Combine(imageFail, "Images", "a_lack_of_thumbnail.png");

            LoadConfig();

            InitializeListView();
            InitializeTargetListView();
            LoadWadFiles();

            listView1.ItemDrag += listView1_ItemDrag;
            listView2.ItemDrag += listView2_ItemDrag;



            Console.WriteLine(gzdoomDir + zandronumDir + boomDir + wadDir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0)
            {
                MessageBox.Show("No WAD files selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedIwad = listView2.Items[listView2.Items.Count - 1].Text;
            Console.WriteLine("Selected IWAD: " + selectedIwad);

            if (string.IsNullOrEmpty(selectedIwad) ||
                !(selectedIwad.EndsWith("doom.wad", StringComparison.OrdinalIgnoreCase) ||
                  selectedIwad.EndsWith("doom2.wad", StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Please add an IWAD (doom.wad or doom2.wad) at the top of the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string arguments = "-iwad \"" + selectedIwad + "\"";
            Console.WriteLine("Arguments after adding IWAD: " + arguments);
            for (int i = 0; i < listView2.Items.Count - 1; i++)
            {
                string wadFile = listView2.Items[i].Text;
                Console.WriteLine("Adding WAD file: " + wadFile);
                arguments += " -file \"" + wadFile + "\"";
            }

            Console.WriteLine("Final arguments: " + arguments);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = gzdoomDir,
                Arguments = arguments,
                UseShellExecute = false
            };

            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching Doom: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void GZDOOMDir_Click(object sender, EventArgs e)
        {
            /*button throws up file explorer to select GZDoom.exe in order to be used.*/
            openGZDOOMDir.InitialDirectory = "C:";
            openGZDOOMDir.Title = "Open GZDoom executeable";
            openGZDOOMDir.ShowDialog();

            try
            {
                gzdoomDir = openGZDOOMDir.FileName;
            }
            catch
            {
                MessageBox.Show("Selection Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ZandronumDir_Click(object sender, EventArgs e)
        {
            /*button throws up file explorer to select Zandronum.exe in order to be used.*/
            openZandronumDir.InitialDirectory = "C:";
            openZandronumDir.Title = "Open Zandronum executeable";
            openZandronumDir.ShowDialog();

            try
            {
                zandronumDir = openZandronumDir.FileName;
            }
            catch
            {
                MessageBox.Show("Selection Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BOOMDir_Click(object sender, EventArgs e)
        {
            /*button throws up file explorer to select Boom.exe in order to be used.*/
            openBOOMDir.InitialDirectory = "C:";
            openBOOMDir.Title = "Open Boom executeable";
            openBOOMDir.ShowDialog();

            try
            {
                boomDir = openBOOMDir.FileName;
            }
            catch
            {
                MessageBox.Show("Selection Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveConfig()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configFile))
                {
                    writer.WriteLine($"gzdoomDir={gzdoomDir}");
                    writer.WriteLine($"zandronumDir={zandronumDir}");
                    writer.WriteLine($"boomDir={boomDir}");
                    writer.WriteLine($"wadDir={wadDir}");
                }
                MessageBox.Show("Configuration saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists(configFile))
                {
                    using (StreamReader reader = new StreamReader(configFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split('=');
                            if (parts.Length == 2) 
                            {
                                switch (parts[0].Trim()) 
                                {
                                    case "gzdoomDir":
                                        gzdoomDir = parts[1].Trim(); 
                                        break;
                                    case "zandronumDir":
                                        zandronumDir = parts[1].Trim();
                                        break;
                                    case "boomDir":
                                        boomDir = parts[1].Trim();
                                        break;
                                    case "wadDir":
                                        wadDir = parts[1].Trim();
                                        break;
                                }
                            }
                        }
                    }
                    MessageBox.Show("Configuration loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WadDir_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openWadDir = new CommonOpenFileDialog();
            openWadDir.IsFolderPicker = true;
            openWadDir.InitialDirectory = "C:";
            openWadDir.Title = "Open directory containing WADs and whatnot.";
            openWadDir.ShowDialog();
            try
            {
                wadDir = openWadDir.FileName;
            }
            catch
            {
                MessageBox.Show("Selection Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadWadFiles();
        }

        private void InitializeListView()
        {
            imageList = new System.Windows.Forms.ImageList();
            imageList.ImageSize = new Size(192, 108); 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            listView1.SmallImageList = imageList;

            listView1.Columns.Add("WAD Files", 100, HorizontalAlignment.Left);
            listView1.Location = new Point(53, 183);
            listView1.Size = new Size(391, 588);
            listView1.AllowDrop = true; 

            // Event handlers for drag-and-drop
            listView1.DragEnter += listView1_DragEnter;
            listView1.DragDrop += listView1_DragDrop;
        }

        private void InitializeTargetListView()
        {
            targetImageList = new System.Windows.Forms.ImageList();
            targetImageList.ImageSize = new Size(192, 108);
            targetImageList.ColorDepth = ColorDepth.Depth32Bit;

            listView2.SmallImageList = targetImageList;

            listView2.AllowDrop = true;

            listView2.DragEnter += TargetListView_DragEnter;
            listView2.DragDrop += TargetListView_DragDrop;
        }
        private void listView2_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView2.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void listView2_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = listView2.PointToClient(new Point(e.X, e.Y));
            int targetIndex = listView2.InsertionMark.NearestIndex(targetPoint);
            listView2.InsertionMark.Index = targetIndex;
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            int targetIndex = listView2.InsertionMark.Index;
            if (targetIndex == -1)
            {
                return;
            }
            if (listView2.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            listView2.Items.Remove(draggedItem);
            listView2.Items.Insert(targetIndex, draggedItem);
            listView2.InsertionMark.Index = -1;
        }
        private void listView2_DragLeave(object sender, EventArgs e)
        {
            listView2.InsertionMark.Index = -1;
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                Point clientPoint = listView1.PointToClient(new Point(e.X, e.Y));
                ListViewItem targetItem = listView1.GetItemAt(clientPoint.X, clientPoint.Y);

                int targetIndex;

                if (targetItem != null)
                {
                    targetIndex = targetItem.Index;
                }
                else
                {
                    targetIndex = listView1.Items.Count;
                }
                bool itemExists = listView1.Items.Cast<ListViewItem>().Any(item => item.Text.Equals(draggedItem.Text));

                if (!itemExists)
                {
                    if (draggedItem.ListView == listView2)
                    {
                        listView2.Items.Remove(draggedItem);
                    }
                    listView1.Items.Insert(targetIndex, draggedItem);
                }
            }
        }

        private void RebuildImageList(ListView listView, ImageList imageList)
        {
            imageList.Images.Clear();
            foreach (ListViewItem item in listView.Items)
            {
                int index = imageList.Images.Count;
                imageList.Images.Add(item.ImageList.Images[item.ImageIndex]);
                item.ImageIndex = index;
            }
        }


        private void TargetListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TargetListView_DragDrop(object sender, DragEventArgs e)
        {
            int targetIndex = listView2.InsertionMark.Index;
            if (targetIndex == -1)
            {
                return;
            }
            if (listView2.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            bool itemExists = listView2.Items.Cast<ListViewItem>().Any(existingItem => existingItem.Text.Equals(draggedItem.Text));
            if (itemExists)
            {
                return;
            }
            listView2.Items.Insert(targetIndex, (ListViewItem)draggedItem.Clone());
            listView1.Items.Remove(draggedItem);

            listView2.Refresh();
            listView1.Refresh();
        }


        private async void LoadWadFiles()
        {
            string directoryPath = wadDir;

            if (Directory.Exists(directoryPath))
            {
                listView1.Items.Clear();
                DisposeImageList(imageList);
                string[] supportedExtensions = { "*.wad", "*.pk3", "*.iwad", "*.pwad" };
                foreach (string ext in supportedExtensions)
                {
                    try
                    {
                        string[] wadFiles = await Task.Run(() => Directory.GetFiles(directoryPath, ext));
                        foreach (string wadFile in wadFiles)
                        {
                            Image wadImage = GetPlaceholderImage();
                            if (wadImage != null && !IsDuplicateFile(wadFile))
                            {
                                imageList.Images.Add(wadImage);
                                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(Path.GetFileName(wadFile));
                                item.ImageIndex = imageList.Images.Count - 1;
                                listView1.Items.Add(item);
                            }
                            else
                            {
                                wadImage?.Dispose();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while processing files with extension '{ext}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void DisposeImageList(System.Windows.Forms.ImageList imageList)
        {
            foreach (Image img in imageList.Images)
            {
                img.Dispose();
            }
            imageList.Images.Clear();
        }

        private Image GetPlaceholderImage()
        {
            try
            {
                return new Bitmap(imageFail); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the placeholder image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool IsDuplicateFile(string filePath)
        {
            foreach (System.Windows.Forms.ListViewItem item in listView1.Items)
            {
                if (item.Text.Equals(Path.GetFileName(filePath), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void refreshWads_Click(object sender, EventArgs e)
        {
            LoadWadFiles();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
