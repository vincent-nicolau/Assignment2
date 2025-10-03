namespace Assignment2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls with prefix naming conventions
        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.ListBox lstMakeModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radWhite;

        private System.Windows.Forms.GroupBox grpFeatures;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.CheckBox chkPowerWindows;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.CheckBox chkSiriusRadio;
        private System.Windows.Forms.CheckBox chkLaneAssist;

        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblPurchaseSummary;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblMakeModel = new Label();
            lstMakeModel = new ListBox();
            lblYear = new Label();
            txtYear = new TextBox();
            grpColors = new GroupBox();
            radRed = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            radWhite = new RadioButton();
            lblColors = new Label();
            grpFeatures = new GroupBox();
            lblFeatures = new Label();
            chkPowerWindows = new CheckBox();
            chkAC = new CheckBox();
            chkSiriusRadio = new CheckBox();
            chkLaneAssist = new CheckBox();
            btnPurchase = new Button();
            lblPurchaseSummary = new Label();
            grpColors.SuspendLayout();
            grpFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblMakeModel
            // 
            lblMakeModel.AccessibleDescription = "Label for Make and Model list box";
            lblMakeModel.AccessibleName = "Make and Model";
            lblMakeModel.AutoSize = true;
            lblMakeModel.Location = new Point(30, 20);
            lblMakeModel.Name = "lblMakeModel";
            lblMakeModel.Size = new Size(96, 15);
            lblMakeModel.TabIndex = 0;
            lblMakeModel.Text = "&Make and Model";
            lblMakeModel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstMakeModel
            // 
            lstMakeModel.FormattingEnabled = true;
            lstMakeModel.ItemHeight = 15;
            lstMakeModel.Items.AddRange(new object[] { "Chevrolet Silverado", "Ford F-150", "Toyota Yaris", "Honda Civic" });
            lstMakeModel.Location = new Point(30, 40);
            lstMakeModel.Name = "lstMakeModel";
            lstMakeModel.Size = new Size(150, 94);
            lstMakeModel.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AccessibleDescription = "Label for Year text box";
            lblYear.AccessibleName = "Year";
            lblYear.AutoSize = true;
            lblYear.Location = new Point(200, 20);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            lblYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(200, 40);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 3;
            // 
            // grpColors
            // 
            grpColors.Controls.Add(radRed);
            grpColors.Controls.Add(radBlue);
            grpColors.Controls.Add(radBlack);
            grpColors.Controls.Add(radWhite);
            grpColors.Controls.Add(lblColors);
            grpColors.Location = new Point(320, 20);
            grpColors.Name = "grpColors";
            grpColors.Size = new Size(150, 150);
            grpColors.TabIndex = 4;
            grpColors.TabStop = false;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Location = new Point(10, 40);
            radRed.Name = "radRed";
            radRed.Size = new Size(45, 19);
            radRed.TabIndex = 6;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Location = new Point(10, 60);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(48, 19);
            radBlue.TabIndex = 7;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(10, 80);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(53, 19);
            radBlack.TabIndex = 8;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Location = new Point(10, 100);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(56, 19);
            radWhite.TabIndex = 9;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            // 
            // lblColors
            // 
            lblColors.AccessibleDescription = "Label for color selection";
            lblColors.AccessibleName = "Colors";
            lblColors.AutoSize = true;
            lblColors.Location = new Point(10, 15);
            lblColors.Name = "lblColors";
            lblColors.Size = new Size(41, 15);
            lblColors.TabIndex = 5;
            lblColors.Text = "&Colors";
            lblColors.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpFeatures
            // 
            grpFeatures.Controls.Add(lblFeatures);
            grpFeatures.Controls.Add(chkPowerWindows);
            grpFeatures.Controls.Add(chkAC);
            grpFeatures.Controls.Add(chkSiriusRadio);
            grpFeatures.Controls.Add(chkLaneAssist);
            grpFeatures.Location = new Point(490, 20);
            grpFeatures.Name = "grpFeatures";
            grpFeatures.Size = new Size(200, 150);
            grpFeatures.TabIndex = 10;
            grpFeatures.TabStop = false;
            // 
            // lblFeatures
            // 
            lblFeatures.AccessibleDescription = "Label for features selection";
            lblFeatures.AccessibleName = "Features";
            lblFeatures.AutoSize = true;
            lblFeatures.Location = new Point(10, 15);
            lblFeatures.Name = "lblFeatures";
            lblFeatures.Size = new Size(51, 15);
            lblFeatures.TabIndex = 11;
            lblFeatures.Text = "&Features";
            lblFeatures.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkPowerWindows
            // 
            chkPowerWindows.AutoSize = true;
            chkPowerWindows.Location = new Point(10, 40);
            chkPowerWindows.Name = "chkPowerWindows";
            chkPowerWindows.Size = new Size(109, 19);
            chkPowerWindows.TabIndex = 12;
            chkPowerWindows.Text = "Power windows";
            chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(10, 60);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(42, 19);
            chkAC.TabIndex = 13;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // chkSiriusRadio
            // 
            chkSiriusRadio.AutoSize = true;
            chkSiriusRadio.Location = new Point(10, 80);
            chkSiriusRadio.Name = "chkSiriusRadio";
            chkSiriusRadio.Size = new Size(84, 19);
            chkSiriusRadio.TabIndex = 14;
            chkSiriusRadio.Text = "Sirius radio";
            chkSiriusRadio.UseVisualStyleBackColor = true;
            // 
            // chkLaneAssist
            // 
            chkLaneAssist.AutoSize = true;
            chkLaneAssist.Location = new Point(10, 100);
            chkLaneAssist.Name = "chkLaneAssist";
            chkLaneAssist.Size = new Size(107, 19);
            chkLaneAssist.TabIndex = 15;
            chkLaneAssist.Text = "Lane assistance";
            chkLaneAssist.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.AccessibleDescription = "Button to complete purchase";
            btnPurchase.AccessibleName = "Purchase";
            btnPurchase.Location = new Point(30, 185);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(150, 30); // Same width as lstMakeModel
            btnPurchase.TabIndex = 16;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true; 
            // 
            // lblPurchaseSummary
            // 
            lblPurchaseSummary.AccessibleDescription = "Displays the summary of the purchase";
            lblPurchaseSummary.AccessibleName = "Purchase Summary";
            lblPurchaseSummary.BorderStyle = BorderStyle.FixedSingle;
            lblPurchaseSummary.Location = new Point(200, 185);
            lblPurchaseSummary.Name = "lblPurchaseSummary";
            lblPurchaseSummary.Size = new Size(490, 30); // 100 (Year) + 150 (Colors) + 200 (Features) + 40 (spacing)
            lblPurchaseSummary.TabIndex = 17;
            lblPurchaseSummary.Text = "";
            lblPurchaseSummary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 240);
            Controls.Add(lblMakeModel);
            Controls.Add(lstMakeModel);
            Controls.Add(lblYear);
            Controls.Add(txtYear);
            Controls.Add(grpColors);
            Controls.Add(grpFeatures);
            Controls.Add(btnPurchase);
            Controls.Add(lblPurchaseSummary);
            Name = "MainForm";
            Text = "Assignment 2";
            Load += Form1_Load;
            grpColors.ResumeLayout(false);
            grpColors.PerformLayout();
            grpFeatures.ResumeLayout(false);
            grpFeatures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
