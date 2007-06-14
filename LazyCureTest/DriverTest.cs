using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NMock2;
using LifeIdea.LazyCure.Interfaces;
using System.IO;
using System.Data;

namespace LifeIdea.LazyCure.Core
{
    [TestFixture]
    public class DriverTest
    {
        Driver driver;
        private Mockery mocks;
        private MockWriter mockWriter;
        [SetUp]
        public void SetUp()
        {
            driver = new Driver();
            mocks = new Mockery();
            mockWriter = new MockWriter();
            Log.TextWriter = mockWriter;
        }
        [Test]
        public void SaveTimeLog()
        {
            string folder = @"c:\temp\LazyCure\test\TimeLogs";
            string filename = folder + @"\2007-11-18.timelog";
            if (Directory.Exists(folder))
            {
                Directory.Delete(folder, true);
            }

            ITimeSystem mockTimeSystem = mocks.NewMock<ITimeSystem>();
            Stub.On(mockTimeSystem).GetProperty("Now").Will(Return.Value(DateTime.Parse("2007-11-18 5:00:00")));

            driver = new Driver(mockTimeSystem);
            driver.TimeLogsFolder = folder;
        
            if (driver.SaveTimeLog())
                Assert.Contains(filename, Directory.GetFiles(folder));
            else
                Assert.Fail(mockWriter.Content);
        }
        [Test]
        public void SaveTimeLogSpecifyFileName()
        {
            string folder = @"c:\temp\LazyCure\test\TimeLogs";
            string filename = folder + @"\2007-11-17.timelog";
            if (Directory.Exists(folder))
            {
                Directory.Delete(folder, true);
            }
            ITimeSystem mockTimeSystem = mocks.NewMock<ITimeSystem>();
            Stub.On(mockTimeSystem).GetProperty("Now").Will(Return.Value(DateTime.Parse("2007-11-18 5:00:00")));

            driver = new Driver(mockTimeSystem);

            if (driver.SaveTimeLog(filename))
                Assert.Contains(filename, Directory.GetFiles(folder));
            else
                Assert.Fail(mockWriter.Content);
        }
        [Test]
        public void NullTimeLogs()
        {
            driver.TimeLogsFolder = "";
            Assert.IsFalse(driver.SaveTimeLog());
            Assert.AreEqual("TimeLogsFolder is not specified", mockWriter.Content);
        }
        [Test]
        public void LoadTimeLog()
        {
            string sContent = "<?xml version=\"1.0\" standalone=\"yes\"?><LazyCureData><Records>"+
                "<Activity>changed</Activity><Begin>14:35:02</Begin><Duration>0:00:07</Duration>"+
                "</Records></LazyCureData>";
            DateTime date = DateTime.Parse("2126-11-18");
            string folder = @"c:\temp\LazyCure\test\TimeLogs";
            string filename = folder + @"\2126-11-18.timelog";
            if (File.Exists(filename))
                File.Delete(filename);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            StreamWriter writer = File.CreateText(filename);
            writer.Write(sContent);
            writer.Close();
            driver.TimeLogsFolder = folder;
            Assert.IsTrue(driver.LoadTimeLog(date),"log loaded");
            DataRow row = (driver.TimeLogData as DataTable).Rows[0];
            Assert.AreEqual("changed", row["Activity"],"activity name match");
            Assert.AreEqual(DateTime.Parse("14:35:02"), row["Start"], "start match");
            Assert.AreEqual(TimeSpan.Parse("0:00:07"), row["Duration"], "duration match");
            Assert.AreEqual(date.ToString("yyyy-MM-dd"), driver.TimeLogDate, "current day changed");
        }
        [Test]
        public void LoadSpecifiedTimeLog()
        {
            string sContent = "<?xml version=\"1.0\" standalone=\"yes\"?><LazyCureData><Records>" +
                "<Activity>changed</Activity><Begin>14:35:02</Begin><Duration>0:00:07</Duration>" +
                "</Records></LazyCureData>";
                        
            FileInfo fileInfo = new FileInfo(@"c:\temp\LazyCure\test\TimeLogs\2126-11-18.timelog");
            fileInfo.Directory.Create();
            StreamWriter writer = fileInfo.CreateText();
            writer.Write(sContent);
            writer.Close();
            driver.FinishActivity("should be removed after load","next");
            if (driver.LoadTimeLog(fileInfo.FullName))
            {
                DataRow row = (driver.TimeLogData as DataTable).Rows[0];
                Assert.AreEqual("changed", row["Activity"], "activity name match");
                Assert.AreEqual(DateTime.Parse("14:35:02"), row["Start"], "start match");
                Assert.AreEqual(TimeSpan.Parse("0:00:07"), row["Duration"], "duration match");
                Assert.AreEqual("2126-11-18", driver.TimeLogDate, "current day changed");
            }
            else
                Assert.Fail(mockWriter.Content);
        }
        [Test]
        public void LoadTwoActivites()
        {
            string sContent = "<?xml version=\"1.0\" standalone=\"yes\"?><LazyCureData>"+
                "<Records>"+
                "<Activity>sleep</Activity><Begin>0:00:00</Begin><Duration>5:00:00</Duration>" +
                "</Records>" +
                "<Records>" +
                "<Activity>clean</Activity><Begin>5:00:00</Begin><Duration>0:07:00</Duration>" +
                "</Records>"+
                "</LazyCureData>";
            DateTime date = DateTime.Parse("2025-12-31");
            string folder = @"c:\temp\LazyCure\test\TimeLogs";
            string filename = folder + @"\2025-12-31.timelog";
            if (File.Exists(filename))
                File.Delete(filename);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            StreamWriter writer = File.CreateText(filename);
            writer.Write(sContent);
            writer.Close();
            driver.TimeLogsFolder = folder;
            driver.LoadTimeLog(date);
            DataRow row1 = (driver.TimeLogData as DataTable).Rows[0];
            DataRow row2 = (driver.TimeLogData as DataTable).Rows[1];
            Assert.AreEqual("sleep", row1["Activity"], "activity name match");
            Assert.AreEqual(DateTime.Parse("0:00:00"), row1["Start"], "start match");
            Assert.AreEqual(TimeSpan.Parse("5:00:00"), row1["Duration"], "duration match");
            Assert.AreEqual("clean", row2["Activity"], "activity name match");
            Assert.AreEqual(DateTime.Parse("5:00:00"), row2["Start"], "start match");
            Assert.AreEqual(TimeSpan.Parse("0:07:00"), row2["Duration"], "duration match");
        }
        [Test]
        public void LoadUnexistingLog()
        {
            Assert.IsFalse(driver.LoadTimeLog(DateTime.Parse("2012-03-16")));
        }
        [Test]
        public void LoadBrokenXml()
        {
            string sBrokenContent = "<?xml version=\"1.0\" standalone=\"yes\"?><LazyCureData><Records>" +
                "<Activity>changed<Activity><Begin>14:35:02</Begin><Duration>0:00:07</Duration>" +
                "</Records></LazyCureData>";
            DateTime date = DateTime.Parse("2126-11-18");
            string folder = @"c:\temp\LazyCure\test\TimeLogs";
            string filename = folder + @"\2126-11-18.timelog";
            if (File.Exists(filename))
                File.Delete(filename);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            StreamWriter writer = File.CreateText(filename);
            writer.Write(sBrokenContent);
            writer.Close();
            driver.TimeLogsFolder = folder;
            Assert.IsFalse(driver.LoadTimeLog(date));
        }
        [Test]
        public void TimeLogDate()
        {
            Assert.AreEqual(DateTime.Now.ToString("yyyy-MM-dd"), driver.TimeLogDate);
        }
        [Test]
        public void CurrentActivityDuration()
        {
            DateTime startTime = DateTime.Parse("5:00:00");
            TimeSpan duration = TimeSpan.FromMinutes(15);
            DateTime endTime = startTime + duration;

            ITimeSystem mockTimeSystem = mocks.NewMock<ITimeSystem>();

            using (mocks.Ordered)
            {
                Expect.Once.On(mockTimeSystem).GetProperty("Now").Will(Return.Value(startTime));
                Expect.Once.On(mockTimeSystem).GetProperty("Now").Will(Return.Value(endTime));
            }
            driver = new Driver(mockTimeSystem);
            Assert.AreEqual(duration, driver.CurrentActivity.Duration);
        }
        [Test]
        public void LatestActivities()
        {
            driver.FinishActivity("latest", "next");

            Assert.Contains("latest", driver.LatestActivities);
        }
        [Test]
        public void HistoryReused()
        {
            driver.FinishActivity("saved", "next");
            driver.SaveHistory(@"c:\temp\history.txt");
            driver = new Driver();
            driver.LoadHistory(@"c:\temp\history.txt");
            Assert.Contains("saved", driver.LatestActivities);
        }
    }
}
