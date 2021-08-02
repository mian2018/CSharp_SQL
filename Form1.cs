using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL
{
    public partial class Form1 : Form
    {
        int PageMax = 1;
        int PageSize = 3;
        int _currentPage = 1;
        int CurrentPage
        {
            get { return _currentPage; }
            set 
            {
                //sql 语句 查询行数
                string sql = "select count(*) from studentInfoTable";

                //执行sql语句
                PageMax = (int)MySqlHelper.ExecuteScalar(sql);
                PageMax = (PageMax + PageSize - 1) / PageSize;
                if (value < 1)
                {
                    _currentPage = PageMax;
                }
                else if(value > PageMax)
                {
                    _currentPage = 1;
                }
                else
                {
                    _currentPage = value;
                }

                txbPage.Text = _currentPage.ToString()+"/"+PageMax.ToString();

                //sql 语句
                sql = "exec GetStudentInfoPage @page, @size";

                //sql 语句参数
                SqlParameter page = new SqlParameter("@page", _currentPage);
                SqlParameter pageSize = new SqlParameter("@size", PageSize);

                //执行sql语句
                DataTable dt = MySqlHelper.ExecuteTable(sql, page, pageSize);

                //为GridView的列绑定数据源  也就是将dataGridViewSQL的列和 sql查出来表的列名绑定起来
                dataGridViewSQL.Columns[0].DataPropertyName = "学生编号";
                dataGridViewSQL.Columns[1].DataPropertyName = "姓名";
                dataGridViewSQL.Columns[2].DataPropertyName = "性别";
                dataGridViewSQL.Columns[3].DataPropertyName = "班级";
                dataGridViewSQL.Columns[4].DataPropertyName = "家庭地址";

                //禁止自动创建列
                dataGridViewSQL.AutoGenerateColumns = false;

                //绑定数据源
                dataGridViewSQL.DataSource = dt;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //开启表格的双缓冲，避免闪烁
            MyDataGridViewDoubleBuffer.SetDoubleBuffered(dataGridViewSQL, true);

            //设置数据库连接字符串
            //Serever: 表示要连接的SQL Server 服务端所在的机器(可以是ip, 可以是hostname)  . 代表本机
            //Database: 数据库名称
            //User Id:  用户名
            //Password: 密码
            //Connection Timeout: 链接超时时间
            MySqlHelper.conStr = "Data Source = .;Database = TestDB; User Id = sa; Password= 12345678; Connection Timeout = 5;";

            CurrentPage = 1;
        }

        private void labFrontPage_Click(object sender, EventArgs e)
        {
            CurrentPage -= 1;
        }

        private void labBackPage_Click(object sender, EventArgs e)
        {
            CurrentPage += 1;
        }

        private void txbPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentPage = int.Parse(txbPage.Text);
            }
            catch
            {

            }
        }

        private void txbPage_MouseDown(object sender, MouseEventArgs e)
        {
            txbPage.SelectAll();
        }

        private void 增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL formSQL = new FormSQL((int)dataGridViewSQL.SelectedRows[0].Cells[0].Value, (string)dataGridViewSQL.SelectedRows[0].Cells[1].Value, (string)dataGridViewSQL.SelectedRows[0].Cells[2].Value, (string)dataGridViewSQL.SelectedRows[0].Cells[3].Value);
            formSQL.Text = "增/改数据";
            formSQL.ShowDialog();

            //刷新
            CurrentPage = CurrentPage;
        }

        private void 删ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewSQL.SelectedRows)
            {
                //sql 语句
                string sql = "delete from studentTable where studentTable.id = @id";

                //sql 语句参数
                SqlParameter id = new SqlParameter("@id", item.Cells[0].Value);

                //执行sql语句
                DataTable dt = MySqlHelper.ExecuteTable(sql, id);

                //刷新
                CurrentPage = CurrentPage;
            }
        }
    }
}
