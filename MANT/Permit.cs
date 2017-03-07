using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANT
{
    partial class Permit
    {
        private int id;
        private string permit_type, club_name, applicant_name, track_name;
        private DateTime permit_start_date, permit_end_date;

        public Permit(int id, string permit_type, string club_name, string applicant_name, string track_name, 
            DateTime permit_start_date, DateTime permit_end_date)
        {
            this.id = id;
            this.permit_type = permit_type;
            this.club_name = club_name;
            this.applicant_name = applicant_name;
            this.track_name = track_name;
            this.permit_start_date = permit_start_date;
            this.permit_end_date = permit_end_date;
        }

        public int getId()
        {
            return id;
        }

        public string getPermitType()
        {
            return permit_type;
        }

        public string getClubName()
        {
            return club_name;
        }

        public string getApplicantName()
        {
            return applicant_name;
        }

        public string getTrackName()
        {
            return track_name;
        }

        public DateTime getStartDate()
        {
            return permit_start_date;
        }

        public DateTime getEndDate()
        {
            return permit_end_date;
        }
    }
}
