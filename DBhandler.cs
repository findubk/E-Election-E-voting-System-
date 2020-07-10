using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace E_Election_Project
{
    class DBhandler
    {
        static SqlConnection myConnection;
        public static void openConnection()
        {
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\C# E-Election Project\User Control\E-Election_Project\E-Election_Project\E_Election_Project_Database.mdf;Integrated Security=True";

            try
            {
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }
        //Adding voter cridentials to database
        static public void insertIntoVoter(Voter voter)
        {

            try
            {
                openConnection();
                string querry_voter = "insert into Voter(Cnic,Fname,Lname,DOB,Email,PhoneNO,Address,Provience,Password,Eligibility,Constituency,Status,Image)values ('" + voter.CNIC + "','" + voter.FIRST_NAME + "','" + voter.LAST_NAME+ "','" + voter.DOB+ "','" + voter.EMAIL_ID + "' ,'" + voter.PHONE_NO + "','" + voter.ADDRESS + "','" + voter.PROVIENCE + "','" + voter.PASSWORD + "','" + voter.ELIGIBILITY + "','" + voter.CONSTITUENCY + "','" + voter.STATUS + "','" + voter.PICPATH + "')";
                SqlCommand command = new SqlCommand(querry_voter, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data saved");
                myConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Adding Candidate cridentials to database
        static public void insertIntoCandidate(Candidate candidate)
        {

            try
            {
                openConnection();
                string querry_candidate = "insert into Candidate(Cnic,Fname,Lname,Constituency,Party,Provience,Image,VoteCount)values ('" + candidate.CNIC + "','" + candidate.FIRSTNAME + "','" + candidate.LASTNAME + "','" + candidate.CONSTITUENCY + "','" + candidate.PARTY + "' ,'" + candidate.PROVIENCE + "','" + candidate.PHOTOPATH + "','" + candidate.VOTECOUNT + "')";
                SqlCommand command = new SqlCommand(querry_candidate, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data saved");
                myConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Voter search with CNIC
        static public List<Voter> GetVoterwithCNIC(string CNIC)
        {
            List<Voter> voter = new List<Voter>();
            openConnection();
            string querry = "select * from Voter";
            SqlCommand command = new SqlCommand(querry, myConnection);
            SqlDataReader mydata = command.ExecuteReader();
            string key;
            Voter v = null;
            while (mydata.Read())
            {
                key = mydata["Cnic"].ToString();
                if (CNIC.Equals(key))
                {
                    v = new Voter();
                    v.CNIC = mydata["Cnic"].ToString();
                    v.FIRST_NAME = mydata["Fname"].ToString();
                    v.LAST_NAME = mydata["Lname"].ToString();
                    v.DOB = mydata["DOB"].ToString();
                    v.PROVIENCE = mydata["Provience"].ToString();
                    v.ELIGIBILITY = mydata["Eligibility"].ToString();
                    v.PHONE_NO = mydata["PhoneNo"].ToString();
                    v.ADDRESS = mydata["Address"].ToString();
                    v.EMAIL_ID = mydata["Email"].ToString();
                    v.PASSWORD = mydata["Password"].ToString();
                    v.CONSTITUENCY = mydata["Constituency"].ToString();
                    v.STATUS = mydata["Status"].ToString();
                    v.VOTE = mydata["Vote"].ToString();
                    v.PICPATH = mydata["Image"].ToString();
                    voter.Add(v);
                }
            }
            myConnection.Close();
            return voter;
        }
        //Voter List with pending Eligibility
        static public List<Voter> GetVoterPendingEligibilty()
        {
            List<Voter> voter = new List<Voter>();
            openConnection();
            string querry= "select * from Voter";
            SqlCommand command = new SqlCommand(querry, myConnection);
            SqlDataReader mydata = command.ExecuteReader();
            string Eligibility;
            Voter v=null;
            while (mydata.Read())
            {
                Eligibility = mydata["Eligibility"].ToString();
                if (Eligibility.Equals("Pending"))
                {
                    v = new Voter();
                    v.CNIC = mydata["Cnic"].ToString();
                    v.FIRST_NAME = mydata["Fname"].ToString();
                    v.LAST_NAME = mydata["Lname"].ToString();
                    v.DOB = mydata["DOB"].ToString();
                    v.PROVIENCE = mydata["Provience"].ToString();
                    v.ELIGIBILITY = mydata["Eligibility"].ToString();
                    v.PHONE_NO = mydata["PhoneNo"].ToString();
                    v.ADDRESS = mydata["Address"].ToString();
                    v.EMAIL_ID = mydata["Email"].ToString();
                    v.PASSWORD = mydata["Password"].ToString();
                    v.CONSTITUENCY = mydata["Constituency"].ToString();
                    v.STATUS = mydata["Status"].ToString();
                    v.VOTE = mydata["Vote"].ToString();
                    v.PICPATH = mydata["Image"].ToString();
                    voter.Add(v);
                }
            }
            myConnection.Close();
            return voter;
        }

        //Voter List with Eligible Voter
        static public List<Voter> GetVoterEligible()
        {
            List<Voter> voter = new List<Voter>();
            openConnection();
            string querry = "select * from Voter";
            SqlCommand command = new SqlCommand(querry, myConnection);
            SqlDataReader mydata = command.ExecuteReader();
            string Eligibility;
            Voter v = null;
            while (mydata.Read())
            {
                Eligibility = mydata["Eligibility"].ToString();
                if (Eligibility.Equals("Eligible"))
                {
                    v = new Voter();
                    v.CNIC = mydata["Cnic"].ToString();
                    v.FIRST_NAME = mydata["Fname"].ToString();
                    v.LAST_NAME = mydata["Lname"].ToString();
                    v.DOB = mydata["DOB"].ToString();
                    v.PROVIENCE = mydata["Provience"].ToString();
                    v.ELIGIBILITY = mydata["Eligibility"].ToString();
                    v.PHONE_NO = mydata["PhoneNo"].ToString();
                    v.ADDRESS = mydata["Address"].ToString();
                    v.EMAIL_ID = mydata["Email"].ToString();
                    v.PASSWORD = mydata["Password"].ToString();
                    v.CONSTITUENCY = mydata["Constituency"].ToString();
                    v.STATUS = mydata["Status"].ToString();
                    v.VOTE = mydata["Vote"].ToString();
                    v.PICPATH = mydata["Image"].ToString();
                    voter.Add(v);
                }
            }
            myConnection.Close();
            return voter;
        }

        //Voter List with  In-Eligibility
        static public List<Voter> GetVoterIneligible()
        {
            List<Voter> voter = new List<Voter>();
            openConnection();
            string querry = "select * from Voter";
            SqlCommand command = new SqlCommand(querry, myConnection);
            SqlDataReader mydata = command.ExecuteReader();
            string Eligibility;
            Voter v = null;
            while (mydata.Read())
            {
                Eligibility = mydata["Eligibility"].ToString();
                if (Eligibility.Equals("Ineligible"))
                {
                    v = new Voter();
                    v.CNIC = mydata["Cnic"].ToString();
                    v.FIRST_NAME = mydata["Fname"].ToString();
                    v.LAST_NAME = mydata["Lname"].ToString();
                    v.DOB = mydata["DOB"].ToString();
                    v.PROVIENCE = mydata["Provience"].ToString();
                    v.ELIGIBILITY = mydata["Eligibility"].ToString();
                    v.PHONE_NO = mydata["PhoneNo"].ToString();
                    v.ADDRESS = mydata["Address"].ToString();
                    v.EMAIL_ID = mydata["Email"].ToString();
                    v.PASSWORD = mydata["Password"].ToString();
                    v.CONSTITUENCY = mydata["Constituency"].ToString();
                    v.STATUS = mydata["Status"].ToString();
                    v.VOTE = mydata["Vote"].ToString();
                    v.PICPATH = mydata["Image"].ToString();
                    voter.Add(v);
                }
            }
            myConnection.Close();
            return voter;
        }


        //Voter List
        static public List<Voter> GetVoterList()
        {
            List<Voter> voter = new List<Voter>();
            openConnection();
            string querry = "select * from Voter";
            SqlCommand command = new SqlCommand(querry, myConnection);
            SqlDataReader mydata = command.ExecuteReader();
            Voter v = null;
            while (mydata.Read())
            {
                
                    v = new Voter();
                    v.CNIC = mydata["Cnic"].ToString();
                    v.FIRST_NAME = mydata["Fname"].ToString();
                    v.LAST_NAME = mydata["Lname"].ToString();
                    v.DOB = mydata["DOB"].ToString();
                    v.PROVIENCE = mydata["Provience"].ToString();
                    v.ELIGIBILITY = mydata["Eligibility"].ToString();
                    v.PHONE_NO = mydata["PhoneNo"].ToString();
                    v.ADDRESS = mydata["Address"].ToString();
                    v.EMAIL_ID = mydata["Email"].ToString();
                    v.PASSWORD = mydata["Password"].ToString();
                    v.CONSTITUENCY = mydata["Constituency"].ToString();
                    v.STATUS= mydata["Status"].ToString();
                    v.VOTE= mydata["Vote"].ToString();
                    v.PICPATH = mydata["Image"].ToString();
                voter.Add(v);
                
            }
            myConnection.Close();
            return voter;
        }

        //candiate list
        static public List<Candidate> GetCandidateList()
        {
            List<Candidate> candidate = new List<Candidate>();
            openConnection();
            string querry = "select * from Candidate";
            SqlCommand command = new SqlCommand(querry, myConnection);
            SqlDataReader mydata = command.ExecuteReader();
            Candidate c = null;
            while (mydata.Read())
            {

                c=new Candidate();
                c.CNIC = mydata["Cnic"].ToString();
                c.FIRSTNAME = mydata["Fname"].ToString();
                c.LASTNAME = mydata["Lname"].ToString();
                c.PARTY = mydata["Party"].ToString();
                c.CONSTITUENCY = mydata["Constituency"].ToString();
                c.PROVIENCE= mydata["Provience"].ToString();
                c.VOTECOUNT = Int32.Parse(mydata["VoteCount"].ToString());
                c.PHOTOPATH = mydata["Image"].ToString();
                candidate.Add(c);

            }
            myConnection.Close();
            return candidate;
        }
        //Specific constituency Candidates
        static public List<Candidate> GetSpecficConstituencyCandidateList(string constituency)
        {
            List<Candidate> candidate = new List<Candidate>();
            openConnection();
            string querry = "select * from Candidate";
            SqlCommand command = new SqlCommand(querry, myConnection);
            SqlDataReader mydata = command.ExecuteReader();
            string Key;
            Candidate c = null;
            while (mydata.Read())
            {
                Key = mydata["Constituency"].ToString();
                if (constituency.Equals(Key))
                {
                    c = new Candidate();
                    c.CNIC = mydata["Cnic"].ToString();
                    c.FIRSTNAME = mydata["Fname"].ToString();
                    c.LASTNAME = mydata["Lname"].ToString();
                    c.PARTY = mydata["Party"].ToString();
                    c.CONSTITUENCY = mydata["Constituency"].ToString();
                    c.PROVIENCE = mydata["Provience"].ToString();
                    c.VOTECOUNT = Int32.Parse(mydata["VoteCount"].ToString());
                    c.PHOTOPATH = mydata["Image"].ToString();
                    candidate.Add(c);

                }
            }
            myConnection.Close();
            return candidate;
        }

        static public bool DeleteVoter(string key)
        {
            try
            {
                openConnection();
                string querry_delete_voter = "DELETE FROM Voter WHERE Cnic ='" + key  +"'";
                SqlDataAdapter sql = new SqlDataAdapter(querry_delete_voter, myConnection);
                sql.SelectCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }catch(SqlException)
            {
                return false;
            }
        }

        static public bool DeleteCandidate(string key)
        {
            try
            {
                openConnection();
                string querry_delete_voter = "DELETE FROM Candidate WHERE CNIC ='" + key + "'";
                SqlDataAdapter sql = new SqlDataAdapter(querry_delete_voter, myConnection);
                sql.SelectCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //ADMIN Voter cridential Update

        static public bool SetVoterEligibility(string key,string constituency)
        {
            try
            {
                openConnection();
                string querry_Upadte = "UPDATE Voter SET Eligibility='" + "Eligible" + "' ,Constituency='" + constituency + "' WHERE Cnic='" + key + "'";
                SqlCommand command = new SqlCommand(querry_Upadte, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        static public bool SetVoterINEligibility(string key)
        {
            try
            {
                openConnection();
                string querry_Upadte = "UPDATE Voter SET Eligibility='" + "Ineligible" + "' WHERE Cnic='" + key + "'";
                SqlCommand command = new SqlCommand(querry_Upadte, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        static public bool VoterCast(string key,string Cand_cnic)
        {
            try
            {
                openConnection();
                string querry_Upadte = "UPDATE Voter SET Vote='" + Cand_cnic + "' ,Status='" + "Voted" + "' WHERE Cnic='" + key + "'";
                SqlCommand command = new SqlCommand(querry_Upadte, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
            static public bool SetVoteCount(string key,int count)
            {
                try
                {
                    openConnection();
                    string querry_Upadte = "UPDATE Candidate SET VoteCount='" + count + "' WHERE CNIC='" + key + "'";
                    SqlCommand command = new SqlCommand(querry_Upadte, myConnection);
                    command.ExecuteNonQuery();
                    myConnection.Close();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        

    }
}
