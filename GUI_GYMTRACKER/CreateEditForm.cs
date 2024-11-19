using GUI_GYMTRACKER.Models;
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
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private int traineeId = 0;
        public void EditTrainee(Trainee trainee)
        {
            this.Text = "Edit Trainee";
            this.label1.Text = "Edit Trainee";

            this.label2.Text = "" + trainee.id;
            this.tbName.Text = trainee.Name;
            this.tbEmail.Text = trainee.Email;
            this.tbProgram.Text = trainee.Program;
            this.tbDate.Text = trainee.AppointmentDate;

            this.traineeId = trainee.id;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            Trainee trainee = new Trainee();
            trainee.id = this.traineeId;
            trainee.Name = this.tbName.Text;
            trainee.Email = this.tbEmail.Text;
            trainee.Program = this.tbProgram.Text;
            trainee.AppointmentDate = this.tbDate.Text;

            var repo = new TraineeRepository();

            if (trainee.id == 0)
            {
                repo.CreateTrainee(trainee);
            }
            else
            {
                repo.UpdateTrainee(trainee);
            }
            repo.CreateTrainee(trainee);

            this.DialogResult = DialogResult.OK;


        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
