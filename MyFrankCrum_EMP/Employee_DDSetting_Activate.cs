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
    ///The Employee_DDSetting_Activate recording.
    /// </summary>
    [TestModule("64afa828-564e-448f-85f0-1b14cb3f6703", ModuleType.Recording, 1)]
    public partial class Employee_DDSetting_Activate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employee_DDSetting_Activate instance = new Employee_DDSetting_Activate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employee_DDSetting_Activate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employee_DDSetting_Activate Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FlexRow1.FlexRow' at 561;5.", repo.ApplicationUnderTest.FlexRow1.FlexRowInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FlexRow1.FlexRow.Click("561;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FlexRow1.Inactive' at 21;13.", repo.ApplicationUnderTest.FlexRow1.InactiveInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FlexRow1.Inactive.Click("21;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton1' at 22;24.", repo.ApplicationUnderTest.DropdownMenuButton1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.DropdownMenuButton1.Click("22;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FlexRow1.ActivateAccount' at 48;17.", repo.ApplicationUnderTest.FlexRow1.ActivateAccountInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.FlexRow1.ActivateAccount.Click("48;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ModalWrapper.Activate' at 56;21.", repo.ApplicationUnderTest.ModalWrapper.ActivateInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ModalWrapper.Activate.Click("56;21");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
