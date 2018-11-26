using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Lable 값 매칭

            //DataGrid 매칭
            CurrentBooks.DataSource = DataManager.DataManager.bookList;
            CurrentUsers.DataSource = DataManager.DataManager.userList;
            totalBook.Text = DataManager.DataManager.bookList.Count().ToString();
            totalUser.Text = DataManager.DataManager.userList.Count().ToString();
            totalBorrowedBook.Text = "0";
            totalOverdueBook.Text = "0";
            CurrentBooks.CurrentCellChanged += CurrentBooksView_CurrentCellChanged; //이 폼에 대해서 변화시 새로운 람다식을 추가한다.
        }

        private void CurrentBooksView_CurrentCellChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookForm().Show();
        }

        private void 유저관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
        }
    }
}
