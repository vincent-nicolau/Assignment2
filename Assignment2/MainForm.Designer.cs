using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblMakeModel;
        private ListBox lstMakeModel;
        private Label lblYear;
        private TextBox txtYear;

        private GroupBox grpColors;
        private RadioButton radRed;
        private RadioButton radBlue;
        private RadioButton radWhite;
        private RadioButton radSilver;

        private GroupBox grpFeatures;
        private CheckBox chkHeatedSeats;
        private CheckBox chkPerformancePackage;
        private CheckBox chkAdaptiveCruise;
        private CheckBox chkSatelliteRadio;

        private Button btnPurchase;
        private Label lblPurchaseSummary;

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
            radWhite = new RadioButton();
            radSilver = new RadioButton();
            grpFeatures = new GroupBox();
            chkHeatedSeats = new CheckBox();
            chkPerformancePackage = new CheckBox();
            chkAdaptiveCruise = new CheckBox();
            chkSatelliteRadio = new CheckBox();
            btnPurchase = new Button();
            lblPurchaseSummary = new Label();
            grpColors.SuspendLayout();
            grpFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblMakeModel
            // 
            lblMakeModel.AccessibleName = "Make and Model";
            lblMakeModel.AutoSize = true;
            lblMakeModel.Location = new Point(30, 20);
            lblMakeModel.Name = "lblMakeModel";
            lblMakeModel.Size = new Size(96, 15);
            lblMakeModel.TabIndex = 0;
            lblMakeModel.Text = "&Make and Model";
            // 
            // lstMakeModel
            // 
            lstMakeModel.FormattingEnabled = true;
            lstMakeModel.ItemHeight = 15;
            lstMakeModel.Items.AddRange(new object[] { "Toyota Camry", "GMC Sierra", "Jeep Grand Cherokee", "Honda CRV" });
            lstMakeModel.Location = new Point(30, 40);
            lstMakeModel.Name = "lstMakeModel";
            lstMakeModel.Size = new Size(150, 94);
            lstMakeModel.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AccessibleName = "Year";
            lblYear.AutoSize = true;
            lblYear.Location = new Point(200, 20);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
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
            grpColors.Controls.Add(radWhite);
            grpColors.Controls.Add(radSilver);
            grpColors.Location = new Point(320, 20);
            grpColors.Name = "grpColors";
            grpColors.Size = new Size(150, 150);
            grpColors.TabIndex = 4;
            grpColors.TabStop = false;
            grpColors.Text = "&Colors";
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
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Location = new Point(10, 80);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(56, 19);
            radWhite.TabIndex = 8;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            // 
            // radSilver
            // 
            radSilver.AutoSize = true;
            radSilver.Location = new Point(10, 100);
            radSilver.Name = "radSilver";
            radSilver.Size = new Size(53, 19);
            radSilver.TabIndex = 9;
            radSilver.TabStop = true;
            radSilver.Text = "Silver";
            radSilver.UseVisualStyleBackColor = true;
            // 
            // grpFeatures
            // 
            grpFeatures.Controls.Add(chkHeatedSeats);
            grpFeatures.Controls.Add(chkPerformancePackage);
            grpFeatures.Controls.Add(chkAdaptiveCruise);
            grpFeatures.Controls.Add(chkSatelliteRadio);
            grpFeatures.Location = new Point(490, 20);
            grpFeatures.Name = "grpFeatures";
            grpFeatures.Size = new Size(200, 150);
            grpFeatures.TabIndex = 10;
            grpFeatures.TabStop = false;
            grpFeatures.Text = "&Features";
            // 
            // chkHeatedSeats
            // 
            chkHeatedSeats.AutoSize = true;
            chkHeatedSeats.Location = new Point(10, 40);
            chkHeatedSeats.Name = "chkHeatedSeats";
            chkHeatedSeats.Size = new Size(93, 19);
            chkHeatedSeats.TabIndex = 12;
            chkHeatedSeats.Text = "Heated seats";
            chkHeatedSeats.UseVisualStyleBackColor = true;
            // 
            // chkPerformancePackage
            // 
            chkPerformancePackage.AutoSize = true;
            chkPerformancePackage.Location = new Point(10, 60);
            chkPerformancePackage.Name = "chkPerformancePackage";
            chkPerformancePackage.Size = new Size(141, 19);
            chkPerformancePackage.TabIndex = 13;
            chkPerformancePackage.Text = "Performance package";
            chkPerformancePackage.UseVisualStyleBackColor = true;
            // 
            // chkAdaptiveCruise
            // 
            chkAdaptiveCruise.AutoSize = true;
            chkAdaptiveCruise.Location = new Point(10, 80);
            chkAdaptiveCruise.Name = "chkAdaptiveCruise";
            chkAdaptiveCruise.Size = new Size(107, 19);
            chkAdaptiveCruise.TabIndex = 14;
            chkAdaptiveCruise.Text = "Adaptive cruise";
            chkAdaptiveCruise.UseVisualStyleBackColor = true;
            // 
            // chkSatelliteRadio
            // 
            chkSatelliteRadio.AutoSize = true;
            chkSatelliteRadio.Location = new Point(10, 100);
            chkSatelliteRadio.Name = "chkSatelliteRadio";
            chkSatelliteRadio.Size = new Size(97, 19);
            chkSatelliteRadio.TabIndex = 15;
            chkSatelliteRadio.Text = "Satellite radio";
            chkSatelliteRadio.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(30, 212);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(150, 30);
            btnPurchase.TabIndex = 16;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click_1;
            // 
            // lblPurchaseSummary
            // 
            lblPurchaseSummary.BorderStyle = BorderStyle.FixedSingle;
            lblPurchaseSummary.Location = new Point(200, 212);
            lblPurchaseSummary.Name = "lblPurchaseSummary";
            lblPurchaseSummary.Size = new Size(490, 55);
            lblPurchaseSummary.TabIndex = 17;
            lblPurchaseSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 320);
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
            Load += MainForm_Load;
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
