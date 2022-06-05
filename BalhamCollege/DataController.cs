using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalhamCollege
{
    public partial class DataController : Form
    { // set up global variables 
        public DataTable dtAssessment;
        public DataTable dtAssignment;
        public DataTable dtCourse;
        public DataTable dtEnrolment;
        public DataTable dtIssue;
        public DataTable dtLecturer;
        public DataTable dtProgramme;
        public DataTable dtResearchProject;
        public DataTable dtResearchTopic;
        public DataTable dtResult;
        public DataTable dtStudent;

        public DataView assessmentView;
        public DataView assignmentView;
        public DataView courseView;
        public DataView enrolmentView;
        public DataView issueView;
        public DataView lecturerView;
        public DataView programmeView;
        public DataView researchProjectview;
        public DataView researchTopicView;
        public DataView resultView;
        public DataView studentView;

        public DataController()
        {
            InitializeComponent();
            dsBalhamCollegeAzure.EnforceConstraints = false;

            daAssessment.Fill(dsBalhamCollegeAzure);
            daAssignment.Fill(dsBalhamCollegeAzure);
            daCourse.Fill(dsBalhamCollegeAzure);
            daEnrolment.Fill(dsBalhamCollegeAzure);
            daIssue.Fill(dsBalhamCollegeAzure);
            daLecturer.Fill(dsBalhamCollegeAzure);
            daProgramme.Fill(dsBalhamCollegeAzure);
            daResearchProject.Fill(dsBalhamCollegeAzure);
            daResearchTopic.Fill(dsBalhamCollegeAzure);
            daResult.Fill(dsBalhamCollegeAzure);
            daStudent.Fill(dsBalhamCollegeAzure);
          
            // set up table instances
            dtAssessment = dsBalhamCollegeAzure.ASSESSMENT;
            dtAssignment = dsBalhamCollegeAzure.ASSIGNMENT;
            dtCourse = dsBalhamCollegeAzure.COURSE;
            dtEnrolment = dsBalhamCollegeAzure.ENROLMENT;
            dtIssue = dsBalhamCollegeAzure.ISSUE;
            dtLecturer = dsBalhamCollegeAzure.LECTURER;
            dtProgramme = dsBalhamCollegeAzure.PROGRAMME;
            dtResearchProject = dsBalhamCollegeAzure.RESEARCHPROJECT;
            dtResearchTopic= dsBalhamCollegeAzure.RESEARCHTOPIC;
            dtResult = dsBalhamCollegeAzure.RESULT;
            dtStudent = dsBalhamCollegeAzure.STUDENT;

            // set up the table views
            assessmentView = new DataView(dtAssessment);
            assessmentView.Sort = "AssessmentID";
            assignmentView = new DataView(dtAssignment);
            assignmentView.Sort = "CourseID,LecturerID";
            courseView = new DataView(dtCourse);
            courseView.Sort = "CourseID";
            enrolmentView = new DataView(dtEnrolment);
            enrolmentView.Sort = "EnrolmentID";
            issueView = new DataView(dtIssue);
            issueView.Sort = "IssueID";
            lecturerView = new DataView(dtLecturer);
            lecturerView.Sort = "LecturerID";
            programmeView = new DataView(dtProgramme);
            programmeView.Sort = "ProgrammeID";
            researchProjectview = new DataView(dtResearchProject);
            researchProjectview.Sort = "ResearchProjectID";
            researchTopicView = new DataView(dtResearchTopic);
            researchTopicView.Sort = "TopicID";
            resultView = new DataView(dtResult);
            resultView.Sort = "AssessmentID,EnrolmentID";
            studentView = new DataView(dtStudent);
            studentView.Sort = "StudentID";

            dsBalhamCollegeAzure.EnforceConstraints = true;
        }

        private void aSSESSMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aSSESSMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBalhamCollegeAzure);

        }

        private void DataController_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dsBalhamCollegeAzure.STUDENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESULT' table. You can move, or remove it, as needed.
            this.rESULTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESULT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHTOPIC' table. You can move, or remove it, as needed.
            this.rESEARCHTOPICTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHTOPIC);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.RESEARCHPROJECT' table. You can move, or remove it, as needed.
            this.rESEARCHPROJECTTableAdapter.Fill(this.dsBalhamCollegeAzure.RESEARCHPROJECT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.dsBalhamCollegeAzure.PROGRAMME);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.LECTURER' table. You can move, or remove it, as needed.
            this.lECTURERTableAdapter.Fill(this.dsBalhamCollegeAzure.LECTURER);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ISSUE' table. You can move, or remove it, as needed.
            this.iSSUETableAdapter.Fill(this.dsBalhamCollegeAzure.ISSUE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ENROLMENT' table. You can move, or remove it, as needed.
            this.eNROLMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ENROLMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dsBalhamCollegeAzure.COURSE);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSIGNMENT' table. You can move, or remove it, as needed.
            this.aSSIGNMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSIGNMENT);
            // TODO: This line of code loads data into the 'dsBalhamCollegeAzure.ASSESSMENT' table. You can move, or remove it, as needed.
            this.aSSESSMENTTableAdapter.Fill(this.dsBalhamCollegeAzure.ASSESSMENT);

        }

        public void UpdateAssessment()
        {
            daAssessment.Update(dsBalhamCollegeAzure, "ASSESSMENT"); // Update Assessment table in the Balham College Database

        }

        public void UpdateAssignment()
        {
            daAssignment.Update(dsBalhamCollegeAzure, "ASSIGNMENT"); // Update Assignment table in the Balham College Database

        }

        public void UpdateCourse()
        {
            daCourse.Update(dsBalhamCollegeAzure, "COURSE"); // Update Course table in the Balham College Database

        }

        public void UpdateEnrolment()
        {
            daEnrolment.Update(dsBalhamCollegeAzure, "ENROLMENT"); // Update Enrolment table in the Balham College Database

        }
        public void UpdateIssue()
        {
            daIssue.Update(dsBalhamCollegeAzure, "ISSUE"); // Update Issue table in the Balham College Database

        }

        public void UpdateLecturer()
        {
            daLecturer.Update(dsBalhamCollegeAzure, "LECTURER"); // Update Lecturer table in the Balham College Database

        }

        public void UpdateProgramme()
        {
            daProgramme.Update(dsBalhamCollegeAzure, "PROGRAMME"); // Update Programme table in the Balham College Database

        }

        public void UpdateResearchProject()
        {
            daResearchProject.Update(dsBalhamCollegeAzure, "RESEARCHPROJECT"); // Update ResearchProject table in the Balham College Database

        }

        public void UpdateResearchTopic()
        {
            daResearchTopic.Update(dsBalhamCollegeAzure, "RESEARCHTOPIC"); // Update ResearchTopic table in the Balham College Database

        }

        public void UpdateResult()
        {
            daResult.Update(dsBalhamCollegeAzure, "RESULT"); // Update Result table in the Balham College Database

        }

        public void UpdateStudent()
        {
            daStudent.Update(dsBalhamCollegeAzure, "STUDENT"); // Update Student table in the Balham College Database

        }
    }
}
