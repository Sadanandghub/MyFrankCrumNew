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
    ///The Cancel_New_Hire_Process_link recording.
    /// </summary>
    [TestModule("15f5c8c0-0b7e-478f-be86-f78c986ee06b", ModuleType.Recording, 1)]
    public partial class Cancel_New_Hire_Process_link : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Cancel_New_Hire_Process_link instance = new Cancel_New_Hire_Process_link();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Cancel_New_Hire_Process_link()
        {
            EmployeeSSN = "743-98-0932";
            EmployeeDOB = "03/03/1991";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Cancel_New_Hire_Process_link Instance
        {
            get { return instance; }
        }

#region Variables

        string _EmployeeSSN;

        /// <summary>
        /// Gets or sets the value of variable EmployeeSSN.
        /// </summary>
        [TestVariable("d1758c0b-8583-485c-99d4-f062313900d3")]
        public string EmployeeSSN
        {
            get { return _EmployeeSSN; }
            set { _EmployeeSSN = value; }
        }

        string _EmployeeDOB;

        /// <summary>
        /// Gets or sets the value of variable EmployeeDOB.
        /// </summary>
        [TestVariable("e4df6d02-8d40-4ca0-a4bd-1e1667af3f2c")]
        public string EmployeeDOB
        {
            get { return _EmployeeDOB; }
            set { _EmployeeDOB = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EmployeeSsn' at Center.", repo.ApplicationUnderTest.EmployeeSsnInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.EmployeeSsn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EmployeeSSN' with focus on 'ApplicationUnderTest.EmployeeSsn'.", repo.ApplicationUnderTest.EmployeeSsnInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.EmployeeSsn.PressKeys(EmployeeSSN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DateOfBirth' at Center.", repo.ApplicationUnderTest.DateOfBirthInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.DateOfBirth.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EmployeeDOB' with focus on 'ApplicationUnderTest.DateOfBirth'.", repo.ApplicationUnderTest.DateOfBirthInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.DateOfBirth.PressKeys(EmployeeDOB);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CancelNewHireProcess' at 56;10.", repo.ApplicationUnderTest.CancelNewHireProcessInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.CancelNewHireProcess.Click("56;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeactivatePopupClose' at 18;11.", repo.ApplicationUnderTest.DeactivatePopupCloseInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.DeactivatePopupClose.Click("18;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CancelNewHireProcess' at 56;10.", repo.ApplicationUnderTest.CancelNewHireProcessInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.CancelNewHireProcess.Click("56;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(9));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CancelNewHire' at 58;19.", repo.ApplicationUnderTest.CancelNewHireInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.CancelNewHire.Click("58;19");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Captured", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}