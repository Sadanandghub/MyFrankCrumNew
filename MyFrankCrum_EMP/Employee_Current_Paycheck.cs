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
    ///The Employee_Current_Paycheck recording.
    /// </summary>
    [TestModule("f394ece3-6e1f-434d-9f8f-75ea11c41aa8", ModuleType.Recording, 1)]
    public partial class Employee_Current_Paycheck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employee_Current_Paycheck instance = new Employee_Current_Paycheck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employee_Current_Paycheck()
        {
            RepoURL = "mfcdev05.frankcrum.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employee_Current_Paycheck Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CurrentPaycheck' at 46;3.", repo.ApplicationUnderTest.CurrentPaycheckInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.CurrentPaycheck.Click("46;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Path1' at 47;113.", repo.ApplicationUnderTest.Path1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Path1.Click("47;113");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Back1' at 14;5.", repo.ApplicationUnderTest.Back1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Back1.Click("14;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pay Details') on item 'ApplicationUnderTest.PaycheckContainerElements.PayDetails'.", repo.ApplicationUnderTest.PaycheckContainerElements.PayDetailsInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.PayDetailsInfo, "InnerText", "Pay Details");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Earnings') on item 'ApplicationUnderTest.PaycheckContainerElements.Earnings1'.", repo.ApplicationUnderTest.PaycheckContainerElements.Earnings1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.Earnings1Info, "InnerText", "Earnings");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Taxes') on item 'ApplicationUnderTest.PaycheckContainerElements.Taxes1'.", repo.ApplicationUnderTest.PaycheckContainerElements.Taxes1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.Taxes1Info, "InnerText", "Taxes");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Deductions') on item 'ApplicationUnderTest.PaycheckContainerElements.Deductions1'.", repo.ApplicationUnderTest.PaycheckContainerElements.Deductions1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.Deductions1Info, "InnerText", "Deductions");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Net Pay Distribution') on item 'ApplicationUnderTest.PaycheckContainerElements.NetPayDistribution'.", repo.ApplicationUnderTest.PaycheckContainerElements.NetPayDistributionInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.NetPayDistributionInfo, "InnerText", "Net Pay Distribution");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Paid Time Off (Hours)') on item 'ApplicationUnderTest.PaycheckContainerElements.PaidTimeOffHours'.", repo.ApplicationUnderTest.PaycheckContainerElements.PaidTimeOffHoursInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.PaidTimeOffHoursInfo, "InnerText", "Paid Time Off (Hours)");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pay Summary - Current') on item 'ApplicationUnderTest.PaycheckContainerElements.PaySummaryCurrent'.", repo.ApplicationUnderTest.PaycheckContainerElements.PaySummaryCurrentInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.PaySummaryCurrentInfo, "InnerText", "Pay Summary - Current");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pay Summary - Year To Date') on item 'ApplicationUnderTest.PaycheckContainerElements.PaySummaryYearToDate'.", repo.ApplicationUnderTest.PaycheckContainerElements.PaySummaryYearToDateInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PaycheckContainerElements.PaySummaryYearToDateInfo, "InnerText", "Pay Summary - Year To Date");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FaFaPrint' at 11;7.", repo.ApplicationUnderTest.FaFaPrintInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.FaFaPrint.Click("11;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(16));
            Delay.Duration(10000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(17));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}