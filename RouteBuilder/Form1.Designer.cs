namespace RouteBuilder
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.adminModeButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.startPontLabel = new System.Windows.Forms.Label();
            this.destinationPoint = new System.Windows.Forms.Label();
            this.startPointTextBox = new System.Windows.Forms.TextBox();
            this.destinationPointTextBox = new System.Windows.Forms.TextBox();
            this.findRouteButton = new System.Windows.Forms.Button();
            this.selectStartPointButton = new System.Windows.Forms.Button();
            this.selectDestPointButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminModeButton
            // 
            this.adminModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminModeButton.Location = new System.Drawing.Point(434, 304);
            this.adminModeButton.Name = "adminModeButton";
            this.adminModeButton.Size = new System.Drawing.Size(72, 21);
            this.adminModeButton.TabIndex = 0;
            this.adminModeButton.Text = "admin mode";
            this.adminModeButton.UseVisualStyleBackColor = true;
            this.adminModeButton.Click += new System.EventHandler(this.adminModeButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.listBox1, 4);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(503, 225);
            this.listBox1.TabIndex = 3;
            // 
            // startPontLabel
            // 
            this.startPontLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startPontLabel.AutoSize = true;
            this.startPontLabel.Location = new System.Drawing.Point(37, 10);
            this.startPontLabel.Name = "startPontLabel";
            this.startPontLabel.Size = new System.Drawing.Size(55, 13);
            this.startPontLabel.TabIndex = 4;
            this.startPontLabel.Text = "Start point";
            // 
            // destinationPoint
            // 
            this.destinationPoint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.destinationPoint.AutoSize = true;
            this.destinationPoint.Location = new System.Drawing.Point(5, 43);
            this.destinationPoint.Name = "destinationPoint";
            this.destinationPoint.Size = new System.Drawing.Size(87, 13);
            this.destinationPoint.TabIndex = 5;
            this.destinationPoint.Text = "Destination Point";
            // 
            // startPointTextBox
            // 
            this.startPointTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startPointTextBox.Location = new System.Drawing.Point(180, 6);
            this.startPointTextBox.Name = "startPointTextBox";
            this.startPointTextBox.Size = new System.Drawing.Size(207, 20);
            this.startPointTextBox.TabIndex = 6;
            // 
            // destinationPointTextBox
            // 
            this.destinationPointTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationPointTextBox.Location = new System.Drawing.Point(180, 39);
            this.destinationPointTextBox.Name = "destinationPointTextBox";
            this.destinationPointTextBox.Size = new System.Drawing.Size(207, 20);
            this.destinationPointTextBox.TabIndex = 7;
            // 
            // findRouteButton
            // 
            this.findRouteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.findRouteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findRouteButton.Location = new System.Drawing.Point(393, 6);
            this.findRouteButton.Name = "findRouteButton";
            this.tableLayoutPanel1.SetRowSpan(this.findRouteButton, 2);
            this.findRouteButton.Size = new System.Drawing.Size(113, 54);
            this.findRouteButton.TabIndex = 8;
            this.findRouteButton.Text = "Find route";
            this.findRouteButton.UseVisualStyleBackColor = true;
            // 
            // selectStartPointButton
            // 
            this.selectStartPointButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectStartPointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectStartPointButton.Location = new System.Drawing.Point(99, 3);
            this.selectStartPointButton.Name = "selectStartPointButton";
            this.selectStartPointButton.Size = new System.Drawing.Size(75, 27);
            this.selectStartPointButton.TabIndex = 9;
            this.selectStartPointButton.Text = "Select";
            this.selectStartPointButton.UseVisualStyleBackColor = true;
            // 
            // selectDestPointButton
            // 
            this.selectDestPointButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDestPointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDestPointButton.Location = new System.Drawing.Point(99, 36);
            this.selectDestPointButton.Name = "selectDestPointButton";
            this.selectDestPointButton.Size = new System.Drawing.Size(75, 27);
            this.selectDestPointButton.TabIndex = 10;
            this.selectDestPointButton.Text = "Select";
            this.selectDestPointButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.selectDestPointButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.adminModeButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectStartPointButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.destinationPointTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.destinationPoint, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startPontLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startPointTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.findRouteButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 359);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 4);
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(509, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "RouteBuilder";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminModeButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label startPontLabel;
        private System.Windows.Forms.Label destinationPoint;
        private System.Windows.Forms.TextBox startPointTextBox;
        private System.Windows.Forms.TextBox destinationPointTextBox;
        private System.Windows.Forms.Button findRouteButton;
        private System.Windows.Forms.Button selectStartPointButton;
        private System.Windows.Forms.Button selectDestPointButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

