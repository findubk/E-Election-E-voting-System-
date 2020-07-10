using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Election_Project
{
    class Voter
    {
       public string firstName, lastName, Cnic, Provience, Email, dob, PhoneNo, Constituency, address,password,Re_password,Eligibility,Status,Vote,Pic_path;

        public string FIRST_NAME
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LAST_NAME
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string CNIC
        {
            get { return Cnic; }
            set { Cnic = value; }
        }
        public string PROVIENCE
        {
            get { return Provience; }
            set { Provience = value; }
        }
        public string EMAIL_ID
        {
            get { return Email; }
            set { Email = value; }
        }
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public string PHONE_NO
        {
            get { return PhoneNo; }
            set { PhoneNo = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        public string CONSTITUENCY
        {
            get { return Constituency; }
            set { Constituency = value; }
        }
        public string ELIGIBILITY
        {
            get { return Eligibility; }
            set { Eligibility = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        public string RE_PASSWORD
        {
            get { return Re_password; }
            set { Re_password = value; }
        }

        public string STATUS
        {
            get { return Status; }
            set { Status = value; }
        }

        public string VOTE
        {
            get { return Vote; }
            set { Vote = value; }
        }

        public string PICPATH
        {
            get { return Pic_path; }
            set { Pic_path = value; }
        }
    }
}
