using Coding_Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding_Challenge
{
    public partial class QBuild : Form
    {
        public QBuild()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Populate_Data_Click(object sender, EventArgs e)
        {
            var result = new DataAccess();

            List<Bom> boms = (List<Bom>)result.GetBom();

            TreeNode parentNode = null;

            var trackChilds = new List<string>();

            foreach (var bom in boms)
            {
                if (string.IsNullOrWhiteSpace(bom.Parent_Name))
                    continue;

                TreeNode childNode = null;

                if (parentNode == null || string.IsNullOrEmpty(parentNode.Text))
                {
                    parentNode = BOMTreeView.Nodes.Add(bom.Parent_Name);
                }
                else if (parentNode.Text != bom.Parent_Name)
                {
                    if (!trackChilds.Contains(bom.Parent_Name))
                    {
                        parentNode = BOMTreeView.Nodes.Add(bom.Parent_Name);
                    }
                }

                var filterValue = bom.Component_Name;
                trackChilds.Add(filterValue);
                childNode = parentNode.Nodes.Add(filterValue);
                childNode.Nodes.AddRange(boms.Where(bomRecords => bomRecords.Parent_Name == filterValue)
                    .Select(bomRecords => new TreeNode(bomRecords.Component_Name)).ToArray());
                Populate_Data.Enabled = false;
            }
        }

        private void BOMTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            current_part_label.Text = BOMTreeView.SelectedNode.Text;

            var allChild = new List<string>();

            for (int i = 0; i < BOMTreeView.SelectedNode.Nodes.Count; i++)
            {
                allChild.Add(BOMTreeView.SelectedNode.Nodes[i].Text);
            }

            if (!(BOMTreeView.SelectedNode.Parent == null))
            {
                parent_child_label.Text = BOMTreeView.SelectedNode.Parent.Text + " \\ " + current_part_label.Text;
            }
            else
                parent_child_label.Text = current_part_label.Text;

            var result = new DataAccess();

            List<Bom> boms = (List<Bom>)result.GetBom();
            List<Part> parts = (List<Part>)result.GetPart();

            var table = from partRecords in parts
                              from bomRecords in boms
                              where allChild.Contains(partRecords.NAME)
                        select new
                              {
                                  bomRecords.Component_Name,
                                  partRecords.PART_NUMBER,
                                  partRecords.TITLE,
                                  bomRecords.Quantity,
                                  partRecords.TYPE,
                                  partRecords.ITEM,
                                  partRecords.MATERIAL
                              };

            var table2 = parts.Where(p => allChild.Contains(p.NAME)).ToArray();

            var table3 = parts.Join(boms,
                p => p.NAME,
                b => b.Component_Name, 
                (parts, boms) => new {
                    boms.Parent_Name,
                    boms.Component_Name, 
                    parts.PART_NUMBER, 
                    parts.TITLE, 
                    boms.Quantity, 
                    parts.TYPE,
                    parts.ITEM,
                    parts.MATERIAL })
                .Where(p => allChild.Contains(p.Component_Name)).ToArray();

            dataGridView.DataSource = table3;
        }
    }
}