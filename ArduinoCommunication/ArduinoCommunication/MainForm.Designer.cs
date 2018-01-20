namespace ArduinoCommunication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MainMenuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionDisconnectOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.TextSendButton = new System.Windows.Forms.Button();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PinBox = new System.Windows.Forms.TextBox();
            this.PinState = new System.Windows.Forms.ComboBox();
            this.DigitalLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.DigitalSendButton = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuConnection,
            this.MainMenuAbout});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(348, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // MainMenuConnection
            // 
            this.MainMenuConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionDisconnectOption});
            this.MainMenuConnection.Name = "MainMenuConnection";
            this.MainMenuConnection.Size = new System.Drawing.Size(81, 20);
            this.MainMenuConnection.Text = "Connection";
            // 
            // ConnectionDisconnectOption
            // 
            this.ConnectionDisconnectOption.Name = "ConnectionDisconnectOption";
            this.ConnectionDisconnectOption.Size = new System.Drawing.Size(133, 22);
            this.ConnectionDisconnectOption.Text = "Disconnect";
            this.ConnectionDisconnectOption.Click += new System.EventHandler(this.ConnectionDisconnectOption_Click);
            // 
            // MainMenuAbout
            // 
            this.MainMenuAbout.Name = "MainMenuAbout";
            this.MainMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MainMenuAbout.Text = "About";
            this.MainMenuAbout.Click += new System.EventHandler(this.MainMenuAbout_Click);
            // 
            // DataBox
            // 
            this.DataBox.Location = new System.Drawing.Point(78, 28);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(178, 20);
            this.DataBox.TabIndex = 1;
            // 
            // TextSendButton
            // 
            this.TextSendButton.Location = new System.Drawing.Point(262, 27);
            this.TextSendButton.Name = "TextSendButton";
            this.TextSendButton.Size = new System.Drawing.Size(75, 23);
            this.TextSendButton.TabIndex = 2;
            this.TextSendButton.Text = "Send";
            this.TextSendButton.UseVisualStyleBackColor = true;
            this.TextSendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 113);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(348, 22);
            this.MainStatusStrip.TabIndex = 3;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 84);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PinBox
            // 
            this.PinBox.Location = new System.Drawing.Point(78, 58);
            this.PinBox.Name = "PinBox";
            this.PinBox.Size = new System.Drawing.Size(74, 20);
            this.PinBox.TabIndex = 5;
            // 
            // PinState
            // 
            this.PinState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PinState.FormattingEnabled = true;
            this.PinState.Items.AddRange(new object[] {
            "0",
            "1"});
            this.PinState.Location = new System.Drawing.Point(159, 56);
            this.PinState.Name = "PinState";
            this.PinState.Size = new System.Drawing.Size(97, 21);
            this.PinState.TabIndex = 6;
            // 
            // DigitalLabel
            // 
            this.DigitalLabel.AutoSize = true;
            this.DigitalLabel.Location = new System.Drawing.Point(12, 61);
            this.DigitalLabel.Name = "DigitalLabel";
            this.DigitalLabel.Size = new System.Drawing.Size(64, 13);
            this.DigitalLabel.TabIndex = 7;
            this.DigitalLabel.Text = "Digital Write";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 32);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 13);
            this.TextLabel.TabIndex = 8;
            this.TextLabel.Text = "Text";
            // 
            // DigitalSendButton
            // 
            this.DigitalSendButton.Location = new System.Drawing.Point(262, 55);
            this.DigitalSendButton.Name = "DigitalSendButton";
            this.DigitalSendButton.Size = new System.Drawing.Size(75, 23);
            this.DigitalSendButton.TabIndex = 9;
            this.DigitalSendButton.Text = "Send";
            this.DigitalSendButton.UseVisualStyleBackColor = true;
            this.DigitalSendButton.Click += new System.EventHandler(this.DigitalSendButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 135);
            this.Controls.Add(this.DigitalSendButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.DigitalLabel);
            this.Controls.Add(this.PinState);
            this.Controls.Add(this.PinBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.TextSendButton);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MainMenuConnection;
        private System.Windows.Forms.ToolStripMenuItem ConnectionDisconnectOption;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Button TextSendButton;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MainMenuAbout;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox PinBox;
        private System.Windows.Forms.ComboBox PinState;
        private System.Windows.Forms.Label DigitalLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Button DigitalSendButton;
    }
}