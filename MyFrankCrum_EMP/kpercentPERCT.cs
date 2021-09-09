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
    ///The kpercentPERCT recording.
    /// </summary>
    [TestModule("88ba1ef3-9a88-4c38-84b3-d013e449e342", ModuleType.Recording, 1)]
    public partial class kpercentPERCT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static kpercentPERCT instance = new kpercentPERCT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public kpercentPERCT()
        {
            EmployeeCalcRule = "Flat Amount";
            DeductionStopDate = "09/25/2021";
            DeductionStartDate = "08/25/2021";
            PrimaryCare = "Yes";
            BenefitStopDate = "09/05/2021";
            ElegibilityDate = "08/26/2021";
            BenefitStartDate = "08/25/2021";
            BenefitStatusValue = "Active";
            RepoURL = "mfcqa01.frankcrum.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static kpercentPERCT Instance
        {
            get { return instance; }
        }

#region Variables

        string _EmployeeCalcRule;

        /// <summary>
        /// Gets or sets the value of variable EmployeeCalcRule.
        /// </summary>
        [TestVariable("da5ac063-c23b-4eb4-9cab-3c55bd27572a")]
        public string EmployeeCalcRule
        {
            get { return _EmployeeCalcRule; }
            set { _EmployeeCalcRule = value; }
        }

        string _DeductionStopDate;

        /// <summary>
        /// Gets or sets the value of variable DeductionStopDate.
        /// </summary>
        [TestVariable("6a2ed5e3-98ed-467e-9987-0814d1f5590e")]
        public string DeductionStopDate
        {
            get { return _DeductionStopDate; }
            set { _DeductionStopDate = value; }
        }

        string _DeductionStartDate;

        /// <summary>
        /// Gets or sets the value of variable DeductionStartDate.
        /// </summary>
        [TestVariable("d3a76548-af2b-4b91-bfd3-1697c55e950d")]
        public string DeductionStartDate
        {
            get { return _DeductionStartDate; }
            set { _DeductionStartDate = value; }
        }

        string _PrimaryCare;

        /// <summary>
        /// Gets or sets the value of variable PrimaryCare.
        /// </summary>
        [TestVariable("f9fdbdf0-b8fe-4f4f-b5c8-cc0aa532d367")]
        public string PrimaryCare
        {
            get { return _PrimaryCare; }
            set { _PrimaryCare = value; }
        }

        string _BenefitStopDate;

        /// <summary>
        /// Gets or sets the value of variable BenefitStopDate.
        /// </summary>
        [TestVariable("0e8a54e4-5341-4690-9a65-68a04c2a9fbb")]
        public string BenefitStopDate
        {
            get { return _BenefitStopDate; }
            set { _BenefitStopDate = value; }
        }

        string _ElegibilityDate;

        /// <summary>
        /// Gets or sets the value of variable ElegibilityDate.
        /// </summary>
        [TestVariable("c092ec42-46ea-496f-9480-bbc716323c6e")]
        public string ElegibilityDate
        {
            get { return _ElegibilityDate; }
            set { _ElegibilityDate = value; }
        }

        string _BenefitStartDate;

        /// <summary>
        /// Gets or sets the value of variable BenefitStartDate.
        /// </summary>
        [TestVariable("184bcf53-cb2d-491c-add8-1eedf05025a7")]
        public string BenefitStartDate
        {
            get { return _BenefitStartDate; }
            set { _BenefitStartDate = value; }
        }

        string _BenefitStatusValue;

        /// <summary>
        /// Gets or sets the value of variable BenefitStatusValue.
        /// </summary>
        [TestVariable("7cb62b09-5ef0-4287-8a3f-509a8aa41170")]
        public string BenefitStatusValue
        {
            get { return _BenefitStatusValue; }
            set { _BenefitStatusValue = value; }
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

            // Benefits Info
            Report.Log(ReportLevel.Info, "Section", "Benefits Info", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PleaseSelect1' at 25;10.", repo.ApplicationUnderTest.PleaseSelect1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.PleaseSelect1.Click("25;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BenefitstatusClick' at 68;19.", repo.ApplicationUnderTest.BenefitstatusClickInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.BenefitstatusClick.Click("68;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BenefitStatusValue' with focus on 'ApplicationUnderTest.BenefitstatusClick'.", repo.ApplicationUnderTest.BenefitstatusClickInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.BenefitstatusClick.EnsureVisible();
            Keyboard.Press(BenefitStatusValue);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BenefitStartDate' at 42;20.", repo.ApplicationUnderTest.BenefitStartDateInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.BenefitStartDate.Click("42;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BenefitStartDate' with focus on 'ApplicationUnderTest.BenefitStartDate'.", repo.ApplicationUnderTest.BenefitStartDateInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.BenefitStartDate.PressKeys(BenefitStartDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EligibilityDate' at 36;18.", repo.ApplicationUnderTest.EligibilityDateInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.EligibilityDate.Click("36;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ElegibilityDate' with focus on 'ApplicationUnderTest.EligibilityDate'.", repo.ApplicationUnderTest.EligibilityDateInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.EligibilityDate.PressKeys(ElegibilityDate);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BenefitStoptDate' at 59;20.", repo.ApplicationUnderTest.BenefitStoptDateInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.BenefitStoptDate.Click("59;20");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BenefitStopDate' with focus on 'ApplicationUnderTest.BenefitStoptDate'.", repo.ApplicationUnderTest.BenefitStoptDateInfo, new RecordItemIndex(10));
            //repo.ApplicationUnderTest.BenefitStoptDate.PressKeys(BenefitStopDate);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PRIMARY_CARE_PHYSICIAN_' at 44;19.", repo.ApplicationUnderTest.PRIMARY_CARE_PHYSICIAN_Info, new RecordItemIndex(11));
            repo.ApplicationUnderTest.PRIMARY_CARE_PHYSICIAN_.Click("44;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PrimaryCare' with focus on 'ApplicationUnderTest.PRIMARY_CARE_PHYSICIAN_'.", repo.ApplicationUnderTest.PRIMARY_CARE_PHYSICIAN_Info, new RecordItemIndex(12));
            repo.ApplicationUnderTest.PRIMARY_CARE_PHYSICIAN_.PressKeys(PrimaryCare);
            Delay.Milliseconds(0);
            
            // Payroll
            Report.Log(ReportLevel.Info, "Section", "Payroll", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeductionStartDate1' at 66;18.", repo.ApplicationUnderTest.DeductionStartDate1Info, new RecordItemIndex(14));
            repo.ApplicationUnderTest.DeductionStartDate1.Click("66;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DeductionStartDate' with focus on 'ApplicationUnderTest.DeductionStartDate1'.", repo.ApplicationUnderTest.DeductionStartDate1Info, new RecordItemIndex(15));
            repo.ApplicationUnderTest.DeductionStartDate1.PressKeys(DeductionStartDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DeductionStopDate1' at 41;17.", repo.ApplicationUnderTest.DeductionStopDate1Info, new RecordItemIndex(16));
            repo.ApplicationUnderTest.DeductionStopDate1.Click("41;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DeductionStopDate' with focus on 'ApplicationUnderTest.DeductionStopDate1'.", repo.ApplicationUnderTest.DeductionStopDate1Info, new RecordItemIndex(17));
            repo.ApplicationUnderTest.DeductionStopDate1.PressKeys(DeductionStopDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PleaseSelect2' at 16;10.", repo.ApplicationUnderTest.PleaseSelect2Info, new RecordItemIndex(18));
            repo.ApplicationUnderTest.PleaseSelect2.Click("16;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EmployeeCalcRule' with focus on 'ApplicationUnderTest.PleaseSelect2'.", repo.ApplicationUnderTest.PleaseSelect2Info, new RecordItemIndex(19));
            repo.ApplicationUnderTest.PleaseSelect2.PressKeys(EmployeeCalcRule);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{return}' with focus on 'ApplicationUnderTest.PleaseSelect2'.", repo.ApplicationUnderTest.PleaseSelect2Info, new RecordItemIndex(20));
            repo.ApplicationUnderTest.PleaseSelect2.PressKeys("{return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
