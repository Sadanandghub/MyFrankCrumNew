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
    ///The Document_Tax_Forms recording.
    /// </summary>
    [TestModule("57c15f69-b193-4def-955c-8d6a7e519102", ModuleType.Recording, 1)]
    public partial class Document_Tax_Forms : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Document_Tax_Forms instance = new Document_Tax_Forms();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Document_Tax_Forms()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Document_Tax_Forms Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TaxForms' at 27;9.", repo.ApplicationUnderTest.TaxFormsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TaxForms.Click("27;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OnboardingIframe.Here' at 22;14.", repo.ApplicationUnderTest.OnboardingIframe.HereInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.OnboardingIframe.Here.Click("22;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TaxWithholdingEstimatorInternalRev.TaxWithholdingEstimatorInternalRev' at 38;17.", repo.TaxWithholdingEstimatorInternalRev.TaxWithholdingEstimatorInternalRevInfo, new RecordItemIndex(3));
            repo.TaxWithholdingEstimatorInternalRev.TaxWithholdingEstimatorInternalRev.Click("38;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Click here ..  next tab screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TaxWithholdingEstimatorInternalRev.Close' at 8;16.", repo.TaxWithholdingEstimatorInternalRev.CloseInfo, new RecordItemIndex(6));
            repo.TaxWithholdingEstimatorInternalRev.Close.Click("8;16");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}