
namespace CSharp_SQL
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSQL = new System.Windows.Forms.DataGridView();
            this.rowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labBackPage = new System.Windows.Forms.Label();
            this.labFrontPage = new System.Windows.Forms.Label();
            this.txbPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).BeginInit();
            this.ContextMenuStripView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSQL
            // 
            this.dataGridViewSQL.AllowUserToAddRows = false;
            this.dataGridViewSQL.AllowUserToDeleteRows = false;
            this.dataGridViewSQL.AllowUserToOrderColumns = true;
            this.dataGridViewSQL.AllowUserToResizeRows = false;
            this.dataGridViewSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowIndex,
            this.name,
            this.gender,
            this.grade,
            this.addr});
            this.dataGridViewSQL.ContextMenuStrip = this.ContextMenuStripView;
            this.dataGridViewSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSQL.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.ReadOnly = true;
            this.dataGridViewSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSQL.Size = new System.Drawing.Size(800, 420);
            this.dataGridViewSQL.TabIndex = 0;
            // 
            // rowIndex
            // 
            this.rowIndex.HeaderText = "学生编号";
            this.rowIndex.Name = "rowIndex";
            this.rowIndex.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.HeaderText = "班级";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // addr
            // 
            this.addr.FillWeight = 500F;
            this.addr.HeaderText = "地址";
            this.addr.Name = "addr";
            this.addr.ReadOnly = true;
            // 
            // ContextMenuStripView
            // 
            this.ContextMenuStripView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增ToolStripMenuItem,
            this.删ToolStripMenuItem});
            this.ContextMenuStripView.Name = "ContextMenuStripView";
            this.ContextMenuStripView.Size = new System.Drawing.Size(181, 70);
            // 
            // 增ToolStripMenuItem
            // 
            this.增ToolStripMenuItem.Name = "增ToolStripMenuItem";
            this.增ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.增ToolStripMenuItem.Text = "增/改";
            this.增ToolStripMenuItem.Click += new System.EventHandler(this.增ToolStripMenuItem_Click);
            // 
            // 删ToolStripMenuItem
            // 
            this.删ToolStripMenuItem.Name = "删ToolStripMenuItem";
            this.删ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删ToolStripMenuItem.Text = "删";
            this.删ToolStripMenuItem.Click += new System.EventHandler(this.删ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labBackPage);
            this.panel1.Controls.Add(this.labFrontPage);
            this.panel1.Controls.Add(this.txbPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 1;
            // 
            // labBackPage
            // 
            this.labBackPage.AutoSize = true;
            this.labBackPage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labBackPage.Location = new System.Drawing.Point(447, 8);
            this.labBackPage.Name = "labBackPage";
            this.labBackPage.Size = new System.Drawing.Size(41, 12);
            this.labBackPage.TabIndex = 2;
            this.labBackPage.Text = "下一页";
            this.labBackPage.Click += new System.EventHandler(this.labBackPage_Click);
            // 
            // labFrontPage
            // 
            this.labFrontPage.AutoSize = true;
            this.labFrontPage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labFrontPage.Location = new System.Drawing.Point(293, 8);
            this.labFrontPage.Name = "labFrontPage";
            this.labFrontPage.Size = new System.Drawing.Size(41, 12);
            this.labFrontPage.TabIndex = 1;
            this.labFrontPage.Text = "上一页";
            this.labFrontPage.Click += new System.EventHandler(this.labFrontPage_Click);
            // 
            // txbPage
            // 
            this.txbPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPage.Location = new System.Drawing.Point(340, 5);
            this.txbPage.Name = "txbPage";
            this.txbPage.Size = new System.Drawing.Size(100, 21);
            this.txbPage.TabIndex = 0;
            this.txbPage.Text = "/";
            this.txbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPage.TextChanged += new System.EventHandler(this.txbPage_TextChanged);
            this.txbPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbPage_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).EndInit();
            this.ContextMenuStripView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labBackPage;
        private System.Windows.Forms.Label labFrontPage;
        private System.Windows.Forms.TextBox txbPage;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripView;
        private System.Windows.Forms.ToolStripMenuItem 增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr;
    }
}

