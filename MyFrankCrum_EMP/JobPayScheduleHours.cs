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
    ///The JobPayScheduleHours recording.
    /// </summary>
    [TestModule("31aaca9d-35a8-4657-bee5-e40213eec2f8", ModuleType.Recording, 1)]
    public partial class JobPayScheduleHours : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static JobPayScheduleHours instance = new JobPayScheduleHours();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public JobPayScheduleHours()
        {
            ScheduledHours = "45";
            HourlyPayRate = "130";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static JobPayScheduleHours Instance
        {
            get { return instance; }
        }

#region Variables

        string _ScheduledHours;

        /// <summary>
        /// Gets or sets the value of variable ScheduledHours.
        /// </summary>
        [TestVariable("cbb7a503-5220-4a31-a5c7-509d018692a4")]
        public string ScheduledHours
        {
            get { return _ScheduledHours; }
            set { _ScheduledHours = value; }
        }

        string _HourlyPayRate;

        /// <summary>
        /// Gets or sets the value of variable HourlyPayRate.
        /// </summary>
        [TestVariable("f430b2d1-cf40-4675-8ecc-aa49c8028299")]
        public string HourlyPayRate
        {
            get { return _HourlyPayRate; }
            set { _HourlyPayRate = value; }
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

            // Change the scheduled hours value
            Report.Log(ReportLevel.Info, "Section", "Change the scheduled hours value", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ScheduledHours1' at Center.", repo.ApplicationUnderTest.ScheduledHours1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ScheduledHours1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$ScheduledHours' on item 'ApplicationUnderTest.ScheduledHours1'.", repo.ApplicationUnderTest.ScheduledHours1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ScheduledHours1.Element.SetAttributeValue("Value", ScheduledHours);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Salary' at Center.", repo.ApplicationUnderTest.SalaryInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Salary.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HourlyPayRateInput' at Center.", repo.ApplicationUnderTest.HourlyPayRateInputInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.HourlyPayRateInput.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$HourlyPayRate' on item 'ApplicationUnderTest.HourlyPayRateInput'.", repo.ApplicationUnderTest.HourlyPayRateInputInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.HourlyPayRateInput.Element.SetAttributeValue("Value", HourlyPayRate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FullFormSection' at Center.", repo.ApplicationUnderTest.FullFormSectionInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.FullFormSection.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "HourlyPayRate Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SaveJobPayChanges' at Center.", repo.ApplicationUnderTest.SaveJobPayChangesInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.SaveJobPayChanges.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}