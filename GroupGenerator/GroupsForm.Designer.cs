﻿using System.Reflection;

namespace GroupGenerator
{
    partial class GroupsForm
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
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.groupsOfLabel = new System.Windows.Forms.Label();
            this.groupSizeBox = new System.Windows.Forms.TextBox();
            this.numberOfGroupsLabel = new System.Windows.Forms.Label();
            this.numberOfGroupsBox = new System.Windows.Forms.TextBox();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.splitIntoGroupsOfButton = new System.Windows.Forms.Button();
            this.splitIntoGroupsButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.editListButton = new System.Windows.Forms.Button();
            this.pickOneButton = new System.Windows.Forms.Button();
            this.loadExampleListButton = new System.Windows.Forms.Button();
            this.TextFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.LastNameFirstNameFullRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameFirstNameAbbreviatedRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameFirstNameStudentNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.TextFormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 15;
            this.groupsListBox.Location = new System.Drawing.Point(12, 12);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(252, 424);
            this.groupsListBox.TabIndex = 0;
            // 
            // groupsOfLabel
            // 
            this.groupsOfLabel.AutoSize = true;
            this.groupsOfLabel.Location = new System.Drawing.Point(273, 121);
            this.groupsOfLabel.Name = "groupsOfLabel";
            this.groupsOfLabel.Size = new System.Drawing.Size(108, 15);
            this.groupsOfLabel.TabIndex = 1;
            this.groupsOfLabel.Text = "Split into groups of";
            // 
            // groupSizeBox
            // 
            this.groupSizeBox.Location = new System.Drawing.Point(387, 118);
            this.groupSizeBox.Name = "groupSizeBox";
            this.groupSizeBox.Size = new System.Drawing.Size(50, 23);
            this.groupSizeBox.TabIndex = 2;
            this.groupSizeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GroupSizeBox_KeyDown);
            // 
            // numberOfGroupsLabel
            // 
            this.numberOfGroupsLabel.AutoSize = true;
            this.numberOfGroupsLabel.Location = new System.Drawing.Point(273, 179);
            this.numberOfGroupsLabel.Name = "numberOfGroupsLabel";
            this.numberOfGroupsLabel.Size = new System.Drawing.Size(54, 15);
            this.numberOfGroupsLabel.TabIndex = 3;
            this.numberOfGroupsLabel.Text = "Split into";
            // 
            // numberOfGroupsBox
            // 
            this.numberOfGroupsBox.Location = new System.Drawing.Point(331, 176);
            this.numberOfGroupsBox.Name = "numberOfGroupsBox";
            this.numberOfGroupsBox.Size = new System.Drawing.Size(50, 23);
            this.numberOfGroupsBox.TabIndex = 4;
            this.numberOfGroupsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberOfGroupsBox_KeyDown);
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Location = new System.Drawing.Point(387, 179);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(44, 15);
            this.groupsLabel.TabIndex = 5;
            this.groupsLabel.Text = "groups";
            // 
            // splitIntoGroupsOfButton
            // 
            this.splitIntoGroupsOfButton.Location = new System.Drawing.Point(273, 147);
            this.splitIntoGroupsOfButton.Name = "splitIntoGroupsOfButton";
            this.splitIntoGroupsOfButton.Size = new System.Drawing.Size(164, 23);
            this.splitIntoGroupsOfButton.TabIndex = 6;
            this.splitIntoGroupsOfButton.Text = "Split";
            this.splitIntoGroupsOfButton.UseVisualStyleBackColor = true;
            this.splitIntoGroupsOfButton.Click += new System.EventHandler(this.SplitIntoGroupsOfButton_Click);
            // 
            // splitIntoGroupsButton
            // 
            this.splitIntoGroupsButton.Location = new System.Drawing.Point(273, 205);
            this.splitIntoGroupsButton.Name = "splitIntoGroupsButton";
            this.splitIntoGroupsButton.Size = new System.Drawing.Size(164, 23);
            this.splitIntoGroupsButton.TabIndex = 7;
            this.splitIntoGroupsButton.Text = "Split";
            this.splitIntoGroupsButton.UseVisualStyleBackColor = true;
            this.splitIntoGroupsButton.Click += new System.EventHandler(this.SplitIntoGroupsButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(273, 41);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(164, 23);
            this.shuffleButton.TabIndex = 8;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // editListButton
            // 
            this.editListButton.Location = new System.Drawing.Point(273, 12);
            this.editListButton.Name = "editListButton";
            this.editListButton.Size = new System.Drawing.Size(164, 23);
            this.editListButton.TabIndex = 9;
            this.editListButton.Text = "Edit List";
            this.editListButton.UseVisualStyleBackColor = true;
            this.editListButton.Click += new System.EventHandler(this.EditListButton_Click);
            // 
            // pickOneButton
            // 
            this.pickOneButton.Location = new System.Drawing.Point(273, 369);
            this.pickOneButton.Name = "pickOneButton";
            this.pickOneButton.Size = new System.Drawing.Size(164, 23);
            this.pickOneButton.TabIndex = 10;
            this.pickOneButton.Text = "Pick One Randomly";
            this.pickOneButton.UseVisualStyleBackColor = true;
            this.pickOneButton.Click += new System.EventHandler(this.PickOneButton_Click);
            // 
            // loadExampleListButton
            // 
            this.loadExampleListButton.Location = new System.Drawing.Point(273, 413);
            this.loadExampleListButton.Name = "loadExampleListButton";
            this.loadExampleListButton.Size = new System.Drawing.Size(164, 23);
            this.loadExampleListButton.TabIndex = 11;
            this.loadExampleListButton.Text = "Load Example List";
            this.loadExampleListButton.UseVisualStyleBackColor = true;
            this.loadExampleListButton.Click += new System.EventHandler(this.LoadExampleListButton_Click);
            // 
            // TextFormatGroupBox
            // 
            this.TextFormatGroupBox.Controls.Add(this.LastNameFirstNameStudentNumberRadioButton);
            this.TextFormatGroupBox.Controls.Add(this.LastNameFirstNameAbbreviatedRadioButton);
            this.TextFormatGroupBox.Controls.Add(this.LastNameFirstNameFullRadioButton);
            this.TextFormatGroupBox.Location = new System.Drawing.Point(273, 234);
            this.TextFormatGroupBox.Name = "TextFormatGroupBox";
            this.TextFormatGroupBox.Size = new System.Drawing.Size(158, 129);
            this.TextFormatGroupBox.TabIndex = 12;
            this.TextFormatGroupBox.TabStop = false;
            this.TextFormatGroupBox.Text = "Text Format";
            // 
            // LastNameFirstNameFullRadioButton
            // 
            this.LastNameFirstNameFullRadioButton.AutoSize = true;
            this.LastNameFirstNameFullRadioButton.Location = new System.Drawing.Point(14, 30);
            this.LastNameFirstNameFullRadioButton.Name = "LastNameFirstNameFullRadioButton";
            this.LastNameFirstNameFullRadioButton.Size = new System.Drawing.Size(99, 19);
            this.LastNameFirstNameFullRadioButton.TabIndex = 0;
            this.LastNameFirstNameFullRadioButton.TabStop = true;
            this.LastNameFirstNameFullRadioButton.Text = "Last, First  Full";
            this.LastNameFirstNameFullRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastNameFirstNameAbbreviatedRadioButton
            // 
            this.LastNameFirstNameAbbreviatedRadioButton.AutoSize = true;
            this.LastNameFirstNameAbbreviatedRadioButton.Location = new System.Drawing.Point(14, 55);
            this.LastNameFirstNameAbbreviatedRadioButton.Name = "LastNameFirstNameAbbreviatedRadioButton";
            this.LastNameFirstNameAbbreviatedRadioButton.Size = new System.Drawing.Size(105, 19);
            this.LastNameFirstNameAbbreviatedRadioButton.TabIndex = 1;
            this.LastNameFirstNameAbbreviatedRadioButton.TabStop = true;
            this.LastNameFirstNameAbbreviatedRadioButton.Text = "Last, First Abbv";
            this.LastNameFirstNameAbbreviatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastNameFirstNameStudentNumberRadioButton
            // 
            this.LastNameFirstNameStudentNumberRadioButton.AutoSize = true;
            this.LastNameFirstNameStudentNumberRadioButton.Location = new System.Drawing.Point(14, 80);
            this.LastNameFirstNameStudentNumberRadioButton.Name = "LastNameFirstNameStudentNumberRadioButton";
            this.LastNameFirstNameStudentNumberRadioButton.Size = new System.Drawing.Size(134, 19);
            this.LastNameFirstNameStudentNumberRadioButton.TabIndex = 2;
            this.LastNameFirstNameStudentNumberRadioButton.TabStop = true;
            this.LastNameFirstNameStudentNumberRadioButton.Text = "Last, First, Stud Num";
            this.LastNameFirstNameStudentNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.TextFormatGroupBox);
            this.Controls.Add(this.loadExampleListButton);
            this.Controls.Add(this.pickOneButton);
            this.Controls.Add(this.editListButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.splitIntoGroupsButton);
            this.Controls.Add(this.splitIntoGroupsOfButton);
            this.Controls.Add(this.groupsLabel);
            this.Controls.Add(this.numberOfGroupsBox);
            this.Controls.Add(this.numberOfGroupsLabel);
            this.Controls.Add(this.groupSizeBox);
            this.Controls.Add(this.groupsOfLabel);
            this.Controls.Add(this.groupsListBox);
            this.Name = "GroupsForm";
            this.Text = "Group Generator";
            this.TextFormatGroupBox.ResumeLayout(false);
            this.TextFormatGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox groupsListBox;
        private Label groupsOfLabel;
        private TextBox groupSizeBox;
        private Label numberOfGroupsLabel;
        private TextBox numberOfGroupsBox;
        private Label groupsLabel;
        private Button splitIntoGroupsOfButton;
        private Button splitIntoGroupsButton;
        private Button shuffleButton;
        private Button editListButton;
        private Button pickOneButton;
        private Button loadExampleListButton;
        private GroupBox TextFormatGroupBox;
        private RadioButton LastNameFirstNameStudentNumberRadioButton;
        private RadioButton LastNameFirstNameAbbreviatedRadioButton;
        private RadioButton LastNameFirstNameFullRadioButton;
    }
}