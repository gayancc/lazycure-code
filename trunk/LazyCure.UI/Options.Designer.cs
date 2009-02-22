namespace LifeIdea.LazyCure.UI
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.saveAfterDone = new System.Windows.Forms.CheckBox();
            this.maxActivitiesInHistory = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.activitiesNumberInTray = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reminderTime = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTimeLogsFolder = new System.Windows.Forms.Button();
            this.timeLogFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.switchTimeLogAtMidnight = new System.Windows.Forms.CheckBox();
            this.hotKeyToActivateLabel = new System.Windows.Forms.Label();
            this.editActivateKeys = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opensMainWindow = new System.Windows.Forms.RadioButton();
            this.showsRecentActivities = new System.Windows.Forms.RadioButton();
            this.switchOnLogOff = new System.Windows.Forms.CheckBox();
            this.tabTwitter = new System.Windows.Forms.TabPage();
            this.twitterLink = new System.Windows.Forms.LinkLabel();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.enableTwitterCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxActivitiesInHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesNumberInTray)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTwitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveAfterDone
            // 
            this.saveAfterDone.AutoSize = true;
            this.saveAfterDone.Location = new System.Drawing.Point(6, 6);
            this.saveAfterDone.Name = "saveAfterDone";
            this.saveAfterDone.Size = new System.Drawing.Size(262, 17);
            this.saveAfterDone.TabIndex = 0;
            this.saveAfterDone.Text = "Save Time Log everytime \'Done\' button is pressed";
            this.saveAfterDone.UseVisualStyleBackColor = true;
            // 
            // maxActivitiesInHistory
            // 
            this.maxActivitiesInHistory.Location = new System.Drawing.Point(244, 85);
            this.maxActivitiesInHistory.Name = "maxActivitiesInHistory";
            this.maxActivitiesInHistory.Size = new System.Drawing.Size(36, 20);
            this.maxActivitiesInHistory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maximum number of activities stored in history:";
            // 
            // activitiesNumberInTray
            // 
            this.activitiesNumberInTray.Location = new System.Drawing.Point(193, 64);
            this.activitiesNumberInTray.Name = "activitiesNumberInTray";
            this.activitiesNumberInTray.Size = new System.Drawing.Size(36, 20);
            this.activitiesNumberInTray.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of activities showed in tray:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(h:mm) of inactivity";
            // 
            // reminderTime
            // 
            this.reminderTime.Location = new System.Drawing.Point(75, 129);
            this.reminderTime.Mask = "0:00";
            this.reminderTime.Name = "reminderTime";
            this.reminderTime.Size = new System.Drawing.Size(28, 20);
            this.reminderTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remind after";
            // 
            // selectTimeLogsFolder
            // 
            this.selectTimeLogsFolder.Location = new System.Drawing.Point(308, 105);
            this.selectTimeLogsFolder.Name = "selectTimeLogsFolder";
            this.selectTimeLogsFolder.Size = new System.Drawing.Size(25, 23);
            this.selectTimeLogsFolder.TabIndex = 5;
            this.selectTimeLogsFolder.Text = "...";
            this.selectTimeLogsFolder.UseVisualStyleBackColor = true;
            this.selectTimeLogsFolder.Click += new System.EventHandler(this.selectTimeLogsFolder_Click);
            // 
            // timeLogFolder
            // 
            this.timeLogFolder.Location = new System.Drawing.Point(117, 107);
            this.timeLogFolder.Name = "timeLogFolder";
            this.timeLogFolder.ReadOnly = true;
            this.timeLogFolder.Size = new System.Drawing.Size(185, 20);
            this.timeLogFolder.TabIndex = 4;
            this.timeLogFolder.Text = "D:\\Program Files\\LazyCure\\TimeLogs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder with time logs:";
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(185, 236);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(266, 236);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabTwitter);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 230);
            this.tabControl.TabIndex = 6;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.switchTimeLogAtMidnight);
            this.tabGeneral.Controls.Add(this.hotKeyToActivateLabel);
            this.tabGeneral.Controls.Add(this.editActivateKeys);
            this.tabGeneral.Controls.Add(this.label6);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Controls.Add(this.switchOnLogOff);
            this.tabGeneral.Controls.Add(this.activitiesNumberInTray);
            this.tabGeneral.Controls.Add(this.saveAfterDone);
            this.tabGeneral.Controls.Add(this.label5);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.label4);
            this.tabGeneral.Controls.Add(this.maxActivitiesInHistory);
            this.tabGeneral.Controls.Add(this.reminderTime);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.timeLogFolder);
            this.tabGeneral.Controls.Add(this.selectTimeLogsFolder);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(342, 204);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // switchTimeLogAtMidnight
            // 
            this.switchTimeLogAtMidnight.AutoSize = true;
            this.switchTimeLogAtMidnight.Location = new System.Drawing.Point(6, 42);
            this.switchTimeLogAtMidnight.Name = "switchTimeLogAtMidnight";
            this.switchTimeLogAtMidnight.Size = new System.Drawing.Size(301, 17);
            this.switchTimeLogAtMidnight.TabIndex = 20;
            this.switchTimeLogAtMidnight.Text = "At midnight close active time log and open on the next day";
            this.switchTimeLogAtMidnight.UseVisualStyleBackColor = true;
            // 
            // hotKeyToActivateLabel
            // 
            this.hotKeyToActivateLabel.Location = new System.Drawing.Point(160, 169);
            this.hotKeyToActivateLabel.Name = "hotKeyToActivateLabel";
            this.hotKeyToActivateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hotKeyToActivateLabel.Size = new System.Drawing.Size(96, 16);
            this.hotKeyToActivateLabel.TabIndex = 19;
            this.hotKeyToActivateLabel.Text = "Ctrl+F12";
            this.hotKeyToActivateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editActivateKeys
            // 
            this.editActivateKeys.Location = new System.Drawing.Point(262, 165);
            this.editActivateKeys.Name = "editActivateKeys";
            this.editActivateKeys.Size = new System.Drawing.Size(25, 23);
            this.editActivateKeys.TabIndex = 18;
            this.editActivateKeys.Text = "...";
            this.editActivateKeys.UseVisualStyleBackColor = true;
            this.editActivateKeys.Click += new System.EventHandler(this.editActivateKeys_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hot key to activate:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opensMainWindow);
            this.groupBox1.Controls.Add(this.showsRecentActivities);
            this.groupBox1.Location = new System.Drawing.Point(9, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 47);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left click on tray:";
            // 
            // opensMainWindow
            // 
            this.opensMainWindow.AutoSize = true;
            this.opensMainWindow.Checked = true;
            this.opensMainWindow.Location = new System.Drawing.Point(6, 13);
            this.opensMainWindow.Name = "opensMainWindow";
            this.opensMainWindow.Size = new System.Drawing.Size(118, 17);
            this.opensMainWindow.TabIndex = 13;
            this.opensMainWindow.TabStop = true;
            this.opensMainWindow.Text = "opens main window";
            this.opensMainWindow.UseVisualStyleBackColor = true;
            // 
            // showsRecentActivities
            // 
            this.showsRecentActivities.AutoSize = true;
            this.showsRecentActivities.Location = new System.Drawing.Point(6, 28);
            this.showsRecentActivities.Name = "showsRecentActivities";
            this.showsRecentActivities.Size = new System.Drawing.Size(132, 17);
            this.showsRecentActivities.TabIndex = 14;
            this.showsRecentActivities.Text = "shows recent activities";
            this.showsRecentActivities.UseVisualStyleBackColor = true;
            // 
            // switchOnLogOff
            // 
            this.switchOnLogOff.AutoSize = true;
            this.switchOnLogOff.Location = new System.Drawing.Point(6, 24);
            this.switchOnLogOff.Name = "switchOnLogOff";
            this.switchOnLogOff.Size = new System.Drawing.Size(177, 17);
            this.switchOnLogOff.TabIndex = 11;
            this.switchOnLogOff.Text = "Switch current activity on log off";
            this.switchOnLogOff.UseVisualStyleBackColor = true;
            // 
            // tabTwitter
            // 
            this.tabTwitter.Controls.Add(this.twitterLink);
            this.tabTwitter.Controls.Add(this.passwordField);
            this.tabTwitter.Controls.Add(this.passwordLabel);
            this.tabTwitter.Controls.Add(this.usernameField);
            this.tabTwitter.Controls.Add(this.usernameLabel);
            this.tabTwitter.Controls.Add(this.enableTwitterCheckbox);
            this.tabTwitter.Location = new System.Drawing.Point(4, 22);
            this.tabTwitter.Name = "tabTwitter";
            this.tabTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwitter.Size = new System.Drawing.Size(342, 204);
            this.tabTwitter.TabIndex = 0;
            this.tabTwitter.Text = "Twitter";
            this.tabTwitter.UseVisualStyleBackColor = true;
            // 
            // twitterLink
            // 
            this.twitterLink.AutoSize = true;
            this.twitterLink.Location = new System.Drawing.Point(240, 7);
            this.twitterLink.Name = "twitterLink";
            this.twitterLink.Size = new System.Drawing.Size(94, 13);
            this.twitterLink.TabIndex = 5;
            this.twitterLink.TabStop = true;
            this.twitterLink.Text = "http://twitter.com/";
            this.twitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitterLink_LinkClicked);
            // 
            // passwordField
            // 
            this.passwordField.Enabled = false;
            this.passwordField.Location = new System.Drawing.Point(73, 49);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Enabled = false;
            this.passwordLabel.Location = new System.Drawing.Point(8, 52);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameField
            // 
            this.usernameField.Enabled = false;
            this.usernameField.Location = new System.Drawing.Point(73, 23);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(100, 20);
            this.usernameField.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Enabled = false;
            this.usernameLabel.Location = new System.Drawing.Point(8, 26);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // enableTwitterCheckbox
            // 
            this.enableTwitterCheckbox.AutoSize = true;
            this.enableTwitterCheckbox.Location = new System.Drawing.Point(8, 6);
            this.enableTwitterCheckbox.Name = "enableTwitterCheckbox";
            this.enableTwitterCheckbox.Size = new System.Drawing.Size(165, 17);
            this.enableTwitterCheckbox.TabIndex = 0;
            this.enableTwitterCheckbox.Text = "Enable post to Twitter feature";
            this.enableTwitterCheckbox.UseVisualStyleBackColor = true;
            this.enableTwitterCheckbox.CheckedChanged += new System.EventHandler(this.enableTwitterCheckbox_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(350, 271);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.maxActivitiesInHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesNumberInTray)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTwitter.ResumeLayout(false);
            this.tabTwitter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox saveAfterDone;
        private System.Windows.Forms.NumericUpDown maxActivitiesInHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeLogFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectTimeLogsFolder;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.MaskedTextBox reminderTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown activitiesNumberInTray;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTwitter;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.CheckBox enableTwitterCheckbox;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel twitterLink;
        private System.Windows.Forms.CheckBox switchOnLogOff;
        private System.Windows.Forms.RadioButton showsRecentActivities;
        private System.Windows.Forms.RadioButton opensMainWindow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editActivateKeys;
        private System.Windows.Forms.Label hotKeyToActivateLabel;
        private System.Windows.Forms.CheckBox switchTimeLogAtMidnight;

    }
}
