﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyFrankCrum_EMP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PayHistory recording.
    /// </summary>
    [TestModule("8a792f5e-79c6-49ad-b2de-3353e57dd482", ModuleType.Recording, 1)]
    public partial class PayHistory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static PayHistory instance = new PayHistory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PayHistory()
        {
            PayHistoryTodate = "04/28/2020";
            PayHistoryFromDate = "04/27/2020";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PayHistory Instance
        {
            get { return instance; }
        }

#region Variables

        string _PayHistoryTodate;

        /// <summary>
        /// Gets or sets the value of variable PayHistoryTodate.
        /// </summary>
        [TestVariable("26dc0310-53dc-4a62-aacf-368b7265295f")]
        public string PayHistoryTodate
        {
            get { return _PayHistoryTodate; }
            set { _PayHistoryTodate = value; }
        }

        string _PayHistoryFromDate;

        /// <summary>
        /// Gets or sets the value of variable PayHistoryFromDate.
        /// </summary>
        [TestVariable("05792033-fde1-4390-ba4c-44fb4e06d23d")]
        public string PayHistoryFromDate
        {
            get { return _PayHistoryFromDate; }
            set { _PayHistoryFromDate = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RepoURL.
        /// </summary>
        [TestVariable("c75816bd-3150-4b49-aa6d-f8479454f515")]
        public string RepoURL
        {
            get { return repo.RepoURL; }
            set { repo.RepoURL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PayHistory' at Center.", repo.ApplicationUnderTest.PayHistoryInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.PayHistory.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            // Check the Pay History date filters
            Report.Log(ReportLevel.Info, "Section", "Check the Pay History date filters", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PayHistoryFromDate' at Center.", repo.ApplicationUnderTest.PayHistoryFromDateInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.PayHistoryFromDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.PayHistoryFromDate'.", repo.ApplicationUnderTest.PayHistoryFromDateInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.PayHistoryFromDate);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PayHistoryFromDate' with focus on 'ApplicationUnderTest.PayHistoryFromDate'.", repo.ApplicationUnderTest.PayHistoryFromDateInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.PayHistoryFromDate.PressKeys(PayHistoryFromDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Historyselectdate' at 12;9.", repo.ApplicationUnderTest.HistoryselectdateInfo, new RecordItemIndex(7));
            //repo.ApplicationUnderTest.Historyselectdate.Click("12;9");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PayHistoryTodate' at Center.", repo.ApplicationUnderTest.PayHistoryTodateInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.PayHistoryTodate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.PayHistoryTodate'.", repo.ApplicationUnderTest.PayHistoryTodateInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.PayHistoryTodate);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PayHistoryTodate' with focus on 'ApplicationUnderTest.PayHistoryTodate'.", repo.ApplicationUnderTest.PayHistoryTodateInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.PayHistoryTodate.PressKeys(PayHistoryTodate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FROMDATElblclick' at Center.", repo.ApplicationUnderTest.FROMDATElblclickInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.FROMDATElblclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(12));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(13));
            
            // View the Pay History  | Click the View link on the right side of the row
            Report.Log(ReportLevel.Info, "Section", "View the Pay History  | Click the View link on the right side of the row", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.View' at Center.", repo.ApplicationUnderTest.ViewInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.View.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(16));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(17));
            
            // On donut chart on top-left click on the different segments
            Report.Log(ReportLevel.Info, "Section", "On donut chart on top-left click on the different segments", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Path' at .07;.763.", repo.ApplicationUnderTest.PathInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Path.Click(".07;.763");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(20));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(21));
            
            // Under the donut chart, click the Back link
            Report.Log(ReportLevel.Info, "Section", "Under the donut chart, click the Back link", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Back' at Center.", repo.ApplicationUnderTest.BackInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.Back.Click();
            Delay.Milliseconds(0);
            
            // Press the Go Back link on top-left of the page
            Report.Log(ReportLevel.Info, "Section", "Press the Go Back link on top-left of the page", new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HistoryGoBack' at .491;.389.", repo.ApplicationUnderTest.HistoryGoBackInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.HistoryGoBack.Click(".491;.389");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(26));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(27));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
