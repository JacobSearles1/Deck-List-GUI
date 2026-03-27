namespace DeckListGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.commanderButton = new System.Windows.Forms.CheckBox();
            this.deckList = new System.Windows.Forms.ListBox();
            this.cardQty = new System.Windows.Forms.NumericUpDown();
            this.cardCountBar = new System.Windows.Forms.ProgressBar();
            this.deckSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNumLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.deckName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.importFile = new System.Windows.Forms.OpenFileDialog();
            this.importButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cardQty)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardInput
            // 
            this.cardInput.Location = new System.Drawing.Point(30, 196);
            this.cardInput.Name = "cardInput";
            this.cardInput.Size = new System.Drawing.Size(146, 20);
            this.cardInput.TabIndex = 0;
            this.cardInput.Text = "Enter Card name...";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(28, 246);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add to Deck";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // commanderButton
            // 
            this.commanderButton.AutoSize = true;
            this.commanderButton.Location = new System.Drawing.Point(96, 180);
            this.commanderButton.Name = "commanderButton";
            this.commanderButton.Size = new System.Drawing.Size(65, 17);
            this.commanderButton.TabIndex = 2;
            this.commanderButton.Text = "Leader?";
            this.commanderButton.UseVisualStyleBackColor = true;
            // 
            // deckList
            // 
            this.deckList.FormattingEnabled = true;
            this.deckList.Location = new System.Drawing.Point(224, 73);
            this.deckList.Name = "deckList";
            this.deckList.Size = new System.Drawing.Size(238, 277);
            this.deckList.TabIndex = 3;
            // 
            // cardQty
            // 
            this.cardQty.Location = new System.Drawing.Point(122, 222);
            this.cardQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cardQty.Name = "cardQty";
            this.cardQty.Size = new System.Drawing.Size(54, 20);
            this.cardQty.TabIndex = 4;
            this.cardQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cardCountBar
            // 
            this.cardCountBar.Location = new System.Drawing.Point(224, 356);
            this.cardCountBar.Maximum = 51;
            this.cardCountBar.Name = "cardCountBar";
            this.cardCountBar.Size = new System.Drawing.Size(238, 23);
            this.cardCountBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cardCountBar.TabIndex = 5;
            // 
            // deckSelect
            // 
            this.deckSelect.FormattingEnabled = true;
            this.deckSelect.Items.AddRange(new object[] {
            "Commander",
            "Standard",
            "OPTCG"});
            this.deckSelect.Location = new System.Drawing.Point(30, 73);
            this.deckSelect.Name = "deckSelect";
            this.deckSelect.Size = new System.Drawing.Size(146, 21);
            this.deckSelect.TabIndex = 6;
            this.deckSelect.Text = "Select a deck type...";
            this.deckSelect.SelectedIndexChanged += new System.EventHandler(this.deckSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cards in deck:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNumLabel
            // 
            this.cardNumLabel.AutoSize = true;
            this.cardNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cardNumLabel.Location = new System.Drawing.Point(309, 385);
            this.cardNumLabel.Name = "cardNumLabel";
            this.cardNumLabel.Size = new System.Drawing.Size(66, 26);
            this.cardNumLabel.TabIndex = 8;
            this.cardNumLabel.Text = "0 / 51";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(28, 321);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(109, 321);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 10;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deckName
            // 
            this.deckName.Location = new System.Drawing.Point(30, 141);
            this.deckName.Name = "deckName";
            this.deckName.Size = new System.Drawing.Size(146, 20);
            this.deckName.TabIndex = 11;
            this.deckName.Text = "Enter Deck name...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Deck Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Card Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Card Quantity";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(109, 246);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(63, 44);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 16;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(474, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(41, 22);
            this.fileButton.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 425);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deckName);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cardNumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deckSelect);
            this.Controls.Add(this.cardCountBar);
            this.Controls.Add(this.cardQty);
            this.Controls.Add(this.deckList);
            this.Controls.Add(this.commanderButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cardInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Deck Builder";
            ((System.ComponentModel.ISupportInitialize)(this.cardQty)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox commanderButton;
        private System.Windows.Forms.ListBox deckList;
        private System.Windows.Forms.NumericUpDown cardQty;
        private System.Windows.Forms.ProgressBar cardCountBar;
        private System.Windows.Forms.ComboBox deckSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardNumLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox deckName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.OpenFileDialog importFile;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton fileButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

