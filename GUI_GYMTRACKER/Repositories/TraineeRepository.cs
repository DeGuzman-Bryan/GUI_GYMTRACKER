 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_GYMTRACKER.Models;
using Microsoft.Data.SqlClient;

namespace GUI_GYMTRACKER.Repositories
{
    public class TraineeRepository
    {
        private readonly string connectionString = "Data Source=DESKTOP-6G5SLJF\\SQLEXPRESS;Initial Catalog=GUI;Integrated Security=True;Trust Server Certificate=True";

        public List<Trainee> GetTrainee()
        {
            var trainee = new List<Trainee>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Trainees ORDER by id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Trainee trainee1 = new Trainee();
                                trainee1.id = reader.GetInt32(0);
                                trainee1.Name = reader.GetString(1);
                                trainee1.Email = reader.GetString(2);
                                trainee1.Program = reader.GetString(3);
                                trainee1.AppointmentDate = reader.GetString(4);

                                trainee.Add(trainee1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: " + ex.ToString());
            }
            return trainee;

        }
        public Trainee? GetTrainee(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Trainees WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Trainee trainee1 = new Trainee();
                                trainee1.id = reader.GetInt32(0);
                                trainee1.Name = reader.GetString(1);
                                trainee1.Email = reader.GetString(2);
                                trainee1.Program = reader.GetString(3);
                                trainee1.AppointmentDate = reader.GetString(4);

                                return trainee1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());

            }
            
            return null;
        }

        public void CreateTrainee(Trainee trainee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Trainees " +
                                 "(Name, Email, Program, AppointmentDate) VALUES" +
                                 "(@Name, @Email, @Program, @AppointmentDate);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", trainee.Name);
                        command.Parameters.AddWithValue("@Email", trainee.Email);
                        command.Parameters.AddWithValue("Program", trainee.Program);
                        command.Parameters.AddWithValue("AppointmentDate", trainee.AppointmentDate);
                        command.ExecuteNonQuery();



                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void  UpdateTrainee (Trainee trainee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Trainees SET Name = @Name, Email = @Email, Program = @Program, AppointmentDate = @AppointmentDate WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", trainee.Name);
                        command.Parameters.AddWithValue("@Email", trainee.Email);
                        command.Parameters.AddWithValue("Program", trainee.Program);
                        command.Parameters.AddWithValue("AppointmentDate", trainee.AppointmentDate);
                        command.Parameters.AddWithValue("@id", trainee.id);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());


            }    
        }

        public void DeleteTrainee(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Trainees WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
} 