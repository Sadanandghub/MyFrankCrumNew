///////////////////////////////////////////////////////////////////////////////
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
    ///The EmployeeStatusTabWithValidation recording.
    /// </summary>
    [TestModule("d3445242-96b3-4544-9c2f-c96aeff33d88", ModuleType.Recording, 1)]
    public partial class EmployeeStatusTabWithValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static EmployeeStatusTabWithValidation instance = new EmployeeStatusTabWithValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmployeeStatusTabWithValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmployeeStatusTabWithValidation Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Activeclick' at Center.", repo.ApplicationUnderTest.ActiveclickInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Activeclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Employees - Active') on item 'ApplicationUnderTest.EmployeesActive'.", repo.ApplicationUnderTest.EmployeesActiveInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.ApplicationUnderTest.EmployeesActiveInfo, "InnerText", "Employees - Active");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LeaveOfAbsenceclick' at Center.", repo.ApplicationUnderTest.LeaveOfAbsenceclickInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LeaveOfAbsenceclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Employees - Leave of absence') on item 'ApplicationUnderTest.EmployeesLeaveOfAbsence'.", repo.ApplicationUnderTest.EmployeesLeaveOfAbsenceInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.ApplicationUnderTest.EmployeesLeaveOfAbsenceInfo, "InnerText", "Employees - Leave of absence");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnStrikeclick' at Center.", repo.ApplicationUnderTest.OnStrikeclickInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.OnStrikeclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Employees - On strike') on item 'ApplicationUnderTest.EmployeesOnStrike'.", repo.ApplicationUnderTest.EmployeesOnStrikeInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.ApplicationUnderTest.EmployeesOnStrikeInfo, "InnerText", "Employees - On strike");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Terminatedclick' at Center.", repo.ApplicationUnderTest.TerminatedclickInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Terminatedclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Employees - Terminated') on item 'ApplicationUnderTest.EmployeesTerminated'.", repo.ApplicationUnderTest.EmployeesTerminatedInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.ApplicationUnderTest.EmployeesTerminatedInfo, "InnerText", "Employees - Terminated");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Totalclick' at Center.", repo.ApplicationUnderTest.TotalclickInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Totalclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Employees - Total') on item 'ApplicationUnderTest.EmployeesTotal'.", repo.ApplicationUnderTest.EmployeesTotalInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.ApplicationUnderTest.EmployeesTotalInfo, "InnerText", "Employees - Total");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
