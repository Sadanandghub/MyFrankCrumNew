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
    ///The EmployeeSearch recording.
    /// </summary>
    [TestModule("110e71eb-f56f-456d-b86d-bbf4a2d9ad97", ModuleType.Recording, 1)]
    public partial class EmployeeSearch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static EmployeeSearch instance = new EmployeeSearch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmployeeSearch()
        {
            CompanyID = "90936";
            EmployeeStatus = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmployeeSearch Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompanyID;

        /// <summary>
        /// Gets or sets the value of variable CompanyID.
        /// </summary>
        [TestVariable("6a7bfb91-f09e-4004-bae0-34132d57bdac")]
        public string CompanyID
        {
            get { return _CompanyID; }
            set { _CompanyID = value; }
        }

        string _EmployeeStatus;

        /// <summary>
        /// Gets or sets the value of variable EmployeeStatus.
        /// </summary>
        [TestVariable("cbb90330-60ce-4265-ae9f-eb8e645dc834")]
        public string EmployeeStatus
        {
            get { return _EmployeeStatus; }
            set { _EmployeeStatus = value; }
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$EmployeeStatus' on item 'ApplicationUnderTest.OnboardingIframe.DdlStatus'.", repo.ApplicationUnderTest.OnboardingIframe.DdlStatusInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.OnboardingIframe.DdlStatus.Element.SetAttributeValue("TagValue", EmployeeStatus);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.BtnSearch' at Center.", repo.ApplicationUnderTest.OnboardingIframe.BtnSearchInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.OnboardingIframe.BtnSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
