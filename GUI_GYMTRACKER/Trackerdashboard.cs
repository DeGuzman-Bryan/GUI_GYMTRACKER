using GUI_GYMTRACKER.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_GYMTRACKER
{
    public partial class TrackerDashboard : Form
    {
        public TrackerDashboard()
        {
            InitializeComponent();
            ReadTrainees();
        }

        private void ReadTrainees()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Program");
            dataTable.Columns.Add("Appointment Date");

            var repo = new TraineeRepository();
            var Trainees = repo.GetTrainee();

            foreach (var trainee in Trainees)
            {
                var row = dataTable.NewRow();

                row["ID"] = trainee.id;
                row["Name"] = trainee.Name;
                row["Email"] = trainee.Email;
                row["Program"] = trainee.Program;
                row["Appointment Date"] = trainee.AppointmentDate;

                dataTable.Rows.Add(row);

            }

            this.traineesTable.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadTrainees();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var val = this.traineesTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;
            int traineeId = int.Parse(val);

            var repo = new TraineeRepository();
            var trainee = repo.GetTrainee(traineeId);

            if (trainee == null) return;

            CreateEditForm form = new CreateEditForm();
            form.EditTrainee(trainee);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadTrainees();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var val = this.traineesTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;
            int traineeId = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete the trainee?",
                "Delete Client", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new TraineeRepository();
            repo.DeleteTrainee(traineeId);
            ReadTrainees() ;
        }
    }
}