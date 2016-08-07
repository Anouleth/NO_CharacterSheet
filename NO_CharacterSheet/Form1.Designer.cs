namespace NO_CharacterSheet
{
    partial class NO_MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tDisplay = new System.Windows.Forms.TabControl();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.nCHA = new System.Windows.Forms.NumericUpDown();
            this.nWIS = new System.Windows.Forms.NumericUpDown();
            this.nINT = new System.Windows.Forms.NumericUpDown();
            this.nCON = new System.Windows.Forms.NumericUpDown();
            this.nDEX = new System.Windows.Forms.NumericUpDown();
            this.nSTR = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.charName = new System.Windows.Forms.Label();
            this.bStatistics = new System.Windows.Forms.Button();
            this.bSkills = new System.Windows.Forms.Button();
            this.bFeats = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lSTRMod = new System.Windows.Forms.Label();
            this.bAbilities = new System.Windows.Forms.Button();
            this.bCombat = new System.Windows.Forms.Button();
            this.bMagic = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.tDisplay.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nINT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSTR)).BeginInit();
            this.tabSkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(726, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newCharacterSheetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            // 
            // newCharacterSheetToolStripMenuItem
            // 
            this.newCharacterSheetToolStripMenuItem.Name = "newCharacterSheetToolStripMenuItem";
            this.newCharacterSheetToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newCharacterSheetToolStripMenuItem.Text = "New Character Sheet...";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.settingsToolStripMenuItem1.Text = "Settings...";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 422);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(726, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "Status Bar";
            // 
            // tDisplay
            // 
            this.tDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDisplay.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tDisplay.Controls.Add(this.tabStatistics);
            this.tDisplay.Controls.Add(this.tabSkills);
            this.tDisplay.ItemSize = new System.Drawing.Size(1, 0);
            this.tDisplay.Location = new System.Drawing.Point(88, 69);
            this.tDisplay.Name = "tDisplay";
            this.tDisplay.SelectedIndex = 0;
            this.tDisplay.Size = new System.Drawing.Size(626, 350);
            this.tDisplay.TabIndex = 4;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.lSTRMod);
            this.tabStatistics.Controls.Add(this.label8);
            this.tabStatistics.Controls.Add(this.label7);
            this.tabStatistics.Controls.Add(this.nCHA);
            this.tabStatistics.Controls.Add(this.nWIS);
            this.tabStatistics.Controls.Add(this.nINT);
            this.tabStatistics.Controls.Add(this.nCON);
            this.tabStatistics.Controls.Add(this.nDEX);
            this.tabStatistics.Controls.Add(this.nSTR);
            this.tabStatistics.Controls.Add(this.label6);
            this.tabStatistics.Controls.Add(this.label5);
            this.tabStatistics.Controls.Add(this.label4);
            this.tabStatistics.Controls.Add(this.label3);
            this.tabStatistics.Controls.Add(this.label2);
            this.tabStatistics.Controls.Add(this.label1);
            this.tabStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(618, 321);
            this.tabStatistics.TabIndex = 0;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // nCHA
            // 
            this.nCHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCHA.Location = new System.Drawing.Point(99, 203);
            this.nCHA.Name = "nCHA";
            this.nCHA.Size = new System.Drawing.Size(47, 26);
            this.nCHA.TabIndex = 11;
            this.nCHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nWIS
            // 
            this.nWIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nWIS.Location = new System.Drawing.Point(99, 171);
            this.nWIS.Name = "nWIS";
            this.nWIS.Size = new System.Drawing.Size(47, 26);
            this.nWIS.TabIndex = 10;
            this.nWIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nINT
            // 
            this.nINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nINT.Location = new System.Drawing.Point(99, 139);
            this.nINT.Name = "nINT";
            this.nINT.Size = new System.Drawing.Size(47, 26);
            this.nINT.TabIndex = 9;
            this.nINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nCON
            // 
            this.nCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCON.Location = new System.Drawing.Point(99, 107);
            this.nCON.Name = "nCON";
            this.nCON.Size = new System.Drawing.Size(47, 26);
            this.nCON.TabIndex = 8;
            this.nCON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nDEX
            // 
            this.nDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDEX.Location = new System.Drawing.Point(99, 75);
            this.nDEX.Name = "nDEX";
            this.nDEX.Size = new System.Drawing.Size(47, 26);
            this.nDEX.TabIndex = 7;
            this.nDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nSTR
            // 
            this.nSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSTR.Location = new System.Drawing.Point(99, 43);
            this.nSTR.Name = "nSTR";
            this.nSTR.Size = new System.Drawing.Size(47, 26);
            this.nSTR.TabIndex = 6;
            this.nSTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Charisma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wisdom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intelligence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Constitution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dexterity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength";
            // 
            // tabSkills
            // 
            this.tabSkills.Controls.Add(this.label10);
            this.tabSkills.Controls.Add(this.label9);
            this.tabSkills.Location = new System.Drawing.Point(4, 25);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(618, 321);
            this.tabSkills.TabIndex = 1;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // charName
            // 
            this.charName.AutoSize = true;
            this.charName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charName.Location = new System.Drawing.Point(8, 35);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(139, 20);
            this.charName.TabIndex = 5;
            this.charName.Text = "Character Name";
            // 
            // bStatistics
            // 
            this.bStatistics.Location = new System.Drawing.Point(12, 69);
            this.bStatistics.Name = "bStatistics";
            this.bStatistics.Size = new System.Drawing.Size(70, 50);
            this.bStatistics.TabIndex = 6;
            this.bStatistics.Text = "Statistics";
            this.bStatistics.UseVisualStyleBackColor = true;
            // 
            // bSkills
            // 
            this.bSkills.Location = new System.Drawing.Point(12, 125);
            this.bSkills.Name = "bSkills";
            this.bSkills.Size = new System.Drawing.Size(70, 50);
            this.bSkills.TabIndex = 7;
            this.bSkills.Text = "Skills";
            this.bSkills.UseVisualStyleBackColor = true;
            // 
            // bFeats
            // 
            this.bFeats.Location = new System.Drawing.Point(12, 181);
            this.bFeats.Name = "bFeats";
            this.bFeats.Size = new System.Drawing.Size(70, 50);
            this.bFeats.TabIndex = 8;
            this.bFeats.Text = "Feats";
            this.bFeats.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ability";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Modifier";
            // 
            // lSTRMod
            // 
            this.lSTRMod.AutoSize = true;
            this.lSTRMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSTRMod.Location = new System.Drawing.Point(161, 45);
            this.lSTRMod.Name = "lSTRMod";
            this.lSTRMod.Size = new System.Drawing.Size(75, 20);
            this.lSTRMod.TabIndex = 14;
            this.lSTRMod.Text = "lSTRMod";
            // 
            // bAbilities
            // 
            this.bAbilities.Location = new System.Drawing.Point(12, 237);
            this.bAbilities.Name = "bAbilities";
            this.bAbilities.Size = new System.Drawing.Size(70, 50);
            this.bAbilities.TabIndex = 9;
            this.bAbilities.Text = "Abilities";
            this.bAbilities.UseVisualStyleBackColor = true;
            // 
            // bCombat
            // 
            this.bCombat.Location = new System.Drawing.Point(12, 293);
            this.bCombat.Name = "bCombat";
            this.bCombat.Size = new System.Drawing.Size(70, 50);
            this.bCombat.TabIndex = 10;
            this.bCombat.Text = "Combat";
            this.bCombat.UseVisualStyleBackColor = true;
            // 
            // bMagic
            // 
            this.bMagic.Location = new System.Drawing.Point(12, 349);
            this.bMagic.Name = "bMagic";
            this.bMagic.Size = new System.Drawing.Size(70, 50);
            this.bMagic.TabIndex = 11;
            this.bMagic.Text = "Magic";
            this.bMagic.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Skills";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(316, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Feats";
            // 
            // NO_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 444);
            this.Controls.Add(this.bMagic);
            this.Controls.Add(this.bCombat);
            this.Controls.Add(this.bAbilities);
            this.Controls.Add(this.bFeats);
            this.Controls.Add(this.bSkills);
            this.Controls.Add(this.bStatistics);
            this.Controls.Add(this.charName);
            this.Controls.Add(this.tDisplay);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "NO_MainForm";
            this.Text = "NO_CharacterSheet";
            this.Load += new System.EventHandler(this.NO_MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tDisplay.ResumeLayout(false);
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nINT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSTR)).EndInit();
            this.tabSkills.ResumeLayout(false);
            this.tabSkills.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.TabControl tDisplay;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.ToolStripMenuItem newCharacterSheetToolStripMenuItem;
        private System.Windows.Forms.Label charName;
        private System.Windows.Forms.Button bStatistics;
        private System.Windows.Forms.Button bSkills;
        private System.Windows.Forms.Button bFeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nCHA;
        private System.Windows.Forms.NumericUpDown nWIS;
        private System.Windows.Forms.NumericUpDown nINT;
        private System.Windows.Forms.NumericUpDown nCON;
        private System.Windows.Forms.NumericUpDown nDEX;
        private System.Windows.Forms.NumericUpDown nSTR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lSTRMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bAbilities;
        private System.Windows.Forms.Button bCombat;
        private System.Windows.Forms.Button bMagic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;

    }
}

