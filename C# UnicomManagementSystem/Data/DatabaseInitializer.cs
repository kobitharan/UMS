using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace C__UnicomManagementSystem.Data
{
    internal class DatabaseInitializer
    {


        public static void CreateTables()
        {
            using (var conn = DataBasecon.GetConnection())
            {
               // Make sure connection is open

                string[] tableCommands =
                {
            // Single SQL statements
            @"CREATE TABLE IF NOT EXISTS Users_Table (
                UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                UserName TEXT NOT NULL,
                Password TEXT NOT NULL,
                Status TEXT NOT NULL,
                ALLID TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS Course_Table (
                CourseId INTEGER PRIMARY KEY AUTOINCREMENT,
                CourseName TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS Subject_Table (
                SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                SubjectName TEXT NOT NULL,
                CourseId INTEGER,
                FOREIGN KEY (CourseId) REFERENCES Course_Table(CourseId)
            );",

            @"CREATE TABLE IF NOT EXISTS Lecturer_Table (
                LecturerId INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                Address TEXT NOT NULL,
                NIC TEXT NOT NULL,
                ContactNO INTEGER NOT NULL,
                Specialization TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS Batch_Table (
                BatchId INTEGER PRIMARY KEY AUTOINCREMENT,
                BatchName TEXT NOT NULL,
                StartDate TEXT NOT NULL,
                EndDate TEXT NOT NULL,
                CourseId INTEGER,
                FOREIGN KEY (CourseId) REFERENCES Course_Table(CourseId)
            );",

            @"CREATE TABLE IF NOT EXISTS Students_Table (
                StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                StudentFullName TEXT NOT NULL,
                StudentAddress TEXT NOT NULL,
                ContactNO TEXT NOT NULL,
                StudentNIC TEXT NOT NULL,
                BatchId INTEGER,
                CourseId INTEGER,
                FOREIGN KEY (BatchId) REFERENCES Batch_Table(BatchId),
                FOREIGN KEY (CourseId) REFERENCES Course_Table(CourseId)
            );",

            @"CREATE TABLE IF NOT EXISTS NIC_Table (
                NICId INTEGER PRIMARY KEY AUTOINCREMENT,
                NIC TEXT NOT NULL,
                Role TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS Room_Table (
                RoomId INTEGER PRIMARY KEY AUTOINCREMENT,
                RoomName TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS Admin_Table (
                AdminId INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                Address TEXT NOT NULL,
                NIC TEXT NOT NULL,
                ContactNO INTEGER NOT NULL,
                Specialization TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS Staff_Table (
                StaffId INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                NIC TEXT NOT NULL,
                Address TEXT NOT NULL,
                ContactNO TEXT NOT NULL,
                Specialization TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS StudentAttendance_Table (
                AttendanceId INTEGER PRIMARY KEY AUTOINCREMENT,
                Month TEXT NOT NULL,
                Percentage TEXT NOT NULL,
                StudentId INTEGER,
                FOREIGN KEY (StudentId) REFERENCES Students_Table(StudentId)
            );",

            @"CREATE TABLE IF NOT EXISTS StaffAttendance_Table (
                AttendanceId INTEGER PRIMARY KEY AUTOINCREMENT,
                Month TEXT NOT NULL,
                Percentage TEXT NOT NULL,
                StaffId INTEGER,
                FOREIGN KEY (StaffId) REFERENCES Staff_Table(StaffId)
            );",

            @"CREATE TABLE IF NOT EXISTS Exam_Table (
                ExamId INTEGER PRIMARY KEY AUTOINCREMENT,
                Ditals TEXT NOT NULL,
                Date TEXT NOT NULL,
                StartTime TEXT NOT NULL,
                EndTime TEXT NOT NULL,
                SubjectId INTEGER,
                BatchId INTEGER,
                CourseId INTEGER,
                RoomId INTEGER,
                FOREIGN KEY (CourseId) REFERENCES Course_Table(CourseId),
                FOREIGN KEY (SubjectId) REFERENCES Subject_Table(SubjectId),
                FOREIGN KEY (BatchId) REFERENCES Batch_Table(BatchId),
                FOREIGN KEY (RoomId) REFERENCES Room_Table(RoomId)
            );",

            @"CREATE TABLE IF NOT EXISTS ExamMark_Table (
                MarkId INTEGER PRIMARY KEY AUTOINCREMENT,
                Mark INTEGER NOT NULL,
                ExamId INTEGER NOT NULL,
                Rank TEXT NOT NULL,
                StudentId INTEGER,
                CourseId INTEGER,
                SubjectId INTEGER,
                BatchId INTEGER,
                FOREIGN KEY (StudentId) REFERENCES Students_Table(StudentId),
                FOREIGN KEY (CourseId) REFERENCES Course_Table(CourseId),
                FOREIGN KEY (BatchId) REFERENCES Batch_Table(BatchId),
                FOREIGN KEY (SubjectId) REFERENCES Subject_Table(SubjectId),
                FOREIGN KEY (ExamId) REFERENCES Exam_Table(ExamId)
            );",

            @"CREATE TABLE IF NOT EXISTS Time_Table (
                TimeTableId INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT NOT NULL,
                StartTime TEXT NOT NULL,
                EndTime TEXT NOT NULL,
                BatchId INTEGER,
                CourseId INTEGER,
                SubjectId INTEGER,
                RoomId INTEGER,
                LecturerId INTEGER,
                FOREIGN KEY (CourseId) REFERENCES Course_Table(CourseId),
                FOREIGN KEY (BatchId) REFERENCES Batch_Table(BatchId),
                FOREIGN KEY (SubjectId) REFERENCES Subject_Table(SubjectId),
                FOREIGN KEY (RoomId) REFERENCES Room_Table(RoomId),
                FOREIGN KEY (LecturerId) REFERENCES Lecturer_Table(LecturerId)
            );",

            @"CREATE TABLE IF NOT EXISTS AddStudent_Table (
                AddId INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                NIC TEXT NOT NULL,
                Address TEXT NOT NULL,
                ContactNO TEXT NOT NULL,
                CourseId INTEGER NOT NULL,
                UserName TEXT NOT NULL,
                Password TEXT NOT NULL,
                BatchId INTEGER NOT NULL,
                FOREIGN KEY (BatchId) REFERENCES Batch_Table(BatchId),
                FOREIGN KEY (CourseId) REFERENCES Course_Table(CourseId)
            );",

            @"CREATE TABLE IF NOT EXISTS Add_Table (
                AddId INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                NIC TEXT NOT NULL,
                Address TEXT NOT NULL,
                ContactNO TEXT NOT NULL,
                Role TEXT NOT NULL,
                UserName TEXT NOT NULL,
                Password TEXT NOT NULL,
                Specialization TEXT NOT NULL
            );",

            @"CREATE TABLE IF NOT EXISTS Manager_Table (
                StaffManagerId INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                NIC TEXT NOT NULL,
                Address TEXT NOT NULL,
                ContactNO TEXT NOT NULL,
                Specialization TEXT NOT NULL
            );"
        };

                foreach (var tableSql in tableCommands)
                {
                    using (var cmd = new SQLiteCommand(tableSql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
