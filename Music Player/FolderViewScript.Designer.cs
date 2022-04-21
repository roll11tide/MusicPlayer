namespace Music_Player
{
    partial class FolderViewScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderViewScript));
            this.contentView = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // contentView
            // 
            this.contentView.AutoScroll = true;
            this.contentView.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.contentView.ColumnCount = 2;
            this.contentView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.37766F));
            this.contentView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.62234F));
            this.contentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentView.Location = new System.Drawing.Point(0, 0);
            this.contentView.Name = "contentView";
            this.contentView.RowCount = 1;
            this.contentView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentView.Size = new System.Drawing.Size(638, 647);
            this.contentView.TabIndex = 2;
            // 
            // FolderViewScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 647);
            this.Controls.Add(this.contentView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderViewScript";
            this.Text = "Folder View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel contentView;
    }
}