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
    ///The New_Hire_JobPayrol_Pagel recording.
    /// </summary>
    [TestModule("cde91585-de45-484c-adb5-8e9402e45195", ModuleType.Recording, 1)]
    public partial class New_Hire_JobPayrol_Pagel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static New_Hire_JobPayrol_Pagel instance = new New_Hire_JobPayrol_Pagel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public New_Hire_JobPayrol_Pagel()
        {
            AnnualSalary = "";
            SupervisorIDValue = "ALAM, RAM";
            WCCode = "5474";
            LocationID = "006647";
            HireSourceValue = "Dice";
            FLSAStatus = "Non Exempt";
            ClientProjectValue = "Z - NONE";
            Project = "Z - NONE";
            PayRatePerHour = "100";
            PayGroup = "A0F212";
            ScheduledHours = "100";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static New_Hire_JobPayrol_Pagel Instance
        {
            get { return instance; }
        }

#region Variables

        string _AnnualSalary;

        /// <summary>
        /// Gets or sets the value of variable AnnualSalary.
        /// </summary>
        [TestVariable("1abe6180-18de-4411-83bc-4786e59d3893")]
        public string AnnualSalary
        {
            get { return _AnnualSalary; }
            set { _AnnualSalary = value; }
        }

        string _WCCode;

        /// <summary>
        /// Gets or sets the value of variable WCCode.
        /// </summary>
        [TestVariable("3020f80a-4761-4d8c-8d70-a385b3cf2a41")]
        public string WCCode
        {
            get { return _WCCode; }
            set { _WCCode = value; }
        }

        string _LocationID;

        /// <summary>
        /// Gets or sets the value of variable LocationID.
        /// </summary>
        [TestVariable("a9327e20-4337-479e-ba7b-716dacffc755")]
        public string LocationID
        {
            get { return _LocationID; }
            set { _LocationID = value; }
        }

        string _ClientProjectValue;

        /// <summary>
        /// Gets or sets the value of variable ClientProjectValue.
        /// </summary>
        [TestVariable("d92b3ea5-72dd-4a1e-9c3d-2a0bb1eb0511")]
        public string ClientProjectValue
        {
            get { return _ClientProjectValue; }
            set { _ClientProjectValue = value; }
        }

        string _Project;

        /// <summary>
        /// Gets or sets the value of variable Project.
        /// </summary>
        [TestVariable("3c5a1dcb-e9f2-4507-9265-509ba8b9914a")]
        public string Project
        {
            get { return _Project; }
            set { _Project = value; }
        }

        string _PayRatePerHour;

        /// <summary>
        /// Gets or sets the value of variable PayRatePerHour.
        /// </summary>
        [TestVariable("a114a310-f6b3-474a-aa8c-eb5246885569")]
        public string PayRatePerHour
        {
            get { return _PayRatePerHour; }
            set { _PayRatePerHour = value; }
        }

        string _PayGroup;

        /// <summary>
        /// Gets or sets the value of variable PayGroup.
        /// </summary>
        [TestVariable("d02d02bf-a4df-4056-be27-b4a4ff1e3f41")]
        public string PayGroup
        {
            get { return _PayGroup; }
            set { _PayGroup = value; }
        }

        string _ScheduledHours;

        /// <summary>
        /// Gets or sets the value of variable ScheduledHours.
        /// </summary>
        [TestVariable("c574b53d-b0e4-414b-9f8e-5a9a06d59e21")]
        public string ScheduledHours
        {
            get { return _ScheduledHours; }
            set { _ScheduledHours = value; }
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

        /// <summary>
        /// Gets or sets the value of variable HireSourceValue.
        /// </summary>
        [TestVariable("0abb3cff-c34d-453c-a1da-89fe1ca9bb1a")]
        public string HireSourceValue
        {
            get { return repo.HireSourceValue; }
            set { repo.HireSourceValue = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EmployeeTypeValue.
        /// </summary>
        [TestVariable("3d84aff9-d56f-42b0-986c-99e3883004e4")]
        public string EmployeeTypeValue
        {
            get { return repo.EmployeeTypeValue; }
            set { repo.EmployeeTypeValue = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DepartmentValues.
        /// </summary>
        [TestVariable("bf72833f-56a1-4271-bad5-9ac9ddbc7647")]
        public string DepartmentValues
        {
            get { return repo.DepartmentValues; }
            set { repo.DepartmentValues = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CostItemValue.
        /// </summary>
        [TestVariable("bed19701-22c5-4017-88e8-480aa99a381d")]
        public string CostItemValue
        {
            get { return repo.CostItemValue; }
            set { repo.CostItemValue = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SupervisorIDValue.
        /// </summary>
        [TestVariable("0b59ccec-b330-4941-8d05-f969f0d077c8")]
        public string SupervisorIDValue
        {
            get { return repo.SupervisorIDValue; }
            set { repo.SupervisorIDValue = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FLSAStatus.
        /// </summary>
        [TestVariable("7e10ed2b-2cb3-4f1c-b711-d591a242b1ad")]
        public string FLSAStatus
        {
            get { return repo.FLSAStatus; }
            set { repo.FLSAStatus = value; }
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

            Report.Log(ReportLevel.Info, "User", "Job / Payroll Started", new RecordItemIndex(0));
            
            // Employee Information
            Report.Log(ReportLevel.Info, "Section", "Employee Information", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SupervisorID' at Center.", repo.ApplicationUnderTest.SupervisorIDInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SupervisorID.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SupervisorIDValue' with focus on 'ApplicationUnderTest.SupervisorID'.", repo.ApplicationUnderTest.SupervisorIDInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.SupervisorID.EnsureVisible();
            Keyboard.Press(SupervisorIDValue);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.SupervisorID'.", repo.ApplicationUnderTest.SupervisorIDInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.SupervisorID.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.WCCode' at Center.", repo.ApplicationUnderTest.WCCodeInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.WCCode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$WCCode' with focus on 'ApplicationUnderTest.WCCode'.", repo.ApplicationUnderTest.WCCodeInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.WCCode.EnsureVisible();
            Keyboard.Press(WCCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.WCCode'.", repo.ApplicationUnderTest.WCCodeInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.WCCode.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LocationID' at Center.", repo.ApplicationUnderTest.LocationIDInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.LocationID.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LocationID' with focus on 'ApplicationUnderTest.LocationID'.", repo.ApplicationUnderTest.LocationIDInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.LocationID.EnsureVisible();
            Keyboard.Press(LocationID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.LocationID'.", repo.ApplicationUnderTest.LocationIDInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.LocationID.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HireSource' at 164;22.", repo.ApplicationUnderTest.HireSourceInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.HireSource.Click("164;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HireSourceValue' at 53;16.", repo.ApplicationUnderTest.HireSourceValueInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.HireSourceValue.Click("53;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EmployeeType' at 11;6.", repo.ApplicationUnderTest.EmployeeTypeInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.EmployeeType.Click("11;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EmployeeTypeValue' at 72;19.", repo.ApplicationUnderTest.EmployeeTypeValueInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.EmployeeTypeValue.Click("72;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FLSAStatus1' at Center.", repo.ApplicationUnderTest.FLSAStatus1Info, new RecordItemIndex(15));
            repo.ApplicationUnderTest.FLSAStatus1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FLSAStatus' with focus on 'ApplicationUnderTest.FLSAStatus1'.", repo.ApplicationUnderTest.FLSAStatus1Info, new RecordItemIndex(16));
            repo.ApplicationUnderTest.FLSAStatus1.EnsureVisible();
            Keyboard.Press(FLSAStatus);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.FLSAStatus1'.", repo.ApplicationUnderTest.FLSAStatus1Info, new RecordItemIndex(17));
            repo.ApplicationUnderTest.FLSAStatus1.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Departmentclick' at 7;9.", repo.ApplicationUnderTest.DepartmentclickInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Departmentclick.Click("7;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DepartmentValue' at 34;16.", repo.ApplicationUnderTest.DepartmentValueInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.DepartmentValue.Click("34;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CostItem' at 11;8.", repo.ApplicationUnderTest.CostItemInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.CostItem.Click("11;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CostitemValue' at 56;15.", repo.ApplicationUnderTest.CostitemValueInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.CostitemValue.Click("56;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ClientProject' at 104;17.", repo.ApplicationUnderTest.ClientProjectInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.ClientProject.Click("104;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClientProjectValue' with focus on 'ApplicationUnderTest.ClientProject'.", repo.ApplicationUnderTest.ClientProjectInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.ClientProject.EnsureVisible();
            Keyboard.Press(ClientProjectValue);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.ClientProject'.", repo.ApplicationUnderTest.ClientProjectInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.ClientProject.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Project' at 133;12.", repo.ApplicationUnderTest.ProjectInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.Project.Click("133;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Project' with focus on 'ApplicationUnderTest.Project'.", repo.ApplicationUnderTest.ProjectInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.Project.EnsureVisible();
            Keyboard.Press(Project);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Project'.", repo.ApplicationUnderTest.ProjectInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.Project.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            // Wage Information
            Report.Log(ReportLevel.Info, "Section", "Wage Information", new RecordItemIndex(28));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PayRatePerHour' at Center.", repo.ApplicationUnderTest.PayRatePerHourInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.PayRatePerHour.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PayRatePerHour' with focus on 'ApplicationUnderTest.PayRatePerHour'.", repo.ApplicationUnderTest.PayRatePerHourInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.PayRatePerHour.PressKeys(PayRatePerHour);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AnnualSalary' at Center.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.AnnualSalary.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.AnnualSalary' and assigning its value to variable 'AnnualSalary'.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(32));
            AnnualSalary = repo.ApplicationUnderTest.AnnualSalary.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>$AnnualSalary) on item 'ApplicationUnderTest.AnnualSalary'.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(33));
            Validate.AttributeContains(repo.ApplicationUnderTest.AnnualSalaryInfo, "Value", AnnualSalary);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Paygroup' at Center.", repo.ApplicationUnderTest.PaygroupInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.Paygroup.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PayGroup' with focus on 'ApplicationUnderTest.Paygroup'.", repo.ApplicationUnderTest.PaygroupInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.Paygroup.EnsureVisible();
            Keyboard.Press(PayGroup);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Paygroup'.", repo.ApplicationUnderTest.PaygroupInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.Paygroup.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'ApplicationUnderTest.Next2'.", repo.ApplicationUnderTest.Next2Info, new RecordItemIndex(37));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Next2Info, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.ScheduledHours' at Center.", repo.ApplicationUnderTest.ScheduledHoursInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.ScheduledHours.DoubleClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ScheduledHours' with focus on 'ApplicationUnderTest.ScheduledHours'.", repo.ApplicationUnderTest.ScheduledHoursInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.ScheduledHours.PressKeys(ScheduledHours);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.AnnualSalary' and assigning its value to variable 'AnnualSalary'.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(40));
            AnnualSalary = repo.ApplicationUnderTest.AnnualSalary.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>$AnnualSalary) on item 'ApplicationUnderTest.AnnualSalary'.", repo.ApplicationUnderTest.AnnualSalaryInfo, new RecordItemIndex(41));
            Validate.AttributeContains(repo.ApplicationUnderTest.AnnualSalaryInfo, "Value", AnnualSalary);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Next2' at Center.", repo.ApplicationUnderTest.Next2Info, new RecordItemIndex(42));
            repo.ApplicationUnderTest.Next2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'ApplicationUnderTest.LiTag4Deductions'.", repo.ApplicationUnderTest.LiTag4DeductionsInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LiTag4DeductionsInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}