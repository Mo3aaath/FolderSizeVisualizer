namespace FolderSizeVisualizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.browseBt = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.pieBt = new System.Windows.Forms.Button();
            this.barBt = new System.Windows.Forms.Button();
            this.visPanel = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tablePanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.Controls.Add(this.browseBt, 0, 2);
            this.tablePanel.Controls.Add(this.buttonsPanel, 1, 0);
            this.tablePanel.Controls.Add(this.visPanel, 1, 1);
            this.tablePanel.Controls.Add(this.treeView, 0, 0);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 3;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tablePanel.Size = new System.Drawing.Size(1057, 566);
            this.tablePanel.TabIndex = 0;
            // 
            // browseBt
            // 
            this.browseBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.browseBt.Location = new System.Drawing.Point(88, 512);
            this.browseBt.Name = "browseBt";
            this.browseBt.Size = new System.Drawing.Size(94, 51);
            this.browseBt.TabIndex = 1;
            this.browseBt.Text = "Browse";
            this.browseBt.UseVisualStyleBackColor = true;
            this.browseBt.Click += new System.EventHandler(this.browseBt_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.pieBt);
            this.buttonsPanel.Controls.Add(this.barBt);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(273, 3);
            this.buttonsPanel.MaximumSize = new System.Drawing.Size(0, 82);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(781, 76);
            this.buttonsPanel.TabIndex = 2;
            // 
            // pieBt
            // 
            this.pieBt.Location = new System.Drawing.Point(161, 21);
            this.pieBt.Name = "pieBt";
            this.pieBt.Size = new System.Drawing.Size(124, 40);
            this.pieBt.TabIndex = 1;
            this.pieBt.Text = "Pie Chart";
            this.pieBt.UseVisualStyleBackColor = true;
            // 
            // barBt
            // 
            this.barBt.Location = new System.Drawing.Point(3, 21);
            this.barBt.Name = "barBt";
            this.barBt.Size = new System.Drawing.Size(124, 40);
            this.barBt.TabIndex = 0;
            this.barBt.Text = "Bar Chart";
            this.barBt.UseVisualStyleBackColor = true;
            // 
            // visPanel
            // 
            this.visPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visPanel.Location = new System.Drawing.Point(275, 87);
            this.visPanel.Margin = new System.Windows.Forms.Padding(5);
            this.visPanel.Name = "visPanel";
            this.tablePanel.SetRowSpan(this.visPanel, 2);
            this.visPanel.Size = new System.Drawing.Size(777, 474);
            this.visPanel.TabIndex = 3;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.tablePanel.SetRowSpan(this.treeView, 2);
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(264, 503);
            this.treeView.TabIndex = 4;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "yellow.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 566);
            this.Controls.Add(this.tablePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tablePanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Button browseBt;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button pieBt;
        private System.Windows.Forms.Button barBt;
        private System.Windows.Forms.Panel visPanel;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList1;
    }
}

