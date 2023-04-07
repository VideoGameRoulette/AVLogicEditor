namespace AVRLogicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadFile = new System.Windows.Forms.Button();
            this.LocationList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LocationID = new System.Windows.Forms.NumericUpDown();
            this.UpdateLogic = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.RequiredPowersList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.AddPowers = new System.Windows.Forms.Button();
            this.RemovePowers = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationID)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadFile
            // 
            this.LoadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadFile.Location = new System.Drawing.Point(3, 3);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(134, 30);
            this.LoadFile.TabIndex = 0;
            this.LoadFile.Text = "Load Location Logic";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // LocationList
            // 
            this.LocationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocationList.FormattingEnabled = true;
            this.LocationList.ItemHeight = 15;
            this.LocationList.Location = new System.Drawing.Point(3, 45);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(231, 498);
            this.LocationList.TabIndex = 1;
            this.LocationList.SelectedIndexChanged += new System.EventHandler(this.LocationList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.375F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LocationList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 546);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel4.Controls.Add(this.SaveFile, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.LoadFile, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(231, 36);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // SaveFile
            // 
            this.SaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveFile.Location = new System.Drawing.Point(143, 3);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(85, 30);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "Save Logic";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ItemName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LocationID, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.UpdateLogic, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(240, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 498);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ItemName
            // 
            this.ItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemName.Enabled = false;
            this.ItemName.Location = new System.Drawing.Point(3, 3);
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Size = new System.Drawing.Size(551, 23);
            this.ItemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location ID:";
            // 
            // LocationID
            // 
            this.LocationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocationID.Enabled = false;
            this.LocationID.Location = new System.Drawing.Point(3, 63);
            this.LocationID.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.LocationID.Name = "LocationID";
            this.LocationID.ReadOnly = true;
            this.LocationID.Size = new System.Drawing.Size(551, 23);
            this.LocationID.TabIndex = 4;
            // 
            // UpdateLogic
            // 
            this.UpdateLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateLogic.Location = new System.Drawing.Point(3, 471);
            this.UpdateLogic.Name = "UpdateLogic";
            this.UpdateLogic.Size = new System.Drawing.Size(551, 24);
            this.UpdateLogic.TabIndex = 7;
            this.UpdateLogic.Text = "Update Logic";
            this.UpdateLogic.UseVisualStyleBackColor = true;
            this.UpdateLogic.Click += new System.EventHandler(this.updateLogic_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.checkedListBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RequiredPowersList, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 128);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(551, 337);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "None",
            "Gun",
            "Nova",
            "Drill",
            "Kilver",
            "AddressDisruptor1",
            "HighJump",
            "Labcoat",
            "Drone",
            "AddressDisruptor2",
            "Grapple",
            "Trenchcoat",
            "AddressBombs",
            "DroneTeleport",
            "ExtendedDroneLaunch",
            "SudranKey",
            "RedCoat",
            "Password",
            "LongKilver",
            "FatBeam"});
            this.checkedListBox1.Location = new System.Drawing.Point(278, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(270, 331);
            this.checkedListBox1.TabIndex = 5;
            // 
            // RequiredPowersList
            // 
            this.RequiredPowersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequiredPowersList.FormattingEnabled = true;
            this.RequiredPowersList.ItemHeight = 15;
            this.RequiredPowersList.Location = new System.Drawing.Point(3, 3);
            this.RequiredPowersList.Name = "RequiredPowersList";
            this.RequiredPowersList.Size = new System.Drawing.Size(269, 331);
            this.RequiredPowersList.TabIndex = 6;
            this.RequiredPowersList.SelectedIndexChanged += new System.EventHandler(this.RequiredPowersList_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.AddPowers, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.RemovePowers, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(551, 29);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // AddPowers
            // 
            this.AddPowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPowers.Location = new System.Drawing.Point(3, 3);
            this.AddPowers.Name = "AddPowers";
            this.AddPowers.Size = new System.Drawing.Size(269, 23);
            this.AddPowers.TabIndex = 0;
            this.AddPowers.Text = "Add New Powers";
            this.AddPowers.UseVisualStyleBackColor = true;
            this.AddPowers.Click += new System.EventHandler(this.AddPowers_Click);
            // 
            // RemovePowers
            // 
            this.RemovePowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemovePowers.Location = new System.Drawing.Point(278, 3);
            this.RemovePowers.Name = "RemovePowers";
            this.RemovePowers.Size = new System.Drawing.Size(270, 23);
            this.RemovePowers.TabIndex = 1;
            this.RemovePowers.Text = "Remove Selected Powers";
            this.RemovePowers.UseVisualStyleBackColor = true;
            this.RemovePowers.Click += new System.EventHandler(this.RemovePowers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Axiom Verge Location Logic Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationID)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoadFile;
        private ListBox LocationList;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label1;
        private TextBox ItemName;
        private NumericUpDown LocationID;
        private CheckedListBox checkedListBox1;
        private ListBox RequiredPowersList;
        private TableLayoutPanel tableLayoutPanel4;
        private Button SaveFile;
        private TableLayoutPanel tableLayoutPanel3;
        private Button UpdateLogic;
        private TableLayoutPanel tableLayoutPanel5;
        private Button AddPowers;
        private Button RemovePowers;
    }
}