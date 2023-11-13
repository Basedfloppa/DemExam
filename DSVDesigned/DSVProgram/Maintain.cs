using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace DSVProgram{
    public partial class Maintain : Form
    {
        private String DATABASE_FileName = @"%PROJECTDIR%";
        private SQLiteConnection DATABASE_Connect;
        private SQLiteCommand DATABASE_Cmd;

        //Первые попытки локализации, очень неправильно, но все же...
        private String STATLOC_Connected = "Подключен";
        private String STATLOC_Disconnected = "Отключен";
        private String STATLOC_Wait = "Ожидание";
        private String STATLOC_Error = "Ошибка";

        public Maintain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DATABASE_Connect = new SQLiteConnection();
            DATABASE_Cmd = new SQLiteCommand();
            DATABASE_FileName = "DBSimple.sqlite";
            lbStatusText.Text = STATLOC_Wait;
        }

        void DBCreate(bool bRunCommands)
        {
            lbStatusText.Text = STATLOC_Wait;
            if (!File.Exists(DATABASE_FileName)) SQLiteConnection.CreateFile(DATABASE_FileName);

            try
            {
                DATABASE_Connect = new SQLiteConnection("Data Source=" + DATABASE_FileName + ";Version=3;");
                DATABASE_Connect.Open();
                DATABASE_Cmd.Connection = DATABASE_Connect;

                if (bRunCommands)
                {
                    DATABASE_Cmd.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, LastName TEXT)";
                    DATABASE_Cmd.ExecuteNonQuery();
                }

                lbStatusText.Text = STATLOC_Connected;
            }
            catch (SQLiteException exec)
            {
                lbStatusText.Text = STATLOC_Disconnected;
                MessageBox.Show(STATLOC_Error + ": " + exec.Message);
            }
        }

        void DBConnect()
        {
            if (!File.Exists(DATABASE_FileName)) MessageBox.Show("Пожалуйста, создайте БД и пустую таблицу (нажмите кнопку «Создать»)");
            DBCreate(false);
        }

        void DBRead()
        {
            String SQLRequest = "";
            DataTable DBTable = new DataTable();

            if (DATABASE_Connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Откройте соединение с базой данных");
                return;
            }

            try
            {
                SQLRequest = "SELECT * FROM Catalog";
                SQLiteDataAdapter SQLAdapt = new SQLiteDataAdapter(SQLRequest, DATABASE_Connect);
                SQLAdapt.Fill(DBTable);

                if (DBTable.Rows.Count > 0)
                {
                    DIAGViewer.Rows.Clear();

                    for (int i = 0; i < DBTable.Rows.Count; i++)
                    {
                        DIAGViewer.Rows.Add(DBTable.Rows[i].ItemArray);
                    }
                }
                else MessageBox.Show("База данных пуста");
            }
            catch (SQLiteException exec)
            {
                MessageBox.Show(STATLOC_Error + ": " + exec.Message);
            }
        }

        void DBAdd()
        {
            if (DATABASE_Connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Откройте соединение с базой данных");
                return;
            }

            Auth addData = new Auth();

            if (addData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //DATABASE_Cmd.CommandText = "INSERT INTO Catalog ('Name', 'LastName') values ('" + addData.Login + "' , '" + addData.Book + "')";
                    DATABASE_Cmd.ExecuteNonQuery();
                }
                catch (SQLiteException exec)
                {
                    MessageBox.Show(STATLOC_Error + ": " + exec.Message);
                }
            }
        }






        private void btCreate_Click(object sender, EventArgs e)
        {
            DBCreate(true);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            DBConnect();
        }

        private void btReadAll_Click(object sender, EventArgs e)
        {
            DBRead();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DBAdd();
        }

        private void btClearTable_Click(object sender, EventArgs e)
        {
            DIAGViewer.Rows.Clear();
        }
    }
}
