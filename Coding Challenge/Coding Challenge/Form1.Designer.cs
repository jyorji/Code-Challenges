
namespace Coding_Challenge
{
    partial class QBuild
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.current_part_label = new System.Windows.Forms.Label();
            this.parent_child_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Populate_Data = new System.Windows.Forms.Button();
            this.BOMTreeView = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.current_part_label);
            this.groupBox1.Controls.Add(this.parent_child_label);
            this.groupBox1.Controls.Add(this.Exit_button);
            this.groupBox1.Controls.Add(this.Populate_Data);
            this.groupBox1.Controls.Add(this.BOMTreeView);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(313, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Part:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(313, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parent Child Part:";
            // 
            // current_part_label
            // 
            this.current_part_label.AutoSize = true;
            this.current_part_label.ForeColor = System.Drawing.Color.LimeGreen;
            this.current_part_label.Location = new System.Drawing.Point(400, 75);
            this.current_part_label.Name = "current_part_label";
            this.current_part_label.Size = new System.Drawing.Size(0, 17);
            this.current_part_label.TabIndex = 6;
            // 
            // parent_child_label
            // 
            this.parent_child_label.AutoSize = true;
            this.parent_child_label.ForeColor = System.Drawing.Color.Red;
            this.parent_child_label.Location = new System.Drawing.Point(424, 41);
            this.parent_child_label.Name = "parent_child_label";
            this.parent_child_label.Size = new System.Drawing.Size(0, 17);
            this.parent_child_label.TabIndex = 5;
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(313, 170);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(177, 25);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Exit from Application";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Populate_Data
            // 
            this.Populate_Data.Location = new System.Drawing.Point(313, 128);
            this.Populate_Data.Name = "Populate_Data";
            this.Populate_Data.Size = new System.Drawing.Size(177, 25);
            this.Populate_Data.TabIndex = 2;
            this.Populate_Data.Text = "Populate Data in Tree";
            this.Populate_Data.UseVisualStyleBackColor = true;
            this.Populate_Data.Click += new System.EventHandler(this.Populate_Data_Click);
            // 
            // BOMTreeView
            // 
            this.BOMTreeView.Location = new System.Drawing.Point(15, 24);
            this.BOMTreeView.Name = "BOMTreeView";
            this.BOMTreeView.Size = new System.Drawing.Size(275, 189);
            this.BOMTreeView.TabIndex = 0;
            this.BOMTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BOMTreeView_AfterSelect);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 296);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 45;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(776, 200);
            this.dataGridView.TabIndex = 1;
            
            // 
            // QBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "QBuild";
            this.Text = "QBuild";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Populate_Data;
        private System.Windows.Forms.TreeView BOMTreeView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label current_part_label;
        private System.Windows.Forms.Label parent_child_label;
    }
}

