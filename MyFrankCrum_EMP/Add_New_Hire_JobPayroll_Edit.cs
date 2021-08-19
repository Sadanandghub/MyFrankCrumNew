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
    ///The Add_New_Hire_JobPayroll_Edit recording.
    /// </summary>
    [TestModule("a38c2fb2-e5dd-4988-92d8-8ce2905197e3", ModuleType.Recording, 1)]
    public partial class Add_New_Hire_JobPayroll_Edit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Add_New_Hire_JobPayroll_Edit instance = new Add_New_Hire_JobPayroll_Edit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_New_Hire_JobPayroll_Edit()
        {
            AnnualSalary = "";
            EditPayRatePerHour = "150";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_New_Hire_JobPayroll_Edit Instance
        {
            get { return instance; }
        }

#region Variables

        string _AnnualSalary;

        /// <summary>
        /// Gets or sets the value of variable AnnualSalary.
        /// </summary>
        [TestVariable("55173cb1-9efe-4a2e-806d-d9765cd3a08e")]
        public string AnnualSalary
        {
            get { return _AnnualSalary; }
            set { _AnnualSalary = value; }
        }

        string _EditPayRatePerHour;

        /// <summary>
        /// Gets or sets the value of variable EditPayRatePerHour.
        /// </summary>
        [TestVariable("642c5496-6a4f-4d21-bc51-d3137c6bec98")]
        public string EditPayRatePerHour
        {
            get { return _EditPayRatePerHour; }
            set { _EditPayRatePerHour = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SumEdit' at Center.", repo.ApplicationUnderTest.SumEditInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SumEdit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.PayRatePerHour' at Center.", repo.ApplicationUnderTest.PayRatePerHourInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.PayRatePerHour.DoubleClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EditPayRatePerHour' with focus on 'ApplicationUnderTest.PayRatePerHour'.", repo.ApplicationUnderTest.PayRatePerHourInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.PayRatePerHour.PressKeys(EditPayRatePerHour);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AnnualSalary' at Center.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AnnualSalary.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.AnnualSalary' and assigning its value to variable 'AnnualSalary'.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(4));
            AnnualSalary = repo.ApplicationUnderTest.AnnualSalary.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>$AnnualSalary) on item 'ApplicationUnderTest.AnnualSalary'.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.ApplicationUnderTest.AnnualSalaryInfo, "Value", AnnualSalary);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.BackToSummary1' at Center.", repo.ApplicationUnderTest.BackToSummary1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.BackToSummary1.DoubleClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1634 units.", new RecordItemIndex(7));
            Mouse.ScrollWheel(-1634);
            Delay.Milliseconds(300);
            
            Report.Screenshot(ReportLevel.Info, "User", "PAGE CAPTURED", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(8));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}