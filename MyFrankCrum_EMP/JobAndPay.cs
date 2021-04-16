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
    ///The JobAndPay recording.
    /// </summary>
    [TestModule("19ef1c10-ee1c-4109-8b46-b097a34d9670", ModuleType.Recording, 1)]
    public partial class JobAndPay : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static JobAndPay instance = new JobAndPay();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public JobAndPay()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static JobAndPay Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.JobPay' at Center.", repo.ApplicationUnderTest.JobPayInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.JobPay.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect4' at Center.", repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect4Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CostOfLivingAdjustment' at Center.", repo.ApplicationUnderTest.CostOfLivingAdjustmentInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.CostOfLivingAdjustment.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect5' at Center.", repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect5Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect5.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Job_Code' at Center.", repo.ApplicationUnderTest.Job_CodeInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Job_Code.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect6' at Center.", repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect6Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect6.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Department' at Center.", repo.ApplicationUnderTest.DepartmentInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Department.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SaveJobPayChanges' at Center.", repo.ApplicationUnderTest.SaveJobPayChangesInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.SaveJobPayChanges.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.NotificationNotificationLeaveNotifica'.", repo.ApplicationUnderTest.NotificationNotificationLeaveNotificaInfo, new RecordItemIndex(9));
            Validate.Exists(repo.ApplicationUnderTest.NotificationNotificationLeaveNotificaInfo);
            Delay.Milliseconds(100);
            
            // Change the scheduled hours value
            Report.Log(ReportLevel.Info, "Section", "Change the scheduled hours value", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ScheduledHours1' at Center.", repo.ApplicationUnderTest.ScheduledHours1Info, new RecordItemIndex(11));
            repo.ApplicationUnderTest.ScheduledHours1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '35' on item 'ApplicationUnderTest.ScheduledHours1'.", repo.ApplicationUnderTest.ScheduledHours1Info, new RecordItemIndex(12));
            repo.ApplicationUnderTest.ScheduledHours1.Element.SetAttributeValue("Value", "35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Salary' at Center.", repo.ApplicationUnderTest.SalaryInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Salary.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", null, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HourlyPayRateInput' at Center.", repo.ApplicationUnderTest.HourlyPayRateInputInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.HourlyPayRateInput.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '130' on item 'ApplicationUnderTest.HourlyPayRateInput'.", repo.ApplicationUnderTest.HourlyPayRateInputInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.HourlyPayRateInput.Element.SetAttributeValue("Value", "130");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FullFormSection' at Center.", repo.ApplicationUnderTest.FullFormSectionInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.FullFormSection.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "HourlyPayRate Screenshot Taken", null, false, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SaveJobPayChanges' at Center.", repo.ApplicationUnderTest.SaveJobPayChangesInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.SaveJobPayChanges.Click();
            Delay.Milliseconds(0);
            
            // Salary Review File Upload section
            Report.Log(ReportLevel.Info, "Section", "Salary Review File Upload section", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentTitle' at Center.", repo.ApplicationUnderTest.DocumentTitleInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.DocumentTitle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Salary file' with focus on 'ApplicationUnderTest.DocumentTitle'.", repo.ApplicationUnderTest.DocumentTitleInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.DocumentTitle.PressKeys("Salary file");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Text' at Center.", repo.ApplicationUnderTest.TextInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04042021' with focus on 'ApplicationUnderTest.Text'.", repo.ApplicationUnderTest.TextInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.Text.PressKeys("04042021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PerformanceReviewCorrectiveAction' at Center.", repo.ApplicationUnderTest.PerformanceReviewCorrectiveActionInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.PerformanceReviewCorrectiveAction.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ChooseFile' at Center.", repo.ApplicationUnderTest.ChooseFileInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.ChooseFile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SystemItemNameDisplay' at Center.", repo.Open.SystemItemNameDisplayInfo, new RecordItemIndex(27));
            repo.Open.SystemItemNameDisplay.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(28));
            repo.Open.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SalaryReviewFileFileEmployeeCanView' at Center.", repo.ApplicationUnderTest.SalaryReviewFileFileEmployeeCanViewInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.SalaryReviewFileFileEmployeeCanView.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot taken", null, false, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SaveJobPayChanges' at Center.", repo.ApplicationUnderTest.SaveJobPayChangesInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.SaveJobPayChanges.Click();
            Delay.Milliseconds(0);
            
            // Performance Review / Corrective Action File Upload
            Report.Log(ReportLevel.Info, "Section", "Performance Review / Corrective Action File Upload", new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PerformanceDocumentTitle' at Center.", repo.ApplicationUnderTest.PerformanceDocumentTitleInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.PerformanceDocumentTitle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Performance file' with focus on 'ApplicationUnderTest.PerformanceDocumentTitle'.", repo.ApplicationUnderTest.PerformanceDocumentTitleInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.PerformanceDocumentTitle.PressKeys("Performance file");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.performanceText' at Center.", repo.ApplicationUnderTest.performanceTextInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.performanceText.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04042021' with focus on 'ApplicationUnderTest.performanceText'.", repo.ApplicationUnderTest.performanceTextInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.performanceText.PressKeys("04042021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceReviewCorrectiveActionF' at Center.", repo.PerformanceReviewCorrectiveActionFInfo, new RecordItemIndex(37));
            repo.PerformanceReviewCorrectiveActionF.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceChooseFile' at Center.", repo.PerformanceChooseFileInfo, new RecordItemIndex(38));
            repo.PerformanceChooseFile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SystemItemNameDisplay' at Center.", repo.Open.SystemItemNameDisplayInfo, new RecordItemIndex(39));
            repo.Open.SystemItemNameDisplay.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(40));
            repo.Open.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceReviewFileFileEmployeeCanVie' at Center.", repo.PerformanceReviewFileFileEmployeeCanVieInfo, new RecordItemIndex(41));
            repo.PerformanceReviewFileFileEmployeeCanVie.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SaveJobPayChanges' at Center.", repo.ApplicationUnderTest.SaveJobPayChangesInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.SaveJobPayChanges.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}