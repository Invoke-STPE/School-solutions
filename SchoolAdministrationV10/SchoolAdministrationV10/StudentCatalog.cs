using System.Collections.Generic;

namespace SchoolAdministrationV10
{
    /// <summary>
    /// This class represents a collection of students,
    /// for instance students attending a school
    /// </summary>
    public class StudentCatalog
    {
        #region Instance fields
        private Dictionary<int, Student> _students;
        #endregion

        #region Constructor
        public StudentCatalog()
        {
            _students = new Dictionary<int, Student>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Return the number of students in the catalog.
        /// </summary>
        public int Count
        {
            get { return _students.Count; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add a single student to the catalog.
        /// </summary>
        public void AddStudent(Student aStudent)
        {
            _students.Add(aStudent.ID, aStudent);
        }

        /// <summary>
        /// Given an id, return the student with that id.
        /// If no student exists with the given id, return null.
        /// </summary>
        public Student GetStudent(int id)
        {
            Student student = null;
            if (_students.ContainsKey(id))
            {
                student = _students[id];
            }
            return student;
        }

        /// <summary>
        /// Given an id, return the score average for the student with that id.
        /// If no student exists with the given id, return -1.
        /// </summary>
        public int GetAverageForStudent(int id)
        {
            int student = -1;
            if (_students.ContainsKey(id))
            {
                student = _students[id].ScoreAverage;
            }
            return student;
        }

        /// <summary>
        /// Returns the total test score average for ALL students in the catalog.
        /// Note that only students with a "real" score average (i.e. NOT -1) should
        /// be included in the calculation of the average.
        /// </summary>
        public int GetTotalAverage()
        {
            int sum = 0;
            int count = 0;
            foreach (var student in _students)
            {
                int studentScore = GetAverageForStudent(student.Key);
                if (studentScore != -1)
                {
                    sum += studentScore;
                    count++;
                }
            }
            sum = sum / count;
            return sum;
        } 
        #endregion
    }
}