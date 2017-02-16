namespace TestApplication
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncomeInputPanel = new System.Windows.Forms.Panel();
            this.IncomeListGridView = new System.Windows.Forms.DataGridView();
            this.AddIncomeButton = new System.Windows.Forms.Button();
            this.IncomeDate2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.IncomeDate1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomeFrequency = new System.Windows.Forms.ComboBox();
            this.IncomeAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IncomeAmountHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeFrequencyHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeDate1Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.IncomeInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incomeToolStripMenuItem
            // 
            this.incomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            this.incomeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.incomeToolStripMenuItem.Text = "Income";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // IncomeInputPanel
            // 
            this.IncomeInputPanel.Controls.Add(this.IncomeListGridView);
            this.IncomeInputPanel.Controls.Add(this.AddIncomeButton);
            this.IncomeInputPanel.Controls.Add(this.IncomeDate2);
            this.IncomeInputPanel.Controls.Add(this.label3);
            this.IncomeInputPanel.Controls.Add(this.IncomeDate1);
            this.IncomeInputPanel.Controls.Add(this.label2);
            this.IncomeInputPanel.Controls.Add(this.IncomeFrequency);
            this.IncomeInputPanel.Controls.Add(this.IncomeAmount);
            this.IncomeInputPanel.Controls.Add(this.label1);
            this.IncomeInputPanel.Location = new System.Drawing.Point(13, 28);
            this.IncomeInputPanel.Name = "IncomeInputPanel";
            this.IncomeInputPanel.Size = new System.Drawing.Size(652, 344);
            this.IncomeInputPanel.TabIndex = 1;
            this.IncomeInputPanel.Visible = false;
            // 
            // IncomeListGridView
            // 
            this.IncomeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncomeAmountHeader,
            this.IncomeFrequencyHeader,
            this.IncomeDate1Header});
            this.IncomeListGridView.Location = new System.Drawing.Point(6, 158);
            this.IncomeListGridView.Name = "IncomeListGridView";
            this.IncomeListGridView.Size = new System.Drawing.Size(344, 150);
            this.IncomeListGridView.TabIndex = 0;
            this.IncomeListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddIncomeButton
            // 
            this.AddIncomeButton.Location = new System.Drawing.Point(353, 64);
            this.AddIncomeButton.Name = "AddIncomeButton";
            this.AddIncomeButton.Size = new System.Drawing.Size(116, 23);
            this.AddIncomeButton.TabIndex = 7;
            this.AddIncomeButton.Text = "Add Income";
            this.AddIncomeButton.UseVisualStyleBackColor = true;
            this.AddIncomeButton.Click += new System.EventHandler(this.AddIncomeButton_Click);
            // 
            // IncomeDate2
            // 
            this.IncomeDate2.Location = new System.Drawing.Point(103, 103);
            this.IncomeDate2.Name = "IncomeDate2";
            this.IncomeDate2.Size = new System.Drawing.Size(200, 20);
            this.IncomeDate2.TabIndex = 6;
            this.IncomeDate2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pay Date";
            // 
            // IncomeDate1
            // 
            this.IncomeDate1.Location = new System.Drawing.Point(103, 68);
            this.IncomeDate1.Name = "IncomeDate1";
            this.IncomeDate1.Size = new System.Drawing.Size(200, 20);
            this.IncomeDate1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frequency";
            // 
            // IncomeFrequency
            // 
            this.IncomeFrequency.FormattingEnabled = true;
            this.IncomeFrequency.Location = new System.Drawing.Point(103, 35);
            this.IncomeFrequency.Name = "IncomeFrequency";
            this.IncomeFrequency.Size = new System.Drawing.Size(121, 21);
            this.IncomeFrequency.TabIndex = 2;
            this.IncomeFrequency.SelectedIndexChanged += new System.EventHandler(this.IncomeFrequency_SelectedIndexChanged);
            // 
            // IncomeAmount
            // 
            this.IncomeAmount.Location = new System.Drawing.Point(103, 4);
            this.IncomeAmount.Name = "IncomeAmount";
            this.IncomeAmount.Size = new System.Drawing.Size(100, 20);
            this.IncomeAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // IncomeAmountHeader
            // 
            this.IncomeAmountHeader.DataPropertyName = "Amount";
            this.IncomeAmountHeader.HeaderText = "Amount";
            this.IncomeAmountHeader.Name = "IncomeAmountHeader";
            // 
            // IncomeFrequencyHeader
            // 
            this.IncomeFrequencyHeader.DataPropertyName = "Frequency";
            this.IncomeFrequencyHeader.HeaderText = "Frequency";
            this.IncomeFrequencyHeader.Name = "IncomeFrequencyHeader";
            // 
            // IncomeDate1Header
            // 
            this.IncomeDate1Header.DataPropertyName = "Date";
            this.IncomeDate1Header.HeaderText = "Date";
            this.IncomeDate1Header.Name = "IncomeDate1Header";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 384);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.IncomeInputPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.IncomeInputPanel.ResumeLayout(false);
            this.IncomeInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Panel IncomeInputPanel;
        private System.Windows.Forms.TextBox IncomeAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IncomeFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker IncomeDate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker IncomeDate2;
        private System.Windows.Forms.Button AddIncomeButton;
        private System.Windows.Forms.DataGridView IncomeListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeAmountHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeFrequencyHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeDate1Header;
    }
}