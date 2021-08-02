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
    public partial class FormSQL : Form
    {
        int StudentID = 0;
        DataTable gradeDT, cityDT;

        public FormSQL(int studentID, string name, string gender, string grade)
        {
            InitializeComponent();

            #region 查询数据库 获取省份和班级信息
            //sql 语句
            string sql = "select * from provinceTable";

            //执行sql语句
            DataTable dt = MySqlHelper.ExecuteTable(sql);

            //为combox的列绑定数据源  也就是将combox和 sql查出来表的列名绑定起来
            cmbProvince.DisplayMember = "province";
            //绑定数据源
            cmbProvince.DataSource = dt;

            sql = "select * from gradeTable";

            //执行sql语句
            gradeDT = MySqlHelper.ExecuteTable(sql);

            //为combox的列绑定数据源  也就是将combox和 sql查出来表的列名绑定起来
            cmbStudentGrade.DisplayMember = "name";
            //绑定数据源
            cmbStudentGrade.DataSource = gradeDT;
            #endregion

            txbStudentName.Text = name;
            if(gender == "男")
            {
                radMan.Checked = true;
            }
            else
            {
                radWoman.Checked = true;
            }
            cmbStudentGrade.Text = grade;

            //获取学生地址信息
            sql = "select * from studentMinuteInfoTable where 学生编号 = @id";

            //sql 语句参数
            SqlParameter id = new SqlParameter("@id", studentID);

            //执行sql语句
            dt = MySqlHelper.ExecuteTable(sql, id);

            cmbProvince.Text = (string)dt.Rows[0].ItemArray[4];
            cmbCity.Text = (string)dt.Rows[0].ItemArray[5];

            if(dt.Rows[0].ItemArray[6] != System.DBNull.Value)
                txbStudentAddr.Text = (string)dt.Rows[0].ItemArray[6];

            StudentID = studentID;
        }

        /// <summary>
        /// 省变化时，市信息跟着变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql 语句
            string sql = "exec GetCityInfo @provinceName";

            //sql 语句参数
            SqlParameter provinceName = new SqlParameter("@provinceName", cmbProvince.Text);

            //执行sql语句
            cityDT = MySqlHelper.ExecuteTable(sql, provinceName);

            //为combox的列绑定数据源  也就是将combox和 sql查出来表的列名绑定起来
            cmbCity.DisplayMember = "cityName";
            //绑定数据源
            cmbCity.DataSource = cityDT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //sql 语句
            string sql = "insert into studentTable(gradeID, name, gender, cityID, address) Values(@gradeID, @name, @gender, @cityID, @address)";
            //sql 语句参数
            SqlParameter gradeID = new SqlParameter("@gradeID", gradeDT.Rows[cmbStudentGrade.SelectedIndex].ItemArray[0]);
            SqlParameter name = new SqlParameter("@name", txbStudentName.Text);
            SqlParameter gender;
            if(radMan.Checked)
            {
                gender = new SqlParameter("@gender", true);
            }
            else
            {
                gender = new SqlParameter("@gender", false);
            }

            SqlParameter cityID = new SqlParameter("@cityID", cityDT.Rows[cmbCity.SelectedIndex].ItemArray[0]);
            SqlParameter address = new SqlParameter("@address", txbStudentAddr.Text);

            MySqlHelper.ExecuteNonQuery(sql, gradeID, name, gender, cityID, address);

            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //sql 语句
            string sql = "update studentTable set gradeID = @gradeID, name = @name, gender = @gender, cityID = @cityID, address = @address where id = @id";
            //sql 语句参数
            SqlParameter id = new SqlParameter("@id", StudentID);
            SqlParameter gradeID = new SqlParameter("@gradeID", gradeDT.Rows[cmbStudentGrade.SelectedIndex].ItemArray[0]);
            SqlParameter name = new SqlParameter("@name", txbStudentName.Text);
            SqlParameter gender;
            if (radMan.Checked)
            {
                gender = new SqlParameter("@gender", true);
            }
            else
            {
                gender = new SqlParameter("@gender", false);
            }

            SqlParameter cityID = new SqlParameter("@cityID", cityDT.Rows[cmbCity.SelectedIndex].ItemArray[0]);
            SqlParameter address = new SqlParameter("@address", txbStudentAddr.Text);

            MySqlHelper.ExecuteNonQuery(sql, gradeID, name, gender, cityID, address, id);

            this.Close();
        }
    }
}
