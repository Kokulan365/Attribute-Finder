namespace AttributeFinder
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadAttributes = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.gbEntities = new System.Windows.Forms.GroupBox();
            this.lvAttributes = new System.Windows.Forms.ListView();
            this.chAttributeDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttributeLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chAttributeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntityLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntityDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMenu.SuspendLayout();
            this.gbEntities.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadAttributes,
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1229, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbLoadAttributes
            // 
            this.tsbLoadAttributes.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadAttributes.Image")));
            this.tsbLoadAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadAttributes.Name = "tsbLoadAttributes";
            this.tsbLoadAttributes.Size = new System.Drawing.Size(121, 28);
            this.tsbLoadAttributes.Text = "Loads Attributes";
            this.tsbLoadAttributes.ToolTipText = "Loads all the attributes for search";
            this.tsbLoadAttributes.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(64, 28);
            this.tsbClose.Text = "Close";
            this.tsbClose.ToolTipText = "Closes the Tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click_1);
            // 
            // gbEntities
            // 
            this.gbEntities.Controls.Add(this.lvAttributes);
            this.gbEntities.Controls.Add(this.panel2);
            this.gbEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEntities.Location = new System.Drawing.Point(0, 31);
            this.gbEntities.Name = "gbEntities";
            this.gbEntities.Size = new System.Drawing.Size(1229, 644);
            this.gbEntities.TabIndex = 5;
            this.gbEntities.TabStop = false;
            this.gbEntities.Text = "Attributes";
            // 
            // lvAttributes
            // 
            this.lvAttributes.CheckBoxes = true;
            this.lvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAttributeDisplayName,
            this.chAttributeLogicalName,
            this.chAttributeType,
            this.chEntityDisplayName,
            this.chEntityLogicalName});
            this.lvAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAttributes.FullRowSelect = true;
            this.lvAttributes.HideSelection = false;
            this.lvAttributes.Location = new System.Drawing.Point(3, 42);
            this.lvAttributes.Name = "lvAttributes";
            this.lvAttributes.Size = new System.Drawing.Size(1223, 599);
            this.lvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAttributes.TabIndex = 2;
            this.lvAttributes.UseCompatibleStateImageBehavior = false;
            this.lvAttributes.View = System.Windows.Forms.View.Details;
            // 
            // chAttributeDisplayName
            // 
            this.chAttributeDisplayName.Text = "Display Name";
            this.chAttributeDisplayName.Width = 200;
            // 
            // chAttributeLogicalName
            // 
            this.chAttributeLogicalName.Text = "Logical Name";
            this.chAttributeLogicalName.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 26);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search Attribute";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(92, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1131, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // chAttributeType
            // 
            this.chAttributeType.Text = "Attribute Type";
            this.chAttributeType.Width = 150;
            // 
            // chEntityLogicalName
            // 
            this.chEntityLogicalName.DisplayIndex = 3;
            this.chEntityLogicalName.Text = "Entity Logical Name";
            this.chEntityLogicalName.Width = 150;
            // 
            // chEntityDisplayName
            // 
            this.chEntityDisplayName.DisplayIndex = 4;
            this.chEntityDisplayName.Text = "Entity Display Name";
            this.chEntityDisplayName.Width = 150;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbEntities);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1229, 675);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gbEntities.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadAttributes;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.GroupBox gbEntities;
        private System.Windows.Forms.ListView lvAttributes;
        private System.Windows.Forms.ColumnHeader chAttributeDisplayName;
        private System.Windows.Forms.ColumnHeader chAttributeLogicalName;
        private System.Windows.Forms.ColumnHeader chAttributeType;
        private System.Windows.Forms.ColumnHeader chEntityDisplayName;
        private System.Windows.Forms.ColumnHeader chEntityLogicalName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
