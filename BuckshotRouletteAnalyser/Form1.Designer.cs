namespace BuckshotRouletteAnalyser
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainLayoutPanel = new TableLayoutPanel();
            MainPictureBox = new PictureBox();
            BottomLeftLayoutPanel = new TableLayoutPanel();
            ShellsLayoutPanel = new TableLayoutPanel();
            LiveBulletsLabel = new Label();
            BlankBulletsLabel = new Label();
            LiveBulletsComboBox = new ComboBox();
            BlankBulletsComboBox = new ComboBox();
            HealthLayoutPanel = new TableLayoutPanel();
            YourHealthLabel = new Label();
            DealersHealthLabel = new Label();
            YourHealthComboBox = new ComboBox();
            DealersHealthComboBox = new ComboBox();
            ResetButton = new Button();
            StartButton = new Button();
            ItemsLayoutPanel = new TableLayoutPanel();
            MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            BottomLeftLayoutPanel.SuspendLayout();
            ShellsLayoutPanel.SuspendLayout();
            HealthLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            MainLayoutPanel.ColumnCount = 2;
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainLayoutPanel.Controls.Add(MainPictureBox, 0, 0);
            MainLayoutPanel.Controls.Add(BottomLeftLayoutPanel, 0, 1);
            MainLayoutPanel.Controls.Add(StartButton, 1, 1);
            MainLayoutPanel.Controls.Add(ItemsLayoutPanel, 1, 0);
            MainLayoutPanel.Dock = DockStyle.Fill;
            MainLayoutPanel.Location = new Point(0, 0);
            MainLayoutPanel.Name = "MainLayoutPanel";
            MainLayoutPanel.RowCount = 2;
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainLayoutPanel.Size = new Size(1182, 853);
            MainLayoutPanel.TabIndex = 0;
            // 
            // MainPictureBox
            // 
            MainPictureBox.Dock = DockStyle.Fill;
            MainPictureBox.Location = new Point(3, 3);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(880, 676);
            MainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            MainPictureBox.MouseClick += MainPictureBox_MouseClick;
            // 
            // BottomLeftLayoutPanel
            // 
            BottomLeftLayoutPanel.ColumnCount = 3;
            BottomLeftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            BottomLeftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            BottomLeftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            BottomLeftLayoutPanel.Controls.Add(ShellsLayoutPanel, 0, 0);
            BottomLeftLayoutPanel.Controls.Add(HealthLayoutPanel, 1, 0);
            BottomLeftLayoutPanel.Controls.Add(ResetButton, 2, 0);
            BottomLeftLayoutPanel.Dock = DockStyle.Fill;
            BottomLeftLayoutPanel.Location = new Point(3, 685);
            BottomLeftLayoutPanel.Name = "BottomLeftLayoutPanel";
            BottomLeftLayoutPanel.RowCount = 1;
            BottomLeftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BottomLeftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BottomLeftLayoutPanel.Size = new Size(880, 165);
            BottomLeftLayoutPanel.TabIndex = 1;
            // 
            // ShellsLayoutPanel
            // 
            ShellsLayoutPanel.ColumnCount = 4;
            ShellsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.Controls.Add(LiveBulletsLabel, 0, 0);
            ShellsLayoutPanel.Controls.Add(BlankBulletsLabel, 0, 2);
            ShellsLayoutPanel.Controls.Add(LiveBulletsComboBox, 1, 1);
            ShellsLayoutPanel.Controls.Add(BlankBulletsComboBox, 1, 3);
            ShellsLayoutPanel.Dock = DockStyle.Fill;
            ShellsLayoutPanel.Location = new Point(3, 3);
            ShellsLayoutPanel.Name = "ShellsLayoutPanel";
            ShellsLayoutPanel.RowCount = 4;
            ShellsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ShellsLayoutPanel.Size = new Size(284, 159);
            ShellsLayoutPanel.TabIndex = 0;
            // 
            // LiveBulletsLabel
            // 
            LiveBulletsLabel.AutoSize = true;
            LiveBulletsLabel.BackColor = Color.FromArgb(64, 0, 0);
            ShellsLayoutPanel.SetColumnSpan(LiveBulletsLabel, 4);
            LiveBulletsLabel.Dock = DockStyle.Fill;
            LiveBulletsLabel.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LiveBulletsLabel.ForeColor = Color.FromArgb(255, 128, 128);
            LiveBulletsLabel.Location = new Point(3, 0);
            LiveBulletsLabel.Name = "LiveBulletsLabel";
            LiveBulletsLabel.Size = new Size(278, 39);
            LiveBulletsLabel.TabIndex = 0;
            LiveBulletsLabel.Text = "Live bullets:";
            LiveBulletsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BlankBulletsLabel
            // 
            BlankBulletsLabel.AutoSize = true;
            BlankBulletsLabel.BackColor = Color.Teal;
            ShellsLayoutPanel.SetColumnSpan(BlankBulletsLabel, 4);
            BlankBulletsLabel.Dock = DockStyle.Fill;
            BlankBulletsLabel.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BlankBulletsLabel.ForeColor = Color.FromArgb(0, 0, 192);
            BlankBulletsLabel.Location = new Point(3, 78);
            BlankBulletsLabel.Name = "BlankBulletsLabel";
            BlankBulletsLabel.Size = new Size(278, 39);
            BlankBulletsLabel.TabIndex = 1;
            BlankBulletsLabel.Text = "Blank bullets:";
            BlankBulletsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LiveBulletsComboBox
            // 
            ShellsLayoutPanel.SetColumnSpan(LiveBulletsComboBox, 2);
            LiveBulletsComboBox.Dock = DockStyle.Fill;
            LiveBulletsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LiveBulletsComboBox.FormattingEnabled = true;
            LiveBulletsComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            LiveBulletsComboBox.Location = new Point(74, 42);
            LiveBulletsComboBox.Name = "LiveBulletsComboBox";
            LiveBulletsComboBox.Size = new Size(136, 28);
            LiveBulletsComboBox.TabIndex = 2;
            LiveBulletsComboBox.SelectedIndexChanged += LiveBulletsComboBox_SelectedIndexChanged;
            // 
            // BlankBulletsComboBox
            // 
            ShellsLayoutPanel.SetColumnSpan(BlankBulletsComboBox, 2);
            BlankBulletsComboBox.Dock = DockStyle.Fill;
            BlankBulletsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BlankBulletsComboBox.FormattingEnabled = true;
            BlankBulletsComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            BlankBulletsComboBox.Location = new Point(74, 120);
            BlankBulletsComboBox.Name = "BlankBulletsComboBox";
            BlankBulletsComboBox.Size = new Size(136, 28);
            BlankBulletsComboBox.TabIndex = 3;
            BlankBulletsComboBox.SelectedIndexChanged += BlankBulletsComboBox_SelectedIndexChanged;
            // 
            // HealthLayoutPanel
            // 
            HealthLayoutPanel.ColumnCount = 4;
            HealthLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.Controls.Add(YourHealthLabel, 0, 0);
            HealthLayoutPanel.Controls.Add(DealersHealthLabel, 0, 2);
            HealthLayoutPanel.Controls.Add(YourHealthComboBox, 1, 1);
            HealthLayoutPanel.Controls.Add(DealersHealthComboBox, 1, 3);
            HealthLayoutPanel.Dock = DockStyle.Fill;
            HealthLayoutPanel.Location = new Point(293, 3);
            HealthLayoutPanel.Name = "HealthLayoutPanel";
            HealthLayoutPanel.RowCount = 4;
            HealthLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HealthLayoutPanel.Size = new Size(284, 159);
            HealthLayoutPanel.TabIndex = 1;
            // 
            // YourHealthLabel
            // 
            YourHealthLabel.AutoSize = true;
            YourHealthLabel.BackColor = Color.FromArgb(192, 255, 192);
            HealthLayoutPanel.SetColumnSpan(YourHealthLabel, 4);
            YourHealthLabel.Dock = DockStyle.Fill;
            YourHealthLabel.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YourHealthLabel.ForeColor = Color.Green;
            YourHealthLabel.Location = new Point(3, 0);
            YourHealthLabel.Name = "YourHealthLabel";
            YourHealthLabel.Size = new Size(278, 39);
            YourHealthLabel.TabIndex = 0;
            YourHealthLabel.Text = "Your health:";
            YourHealthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DealersHealthLabel
            // 
            DealersHealthLabel.AutoSize = true;
            DealersHealthLabel.BackColor = Color.FromArgb(255, 192, 128);
            HealthLayoutPanel.SetColumnSpan(DealersHealthLabel, 4);
            DealersHealthLabel.Dock = DockStyle.Fill;
            DealersHealthLabel.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DealersHealthLabel.ForeColor = Color.FromArgb(128, 64, 0);
            DealersHealthLabel.Location = new Point(3, 78);
            DealersHealthLabel.Name = "DealersHealthLabel";
            DealersHealthLabel.Size = new Size(278, 39);
            DealersHealthLabel.TabIndex = 1;
            DealersHealthLabel.Text = "Dealer's health:";
            DealersHealthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YourHealthComboBox
            // 
            HealthLayoutPanel.SetColumnSpan(YourHealthComboBox, 2);
            YourHealthComboBox.Dock = DockStyle.Fill;
            YourHealthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            YourHealthComboBox.FormattingEnabled = true;
            YourHealthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            YourHealthComboBox.Location = new Point(74, 42);
            YourHealthComboBox.Name = "YourHealthComboBox";
            YourHealthComboBox.Size = new Size(136, 28);
            YourHealthComboBox.TabIndex = 2;
            YourHealthComboBox.SelectedIndexChanged += YourHealthComboBox_SelectedIndexChanged;
            // 
            // DealersHealthComboBox
            // 
            HealthLayoutPanel.SetColumnSpan(DealersHealthComboBox, 2);
            DealersHealthComboBox.Dock = DockStyle.Fill;
            DealersHealthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DealersHealthComboBox.FormattingEnabled = true;
            DealersHealthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            DealersHealthComboBox.Location = new Point(74, 120);
            DealersHealthComboBox.Name = "DealersHealthComboBox";
            DealersHealthComboBox.Size = new Size(136, 28);
            DealersHealthComboBox.TabIndex = 3;
            DealersHealthComboBox.SelectedIndexChanged += DealersHealthComboBox_SelectedIndexChanged;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(255, 128, 128);
            ResetButton.Dock = DockStyle.Fill;
            ResetButton.Font = new Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetButton.ForeColor = Color.FromArgb(192, 0, 0);
            ResetButton.Location = new Point(630, 40);
            ResetButton.Margin = new Padding(50, 40, 50, 40);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(200, 85);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "RESET THE TABLE";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(128, 255, 128);
            StartButton.Dock = DockStyle.Fill;
            StartButton.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.ForeColor = Color.Green;
            StartButton.Location = new Point(906, 702);
            StartButton.Margin = new Padding(20);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(256, 131);
            StartButton.TabIndex = 2;
            StartButton.Text = "RUN";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // ItemsLayoutPanel
            // 
            ItemsLayoutPanel.ColumnCount = 1;
            ItemsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ItemsLayoutPanel.Dock = DockStyle.Fill;
            ItemsLayoutPanel.Location = new Point(889, 3);
            ItemsLayoutPanel.Name = "ItemsLayoutPanel";
            ItemsLayoutPanel.RowCount = 2;
            ItemsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ItemsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            ItemsLayoutPanel.Size = new Size(290, 676);
            ItemsLayoutPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 853);
            Controls.Add(MainLayoutPanel);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buckshot Roulette Analyser";
            Load += MainForm_Load;
            MainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            BottomLeftLayoutPanel.ResumeLayout(false);
            ShellsLayoutPanel.ResumeLayout(false);
            ShellsLayoutPanel.PerformLayout();
            HealthLayoutPanel.ResumeLayout(false);
            HealthLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainLayoutPanel;
        private PictureBox MainPictureBox;
        private TableLayoutPanel BottomLeftLayoutPanel;
        private Button StartButton;
        private TableLayoutPanel ShellsLayoutPanel;
        private TableLayoutPanel HealthLayoutPanel;
        private Button ResetButton;
        private TableLayoutPanel ItemsLayoutPanel;
        private Label LiveBulletsLabel;
        private Label BlankBulletsLabel;
        private ComboBox LiveBulletsComboBox;
        private ComboBox BlankBulletsComboBox;
        private Label YourHealthLabel;
        private Label DealersHealthLabel;
        private ComboBox YourHealthComboBox;
        private ComboBox DealersHealthComboBox;
    }
}
