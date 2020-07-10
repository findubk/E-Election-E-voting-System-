using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Election_Project
{
    class Candidate
    {
        string firstName, lastName, cnic, provience, constituency, photoPath, party;
        int VoteCount;
        public string FIRSTNAME
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LASTNAME
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string CNIC
        {
            get { return cnic; }
            set { cnic = value; }
        }

        public string PROVIENCE
        {
            get { return provience; }
            set { provience = value; }
        }

        public string CONSTITUENCY
        {
            get { return constituency; }
            set { constituency = value; }
        }
        public string PARTY
        {
            get { return party; }
            set { party = value; }
        }
        public int VOTECOUNT
        {
            get { return VoteCount; }
            set { VoteCount = value; }
        }
        public string PHOTOPATH
        {
            get { return photoPath; }
            set { photoPath = value; }
        }
    }
}
