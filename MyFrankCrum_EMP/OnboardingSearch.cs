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
    ///The OnboardingSearch recording.
    /// </summary>
    [TestModule("d20da3b0-6271-4b24-8700-5362c8610334", ModuleType.Recording, 1)]
    public partial class OnboardingSearch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static OnboardingSearch instance = new OnboardingSearch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OnboardingSearch()
        {
            CompanyID = "90936";
            EmployeeStatus = "0";
            EmployeeLastName = "WRIGHT";
            EmployeeFirstName = "DENNIE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OnboardingSearch Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompanyID;

        /// <summary>
        /// Gets or sets the value of variable CompanyID.
        /// </summary>
        [TestVariable("3c574e88-4815-44eb-b1b0-295c6f589a59")]
        public string CompanyID
        {
            get { return _CompanyID; }
            set { _CompanyID = value; }
        }

        string _EmployeeStatus;

        /// <summary>
        /// Gets or sets the value of variable EmployeeStatus.
        /// </summary>
        [TestVariable("134df98e-5345-4022-9664-380dcc612d63")]
        public string EmployeeStatus
        {
            get { return _EmployeeStatus; }
            set { _EmployeeStatus = value; }
        }

        string _EmployeeLastName;

        /// <summary>
        /// Gets or sets the value of variable EmployeeLastName.
        /// </summary>
        [TestVariable("2673b814-f6d5-400e-a324-27f201766661")]
        public string EmployeeLastName
        {
            get { return _EmployeeLastName; }
            set { _EmployeeLastName = value; }
        }

        string _EmployeeFirstName;

        /// <summary>
        /// Gets or sets the value of variable EmployeeFirstName.
        /// </summary>
        [TestVariable("c5a7e2d2-7801-4d59-91e7-943f85bb5baa")]
        public string EmployeeFirstName
        {
            get { return _EmployeeFirstName; }
            set { _EmployeeFirstName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Onboarding' at Center.", repo.ApplicationUnderTest.OnboardingInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Onboarding.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.ModalScroll'.", repo.ApplicationUnderTest.ModalScrollInfo, new RecordItemIndex(1));
            Validate.Exists(repo.ApplicationUnderTest.ModalScrollInfo);
            Delay.Milliseconds(100);
            
            // Onboarding Page
            Report.Log(ReportLevel.Info, "Section", "Onboarding Page", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.DdlCompany' at Center.", repo.ApplicationUnderTest.OnboardingIframe.DdlCompanyInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.OnboardingIframe.DdlCompany.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CompanyID' with focus on 'ApplicationUnderTest.OnboardingIframe.DdlCompany'.", repo.ApplicationUnderTest.OnboardingIframe.DdlCompanyInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.OnboardingIframe.DdlCompany.PressKeys(CompanyID);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'VABWA' on item 'ApplicationUnderTest.OnboardingIframe.DdlCompany'.", repo.ApplicationUnderTest.OnboardingIframe.DdlCompanyInfo, new RecordItemIndex(5));
            //repo.ApplicationUnderTest.OnboardingIframe.DdlCompany.Element.SetAttributeValue("TagValue", "VABWA");
            //Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.BtnSearch' at Center.", repo.ApplicationUnderTest.OnboardingIframe.BtnSearchInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.OnboardingIframe.BtnSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot capture", repo.ApplicationUnderTest.ModalScroll, false, new RecordItemIndex(8));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ModalScroll' at 4;4.", repo.ApplicationUnderTest.ModalScrollInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.ModalScroll.Click(new Location(ModalScroll_Screenshot1, "4;4", ModalScroll_Screenshot1_Options));
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.Maincontent' at 4;4.", repo.ApplicationUnderTest.OnboardingIframe.MaincontentInfo, new RecordItemIndex(10));
            //repo.ApplicationUnderTest.OnboardingIframe.Maincontent.Click(new Location(Maincontent_Screenshot1, "4;4", Maincontent_Screenshot1_Options));
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$EmployeeStatus' on item 'ApplicationUnderTest.OnboardingIframe.DdlStatus'.", repo.ApplicationUnderTest.OnboardingIframe.DdlStatusInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.OnboardingIframe.DdlStatus.Element.SetAttributeValue("TagValue", EmployeeStatus);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.BtnSearch' at Center.", repo.ApplicationUnderTest.OnboardingIframe.BtnSearchInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.OnboardingIframe.BtnSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(13));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot capture", repo.ApplicationUnderTest.ModalScroll, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.TxtLastName' at Center.", repo.ApplicationUnderTest.OnboardingIframe.TxtLastNameInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.OnboardingIframe.TxtLastName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EmployeeLastName' with focus on 'ApplicationUnderTest.OnboardingIframe.TxtLastName'.", repo.ApplicationUnderTest.OnboardingIframe.TxtLastNameInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.OnboardingIframe.TxtLastName.PressKeys(EmployeeLastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.BtnSearch' at Center.", repo.ApplicationUnderTest.OnboardingIframe.BtnSearchInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.OnboardingIframe.BtnSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(18));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot capture", repo.ApplicationUnderTest.ModalScroll, false, new RecordItemIndex(19));
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.OnboardingIframe.TxtLastName'.", repo.ApplicationUnderTest.OnboardingIframe.TxtLastNameInfo, new RecordItemIndex(20));
            //repo.ApplicationUnderTest.OnboardingIframe.TxtLastName.Element.SetAttributeValue("Value", null);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.TxtFirstName' at Center.", repo.ApplicationUnderTest.OnboardingIframe.TxtFirstNameInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.OnboardingIframe.TxtFirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EmployeeFirstName' with focus on 'ApplicationUnderTest.OnboardingIframe.TxtFirstName'.", repo.ApplicationUnderTest.OnboardingIframe.TxtFirstNameInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.OnboardingIframe.TxtFirstName.PressKeys(EmployeeFirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.BtnSearch' at Center.", repo.ApplicationUnderTest.OnboardingIframe.BtnSearchInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.OnboardingIframe.BtnSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(24));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot capture", repo.ApplicationUnderTest.ModalScroll, false, new RecordItemIndex(25));
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ModalScroll_Screenshot1
        { get { return repo.ApplicationUnderTest.ModalScrollInfo.GetScreenshot1(new Rectangle(316, 39, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ModalScroll_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Maincontent_Screenshot1
        { get { return repo.ApplicationUnderTest.OnboardingIframe.MaincontentInfo.GetScreenshot1(new Rectangle(297, 105, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Maincontent_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}