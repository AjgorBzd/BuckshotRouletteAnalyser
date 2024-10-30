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
            StartButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ResetButton = new Button();
            MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            BottomLeftLayoutPanel.SuspendLayout();
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
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            // 
            // BottomLeftLayoutPanel
            // 
            BottomLeftLayoutPanel.ColumnCount = 3;
            BottomLeftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            BottomLeftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            BottomLeftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            BottomLeftLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            BottomLeftLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 0);
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(250, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(293, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(250, 125);
            tableLayoutPanel2.TabIndex = 1;
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
            MainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            BottomLeftLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainLayoutPanel;
        private PictureBox MainPictureBox;
        private TableLayoutPanel BottomLeftLayoutPanel;
        private Button StartButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ResetButton;
    }
}
