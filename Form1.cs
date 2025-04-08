using DataImport.Processors;
using Microsoft.Data.SqlClient;
using XMLtoDatabase.Processors;

namespace XMLtoDatabase
{
    public partial class Form1 : Form
    {
        private string connectionString = "";
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();

            // Load the ConnectionString saved
            txtConnectionString.Text = Properties.Settings.Default.cs;
        }

        // Connect Button ----------------------------------------
        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectionString = txtConnectionString.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Save the ConnectionString
                    Properties.Settings.Default.cs = connectionString;
                    Properties.Settings.Default.Save();

                    isConnected = true;
                    MessageBox.Show("Connection successful!", "DB Importer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    isConnected = false;
                    MessageBox.Show("Connection failed: " + ex.Message, "DB Importer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ItemMaking.xml ----------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\ItemMaking";
                    files = Directory.GetFiles(directory, "*.xml");
                    ItemMakingImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"ItemMake imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImportAccessory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SqlConnection(txtConnectionString.Text))
                {
                    var processor = new AccessoryRollProcessor(db);
                    var xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AccessoryStatusInfo.xml");

                    processor.Import(xmlPath);
                    MessageBox.Show("AccessoryRoll importado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao importar: " + ex.Message);
            }
        }


        // DigimonList.xml ---------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\DigimonList";
                    files = Directory.GetFiles(directory, "*.xml");
                    DigimonListImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"DigimonList imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // DigimonEvo.xml ----------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\DigimonEvo";
                    files = Directory.GetFiles(directory, "*.xml");
                    DigimonEvoImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"DigimonEvo imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // MapList.xml -------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Maps";
                    files = Directory.GetFiles(directory, "*.xml");
                    MapInfoImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"MapList imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ItemList.xml ------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\ItemList";
                    files = Directory.GetFiles(directory, "*.xml");
                    ItemInfoImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"ItemList imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // NPC.xml -----------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\NPC";
                    files = Directory.GetFiles(directory, "*.xml");
                    NpcInfoImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"NPC imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // MapPortal.xml -----------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\PortalInfo";
                    files = Directory.GetFiles(directory, "*.xml");
                    PortalImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"MapPortal imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Quest.xml ---------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Quest";
                    files = Directory.GetFiles(directory, "*.xml");
                    QuestImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"Quest imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Seal.xml ----------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Seal";
                    files = Directory.GetFiles(directory, "*.xml");
                    SealInfoImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"Seal imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ItemXAI.xml -------------------------------------------
        private void button10_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\ItemXAI";
                    files = Directory.GetFiles(directory, "*.xml");
                    ItemXaiImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"ItemXAI imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // SkillCode.xml -----------------------------------------
        private void button11_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Skill";
                    files = Directory.GetFiles(directory, "*.xml");
                    SkillCodeImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"SkillCode imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // SkillInfo.xml -----------------------------------------
        private void button12_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Skill";
                    files = Directory.GetFiles(directory, "*.xml");
                    var directory1 = currentDir + "\\XML\\DigimonList";
                    var files1 = Directory.GetFiles(directory1, "*.xml");
                    SkillImportProcessor.Import(connectionString, files, files1);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"SkillInfo imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // DigimonSkill.xml --------------------------------------
        private void button13_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Skill";
                    files = Directory.GetFiles(directory, "*.xml");
                    var directory2 = currentDir + "\\XML\\DigimonList";
                    var files2 = Directory.GetFiles(directory2, "*.xml");
                    DigimonSkillProcessor.Import(connectionString, files, files2);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"DigimonSkill imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Summon.xml --------------------------------------------
        private void button14_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Summon";
                    files = Directory.GetFiles(directory, "*.xml");
                    SummonImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"Summon imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hatch.xml ---------------------------------------------
        private void button15_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Hatch";
                    files = Directory.GetFiles(directory, "*.xml");
                    HatchImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"Hatch imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Container.xml -----------------------------------------
        private void button16_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Container";
                    files = Directory.GetFiles(directory, "*.xml");
                    ContainerImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"Container imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Scan.xml -----------------------------------------
        private void button17_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var currentDir = Directory.GetCurrentDirectory();
                string directory;
                string[]? files;

                connectionString = txtConnectionString.Text;

                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Step = 1;
                progressBar1.Visible = true;
                progressBar1.PerformStep();

                try
                {
                    directory = currentDir + "\\XML\\Scan";
                    files = Directory.GetFiles(directory, "*.xml");
                    ScanImportProcessor.Import(connectionString, files);
                    progressBar1.PerformStep();
                    Thread.Sleep(1500);

                    MessageBox.Show($"Scan imported successfully!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unhandled exception: {ex.Message} {ex.StackTrace}.");

                    progressBar1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You must connect to the database first.", "DB Importer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
