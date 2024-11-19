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
    public partial class Trackerdashboard : Form
    {
        public Trackerdashboard()
        {
            InitializeComponent();
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
        }
    }
}