namespace ArduinoCommunication
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.PortSelection = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectionStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ConnectionMenuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionRefreshOption = new System.Windows.Forms.ToolStripMenuItem();
            this.PortLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.RateSelection = new System.Windows.Forms.ComboBox();
            this.ConnectionStatusStrip.SuspendLayout();
            this.ConnectionMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortSelection
            // 
            this.PortSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortSelection.FormattingEnabled = true;
            this.PortSelection.Location = new System.Drawing.Point(42, 29);
            this.PortSelection.Name = "PortSelection";
            this.PortSelection.Size = new System.Drawing.Size(121, 21);
            this.PortSelection.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(15, 85);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectionStatusStrip
            // 
            this.ConnectionStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionStatus});
            this.ConnectionStatusStrip.Location = new System.Drawing.Point(0, 118);
            this.ConnectionStatusStrip.Name = "ConnectionStatusStrip";
            this.ConnectionStatusStrip.Size = new System.Drawing.Size(181, 22);
            this.ConnectionStatusStrip.TabIndex = 2;
            this.ConnectionStatusStrip.Text = "statusStrip1";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(88, 17);
            this.ConnectionStatus.Text = "Not Connected";
            // 
            // ConnectionMenuStrip
            // 
            this.ConnectionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionMenuConnection});
            this.ConnectionMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ConnectionMenuStrip.Name = "ConnectionMenuStrip";
            this.ConnectionMenuStrip.Size = new System.Drawing.Size(181, 24);
            this.ConnectionMenuStrip.TabIndex = 3;
            this.ConnectionMenuStrip.Text = "menuStrip1";
            // 
            // ConnectionMenuConnection
            // 
            this.ConnectionMenuConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionRefreshOption});
            this.ConnectionMenuConnection.Name = "ConnectionMenuConnection";
            this.ConnectionMenuConnection.Size = new System.Drawing.Size(81, 20);
            this.ConnectionMenuConnection.Text = "Connection";
            // 
            // ConnectionRefreshOption
            // 
            this.ConnectionRefreshOption.Name = "ConnectionRefreshOption";
            this.ConnectionRefreshOption.Size = new System.Drawing.Size(113, 22);
            this.ConnectionRefreshOption.Text = "Refresh";
            this.ConnectionRefreshOption.Click += new System.EventHandler(this.ConnectionRefreshOption_Click);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(12, 32);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "Port";
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(12, 61);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(30, 13);
            this.RateLabel.TabIndex = 7;
            this.RateLabel.Text = "Rate";
            // 
            // RateSelection
            // 
            this.RateSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RateSelection.FormattingEnabled = true;
            this.RateSelection.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "115200"});
            this.RateSelection.Location = new System.Drawing.Point(42, 58);
            this.RateSelection.Name = "RateSelection";
            this.RateSelection.Size = new System.Drawing.Size(121, 21);
            this.RateSelection.TabIndex = 5;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 140);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.RateSelection);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.ConnectionStatusStrip);
            this.Controls.Add(this.ConnectionMenuStrip);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionForm";
            this.Text = "Arduino Communication";
            this.ConnectionStatusStrip.ResumeLayout(false);
            this.ConnectionStatusStrip.PerformLayout();
            this.ConnectionMenuStrip.ResumeLayout(false);
            this.ConnectionMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortSelection;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.StatusStrip ConnectionStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatus;
        private System.Windows.Forms.MenuStrip ConnectionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ConnectionMenuConnection;
        private System.Windows.Forms.ToolStripMenuItem ConnectionRefreshOption;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.ComboBox RateSelection;
    }
}

